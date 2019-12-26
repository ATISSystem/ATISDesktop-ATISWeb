Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCTransportCompanyCollection
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
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Size = New System.Drawing.Size(465, 34)
        Me.PnlMain.TabIndex = 0
        '
        'PnlUCs
        '
        Me.PnlUCs.BackColor = System.Drawing.Color.White
        Me.PnlUCs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlUCs.Location = New System.Drawing.Point(2, 2)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(461, 30)
        Me.PnlUCs.TabIndex = 0
        '
        'UCUCTransportCompanyCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCTransportCompanyCollection"
        Me.Size = New System.Drawing.Size(465, 34)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlUCs As Windows.Forms.Panel
End Class
