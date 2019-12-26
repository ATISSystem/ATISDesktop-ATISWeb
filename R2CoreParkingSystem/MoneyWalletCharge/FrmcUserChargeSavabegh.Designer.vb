Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcUserChargeSavabegh
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
        Me.PnlUserChargeSavabegh = New System.Windows.Forms.Panel()
        Me.UcUserChargeSavabeghCollection = New R2CoreParkingSystem.UCUserChargeSavabeghCollection()
        Me.PnlUserChargeSavabegh.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlUserChargeSavabegh
        '
        Me.PnlUserChargeSavabegh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUserChargeSavabegh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUserChargeSavabegh.Controls.Add(Me.UcUserChargeSavabeghCollection)
        Me.PnlUserChargeSavabegh.Location = New System.Drawing.Point(5, 50)
        Me.PnlUserChargeSavabegh.Name = "PnlUserChargeSavabegh"
        Me.PnlUserChargeSavabegh.Size = New System.Drawing.Size(995, 512)
        Me.PnlUserChargeSavabegh.TabIndex = 202
        '
        'UcUserChargeSavabeghCollection
        '
        Me.UcUserChargeSavabeghCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcUserChargeSavabeghCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUserChargeSavabeghCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcUserChargeSavabeghCollection.Name = "UcUserChargeSavabeghCollection"
        Me.UcUserChargeSavabeghCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcUserChargeSavabeghCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcUserChargeSavabeghCollection.TabIndex = 0
        '
        'FrmcUserChargeSavabegh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlUserChargeSavabegh)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcUserChargeSavabegh"
        Me.Text = "FrmcUserChargeSavabegh"
        Me.Controls.SetChildIndex(Me.PnlUserChargeSavabegh, 0)
        Me.PnlUserChargeSavabegh.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlUserChargeSavabegh As System.Windows.Forms.Panel
    Friend WithEvents UcUserChargeSavabeghCollection As UCUserChargeSavabeghCollection
End Class
