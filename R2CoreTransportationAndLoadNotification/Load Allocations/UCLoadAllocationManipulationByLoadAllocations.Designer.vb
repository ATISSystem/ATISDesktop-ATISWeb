Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadAllocationManipulationByLoadAllocations
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
        Me.UcucLoadAllocationCollectionAdvance = New R2CoreTransportationAndLoadNotification.UCUCLoadAllocationCollectionAdvance()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLoadAllocationManipulation)
        Me.PnlMain.Controls.Add(Me.UcucLoadAllocationCollectionAdvance)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(949, 488)
        Me.PnlMain.TabIndex = 0
        '
        'UcLoadAllocationManipulation
        '
        Me.UcLoadAllocationManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadAllocationManipulation.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLoadAllocationManipulation.Location = New System.Drawing.Point(0, 0)
        Me.UcLoadAllocationManipulation.Name = "UcLoadAllocationManipulation"
        Me.UcLoadAllocationManipulation.Padding = New System.Windows.Forms.Padding(5)
        Me.UcLoadAllocationManipulation.Size = New System.Drawing.Size(949, 125)
        Me.UcLoadAllocationManipulation.TabIndex = 1
        Me.UcLoadAllocationManipulation.UCNSSCurrent = Nothing
        Me.UcLoadAllocationManipulation.UCViewButtons = false
        '
        'UcucLoadAllocationCollectionAdvance
        '
        Me.UcucLoadAllocationCollectionAdvance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadAllocationCollectionAdvance.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadAllocationCollectionAdvance.Location = New System.Drawing.Point(3, 122)
        Me.UcucLoadAllocationCollectionAdvance.Name = "UcucLoadAllocationCollectionAdvance"
        Me.UcucLoadAllocationCollectionAdvance.Size = New System.Drawing.Size(943, 363)
        Me.UcucLoadAllocationCollectionAdvance.TabIndex = 0
        '
        'UCLoadAllocationManipulationByLoadAllocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadAllocationManipulationByLoadAllocations"
        Me.Size = New System.Drawing.Size(949, 488)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcucLoadAllocationCollectionAdvance As UCUCLoadAllocationCollectionAdvance
    Friend WithEvents UcLoadAllocationManipulation As UCLoadAllocationManipulation
End Class
