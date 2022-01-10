<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTimeEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCTimeEntry))
        Me.PnlTimeObjects = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcTextBoxSecond = New R2CoreGUI.UCTextBox()
        Me.UcTextBoxMinute = New R2CoreGUI.UCTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcTextBoxHour = New R2CoreGUI.UCTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlTimeObjects.SuspendLayout
        CType(Me.PictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlTimeObjects
        '
        Me.PnlTimeObjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTimeObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlTimeObjects.Border = false
        Me.PnlTimeObjects.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlTimeObjects.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlTimeObjects.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlTimeObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlTimeObjects.Controls.Add(Me.UcTextBoxSecond)
        Me.PnlTimeObjects.Controls.Add(Me.UcTextBoxMinute)
        Me.PnlTimeObjects.Controls.Add(Me.Label2)
        Me.PnlTimeObjects.Controls.Add(Me.UcTextBoxHour)
        Me.PnlTimeObjects.Controls.Add(Me.Label1)
        Me.PnlTimeObjects.CornerRadius = 20
        Me.PnlTimeObjects.Corners = BlueActivity.Controls.Corner.None
        Me.PnlTimeObjects.Gradient = true
        Me.PnlTimeObjects.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlTimeObjects.GradientOffset = 1!
        Me.PnlTimeObjects.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlTimeObjects.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlTimeObjects.Grayscale = false
        Me.PnlTimeObjects.Image = Nothing
        Me.PnlTimeObjects.ImageAlpha = 75
        Me.PnlTimeObjects.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlTimeObjects.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlTimeObjects.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlTimeObjects.Location = New System.Drawing.Point(20, -1)
        Me.PnlTimeObjects.Name = "PnlTimeObjects"
        Me.PnlTimeObjects.Rounded = True
        Me.PnlTimeObjects.Size = New System.Drawing.Size(130, 28)
        Me.PnlTimeObjects.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlTimeObjects
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlTimeObjects
        '
        'UcTextBoxSecond
        '
        Me.UcTextBoxSecond.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxSecond.ForeColor = System.Drawing.Color.Black
        Me.UcTextBoxSecond.Location = New System.Drawing.Point(96, 0)
        Me.UcTextBoxSecond.Name = "UcTextBoxSecond"
        Me.UcTextBoxSecond.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxSecond.Size = New System.Drawing.Size(31, 23)
        Me.UcTextBoxSecond.TabIndex = 7
        Me.UcTextBoxSecond.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxSecond.UCBackColorDisable = System.Drawing.Color.White
        Me.UcTextBoxSecond.UCBorder = False
        Me.UcTextBoxSecond.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxSecond.UCBorderCornerRedius = 0
        Me.UcTextBoxSecond.UCEnable = True
        Me.UcTextBoxSecond.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxSecond.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxSecond.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxSecond.UCMaxCharacterReached = CType(2, Short)
        Me.UcTextBoxSecond.UCMaxNumber = CType(59, Long)
        Me.UcTextBoxSecond.UCMultiLine = False
        Me.UcTextBoxSecond.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxSecond.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxSecond.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxSecond.UCValue = "88"
        '
        'UcTextBoxMinute
        '
        Me.UcTextBoxMinute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxMinute.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxMinute.ForeColor = System.Drawing.Color.Black
        Me.UcTextBoxMinute.Location = New System.Drawing.Point(51, 0)
        Me.UcTextBoxMinute.Name = "UcTextBoxMinute"
        Me.UcTextBoxMinute.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxMinute.Size = New System.Drawing.Size(30, 23)
        Me.UcTextBoxMinute.TabIndex = 5
        Me.UcTextBoxMinute.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxMinute.UCBackColorDisable = System.Drawing.Color.White
        Me.UcTextBoxMinute.UCBorder = False
        Me.UcTextBoxMinute.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxMinute.UCBorderCornerRedius = 0
        Me.UcTextBoxMinute.UCEnable = True
        Me.UcTextBoxMinute.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxMinute.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxMinute.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxMinute.UCMaxCharacterReached = CType(2, Short)
        Me.UcTextBoxMinute.UCMaxNumber = CType(59, Long)
        Me.UcTextBoxMinute.UCMultiLine = False
        Me.UcTextBoxMinute.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxMinute.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxMinute.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxMinute.UCValue = "88"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ":"
        '
        'UcTextBoxHour
        '
        Me.UcTextBoxHour.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxHour.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxHour.ForeColor = System.Drawing.Color.Black
        Me.UcTextBoxHour.Location = New System.Drawing.Point(4, 0)
        Me.UcTextBoxHour.Name = "UcTextBoxHour"
        Me.UcTextBoxHour.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxHour.Size = New System.Drawing.Size(42, 23)
        Me.UcTextBoxHour.TabIndex = 1
        Me.UcTextBoxHour.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxHour.UCBackColorDisable = System.Drawing.Color.White
        Me.UcTextBoxHour.UCBorder = False
        Me.UcTextBoxHour.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxHour.UCBorderCornerRedius = 0
        Me.UcTextBoxHour.UCEnable = True
        Me.UcTextBoxHour.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxHour.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxHour.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxHour.UCMaxCharacterReached = CType(2, Short)
        Me.UcTextBoxHour.UCMaxNumber = CType(23, Long)
        Me.UcTextBoxHour.UCMultiLine = False
        Me.UcTextBoxHour.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxHour.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxHour.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxHour.UCValue = "88"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":"
        '
        'PictureBox
        '
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(22, 27)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = False
        Me.PnlMain.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.PictureBox)
        Me.PnlMain.Controls.Add(Me.PnlTimeObjects)
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
        Me.PnlMain.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlMain.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Rounded = True
        Me.PnlMain.Size = New System.Drawing.Size(150, 27)
        Me.PnlMain.TabIndex = 1
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlMain
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlMain
        '
        'UCTimeEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTimeEntry"
        Me.Size = New System.Drawing.Size(150, 27)
        Me.PnlTimeObjects.ResumeLayout(false)
        Me.PnlTimeObjects.PerformLayout
        CType(Me.PictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTimeObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcTextBoxHour As UCTextBox
    Friend WithEvents UcTextBoxSecond As UCTextBox
    Friend WithEvents UcTextBoxMinute As UCTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
