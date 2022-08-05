
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcTransportCompniesManipulation
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PnlTransportCompanies = New UI.Glass.Panel()
        Me.CButtonRelationRegistering = New CButtonLib.CButton()
        Me.UcTransportCompanyManipulation = New R2CoreTransportationAndLoadNotification.UCTransportCompanyManipulation()
        Me.UcrfidCardTextMaintainer = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.PnlTransportCompanies.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1288, -1137)
        '
        'PnlTransportCompanies
        '
        Me.PnlTransportCompanies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.PnlTransportCompanies.Controls.Add(Me.CButtonRelationRegistering)
        Me.PnlTransportCompanies.Controls.Add(Me.UcTransportCompanyManipulation)
        Me.PnlTransportCompanies.Controls.Add(Me.UcrfidCardTextMaintainer)
        Me.PnlTransportCompanies.Controls.Add(Me.UcMoneyWallet)
        Me.PnlTransportCompanies.GlassColor = System.Drawing.Color.White
        Me.PnlTransportCompanies.Location = New System.Drawing.Point(5, 50)
        Me.PnlTransportCompanies.MouseReflection = True
        Me.PnlTransportCompanies.Name = "PnlTransportCompanies"
        Me.PnlTransportCompanies.Opacity = 0
        Me.PnlTransportCompanies.Radius = 5.0!
        Me.PnlTransportCompanies.Size = New System.Drawing.Size(995, 512)
        Me.PnlTransportCompanies.TabIndex = 49
        '
        'CButtonRelationRegistering
        '
        Me.CButtonRelationRegistering.BorderColor = System.Drawing.Color.Red
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Blue, System.Drawing.Color.CornflowerBlue}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonRelationRegistering.ColorFillBlend = CBlendItems1
        Me.CButtonRelationRegistering.Corners.LowerRight = 15
        Me.CButtonRelationRegistering.Corners.UpperLeft = 15
        Me.CButtonRelationRegistering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonRelationRegistering.DesignerSelected = False
        Me.CButtonRelationRegistering.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonRelationRegistering.ImageIndex = 0
        Me.CButtonRelationRegistering.Location = New System.Drawing.Point(21, 32)
        Me.CButtonRelationRegistering.Name = "CButtonRelationRegistering"
        Me.CButtonRelationRegistering.Size = New System.Drawing.Size(272, 36)
        Me.CButtonRelationRegistering.TabIndex = 27
        Me.CButtonRelationRegistering.Text = "ثبت رابطه شرکت حمل ونقل با کیف پول"
        Me.CButtonRelationRegistering.TextShadowShow = False
        '
        'UcTransportCompanyManipulation
        '
        Me.UcTransportCompanyManipulation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTransportCompanyManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcTransportCompanyManipulation.Location = New System.Drawing.Point(14, 74)
        Me.UcTransportCompanyManipulation.Name = "UcTransportCompanyManipulation"
        Me.UcTransportCompanyManipulation.Padding = New System.Windows.Forms.Padding(5)
        Me.UcTransportCompanyManipulation.Size = New System.Drawing.Size(966, 191)
        Me.UcTransportCompanyManipulation.TabIndex = 8
        Me.UcTransportCompanyManipulation.UCNSSCurrent = Nothing
        '
        'UcrfidCardTextMaintainer
        '
        Me.UcrfidCardTextMaintainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcrfidCardTextMaintainer.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainer.Location = New System.Drawing.Point(771, 34)
        Me.UcrfidCardTextMaintainer.Name = "UcrfidCardTextMaintainer"
        Me.UcrfidCardTextMaintainer.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainer.Size = New System.Drawing.Size(202, 34)
        Me.UcrfidCardTextMaintainer.TabIndex = 7
        Me.UcrfidCardTextMaintainer.UCEnable = True
        Me.UcrfidCardTextMaintainer.UCValue = ""
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWallet.Location = New System.Drawing.Point(399, 276)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(197, 154)
        Me.UcMoneyWallet.TabIndex = 1
        '
        'FrmcTransportCompniesManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTransportCompanies)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTransportCompniesManipulation"
        Me.Text = "FrmcTransportCompniesManipulation"
        Me.Controls.SetChildIndex(Me.PnlTransportCompanies, 0)
        Me.PnlTransportCompanies.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTransportCompanies As UI.Glass.Panel
    Friend WithEvents UcMoneyWallet As R2CoreParkingSystem.UCMoneyWallet
    Friend WithEvents UcrfidCardTextMaintainer As UCRFIDCardTextMaintainer
    Friend WithEvents UcTransportCompanyManipulation As UCTransportCompanyManipulation
    Friend WithEvents CButtonRelationRegistering As CButtonLib.CButton
End Class
