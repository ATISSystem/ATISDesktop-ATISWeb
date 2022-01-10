Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTerafficCardEdit
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcButton = New R2CoreGUI.UCButton()
        Me.UcTerafficCardViewerEditor = New R2CoreParkingSystem.UCTerafficCardViewerEditor()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcButton)
        Me.PnlMain.Controls.Add(Me.UcTerafficCardViewerEditor)
        Me.PnlMain.Location = New System.Drawing.Point(5, 50)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(995, 512)
        Me.PnlMain.TabIndex = 204
        '
        'UcButton
        '
        Me.UcButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(25, 454)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButton.Size = New System.Drawing.Size(171, 42)
        Me.UcButton.TabIndex = 1
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = true
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "ثبت مشخصات"
        '
        'UcTerafficCardViewerEditor
        '
        Me.UcTerafficCardViewerEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTerafficCardViewerEditor.BackColor = System.Drawing.Color.Transparent
        Me.UcTerafficCardViewerEditor.Location = New System.Drawing.Point(16, 17)
        Me.UcTerafficCardViewerEditor.Name = "UcTerafficCardViewerEditor"
        Me.UcTerafficCardViewerEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTerafficCardViewerEditor.Size = New System.Drawing.Size(965, 431)
        Me.UcTerafficCardViewerEditor.TabIndex = 0
        Me.UcTerafficCardViewerEditor.UCCanEdit = true
        Me.UcTerafficCardViewerEditor.UCEditLevel = R2Core.R2Enums.EditLevel.HighLevel
        '
        'FrmcTerafficCardEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMain)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTerafficCardEdit"
        Me.Text = "FrmcTerafficCardEdit"
        Me.Controls.SetChildIndex(Me.PnlMain, 0)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcTerafficCardViewerEditor As UCTerafficCardViewerEditor
    Friend WithEvents UcButton As UCButton
End Class
