<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPersonnelEnterExits
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
        Me.PnlPersonnelEnterExits = New System.Windows.Forms.Panel()
        Me.UcListBoxPersonnelEnterExit = New R2CoreGUI.UCListBoxPersonnelEnterExit()
        Me.UcPersonnelImage = New R2CoreGUI.UCPersonnelImage()
        Me.UcucPersonnelCollection = New R2CoreGUI.UCUCPersonnelCollection()
        Me.PnlPersonnelEnterExits.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlPersonnelEnterExits
        '
        Me.PnlPersonnelEnterExits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelEnterExits.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelEnterExits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelEnterExits.Controls.Add(Me.UcListBoxPersonnelEnterExit)
        Me.PnlPersonnelEnterExits.Controls.Add(Me.UcPersonnelImage)
        Me.PnlPersonnelEnterExits.Controls.Add(Me.UcucPersonnelCollection)
        Me.PnlPersonnelEnterExits.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelEnterExits.Name = "PnlPersonnelEnterExits"
        Me.PnlPersonnelEnterExits.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelEnterExits.TabIndex = 208
        '
        'UcListBoxPersonnelEnterExit
        '
        Me.UcListBoxPersonnelEnterExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcListBoxPersonnelEnterExit.BackColor = System.Drawing.Color.Transparent
        Me.UcListBoxPersonnelEnterExit.Location = New System.Drawing.Point(446, 5)
        Me.UcListBoxPersonnelEnterExit.Name = "UcListBoxPersonnelEnterExit"
        Me.UcListBoxPersonnelEnterExit.Padding = New System.Windows.Forms.Padding(2)
        Me.UcListBoxPersonnelEnterExit.Size = New System.Drawing.Size(251, 498)
        Me.UcListBoxPersonnelEnterExit.TabIndex = 2
        Me.UcListBoxPersonnelEnterExit.UCBackColor = System.Drawing.Color.White
        Me.UcListBoxPersonnelEnterExit.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcListBoxPersonnelEnterExit.UCForeColor = System.Drawing.Color.Black
        Me.UcListBoxPersonnelEnterExit.UCTitle = "سوابق تردد پرسنل"
        '
        'UcPersonnelImage
        '
        Me.UcPersonnelImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelImage.Location = New System.Drawing.Point(46, 76)
        Me.UcPersonnelImage.Name = "UcPersonnelImage"
        Me.UcPersonnelImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersonnelImage.Size = New System.Drawing.Size(359, 359)
        Me.UcPersonnelImage.TabIndex = 1
        '
        'UcucPersonnelCollection
        '
        Me.UcucPersonnelCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucPersonnelCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucPersonnelCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucPersonnelCollection.Location = New System.Drawing.Point(703, 7)
        Me.UcucPersonnelCollection.Name = "UcucPersonnelCollection"
        Me.UcucPersonnelCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucPersonnelCollection.Size = New System.Drawing.Size(274, 494)
        Me.UcucPersonnelCollection.TabIndex = 0
        '
        'FrmcPersonnelEnterExits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPersonnelEnterExits)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPersonnelEnterExits"
        Me.Text = "FrmcPersonnelEnterExits"
        Me.Controls.SetChildIndex(Me.PnlPersonnelEnterExits, 0)
        Me.PnlPersonnelEnterExits.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlPersonnelEnterExits As Panel
    Friend WithEvents UcListBoxPersonnelEnterExit As UCListBoxPersonnelEnterExit
    Friend WithEvents UcPersonnelImage As UCPersonnelImage
    Friend WithEvents UcucPersonnelCollection As UCUCPersonnelCollection
End Class
