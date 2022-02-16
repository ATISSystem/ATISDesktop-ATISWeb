
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcSoftwareUserManagement
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
        Me.PnlSoftwareUser = New System.Windows.Forms.Panel()
        Me.UcSoftwareUserManipulation = New R2CoreGUI.UCSoftwareUserManipulation()
        Me.PnlSoftwareUserTruckDriver = New System.Windows.Forms.Panel()
        Me.UcSoftwareUserManipulationTruckDriver = New R2CoreGUI.UCSoftwareUserManipulation()
        Me.UcDriverTruck = New PayanehClassLibrary.UCDriverTruck()
        Me.PnlSoftwareUserTransportCompany = New System.Windows.Forms.Panel()
        Me.UcSoftwareUserManipulationTransportCompany = New R2CoreGUI.UCSoftwareUserManipulation()
        Me.UcTransportCompanyManipulation = New R2CoreTransportationAndLoadNotification.UCTransportCompanyManipulation()
        Me.PnlSoftwareUser.SuspendLayout()
        Me.PnlSoftwareUserTruckDriver.SuspendLayout()
        Me.PnlSoftwareUserTransportCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlSoftwareUser
        '
        Me.PnlSoftwareUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSoftwareUser.BackColor = System.Drawing.Color.Transparent
        Me.PnlSoftwareUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSoftwareUser.Controls.Add(Me.UcSoftwareUserManipulation)
        Me.PnlSoftwareUser.Location = New System.Drawing.Point(5, 50)
        Me.PnlSoftwareUser.Name = "PnlSoftwareUser"
        Me.PnlSoftwareUser.Size = New System.Drawing.Size(995, 512)
        Me.PnlSoftwareUser.TabIndex = 49
        '
        'UcSoftwareUserManipulation
        '
        Me.UcSoftwareUserManipulation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSoftwareUserManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcSoftwareUserManipulation.Location = New System.Drawing.Point(6, 3)
        Me.UcSoftwareUserManipulation.Name = "UcSoftwareUserManipulation"
        Me.UcSoftwareUserManipulation.Padding = New System.Windows.Forms.Padding(5)
        Me.UcSoftwareUserManipulation.Size = New System.Drawing.Size(981, 226)
        Me.UcSoftwareUserManipulation.TabIndex = 0
        Me.UcSoftwareUserManipulation.UCNSSCurrent = Nothing
        '
        'PnlSoftwareUserTruckDriver
        '
        Me.PnlSoftwareUserTruckDriver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSoftwareUserTruckDriver.BackColor = System.Drawing.Color.Transparent
        Me.PnlSoftwareUserTruckDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSoftwareUserTruckDriver.Controls.Add(Me.UcSoftwareUserManipulationTruckDriver)
        Me.PnlSoftwareUserTruckDriver.Controls.Add(Me.UcDriverTruck)
        Me.PnlSoftwareUserTruckDriver.Location = New System.Drawing.Point(5, 50)
        Me.PnlSoftwareUserTruckDriver.Name = "PnlSoftwareUserTruckDriver"
        Me.PnlSoftwareUserTruckDriver.Size = New System.Drawing.Size(995, 512)
        Me.PnlSoftwareUserTruckDriver.TabIndex = 50
        '
        'UcSoftwareUserManipulationTruckDriver
        '
        Me.UcSoftwareUserManipulationTruckDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSoftwareUserManipulationTruckDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcSoftwareUserManipulationTruckDriver.Location = New System.Drawing.Point(6, 186)
        Me.UcSoftwareUserManipulationTruckDriver.Name = "UcSoftwareUserManipulationTruckDriver"
        Me.UcSoftwareUserManipulationTruckDriver.Padding = New System.Windows.Forms.Padding(5)
        Me.UcSoftwareUserManipulationTruckDriver.Size = New System.Drawing.Size(981, 226)
        Me.UcSoftwareUserManipulationTruckDriver.TabIndex = 1
        Me.UcSoftwareUserManipulationTruckDriver.UCNSSCurrent = Nothing
        '
        'UcDriverTruck
        '
        Me.UcDriverTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruck.Location = New System.Drawing.Point(6, 13)
        Me.UcDriverTruck.Name = "UcDriverTruck"
        Me.UcDriverTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruck.Size = New System.Drawing.Size(981, 167)
        Me.UcDriverTruck.TabIndex = 0
        Me.UcDriverTruck.UCViewButtons = True
        '
        'PnlSoftwareUserTransportCompany
        '
        Me.PnlSoftwareUserTransportCompany.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSoftwareUserTransportCompany.BackColor = System.Drawing.Color.Transparent
        Me.PnlSoftwareUserTransportCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSoftwareUserTransportCompany.Controls.Add(Me.UcSoftwareUserManipulationTransportCompany)
        Me.PnlSoftwareUserTransportCompany.Controls.Add(Me.UcTransportCompanyManipulation)
        Me.PnlSoftwareUserTransportCompany.Location = New System.Drawing.Point(5, 50)
        Me.PnlSoftwareUserTransportCompany.Name = "PnlSoftwareUserTransportCompany"
        Me.PnlSoftwareUserTransportCompany.Size = New System.Drawing.Size(995, 512)
        Me.PnlSoftwareUserTransportCompany.TabIndex = 51
        '
        'UcSoftwareUserManipulationTransportCompany
        '
        Me.UcSoftwareUserManipulationTransportCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSoftwareUserManipulationTransportCompany.BackColor = System.Drawing.Color.Transparent
        Me.UcSoftwareUserManipulationTransportCompany.Location = New System.Drawing.Point(6, 186)
        Me.UcSoftwareUserManipulationTransportCompany.Name = "UcSoftwareUserManipulationTransportCompany"
        Me.UcSoftwareUserManipulationTransportCompany.Padding = New System.Windows.Forms.Padding(5)
        Me.UcSoftwareUserManipulationTransportCompany.Size = New System.Drawing.Size(981, 226)
        Me.UcSoftwareUserManipulationTransportCompany.TabIndex = 1
        Me.UcSoftwareUserManipulationTransportCompany.UCNSSCurrent = Nothing
        '
        'UcTransportCompanyManipulation
        '
        Me.UcTransportCompanyManipulation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTransportCompanyManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcTransportCompanyManipulation.Location = New System.Drawing.Point(6, 11)
        Me.UcTransportCompanyManipulation.Name = "UcTransportCompanyManipulation"
        Me.UcTransportCompanyManipulation.Padding = New System.Windows.Forms.Padding(5)
        Me.UcTransportCompanyManipulation.Size = New System.Drawing.Size(981, 169)
        Me.UcTransportCompanyManipulation.TabIndex = 0
        Me.UcTransportCompanyManipulation.UCNSSCurrent = Nothing
        '
        'FrmcSoftwareUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSoftwareUser)
        Me.Controls.Add(Me.PnlSoftwareUserTransportCompany)
        Me.Controls.Add(Me.PnlSoftwareUserTruckDriver)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcSoftwareUserManagement"
        Me.Text = "FrmcSoftwareUserManagement"
        Me.Controls.SetChildIndex(Me.PnlSoftwareUserTruckDriver, 0)
        Me.Controls.SetChildIndex(Me.PnlSoftwareUserTransportCompany, 0)
        Me.Controls.SetChildIndex(Me.PnlSoftwareUser, 0)
        Me.PnlSoftwareUser.ResumeLayout(False)
        Me.PnlSoftwareUserTruckDriver.ResumeLayout(False)
        Me.PnlSoftwareUserTransportCompany.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlSoftwareUser As Windows.Forms.Panel
    Friend WithEvents UcSoftwareUserManipulation As UCSoftwareUserManipulation
    Friend WithEvents PnlSoftwareUserTruckDriver As Windows.Forms.Panel
    Friend WithEvents UcSoftwareUserManipulationTruckDriver As UCSoftwareUserManipulation
    Friend WithEvents UcDriverTruck As UCDriverTruck
    Friend WithEvents PnlSoftwareUserTransportCompany As Windows.Forms.Panel
    Friend WithEvents UcSoftwareUserManipulationTransportCompany As UCSoftwareUserManipulation
    Friend WithEvents UcTransportCompanyManipulation As R2CoreTransportationAndLoadNotification.UCTransportCompanyManipulation
End Class
