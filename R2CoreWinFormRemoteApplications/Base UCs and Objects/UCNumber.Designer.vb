<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCNumber
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
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'TxtNumber
        '
        Me.TxtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNumber.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.TxtNumber.Location = New System.Drawing.Point(0, 0)
        Me.TxtNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNumber.Size = New System.Drawing.Size(159, 23)
        Me.TxtNumber.TabIndex = 0
        Me.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtNumber)
        Me.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UCNumber"
        Me.Size = New System.Drawing.Size(159, 25)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TxtNumber As System.Windows.Forms.TextBox

End Class
