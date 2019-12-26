Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCLoadAllocationCollectionAdvance
    Inherits UCGeneralExtended

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCLoadAllocationCollectionAdvance))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.ChkTransportCompany = New System.Windows.Forms.CheckBox()
        Me.UcSearcherTransportCompanies = New R2CoreTransportationAndLoadNotification.UCSearcherTransportCompanies()
        Me.UcucLoadAllocationCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadAllocationCollection()
        Me.UcucLoadAllocationStatusCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadAllocationStatusCollection()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.ChkTransportCompany)
        Me.PnlMain.Controls.Add(Me.UcSearcherTransportCompanies)
        Me.PnlMain.Controls.Add(Me.UcucLoadAllocationCollection)
        Me.PnlMain.Controls.Add(Me.UcucLoadAllocationStatusCollection)
        Me.PnlMain.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(851, 469)
        Me.PnlMain.TabIndex = 0
        '
        'ChkTransportCompany
        '
        Me.ChkTransportCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ChkTransportCompany.AutoSize = true
        Me.ChkTransportCompany.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkTransportCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkTransportCompany.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ChkTransportCompany.FlatAppearance.BorderSize = 10
        Me.ChkTransportCompany.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.ChkTransportCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.ChkTransportCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.ChkTransportCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkTransportCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkTransportCompany.Location = New System.Drawing.Point(832, 98)
        Me.ChkTransportCompany.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkTransportCompany.Name = "ChkTransportCompany"
        Me.ChkTransportCompany.Size = New System.Drawing.Size(12, 11)
        Me.ChkTransportCompany.TabIndex = 5
        Me.ChkTransportCompany.UseVisualStyleBackColor = true
        '
        'UcSearcherTransportCompanies
        '
        Me.UcSearcherTransportCompanies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherTransportCompanies.Location = New System.Drawing.Point(602, 87)
        Me.UcSearcherTransportCompanies.Name = "UcSearcherTransportCompanies"
        Me.UcSearcherTransportCompanies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherTransportCompanies.Size = New System.Drawing.Size(227, 31)
        Me.UcSearcherTransportCompanies.TabIndex = 4
        Me.UcSearcherTransportCompanies.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherTransportCompanies.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherTransportCompanies.UCFontSearch = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherTransportCompanies.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherTransportCompanies.UCIcon = CType(resources.GetObject("UcSearcherTransportCompanies.UCIcon"),System.Drawing.Image)
        Me.UcSearcherTransportCompanies.UCMaximizeHight = CType(300,Long)
        Me.UcSearcherTransportCompanies.UCMinimizeHight = CType(31,Long)
        Me.UcSearcherTransportCompanies.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherTransportCompanies.UCShowDomainIcon = false
        '
        'UcucLoadAllocationCollection
        '
        Me.UcucLoadAllocationCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadAllocationCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadAllocationCollection.Location = New System.Drawing.Point(3, 124)
        Me.UcucLoadAllocationCollection.Name = "UcucLoadAllocationCollection"
        Me.UcucLoadAllocationCollection.Size = New System.Drawing.Size(845, 342)
        Me.UcucLoadAllocationCollection.TabIndex = 2
        '
        'UcucLoadAllocationStatusCollection
        '
        Me.UcucLoadAllocationStatusCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadAllocationStatusCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadAllocationStatusCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucLoadAllocationStatusCollection.Location = New System.Drawing.Point(3, 87)
        Me.UcucLoadAllocationStatusCollection.Name = "UcucLoadAllocationStatusCollection"
        Me.UcucLoadAllocationStatusCollection.Size = New System.Drawing.Size(593, 31)
        Me.UcucLoadAllocationStatusCollection.TabIndex = 1
        Me.UcucLoadAllocationStatusCollection.UCCurrentNSS = Nothing
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(3, 3)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(845, 80)
        Me.UcAnnouncementHallSelection.TabIndex = 0
        '
        'UCUCLoadAllocationCollectionAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCLoadAllocationCollectionAdvance"
        Me.Size = New System.Drawing.Size(851, 469)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcucLoadAllocationStatusCollection As UCUCLoadAllocationStatusCollection
    Friend WithEvents UcAnnouncementHallSelection As UCAnnouncementHallSelection
    Friend WithEvents UcucLoadAllocationCollection As UCUCLoadAllocationCollection
    Friend WithEvents ChkTransportCompany As Windows.Forms.CheckBox
    Friend WithEvents UcSearcherTransportCompanies As UCSearcherTransportCompanies
End Class
