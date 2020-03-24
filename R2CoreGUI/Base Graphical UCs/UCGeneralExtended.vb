
Imports R2Core.DateAndTimeManagement


Public Class UCGeneralExtended

    Protected Event UCGotFocusedEvent()
    Protected _DateTime As New R2DateTime

    Public Sub UCFocus()
        RaiseEvent UCGotFocusedEvent()
    End Sub

    Private _UCFrmMessageDialog As FrmcMessageDialog = Nothing
    Public ReadOnly Property UCFrmMessageDialog As FrmcMessageDialog
        Get
            If _UCFrmMessageDialog Is Nothing Then _UCFrmMessageDialog = New FrmcMessageDialog()
            Return _UCFrmMessageDialog
        End Get
    End Property

End Class
