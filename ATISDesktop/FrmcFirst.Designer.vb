<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcFirst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcFirst))
        Me.PicEnd = New System.Windows.Forms.PictureBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.LblSystemTitle = New System.Windows.Forms.Label()
        Me.LblApplicationDomainTitle1 = New System.Windows.Forms.Label()
        Me.LblApplicationDomainTitle0 = New System.Windows.Forms.Label()
        Me.UcLabelMessage = New R2CoreGUI.UCLabel()
        CType(Me.PicEnd,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PicEnd
        '
        Me.PicEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEnd.Image = CType(resources.GetObject("PicEnd.Image"),System.Drawing.Image)
        Me.PicEnd.Location = New System.Drawing.Point(432, 11)
        Me.PicEnd.Name = "PicEnd"
        Me.PicEnd.Size = New System.Drawing.Size(30, 39)
        Me.PicEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicEnd.TabIndex = 1
        Me.PicEnd.TabStop = false
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.DarkGray
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.LblSystemTitle)
        Me.PnlMain.Controls.Add(Me.PicEnd)
        Me.PnlMain.Controls.Add(Me.LblApplicationDomainTitle1)
        Me.PnlMain.Controls.Add(Me.LblApplicationDomainTitle0)
        Me.PnlMain.Controls.Add(Me.UcLabelMessage)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(491, 191)
        Me.PnlMain.TabIndex = 2
        '
        'LblSystemTitle
        '
        Me.LblSystemTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblSystemTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblSystemTitle.Font = New System.Drawing.Font("Tempus Sans ITC", 15!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblSystemTitle.ForeColor = System.Drawing.Color.Black
        Me.LblSystemTitle.Location = New System.Drawing.Point(11, 99)
        Me.LblSystemTitle.Name = "LblSystemTitle"
        Me.LblSystemTitle.Size = New System.Drawing.Size(397, 23)
        Me.LblSystemTitle.TabIndex = 204
        Me.LblSystemTitle.Text = " "
        Me.LblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblApplicationDomainTitle1
        '
        Me.LblApplicationDomainTitle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblApplicationDomainTitle1.BackColor = System.Drawing.Color.Transparent
        Me.LblApplicationDomainTitle1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblApplicationDomainTitle1.ForeColor = System.Drawing.Color.Black
        Me.LblApplicationDomainTitle1.Location = New System.Drawing.Point(11, 40)
        Me.LblApplicationDomainTitle1.Name = "LblApplicationDomainTitle1"
        Me.LblApplicationDomainTitle1.Size = New System.Drawing.Size(397, 23)
        Me.LblApplicationDomainTitle1.TabIndex = 202
        Me.LblApplicationDomainTitle1.Text = " "
        Me.LblApplicationDomainTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblApplicationDomainTitle0
        '
        Me.LblApplicationDomainTitle0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblApplicationDomainTitle0.BackColor = System.Drawing.Color.Transparent
        Me.LblApplicationDomainTitle0.Font = New System.Drawing.Font("B Homa", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblApplicationDomainTitle0.ForeColor = System.Drawing.Color.Black
        Me.LblApplicationDomainTitle0.Location = New System.Drawing.Point(58, 40)
        Me.LblApplicationDomainTitle0.Name = "LblApplicationDomainTitle0"
        Me.LblApplicationDomainTitle0.Size = New System.Drawing.Size(421, 67)
        Me.LblApplicationDomainTitle0.TabIndex = 203
        Me.LblApplicationDomainTitle0.Text = " "
        Me.LblApplicationDomainTitle0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcLabelMessage
        '
        Me.UcLabelMessage._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelMessage._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelMessage.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelMessage.ForeColor = System.Drawing.Color.Black
        Me.UcLabelMessage.Location = New System.Drawing.Point(11, 125)
        Me.UcLabelMessage.Name = "UcLabelMessage"
        Me.UcLabelMessage.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelMessage.Size = New System.Drawing.Size(467, 53)
        Me.UcLabelMessage.TabIndex = 0
        Me.UcLabelMessage.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelMessage.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelMessage.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelMessage.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelMessage.UCValue = ""
        '
        'FrmcFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(497, 197)
        Me.ControlBox = false
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmcFirst"
        Me.Opacity = 0.9R
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        CType(Me.PicEnd,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcLabelMessage As R2CoreGUI.UCLabel
    Friend WithEvents PicEnd As PictureBox
    Friend WithEvents PnlMain As Panel
    Friend WithEvents LblApplicationDomainTitle1 As Label
    Friend WithEvents LblApplicationDomainTitle0 As Label
    Friend WithEvents LblSystemTitle As Label
End Class
