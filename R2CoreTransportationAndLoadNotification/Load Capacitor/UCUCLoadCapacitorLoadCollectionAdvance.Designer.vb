Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCLoadCapacitorLoadCollectionAdvance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCLoadCapacitorLoadCollectionAdvance))
        Dim R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1 As R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure = New R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.ChkTransportCompany = New System.Windows.Forms.CheckBox()
        Me.UcSearcherTransportCompanies = New R2CoreTransportationAndLoadNotification.UCSearcherTransportCompanies()
        Me.UcViewerCurrentLoadsStatisticsSummary = New R2CoreTransportationAndLoadNotification.UCViewerCurrentLoadsStatisticsSummary()
        Me.UcucLoadCapacitorLoadCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadCapacitorLoadCollection()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.ChkViewnCarNumZero = New System.Windows.Forms.CheckBox()
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallAnnounceTimeTypeCollection()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcPersianShamsiDate)
        Me.PnlMain.Controls.Add(Me.ChkTransportCompany)
        Me.PnlMain.Controls.Add(Me.UcSearcherTransportCompanies)
        Me.PnlMain.Controls.Add(Me.UcViewerCurrentLoadsStatisticsSummary)
        Me.PnlMain.Controls.Add(Me.UcucLoadCapacitorLoadCollection)
        Me.PnlMain.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.PnlMain.Controls.Add(Me.ChkViewnCarNumZero)
        Me.PnlMain.Controls.Add(Me.UcucAnnouncementHallAnnounceTimeTypeCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1254, 670)
        Me.PnlMain.TabIndex = 0
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(286, 91)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(145, 23)
        Me.UcPersianShamsiDate.TabIndex = 9
        Me.UcPersianShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'ChkTransportCompany
        '
        Me.ChkTransportCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkTransportCompany.AutoSize = True
        Me.ChkTransportCompany.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkTransportCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkTransportCompany.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ChkTransportCompany.FlatAppearance.BorderSize = 10
        Me.ChkTransportCompany.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.ChkTransportCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.ChkTransportCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.ChkTransportCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkTransportCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkTransportCompany.Location = New System.Drawing.Point(1239, 101)
        Me.ChkTransportCompany.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkTransportCompany.Name = "ChkTransportCompany"
        Me.ChkTransportCompany.Size = New System.Drawing.Size(12, 11)
        Me.ChkTransportCompany.TabIndex = 7
        Me.ChkTransportCompany.UseVisualStyleBackColor = True
        '
        'UcSearcherTransportCompanies
        '
        Me.UcSearcherTransportCompanies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherTransportCompanies.Location = New System.Drawing.Point(1009, 90)
        Me.UcSearcherTransportCompanies.Name = "UcSearcherTransportCompanies"
        Me.UcSearcherTransportCompanies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherTransportCompanies.Size = New System.Drawing.Size(227, 31)
        Me.UcSearcherTransportCompanies.TabIndex = 6
        Me.UcSearcherTransportCompanies.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherTransportCompanies.UCFillFirstTime = False
        Me.UcSearcherTransportCompanies.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCFontSearch = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherTransportCompanies.UCIcon = CType(resources.GetObject("UcSearcherTransportCompanies.UCIcon"), System.Drawing.Image)
        Me.UcSearcherTransportCompanies.UCMaximizeHight = CType(300, Long)
        Me.UcSearcherTransportCompanies.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherTransportCompanies.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherTransportCompanies.UCShowDomainIcon = False
        '
        'UcViewerCurrentLoadsStatisticsSummary
        '
        Me.UcViewerCurrentLoadsStatisticsSummary.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerCurrentLoadsStatisticsSummary.Location = New System.Drawing.Point(5, 93)
        Me.UcViewerCurrentLoadsStatisticsSummary.Name = "UcViewerCurrentLoadsStatisticsSummary"
        Me.UcViewerCurrentLoadsStatisticsSummary.Size = New System.Drawing.Size(114, 28)
        Me.UcViewerCurrentLoadsStatisticsSummary.TabIndex = 3
        '
        'UcucLoadCapacitorLoadCollection
        '
        Me.UcucLoadCapacitorLoadCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucLoadCapacitorLoadCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadCapacitorLoadCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucLoadCapacitorLoadCollection.Location = New System.Drawing.Point(3, 127)
        Me.UcucLoadCapacitorLoadCollection.Name = "UcucLoadCapacitorLoadCollection"
        Me.UcucLoadCapacitorLoadCollection.Size = New System.Drawing.Size(1248, 540)
        Me.UcucLoadCapacitorLoadCollection.TabIndex = 2
        Me.UcucLoadCapacitorLoadCollection.UCTimerInterval = CType(1, Long)
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(3, 3)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(1248, 84)
        Me.UcAnnouncementHallSelection.TabIndex = 0
        '
        'ChkViewnCarNumZero
        '
        Me.ChkViewnCarNumZero.AutoSize = True
        Me.ChkViewnCarNumZero.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkViewnCarNumZero.Location = New System.Drawing.Point(127, 91)
        Me.ChkViewnCarNumZero.Name = "ChkViewnCarNumZero"
        Me.ChkViewnCarNumZero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkViewnCarNumZero.Size = New System.Drawing.Size(146, 27)
        Me.ChkViewnCarNumZero.TabIndex = 8
        Me.ChkViewnCarNumZero.Text = "نمایش بار با موجودی صفر"
        Me.ChkViewnCarNumZero.UseVisualStyleBackColor = True
        '
        'UcucAnnouncementHallAnnounceTimeTypeCollection
        '
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.Location = New System.Drawing.Point(125, 90)
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.Name = "UcucAnnouncementHallAnnounceTimeTypeCollection"
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.Size = New System.Drawing.Size(878, 31)
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.TabIndex = 1
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1.AHATTypeColor = "Green                                                                            " &
    "                   "
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1.AHATTypeId = CType(1, Long)
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1.AHATTypeTitle = "آخرین بار اعلام شده                                                              " &
    "                   "
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1.Deleted = False
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1.OCode = ""
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1.OName = ""
        Me.UcucAnnouncementHallAnnounceTimeTypeCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure1
        '
        'UCUCLoadCapacitorLoadCollectionAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCLoadCapacitorLoadCollectionAdvance"
        Me.Size = New System.Drawing.Size(1254, 670)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcucLoadCapacitorLoadCollection As UCUCLoadCapacitorLoadCollection
    Friend WithEvents UcucAnnouncementHallAnnounceTimeTypeCollection As UCUCAnnouncementHallAnnounceTimeTypeCollection
    Friend WithEvents UcAnnouncementHallSelection As UCAnnouncementHallSelection
    Friend WithEvents UcViewerCurrentLoadsStatisticsSummary As UCViewerCurrentLoadsStatisticsSummary
    Friend WithEvents ChkTransportCompany As Windows.Forms.CheckBox
    Friend WithEvents UcSearcherTransportCompanies As UCSearcherTransportCompanies
    Friend WithEvents ChkViewnCarNumZero As Windows.Forms.CheckBox
    Friend WithEvents UcPersianShamsiDate As UCPersianShamsiDate
End Class
