
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcSaleOfCommissionSMSReport
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
        Me.PnlSaleOfSoftwareUserActivationSMSReport = New System.Windows.Forms.Panel()
        Me.UcSaleOfSoftwareUserActivationSMSReport = New PayanehClassLibrary.UCSaleOfCommissionSMSReport()
        Me.PnlSaleOfSoftwareUserActivationSMSReport.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlSaleOfSoftwareUserActivationSMSReport
        '
        Me.PnlSaleOfSoftwareUserActivationSMSReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSaleOfSoftwareUserActivationSMSReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlSaleOfSoftwareUserActivationSMSReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSaleOfSoftwareUserActivationSMSReport.Controls.Add(Me.UcSaleOfSoftwareUserActivationSMSReport)
        Me.PnlSaleOfSoftwareUserActivationSMSReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlSaleOfSoftwareUserActivationSMSReport.Name = "PnlSaleOfSoftwareUserActivationSMSReport"
        Me.PnlSaleOfSoftwareUserActivationSMSReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlSaleOfSoftwareUserActivationSMSReport.TabIndex = 49
        '
        'UcSaleOfSoftwareUserActivationSMSReport
        '
        Me.UcSaleOfSoftwareUserActivationSMSReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSaleOfSoftwareUserActivationSMSReport.BackColor = System.Drawing.Color.Transparent
        Me.UcSaleOfSoftwareUserActivationSMSReport.Location = New System.Drawing.Point(306, 39)
        Me.UcSaleOfSoftwareUserActivationSMSReport.Name = "UcSaleOfSoftwareUserActivationSMSReport"
        Me.UcSaleOfSoftwareUserActivationSMSReport.Padding = New System.Windows.Forms.Padding(5)
        Me.UcSaleOfSoftwareUserActivationSMSReport.Size = New System.Drawing.Size(380, 307)
        Me.UcSaleOfSoftwareUserActivationSMSReport.TabIndex = 0
        Me.UcSaleOfSoftwareUserActivationSMSReport.UCViewTitle = False
        '
        'FrmcSaleOfSoftwareUserActivationSMSReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSaleOfSoftwareUserActivationSMSReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcSaleOfSoftwareUserActivationSMSReport"
        Me.Text = "FrmcSaleOfSoftwareUserActivationSMSReport"
        Me.Controls.SetChildIndex(Me.PnlSaleOfSoftwareUserActivationSMSReport, 0)
        Me.PnlSaleOfSoftwareUserActivationSMSReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlSaleOfSoftwareUserActivationSMSReport As Windows.Forms.Panel
    Friend WithEvents UcSaleOfSoftwareUserActivationSMSReport As UCSaleOfCommissionSMSReport
End Class
