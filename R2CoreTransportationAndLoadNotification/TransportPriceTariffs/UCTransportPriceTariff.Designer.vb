Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCTransportPriceTariff
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
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcSearcherLoadTargets = New R2CoreTransportationAndLoadNotification.UCSearcherLoadTargets()
        Me.UcSearcherLoadSources = New R2CoreTransportationAndLoadNotification.UCSearcherLoadSources()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.UcMoney = New R2CoreGUI.UCMoney()
        Me.UcButtonCButtonRegistering = New R2CoreGUI.UCButtonCButton()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcButtonCButtonDeleting = New R2CoreGUI.UCButtonCButton()
        Me.SuspendLayout()
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(448, 144)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcLabel2.Size = New System.Drawing.Size(74, 36)
        Me.UcLabel2.TabIndex = 4
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel2.UCValue = "مقصد حمل"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(712, 144)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcLabel1.Size = New System.Drawing.Size(88, 27)
        Me.UcLabel1.TabIndex = 3
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "مبدا حمل"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(192, 144)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcLabel3.Size = New System.Drawing.Size(74, 32)
        Me.UcLabel3.TabIndex = 5
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel3.UCValue = "تعرفه حمل"
        '
        'UcSearcherLoadTargets
        '
        Me.UcSearcherLoadTargets.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherLoadTargets.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoadTargets.Location = New System.Drawing.Point(275, 174)
        Me.UcSearcherLoadTargets.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcSearcherLoadTargets.Name = "UcSearcherLoadTargets"
        Me.UcSearcherLoadTargets.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoadTargets.Size = New System.Drawing.Size(245, 31)
        Me.UcSearcherLoadTargets.TabIndex = 2
        Me.UcSearcherLoadTargets.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoadTargets.UCFillFirstTime = False
        Me.UcSearcherLoadTargets.UCFontList = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcSearcherLoadTargets.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadTargets.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoadTargets.UCIcon = Nothing
        Me.UcSearcherLoadTargets.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoadTargets.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoadTargets.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherLoadTargets.UCShowDomainIcon = False
        '
        'UcSearcherLoadSources
        '
        Me.UcSearcherLoadSources.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherLoadSources.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoadSources.Location = New System.Drawing.Point(530, 174)
        Me.UcSearcherLoadSources.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcSearcherLoadSources.Name = "UcSearcherLoadSources"
        Me.UcSearcherLoadSources.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoadSources.Size = New System.Drawing.Size(245, 31)
        Me.UcSearcherLoadSources.TabIndex = 1
        Me.UcSearcherLoadSources.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoadSources.UCFillFirstTime = False
        Me.UcSearcherLoadSources.UCFontList = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcSearcherLoadSources.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadSources.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoadSources.UCIcon = Nothing
        Me.UcSearcherLoadSources.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoadSources.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoadSources.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherLoadSources.UCShowDomainIcon = False
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(4, 61)
        Me.UcAnnouncementHallSelection.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(774, 80)
        Me.UcAnnouncementHallSelection.TabIndex = 0
        '
        'UcMoney
        '
        Me.UcMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoney.Location = New System.Drawing.Point(70, 174)
        Me.UcMoney.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcMoney.Name = "UcMoney"
        Me.UcMoney.Size = New System.Drawing.Size(192, 31)
        Me.UcMoney.TabIndex = 6
        Me.UcMoney.UCBackColor = System.Drawing.Color.White
        Me.UcMoney.UCBorder = True
        Me.UcMoney.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcMoney.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcMoney.UCForeColor = System.Drawing.Color.Black
        Me.UcMoney.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcMoney.UCValue = ""
        '
        'UcButtonCButtonRegistering
        '
        Me.UcButtonCButtonRegistering.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonCButtonRegistering.Location = New System.Drawing.Point(307, 212)
        Me.UcButtonCButtonRegistering.Name = "UcButtonCButtonRegistering"
        Me.UcButtonCButtonRegistering.Size = New System.Drawing.Size(169, 38)
        Me.UcButtonCButtonRegistering.TabIndex = 8
        Me.UcButtonCButtonRegistering.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.LimeGreen, System.Drawing.Color.Green}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.UcButtonCButtonRegistering.UCColorFillBlend = CBlendItems1
        Me.UcButtonCButtonRegistering.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty1.LowerLeft = 16
        CornersProperty1.UpperRight = 16
        Me.UcButtonCButtonRegistering.UCCorners = CornersProperty1
        Me.UcButtonCButtonRegistering.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonRegistering.UCEnable = True
        Me.UcButtonCButtonRegistering.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCButtonRegistering.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonRegistering.UCText = "ثبت تعرفه حمل"
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
        Me.UcLabelTop.Size = New System.Drawing.Size(782, 52)
        Me.UcLabelTop.TabIndex = 351
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "تعرفه حمل"
        '
        'UcButtonCButtonDeleting
        '
        Me.UcButtonCButtonDeleting.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonCButtonDeleting.Location = New System.Drawing.Point(307, 256)
        Me.UcButtonCButtonDeleting.Name = "UcButtonCButtonDeleting"
        Me.UcButtonCButtonDeleting.Size = New System.Drawing.Size(169, 38)
        Me.UcButtonCButtonDeleting.TabIndex = 352
        Me.UcButtonCButtonDeleting.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0!, 1.0!}
        Me.UcButtonCButtonDeleting.UCColorFillBlend = CBlendItems2
        Me.UcButtonCButtonDeleting.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty2.LowerLeft = 16
        CornersProperty2.UpperRight = 16
        Me.UcButtonCButtonDeleting.UCCorners = CornersProperty2
        Me.UcButtonCButtonDeleting.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonDeleting.UCEnable = True
        Me.UcButtonCButtonDeleting.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCButtonDeleting.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonDeleting.UCText = "حذف تعرفه حمل"
        '
        'UCTransportPriceTariff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.UcButtonCButtonDeleting)
        Me.Controls.Add(Me.UcLabelTop)
        Me.Controls.Add(Me.UcButtonCButtonRegistering)
        Me.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.Controls.Add(Me.UcMoney)
        Me.Controls.Add(Me.UcSearcherLoadSources)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.UcSearcherLoadTargets)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.UcLabel1)
        Me.Name = "UCTransportPriceTariff"
        Me.Size = New System.Drawing.Size(782, 301)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel3 As R2CoreGUI.UCLabel
    Friend WithEvents UcSearcherLoadTargets As UCSearcherLoadTargets
    Friend WithEvents UcSearcherLoadSources As UCSearcherLoadSources
    Friend WithEvents UcAnnouncementHallSelection As UCAnnouncementHallSelection
    Friend WithEvents UcMoney As R2CoreGUI.UCMoney
    Friend WithEvents UcButtonCButtonRegistering As R2CoreGUI.UCButtonCButton
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents UcButtonCButtonDeleting As UCButtonCButton
End Class
