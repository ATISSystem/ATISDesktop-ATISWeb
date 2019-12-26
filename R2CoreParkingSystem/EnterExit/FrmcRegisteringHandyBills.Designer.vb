Imports System.Windows.Forms
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcRegisteringHandyBills
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
        Me.PnlRegisteringHandyBills = New System.Windows.Forms.Panel()
        Me.UcRegisteringHandyBills = New R2CoreParkingSystem.UCRegisteringHandyBills()
        Me.PnlRegisteringHandyBills.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlRegisteringHandyBills
        '
        Me.PnlRegisteringHandyBills.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlRegisteringHandyBills.BackColor = System.Drawing.Color.Transparent
        Me.PnlRegisteringHandyBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlRegisteringHandyBills.Controls.Add(Me.UcRegisteringHandyBills)
        Me.PnlRegisteringHandyBills.Location = New System.Drawing.Point(5, 50)
        Me.PnlRegisteringHandyBills.Name = "PnlRegisteringHandyBills"
        Me.PnlRegisteringHandyBills.Size = New System.Drawing.Size(995, 512)
        Me.PnlRegisteringHandyBills.TabIndex = 201
        '
        'UcRegisteringHandyBills
        '
        Me.UcRegisteringHandyBills.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcRegisteringHandyBills.BackColor = System.Drawing.Color.Transparent
        Me.UcRegisteringHandyBills.Location = New System.Drawing.Point(339, 50)
        Me.UcRegisteringHandyBills.Name = "UcRegisteringHandyBills"
        Me.UcRegisteringHandyBills.Padding = New System.Windows.Forms.Padding(3)
        Me.UcRegisteringHandyBills.Size = New System.Drawing.Size(315, 436)
        Me.UcRegisteringHandyBills.TabIndex = 0
        '
        'FrmcRegisteringHandyBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlRegisteringHandyBills)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcRegisteringHandyBills"
        Me.Text = "FrmcRegisteringHandyBills"
        Me.Controls.SetChildIndex(Me.PnlRegisteringHandyBills, 0)
        Me.PnlRegisteringHandyBills.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlRegisteringHandyBills As Panel
    Friend WithEvents UcRegisteringHandyBills As UCRegisteringHandyBills
End Class
