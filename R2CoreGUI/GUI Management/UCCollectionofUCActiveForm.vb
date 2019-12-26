
Imports System.Reflection

Imports R2Core.RFIDCardsManagement


Public Class UCCollectionofUCActiveForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCAddActiveForm(ByVal YourFormName As String, ByVal YourFormRefrence As FrmcGeneral)
        Try
            Dim UC As UCActiveForm = New UCActiveForm
            UC.UCSetActiveForm(YourFormName, YourFormRefrence)
            AddHandler UC.UCUnSetActiveFormEvent, AddressOf UCs_Handler
            UC.Dock = DockStyle.Right
            PnlMain.Controls.Add(UC)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub

    Public Sub UCCloseActiveForm(ByVal YourFormRefrence As FrmcGeneral)
        Try
            For Each UC As UCActiveForm In PnlMain.Controls
                UC.UCUnSetActiveForm(YourFormRefrence)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub

    Private Sub UCs_Handler(ByVal UC As UCActiveForm)
        PnlMain.Controls.Remove(UC)
    End Sub

    Public Sub UCActivateThisRefrence(YourReference As FrmcGeneral)
        Try
            For Each UC As UCActiveForm In PnlMain.Controls
                If Object.Equals(UC.UCFormRefrence, YourReference) Then
                    UC.UCActivateRefrence()
                End If
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub CButtonMainMenuRefrence_Click(sender As Object, e As EventArgs) Handles CButtonMainMenuRefrence.Click
        R2CoreRFIDCardReaderInterface.StopReading()
        For Each Frm As UCActiveForm In PnlMain.Controls
            Frm.UCFormRefrence.Hide()
        Next
    End Sub

End Class
