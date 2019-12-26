
Imports System.Globalization
Imports System.Reflection
Imports Microsoft.Win32

Imports R2CoreWinFormRemoteApplications.ConfigurationManagement

Public NotInheritable Class PayanehAmirKabirRemoteApplicationClassLibrary

    Private Shared PWebService As PayanehWS.PayanehWebService=NEW PayanehWS.PayanehWebService

#Region "Configuration Management"
    Public Shared Function GetClock4CNN() As String
        Try
            Return R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetAppConfigValue("Clock4CNN", "Clock4CNN")
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

#End Region

#Region "Reports Management"

    Public Shared RdlName_UsersChargeReport = "UsersChargeReport"
    Public Shared RdlName_ContractorCompanyFinancialReport = "ContractorCompanyFinancialReport"
    Public Shared RdlName_TruckersAssociationFinancialReport = "TruckersAssociationFinancialReport"
    Public Shared RdlName_PersonnelEnterExitReport = "PersonnelEnterExitReport"
    Public Shared RdlName_SoldRFIDCardsReport = "SoldRFIDCardsReport"

#End Region

#Region "Personnel Management"
    Public Shared Sub TransferPersonelFingerPrintsIntoClock4(YourSalFull As String, YourMonthCodeFull As String)
        Dim myClockTableName As String = "C" + YourSalFull.Trim + YourMonthCodeFull
        Dim CmdSqlClock4 As New OleDb.OleDbCommand
        CmdSqlClock4.Connection = New OleDb.OleDbConnection(GetClock4CNN())
        Try
            Dim DS As DataSet = PWebService.WebMethodGetDSPersonnelFingerPrints(YourSalFull, YourMonthCodeFull)

            'شروع تراکنش ثبت
            CmdSqlClock4.Connection.Open()
            CmdSqlClock4.Transaction = CmdSqlClock4.Connection.BeginTransaction
            For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                Dim myPIdOther As String = DS.Tables(0).Rows(Loopx).Item("PIdOther").trim
                Dim myDateShamsi As String = DS.Tables(0).Rows(Loopx).Item("DateShamsi").trim
                Dim myTimeInteger As Int64 = Mid(DS.Tables(0).Rows(Loopx).Item("Time").trim, 1, 2) * 60 + Mid(DS.Tables(0).Rows(Loopx).Item("Time").trim, 4, 2)
                CmdSqlClock4.CommandText = "Insert Into " & myClockTableName & " Values('" & myPIdOther & "','" & myDateShamsi & "'," & myTimeInteger & ",1,0,'" & myDateShamsi & "'," & myTimeInteger & ",1,0,0,'Admin')"
                CmdSqlClock4.ExecuteNonQuery()
            Next
            CmdSqlClock4.Transaction.Commit() : CmdSqlClock4.Connection.Close()

        Catch ex As Exception
            If CmdSqlClock4.Connection.State <> ConnectionState.Closed Then
                CmdSqlClock4.Transaction.Rollback() : CmdSqlClock4.Connection.Close()
            End If
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region


End Class




