<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSLoadCapacitorLoadDataEntry
    Inherits UCLoadCapacitorLoad

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCViewerNSSLoadCapacitorLoadDataEntry))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcNumbernEstelamId = New R2CoreGUI.UCNumber()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UcLabelLoadTarget = New R2CoreGUI.UCLabel()
        Me.UcLabelGood = New R2CoreGUI.UCLabel()
        Me.UcLabelTransportCompany = New R2CoreGUI.UCLabel()
        Me.UcLabelStrDescription = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.Size = New System.Drawing.Size(497, 47)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Location = New System.Drawing.Point(3, 3)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlOutter.Size = New System.Drawing.Size(491, 44)
        Me.PnlOutter.TabIndex = 5
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcNumbernEstelamId)
        Me.PnlInner.Controls.Add(Me.PictureBox1)
        Me.PnlInner.Controls.Add(Me.UcLabelLoadTarget)
        Me.PnlInner.Controls.Add(Me.UcLabelGood)
        Me.PnlInner.Controls.Add(Me.UcLabelTransportCompany)
        Me.PnlInner.Controls.Add(Me.UcLabelStrDescription)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(487, 40)
        Me.PnlInner.TabIndex = 0
        '
        'UcNumbernEstelamId
        '
        Me.UcNumbernEstelamId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumbernEstelamId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernEstelamId.Location = New System.Drawing.Point(412, 0)
        Me.UcNumbernEstelamId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernEstelamId.Name = "UcNumbernEstelamId"
        Me.UcNumbernEstelamId.Size = New System.Drawing.Size(58, 40)
        Me.UcNumbernEstelamId.TabIndex = 0
        Me.UcNumbernEstelamId.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernEstelamId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernEstelamId.UCBorder = true
        Me.UcNumbernEstelamId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumbernEstelamId.UCEnable = true
        Me.UcNumbernEstelamId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernEstelamId.UCForeColor = System.Drawing.Color.Red
        Me.UcNumbernEstelamId.UCMultiLine = false
        Me.UcNumbernEstelamId.UCValue = CType(439232,Long)
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(471, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = false
        '
        'UcLabelLoadTarget
        '
        Me.UcLabelLoadTarget._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLoadTarget._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLoadTarget.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadTarget.Location = New System.Drawing.Point(1, 1)
        Me.UcLabelLoadTarget.Name = "UcLabelLoadTarget"
        Me.UcLabelLoadTarget.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadTarget.Size = New System.Drawing.Size(87, 21)
        Me.UcLabelLoadTarget.TabIndex = 4
        Me.UcLabelLoadTarget.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadTarget.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelLoadTarget.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelLoadTarget.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadTarget.UCValue = "آبادان نهبندان"
        '
        'UcLabelGood
        '
        Me.UcLabelGood._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelGood._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelGood.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelGood.Location = New System.Drawing.Point(94, 1)
        Me.UcLabelGood.Name = "UcLabelGood"
        Me.UcLabelGood.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelGood.Size = New System.Drawing.Size(128, 21)
        Me.UcLabelGood.TabIndex = 2
        Me.UcLabelGood.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelGood.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelGood.UCForeColor = System.Drawing.Color.DarkRed
        Me.UcLabelGood.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelGood.UCValue = "میلگرد 12 نرمال"
        '
        'UcLabelTransportCompany
        '
        Me.UcLabelTransportCompany._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTransportCompany._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTransportCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelTransportCompany.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTransportCompany.Location = New System.Drawing.Point(228, 1)
        Me.UcLabelTransportCompany.Name = "UcLabelTransportCompany"
        Me.UcLabelTransportCompany.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTransportCompany.Size = New System.Drawing.Size(186, 21)
        Me.UcLabelTransportCompany.TabIndex = 1
        Me.UcLabelTransportCompany.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTransportCompany.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTransportCompany.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTransportCompany.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTransportCompany.UCValue = "شعبه حمل و نقل دریایی آبادان"
        '
        'UcLabelStrDescription
        '
        Me.UcLabelStrDescription._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelStrDescription._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelStrDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrDescription.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDescription.Location = New System.Drawing.Point(3, 20)
        Me.UcLabelStrDescription.Name = "UcLabelStrDescription"
        Me.UcLabelStrDescription.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrDescription.Size = New System.Drawing.Size(411, 21)
        Me.UcLabelStrDescription.TabIndex = 3
        Me.UcLabelStrDescription.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDescription.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrDescription.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabelStrDescription.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrDescription.UCValue = "شعبه حمل و نقل دریایی آبطز ب شسشسیش یشسیادان"
        '
        'UCViewerNSSLoadCapacitorLoadDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSLoadCapacitorLoadDataEntry"
        Me.Size = New System.Drawing.Size(497, 47)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcNumbernEstelamId As R2CoreGUI.UCNumber
    Friend WithEvents PnlOutter As System.Windows.Forms.Panel
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents UcLabelStrDescription As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelLoadTarget As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelGood As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelTransportCompany As R2CoreGUI.UCLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
