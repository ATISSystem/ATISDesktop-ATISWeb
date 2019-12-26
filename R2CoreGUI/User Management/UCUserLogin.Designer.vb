<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserLogin
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
        Me.UcTextBoxUserPassword = New R2CoreGUI.UCTextBox()
        Me.UcTextBoxUserShenaseh = New R2CoreGUI.UCTextBox()
        Me.UcLabelUserShenaseh = New R2CoreGUI.UCLabel()
        Me.UcLabelUserPassword = New R2CoreGUI.UCLabel()
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'UcTextBoxUserPassword
        '
        Me.UcTextBoxUserPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxUserPassword.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcTextBoxUserPassword.Location = New System.Drawing.Point(16, 46)
        Me.UcTextBoxUserPassword.Name = "UcTextBoxUserPassword"
        Me.UcTextBoxUserPassword.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxUserPassword.Size = New System.Drawing.Size(136, 28)
        Me.UcTextBoxUserPassword.TabIndex = 6
        Me.UcTextBoxUserPassword.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxUserPassword.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxUserPassword.UCBorder = System.Windows.Forms.BorderStyle.None
        Me.UcTextBoxUserPassword.UCEnable = true
        Me.UcTextBoxUserPassword.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxUserPassword.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxUserPassword.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxUserPassword.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxUserPassword.UCMultiLine = false
        Me.UcTextBoxUserPassword.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxUserPassword.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UcTextBoxUserPassword.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxUserPassword.UCValue = ""
        '
        'UcTextBoxUserShenaseh
        '
        Me.UcTextBoxUserShenaseh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxUserShenaseh.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxUserShenaseh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcTextBoxUserShenaseh.Location = New System.Drawing.Point(16, 12)
        Me.UcTextBoxUserShenaseh.Name = "UcTextBoxUserShenaseh"
        Me.UcTextBoxUserShenaseh.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxUserShenaseh.Size = New System.Drawing.Size(136, 28)
        Me.UcTextBoxUserShenaseh.TabIndex = 5
        Me.UcTextBoxUserShenaseh.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxUserShenaseh.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxUserShenaseh.UCBorder = System.Windows.Forms.BorderStyle.None
        Me.UcTextBoxUserShenaseh.UCEnable = true
        Me.UcTextBoxUserShenaseh.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxUserShenaseh.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxUserShenaseh.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxUserShenaseh.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxUserShenaseh.UCMultiLine = false
        Me.UcTextBoxUserShenaseh.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxUserShenaseh.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxUserShenaseh.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxUserShenaseh.UCValue = ""
        '
        'UcLabelUserShenaseh
        '
        Me.UcLabelUserShenaseh._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelUserShenaseh._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelUserShenaseh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelUserShenaseh.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserShenaseh.Location = New System.Drawing.Point(147, 6)
        Me.UcLabelUserShenaseh.Name = "UcLabelUserShenaseh"
        Me.UcLabelUserShenaseh.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelUserShenaseh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelUserShenaseh.Size = New System.Drawing.Size(116, 32)
        Me.UcLabelUserShenaseh.TabIndex = 8
        Me.UcLabelUserShenaseh.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserShenaseh.UCFont = New System.Drawing.Font("B Homa", 14.25!)
        Me.UcLabelUserShenaseh.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelUserShenaseh.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelUserShenaseh.UCValue = "شناسه کاربر : "
        '
        'UcLabelUserPassword
        '
        Me.UcLabelUserPassword._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelUserPassword._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelUserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelUserPassword.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserPassword.Location = New System.Drawing.Point(154, 41)
        Me.UcLabelUserPassword.Name = "UcLabelUserPassword"
        Me.UcLabelUserPassword.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelUserPassword.Size = New System.Drawing.Size(116, 32)
        Me.UcLabelUserPassword.TabIndex = 9
        Me.UcLabelUserPassword.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserPassword.UCFont = New System.Drawing.Font("B Homa", 14.25!)
        Me.UcLabelUserPassword.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelUserPassword.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelUserPassword.UCValue = "رمز عبور کاربر : "
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = true
        Me.PnlMain.BorderColor = System.Drawing.Color.Black
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.UcButtonSpecial)
        Me.PnlMain.Controls.Add(Me.UcTextBoxUserShenaseh)
        Me.PnlMain.Controls.Add(Me.UcTextBoxUserPassword)
        Me.PnlMain.Controls.Add(Me.UcLabelUserPassword)
        Me.PnlMain.Controls.Add(Me.UcLabelUserShenaseh)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Gradient = true
        Me.PnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlMain.GradientOffset = 1!
        Me.PnlMain.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlMain.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlMain.Grayscale = false
        Me.PnlMain.Image = Nothing
        Me.PnlMain.ImageAlpha = 75
        Me.PnlMain.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlMain.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Rounded = true
        Me.PnlMain.Size = New System.Drawing.Size(279, 130)
        Me.PnlMain.TabIndex = 4
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlMain
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlMain
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(16, 82)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(113, 40)
        Me.UcButtonSpecial.TabIndex = 10
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = true
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "تایید"
        '
        'UCUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUserLogin"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(285, 136)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents UcTextBoxUserShenaseh As UCTextBox
    Friend WithEvents UcTextBoxUserPassword As UCTextBox
    Friend WithEvents UcLabelUserPassword As UCLabel
    Friend WithEvents UcLabelUserShenaseh As UCLabel
    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcButtonSpecial As UCButtonSpecial
End Class
