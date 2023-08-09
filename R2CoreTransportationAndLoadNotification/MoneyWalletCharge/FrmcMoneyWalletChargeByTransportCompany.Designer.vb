
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcMoneyWalletChargeByTransportCompany
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlMoneyWalletCharge = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge()
        Me.UcTransportCompanyManipulation = New R2CoreTransportationAndLoadNotification.UCTransportCompanyManipulation()
        Me.PnlMoneyWalletCharge.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlMoneyWalletCharge
        '
        Me.PnlMoneyWalletCharge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcMoneyWalletCharge)
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcTransportCompanyManipulation)
        Me.PnlMoneyWalletCharge.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletCharge.Name = "PnlMoneyWalletCharge"
        Me.PnlMoneyWalletCharge.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletCharge.TabIndex = 49
        '
        'UcMoneyWalletCharge
        '
        Me.UcMoneyWalletCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top)), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletCharge.Location = New System.Drawing.Point(63, 200)
        Me.UcMoneyWalletCharge.Name = "UcMoneyWalletCharge"
        Me.UcMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletCharge.Size = New System.Drawing.Size(874, 340)
        Me.UcMoneyWalletCharge.TabIndex = 0
        Me.UcMoneyWalletCharge.UCConfigurationIndex = CType(5, Long)
        Me.UcMoneyWalletCharge.UCLocalPrintFlagforUCPrintBillan = True
        '
        'UcTransportCompanyManipulation
        '
        Me.UcTransportCompanyManipulation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTransportCompanyManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcTransportCompanyManipulation.Location = New System.Drawing.Point(83, 5)
        Me.UcTransportCompanyManipulation.Name = "UcTransportCompanyManipulation"
        Me.UcTransportCompanyManipulation.Padding = New System.Windows.Forms.Padding(5)
        Me.UcTransportCompanyManipulation.Size = New System.Drawing.Size(827, 191)
        Me.UcTransportCompanyManipulation.TabIndex = 0
        Me.UcTransportCompanyManipulation.UCNSSCurrent = Nothing
        Me.UcTransportCompanyManipulation.UCViewButtons = False
        '
        'FrmcMoneyWalletChargeByTransportCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletCharge)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletChargeByTransportCompany"
        Me.Text = "FrmcMoneyWalletChargeByTransportCompany"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletCharge, 0)
        Me.PnlMoneyWalletCharge.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMoneyWalletCharge As Windows.Forms.Panel
    Friend WithEvents UcTransportCompanyManipulation As UCTransportCompanyManipulation
    Friend WithEvents UcMoneyWalletCharge As R2CoreParkingSystem.UCMoneyWalletCharge

End Class
