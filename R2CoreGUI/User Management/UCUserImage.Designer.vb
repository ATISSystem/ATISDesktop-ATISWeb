<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserImage
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
        Me.PnlUserImage = New System.Windows.Forms.Panel()
        Me.PicUserImage = New System.Windows.Forms.PictureBox()
        Me.PnlUserImage.SuspendLayout
        CType(Me.PicUserImage,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlUserImage
        '
        Me.PnlUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUserImage.Controls.Add(Me.PicUserImage)
        Me.PnlUserImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlUserImage.Location = New System.Drawing.Point(2, 2)
        Me.PnlUserImage.Name = "PnlUserImage"
        Me.PnlUserImage.Size = New System.Drawing.Size(146, 146)
        Me.PnlUserImage.TabIndex = 0
        '
        'PicUserImage
        '
        Me.PicUserImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicUserImage.Location = New System.Drawing.Point(0, 0)
        Me.PicUserImage.Name = "PicUserImage"
        Me.PicUserImage.Size = New System.Drawing.Size(144, 144)
        Me.PicUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUserImage.TabIndex = 0
        Me.PicUserImage.TabStop = False
        '
        'UCUserImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlUserImage)
        Me.Name = "UCUserImage"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlUserImage.ResumeLayout(false)
        CType(Me.PicUserImage,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlUserImage As Panel
    Friend WithEvents PicUserImage As PictureBox
End Class
