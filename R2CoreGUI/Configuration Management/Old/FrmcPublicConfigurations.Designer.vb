<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPublicConfigurations
    Inherits  FrmcGeneral

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
        Me.PnlPublicConfigurations = New System.Windows.Forms.Panel()
        Me.UcucConfigurationCollection = New R2CoreGUI.UCUCConfigurationCollection()
        Me.PnlPublicConfigurations.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlPublicConfigurations
        '
        Me.PnlPublicConfigurations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPublicConfigurations.BackColor = System.Drawing.Color.Transparent
        Me.PnlPublicConfigurations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPublicConfigurations.Controls.Add(Me.UcucConfigurationCollection)
        Me.PnlPublicConfigurations.Location = New System.Drawing.Point(5, 50)
        Me.PnlPublicConfigurations.Name = "PnlPublicConfigurations"
        Me.PnlPublicConfigurations.Size = New System.Drawing.Size(995, 512)
        Me.PnlPublicConfigurations.TabIndex = 201
        '
        'UcucConfigurationCollection
        '
        Me.UcucConfigurationCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucConfigurationCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucConfigurationCollection.Location = New System.Drawing.Point(6, 3)
        Me.UcucConfigurationCollection.Name = "UcucConfigurationCollection"
        Me.UcucConfigurationCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucConfigurationCollection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcucConfigurationCollection.Size = New System.Drawing.Size(981, 504)
        Me.UcucConfigurationCollection.TabIndex = 0
        Me.UcucConfigurationCollection.UCTitle = "تنظیمات عمومی سیستم"
        '
        'FrmcPublicConfigurations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPublicConfigurations)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPublicConfigurations"
        Me.Text = "FrmcPublicConfigurations"
        Me.Controls.SetChildIndex(Me.PnlPublicConfigurations, 0)
        Me.PnlPublicConfigurations.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlPublicConfigurations As Panel
    Friend WithEvents UcucConfigurationCollection As UCUCConfigurationCollection
End Class
