
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DatabaseManagement
Imports R2CoreGUI

Public Class UCDriverTruckPresentCollection
    Inherits UCGeneral


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub UCViewPresent(ByVal YourNobatId As UInt64)
        Try
            ViewPresent(YourNobatId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Delegate Sub _ViewPresent(ByVal YourNobatId As UInt64)
    Private Sub ViewPresent(ByVal YourNobatId As UInt64)
        Try
            If (PnlUCs.InvokeRequired) Then
                Dim myDelegate As _ViewPresent = New _ViewPresent(AddressOf ViewPresent)
                Dim params() As Object = New Object() {YourNobatId}
                BeginInvoke(myDelegate, params)
            Else
                PnlUCs.SuspendLayout()
                UCRefresh()
                Dim DSPresent As DataSet
                Dim myPresentSabted As UInt16 = R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent where (NobatId=" & YourNobatId & ") order by DateTimeMilladi Asc", 1, DSPresent).GetRecordsCount
                If myPresentSabted <> 0 Then
                    For Loopx As UInt16 = 0 To DSPresent.Tables(0).Rows.Count - 1
                        Dim myUC As UCDriverTruckSinglePresent = New UCDriverTruckSinglePresent(DSPresent.Tables(0).Rows(Loopx).Item("PelakSerial").trim, DSPresent.Tables(0).Rows(Loopx).Item("DriverNameFamily").trim, DSPresent.Tables(0).Rows(Loopx).Item("DateShamsi").trim, DSPresent.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DSPresent.Tables(0).Rows(Loopx).Item("PresentType"))
                        myUC.Dock = DockStyle.Top
                        PnlUCs.Controls.Add(myUC)
                    Next
                End If
                PnlUCs.ResumeLayout(True)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
            Do While PnlUCs.Controls.Count <> 0
                For Each C As Control In PnlUCs.Controls
                    PnlUCs.Controls.Remove(C)
                    C.Dispose()
                Next
            Loop
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


End Class
