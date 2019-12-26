Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCLoadPermissionCollectionAdvance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCLoadPermissionCollectionAdvance))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.ChkTransportCompany = New System.Windows.Forms.CheckBox()
        Me.UcSearcherTransportCompanies = New R2CoreTransportationAndLoadNotification.UCSearcherTransportCompanies()
        Me.UcucLoadPermissionCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadPermissionCollection()
        Me.UcucLoadPermissionStatusCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadPermissionStatusCollection()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.UcLoadPermissionLocationSelection = New R2CoreTransportationAndLoadNotification.UCLoadPermissionLocationSelection()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.ChkTransportCompany)
        Me.PnlMain.Controls.Add(Me.UcSearcherTransportCompanies)
        Me.PnlMain.Controls.Add(Me.UcucLoadPermissionCollection)
        Me.PnlMain.Controls.Add(Me.UcucLoadPermissionStatusCollection)
        Me.PnlMain.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.PnlMain.Controls.Add(Me.UcLoadPermissionLocationSelection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(867, 473)
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
        Me.ChkTransportCompany.Location = New System.Drawing.Point(850, 101)
        Me.ChkTransportCompany.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkTransportCompany.Name = "ChkTransportCompany"
        Me.ChkTransportCompany.Size = New System.Drawing.Size(12, 11)
        Me.ChkTransportCompany.TabIndex = 9
        Me.ChkTransportCompany.UseVisualStyleBackColor = true
        '
        'UcSearcherTransportCompanies
        '
        Me.UcSearcherTransportCompanies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherTransportCompanies.Location = New System.Drawing.Point(620, 90)
        Me.UcSearcherTransportCompanies.Name = "UcSearcherTransportCompanies"
        Me.UcSearcherTransportCompanies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherTransportCompanies.Size = New System.Drawing.Size(227, 31)
        Me.UcSearcherTransportCompanies.TabIndex = 8
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
        'UcucLoadPermissionCollection
        '
        Me.UcucLoadPermissionCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadPermissionCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadPermissionCollection.Location = New System.Drawing.Point(3, 127)
        Me.UcucLoadPermissionCollection.Name = "UcucLoadPermissionCollection"
        Me.UcucLoadPermissionCollection.Size = New System.Drawing.Size(859, 343)
        Me.UcucLoadPermissionCollection.TabIndex = 3
        '
        'UcucLoadPermissionStatusCollection
        '
        Me.UcucLoadPermissionStatusCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadPermissionStatusCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadPermissionStatusCollection.Location = New System.Drawing.Point(328, 89)
        Me.UcucLoadPermissionStatusCollection.Name = "UcucLoadPermissionStatusCollection"
        Me.UcucLoadPermissionStatusCollection.Size = New System.Drawing.Size(273, 32)
        Me.UcucLoadPermissionStatusCollection.TabIndex = 1
        Me.UcucLoadPermissionStatusCollection.UCCurrentNSS = Nothing
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(3, 3)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(859, 84)
        Me.UcAnnouncementHallSelection.TabIndex = 0
        '
        'UcLoadPermissionLocationSelection
        '
        Me.UcLoadPermissionLocationSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadPermissionLocationSelection.Location = New System.Drawing.Point(-1, 91)
        Me.UcLoadPermissionLocationSelection.Name = "UcLoadPermissionLocationSelection"
        Me.UcLoadPermissionLocationSelection.Size = New System.Drawing.Size(331, 31)
        Me.UcLoadPermissionLocationSelection.TabIndex = 2
        '
        'UCUCLoadPermissionCollectionAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCLoadPermissionCollectionAdvance"
        Me.Size = New System.Drawing.Size(867, 473)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcucLoadPermissionStatusCollection As UCUCLoadPermissionStatusCollection
    Friend WithEvents UcAnnouncementHallSelection As UCAnnouncementHallSelection
    Friend WithEvents UcucLoadPermissionCollection As UCUCLoadPermissionCollection
    Friend WithEvents UcLoadPermissionLocationSelection As UCLoadPermissionLocationSelection
    Friend WithEvents ChkTransportCompany As Windows.Forms.CheckBox
    Friend WithEvents UcSearcherTransportCompanies As UCSearcherTransportCompanies
End Class
