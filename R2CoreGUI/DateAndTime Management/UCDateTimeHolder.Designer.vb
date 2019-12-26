Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDateTimeHolder
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
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.UcTimeEntry1 = New R2CoreGUI.UCTimeEntry()
        Me.UcPersianShamsiDate1 = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcPersianShamsiDate2 = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcTimeEntry2 = New R2CoreGUI.UCTimeEntry()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlDateTimeObjects = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlMain.SuspendLayout
        Me.PnlDateTimeObjects.SuspendLayout
        Me.SuspendLayout
        '
        'UcLabel4
        '
        Me.UcLabel4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.Location = New System.Drawing.Point(142, 93)
        Me.UcLabel4.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel4.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel4.TabIndex = 13
        Me.UcLabel4.UCBackColor = System.Drawing.Color.White
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "تا ساعت:"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.Location = New System.Drawing.Point(142, 65)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel3.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel3.TabIndex = 12
        Me.UcLabel3.UCBackColor = System.Drawing.Color.White
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "تا تاریخ:"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(142, 37)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel2.TabIndex = 11
        Me.UcLabel2.UCBackColor = System.Drawing.Color.White
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "از ساعت:"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(142, 7)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel1.TabIndex = 10
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "از تاریخ:"
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(208, 52)
        Me.UcLabelTop.TabIndex = 348
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "محدوده زمانی"
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonSpecial.Location = New System.Drawing.Point(46, 130)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(125, 41)
        Me.UcButtonSpecial.TabIndex = 349
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = true
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "نمایش"
        '
        'UcTimeEntry1
        '
        Me.UcTimeEntry1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTimeEntry1.BackColor = System.Drawing.Color.Transparent
        Me.UcTimeEntry1.Location = New System.Drawing.Point(38, 39)
        Me.UcTimeEntry1.Name = "UcTimeEntry1"
        Me.UcTimeEntry1.Size = New System.Drawing.Size(106, 24)
        Me.UcTimeEntry1.TabIndex = 350
        Me.UcTimeEntry1.UCBackColor = System.Drawing.Color.White
        Me.UcTimeEntry1.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTimeEntry1.UCEnable = true
        Me.UcTimeEntry1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTimeEntry1.UCUserTime = "07:45:10"
        '
        'UcPersianShamsiDate1
        '
        Me.UcPersianShamsiDate1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianShamsiDate1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate1.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate1.Location = New System.Drawing.Point(6, 8)
        Me.UcPersianShamsiDate1.Name = "UcPersianShamsiDate1"
        Me.UcPersianShamsiDate1.Size = New System.Drawing.Size(138, 29)
        Me.UcPersianShamsiDate1.TabIndex = 351
        Me.UcPersianShamsiDate1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        '
        'UcPersianShamsiDate2
        '
        Me.UcPersianShamsiDate2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianShamsiDate2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate2.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate2.Location = New System.Drawing.Point(6, 65)
        Me.UcPersianShamsiDate2.Name = "UcPersianShamsiDate2"
        Me.UcPersianShamsiDate2.Size = New System.Drawing.Size(138, 29)
        Me.UcPersianShamsiDate2.TabIndex = 352
        Me.UcPersianShamsiDate2.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        '
        'UcTimeEntry2
        '
        Me.UcTimeEntry2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTimeEntry2.BackColor = System.Drawing.Color.Transparent
        Me.UcTimeEntry2.Location = New System.Drawing.Point(38, 95)
        Me.UcTimeEntry2.Name = "UcTimeEntry2"
        Me.UcTimeEntry2.Size = New System.Drawing.Size(106, 24)
        Me.UcTimeEntry2.TabIndex = 353
        Me.UcTimeEntry2.UCBackColor = System.Drawing.Color.White
        Me.UcTimeEntry2.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTimeEntry2.UCEnable = true
        Me.UcTimeEntry2.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTimeEntry2.UCUserTime = "07:45:10"
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlDateTimeObjects)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(208, 230)
        Me.PnlMain.TabIndex = 0
        '
        'PnlDateTimeObjects
        '
        Me.PnlDateTimeObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlDateTimeObjects.Border = false
        Me.PnlDateTimeObjects.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlDateTimeObjects.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlDateTimeObjects.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlDateTimeObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcPersianShamsiDate1)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcTimeEntry2)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcLabel4)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcPersianShamsiDate2)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcLabel3)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcLabel2)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcTimeEntry1)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcLabel1)
        Me.PnlDateTimeObjects.Controls.Add(Me.UcButtonSpecial)
        Me.PnlDateTimeObjects.CornerRadius = 20
        Me.PnlDateTimeObjects.Corners = BlueActivity.Controls.Corner.None
        Me.PnlDateTimeObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDateTimeObjects.Gradient = true
        Me.PnlDateTimeObjects.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlDateTimeObjects.GradientOffset = 1!
        Me.PnlDateTimeObjects.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlDateTimeObjects.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlDateTimeObjects.Grayscale = false
        Me.PnlDateTimeObjects.Image = Nothing
        Me.PnlDateTimeObjects.ImageAlpha = 75
        Me.PnlDateTimeObjects.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlDateTimeObjects.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlDateTimeObjects.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlDateTimeObjects.Location = New System.Drawing.Point(0, 52)
        Me.PnlDateTimeObjects.Name = "PnlDateTimeObjects"
        Me.PnlDateTimeObjects.Rounded = true
        Me.PnlDateTimeObjects.Size = New System.Drawing.Size(208, 178)
        Me.PnlDateTimeObjects.TabIndex = 354
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlDateTimeObjects
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlDateTimeObjects
        '
        'UCDateTimeHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDateTimeHolder"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(214, 236)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlDateTimeObjects.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents UcButtonSpecial As UCButtonSpecial
    Friend WithEvents UcTimeEntry1 As UCTimeEntry
    Friend WithEvents UcPersianShamsiDate1 As UCPersianShamsiDate
    Friend WithEvents UcPersianShamsiDate2 As UCPersianShamsiDate
    Friend WithEvents UcTimeEntry2 As UCTimeEntry
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlDateTimeObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
End Class
