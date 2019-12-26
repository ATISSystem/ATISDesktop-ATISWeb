Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAnnouncementHallSelection
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
        Dim R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1 As R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = New R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcucAnnouncementHallSubGroupCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallSubGroupCollection()
        Me.UcucAnnouncementHallCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(859, 80)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(859, 80)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcucAnnouncementHallSubGroupCollection)
        Me.PnlInner.Controls.Add(Me.UcucAnnouncementHallCollection)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlInner.Size = New System.Drawing.Size(853, 74)
        Me.PnlInner.TabIndex = 0
        '
        'UcucAnnouncementHallSubGroupCollection
        '
        Me.UcucAnnouncementHallSubGroupCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucAnnouncementHallSubGroupCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallSubGroupCollection.Location = New System.Drawing.Point(2, 42)
        Me.UcucAnnouncementHallSubGroupCollection.Name = "UcucAnnouncementHallSubGroupCollection"
        Me.UcucAnnouncementHallSubGroupCollection.Size = New System.Drawing.Size(850, 30)
        Me.UcucAnnouncementHallSubGroupCollection.TabIndex = 1
        Me.UcucAnnouncementHallSubGroupCollection.UCCurrentNSS = Nothing
        Me.UcucAnnouncementHallSubGroupCollection.UCViewBorder = false
        '
        'UcucAnnouncementHallCollection
        '
        Me.UcucAnnouncementHallCollection.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.UcucAnnouncementHallCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallCollection.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcucAnnouncementHallCollection.Location = New System.Drawing.Point(2, 2)
        Me.UcucAnnouncementHallCollection.Name = "UcucAnnouncementHallCollection"
        Me.UcucAnnouncementHallCollection.Size = New System.Drawing.Size(849, 35)
        Me.UcucAnnouncementHallCollection.TabIndex = 0
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.Active = true
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHColor = "Green"
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHId = CType(2,Long)
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHTitle = "سالن اعلام بار جاده ای"
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.Deleted = false
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.ViewFlag = true
        Me.UcucAnnouncementHallCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1
        Me.UcucAnnouncementHallCollection.UCDefaultAHId = CType(2,Long)
        Me.UcucAnnouncementHallCollection.UCViewBorder = false
        '
        'UCAnnouncementHallSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCAnnouncementHallSelection"
        Me.Size = New System.Drawing.Size(859, 80)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlOutter As System.Windows.Forms.Panel
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents UcucAnnouncementHallSubGroupCollection As UCUCAnnouncementHallSubGroupCollection
    Friend WithEvents UcucAnnouncementHallCollection As UCUCAnnouncementHallCollection
End Class
