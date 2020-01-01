
Imports System.Drawing
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Reflection
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Imports R2Core.AuthenticationManagement
Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.EntityRelations.Exceptions
Imports R2Core.ExceptionManagement
Imports R2Core.FileShareRawGroupsManagement
Imports R2Core.ProcessesManagement
Imports R2Core.PublicProc
Imports R2Core.R2PrimaryFileSharingWS
Imports R2Core.UserManagement
Imports R2Core.MonetaryCreditSupplySources



Namespace MonetarySupply

    Public Class R2CoreMonetarySupply

        Public Event MonetarySupplySuccessEvent(TransactionId As Int64)
        Public Event MonetarySupplyUnSuccessEvent(TransactionId As Int64)
        Private WithEvents _MonetaryCreditSupplySource As R2CoreMonetaryCreditSupplySource = Nothing

        Public Sub New(YourNSS As R2CoreStandardMonetaryCreditSupplySourceStructure, YourAmount As Int64)
            Try
                _MonetaryCreditSupplySource = R2CoreMonetaryCreditSupplySourcesManagement.GetMonetaryCreditSupplySourceInstance(YourNSS, YourAmount)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub MonetaryCreditSupplySourceInstance_MonetaryCreditSupplySuccessEvent(TransactionId As Int64) Handles _MonetaryCreditSupplySource.MonetaryCreditSupplySuccessEvent
            Try
                RaiseEvent MonetarySupplySuccessEvent(TransactionId)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub MonetaryCreditSupplySourceInstance_MonetaryCreditSupplyUnSuccessEvent(TransactionId As Int64) Handles _MonetaryCreditSupplySource.MonetaryCreditSupplyUnSuccessEvent
            Try
                RaiseEvent MonetarySupplyUnSuccessEvent(TransactionId)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

End Namespace

Namespace MonetaryCreditSupplySources

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
            AssemblyPath = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.TrueString
        End Sub

        Public Sub New(ByVal YourMCSSId As Int64, ByVal YourMCSSName As String, ByVal YourMCSSTitle As String, ByVal YourMCSSColor As Color, YourAssemblyPath As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourMCSSId, YourMCSSName)
            MCSSId = YourMCSSId
            MCSSName = YourMCSSName
            MCSSTitle = YourMCSSTitle
            MCSSColor = YourMCSSColor
            AssemblyPath = YourAssemblyPath
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property MCSSId As Int64
        Public Property MCSSName As String
        Public Property MCSSTitle As String
        Public Property MCSSColor As Color
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
                    Return New R2CoreStandardMonetaryCreditSupplySourceStructure(Ds.Tables(0).Rows(0).Item("MCSSId"), Ds.Tables(0).Rows(0).Item("MCSSName").trim, Ds.Tables(0).Rows(0).Item("MCSSTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("MCSSColor").trim), Ds.Tables(0).Rows(0).Item("AssemblyPath").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
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
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMonetaryCreditSupplySources as MCSSs Where MCSSs.ViewFlag=1 and Active=1 and Deleted=0 ", 3600, DS)
                Dim Lst As New List(Of R2CoreStandardMonetaryCreditSupplySourceStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardMonetaryCreditSupplySourceStructure(DS.Tables(0).Rows(Loopx).Item("MCSSId"), DS.Tables(0).Rows(Loopx).Item("MCSSName").trim, DS.Tables(0).Rows(Loopx).Item("MCSSTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("MCSSColor").trim), DS.Tables(0).Rows(0).Item("AssemblyPath").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
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
                Dim Instance As Object = Activator.CreateInstance(Type.GetType(AssemblyClassName))
                Return Instance
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public Class R2CoreMonetaryCreditSupplySource
        Public Event MonetaryCreditSupplySuccessEvent(TransactionId As Int64)
        Public Event MonetaryCreditSupplyUnSuccessEvent(TransactionId As Int64)
    End Class


End Namespace

Namespace MonetarySettingTools

    Public MustInherit Class R2CoreMonetarySettingTools
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property UserPad As Int64 = 1
        Public Shared ReadOnly Property ExitCarProcess As Int64 = 2
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
            AssemblyPath = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.TrueString
        End Sub

        Public Sub New(ByVal YourMSTId As Int64, ByVal YourMSTName As String, ByVal YourMSTTitle As String, ByVal YourMSTColor As Color, YourAssemblyPath As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourMSTId, YourMSTName)
            MSTId = YourMSTId
            MSTName = YourMSTName
            MSTTitle = YourMSTTitle
            MSTColor = YourMSTColor
            AssemblyPath = YourAssemblyPath
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property MSTId As Int64
        Public Property MSTName As String
        Public Property MSTTitle As String
        Public Property MSTColor As Color
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
                    Return New R2CoreStandardMonetarySettingToolStructure(Ds.Tables(0).Rows(0).Item("MSTId"), Ds.Tables(0).Rows(0).Item("MSTName").trim, Ds.Tables(0).Rows(0).Item("MSTTitle").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("MSTColor").trim), Ds.Tables(0).Rows(0).Item("AssemblyPath").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
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
                    Lst.Add(New R2CoreStandardMonetarySettingToolStructure(DS.Tables(0).Rows(Loopx).Item("MSTId"), DS.Tables(0).Rows(Loopx).Item("MSTName").trim, DS.Tables(0).Rows(Loopx).Item("MSTTitle").trim, Color.FromName(DS.Tables(0).Rows(Loopx).Item("MSTColor").trim), DS.Tables(0).Rows(0).Item("AssemblyPath").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetThisComputerDefaultNSS(YourConfigurationIndex As Int16) As R2CoreStandardMonetarySettingToolStructure
            Try
                Dim ConfigValue As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.MonetarySettingTools, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, YourConfigurationIndex)
                Return GetMonetarySettingTools(ConfigValue.Split("@")(0))
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

    End Class

End Namespace