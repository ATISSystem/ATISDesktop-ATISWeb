Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads = New System.Windows.Forms.Button()
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads = New System.Windows.Forms.Panel()
        Me.UcLabelNote = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation = New System.Windows.Forms.Panel()
        Me.UcButtonSpecialRepeatPermissionPrint = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcDriverTruck = New PAKTCRemoteApplication.UCDriverTruck()
        Me.UcCarTruck = New PAKTCRemoteApplication.UCCarTruck()
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation = New PAKTCRemoteApplication.UCTransportCompanyLoadCapacitorSedimentLoadViewer()
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection = New PAKTCRemoteApplication.UCUCTransportCompanyLoadCapacitorSedimentLoadViewerCollection()
        Me.PnlTopMenu.SuspendLayout()
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.SuspendLayout()
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 206
        '
        'BtnPnlTransportCompanyLoadCapacitorSedimentedLoads
        '
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.ForeColor = System.Drawing.Color.White
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.Name = "BtnPnlTransportCompanyLoadCapacitorSedimentedLoads"
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.Size = New System.Drawing.Size(140, 35)
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.TabIndex = 0
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.Text = "لیست بار رسوب شده"
        Me.BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.UseVisualStyleBackColor = False
        '
        'PnlTransportCompanyLoadCapacitorSedimentedLoads
        '
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.BackColor = System.Drawing.Color.Transparent
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.Controls.Add(Me.UcLabelNote)
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.Controls.Add(Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection)
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.Location = New System.Drawing.Point(5, 50)
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.Name = "PnlTransportCompanyLoadCapacitorSedimentedLoads"
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.Size = New System.Drawing.Size(995, 512)
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.TabIndex = 207
        '
        'UcLabelNote
        '
        Me.UcLabelNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelNote.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelNote.Location = New System.Drawing.Point(492, 65)
        Me.UcLabelNote.Name = "UcLabelNote"
        Me.UcLabelNote.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelNote.Size = New System.Drawing.Size(492, 32)
        Me.UcLabelNote.TabIndex = 1
        Me.UcLabelNote.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelNote.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelNote.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelNote.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelNote.UCValue = "به منظور تخصیص بار روی کد مخزن بار کلیک نمایید تا به پانل تخصیص بار هدایت شوید"
        '
        'PnlTransportCompanyLoadCapacitorSedimentLoadAllocation
        '
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.BackColor = System.Drawing.Color.Transparent
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Controls.Add(Me.UcButtonSpecialRepeatPermissionPrint)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Controls.Add(Me.UcButtonSpecialAllocateSedimentLoadAndPermission)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Controls.Add(Me.UcDriverTruck)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Controls.Add(Me.UcCarTruck)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Controls.Add(Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Location = New System.Drawing.Point(5, 50)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Name = "PnlTransportCompanyLoadCapacitorSedimentLoadAllocation"
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Size = New System.Drawing.Size(995, 512)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.TabIndex = 208
        '
        'UcButtonSpecialRepeatPermissionPrint
        '
        Me.UcButtonSpecialRepeatPermissionPrint.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialRepeatPermissionPrint.Location = New System.Drawing.Point(393, 431)
        Me.UcButtonSpecialRepeatPermissionPrint.Name = "UcButtonSpecialRepeatPermissionPrint"
        Me.UcButtonSpecialRepeatPermissionPrint.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialRepeatPermissionPrint.Size = New System.Drawing.Size(103, 45)
        Me.UcButtonSpecialRepeatPermissionPrint.TabIndex = 4
        Me.UcButtonSpecialRepeatPermissionPrint.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonSpecialRepeatPermissionPrint.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialRepeatPermissionPrint.UCEnable = True
        Me.UcButtonSpecialRepeatPermissionPrint.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecialRepeatPermissionPrint.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSpecialRepeatPermissionPrint.UCValue = "چاپ مجدد"
        '
        'UcButtonSpecialAllocateSedimentLoadAndPermission
        '
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.Location = New System.Drawing.Point(79, 431)
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.Name = "UcButtonSpecialAllocateSedimentLoadAndPermission"
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.Size = New System.Drawing.Size(308, 45)
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.TabIndex = 3
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.UCEnable = False
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialAllocateSedimentLoadAndPermission.UCValue = "تخصیص بار و صدور مجوز بارگیری سالن اعلام بار"
        '
        'UcDriverTruck
        '
        Me.UcDriverTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruck.Location = New System.Drawing.Point(79, 329)
        Me.UcDriverTruck.Name = "UcDriverTruck"
        Me.UcDriverTruck.Size = New System.Drawing.Size(800, 92)
        Me.UcDriverTruck.TabIndex = 2
        '
        'UcCarTruck
        '
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(77, 218)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(802, 105)
        Me.UcCarTruck.TabIndex = 1
        '
        'UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation
        '
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.BackColor = System.Drawing.Color.Transparent
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.Location = New System.Drawing.Point(66, 24)
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.Name = "UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation"
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.Padding = New System.Windows.Forms.Padding(10)
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.Size = New System.Drawing.Size(822, 197)
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.TabIndex = 0
        Me.UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.UCViewButtons = False
        '
        'UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection
        '
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.Name = "UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection"
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.Padding = New System.Windows.Forms.Padding(10)
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.TabIndex = 0
        '
        'FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTransportCompanyLoadCapacitorSedimentedLoads)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.Controls.Add(Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation)
        Me.FrmEnglishName = "FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation"
        Me.FrmPersianName = "تخصیص بار"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation"
        Me.Text = "FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation"
        Me.Controls.SetChildIndex(Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation, 0)
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlTransportCompanyLoadCapacitorSedimentedLoads, 0)
        Me.PnlTopMenu.ResumeLayout(False)
        Me.PnlTransportCompanyLoadCapacitorSedimentedLoads.ResumeLayout(False)
        Me.PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnPnlTransportCompanyLoadCapacitorSedimentedLoads As Button
    Friend WithEvents PnlTransportCompanyLoadCapacitorSedimentedLoads As Panel
    Friend WithEvents UcLabelNote As UCLabel
    Friend WithEvents UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection As UCUCTransportCompanyLoadCapacitorSedimentLoadViewerCollection
    Friend WithEvents PnlTransportCompanyLoadCapacitorSedimentLoadAllocation As Panel
    Friend WithEvents UcButtonSpecialAllocateSedimentLoadAndPermission As UCButtonSpecial
    Friend WithEvents UcDriverTruck As UCDriverTruck
    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation As UCTransportCompanyLoadCapacitorSedimentLoadViewer
    Friend WithEvents UcButtonSpecialRepeatPermissionPrint As UCButtonSpecial
End Class
