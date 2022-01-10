Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadAllocationManipulationByLoadCapacitorLoads
    Inherits UCGeneralExtended

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
        Me.UcLoadAllocationManipulation = New R2CoreTransportationAndLoadNotification.UCLoadAllocationManipulation()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLoadAllocationManipulation)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(948, 133)
        Me.PnlMain.TabIndex = 0
        '
        'UcLoadAllocationManipulation
        '
        Me.UcLoadAllocationManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadAllocationManipulation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLoadAllocationManipulation.Location = New System.Drawing.Point(0, 0)
        Me.UcLoadAllocationManipulation.Name = "UcLoadAllocationManipulation"
        Me.UcLoadAllocationManipulation.Padding = New System.Windows.Forms.Padding(5)
        Me.UcLoadAllocationManipulation.Size = New System.Drawing.Size(948, 133)
        Me.UcLoadAllocationManipulation.TabIndex = 0
        Me.UcLoadAllocationManipulation.UCNSSCurrent = Nothing
        Me.UcLoadAllocationManipulation.UCViewButtons = True
        '
        'UCLoadAllocationManipulationByLoadCapacitorLoads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadAllocationManipulationByLoadCapacitorLoads"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(950, 135)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLoadAllocationManipulation As UCLoadAllocationManipulation
End Class
