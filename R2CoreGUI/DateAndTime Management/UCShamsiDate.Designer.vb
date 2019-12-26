<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCShamsiDate
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
        Me.TxtShamsiDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtShamsiDate
        '
        Me.TxtShamsiDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtShamsiDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtShamsiDate.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TxtShamsiDate.Location = New System.Drawing.Point(0, 0)
        Me.TxtShamsiDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtShamsiDate.Multiline = True
        Me.TxtShamsiDate.Name = "TxtShamsiDate"
        Me.TxtShamsiDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtShamsiDate.Size = New System.Drawing.Size(181, 35)
        Me.TxtShamsiDate.TabIndex = 2
        Me.TxtShamsiDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCShamsiDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtShamsiDate)
        Me.Name = "UCShamsiDate"
        Me.Size = New System.Drawing.Size(181, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtShamsiDate As System.Windows.Forms.TextBox

End Class
