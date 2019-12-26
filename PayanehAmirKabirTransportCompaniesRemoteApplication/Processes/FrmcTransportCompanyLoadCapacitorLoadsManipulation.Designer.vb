

Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTransportCompanyLoadCapacitorLoadsManipulation
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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation = New System.Windows.Forms.Button()
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation = New System.Windows.Forms.Panel()
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1 = New PAKTCRemoteApplication.UCUCTransportCompanyLoadCapacitorLoadManipulationCollection()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 205
        '
        'BtnPnlTransportCompanyLoadCapacitorLoadsManipulation
        '
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.ForeColor = System.Drawing.Color.White
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.Name = "BtnPnlTransportCompanyLoadCapacitorLoadsManipulation"
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.Size = New System.Drawing.Size(186, 35)
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.TabIndex = 0
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.Text = "ثبت بار شرکت حمل ونقل"
        Me.BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.UseVisualStyleBackColor = false
        '
        'PnlTransportCompanyLoadCapacitorLoadsManipulation
        '
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.Controls.Add(Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1)
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.Location = New System.Drawing.Point(5, 50)
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.Name = "PnlTransportCompanyLoadCapacitorLoadsManipulation"
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.Size = New System.Drawing.Size(995, 512)
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.TabIndex = 206
        '
        'UcucTransportCompanyLoadCapacitorLoadManipulationCollection1
        '
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.BackColor = System.Drawing.Color.Transparent
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.Location = New System.Drawing.Point(0, 0)
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.Name = "UcucTransportCompanyLoadCapacitorLoadManipulationCollection1"
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.Padding = New System.Windows.Forms.Padding(10)
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.Size = New System.Drawing.Size(993, 510)
        Me.UcucTransportCompanyLoadCapacitorLoadManipulationCollection1.TabIndex = 0
        '
        'FrmcTransportCompanyLoadCapacitorLoadsManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTransportCompanyLoadCapacitorLoadsManipulation)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcTransportCompanyLoadCapacitorLoadsManipulation"
        Me.FrmPersianName = "ثبت بار شرکت حمل ونقل"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTransportCompanyLoadCapacitorLoadsManipulation"
        Me.Text = "FrmcContractorCompanyFinancialReport"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlTransportCompanyLoadCapacitorLoadsManipulation, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlTransportCompanyLoadCapacitorLoadsManipulation.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnPnlTransportCompanyLoadCapacitorLoadsManipulation As System.Windows.Forms.Button
    Friend WithEvents PnlTransportCompanyLoadCapacitorLoadsManipulation As System.Windows.Forms.Panel
    Friend WithEvents UcucTransportCompanyLoadCapacitorLoadManipulationCollection1 As UCUCTransportCompanyLoadCapacitorLoadManipulationCollection
End Class
