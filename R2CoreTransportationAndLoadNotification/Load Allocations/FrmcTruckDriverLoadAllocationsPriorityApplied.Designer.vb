
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTruckDriverLoadAllocationsPriorityApplied
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
        Me.PnlLoadAllocationRegistering = New System.Windows.Forms.Panel()
        Me.UcucLoadCapacitorLoadCollectionAdvance = New R2CoreTransportationAndLoadNotification.UCUCLoadCapacitorLoadCollectionAdvance()
        Me.UcViewerNSSTurnDataEntry = New R2CoreTransportationAndLoadNotification.UCViewerNSSTurnDataEntry()
        Me.PnlLoadAllocationsPriorityApplied = New System.Windows.Forms.Panel()
        Me.UcucLoadAllocationCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadAllocationCollection()
        Me.PnlLoadAllocationRegistering.SuspendLayout
        Me.PnlLoadAllocationsPriorityApplied.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlLoadAllocationRegistering
        '
        Me.PnlLoadAllocationRegistering.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadAllocationRegistering.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadAllocationRegistering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoadAllocationRegistering.Controls.Add(Me.UcucLoadCapacitorLoadCollectionAdvance)
        Me.PnlLoadAllocationRegistering.Controls.Add(Me.UcViewerNSSTurnDataEntry)
        Me.PnlLoadAllocationRegistering.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadAllocationRegistering.Name = "PnlLoadAllocationRegistering"
        Me.PnlLoadAllocationRegistering.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadAllocationRegistering.TabIndex = 49
        '
        'UcucLoadCapacitorLoadCollectionAdvance
        '
        Me.UcucLoadCapacitorLoadCollectionAdvance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadCapacitorLoadCollectionAdvance.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadCapacitorLoadCollectionAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucLoadCapacitorLoadCollectionAdvance.Location = New System.Drawing.Point(3, 88)
        Me.UcucLoadCapacitorLoadCollectionAdvance.Name = "UcucLoadCapacitorLoadCollectionAdvance"
        Me.UcucLoadCapacitorLoadCollectionAdvance.Size = New System.Drawing.Size(987, 419)
        Me.UcucLoadCapacitorLoadCollectionAdvance.TabIndex = 1
        '
        'UcViewerNSSTurnDataEntry
        '
        Me.UcViewerNSSTurnDataEntry.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcViewerNSSTurnDataEntry.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSTurnDataEntry.Location = New System.Drawing.Point(258, 3)
        Me.UcViewerNSSTurnDataEntry.Name = "UcViewerNSSTurnDataEntry"
        Me.UcViewerNSSTurnDataEntry.Size = New System.Drawing.Size(477, 79)
        Me.UcViewerNSSTurnDataEntry.TabIndex = 0
        Me.UcViewerNSSTurnDataEntry.UCNSSCurrent = Nothing
        '
        'PnlLoadAllocationsPriorityApplied
        '
        Me.PnlLoadAllocationsPriorityApplied.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadAllocationsPriorityApplied.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadAllocationsPriorityApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoadAllocationsPriorityApplied.Controls.Add(Me.UcucLoadAllocationCollection)
        Me.PnlLoadAllocationsPriorityApplied.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadAllocationsPriorityApplied.Name = "PnlLoadAllocationsPriorityApplied"
        Me.PnlLoadAllocationsPriorityApplied.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadAllocationsPriorityApplied.TabIndex = 50
        '
        'UcucLoadAllocationCollection
        '
        Me.UcucLoadAllocationCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadAllocationCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadAllocationCollection.Location = New System.Drawing.Point(3, 3)
        Me.UcucLoadAllocationCollection.Name = "UcucLoadAllocationCollection"
        Me.UcucLoadAllocationCollection.Size = New System.Drawing.Size(987, 504)
        Me.UcucLoadAllocationCollection.TabIndex = 0
        '
        'FrmcTruckDriverLoadAllocationsPriorityApplied
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlLoadAllocationRegistering)
        Me.Controls.Add(Me.PnlLoadAllocationsPriorityApplied)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTruckDriverLoadAllocationsPriorityApplied"
        Me.Text = "FrmcTruckDriverLoadAllocationsPriorityApplied"
        Me.Controls.SetChildIndex(Me.PnlLoadAllocationsPriorityApplied, 0)
        Me.Controls.SetChildIndex(Me.PnlLoadAllocationRegistering, 0)
        Me.PnlLoadAllocationRegistering.ResumeLayout(false)
        Me.PnlLoadAllocationsPriorityApplied.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlLoadAllocationRegistering As Windows.Forms.Panel
    Friend WithEvents PnlLoadAllocationsPriorityApplied As Windows.Forms.Panel
    Friend WithEvents UcucLoadCapacitorLoadCollectionAdvance As UCUCLoadCapacitorLoadCollectionAdvance
    Friend WithEvents UcViewerNSSTurnDataEntry As UCViewerNSSTurnDataEntry
    Friend WithEvents UcucLoadAllocationCollection As UCUCLoadAllocationCollection
End Class
