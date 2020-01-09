
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Timers

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.ExceptionManagement
Imports R2Core.MonetaryCreditSupplySources
Imports R2Core.LoggingManagement
Imports R2Core.BaseStandardClass
Imports R2Core.DateAndTimeManagement
Imports R2Core.UserManagement

Imports PcPosDll



Namespace MonetarySupply

    ' On All of Location of Code Where UCMonetarySupply Used so ConfigurationIndex must be set to UCConfigurationIndex Property
    ' For Example UCMoneyWalletCharge has ConfigurationIndex Property so send it to UCMonetarySupply

    Public Class R2CoreMonetarySupply

        Public Event MonetarySupplySuccessEvent(TransactionId As Int64, Amount As Int64)
        Public Event MonetarySupplyUnSuccessEvent(TransactionId As Int64, Amount As Int64)
        Private WithEvents _MonetaryCreditSupplySource As R2CoreMonetaryCreditSupplySource = Nothing

        Public Sub New(YourNSS As R2CoreStandardMonetaryCreditSupplySourceStructure, YourAmount As Int64)
            Try
                _MonetaryCreditSupplySource = R2CoreMonetaryCreditSupplySourcesManagement.GetMonetaryCreditSupplySourceInstance(YourNSS, YourAmount)
            Catch ex As Exception
                _MonetaryCreditSupplySource.Dispose()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub _MonetaryCreditSupplySource_MonetaryCreditSupplySuccessEvent(TransactionId As Int64, Amount As Int64) Handles _MonetaryCreditSupplySource.MonetaryCreditSupplySuccessEvent
            Try
                _MonetaryCreditSupplySource.Dispose()
                RaiseEvent MonetarySupplySuccessEvent(TransactionId, Amount)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub _MonetaryCreditSupplySource_MonetaryCreditSupplyUnSuccessEvent(TransactionId As Int64, Amount As Int64) Handles _MonetaryCreditSupplySource.MonetaryCreditSupplyUnSuccessEvent
            Try
                _MonetaryCreditSupplySource.Dispose()
                RaiseEvent MonetarySupplyUnSuccessEvent(TransactionId, Amount)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
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

        Public Event MonetaryCreditSupplySuccessEvent(TransactionId As Int64, Amount As Int64)
        Public Event MonetaryCreditSupplyUnSuccessEvent(TransactionId As Int64, Amount As Int64)

        Public Sub New(YourAmount As Int64)
            Try
                Amount = YourAmount
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private _Amount As Int64 = 0
        Public Property Amount As Int64
            Get
                Return _Amount
            End Get
            Set(value As Int64)
                _Amount = value
            End Set
        End Property


        Public MustOverride Sub Dispose()

        Protected Sub OnMonetaryCreditSupplySuccess(YourTransactionId As Int64, YourAmount As Int64)
            Try
                RaiseEvent MonetaryCreditSupplySuccessEvent(YourTransactionId, YourAmount)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Protected Sub OnMonetaryCreditSupplyUnSuccess(YourTransactionId As Int64, YourAmount As Int64)
            Try
                RaiseEvent MonetaryCreditSupplyUnSuccessEvent(YourTransactionId, YourAmount)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Namespace Cash

        Public Class R2CoreCash
            Inherits MonetaryCreditSupplySources.R2CoreMonetaryCreditSupplySource

            Private WithEvents _Timer As New System.Timers.Timer

            Public Sub New(YourAmount As Int64)
                MyBase.New(YourAmount)
                Try
                    _Timer.Interval = 500
                    _Timer.Enabled = True
                    _Timer.Start()
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Overrides Sub Dispose()
                If _Timer IsNot Nothing Then _Timer = Nothing
            End Sub

            Private Sub _Timer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles _Timer.Elapsed
                Try
                    _Timer.Stop()
                    _Timer.Enabled = False
                    _Timer = Nothing
                    OnMonetaryCreditSupplySuccess(Amount, Amount)
                Catch ex As Exception
                    MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

    End Namespace

    Namespace Pos

        Namespace PCPos

            Public Class R2CorePCPos
                Inherits R2CoreMonetaryCreditSupplySource

                Private _DateTime As R2DateTime = New R2DateTime
                Public WithEvents _PCPOS As PcPosBusiness = New PcPosBusiness
                Public WithEvents _SearchPos As PcPosDiscovery = New PcPosDiscovery

#Region "General Properties"

                Public ReadOnly Property GetTargetPosIPAddress As String
                    Get
                        Return R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.AttachedPoses, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
                    End Get
                End Property

                Private Property TransactionId As String = String.Empty

#End Region

#Region "Subroutins And Functions"

                Public Sub New(YourAmount As Int64)
                    MyBase.New(YourAmount)
                    Try
                        _SearchPos.SearchPcPosByIp(100, 2000, GetTargetPosIPAddress)
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

                Private Sub LoggingPosResult(YourPosResult As PosResult)
                    Try
                        Dim DataStruct As DataStruct = GetPosResultComposit(YourPosResult)
                        TransactionId = DataStruct.Data1
                        R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "پوز - خرید", DataStruct.Data1, DataStruct.Data2, DataStruct.Data3, DataStruct.Data4, DataStruct.Data5, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
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
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

                Private Sub _PCPOS_OnSaleResult(sender As Object, e As PosResult) Handles _PCPOS.OnSaleResult
                    Try
                        LoggingPosResult(e)
                        If e.ResponseCode = "00" Then
                            OnMonetaryCreditSupplySuccess(TransactionId, Amount)
                        Else
                            OnMonetaryCreditSupplyUnSuccess(TransactionId, Amount)
                        End If
                    Catch ex As Exception
                        Dispose()
                        MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

                Private Sub _SearchPos_OnSearchPcPos(sender As Object, e As IEnumerable(Of PosDevice)) Handles _SearchPos.OnSearchPcPos
                    Try
                        If e.Count < 1 Then
                            Throw New Exceptions.PCPosWithTargetIpNotFoundException
                        Else
                            _PCPOS = New PcPosBusiness
                            _PCPOS.Amount = Amount
                            _PCPOS.RetryTimeOut = New Integer() {5000, 5000, 5000}
                            _PCPOS.ResponseTimeout = New Integer() {180000, 5000, 5000}
                            _PCPOS.Ip = e(0).IpAddress
                            _PCPOS.Port = e(0).Port
                            _PCPOS.ConnectionType = PcPosConnectionType.Lan
                            _PCPOS.AsyncSaleTransaction()
                            Return
                        End If
                    Catch ex As Exception
                        Dispose()
                        MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Sub

#End Region

#Region "Override Methods"
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

            Private WithEvents _Timer As New System.Timers.Timer

            Public Sub New(YourAmount As Int64)
                MyBase.New(YourAmount)
                Try
                    _Timer.Interval = 6000
                    _Timer.Enabled = True
                    _Timer.Start()
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Overrides Sub Dispose()
                If _Timer IsNot Nothing Then _Timer = Nothing
            End Sub

            Private Sub _Timer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles _Timer.Elapsed
                Try
                    _Timer.Stop()
                    _Timer.Enabled = False
                    _Timer = Nothing
                    OnMonetaryCreditSupplySuccess(Amount, Amount)
                Catch ex As Exception
                    MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
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

