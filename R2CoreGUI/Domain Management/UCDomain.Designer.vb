<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDomain
    Inherits UCGeneral

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
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        '
        'UCDomain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Name = "UCDomain"
        Me.Size = New System.Drawing.Size(217, 41)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
End Class
