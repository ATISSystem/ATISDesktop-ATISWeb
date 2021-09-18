Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport))
        Dim R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1 As R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = New R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure()
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport = New System.Windows.Forms.Panel()
        Me.UcSearcherLoadTargets = New R2CoreTransportationAndLoadNotification.UCSearcherLoadTargets()
        Me.ChkLoadTargetCity = New System.Windows.Forms.CheckBox()
        Me.UcSearcherTransportCompanies = New PayanehClassLibrary.UCSearcherTransportCompanies()
        Me.PnlAnnouncementHallSelection = New System.Windows.Forms.Panel()
        Me.UcucAnnouncementHallCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection()
        Me.RBAllAnnouncementHall = New System.Windows.Forms.RadioButton()
        Me.RBSpecialAnnouncementHall = New System.Windows.Forms.RadioButton()
        Me.RBSpecialCompany = New System.Windows.Forms.RadioButton()
        Me.RBAllCompany = New System.Windows.Forms.RadioButton()
        Me.UcDateTimeHolder = New R2CoreGUI.UCDateTimeHolder()
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.SuspendLayout()
        Me.PnlAnnouncementHallSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport
        '
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.UcSearcherTransportCompanies)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.UcSearcherLoadTargets)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.ChkLoadTargetCity)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.PnlAnnouncementHallSelection)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.RBSpecialCompany)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.RBAllCompany)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Name = "PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport"
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.TabIndex = 209
        '
        'UcSearcherLoadTargets
        '
        Me.UcSearcherLoadTargets.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcherLoadTargets.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoadTargets.Location = New System.Drawing.Point(548, 158)
        Me.UcSearcherLoadTargets.Name = "UcSearcherLoadTargets"
        Me.UcSearcherLoadTargets.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoadTargets.Size = New System.Drawing.Size(229, 31)
        Me.UcSearcherLoadTargets.TabIndex = 20
        Me.UcSearcherLoadTargets.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoadTargets.UCFontList = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcSearcherLoadTargets.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadTargets.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoadTargets.UCIcon = Nothing
        Me.UcSearcherLoadTargets.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoadTargets.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoadTargets.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherLoadTargets.UCShowDomainIcon = False
        '
        'ChkLoadTargetCity
        '
        Me.ChkLoadTargetCity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkLoadTargetCity.AutoSize = True
        Me.ChkLoadTargetCity.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkLoadTargetCity.Location = New System.Drawing.Point(878, 155)
        Me.ChkLoadTargetCity.Name = "ChkLoadTargetCity"
        Me.ChkLoadTargetCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkLoadTargetCity.Size = New System.Drawing.Size(82, 33)
        Me.ChkLoadTargetCity.TabIndex = 19
        Me.ChkLoadTargetCity.Text = "مقصد بار"
        Me.ChkLoadTargetCity.UseVisualStyleBackColor = True
        '
        'UcSearcherTransportCompanies
        '
        Me.UcSearcherTransportCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcherTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherTransportCompanies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSearcherTransportCompanies.Location = New System.Drawing.Point(548, 119)
        Me.UcSearcherTransportCompanies.Name = "UcSearcherTransportCompanies"
        Me.UcSearcherTransportCompanies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherTransportCompanies.Size = New System.Drawing.Size(229, 33)
        Me.UcSearcherTransportCompanies.TabIndex = 18
        Me.UcSearcherTransportCompanies.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcSearcherTransportCompanies.UCFontList = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherTransportCompanies.UCIcon = CType(resources.GetObject("UcSearcherTransportCompanies.UCIcon"), System.Drawing.Image)
        Me.UcSearcherTransportCompanies.UCMaximizeHight = CType(200, Long)
        Me.UcSearcherTransportCompanies.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherTransportCompanies.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherTransportCompanies.UCShowDomainIcon = True
        '
        'PnlAnnouncementHallSelection
        '
        Me.PnlAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlAnnouncementHallSelection.Controls.Add(Me.UcucAnnouncementHallCollection)
        Me.PnlAnnouncementHallSelection.Controls.Add(Me.RBAllAnnouncementHall)
        Me.PnlAnnouncementHallSelection.Controls.Add(Me.RBSpecialAnnouncementHall)
        Me.PnlAnnouncementHallSelection.Location = New System.Drawing.Point(3, 10)
        Me.PnlAnnouncementHallSelection.Name = "PnlAnnouncementHallSelection"
        Me.PnlAnnouncementHallSelection.Size = New System.Drawing.Size(989, 103)
        Me.PnlAnnouncementHallSelection.TabIndex = 16
        '
        'UcucAnnouncementHallCollection
        '
        Me.UcucAnnouncementHallCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucAnnouncementHallCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallCollection.Location = New System.Drawing.Point(27, 47)
        Me.UcucAnnouncementHallCollection.Name = "UcucAnnouncementHallCollection"
        Me.UcucAnnouncementHallCollection.Size = New System.Drawing.Size(940, 46)
        Me.UcucAnnouncementHallCollection.TabIndex = 17
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.Active = True
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHColor = "Green"
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHId = CType(2, Long)
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHTitle = "سالن اعلام بار جاده ای"
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.Deleted = False
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.ViewFlag = True
        Me.UcucAnnouncementHallCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1
        Me.UcucAnnouncementHallCollection.UCDefaultAHId = CType(2, Long)
        Me.UcucAnnouncementHallCollection.UCViewBorder = True
        '
        'RBAllAnnouncementHall
        '
        Me.RBAllAnnouncementHall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBAllAnnouncementHall.AutoSize = True
        Me.RBAllAnnouncementHall.Checked = True
        Me.RBAllAnnouncementHall.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RBAllAnnouncementHall.Location = New System.Drawing.Point(886, 14)
        Me.RBAllAnnouncementHall.Name = "RBAllAnnouncementHall"
        Me.RBAllAnnouncementHall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBAllAnnouncementHall.Size = New System.Drawing.Size(71, 27)
        Me.RBAllAnnouncementHall.TabIndex = 10
        Me.RBAllAnnouncementHall.TabStop = True
        Me.RBAllAnnouncementHall.Text = "همه بارها"
        Me.RBAllAnnouncementHall.UseVisualStyleBackColor = True
        '
        'RBSpecialAnnouncementHall
        '
        Me.RBSpecialAnnouncementHall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBSpecialAnnouncementHall.AutoSize = True
        Me.RBSpecialAnnouncementHall.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RBSpecialAnnouncementHall.Location = New System.Drawing.Point(688, 14)
        Me.RBSpecialAnnouncementHall.Name = "RBSpecialAnnouncementHall"
        Me.RBSpecialAnnouncementHall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBSpecialAnnouncementHall.Size = New System.Drawing.Size(160, 27)
        Me.RBSpecialAnnouncementHall.TabIndex = 15
        Me.RBSpecialAnnouncementHall.Text = "بار مرتبط با سالن انتخاب شده"
        Me.RBSpecialAnnouncementHall.UseVisualStyleBackColor = True
        '
        'RBSpecialCompany
        '
        Me.RBSpecialCompany.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBSpecialCompany.AutoSize = True
        Me.RBSpecialCompany.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RBSpecialCompany.Location = New System.Drawing.Point(794, 122)
        Me.RBSpecialCompany.Name = "RBSpecialCompany"
        Me.RBSpecialCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBSpecialCompany.Size = New System.Drawing.Size(57, 27)
        Me.RBSpecialCompany.TabIndex = 13
        Me.RBSpecialCompany.Text = "شرکت"
        Me.RBSpecialCompany.UseVisualStyleBackColor = True
        '
        'RBAllCompany
        '
        Me.RBAllCompany.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBAllCompany.AutoSize = True
        Me.RBAllCompany.Checked = True
        Me.RBAllCompany.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RBAllCompany.Location = New System.Drawing.Point(867, 122)
        Me.RBAllCompany.Name = "RBAllCompany"
        Me.RBAllCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBAllCompany.Size = New System.Drawing.Size(93, 27)
        Me.RBAllCompany.TabIndex = 11
        Me.RBAllCompany.TabStop = True
        Me.RBAllCompany.Text = "همه شرکت ها"
        Me.RBAllCompany.UseVisualStyleBackColor = True
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(398, 229)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(199, 186)
        Me.UcDateTimeHolder.TabIndex = 9
        Me.UcDateTimeHolder.UCDisableTimeSetting = False
        Me.UcDateTimeHolder.UCTime1 = "00:00:00"
        Me.UcDateTimeHolder.UCTime2 = "23:59:59"
        Me.UcDateTimeHolder.UCViewTitle = False
        '
        'FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport"
        Me.Text = "FrmcCapacitorLoadsTransportCompaniesRegisteredLoads"
        Me.Controls.SetChildIndex(Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport, 0)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.ResumeLayout(false)
        Me.PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport.PerformLayout
        Me.PnlAnnouncementHallSelection.ResumeLayout(false)
        Me.PnlAnnouncementHallSelection.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlCapacitorLoadsTransportCompaniesRegisteredLoadsReport As System.Windows.Forms.Panel
    Friend WithEvents UcDateTimeHolder As UCDateTimeHolder
    Friend WithEvents RBSpecialCompany As System.Windows.Forms.RadioButton
    Friend WithEvents RBAllCompany As System.Windows.Forms.RadioButton
    Friend WithEvents RBAllAnnouncementHall As System.Windows.Forms.RadioButton
    Friend WithEvents PnlAnnouncementHallSelection As System.Windows.Forms.Panel
    Friend WithEvents RBSpecialAnnouncementHall As System.Windows.Forms.RadioButton
    Friend WithEvents UcucAnnouncementHallCollection As R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection
    Friend WithEvents UcSearcherTransportCompanies As UCSearcherTransportCompanies
    Friend WithEvents ChkLoadTargetCity As Windows.Forms.CheckBox
    Friend WithEvents UcSearcherLoadTargets As R2CoreTransportationAndLoadNotification.UCSearcherLoadTargets
End Class
