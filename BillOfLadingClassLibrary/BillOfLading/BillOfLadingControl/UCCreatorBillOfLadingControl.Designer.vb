Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCreatorBillOfLadingControl
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
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty1 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty2 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcButtonCButtonTransferInformation = New R2CoreGUI.UCButtonCButton()
        Me.UcButtonCButtonPathOfFile = New R2CoreGUI.UCButtonCButton()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcTextBoxPathOfFile = New R2CoreGUI.UCTextBox()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcPersianTextBoxBLCTitle = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.AlphaGradientPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(579, 205)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlOutter.Size = New System.Drawing.Size(579, 205)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcButtonCButtonTransferInformation)
        Me.PnlInner.Controls.Add(Me.UcButtonCButtonPathOfFile)
        Me.PnlInner.Controls.Add(Me.UcLabel3)
        Me.PnlInner.Controls.Add(Me.AlphaGradientPanel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(577, 203)
        Me.PnlInner.TabIndex = 0
        '
        'UcButtonCButtonTransferInformation
        '
        Me.UcButtonCButtonTransferInformation.Location = New System.Drawing.Point(33, 160)
        Me.UcButtonCButtonTransferInformation.Name = "UcButtonCButtonTransferInformation"
        Me.UcButtonCButtonTransferInformation.Size = New System.Drawing.Size(204, 37)
        Me.UcButtonCButtonTransferInformation.TabIndex = 7
        Me.UcButtonCButtonTransferInformation.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.RoyalBlue, System.Drawing.Color.Black}
        CBlendItems1.iPoint = New Single() {0!, 1!}
        Me.UcButtonCButtonTransferInformation.UCColorFillBlend = CBlendItems1
        Me.UcButtonCButtonTransferInformation.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty1.LowerLeft = 16
        CornersProperty1.UpperRight = 16
        Me.UcButtonCButtonTransferInformation.UCCorners = CornersProperty1
        Me.UcButtonCButtonTransferInformation.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonTransferInformation.UCEnable = true
        Me.UcButtonCButtonTransferInformation.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonCButtonTransferInformation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonTransferInformation.UCText = "انتقال اطلاعات به بانک اطلاعاتی"
        '
        'UcButtonCButtonPathOfFile
        '
        Me.UcButtonCButtonPathOfFile.Location = New System.Drawing.Point(33, 7)
        Me.UcButtonCButtonPathOfFile.Name = "UcButtonCButtonPathOfFile"
        Me.UcButtonCButtonPathOfFile.Size = New System.Drawing.Size(122, 37)
        Me.UcButtonCButtonPathOfFile.TabIndex = 0
        Me.UcButtonCButtonPathOfFile.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.CornflowerBlue, System.Drawing.Color.Navy}
        CBlendItems2.iPoint = New Single() {0!, 1!}
        Me.UcButtonCButtonPathOfFile.UCColorFillBlend = CBlendItems2
        Me.UcButtonCButtonPathOfFile.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty2.LowerLeft = 16
        CornersProperty2.UpperRight = 16
        Me.UcButtonCButtonPathOfFile.UCCorners = CornersProperty2
        Me.UcButtonCButtonPathOfFile.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonPathOfFile.UCEnable = true
        Me.UcButtonCButtonPathOfFile.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonCButtonPathOfFile.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonPathOfFile.UCText = "انتخاب فایل"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(363, 1)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcLabel3.Size = New System.Drawing.Size(165, 40)
        Me.UcLabel3.TabIndex = 6
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "فایل کنترل بارنامه"
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = true
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabel1)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcTextBoxPathOfFile)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabel2)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcPersianTextBoxBLCTitle)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = BlueActivity.Controls.Corner.TopRight
        Me.AlphaGradientPanel1.Gradient = true
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = false
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(7, 25)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = true
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(563, 156)
        Me.AlphaGradientPanel1.TabIndex = 5
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(31, 29)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcLabel1.Size = New System.Drawing.Size(86, 17)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "PathOfFile :"
        '
        'UcTextBoxPathOfFile
        '
        Me.UcTextBoxPathOfFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxPathOfFile.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxPathOfFile.Location = New System.Drawing.Point(26, 25)
        Me.UcTextBoxPathOfFile.Name = "UcTextBoxPathOfFile"
        Me.UcTextBoxPathOfFile.Size = New System.Drawing.Size(503, 27)
        Me.UcTextBoxPathOfFile.TabIndex = 0
        Me.UcTextBoxPathOfFile.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxPathOfFile.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxPathOfFile.UCBorder = true
        Me.UcTextBoxPathOfFile.UCBorderColor = System.Drawing.Color.Blue
        Me.UcTextBoxPathOfFile.UCEnable = true
        Me.UcTextBoxPathOfFile.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxPathOfFile.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxPathOfFile.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxPathOfFile.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxPathOfFile.UCMaxNumber = CType(99999,Long)
        Me.UcTextBoxPathOfFile.UCMultiLine = false
        Me.UcTextBoxPathOfFile.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxPathOfFile.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxPathOfFile.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxPathOfFile.UCValue = ""
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(24, 52)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcLabel2.Size = New System.Drawing.Size(505, 31)
        Me.UcLabel2.TabIndex = 4
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "عنوانی برای فایل مورد نظر وارد نمایید و سپس کلید انتقال اطلاعات را فشار دهید"
        '
        'UcPersianTextBoxBLCTitle
        '
        Me.UcPersianTextBoxBLCTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxBLCTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxBLCTitle.Location = New System.Drawing.Point(111, 84)
        Me.UcPersianTextBoxBLCTitle.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxBLCTitle.Name = "UcPersianTextBoxBLCTitle"
        Me.UcPersianTextBoxBLCTitle.Size = New System.Drawing.Size(330, 26)
        Me.UcPersianTextBoxBLCTitle.TabIndex = 3
        Me.UcPersianTextBoxBLCTitle.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxBLCTitle.UCBorder = true
        Me.UcPersianTextBoxBLCTitle.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxBLCTitle.UCEnable = true
        Me.UcPersianTextBoxBLCTitle.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxBLCTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxBLCTitle.UCMultiLine = false
        Me.UcPersianTextBoxBLCTitle.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxBLCTitle.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxBLCTitle.UCValue = ""
        '
        'UCCreatorBillOfLadingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCreatorBillOfLadingControl"
        Me.Size = New System.Drawing.Size(579, 205)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.AlphaGradientPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcTextBoxPathOfFile As R2CoreGUI.UCTextBox
    Friend WithEvents UcPersianTextBoxBLCTitle As UCPersianTextBox
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcButtonCButtonTransferInformation As UCButtonCButton
    Friend WithEvents UcButtonCButtonPathOfFile As UCButtonCButton
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
End Class
