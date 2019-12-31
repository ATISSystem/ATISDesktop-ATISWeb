
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


Namespace MonetaryProviding

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
                    Return New R2CoreStandardMonetaryCreditSupplySourceStructure(Ds.Tables(0).Rows(0).Item("MCSSId"), Ds.Tables(0).Rows(0).Item("MCSSName").trim, Ds.Tables(0).Rows(0).Item("MCSSTitle").trim, Ds.Tables(0).Rows(0).Item("MCSSColor").trim, Ds.Tables(0).Rows(0).Item("AssemblyPath").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
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
                    Lst.Add(New R2CoreStandardMonetaryCreditSupplySourceStructure(DS.Tables(0).Rows(Loopx).Item("MCSSId"), DS.Tables(0).Rows(Loopx).Item("MCSSName").trim, DS.Tables(0).Rows(Loopx).Item("MCSSTitle").trim, DS.Tables(0).Rows(Loopx).Item("MCSSColor").trim, DS.Tables(0).Rows(0).Item("AssemblyPath").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
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