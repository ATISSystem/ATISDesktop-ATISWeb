<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMonetarySettingToolUserPadInstrument
    Inherits UCMonetarySettingToolInstrument

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMonetarySettingToolUserPadInstrument))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PicMblghZero = New System.Windows.Forms.PictureBox()
        Me.UcMblghSelector10000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector50000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector100000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector1000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector28000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector36000 = New R2CoreGUI.UCMblghSelector()
        Me.UcLabelHint = New R2CoreGUI.UCLabel()
        Me.UcLabelAmount = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        CType(Me.PicMblghZero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PicMblghZero)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector10000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector50000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector100000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector1000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector28000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector36000)
        Me.PnlMain.Controls.Add(Me.UcLabelHint)
        Me.PnlMain.Controls.Add(Me.UcLabelAmount)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(414, 155)
        Me.PnlMain.TabIndex = 0
        '
        'PicMblghZero
        '
        Me.PicMblghZero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicMblghZero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMblghZero.Image = CType(resources.GetObject("PicMblghZero.Image"), System.Drawing.Image)
        Me.PicMblghZero.Location = New System.Drawing.Point(6, 142)
        Me.PicMblghZero.Name = "PicMblghZero"
        Me.PicMblghZero.Size = New System.Drawing.Size(19, 10)
        Me.PicMblghZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMblghZero.TabIndex = 12
        Me.PicMblghZero.TabStop = False
        '
        'UcMblghSelector10000
        '
        Me.UcMblghSelector10000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector10000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector10000.Location = New System.Drawing.Point(274, 70)
        Me.UcMblghSelector10000.Name = "UcMblghSelector10000"
        Me.UcMblghSelector10000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector10000.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMblghSelector10000.Size = New System.Drawing.Size(134, 70)
        Me.UcMblghSelector10000.TabIndex = 5
        Me.UcMblghSelector10000.UCBackColor = System.Drawing.Color.Coral
        Me.UcMblghSelector10000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector10000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector10000.UCEnable = True
        Me.UcMblghSelector10000.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector10000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector10000.UCMblgh = CType(100000, Long)
        Me.UcMblghSelector10000.UCValue = "10,000 تومان"
        Me.UcMblghSelector10000.UCViewString = "تومان"
        '
        'UcMblghSelector50000
        '
        Me.UcMblghSelector50000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector50000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector50000.Location = New System.Drawing.Point(140, 70)
        Me.UcMblghSelector50000.Name = "UcMblghSelector50000"
        Me.UcMblghSelector50000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector50000.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMblghSelector50000.Size = New System.Drawing.Size(134, 70)
        Me.UcMblghSelector50000.TabIndex = 4
        Me.UcMblghSelector50000.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcMblghSelector50000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector50000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector50000.UCEnable = True
        Me.UcMblghSelector50000.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector50000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector50000.UCMblgh = CType(500000, Long)
        Me.UcMblghSelector50000.UCValue = "50,000 تومان"
        Me.UcMblghSelector50000.UCViewString = "تومان"
        '
        'UcMblghSelector100000
        '
        Me.UcMblghSelector100000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector100000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector100000.Location = New System.Drawing.Point(6, 70)
        Me.UcMblghSelector100000.Name = "UcMblghSelector100000"
        Me.UcMblghSelector100000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector100000.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMblghSelector100000.Size = New System.Drawing.Size(134, 70)
        Me.UcMblghSelector100000.TabIndex = 3
        Me.UcMblghSelector100000.UCBackColor = System.Drawing.Color.Red
        Me.UcMblghSelector100000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector100000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector100000.UCEnable = True
        Me.UcMblghSelector100000.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector100000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector100000.UCMblgh = CType(1000000, Long)
        Me.UcMblghSelector100000.UCValue = "100,000 تومان"
        Me.UcMblghSelector100000.UCViewString = "تومان"
        '
        'UcMblghSelector1000
        '
        Me.UcMblghSelector1000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector1000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector1000.Location = New System.Drawing.Point(274, 2)
        Me.UcMblghSelector1000.Name = "UcMblghSelector1000"
        Me.UcMblghSelector1000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector1000.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMblghSelector1000.Size = New System.Drawing.Size(134, 70)
        Me.UcMblghSelector1000.TabIndex = 2
        Me.UcMblghSelector1000.UCBackColor = System.Drawing.Color.LimeGreen
        Me.UcMblghSelector1000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector1000.UCDeleteOneZeroWhenView = False
        Me.UcMblghSelector1000.UCEnable = True
        Me.UcMblghSelector1000.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector1000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector1000.UCMblgh = CType(10000, Long)
        Me.UcMblghSelector1000.UCValue = "1,000 تومان"
        Me.UcMblghSelector1000.UCViewString = "تومان"
        '
        'UcMblghSelector28000
        '
        Me.UcMblghSelector28000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector28000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector28000.Location = New System.Drawing.Point(140, 2)
        Me.UcMblghSelector28000.Name = "UcMblghSelector28000"
        Me.UcMblghSelector28000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector28000.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMblghSelector28000.Size = New System.Drawing.Size(134, 70)
        Me.UcMblghSelector28000.TabIndex = 1
        Me.UcMblghSelector28000.UCBackColor = System.Drawing.Color.ForestGreen
        Me.UcMblghSelector28000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector28000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector28000.UCEnable = True
        Me.UcMblghSelector28000.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector28000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector28000.UCMblgh = CType(280000, Long)
        Me.UcMblghSelector28000.UCValue = "28,000 تومان"
        Me.UcMblghSelector28000.UCViewString = "تومان"
        '
        'UcMblghSelector36000
        '
        Me.UcMblghSelector36000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector36000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector36000.Location = New System.Drawing.Point(6, 2)
        Me.UcMblghSelector36000.Name = "UcMblghSelector36000"
        Me.UcMblghSelector36000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector36000.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMblghSelector36000.Size = New System.Drawing.Size(134, 70)
        Me.UcMblghSelector36000.TabIndex = 0
        Me.UcMblghSelector36000.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcMblghSelector36000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector36000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector36000.UCEnable = True
        Me.UcMblghSelector36000.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector36000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector36000.UCMblgh = CType(360000, Long)
        Me.UcMblghSelector36000.UCValue = "36,000 تومان"
        Me.UcMblghSelector36000.UCViewString = "تومان"
        '
        'UcLabelHint
        '
        Me.UcLabelHint._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelHint._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelHint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelHint.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelHint.Location = New System.Drawing.Point(360, 127)
        Me.UcLabelHint.Name = "UcLabelHint"
        Me.UcLabelHint.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelHint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelHint.Size = New System.Drawing.Size(40, 32)
        Me.UcLabelHint.TabIndex = 6
        Me.UcLabelHint.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelHint.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelHint.UCForeColor = System.Drawing.Color.LightGray
        Me.UcLabelHint.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelHint.UCValue = "مبلغ :"
        '
        'UcLabelAmount
        '
        Me.UcLabelAmount._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelAmount._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelAmount.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAmount.Location = New System.Drawing.Point(250, 127)
        Me.UcLabelAmount.Name = "UcLabelAmount"
        Me.UcLabelAmount.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelAmount.Size = New System.Drawing.Size(82, 32)
        Me.UcLabelAmount.TabIndex = 7
        Me.UcLabelAmount.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAmount.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelAmount.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabelAmount.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelAmount.UCValue = "0"
        '
        'UCMonetarySettingToolUserPadInstrument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMonetarySettingToolUserPadInstrument"
        Me.Size = New System.Drawing.Size(414, 155)
        Me.PnlMain.ResumeLayout(False)
        CType(Me.PicMblghZero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcMblghSelector36000 As UCMblghSelector
    Friend WithEvents UcMblghSelector28000 As UCMblghSelector
    Friend WithEvents UcMblghSelector1000 As UCMblghSelector
    Friend WithEvents UcMblghSelector100000 As UCMblghSelector
    Friend WithEvents UcMblghSelector50000 As UCMblghSelector
    Friend WithEvents UcMblghSelector10000 As UCMblghSelector
    Friend WithEvents UcLabelHint As UCLabel
    Friend WithEvents UcLabelAmount As UCLabel
    Friend WithEvents PicMblghZero As PictureBox
End Class
