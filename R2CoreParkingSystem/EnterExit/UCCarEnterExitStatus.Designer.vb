Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCCarEnterExitStatus
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
        Me.UcLabelCarEnterExitStatus = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabelCarEnterExitStatus)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(156, 40)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelCarEnterExitStatus
        '
        Me.UcLabelCarEnterExitStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarEnterExitStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabelCarEnterExitStatus.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelCarEnterExitStatus.Name = "UcLabelCarEnterExitStatus"
        Me.UcLabelCarEnterExitStatus.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCarEnterExitStatus.Size = New System.Drawing.Size(156, 40)
        Me.UcLabelCarEnterExitStatus.TabIndex = 0
        Me.UcLabelCarEnterExitStatus.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarEnterExitStatus.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCarEnterExitStatus.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelCarEnterExitStatus.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCarEnterExitStatus.UCValue = ""
        '
        'UCCarEnterExitStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarEnterExitStatus"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(176, 60)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabelCarEnterExitStatus As R2CoreGUI.UCLabel
End Class
