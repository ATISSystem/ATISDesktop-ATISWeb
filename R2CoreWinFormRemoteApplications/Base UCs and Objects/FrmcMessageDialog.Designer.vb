<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMessageDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcMessageDialog))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.LblHint = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlRight = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblContinueStop = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PicMessageImage = New System.Windows.Forms.PictureBox()
        Me.PnlMain.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.PicMessageImage,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BackColor = System.Drawing.Color.SaddleBrown
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.LblHint)
        Me.PnlMain.Controls.Add(Me.LblMessage)
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(591, 452)
        Me.PnlMain.TabIndex = 1
        '
        'LblHint
        '
        Me.LblHint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblHint.Font = New System.Drawing.Font("IRMehr", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblHint.ForeColor = System.Drawing.Color.Yellow
        Me.LblHint.Location = New System.Drawing.Point(0, 350)
        Me.LblHint.Name = "LblHint"
        Me.LblHint.Size = New System.Drawing.Size(589, 100)
        Me.LblHint.TabIndex = 3
        Me.LblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMessage
        '
        Me.LblMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblMessage.Font = New System.Drawing.Font("B Homa", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.White
        Me.LblMessage.Location = New System.Drawing.Point(0, 0)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMessage.Size = New System.Drawing.Size(589, 350)
        Me.LblMessage.TabIndex = 2
        Me.LblMessage.Text = " "
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlRight
        '
        Me.PnlRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlRight.BackColor = System.Drawing.Color.DarkOrange
        Me.PnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlRight.Location = New System.Drawing.Point(597, 304)
        Me.PnlRight.Name = "PnlRight"
        Me.PnlRight.Size = New System.Drawing.Size(183, 149)
        Me.PnlRight.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblContinueStop)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PnlMain)
        Me.Panel1.Controls.Add(Me.PnlRight)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(782, 452)
        Me.Panel1.TabIndex = 3
        '
        'LblContinueStop
        '
        Me.LblContinueStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblContinueStop.BackColor = System.Drawing.Color.Firebrick
        Me.LblContinueStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblContinueStop.Font = New System.Drawing.Font("IRMehr", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblContinueStop.ForeColor = System.Drawing.Color.White
        Me.LblContinueStop.Location = New System.Drawing.Point(597, 243)
        Me.LblContinueStop.Name = "LblContinueStop"
        Me.LblContinueStop.Size = New System.Drawing.Size(183, 58)
        Me.LblContinueStop.TabIndex = 5
        Me.LblContinueStop.Text = "توقف/ادامه"
        Me.LblContinueStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PicMessageImage)
        Me.Panel2.Location = New System.Drawing.Point(597, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 238)
        Me.Panel2.TabIndex = 3
        '
        'PicMessageImage
        '
        Me.PicMessageImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicMessageImage.Image = CType(resources.GetObject("PicMessageImage.Image"),System.Drawing.Image)
        Me.PicMessageImage.Location = New System.Drawing.Point(0, 0)
        Me.PicMessageImage.Name = "PicMessageImage"
        Me.PicMessageImage.Size = New System.Drawing.Size(181, 236)
        Me.PicMessageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMessageImage.TabIndex = 0
        Me.PicMessageImage.TabStop = false
        '
        'FrmcMessageDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 454)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmcMessageDialog"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmcMessageDialog"
        Me.PnlMain.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.PicMessageImage,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents LblHint As System.Windows.Forms.Label
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlRight As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PicMessageImage As System.Windows.Forms.PictureBox
    Friend WithEvents LblContinueStop As System.Windows.Forms.Label
End Class
