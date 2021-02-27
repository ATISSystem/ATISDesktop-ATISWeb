
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Timers
Imports System.ComponentModel

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.ExceptionManagement
Imports R2Core.MonetaryCreditSupplySources
Imports R2Core.LoggingManagement
Imports R2Core.BaseStandardClass
Imports R2Core.DateAndTimeManagement
Imports R2Core.SoftwareUserManagement
Imports R2Core.SoftwareUserManagement.Exceptions
Imports R2Core.SecurityAlgorithmsManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2Core.EntityRelationManagement.Exceptions
Imports R2Core.PredefinedMessagesManagement.Exceptions
Imports R2Core.SMSSendAndRecieved
Imports R2Core.SMSSendAndRecieved.Exceptions
Imports R2Core.EntityRelationManagement
Imports R2Core.MobileProcessesManagement.Exceptions

Imports PcPosDll
Imports R2Core.WebProcessesManagement.Exceptions

Namespace MonetarySupply

    ' On All of Location of Code Where UCMonetarySupply Used so ConfigurationIndex must be set to UCConfigurationIndex Property
    ' For Example UCMoneyWalletCharge has ConfigurationIndex Property so send it to UCMonetarySupply

    Public Enum MonetarySupplyResult
        None = 0
        Success = 1
        UnSuccess = 2
    End Enum

    Public Class R2CoreMonetarySupply

        Private _CurrentNSS As R2CoreStandardMonetaryCreditSupplySourceStructure = Nothing
        Private _Amount As Int64
        Public Event MonetarySupplySuccessEvent(TransactionId As Int64, Amount As Int64, SupplyReport As String)
        Public Event MonetarySupplyUnSuccessEvent(TransactionId As Int64, Amount As Int64, SupplyReport As String)
        Private WithEvents _MonetaryCreditSupplySource As R2CoreMonetaryCreditSupplySource = Nothing
        Private WithEvents _MonetarySupplyWatcher As System.Windows.Forms.Timer = New System.Windows.Forms.Timer

        Public Sub New(YourNSS As R2CoreStandardMonetaryCreditSupplySourceStructure, YourAmount As Int64)
            Try
                _CurrentNSS = YourNSS
                _Amount = YourAmount
            Catch ex As Exception
                '_MonetaryCreditSupplySource.Dispose()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub StartSupply()
            Try
                _MonetaryCreditSupplySource = R2CoreMonetaryCreditSupplySourcesManagement.GetMonetaryCreditSupplySourceInstance(_CurrentNSS, _Amount)
                _MonetaryCreditSupplySource.Initialize()
                _MonetaryCreditSupplySource.DoCreditSupply()
                _MonetarySupplyWatcher.Interval = 100
                _MonetarySupplyWatcher.Enabled = True
                _MonetarySupplyWatcher.Start()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub _MonetarySupplyWatcher_Tick(sender As Object, e As EventArgs) Handles _MonetarySupplyWatcher.Tick
            Try
                If _MonetaryCreditSupplySource.MonetaryCreditSupplyResult <> MonetarySupplyResult.None Then
                    _MonetarySupplyWatcher.Enabled = False
                    _MonetarySupplyWatcher.Stop()
                    If _MonetaryCreditSupplySource.MonetaryCreditSupplyResult = MonetarySupplyResult.Success Then
                        RaiseEvent MonetarySupplySuccessEvent(_MonetaryCreditSupplySource.TransactionId, _MonetaryCreditSupplySource.Amount, _MonetaryCreditSupplySource.SupplyReport)
                    Else
                        RaiseEvent MonetarySupplyUnSuccessEvent(_MonetaryCreditSupplySource.TransactionId, _MonetaryCreditSupplySource.Amount, _MonetaryCreditSupplySource.SupplyReport)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

End Namespace

