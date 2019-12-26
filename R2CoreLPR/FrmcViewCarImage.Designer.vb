<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcViewCarImage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PicCarImage = New System.Windows.Forms.PictureBox()
        CType(Me.PicCarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicCarImage
        '
        Me.PicCarImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicCarImage.Location = New System.Drawing.Point(0, 0)
        Me.PicCarImage.Name = "PicCarImage"
        Me.PicCarImage.Size = New System.Drawing.Size(439, 406)
        Me.PicCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCarImage.TabIndex = 0
        Me.PicCarImage.TabStop = False
        '
        'FrmcViewCarImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 406)
        Me.Controls.Add(Me.PicCarImage)
        Me.Name = "FrmcViewCarImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R2CoreLPR-FrmcViewCarImage"
        CType(Me.PicCarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicCarImage As System.Windows.Forms.PictureBox
End Class
