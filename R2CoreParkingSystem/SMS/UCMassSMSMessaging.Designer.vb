
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCMassSMSMessaging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMassSMSMessaging))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.UcPersianTextBox = New R2CoreGUI.UCPersianTextBox()
        Me.UcSearcherSMSTypes = New R2CoreParkingSystem.UCSearcherSMSTypes()
        Me.UcSearcherUserTypes = New R2CoreGUI.UCSearcherUserTypes()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcEntrySMSData = New R2CoreParkingSystem.UCEntrySMSData()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabel4)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Controls.Add(Me.UcButtonSpecial)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBox)
        Me.PnlMain.Controls.Add(Me.UcSearcherSMSTypes)
        Me.PnlMain.Controls.Add(Me.UcSearcherUserTypes)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcEntrySMSData)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(616, 533)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(212, 41)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(395, 32)
        Me.UcLabel3.TabIndex = 9
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel3.UCValue = "توجه : گزارش ارسال اس ام اس انبوه در بانک اطلاعات لاگ ثبت می شود"
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.Silver
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(616, 32)
        Me.UcLabelTop.TabIndex = 8
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.LightSteelBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelTop.UCValue = "ارسال انبوه اس ام اس"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(224, 105)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(79, 32)
        Me.UcLabel2.TabIndex = 7
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel2.UCValue = "نوع اس ام اس"
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(6, 38)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(143, 35)
        Me.UcButtonSpecial.TabIndex = 5
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = True
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "ارسال اس ام اس"
        '
        'UcPersianTextBox
        '
        Me.UcPersianTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox.Location = New System.Drawing.Point(6, 352)
        Me.UcPersianTextBox.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBox.Name = "UcPersianTextBox"
        Me.UcPersianTextBox.Size = New System.Drawing.Size(604, 174)
        Me.UcPersianTextBox.TabIndex = 3
        Me.UcPersianTextBox.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox.UCBorder = True
        Me.UcPersianTextBox.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox.UCEnable = False
        Me.UcPersianTextBox.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBox.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox.UCMultiLine = True
        Me.UcPersianTextBox.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox.UCValue = ""
        '
        'UcSearcherSMSTypes
        '
        Me.UcSearcherSMSTypes.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherSMSTypes.Location = New System.Drawing.Point(27, 105)
        Me.UcSearcherSMSTypes.Name = "UcSearcherSMSTypes"
        Me.UcSearcherSMSTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherSMSTypes.Size = New System.Drawing.Size(195, 31)
        Me.UcSearcherSMSTypes.TabIndex = 1
        Me.UcSearcherSMSTypes.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherSMSTypes.UCFillFirstTime = False
        Me.UcSearcherSMSTypes.UCFontList = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherSMSTypes.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherSMSTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherSMSTypes.UCIcon = Nothing
        Me.UcSearcherSMSTypes.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherSMSTypes.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherSMSTypes.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherSMSTypes.UCShowDomainIcon = False
        '
        'UcSearcherUserTypes
        '
        Me.UcSearcherUserTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherUserTypes.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherUserTypes.Location = New System.Drawing.Point(346, 105)
        Me.UcSearcherUserTypes.Name = "UcSearcherUserTypes"
        Me.UcSearcherUserTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherUserTypes.Size = New System.Drawing.Size(188, 31)
        Me.UcSearcherUserTypes.TabIndex = 0
        Me.UcSearcherUserTypes.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherUserTypes.UCFillFirstTime = False
        Me.UcSearcherUserTypes.UCFontList = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherUserTypes.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherUserTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherUserTypes.UCIcon = CType(resources.GetObject("UcSearcherUserTypes.UCIcon"), System.Drawing.Image)
        Me.UcSearcherUserTypes.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherUserTypes.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherUserTypes.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherUserTypes.UCShowDomainIcon = False
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(535, 104)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(59, 32)
        Me.UcLabel1.TabIndex = 6
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "نوع کاربر"
        '
        'UcEntrySMSData
        '
        Me.UcEntrySMSData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcEntrySMSData.BackColor = System.Drawing.Color.Transparent
        Me.UcEntrySMSData.Location = New System.Drawing.Point(-2, 142)
        Me.UcEntrySMSData.Name = "UcEntrySMSData"
        Me.UcEntrySMSData.Padding = New System.Windows.Forms.Padding(5)
        Me.UcEntrySMSData.Size = New System.Drawing.Size(620, 213)
        Me.UcEntrySMSData.TabIndex = 4
        '
        'UcLabel4
        '
        Me.UcLabel4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(215, 68)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(395, 32)
        Me.UcLabel4.TabIndex = 10
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel4.UCValue = "ارسال اس ام اس فقط برای کاربرانی است که فعال سازی انجام داده اند"
        '
        'UCMassSMSMessaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMassSMSMessaging"
        Me.Size = New System.Drawing.Size(616, 533)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcPersianTextBox As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcSearcherSMSTypes As UCSearcherSMSTypes
    Friend WithEvents UcSearcherUserTypes As R2CoreGUI.UCSearcherUserTypes
    Friend WithEvents UcEntrySMSData As UCEntrySMSData
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonSpecial As R2CoreGUI.UCButtonSpecial
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
End Class