Namespace MonetaryCreditSupplySources

    ' When new MonetaryCreditSupplySource must to add to ApplicationDomain then 
    ' 1-R2primary.dbo.TblMonetaryCreditSupplySources
    ' 2-R2Primary.dbo.TblConfigurationOfComputers for 65 Config
    ' 3-Developmnet of Classes - Inheritance of R2CoreMonetaryCreditSupplySource

    Public MustInherit Class R2CoreMonetaryCreditSupplySources
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Cash As Int64 = 1
        Public Shared ReadOnly Property Pos As Int64 = 2
        Public Shared ReadOnly Property BankWebService As Int64 = 3
    End Class

    Public Class R2CoreStandardMonetaryCreditSupplySourceStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            MCSSId = 0
            MCSSName = String.Empty
            MCSSTitle = String.Empty
            MCSSColor = Color.Navy
            AssemblyDll = String.Empty
            AssemblyPath = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.TrueString
        End Sub

        Public Sub New(ByVal YourMCSSId As Int64, ByVal YourMCSSName As String, ByVal YourMCSSTitle As String, ByVal YourMCSSColor As Color, YourAssemblyPath As String, YourAssemblyDll As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourMCSSId, YourMCSSName)
            MCSSId = YourMCSSId
            MCSSName = YourMCSSName
            MCSSTitle = YourMCSSTitle
            MCSSColor = YourMCSSColor
            AssemblyDll = YourAssemblyDll
            AssemblyPath = YourAssemblyPath
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property MCSSId As Int64
        Public Property MCSSName As String
        Public Property MCSSTitle As String
        Public Property MCSSColor As Color
        Public Property AssemblyDll As String
        Public Property AssemblyPath As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean
    End Class

    Public MustInherit Class R2CoreMonetaryCreditSupplySourcesManagement
        Public Shared Function GetNSSMonetaryCreditSupplySource(YourMCSSId As String) As R2CoreStandardMonetaryCreditSupplySourceStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMonetaryCreditSupplySources Where MCSSId=" & YourMCSSId & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardMonetaryCreditSupplySourceStructure(Ds.Tables(0).Rows(0).Item("MCSSId"), Ds.Tables(0).Rows(0).Item("MCSSName").trim, Ds.Tables(0).Rows(0).Item("MCSSTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("MCSSColor").trim), Ds.Tables(0).Rows(0).Item("AssemblyPath").trim, Ds.Tables(0).Rows(0).Item("AssemblyDll").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetMonetaryCreditSupplySources() As List(Of R2CoreStandardMonetaryCreditSupplySourceStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMonetaryCreditSupplySources Where ViewFlag=1 and Active=1 and Deleted=0 ", 3600, DS)
                Dim Lst As New List(Of R2CoreStandardMonetaryCreditSupplySourceStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardMonetaryCreditSupplySourceStructure(DS.Tables(0).Rows(Loopx).Item("MCSSId"), DS.Tables(0).Rows(Loopx).Item("MCSSName").trim, DS.Tables(0).Rows(Loopx).Item("MCSSTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("MCSSColor").trim), DS.Tables(0).Rows(Loopx).Item("AssemblyPath").trim, DS.Tables(0).Rows(Loopx).Item("AssemblyDll").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetThisComputerDefaultNSS(YourConfigurationIndex As Int16) As R2CoreStandardMonetaryCreditSupplySourceStructure
            Try
                Dim ConfigValue As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.MonetaryCreditSupplySources, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, YourConfigurationIndex)
                Return GetNSSMonetaryCreditSupplySource(ConfigValue.Split("@")(0))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetThisComputerCollectionBitMap(YourConfigurationIndex As Int16) As List(Of R2CoreStandardMonetaryCreditSupplySourceStructure)
            Try
                Dim Lst As New List(Of R2CoreStandardMonetaryCreditSupplySourceStructure)
                Dim ConfigValue As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.MonetaryCreditSupplySources, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, YourConfigurationIndex)
                Dim Bitmap() As String = ConfigValue.Split("@")(1).Split("-")
                For Loopx As Int16 = 0 To Bitmap.Count - 1
                    Dim NSS As R2CoreStandardMonetaryCreditSupplySourceStructure = GetNSSMonetaryCreditSupplySource(Bitmap(Loopx).Split(":")(0))
                    NSS.Active = Bitmap(Loopx).Split(":")(1)
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetMonetaryCreditSupplySourceInstance(YourNSS As R2CoreStandardMonetaryCreditSupplySourceStructure, YourAmount As Int64) As R2CoreMonetaryCreditSupplySource
            Try
                Dim AssemblyClassName As String = YourNSS.AssemblyPath
                Dim Instance As Object = Activator.CreateInstance(Type.GetType(AssemblyClassName), New Object() {YourAmount})
                Return Instance
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public MustInherit Class R2CoreMonetaryCreditSupplySource
        Protected _DateTime As R2DateTime = New R2DateTime

        Public Sub New(YourAmount As Int64)
            Try
                _Amount = YourAmount
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Protected _Amount As Int64 = 0
        <Browsable(False)>
        Public ReadOnly Property Amount As Int64
            Get
                Return _Amount
            End Get
        End Property

        Protected _SupplyReport As String = String.Empty
        <Browsable(False)>
        Public ReadOnly Property SupplyReport As String
            Get
                Return _SupplyReport
            End Get
        End Property


        Protected _TransactionId As Int64 = 0
        <Browsable(False)>
        Public ReadOnly Property TransactionId As Int64
            Get
                Return _TransactionId
            End Get
        End Property

        Protected _MonetaryCreditSupplyResult As MonetarySupply.MonetarySupplyResult = MonetarySupply.MonetarySupplyResult.None
        <Browsable(False)>
        Public ReadOnly Property MonetaryCreditSupplyResult As MonetarySupply.MonetarySupplyResult
            Get
                Return _MonetaryCreditSupplyResult
            End Get
        End Property

        Public MustOverride Sub DoCreditSupply()

        Public MustOverride Sub Initialize()

        Public MustOverride Sub Dispose()


    End Class

    Namespace Cash

        Public Class R2CoreCash
            Inherits MonetaryCreditSupplySources.R2CoreMonetaryCreditSupplySource


            Public Sub New(YourAmount As Int64)
                MyBase.New(YourAmount)
                Try
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Overrides Sub Initialize()

            End Sub

            Public Overrides Sub DoCreditSupply()
                _SupplyReport = "عملیات موفق"
                _TransactionId = Convert.ToUInt64(_DateTime.GetCurrentDateShamsiFull.Replace("/", "") + _DateTime.GetCurrentTime.Replace(":", "") + Int((1000 - 100 + 1) * Rnd() + 100).ToString)
                _MonetaryCreditSupplyResult = MonetarySupply.MonetarySupplyResult.Success
            End Sub

            Public Overrides Sub Dispose()
            End Sub

        End Class

    End Namespace

    Namespace Pos

        Namespace PCPos

            Public Class R2CorePCPos
                Inherits R2CoreMonetaryCreditSupplySource

                Private TargetedPosDevice As PosDevice = New PosDevice
                Public WithEvents _PCPOS As PcPosBusiness = New PcPosBusiness
                Public WithEvents _SearchPos As PcPosDiscovery = New PcPosDiscovery
                Public Event SearchAsyncCompleted(ResultCount As Int16, Description As String)

#Region "General Properties"

                Public ReadOnly Property GetTargetPosIPAddress As String
                    Get
                        Return R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.AttachedPoses, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
                    End Get
                End Property

#End Region

#Region "Subroutins And Functions"

                Public Sub New(YourAmount As Int64)
                    MyBase.New(YourAmount)
                    Try
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

                Private Sub LoggingPosResult(YourPosResult As PosResult)
                    Try
                        Dim DataStruct As DataStruct = GetPosResultComposit(YourPosResult)
                        _TransactionId = DataStruct.Data1
                        R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "پوز - خرید", DataStruct.Data1, DataStruct.Data2, DataStruct.Data3, DataStruct.Data4, DataStruct.Data5, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

                Private Function GetPosResultComposit(YourPosResult As PosResult) As R2Core.BaseStandardClass.DataStruct
                    Try
                        Dim TransactionId As Long = Convert.ToUInt64(_DateTime.GetCurrentDateShamsiFull.Replace("/", "") + _DateTime.GetCurrentTime.Replace(":", "") + Int((1000 - 100 + 1) * Rnd() + 100).ToString)
                        Dim DataStruct As DataStruct = New DataStruct
                        DataStruct.Data1 = TransactionId
                        DataStruct.Data2 = YourPosResult.PcPosStatusCode.ToString + "-" + YourPosResult.PcPosStatus + "-" + YourPosResult.OptionalField + "-" + YourPosResult.Amount
                        DataStruct.Data3 = YourPosResult.ResponseCode + "-" + YourPosResult.Rrn + "-" + YourPosResult.CardNo
                        DataStruct.Data4 = YourPosResult.TerminalId + "-" + YourPosResult.ProcessingCode + "-" + YourPosResult.TransactionNo
                        DataStruct.Data5 = YourPosResult.TransactionDate + "-" + YourPosResult.TransactionTime
                        Return DataStruct
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

                Public Function SearchPCPosAsync()
                    Try
                        _SearchPos.SearchPcPosByIp(100, 2000, GetTargetPosIPAddress)
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

                Private Sub _PCPOS_OnSaleResult(sender As Object, e As PosResult) Handles _PCPOS.OnSaleResult
                    Try
                        LoggingPosResult(e)
                        If e.ResponseCode = "00" Then
                            _SupplyReport = e.PcPosStatus
                            _MonetaryCreditSupplyResult = MonetarySupply.MonetarySupplyResult.Success
                        Else
                            _SupplyReport = "شکست عملیات هنگام ارتباط با دستگاه پوز"
                            _MonetaryCreditSupplyResult = MonetarySupply.MonetarySupplyResult.UnSuccess
                        End If
                    Catch ex As Exception
                        MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

                Private Sub _SearchPos_OnSearchPcPos(sender As Object, e As IEnumerable(Of PosDevice)) Handles _SearchPos.OnSearchPcPos
                    Try
                        If e.Count < 1 Then
                            TargetedPosDevice = Nothing
                            RaiseEvent SearchAsyncCompleted(e.Count, (New Exceptions.PCPosWithTargetIpNotFoundException).Message)
                        Else
                            TargetedPosDevice = e(0)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

#End Region

#Region "Override Methods"
                Public Overrides Sub Initialize()
                    Try
                        TargetedPosDevice.IpAddress = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.AttachedPoses, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
                        TargetedPosDevice.Port = 8888
                        'SearchPCPosAsync()
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try

                End Sub

                Public Overrides Sub DoCreditSupply()
                    Try
                        _PCPOS = New PcPosBusiness
                        _PCPOS.Amount = Amount
                        _PCPOS.RetryTimeOut = New Integer() {1800000, 1800000, 1800000}
                        _PCPOS.ResponseTimeout = New Integer() {1800000, 1800000, 1800000}
                        _PCPOS.Ip = TargetedPosDevice.IpAddress
                        _PCPOS.Port = TargetedPosDevice.Port
                        _PCPOS.ConnectionType = PcPosConnectionType.Lan
                        _PCPOS.AsyncSaleTransaction()
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

                Public Overrides Sub Dispose()
                    Try
                        _PCPOS.Dispose()
                    Catch ex As Exception
                    End Try
                    Try
                        _SearchPos.Dispose()
                    Catch ex As Exception
                    End Try
                End Sub




#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

            End Class

            Namespace Exceptions
                Public Class PCPosWithTargetIpNotFoundException
                    Inherits ApplicationException
                    Public Overrides ReadOnly Property Message As String
                        Get
                            Return "دستگاه پوز آماده نیست و یا ارتباط با آن فعلا مقدور نمی باشد"
                        End Get
                    End Property
                End Class

            End Namespace

        End Namespace

    End Namespace

    Namespace Bank

        Public Class R2CoreBank
            Inherits MonetaryCreditSupplySources.R2CoreMonetaryCreditSupplySource

            Public Sub New(YourAmount As Int64)
                MyBase.New(YourAmount)
                Try
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Overrides Sub Initialize()

            End Sub

            Public Overrides Sub DoCreditSupply()
                _SupplyReport = "عملیات موفق"
                _MonetaryCreditSupplyResult = MonetarySupply.MonetarySupplyResult.Success
            End Sub

            Public Overrides Sub Dispose()
            End Sub


        End Class

    End Namespace

End Namespace

Namespace MonetarySettingTools

    'When new MonetarySettingTool must to add to ApplicationDomain then 
    ' 1-R2primary.dbo.TblMonetarySettingTools
    ' 2-R2Primary.dbo.TblConfigurationOfComputers for 66 Config
    ' 3-Developmnet of Classes - Inheritance of UCMonetarySettingToolInstrument

    Public MustInherit Class R2CoreMonetarySettingTools
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property UserPad As Int64 = 1
        Public Shared ReadOnly Property R2PrimaryWebService As Int64 = 3
    End Class

    Public Class R2CoreStandardMonetarySettingToolStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            MSTId = 0
            MSTName = String.Empty
            MSTTitle = String.Empty
            MSTColor = Color.Navy
            AssemblyDll = String.Empty
            AssemblyPath = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.TrueString
        End Sub

        Public Sub New(ByVal YourMSTId As Int64, ByVal YourMSTName As String, ByVal YourMSTTitle As String, ByVal YourMSTColor As Color, YourAssemblyPath As String, YourAssemblyDll As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourMSTId, YourMSTName)
            MSTId = YourMSTId
            MSTName = YourMSTName
            MSTTitle = YourMSTTitle
            MSTColor = YourMSTColor
            AssemblyDll = YourAssemblyDll
            AssemblyPath = YourAssemblyPath
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property MSTId As Int64
        Public Property MSTName As String
        Public Property MSTTitle As String
        Public Property MSTColor As Color
        Public Property AssemblyDll As String
        Public Property AssemblyPath As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean
    End Class

    Public MustInherit Class R2CoreMonetarySettingToolsManagement
        Public Shared Function GetNSSMonetarySettingTool(YourMSTId As String) As R2CoreStandardMonetarySettingToolStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMonetarySettingTools  Where MSTId=" & YourMSTId & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardMonetarySettingToolStructure(Ds.Tables(0).Rows(0).Item("MSTId"), Ds.Tables(0).Rows(0).Item("MSTName").trim, Ds.Tables(0).Rows(0).Item("MSTTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("MSTColor").trim), Ds.Tables(0).Rows(0).Item("AssemblyPath").trim, Ds.Tables(0).Rows(0).Item("AssemblyDll").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetMonetarySettingTools() As List(Of R2CoreStandardMonetarySettingToolStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMonetarySettingTools Where ViewFlag=1 and Active=1 and Deleted=0", 3600, DS)
                Dim Lst As New List(Of R2CoreStandardMonetarySettingToolStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardMonetarySettingToolStructure(DS.Tables(0).Rows(Loopx).Item("MSTId"), DS.Tables(0).Rows(Loopx).Item("MSTName").trim, DS.Tables(0).Rows(Loopx).Item("MSTTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("MSTColor").trim), DS.Tables(0).Rows(Loopx).Item("AssemblyPath").trim, DS.Tables(0).Rows(Loopx).Item("AssemblyDll").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetThisComputerDefaultNSS(YourConfigurationIndex As Int16) As R2CoreStandardMonetarySettingToolStructure
            Try
                Dim ConfigValue As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.MonetarySettingTools, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, YourConfigurationIndex)
                Return GetNSSMonetarySettingTool(ConfigValue.Split("@")(0))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetThisComputerCollectionBitMap(YourConfigurationIndex As Int16) As List(Of R2CoreStandardMonetarySettingToolStructure)
            Try
                Dim Lst As New List(Of R2CoreStandardMonetarySettingToolStructure)
                Dim ConfigValue As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.MonetarySettingTools, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, YourConfigurationIndex)
                Dim Bitmap() As String = ConfigValue.Split("@")(1).Split("-")
                For Loopx As Int16 = 0 To Bitmap.Count - 1
                    Dim NSS As R2CoreStandardMonetarySettingToolStructure = GetNSSMonetarySettingTool(Bitmap(Loopx).Split(":")(0))
                    NSS.Active = Bitmap(Loopx).Split(":")(1)
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetMonetarySettingToolInstrumentInstance(YourNSS As R2CoreStandardMonetarySettingToolStructure) As Object
            Try
                Dim PathDll As String = Application.StartupPath + "\" + YourNSS.AssemblyDll.Trim
                Dim Assembly_ As Assembly = Assembly.LoadFrom(PathDll)
                Dim ProjAndForm As String = YourNSS.AssemblyPath.Trim()
                Dim FormInstanceType = Assembly_.GetType(ProjAndForm)
                Dim objForm = CType(Activator.CreateInstance(FormInstanceType), Object)
                Return objForm
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

End Namespace

Namespace SecurityAlgorithmsManagement


    Public Class ExchangeKey
        Public Sub New()
            ExchangeKey = Int64.MinValue
            UserId = Int64.MinValue
            StartDateTime = Now
        End Sub

        Public Sub New(YourExchangeKey As Int64, YourUserId As Int64, YourStartDateTime As DateTime)
            ExchangeKey = YourExchangeKey
            UserId = YourUserId
            StartDateTime = YourStartDateTime
        End Sub

        Public ExchangeKey As Int64
        Public UserId As Int64
        Public StartDateTime As DateTime
    End Class

    Public Class ExchangeKeyManager

        Private _LstUsers As List(Of ExchangeKey) = New List(Of ExchangeKey)

        Public Sub New()
        End Sub

        Public Function Login(YourUserShenaseh As String, YourUserPassword As String) As Int64
            Try
                R2CoreMClassSoftwareUsersManagement.AuthenticationUserbyShenasehPassword(New R2CoreStandardSoftwareUserStructure(Nothing, Nothing, YourUserShenaseh, YourUserPassword, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                Dim NSS = R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserShenaseh, YourUserPassword)
                If _LstUsers.Exists(Function(x) x.UserId = NSS.UserId) Then
                    _LstUsers.Where(Function(x) x.UserId = NSS.UserId)(0).StartDateTime = Now
                    Return _LstUsers.Where(Function(x) x.UserId = NSS.UserId)(0).ExchangeKey
                End If
                Dim EKTemp = R2CoreMClassSecurityAlgorithmsManagement.GetNewExchangeKey()
                _LstUsers.Add(New ExchangeKey(EKTemp, NSS.UserId, Now))
                Return EKTemp
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub AuthenticationExchangeKey(YourExchangeKey As Int64)
            Try
                If _LstUsers.Exists(Function(x) x.ExchangeKey = YourExchangeKey) Then
                    If DateDiff(DateInterval.Minute, _LstUsers.Where(Function(x) x.ExchangeKey = YourExchangeKey)(0).StartDateTime, Now) <= 1 Then
                    Else
                        _LstUsers.Remove(_LstUsers.Where(Function(x) x.ExchangeKey = YourExchangeKey)(0))
                        Throw New ExchangeKeyTimeRangePassedException
                    End If
                Else
                    Throw New ExchangeKeyNotExistException
                End If
            Catch ex As ExchangeKeyTimeRangePassedException
                Throw ex
            Catch ex As ExchangeKeyNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSUser(YourExchangeKey As Int64) As R2CoreStandardSoftwareUserStructure
            Try
                AuthenticationExchangeKey(YourExchangeKey)
                Return R2CoreMClassSoftwareUsersManagement.GetNSSUser(_LstUsers.Where(Function(x) x.ExchangeKey = YourExchangeKey)(0).UserId)
            Catch ex As ExchangeKeyTimeRangePassedException
                Throw ex
            Catch ex As ExchangeKeyNotExistException
                Throw ex
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class R2CoreMClassSecurityAlgorithmsManagement
        Public Shared Function GetNewExchangeKey() As Int64
            Try
                Dim RandGen As New Random
                Return RandGen.Next(10000, 1000000)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class ExchangeKeyNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کلید تبادل مورد نظر نامعتبر نیست"
                End Get
            End Property
        End Class

        Public Class ExchangeKeyTimeRangePassedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مدت زمان مجاز به پایان رسیده است"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace PredefinedMessagesManagement

    Public MustInherit Class R2CorePredefinedMessages
        Public Shared ReadOnly None As Int64 = 0
    End Class

    Public Class R2CoreStandardPredefinedMessageStructure

        Public Sub New()
            MyBase.New()
            MsgId = Int64.MinValue
            MsgName = String.Empty
            MsgTitle = String.Empty
            MsgContent = String.Empty
            InputLanguageType = Int16.MinValue
            MsgColor = Color.White
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            Active = Boolean.FalseString
            ViewFlag = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourMsgId As Int64, YourMsgName As String, YourMsgTitle As String, YourMsgContent As String, YourInputLanguageType As Int16, YourMsgColor As Color, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourActive As Boolean, YourViewFlag As Boolean, YourDeleted As Boolean)
            MyBase.New()
            MsgId = YourMsgId
            MsgName = YourMsgName
            MsgTitle = YourMsgTitle
            MsgContent = YourMsgContent
            InputLanguageType = YourInputLanguageType
            MsgColor = YourMsgColor
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            Active = YourActive
            ViewFlag = YourViewFlag
            Deleted = YourDeleted
        End Sub

        Public Property MsgId As Int64
        Public Property MsgName As String
        Public Property MsgTitle As String
        Public Property MsgContent As String
        Public Property InputLanguageType As Int16
        Public Property MsgColor As Color
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Active As Boolean
        Public Property ViewFlag As Boolean
        Public Property Deleted As Boolean

    End Class

    Public NotInheritable Class R2CoreMClassPredefinedMessagesManagement

        Public Shared Function GetNSS(YourMSGId As Int64) As R2CoreStandardPredefinedMessageStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblPredefinedMessages Where MsgId  = " & YourMSGId & " And Deleted=0", 3600, Ds).GetRecordsCount() = 0 Then Throw New PredefinedMessageNotFoundException
                Dim NSS = New R2CoreStandardPredefinedMessageStructure
                NSS.MsgId = Ds.Tables(0).Rows(0).Item("MsgId")
                NSS.MsgName = Ds.Tables(0).Rows(0).Item("MsgName").trim
                NSS.MsgTitle = Ds.Tables(0).Rows(0).Item("MsgTitle").trim
                NSS.MsgContent = Ds.Tables(0).Rows(0).Item("MsgContent").trim
                NSS.InputLanguageType = Ds.Tables(0).Rows(0).Item("InputLanguageType")
                NSS.MsgColor = Color.FromName(Ds.Tables(0).Rows(0).Item("MsgColor").trim)
                NSS.UserId = Ds.Tables(0).Rows(0).Item("UserId")
                NSS.DateTimeMilladi = Ds.Tables(0).Rows(0).Item("DateTimeMilladi")
                NSS.DateShamsi = Ds.Tables(0).Rows(0).Item("DateShamsi").trim
                NSS.ViewFlag = Ds.Tables(0).Rows(0).Item("ViewFlag")
                NSS.Active = Ds.Tables(0).Rows(0).Item("Active")
                NSS.Deleted = Ds.Tables(0).Rows(0).Item("Deleted")
                Return NSS
            Catch ex As PredefinedMessageNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Function



    End Class

    Namespace Exceptions
        Public Class PredefinedMessageNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "پیام از پیش تعریف شده ای با کد شاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class


    End Namespace

End Namespace

Namespace EntityManagement

    Public MustInherit Class R2CoreEntities
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly SoftwareUsers As Int64 = 1
        Public Shared ReadOnly MobileProcesses As Int64 = 2
    End Class

    Public Class R2StandardEntityRelationTypeStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            EntId = Int64.MinValue
            EntName = String.Empty
            EntTitle = String.Empty
            TargetTable = String.Empty
            EntColor = Color.White
            IdFieldName = String.Empty
            TitleFieldName = String.Empty
            OrderFieldName = String.Empty
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourEntId As Int64, YourEntName As String, YourEntTitle As String, YourTargetTable As String, YourEntColor As Color, YourIdFieldName As String, YourTitleFieldName As String, YourOrderFieldName As String, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourEntId, YourEntName)
            EntId = YourEntId
            EntName = YourEntName
            EntTitle = YourEntTitle
            TargetTable = YourTargetTable
            EntColor = YourEntColor
            IdFieldName = YourIdFieldName
            TitleFieldName = YourTitleFieldName
            OrderFieldName = YourOrderFieldName
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property EntId As Int64
        Public Property EntName As String
        Public Property EntTitle As String
        Public Property TargetTable As String
        Public Property EntColor As Color
        Public Property IdFieldName As String
        Public Property TitleFieldName As String
        Public Property OrderFieldName As String
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean
    End Class


End Namespace

Namespace EntityRelationManagement

    Public Enum RelationDeactiveTypes
        None = 0
        E1Deactive = 1
        E2Deactive = 2
        BothDeactive = 3
    End Enum

    Public MustInherit Class R2CoreEntityRelationTypes
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly SoftwareUser_MobileProcessGroup As Int64 = 3
        Public Shared ReadOnly MobileProcessGroup_MobileProcess As Int64 = 4
        Public Shared ReadOnly WebProcessGroup_WebProcess As Int64 = 5
        Public Shared ReadOnly SoftwareUser_WebProcessGroup As Int64 = 6

    End Class

    Public Class R2StandardEntityRelationTypeStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            _ERTypeId = Int64.MinValue
            _ERTypeName = String.Empty
            _ERTypeTitle = String.Empty
            _Color = Color.Empty
            _Core = String.Empty
            _UserId = Int64.MinValue
            _DateTimeMilladi = Now
            _DateShamsi = String.Empty
            _ViewFlag = Boolean.FalseString
            _Active = Boolean.FalseString
            _Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourERTypeId As Int64, YourERTypeName As String, YourERTypeTitle As String, YourColor As Color, YourCore As String, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourERTypeId, YourERTypeName)
            _ERTypeId = YourERTypeId
            _ERTypeName = YourERTypeName
            _ERTypeTitle = YourERTypeTitle
            _Color = YourColor
            _Core = YourCore
            _UserId = YourUserId
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Property ERTypeId As Int64
        Public Property ERTypeName As String
        Public Property ERTypeTitle As String
        Public Property Color As Color
        Public Property Core As String
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public Class R2StandardEntityRelationStructure

        Public Sub New()
            MyBase.New()
            _ERId = Int64.MinValue
            _ERTypeId = Int64.MinValue
            _E1 = Int64.MinValue
            _E2 = Int64.MinValue
            _RelationActive = Boolean.FalseString
        End Sub

        Public Sub New(YourERId As Int64, YourERTypeId As Int64, YourE1 As Int64, YourE2 As Int64, YourRelationActive As Boolean)
            MyBase.New()
            _ERId = YourERId
            _ERTypeId = YourERTypeId
            _E1 = YourE1
            _E2 = YourE2
            _RelationActive = YourRelationActive
        End Sub

        Public Property ERId As Int64
        Public Property ERTypeId As Int64
        Public Property E1 As Int64
        Public Property E2 As Int64
        Public Property RelationActive As Boolean

    End Class

    Public NotInheritable Class R2CoreMClassEntityRelationManagement
        Public Shared Function GetNSSEntityRelationType(YourEntityRelationTypeId As Int64) As R2StandardEntityRelationTypeStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblEntityRelationTypes as ERTypes Where ERTypes.ERTypeId=" & YourEntityRelationTypeId & "", 3600, Ds).GetRecordsCount() = 0 Then Throw New EntityRelationTypeNotFoundException
                Dim NSS = New R2StandardEntityRelationTypeStructure
                NSS.ERTypeId = Ds.Tables(0).Rows(0).Item("ERTypeId")
                NSS.ERTypeName = Ds.Tables(0).Rows(0).Item("ERTypeName").TRIM
                NSS.ERTypeTitle = Ds.Tables(0).Rows(0).Item("ERTypeTitle").TRIM
                NSS.Color = Color.FromName(Ds.Tables(0).Rows(0).Item("Color").TRIM)
                NSS.Core = Ds.Tables(0).Rows(0).Item("Core").trim
                NSS.UserId = Ds.Tables(0).Rows(0).Item("UserId")
                NSS.DateTimeMilladi = Ds.Tables(0).Rows(0).Item("DateTimeMilladi")
                NSS.DateShamsi = Ds.Tables(0).Rows(0).Item("DateShamsi").TRIM
                NSS.ViewFlag = Ds.Tables(0).Rows(0).Item("ViewFlag")
                NSS.Active = Ds.Tables(0).Rows(0).Item("Active")
                NSS.Deleted = Ds.Tables(0).Rows(0).Item("Deleted")
                Return NSS
            Catch ex As EntityRelationTypeNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSEntityRelation(YourEntityRelationId As Int64) As R2StandardEntityRelationStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblEntityRelations as ERs Where ERs.ERId=" & YourEntityRelationId & "", 1, Ds).GetRecordsCount() = 0 Then Throw New EntityRelationNotFoundException
                Dim NSS = New R2StandardEntityRelationStructure
                NSS.ERId = Ds.Tables(0).Rows(0).Item("ERId")
                NSS.ERTypeId = Ds.Tables(0).Rows(0).Item("ERTypeId")
                NSS.E1 = Ds.Tables(0).Rows(0).Item("E1")
                NSS.E2 = Ds.Tables(0).Rows(0).Item("E2")
                NSS.RelationActive = Ds.Tables(0).Rows(0).Item("RelationActive")
                Return NSS
            Catch ex As EntityRelationNotFoundException

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function RegisteringEntityRelation(YourNSSEntityRelation As R2StandardEntityRelationStructure, YourDeactive As RelationDeactiveTypes) As Int64
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                If YourDeactive = RelationDeactiveTypes.E1Deactive Then
                    CmdSql.CommandText = "Update R2Primary.dbo.TblEntityRelations Set RelationActive=0 Where E1=" & YourNSSEntityRelation.E1 & " and ERTypeId=" & YourNSSEntityRelation.ERTypeId & ""
                ElseIf YourDeactive = RelationDeactiveTypes.E2Deactive Then
                    CmdSql.CommandText = "Update R2Primary.dbo.TblEntityRelations Set RelationActive=0 Where E2=" & YourNSSEntityRelation.E2 & " and ERTypeId=" & YourNSSEntityRelation.ERTypeId & ""
                ElseIf YourDeactive = RelationDeactiveTypes.BothDeactive Then
                    CmdSql.CommandText = "Update R2Primary.dbo.TblEntityRelations Set RelationActive=0 Where (E1=" & YourNSSEntityRelation.E1 & " or E2=" & YourNSSEntityRelation.E2 & ") and ERTypeId=" & YourNSSEntityRelation.ERTypeId & ""
                ElseIf YourDeactive = RelationDeactiveTypes.None Then
                End If
                CmdSql.ExecuteNonQuery()

                CmdSql.CommandText = "Select Top 1 ERId From R2Primary.dbo.TblEntityRelations With (tablockx) Order By ERId Desc"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Select IDENT_CURRENT('R2Primary.dbo.TblEntityRelations') "
                Dim ERIdNew As Int64 = CmdSql.ExecuteScalar() + 1
                CmdSql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive) Values(" & YourNSSEntityRelation.ERTypeId & "," & YourNSSEntityRelation.E1 & "," & YourNSSEntityRelation.E2 & ",1)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Return ERIdNew
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSEntityRelation(YourERTypeId As Int64, YourERId1 As Int64, YourERId2 As Int64) As R2StandardEntityRelationStructure
            Try
                Dim Ds As DataSet
                If YourERId1 = Int64.MinValue Then
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 ERId from R2Primary.dbo.TblEntityRelations as ERs Where ERs.E2=" & YourERId2 & " and ERs.ERTypeId=" & YourERTypeId & " and RelationActive=1 Order By ERId Desc", 0, Ds).GetRecordsCount() = 0 Then Throw New EntityRelationNotFoundException
                    Return GetNSSEntityRelation(Ds.Tables(0).Rows(0).Item("ERId"))
                ElseIf YourERId2 = Int64.MinValue Then
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 ERId from R2Primary.dbo.TblEntityRelations as ERs Where ERs.E1=" & YourERId1 & " and ERs.ERTypeId=" & YourERTypeId & " and RelationActive=1 Order By ERId Desc", 0, Ds).GetRecordsCount() = 0 Then Throw New EntityRelationNotFoundException
                    Return GetNSSEntityRelation(Ds.Tables(0).Rows(0).Item("ERId"))
                Else
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 ERId from R2Primary.dbo.TblEntityRelations as ERs Where ERs.E1=" & YourERId1 & " and ERs.E2=" & YourERId2 & " ERs.ERTypeId=" & YourERTypeId & " and RelationActive=1 Order By ERId Desc", 0, Ds).GetRecordsCount() = 0 Then Throw New EntityRelationNotFoundException
                    Return GetNSSEntityRelation(Ds.Tables(0).Rows(0).Item("ERId"))
                End If
            Catch ex As EntityRelationNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function RegisteringEntityRelations(YourEntityRelationTypeId As Int64, YourE1Id As Int64, YourE2Ids As String()) As Int64
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Cmdsql.Connection.Open()
                Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
                For Loopx As Int64 = 0 To YourE2Ids.Count - 1
                    Cmdsql.CommandText = "Select Top 1 ERId From R2Primary.dbo.TblEntityRelations With (tablockx) Order By ERId Desc"
                    Cmdsql.ExecuteNonQuery()
                    Dim ERIdNew As Int64 = Cmdsql.ExecuteScalar() + 1
                    Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive)
                                          Values(" & YourEntityRelationTypeId & "," & YourE1Id & "," & YourE2Ids(Loopx) & ",1)"
                    Cmdsql.ExecuteNonQuery()
                Next
                Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then
                    Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class EntityRelationTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع رابطه نهادی با شماره شاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

        Public Class EntityRelationNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "رابطه نهادی با شماره شاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace PermissionManagement

    Public MustInherit Class R2CorePermissionTypes
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly SoftwareUsersAccessMobileProcesses As Int64 = 1
        Public Shared ReadOnly SoftwareUsersAccessWebProcesses As Int64 = 2
    End Class

    Public Class R2StandardPermissionTypeStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            PTId = Int64.MinValue
            PTName = String.Empty
            PTTitle = String.Empty
            PTColor = Color.White
            EntityTableId1 = Int64.MinValue
            EntityTableId2 = Int64.MinValue
            Description = String.Empty
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourPTId As Int64, YourPTName As String, YourPTTitle As String, YourPTColor As Color, YourEntityTableId1 As Int64, YourEntityTableId2 As Int64, YourDescription As String, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourPTId, YourPTName)
            PTId = YourPTId
            PTName = YourPTName
            PTTitle = YourPTTitle
            PTColor = YourPTColor
            EntityTableId1 = YourEntityTableId1
            EntityTableId2 = YourEntityTableId2
            Description = YourDescription
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property PTId As Int64
        Public Property PTName As String
        Public Property PTTitle As String
        Public Property PTColor As Color
        Public Property EntityTableId1 As Int64
        Public Property EntityTableId2 As Int64
        Public Property Description As String
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public Class R2StandardPermissionStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            PId = Int64.MinValue
            EntityIdFirst = Int64.MinValue
            EntityIdSecond = Int64.MinValue
            PermissionTypeId = Int64.MinValue
            RelationActive = Boolean.FalseString
        End Sub

        Public Sub New(YourPId As Int64, YourEntityIdFirst As Int64, YourEntityIdSecond As Int64, YourPermissionTypeId As Int64, YourRelationActive As Boolean)
            MyBase.New(YourPId, String.Empty)
            PId = YourPId
            EntityIdFirst = YourEntityIdFirst
            EntityIdSecond = YourEntityIdSecond
            PermissionTypeId = YourPermissionTypeId
            RelationActive = YourRelationActive
        End Sub

        Public Property PId As Int64
        Public Property EntityIdFirst As Int64
        Public Property EntityIdSecond As Int64
        Public Property PermissionTypeId As Int64
        Public Property RelationActive As Boolean

    End Class

    Public NotInheritable Class R2CoreMClassPermissionsManagement

        Public Shared Sub RegisteringPermissions(YourPermissionTypeId As Int64, YourEntityIdFirst As Int64, YourEntityIdsSecond As String())
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Cmdsql.Connection.Open()
                Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
                For Loopx As Int64 = 0 To YourEntityIdsSecond.Count - 1
                    Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblPermissions(EntityIdFirst,EntityIdSecond,PermissionTypeId,RelationActive) 
                                          Values(" & YourEntityIdFirst & "," & YourEntityIdsSecond(Loopx) & "," & YourPermissionTypeId & ",1)"
                    Cmdsql.ExecuteNonQuery()
                Next
                Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then
                    Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function ExistPermission(YourPermissionTypeId As Int64, YourEntityIdFirst As Int64, YourEntityIdSecond As Int64) As Boolean
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                      "Select * from R2Primary.dbo.TblPermissions as Permissions 
                       Where Permissions.PermissionTypeId=" & YourPermissionTypeId & " and Permissions.RelationActive=1 and Permissions.EntityIdFirst=" & YourEntityIdFirst & " and Permissions.EntityIdSecond=" & YourEntityIdSecond & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

