Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTWSReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCTWSReport))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblSelectedTerminal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnOnLineEbtal = New System.Windows.Forms.Button()
        Me.LblTruckId = New System.Windows.Forms.Label()
        Me.BtnSetting = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPelak = New System.Windows.Forms.TextBox()
        Me.PnlUcLogHolder = New System.Windows.Forms.Panel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlSetting = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotalRec = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicExitPnlSetting = New System.Windows.Forms.PictureBox()
        Me.PnlMain.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlSetting.SuspendLayout
        CType(Me.PicExitPnlSetting,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.Panel2)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.PnlUcLogHolder)
        Me.PnlMain.Controls.Add(Me.PnlSetting)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(747, 427)
        Me.PnlMain.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LblSelectedTerminal)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.BtnOnLineEbtal)
        Me.Panel2.Controls.Add(Me.LblTruckId)
        Me.Panel2.Controls.Add(Me.BtnSetting)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.BtnView)
        Me.Panel2.Controls.Add(Me.TxtSerial)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtPelak)
        Me.Panel2.Location = New System.Drawing.Point(599, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 354)
        Me.Panel2.TabIndex = 23
        '
        'LblSelectedTerminal
        '
        Me.LblSelectedTerminal.BackColor = System.Drawing.Color.Transparent
        Me.LblSelectedTerminal.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblSelectedTerminal.ForeColor = System.Drawing.Color.Red
        Me.LblSelectedTerminal.Location = New System.Drawing.Point(12, 350)
        Me.LblSelectedTerminal.Name = "LblSelectedTerminal"
        Me.LblSelectedTerminal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblSelectedTerminal.Size = New System.Drawing.Size(116, 22)
        Me.LblSelectedTerminal.TabIndex = 24
        Me.LblSelectedTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(13, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(116, 49)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "درخواست ابطال نوبت در سيستم آنلاين"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOnLineEbtal
        '
        Me.BtnOnLineEbtal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnOnLineEbtal.BackColor = System.Drawing.Color.GhostWhite
        Me.BtnOnLineEbtal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOnLineEbtal.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnOnLineEbtal.ForeColor = System.Drawing.Color.Black
        Me.BtnOnLineEbtal.Location = New System.Drawing.Point(21, 310)
        Me.BtnOnLineEbtal.Name = "BtnOnLineEbtal"
        Me.BtnOnLineEbtal.Size = New System.Drawing.Size(98, 34)
        Me.BtnOnLineEbtal.TabIndex = 22
        Me.BtnOnLineEbtal.Text = "ابطال نوبت"
        Me.BtnOnLineEbtal.UseVisualStyleBackColor = false
        '
        'LblTruckId
        '
        Me.LblTruckId.AutoSize = true
        Me.LblTruckId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.LblTruckId.ForeColor = System.Drawing.Color.Silver
        Me.LblTruckId.Location = New System.Drawing.Point(56, 136)
        Me.LblTruckId.Name = "LblTruckId"
        Me.LblTruckId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTruckId.Size = New System.Drawing.Size(11, 15)
        Me.LblTruckId.TabIndex = 19
        Me.LblTruckId.Text = " "
        Me.LblTruckId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSetting
        '
        Me.BtnSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnSetting.BackColor = System.Drawing.Color.GhostWhite
        Me.BtnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSetting.Font = New System.Drawing.Font("Zar", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnSetting.ForeColor = System.Drawing.Color.Black
        Me.BtnSetting.Location = New System.Drawing.Point(21, 194)
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.Size = New System.Drawing.Size(98, 33)
        Me.BtnSetting.TabIndex = 11
        Me.BtnSetting.Text = "تنظيمات"
        Me.BtnSetting.UseVisualStyleBackColor = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(56, 99)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = false
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.Font = New System.Drawing.Font("Zar", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnView.Location = New System.Drawing.Point(21, 154)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(98, 34)
        Me.BtnView.TabIndex = 6
        Me.BtnView.Text = "نمايش"
        Me.BtnView.UseVisualStyleBackColor = false
        '
        'TxtSerial
        '
        Me.TxtSerial.BackColor = System.Drawing.Color.White
        Me.TxtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSerial.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtSerial.ForeColor = System.Drawing.Color.Silver
        Me.TxtSerial.Location = New System.Drawing.Point(3, 72)
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSerial.Size = New System.Drawing.Size(134, 21)
        Me.TxtSerial.TabIndex = 18
        Me.TxtSerial.Text = "سري پلاک را وارد نماييد"
        Me.TxtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Zar", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(105, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "مشخصات ناوگان"
        '
        'TxtPelak
        '
        Me.TxtPelak.BackColor = System.Drawing.Color.White
        Me.TxtPelak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPelak.Font = New System.Drawing.Font("Zar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtPelak.ForeColor = System.Drawing.Color.Silver
        Me.TxtPelak.Location = New System.Drawing.Point(5, 45)
        Me.TxtPelak.Name = "TxtPelak"
        Me.TxtPelak.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPelak.Size = New System.Drawing.Size(129, 21)
        Me.TxtPelak.TabIndex = 17
        Me.TxtPelak.Text = "پلاک ناوگان را وارد نماييد"
        Me.TxtPelak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlUcLogHolder
        '
        Me.PnlUcLogHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUcLogHolder.AutoScroll = true
        Me.PnlUcLogHolder.BackColor = System.Drawing.Color.White
        Me.PnlUcLogHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PnlUcLogHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUcLogHolder.Location = New System.Drawing.Point(3, 59)
        Me.PnlUcLogHolder.Name = "PnlUcLogHolder"
        Me.PnlUcLogHolder.Size = New System.Drawing.Size(590, 354)
        Me.PnlUcLogHolder.TabIndex = 13
        '
        'UcLabelTop
        '
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(745, 53)
        Me.UcLabelTop.TabIndex = 12
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCValue = "گزارش سیستم آنلاین کنترل متمرکز نوبت دهی پایانه های استان اصفهان "
        '
        'PnlSetting
        '
        Me.PnlSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSetting.BackColor = System.Drawing.Color.White
        Me.PnlSetting.Controls.Add(Me.Label5)
        Me.PnlSetting.Controls.Add(Me.Label3)
        Me.PnlSetting.Controls.Add(Me.TxtTotalRec)
        Me.PnlSetting.Controls.Add(Me.Panel1)
        Me.PnlSetting.Controls.Add(Me.PicExitPnlSetting)
        Me.PnlSetting.Location = New System.Drawing.Point(3, 59)
        Me.PnlSetting.Name = "PnlSetting"
        Me.PnlSetting.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlSetting.Size = New System.Drawing.Size(590, 354)
        Me.PnlSetting.TabIndex = 24
        Me.PnlSetting.Visible = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Zar", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(59, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "تنظيمات"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Zar", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.Location = New System.Drawing.Point(463, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(114, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تعداد رکورد دريافتي :"
        '
        'TxtTotalRec
        '
        Me.TxtTotalRec.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.TxtTotalRec.Location = New System.Drawing.Point(357, 131)
        Me.TxtTotalRec.Name = "TxtTotalRec"
        Me.TxtTotalRec.Size = New System.Drawing.Size(100, 23)
        Me.TxtTotalRec.TabIndex = 3
        Me.TxtTotalRec.Text = "10"
        Me.TxtTotalRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 36)
        Me.Panel1.TabIndex = 2
        '
        'PicExitPnlSetting
        '
        Me.PicExitPnlSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExitPnlSetting.Image = CType(resources.GetObject("PicExitPnlSetting.Image"),System.Drawing.Image)
        Me.PicExitPnlSetting.Location = New System.Drawing.Point(13, 24)
        Me.PicExitPnlSetting.Name = "PicExitPnlSetting"
        Me.PicExitPnlSetting.Size = New System.Drawing.Size(66, 13)
        Me.PicExitPnlSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExitPnlSetting.TabIndex = 0
        Me.PicExitPnlSetting.TabStop = false
        '
        'UCTWSReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTWSReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(753, 433)
        Me.PnlMain.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlSetting.ResumeLayout(false)
        Me.PnlSetting.PerformLayout
        CType(Me.PicExitPnlSetting,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents PnlUcLogHolder As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblSelectedTerminal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnOnLineEbtal As System.Windows.Forms.Button
    Friend WithEvents LblTruckId As System.Windows.Forms.Label
    Friend WithEvents BtnSetting As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents TxtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPelak As System.Windows.Forms.TextBox
    Friend WithEvents PnlSetting As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalRec As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PicExitPnlSetting As System.Windows.Forms.PictureBox
End Class
