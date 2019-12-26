Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerTankTreiler
    Inherits UCGeneral

    'UserControl overrides dispose to clean up the component list.
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
        Me.UcLabel = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabel)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(232, 49)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel
        '
        Me.UcLabel.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabel.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel.Name = "UcLabel"
        Me.UcLabel.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel.Size = New System.Drawing.Size(232, 49)
        Me.UcLabel.TabIndex = 0
        Me.UcLabel.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel.UCValue = "تانکر مخزندار"
        '
        'UCViewerTankTreiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerTankTreiler"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(242, 59)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel As R2CoreGUI.UCLabel
End Class