End Namespace

Namespace WebProcessesManagement

    Public Class R2StandardWebProcessStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            PId = Int64.MinValue
            PName = String.Empty
            PTitle = String.Empty
            TargetWfProcess = String.Empty
            Description = String.Empty
            PBackColor = Color.Black
            PForeColor = Color.Black
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourPId As Int64, ByVal YourPName As String, ByVal YourPTitle As String, ByVal YourTargetWfProcess As String, ByVal YourDescription As String, YourPBackColor As Color, YourPForeColor As Color, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourPId, YourPName.Trim())
            PId = YourPId
            PName = YourPName
            PTitle = YourPTitle
            TargetWfProcess = YourTargetWfProcess
            Description = YourDescription
            PBackColor = YourPBackColor
            PForeColor = YourPForeColor
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property PId As String
        Public Property PName As String
        Public Property PTitle As String
        Public Property TargetWfProcess As String
        Public Property Description As String
        Public Property PBackColor As Color
        Public Property PForeColor As Color
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean





    End Class

    Public Class R2StandardWebProcessGroupStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            PGId = Int64.MinValue
            PGName = String.Empty
            PGTitle = String.Empty
            PGBackColor = Color.Black
            PGForeColor = Color.Black
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourPGId As Int64, ByVal YourPGName As String, ByVal YourPGTitle As String, YourPGBackColor As Color, YourPGForeColor As Color, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourPGId, YourPGName.Trim())
            PGId = YourPGId
            PGName = YourPGName
            PGTitle = YourPGTitle
            PGBackColor = YourPGBackColor
            PGForeColor = YourPGForeColor
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property PGId As String
        Public Property PGName As String
        Public Property PGTitle As String
        Public Property PGBackColor As Color
        Public Property PGForeColor As Color
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean





    End Class

    Public MustInherit Class R2CoreWebProcessGroups
    End Class

    Public NotInheritable Class R2CoreMClassWebProcessesManagement
        Public Shared Function GetWebProcesses(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As List(Of R2StandardWebProcessStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                 "Select WebProcesses.* 
                   from R2Primary.dbo.TblSoftwareUsers as SoftwareUser
                     Inner Join R2Primary.dbo.TblEntityRelations as SoftwareUserWebProcessGroup On SoftwareUser.UserId=SoftwareUserWebProcessGroup.E1 
                     Inner Join R2Primary.dbo.TblWebProcessGroups as WebProcessGroup On SoftwareUserWebProcessGroup.E2=WebProcessGroup.PGId 
                     Inner Join R2Primary.dbo.TblEntityRelations as WebProcessGroupWebProcess On WebProcessGroup.PGId=WebProcessGroupWebProcess.E1  
                     Inner Join R2Primary.dbo.TblWebProcesses as WebProcesses On WebProcessGroupWebProcess.E2=WebProcesses.PId 
                   Where SoftwareUser.UserId=" & YourNSSSoftwareUser.UserId & " and SoftwareUser.UserActive=1 and SoftwareUser.Deleted=0 and SoftwareUserWebProcessGroup.ERTypeId=" & R2CoreEntityRelationTypes.SoftwareUser_WebProcessGroup & "
                         and SoftwareUserWebProcessGroup.RelationActive=1 and  WebProcessGroup.ViewFlag=1 and  WebProcessGroup.Active=1 and WebProcessGroup.Deleted=0 and WebProcessGroupWebProcess.ERTypeId=" & R2CoreEntityRelationTypes.WebProcessGroup_WebProcess & "  
                         and WebProcessGroupWebProcess.RelationActive=1 and WebProcesses.ViewFlag=1 and WebProcesses.Active=1 and WebProcesses.Deleted=0 
                   Order By WebProcessGroup.PGId,WebProcesses.PId ", 3600, Ds).GetRecordsCount <> 0 Then
                    Dim Lst As New List(Of R2StandardWebProcessStructure)
                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        Dim NSS As New R2StandardWebProcessStructure
                        NSS.PId = Ds.Tables(0).Rows(Loopx).Item("PId")
                        NSS.PName = Ds.Tables(0).Rows(Loopx).Item("PName")
                        NSS.PTitle = "  " + Ds.Tables(0).Rows(Loopx).Item("PTitle").ToString().Trim
                        NSS.Description = Ds.Tables(0).Rows(Loopx).Item("Description").trim
                        NSS.PForeColor = Color.FromName(Ds.Tables(0).Rows(Loopx).Item("PForeColor").trim)
                        NSS.PBackColor = Color.FromName(Ds.Tables(0).Rows(Loopx).Item("PBackColor").trim)
                        NSS.TargetWfProcess = Ds.Tables(0).Rows(Loopx).Item("TargetWfProcess").trim
                        NSS.UserId = Ds.Tables(0).Rows(Loopx).Item("UserId")
                        NSS.DateTimeMilladi = Ds.Tables(0).Rows(Loopx).Item("DateTimeMilladi")
                        NSS.DateShamsi = Ds.Tables(0).Rows(Loopx).Item("DateShamsi").trim
                        NSS.Active = Ds.Tables(0).Rows(Loopx).Item("Active")
                        NSS.ViewFlag = Ds.Tables(0).Rows(Loopx).Item("ViewFlag")
                        NSS.Deleted = Ds.Tables(0).Rows(Loopx).Item("Deleted")
                        Lst.Add(NSS)
                    Next
                    Return Lst
                Else
                    Throw New SoftwareUserHasNotAnyWebProcessPermissionException
                End If
            Catch exx As SoftwareUserHasNotAnyWebProcessPermissionException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class SoftwareUserHasNotAnyWebProcessPermissionException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مجوز دسترسی به هیچ یک از منوهای سایت را ندارید"
                End Get
            End Property
        End Class


    End Namespace


End Namespace

Namespace MobileProcessesManagement

    Public Class R2StandardMobileProcessStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            PId = Int64.MinValue
            PName = String.Empty
            PTitle = String.Empty
            TargetMobilePage = String.Empty
            Description = String.Empty
            PBackColor = Color.Black
            PForeColor = Color.Black
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourPId As Int64, ByVal YourPName As String, ByVal YourPTitle As String, ByVal YourTargetMobilePage As String, ByVal YourDescription As String, YourPBackColor As Color, YourPForeColor As Color, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourPId, YourPName.Trim())
            PId = YourPId
            PName = YourPName
            PTitle = YourPTitle
            TargetMobilePage = YourTargetMobilePage
            Description = YourDescription
            PBackColor = YourPBackColor
            PForeColor = YourPForeColor
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property PId As String
        Public Property PName As String
        Public Property PTitle As String
        Public Property TargetMobilePage As String
        Public Property Description As String
        Public Property PBackColor As Color
        Public Property PForeColor As Color
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean





    End Class

    Public Class R2StandardMobileProcessGroupStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            PGId = Int64.MinValue
            PGName = String.Empty
            PGTitle = String.Empty
            PGBackColor = Color.Black
            PGForeColor = Color.Black
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourPGId As Int64, ByVal YourPGName As String, ByVal YourPGTitle As String, YourPGBackColor As Color, YourPGForeColor As Color, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourPGId, YourPGName.Trim())
            PGId = YourPGId
            PGName = YourPGName
            PGTitle = YourPGTitle
            PGBackColor = YourPGBackColor
            PGForeColor = YourPGForeColor
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property PGId As String
        Public Property PGName As String
        Public Property PGTitle As String
        Public Property PGBackColor As Color
        Public Property PGForeColor As Color
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean





    End Class

    Public NotInheritable Class R2CoreMClassMobileProcessesManagement

        Public Shared Function GetMobileProcesses(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As List(Of R2StandardMobileProcessStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                             "Select PId,PName,PTitle,TargetMobilePage,Description,PForeColor,PBackColor 
                              from R2Primary.dbo.TblSoftwareUsers as SoftwareUser
                                 Inner Join R2Primary.dbo.TblEntityRelations as SoftwareUserMobileProcessGroup On SoftwareUser.UserId=SoftwareUserMobileProcessGroup.E1 
                                 Inner Join R2Primary.dbo.TblMobileProcessGroups as MobileProcessGroup On SoftwareUserMobileProcessGroup.E2=MobileProcessGroup.PGId 
                                 Inner Join R2Primary.dbo.TblEntityRelations as MobileProcessGroupMobileProcess On MobileProcessGroup.PGId=MobileProcessGroupMobileProcess.E1  
                                 Inner Join R2Primary.dbo.TblMobileProcesses as MobileProcesses On MobileProcessGroupMobileProcess.E2=MobileProcesses.PId 
                              Where SoftwareUser.UserId=" & YourNSSSoftwareUser.UserId & " and SoftwareUser.UserActive=1 and SoftwareUser.Deleted=0 and SoftwareUserMobileProcessGroup.ERTypeId=" & R2CoreEntityRelationTypes.SoftwareUser_MobileProcessGroup & "
                                    and SoftwareUserMobileProcessGroup.RelationActive=1 and  MobileProcessGroup.ViewFlag=1 and  MobileProcessGroup.Active=1 and MobileProcessGroup.Deleted=0 and MobileProcessGroupMobileProcess.ERTypeId=" & R2CoreEntityRelationTypes.MobileProcessGroup_MobileProcess & " 
                                    and MobileProcessGroupMobileProcess.RelationActive=1 and MobileProcesses.ViewFlag=1 and MobileProcesses.Active=1 and MobileProcesses.Deleted=0 
                              Order By MobileProcessGroup.PGId,MobileProcesses.PId ", 3600, Ds).GetRecordsCount <> 0 Then
                    Dim Lst As New List(Of R2StandardMobileProcessStructure)
                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        Dim NSS As New R2StandardMobileProcessStructure
                        NSS.PId = Ds.Tables(0).Rows(Loopx).Item("PId")
                        NSS.PName = Ds.Tables(0).Rows(Loopx).Item("PName")
                        NSS.PTitle = "  " + Ds.Tables(0).Rows(Loopx).Item("PTitle").ToString().Trim
                        NSS.TargetMobilePage = Ds.Tables(0).Rows(Loopx).Item("TargetMobilePage").trim
                        NSS.Description = Ds.Tables(0).Rows(Loopx).Item("Description").trim
                        NSS.PForeColor = Color.FromName(Ds.Tables(0).Rows(Loopx).Item("PForeColor").trim)
                        NSS.PBackColor = Color.FromName(Ds.Tables(0).Rows(Loopx).Item("PBackColor").trim)
                        Lst.Add(NSS)
                    Next
                    Return Lst
                Else
                    Throw New SoftwareUserHasNotAnyMobileProcessPermissionException
                End If
            Catch exx As SoftwareUserHasNotAnyMobileProcessPermissionException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function




    End Class

    Namespace Exceptions
        Public Class SoftwareUserHasNotAnyMobileProcessPermissionException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مجوز دسترسی به هیچ یک از منوهای اپلیکیشن را ندارید"
                End Get
            End Property
        End Class


    End Namespace

End Namespace

Namespace SMSSendAndRecieved

    Public Enum SmsSendReciveType
        None = 0
        ForSend = 1
        Recived = 2
    End Enum

    Public Class R2CoreSMSStandardSmsStructure

        Public Sub New()
            MyBase.New()
            SmsId = Int64.MinValue
            MobileNumber = String.Empty
            Message = String.Empty
            EndHours = Int16.MinValue
            DateTimeMilladi = Now.Date
            Active = Boolean.FalseString
            DateShamsi = String.Empty
            Time = String.Empty
        End Sub

        Public Sub New(ByVal YourSmsId As Int64, ByVal YourMobileNumber As String, ByVal YourMessage As String, ByVal YourEndHours As Int16, ByVal YourDateTimeMilladi As DateTime, ByVal YourActive As Boolean, ByVal YourDateShamsi As String, ByVal YourTime As String)
            SmsId = YourSmsId
            MobileNumber = YourMobileNumber
            Message = YourMessage
            EndHours = YourEndHours
            DateTimeMilladi = YourDateTimeMilladi
            Active = YourActive
            DateShamsi = YourDateShamsi
            Time = YourTime
        End Sub

        Public Property SmsId As Int64
        Public Property MobileNumber As String
        Public Property Message As String
        Public Property EndHours As Int16
        Public Property DateTimeMilladi As DateTime
        Public Property Active As Boolean
        Public Property DateShamsi As String
        Public Property Time As String
    End Class

    Public Class R2CoreSMSSendRecive

        Private _DateTime As New R2DateTime

        Public Sub New()
            MyBase.New()
            Try
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Sub SendSms(ByVal YourNSS As R2CoreSMSStandardSmsStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                If YourNSS.MobileNumber.Trim.Length <> 11 Then Throw New MobileNumberInvallidException
                If YourNSS.Message.Trim = "" Then Throw New SmsMessageEmptyException
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblSMSWareHouse(MobileNumber,Message,EndHours,DateTimeMilladi,Active,DateShamsi,SmsType) values('" & YourNSS.MobileNumber & "','" & YourNSS.Message & "'," & YourNSS.EndHours & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "',1,'" & _DateTime.GetCurrentDateShamsiFull & "'," & SmsSendReciveType.ForSend & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        'Public Function RecivedSms() As R2StandardSmsRecivedStructure()
        '    Try
        '        DsSmsRecived.Tables.Clear()
        '        DaSmsRecived.Fill(DsSmsRecived)
        '        myNumberOfRecivedSms = DsSmsRecived.Tables(0).Rows.Count
        '        ReDim SmsArray(myNumberOfRecivedSms - 1)
        '        For loopx As Int32 = 0 To myNumberOfRecivedSms - 1
        '            SmsArray(loopx) = New R2StandardSmsRecivedStructure(DsSmsRecived.Tables(0).Rows(loopx).Item("SMSId"), DsSmsRecived.Tables(0).Rows(loopx).Item("Mobile").trim, DsSmsRecived.Tables(0).Rows(loopx).Item("Message").trim, DsSmsRecived.Tables(0).Rows(loopx).Item("EndHours"), DsSmsRecived.Tables(0).Rows(loopx).Item("SabtDateTimeMilladi"), DsSmsRecived.Tables(0).Rows(loopx).Item("Active"), DsSmsRecived.Tables(0).Rows(loopx).Item("SabtDateShamsi"), DsSmsRecived.Tables(0).Rows(loopx).Item("SabtTime"))
        '        Next
        '        Return SmsArray
        '    Catch ex As Exception
        '        Throw New Exception("Sms.RecivedSms()." + ex.Message.ToString)
        '    End Try
        'End Function

        'Public Sub RecivedSmsHandled(ByVal SmsId As Int64)
        '    Dim CmdSql As New SqlClient.SqlCommand
        '    CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
        '    Try
        '        CmdSqlSmsSystem.Connection.Open()
        '        CmdSqlSmsSystem.CommandText = "update TblSmsWareHouse Set Active=0 where SmsId=" & SmsId & ""
        '        CmdSqlSmsSystem.ExecuteNonQuery()
        '        CmdSqlSmsSystem.Connection.Close()
        '    Catch ex As Exception
        '        If CmdSqlSmsSystem.Connection.State <> ConnectionState.Closed Then CmdSqlSmsSystem.Connection.Close()
        '        Throw New Exception("SmsCore.Sms.RecivedSmsHandled()." + ex.Message.ToString)
        '    End Try
        'End Sub




    End Class

    Public MustInherit Class R2CoreSMSMClassSMSDomainManagement

        Private Shared _SepahanSMS As New net.sepahansms.smsSendWebServiceforPHP()
        Private Shared _DateTime As New R2DateTime

        Public Shared Sub SMSDomainSendRecieved()
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                'ارسالی            
                If R2CoreMClassConfigurationManagement.GetConfigBoolean(R2CoreConfigurations.SmsSystemSetting, 0) = True Then
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimarySMSSystem.dbo.TblSmsWareHouse where Active=1 and SmsType=" & SmsSendReciveType.ForSend & "", 0, DS)
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    For Loopx As Int32 = 0 To DS.Tables(0).Rows.Count - 1
                        Dim mySmsId As String = DS.Tables(0).Rows(Loopx).Item("SmsId")
                        If DateDiff(DateInterval.Hour, _DateTime.GetCurrentDateTimeMilladi, Convert.ToDateTime(DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"))) <= DS.Tables(0).Rows(Loopx).Item("EndHours") Then
                            Dim myMessage As String = DS.Tables(0).Rows(Loopx).Item("message").trim
                            Dim myMobilenumber As String = DS.Tables(0).Rows(Loopx).Item("mobilenumber").trim
                            Dim SmsId() As Long = _SepahanSMS.SendSms("Biinfo878", "3800000", "sepahansms", New String() {myMessage}, New String() {myMobilenumber}, "30006403868611",
                                                     net.sepahansms.SendType.DynamicText, net.sepahansms.SmsMode.SaveInPhone)
                            If SmsId(0) > 0 Then
                                CmdSql.CommandText = "Update  R2PrimarySMSSystem.dbo.TblSmsWareHouse Set Active=0 where SmsId=" & mySmsId & ""
                                CmdSql.ExecuteNonQuery()
                            End If
                        Else
                            CmdSql.CommandText = "Update  R2PrimarySMSSystem.dbo.TblSmsWareHouse Set Active=0 where SmsId=" & mySmsId & ""
                            CmdSql.ExecuteNonQuery()
                        End If
                    Next
                Else
                    Throw New SmsSystemIsDisabledException
                End If


                ''دریافتی
                'ReDim ReceiveSmsOneLine(10)
                'ReceiveSmsOneLine = SepahanSMS.GetReceiveSMSWithNumber(com.sepahansms.www.ReceiveType.UnRead, "30006016635245", Nothing, "", "")
                'If ReceiveSmsOneLine.Length = 0 Then
                '    EventLog.WriteEntry("SmsServiceSource", "ReceiveSmsOneLine.Length = 0", EventLogEntryType.Information)
                '    Exit Try
                'End If
                'CmdSqlSmsSystem.CommandText = "select top 1 smsid from TblSmsWareHouse order by smsid desc"
                'Dim mySmsIdStart As Int32 = CmdSqlSmsSystem.ExecuteScalar + 1
                'For loopx As Int32 = 0 To ReceiveSmsOneLine.Length - 1
                '    Dim SmsText As String = ReceiveSmsOneLine(loopx).SmsText
                '    If SmsText.Trim <> "" Then
                '        Dim myMobile As String = ReceiveSmsOneLine(loopx).FromNumber
                '        Dim myDate As String = ReceiveSmsOneLine(loopx).Date
                '        Dim myMessage As String = ReceiveSmsOneLine(loopx).SmsText
                '        If ((myMessage = "Biinfo878*03*0") Or (myMessage = "Biinfo878*03*1")) And (myMobile = SmsSystemConfiguration.GetSmsSystemGeneralNumber) Then
                '            If myMessage = "Biinfo878*03*0" Then mySendSmsStatus = False
                '            If myMessage = "Biinfo878*03*1" Then mySendSmsStatus = True
                '        Else
                '            CmdSqlSmsSystem.CommandText = "insert into TblSmsWareHouse(SmsId,Mobile,Message,EndHours,SabtDateTimeMilladi,Active,SabtDateShamsi,SabtTime,SmsType) values(" & mySmsIdStart & ",'" & myMobile & "','" & myMessage & "',0,'" & myR2DateTime.GetCurrentDateTimeMilladi.ToString("yyyy-MM-dd HH:mm:ss") & "',1,'" & myDate & "','" & myR2DateTime.GetCurrentTime & "'," & SmsSendReciveType.Recived & ")"
                '            CmdSqlSmsSystem.ExecuteNonQuery()
                '            mySmsIdStart += 1
                '        End If
                '    End If
                'Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As SmsSystemIsDisabledException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Namespace Exceptions

        Public Class MobileNumberInvallidException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شماره موبایل نادرست است"
                End Get
            End Property
        End Class

        Public Class SmsSystemIsDisabledException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "سیستم اس ام اس از طریق جدول پیکربندی غیر فعال است"
                End Get
            End Property
        End Class

        Public Class SmsMessageEmptyException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "در پیام ارسالی متنی وجود ندارد"
                End Get
            End Property
        End Class



    End Namespace

End Namespace

Namespace WhatsAppMessenger

End Namespace
