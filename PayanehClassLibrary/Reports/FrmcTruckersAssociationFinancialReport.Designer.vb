Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTruckersAssociationFinancialReport
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
        Me.PnlTruckersAssiciationFinanceReport = New System.Windows.Forms.Panel()
        Me.UcTruckersAssociationFinacialReport = New PayanehClassLibrary.UCTruckersAssociationFinacialReport()
        Me.PnlTruckersAssiciationFinanceReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlTruckersAssiciationFinanceReport
        '
        Me.PnlTruckersAssiciationFinanceReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTruckersAssiciationFinanceReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTruckersAssiciationFinanceReport.Controls.Add(Me.UcTruckersAssociationFinacialReport)
        Me.PnlTruckersAssiciationFinanceReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlTruckersAssiciationFinanceReport.Name = "PnlTruckersAssiciationFinanceReport"
        Me.PnlTruckersAssiciationFinanceReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlTruckersAssiciationFinanceReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlTruckersAssiciationFinanceReport.TabIndex = 205
        '
        'UcTruckersAssociationFinacialReport
        '
        Me.UcTruckersAssociationFinacialReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTruckersAssociationFinacialReport.BackColor = System.Drawing.Color.Transparent
        Me.UcTruckersAssociationFinacialReport.Location = New System.Drawing.Point(394, 40)
        Me.UcTruckersAssociationFinacialReport.Name = "UcTruckersAssociationFinacialReport"
        Me.UcTruckersAssociationFinacialReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTruckersAssociationFinacialReport.Size = New System.Drawing.Size(205, 247)
        Me.UcTruckersAssociationFinacialReport.TabIndex = 0
        Me.UcTruckersAssociationFinacialReport.UCViewTitle = false
        '
        'FrmcTruckersAssociationFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTruckersAssiciationFinanceReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTruckersAssociationFinancialReport"
        Me.Text = "FrmcTruckersAssociationFinancialReport"
        Me.Controls.SetChildIndex(Me.PnlTruckersAssiciationFinanceReport, 0)
        Me.PnlTruckersAssiciationFinanceReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlTruckersAssiciationFinanceReport As System.Windows.Forms.Panel
    Friend WithEvents UcTruckersAssociationFinacialReport As UCTruckersAssociationFinacialReport
End Class
