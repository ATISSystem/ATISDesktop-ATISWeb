

Public Class UCGeneralExtended

    Protected Event UCGotFocusedEvent()

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
