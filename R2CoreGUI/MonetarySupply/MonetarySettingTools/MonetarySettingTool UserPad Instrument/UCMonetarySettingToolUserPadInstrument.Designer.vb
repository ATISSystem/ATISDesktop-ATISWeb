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
        Me.UcMblghSelector5000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector6000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector10000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector500 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector1000 = New R2CoreGUI.UCMblghSelector()
        Me.UcMblghSelector3000 = New R2CoreGUI.UCMblghSelector()
        Me.UcLabelHint = New R2CoreGUI.UCLabel()
        Me.UcLabelAmount = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        CType(Me.PicMblghZero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PicMblghZero)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector5000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector6000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector10000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector500)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector1000)
        Me.PnlMain.Controls.Add(Me.UcMblghSelector3000)
        Me.PnlMain.Controls.Add(Me.UcLabelHint)
        Me.PnlMain.Controls.Add(Me.UcLabelAmount)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(394, 121)
        Me.PnlMain.TabIndex = 0
        '
        'PicMblghZero
        '
        Me.PicMblghZero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicMblghZero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMblghZero.Image = CType(resources.GetObject("PicMblghZero.Image"), System.Drawing.Image)
        Me.PicMblghZero.Location = New System.Drawing.Point(7, 101)
        Me.PicMblghZero.Name = "PicMblghZero"
        Me.PicMblghZero.Size = New System.Drawing.Size(19, 15)
        Me.PicMblghZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMblghZero.TabIndex = 12
        Me.PicMblghZero.TabStop = False
        '
        'UcMblghSelector5000
        '
        Me.UcMblghSelector5000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector5000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector5000.Location = New System.Drawing.Point(261, 50)
        Me.UcMblghSelector5000.Name = "UcMblghSelector5000"
        Me.UcMblghSelector5000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector5000.Size = New System.Drawing.Size(129, 48)
        Me.UcMblghSelector5000.TabIndex = 5
        Me.UcMblghSelector5000.UCBackColor = System.Drawing.Color.Coral
        Me.UcMblghSelector5000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector5000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector5000.UCEnable = True
        Me.UcMblghSelector5000.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector5000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector5000.UCMblgh = CType(50000, Long)
        Me.UcMblghSelector5000.UCValue = "5,000تومان"
        Me.UcMblghSelector5000.UCViewString = "تومان"
        '
        'UcMblghSelector6000
        '
        Me.UcMblghSelector6000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector6000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector6000.Location = New System.Drawing.Point(133, 50)
        Me.UcMblghSelector6000.Name = "UcMblghSelector6000"
        Me.UcMblghSelector6000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector6000.Size = New System.Drawing.Size(129, 48)
        Me.UcMblghSelector6000.TabIndex = 4
        Me.UcMblghSelector6000.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcMblghSelector6000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector6000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector6000.UCEnable = True
        Me.UcMblghSelector6000.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector6000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector6000.UCMblgh = CType(60000, Long)
        Me.UcMblghSelector6000.UCValue = "6,000تومان"
        Me.UcMblghSelector6000.UCViewString = "تومان"
        '
        'UcMblghSelector10000
        '
        Me.UcMblghSelector10000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector10000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector10000.Location = New System.Drawing.Point(4, 50)
        Me.UcMblghSelector10000.Name = "UcMblghSelector10000"
        Me.UcMblghSelector10000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector10000.Size = New System.Drawing.Size(129, 48)
        Me.UcMblghSelector10000.TabIndex = 3
        Me.UcMblghSelector10000.UCBackColor = System.Drawing.Color.Red
        Me.UcMblghSelector10000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector10000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector10000.UCEnable = True
        Me.UcMblghSelector10000.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector10000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector10000.UCMblgh = CType(100000, Long)
        Me.UcMblghSelector10000.UCValue = "10,000تومان"
        Me.UcMblghSelector10000.UCViewString = "تومان"
        '
        'UcMblghSelector500
        '
        Me.UcMblghSelector500.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector500.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector500.Location = New System.Drawing.Point(261, 3)
        Me.UcMblghSelector500.Name = "UcMblghSelector500"
        Me.UcMblghSelector500.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector500.Size = New System.Drawing.Size(129, 48)
        Me.UcMblghSelector500.TabIndex = 2
        Me.UcMblghSelector500.UCBackColor = System.Drawing.Color.LimeGreen
        Me.UcMblghSelector500.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector500.UCDeleteOneZeroWhenView = False
        Me.UcMblghSelector500.UCEnable = True
        Me.UcMblghSelector500.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector500.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector500.UCMblgh = CType(5000, Long)
        Me.UcMblghSelector500.UCValue = "500تومان"
        Me.UcMblghSelector500.UCViewString = "تومان"
        '
        'UcMblghSelector1000
        '
        Me.UcMblghSelector1000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector1000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector1000.Location = New System.Drawing.Point(133, 3)
        Me.UcMblghSelector1000.Name = "UcMblghSelector1000"
        Me.UcMblghSelector1000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector1000.Size = New System.Drawing.Size(129, 48)
        Me.UcMblghSelector1000.TabIndex = 1
        Me.UcMblghSelector1000.UCBackColor = System.Drawing.Color.ForestGreen
        Me.UcMblghSelector1000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector1000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector1000.UCEnable = True
        Me.UcMblghSelector1000.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector1000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector1000.UCMblgh = CType(10000, Long)
        Me.UcMblghSelector1000.UCValue = "1,000تومان"
        Me.UcMblghSelector1000.UCViewString = "تومان"
        '
        'UcMblghSelector3000
        '
        Me.UcMblghSelector3000.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMblghSelector3000.BackColor = System.Drawing.Color.Transparent
        Me.UcMblghSelector3000.Location = New System.Drawing.Point(4, 3)
        Me.UcMblghSelector3000.Name = "UcMblghSelector3000"
        Me.UcMblghSelector3000.Padding = New System.Windows.Forms.Padding(1)
        Me.UcMblghSelector3000.Size = New System.Drawing.Size(129, 48)
        Me.UcMblghSelector3000.TabIndex = 0
        Me.UcMblghSelector3000.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcMblghSelector3000.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcMblghSelector3000.UCDeleteOneZeroWhenView = True
        Me.UcMblghSelector3000.UCEnable = True
        Me.UcMblghSelector3000.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcMblghSelector3000.UCForeColor = System.Drawing.Color.White
        Me.UcMblghSelector3000.UCMblgh = CType(30000, Long)
        Me.UcMblghSelector3000.UCValue = "3,000تومان"
        Me.UcMblghSelector3000.UCViewString = "تومان"
        '
        'UcLabelHint
        '
        Me.UcLabelHint._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelHint._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelHint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelHint.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelHint.Location = New System.Drawing.Point(349, 91)
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
        Me.UcLabelAmount.Location = New System.Drawing.Point(261, 91)
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
        Me.Size = New System.Drawing.Size(394, 121)
        Me.PnlMain.ResumeLayout(False)
        CType(Me.PicMblghZero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcMblghSelector3000 As UCMblghSelector
    Friend WithEvents UcMblghSelector1000 As UCMblghSelector
    Friend WithEvents UcMblghSelector500 As UCMblghSelector
    Friend WithEvents UcMblghSelector10000 As UCMblghSelector
    Friend WithEvents UcMblghSelector6000 As UCMblghSelector
    Friend WithEvents UcMblghSelector5000 As UCMblghSelector
    Friend WithEvents UcLabelHint As UCLabel
    Friend WithEvents UcLabelAmount As UCLabel
    Friend WithEvents PicMblghZero As PictureBox
End Class
