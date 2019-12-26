<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersianTextBox
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
        Me.TxtPersianText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'TxtPersianText
        '
        Me.TxtPersianText.BackColor = System.Drawing.Color.White
        Me.TxtPersianText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPersianText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPersianText.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtPersianText.Location = New System.Drawing.Point(0, 0)
        Me.TxtPersianText.Multiline = true
        Me.TxtPersianText.Name = "TxtPersianText"
        Me.TxtPersianText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPersianText.Size = New System.Drawing.Size(459, 30)
        Me.TxtPersianText.TabIndex = 0
        Me.TxtPersianText.Text = "rfwrwer"
        Me.TxtPersianText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCPersianTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtPersianText)
        Me.Name = "UCPersianTextBox"
        Me.Size = New System.Drawing.Size(459, 30)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TxtPersianText As System.Windows.Forms.TextBox

End Class
