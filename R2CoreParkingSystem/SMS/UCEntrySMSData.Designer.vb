
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCEntrySMSData
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.CButtonSubmit = New CButtonLib.CButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcPersianTextBox10 = New R2CoreGUI.UCPersianTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UcPersianTextBox9 = New R2CoreGUI.UCPersianTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UcPersianTextBox8 = New R2CoreGUI.UCPersianTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UcPersianTextBox7 = New R2CoreGUI.UCPersianTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UcPersianTextBox6 = New R2CoreGUI.UCPersianTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcPersianTextBox5 = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBox4 = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBox3 = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBox2 = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBox1 = New R2CoreGUI.UCPersianTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.White
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(5, 5)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlOutter.Size = New System.Drawing.Size(615, 212)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.CButtonSubmit)
        Me.PnlInner.Controls.Add(Me.Label1)
        Me.PnlInner.Controls.Add(Me.AlphaGradientPanel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(613, 210)
        Me.PnlInner.TabIndex = 0
        '
        'CButtonSubmit
        '
        Me.CButtonSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.ForestGreen, System.Drawing.Color.DarkGreen, System.Drawing.Color.Olive}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSubmit.ColorFillBlend = CBlendItems1
        Me.CButtonSubmit.Corners.LowerRight = 10
        Me.CButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSubmit.DesignerSelected = False
        Me.CButtonSubmit.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSubmit.ImageIndex = 0
        Me.CButtonSubmit.Location = New System.Drawing.Point(21, 10)
        Me.CButtonSubmit.Name = "CButtonSubmit"
        Me.CButtonSubmit.Size = New System.Drawing.Size(117, 22)
        Me.CButtonSubmit.TabIndex = 33
        Me.CButtonSubmit.Text = "تایید پارامترها"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "پارامترهای ورودی به متن اس ام اس"
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox10)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label8)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox9)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label7)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox8)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label6)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox7)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label5)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox6)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label4)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox5)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox4)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox3)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox2)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBox1)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel1.Controls.Add(Me.Lbl4)
        Me.AlphaGradientPanel1.Controls.Add(Me.Lbl3)
        Me.AlphaGradientPanel1.Controls.Add(Me.Lbl2)
        Me.AlphaGradientPanel1.Controls.Add(Me.Lbl1)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = BlueActivity.Controls.Corner.TopRight
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(3, 22)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(607, 185)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Azure
        Me.ColorWithAlpha3.Parent = Me.AlphaGradientPanel1
        '
        'UcPersianTextBox10
        '
        Me.UcPersianTextBox10.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox10.Location = New System.Drawing.Point(15, 151)
        Me.UcPersianTextBox10.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox10.Name = "UcPersianTextBox10"
        Me.UcPersianTextBox10.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox10.TabIndex = 20
        Me.UcPersianTextBox10.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox10.UCBorder = True
        Me.UcPersianTextBox10.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox10.UCEnable = True
        Me.UcPersianTextBox10.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox10.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox10.UCMultiLine = False
        Me.UcPersianTextBox10.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox10.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox10.UCValue = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(67, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "پارامتر دهم :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcPersianTextBox9
        '
        Me.UcPersianTextBox9.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox9.Location = New System.Drawing.Point(15, 118)
        Me.UcPersianTextBox9.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox9.Name = "UcPersianTextBox9"
        Me.UcPersianTextBox9.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox9.TabIndex = 18
        Me.UcPersianTextBox9.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox9.UCBorder = True
        Me.UcPersianTextBox9.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox9.UCEnable = True
        Me.UcPersianTextBox9.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox9.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox9.UCMultiLine = False
        Me.UcPersianTextBox9.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox9.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox9.UCValue = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(177, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "پارامتر نهم :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcPersianTextBox8
        '
        Me.UcPersianTextBox8.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox8.Location = New System.Drawing.Point(15, 85)
        Me.UcPersianTextBox8.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox8.Name = "UcPersianTextBox8"
        Me.UcPersianTextBox8.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox8.TabIndex = 16
        Me.UcPersianTextBox8.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox8.UCBorder = True
        Me.UcPersianTextBox8.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox8.UCEnable = True
        Me.UcPersianTextBox8.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox8.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox8.UCMultiLine = False
        Me.UcPersianTextBox8.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox8.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox8.UCValue = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "پارامتر هشتم :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcPersianTextBox7
        '
        Me.UcPersianTextBox7.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox7.Location = New System.Drawing.Point(15, 52)
        Me.UcPersianTextBox7.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox7.Name = "UcPersianTextBox7"
        Me.UcPersianTextBox7.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox7.TabIndex = 14
        Me.UcPersianTextBox7.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox7.UCBorder = True
        Me.UcPersianTextBox7.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox7.UCEnable = True
        Me.UcPersianTextBox7.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox7.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox7.UCMultiLine = False
        Me.UcPersianTextBox7.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox7.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox7.UCValue = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "پارامتر هفتم :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcPersianTextBox6
        '
        Me.UcPersianTextBox6.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox6.Location = New System.Drawing.Point(15, 20)
        Me.UcPersianTextBox6.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox6.Name = "UcPersianTextBox6"
        Me.UcPersianTextBox6.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox6.TabIndex = 12
        Me.UcPersianTextBox6.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox6.UCBorder = True
        Me.UcPersianTextBox6.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox6.UCEnable = True
        Me.UcPersianTextBox6.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox6.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox6.UCMultiLine = False
        Me.UcPersianTextBox6.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox6.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox6.UCValue = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "پارامتر ششم :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcPersianTextBox5
        '
        Me.UcPersianTextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox5.Location = New System.Drawing.Point(355, 151)
        Me.UcPersianTextBox5.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox5.Name = "UcPersianTextBox5"
        Me.UcPersianTextBox5.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox5.TabIndex = 10
        Me.UcPersianTextBox5.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox5.UCBorder = True
        Me.UcPersianTextBox5.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox5.UCEnable = True
        Me.UcPersianTextBox5.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox5.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox5.UCMultiLine = False
        Me.UcPersianTextBox5.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox5.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox5.UCValue = ""
        '
        'UcPersianTextBox4
        '
        Me.UcPersianTextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox4.Location = New System.Drawing.Point(355, 118)
        Me.UcPersianTextBox4.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox4.Name = "UcPersianTextBox4"
        Me.UcPersianTextBox4.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox4.TabIndex = 8
        Me.UcPersianTextBox4.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox4.UCBorder = True
        Me.UcPersianTextBox4.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox4.UCEnable = True
        Me.UcPersianTextBox4.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox4.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox4.UCMultiLine = False
        Me.UcPersianTextBox4.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox4.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox4.UCValue = ""
        '
        'UcPersianTextBox3
        '
        Me.UcPersianTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox3.Location = New System.Drawing.Point(355, 85)
        Me.UcPersianTextBox3.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox3.Name = "UcPersianTextBox3"
        Me.UcPersianTextBox3.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox3.TabIndex = 6
        Me.UcPersianTextBox3.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox3.UCBorder = True
        Me.UcPersianTextBox3.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox3.UCEnable = True
        Me.UcPersianTextBox3.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox3.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox3.UCMultiLine = False
        Me.UcPersianTextBox3.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox3.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox3.UCValue = ""
        '
        'UcPersianTextBox2
        '
        Me.UcPersianTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox2.Location = New System.Drawing.Point(355, 52)
        Me.UcPersianTextBox2.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox2.Name = "UcPersianTextBox2"
        Me.UcPersianTextBox2.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox2.TabIndex = 4
        Me.UcPersianTextBox2.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox2.UCBorder = True
        Me.UcPersianTextBox2.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox2.UCEnable = True
        Me.UcPersianTextBox2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox2.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox2.UCMultiLine = False
        Me.UcPersianTextBox2.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox2.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox2.UCValue = ""
        '
        'UcPersianTextBox1
        '
        Me.UcPersianTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox1.Location = New System.Drawing.Point(355, 19)
        Me.UcPersianTextBox1.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox1.Name = "UcPersianTextBox1"
        Me.UcPersianTextBox1.Size = New System.Drawing.Size(156, 27)
        Me.UcPersianTextBox1.TabIndex = 2
        Me.UcPersianTextBox1.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox1.UCBorder = True
        Me.UcPersianTextBox1.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox1.UCEnable = True
        Me.UcPersianTextBox1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox1.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox1.UCMultiLine = False
        Me.UcPersianTextBox1.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox1.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox1.UCValue = ""
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "پارامتر پنجم :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl4
        '
        Me.Lbl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl4.AutoSize = True
        Me.Lbl4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(512, 119)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl4.Size = New System.Drawing.Size(73, 23)
        Me.Lbl4.TabIndex = 7
        Me.Lbl4.Text = "پارامتر چهارم :"
        Me.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl3
        '
        Me.Lbl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl3.AutoSize = True
        Me.Lbl3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(512, 86)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl3.Size = New System.Drawing.Size(69, 23)
        Me.Lbl3.TabIndex = 5
        Me.Lbl3.Text = "پارامتر سوم :"
        Me.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl2
        '
        Me.Lbl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl2.AutoSize = True
        Me.Lbl2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(512, 53)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl2.Size = New System.Drawing.Size(65, 23)
        Me.Lbl2.TabIndex = 3
        Me.Lbl2.Text = "پارامتر دوم :"
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl1.AutoSize = True
        Me.Lbl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(512, 20)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl1.Size = New System.Drawing.Size(64, 23)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "پارامتر اول :"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UCEntrySMSData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlOutter)
        Me.Name = "UCEntrySMSData"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(625, 222)
        Me.PnlOutter.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.PnlInner.PerformLayout()
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcPersianTextBox10 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox9 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox8 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox7 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox6 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox5 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox4 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Lbl4 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox3 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Lbl3 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox2 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Lbl2 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBox1 As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Lbl1 As Windows.Forms.Label
    Friend WithEvents CButtonSubmit As CButtonLib.CButton
End Class
