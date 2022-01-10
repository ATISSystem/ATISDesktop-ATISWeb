<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersianShamsiDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPersianShamsiDate))
        Me.UcTextBoxDay = New R2CoreGUI.UCTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcTextBoxMonth = New R2CoreGUI.UCTextBox()
        Me.UcTextBoxYear = New R2CoreGUI.UCTextBox()
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.PnlDateObjects = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlMain.SuspendLayout
        CType(Me.PictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlDateObjects.SuspendLayout
        Me.SuspendLayout
        '
        'UcTextBoxDay
        '
        Me.UcTextBoxDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxDay.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxDay.Location = New System.Drawing.Point(93, 0)
        Me.UcTextBoxDay.Name = "UcTextBoxDay"
        Me.UcTextBoxDay.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxDay.Size = New System.Drawing.Size(30, 23)
        Me.UcTextBoxDay.TabIndex = 4
        Me.UcTextBoxDay.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxDay.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxDay.UCBorder = False
        Me.UcTextBoxDay.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxDay.UCBorderCornerRedius = 0
        Me.UcTextBoxDay.UCEnable = True
        Me.UcTextBoxDay.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxDay.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxDay.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxDay.UCMaxCharacterReached = CType(2, Short)
        Me.UcTextBoxDay.UCMaxNumber = CType(31, Long)
        Me.UcTextBoxDay.UCMultiLine = False
        Me.UcTextBoxDay.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxDay.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxDay.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxDay.UCValue = "08"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "/"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "/"
        '
        'UcTextBoxMonth
        '
        Me.UcTextBoxMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxMonth.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxMonth.Location = New System.Drawing.Point(59, 0)
        Me.UcTextBoxMonth.Name = "UcTextBoxMonth"
        Me.UcTextBoxMonth.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxMonth.Size = New System.Drawing.Size(26, 23)
        Me.UcTextBoxMonth.TabIndex = 1
        Me.UcTextBoxMonth.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxMonth.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxMonth.UCBorder = False
        Me.UcTextBoxMonth.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxMonth.UCBorderCornerRedius = 0
        Me.UcTextBoxMonth.UCEnable = True
        Me.UcTextBoxMonth.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxMonth.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxMonth.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxMonth.UCMaxCharacterReached = CType(2, Short)
        Me.UcTextBoxMonth.UCMaxNumber = CType(12, Long)
        Me.UcTextBoxMonth.UCMultiLine = False
        Me.UcTextBoxMonth.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxMonth.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxMonth.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxMonth.UCValue = "08"
        '
        'UcTextBoxYear
        '
        Me.UcTextBoxYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxYear.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxYear.Location = New System.Drawing.Point(0, 0)
        Me.UcTextBoxYear.Name = "UcTextBoxYear"
        Me.UcTextBoxYear.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxYear.Size = New System.Drawing.Size(53, 23)
        Me.UcTextBoxYear.TabIndex = 0
        Me.UcTextBoxYear.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxYear.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxYear.UCBorder = False
        Me.UcTextBoxYear.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxYear.UCBorderCornerRedius = 0
        Me.UcTextBoxYear.UCEnable = True
        Me.UcTextBoxYear.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxYear.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxYear.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxYear.UCMaxCharacterReached = CType(4, Short)
        Me.UcTextBoxYear.UCMaxNumber = CType(1500, Long)
        Me.UcTextBoxYear.UCMultiLine = False
        Me.UcTextBoxYear.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxYear.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxYear.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxYear.UCValue = "1397"
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = False
        Me.PnlMain.BorderColor = System.Drawing.Color.Black
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.PictureBox)
        Me.PnlMain.Controls.Add(Me.PnlDateObjects)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = BlueActivity.Controls.Corner.None
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Gradient = True
        Me.PnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlMain.GradientOffset = 1.0!
        Me.PnlMain.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlMain.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlMain.Grayscale = False
        Me.PnlMain.Image = Nothing
        Me.PnlMain.ImageAlpha = 75
        Me.PnlMain.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.ImagePosition = CType((BlueActivity.Controls.ImagePosition.TopLeft Or BlueActivity.Controls.ImagePosition.TopRight), BlueActivity.Controls.ImagePosition)
        Me.PnlMain.ImageSize = New System.Drawing.Size(20, 20)
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Rounded = False
        Me.PnlMain.Size = New System.Drawing.Size(145, 23)
        Me.PnlMain.TabIndex = 5
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
        'PictureBox
        '
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'PnlDateObjects
        '
        Me.PnlDateObjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDateObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlDateObjects.Border = False
        Me.PnlDateObjects.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlDateObjects.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlDateObjects.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlDateObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlDateObjects.Controls.Add(Me.UcTextBoxYear)
        Me.PnlDateObjects.Controls.Add(Me.Label1)
        Me.PnlDateObjects.Controls.Add(Me.UcTextBoxMonth)
        Me.PnlDateObjects.Controls.Add(Me.Label2)
        Me.PnlDateObjects.Controls.Add(Me.UcTextBoxDay)
        Me.PnlDateObjects.CornerRadius = 20
        Me.PnlDateObjects.Corners = BlueActivity.Controls.Corner.None
        Me.PnlDateObjects.Gradient = True
        Me.PnlDateObjects.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlDateObjects.GradientOffset = 1.0!
        Me.PnlDateObjects.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlDateObjects.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlDateObjects.Grayscale = False
        Me.PnlDateObjects.Image = Nothing
        Me.PnlDateObjects.ImageAlpha = 75
        Me.PnlDateObjects.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlDateObjects.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlDateObjects.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlDateObjects.Location = New System.Drawing.Point(20, 1)
        Me.PnlDateObjects.Name = "PnlDateObjects"
        Me.PnlDateObjects.Rounded = True
        Me.PnlDateObjects.Size = New System.Drawing.Size(123, 22)
        Me.PnlDateObjects.TabIndex = 5
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlDateObjects
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlDateObjects
        '
        'UCPersianShamsiDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPersianShamsiDate"
        Me.Size = New System.Drawing.Size(145, 23)
        Me.PnlMain.ResumeLayout(false)
        CType(Me.PictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlDateObjects.ResumeLayout(false)
        Me.PnlDateObjects.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents UcTextBoxYear As UCTextBox
    Friend WithEvents UcTextBoxDay As UCTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UcTextBoxMonth As UCTextBox
    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlDateObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PictureBox As PictureBox
End Class
