<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCButtonComputerMessageSender
    Inherits UCButton

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout
        '
        'UCButtonComputerMessageSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "UCButtonComputerMessageSender"
        Me.Size = New System.Drawing.Size(156, 45)
        Me.UCForeColor = System.Drawing.Color.White
        Me.UCValue = "ارسال پیام"
        Me.ResumeLayout(false)

End Sub

End Class
