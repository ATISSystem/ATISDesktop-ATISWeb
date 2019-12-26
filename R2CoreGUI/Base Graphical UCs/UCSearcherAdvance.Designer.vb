<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCSearcherAdvance
    Inherits UCGeneral

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSearcherAdvance))
        Me.UcPersianTextBox = New R2CoreGUI.UCPersianTextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.PictureBoxDomain = New System.Windows.Forms.PictureBox()
        Me.PictureBoxRefresh = New System.Windows.Forms.PictureBox()
        Me.PictureBoxArrows = New System.Windows.Forms.PictureBox()
        Me.PnlTop = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlListBox = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        CType(Me.PictureBoxDomain,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxRefresh,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxArrows,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlTop.SuspendLayout
        Me.PnlListBox.SuspendLayout
        Me.SuspendLayout
        '
        'UcPersianTextBox
        '
        Me.UcPersianTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox.Location = New System.Drawing.Point(30, 3)
        Me.UcPersianTextBox.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBox.Name = "UcPersianTextBox"
        Me.UcPersianTextBox.Size = New System.Drawing.Size(178, 24)
        Me.UcPersianTextBox.TabIndex = 0
        Me.UcPersianTextBox.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox.UCBorder = false
        Me.UcPersianTextBox.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox.UCEnable = true
        Me.UcPersianTextBox.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBox.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox.UCMultiLine = false
        Me.UcPersianTextBox.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox.UCValue = ""
        '
        'ListBox
        '
        Me.ListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.ListBox.ForeColor = System.Drawing.Color.Black
        Me.ListBox.FormattingEnabled = true
        Me.ListBox.IntegralHeight = false
        Me.ListBox.ItemHeight = 24
        Me.ListBox.Location = New System.Drawing.Point(3, 3)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(233, 0)
        Me.ListBox.TabIndex = 1
        '
        'PictureBoxDomain
        '
        Me.PictureBoxDomain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBoxDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxDomain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxDomain.Image = CType(resources.GetObject("PictureBoxDomain.Image"),System.Drawing.Image)
        Me.PictureBoxDomain.Location = New System.Drawing.Point(187, 3)
        Me.PictureBoxDomain.Name = "PictureBoxDomain"
        Me.PictureBoxDomain.Size = New System.Drawing.Size(23, 25)
        Me.PictureBoxDomain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxDomain.TabIndex = 4
        Me.PictureBoxDomain.TabStop = false
        Me.PictureBoxDomain.Visible = false
        '
        'PictureBoxRefresh
        '
        Me.PictureBoxRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxRefresh.Image = CType(resources.GetObject("PictureBoxRefresh.Image"),System.Drawing.Image)
        Me.PictureBoxRefresh.Location = New System.Drawing.Point(213, 3)
        Me.PictureBoxRefresh.Name = "PictureBoxRefresh"
        Me.PictureBoxRefresh.Size = New System.Drawing.Size(23, 25)
        Me.PictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRefresh.TabIndex = 3
        Me.PictureBoxRefresh.TabStop = false
        '
        'PictureBoxArrows
        '
        Me.PictureBoxArrows.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.PictureBoxArrows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxArrows.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxArrows.Image = CType(resources.GetObject("PictureBoxArrows.Image"),System.Drawing.Image)
        Me.PictureBoxArrows.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxArrows.Name = "PictureBoxArrows"
        Me.PictureBoxArrows.Size = New System.Drawing.Size(23, 25)
        Me.PictureBoxArrows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxArrows.TabIndex = 2
        Me.PictureBoxArrows.TabStop = false
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Border = true
        Me.PnlTop.BorderColor = System.Drawing.Color.Black
        Me.PnlTop.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlTop.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlTop.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlTop.Controls.Add(Me.PictureBoxDomain)
        Me.PnlTop.Controls.Add(Me.PictureBoxArrows)
        Me.PnlTop.Controls.Add(Me.PictureBoxRefresh)
        Me.PnlTop.Controls.Add(Me.UcPersianTextBox)
        Me.PnlTop.CornerRadius = 5
        Me.PnlTop.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Gradient = true
        Me.PnlTop.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlTop.GradientOffset = 1!
        Me.PnlTop.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlTop.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlTop.Grayscale = false
        Me.PnlTop.Image = Nothing
        Me.PnlTop.ImageAlpha = 75
        Me.PnlTop.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlTop.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlTop.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Rounded = true
        Me.PnlTop.Size = New System.Drawing.Size(239, 31)
        Me.PnlTop.TabIndex = 4
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlTop
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlTop
        '
        'PnlListBox
        '
        Me.PnlListBox.BackColor = System.Drawing.Color.Transparent
        Me.PnlListBox.Border = true
        Me.PnlListBox.BorderColor = System.Drawing.Color.Black
        Me.PnlListBox.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlListBox.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlListBox.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlListBox.Controls.Add(Me.ListBox)
        Me.PnlListBox.CornerRadius = 5
        Me.PnlListBox.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlListBox.Gradient = true
        Me.PnlListBox.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlListBox.GradientOffset = 1!
        Me.PnlListBox.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlListBox.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlListBox.Grayscale = false
        Me.PnlListBox.Image = Nothing
        Me.PnlListBox.ImageAlpha = 75
        Me.PnlListBox.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlListBox.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlListBox.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlListBox.Location = New System.Drawing.Point(0, 31)
        Me.PnlListBox.Name = "PnlListBox"
        Me.PnlListBox.Rounded = true
        Me.PnlListBox.Size = New System.Drawing.Size(239, 0)
        Me.PnlListBox.TabIndex = 5
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlListBox
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlListBox
        '
        'UCSearcherAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlListBox)
        Me.Controls.Add(Me.PnlTop)
        Me.Name = "UCSearcherAdvance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(239, 31)
        CType(Me.PictureBoxDomain,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxRefresh,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxArrows,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlTop.ResumeLayout(false)
        Me.PnlListBox.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcPersianTextBox As UCPersianTextBox
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents PictureBoxArrows As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxRefresh As PictureBox
    Friend WithEvents PictureBoxDomain As PictureBox
    Friend WithEvents PnlTop As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlListBox As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
End Class
