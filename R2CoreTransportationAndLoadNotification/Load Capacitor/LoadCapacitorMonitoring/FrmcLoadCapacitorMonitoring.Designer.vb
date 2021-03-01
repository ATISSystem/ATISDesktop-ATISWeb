
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcLoadCapacitorMonitoring
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
        Me.PnlMonitoring = New System.Windows.Forms.Panel()
        Me.UcucLoadCapacitorLoadCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadCapacitorLoadCollection()
        Me.PnlMonitoring.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlMonitoring
        '
        Me.PnlMonitoring.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMonitoring.BackColor = System.Drawing.Color.Transparent
        Me.PnlMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMonitoring.Controls.Add(Me.UcucLoadCapacitorLoadCollection)
        Me.PnlMonitoring.Location = New System.Drawing.Point(5, 50)
        Me.PnlMonitoring.Name = "PnlMonitoring"
        Me.PnlMonitoring.Size = New System.Drawing.Size(995, 512)
        Me.PnlMonitoring.TabIndex = 49
        '
        'UcucLoadCapacitorLoadCollection
        '
        Me.UcucLoadCapacitorLoadCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadCapacitorLoadCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadCapacitorLoadCollection.Location = New System.Drawing.Point(1, 3)
        Me.UcucLoadCapacitorLoadCollection.Name = "UcucLoadCapacitorLoadCollection"
        Me.UcucLoadCapacitorLoadCollection.Size = New System.Drawing.Size(990, 504)
        Me.UcucLoadCapacitorLoadCollection.TabIndex = 0
        Me.UcucLoadCapacitorLoadCollection.UCTimerInterval = CType(3000,Long)
        '
        'FrmcLoadCapacitorMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMonitoring)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadCapacitorMonitoring"
        Me.Text = "FrmcLoadCapacitorMonitoring"
        Me.Controls.SetChildIndex(Me.PnlMonitoring, 0)
        Me.PnlMonitoring.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMonitoring As Windows.Forms.Panel
    Friend WithEvents UcucLoadCapacitorLoadCollection As UCUCLoadCapacitorLoadCollection
End Class
