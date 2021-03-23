Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcLoadAllocations
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
        Me.PnlLoadAllocation = New System.Windows.Forms.Panel()
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads = New R2CoreTransportationAndLoadNotification.UCLoadAllocationManipulationByLoadCapacitorLoads()
        Me.PnlLoadAllocationRecords = New System.Windows.Forms.Panel()
        Me.UcLoadAllocationManipulationByLoadAllocations = New R2CoreTransportationAndLoadNotification.UCLoadAllocationManipulationByLoadAllocations()
        Me.PnlLoadCapacitorLoadsStatistics = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcViewerCurrentLoadsStatistics = New R2CoreTransportationAndLoadNotification.UCViewerCurrentLoadsStatistics()
        Me.PnlLoadCapacitor = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcucLoadCapacitorLoadCollectionAdvance = New R2CoreTransportationAndLoadNotification.UCUCLoadCapacitorLoadCollectionAdvance()
        Me.PnlLoadAllocation.SuspendLayout
        Me.PnlLoadAllocationRecords.SuspendLayout
        Me.PnlLoadCapacitorLoadsStatistics.SuspendLayout
        Me.PnlLoadCapacitor.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlLoadAllocation
        '
        Me.PnlLoadAllocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadAllocation.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadAllocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoadAllocation.Controls.Add(Me.UcLoadAllocationManipulationByLoadCapacitorLoads)
        Me.PnlLoadAllocation.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadAllocation.Name = "PnlLoadAllocation"
        Me.PnlLoadAllocation.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadAllocation.TabIndex = 202
        '
        'UcLoadAllocationManipulationByLoadCapacitorLoads
        '
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.Location = New System.Drawing.Point(-3, 1)
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.Name = "UcLoadAllocationManipulationByLoadCapacitorLoads"
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.Size = New System.Drawing.Size(998, 130)
        Me.UcLoadAllocationManipulationByLoadCapacitorLoads.TabIndex = 0
        '
        'PnlLoadAllocationRecords
        '
        Me.PnlLoadAllocationRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadAllocationRecords.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadAllocationRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoadAllocationRecords.Controls.Add(Me.UcLoadAllocationManipulationByLoadAllocations)
        Me.PnlLoadAllocationRecords.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadAllocationRecords.Name = "PnlLoadAllocationRecords"
        Me.PnlLoadAllocationRecords.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadAllocationRecords.TabIndex = 203
        '
        'UcLoadAllocationManipulationByLoadAllocations
        '
        Me.UcLoadAllocationManipulationByLoadAllocations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLoadAllocationManipulationByLoadAllocations.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadAllocationManipulationByLoadAllocations.Location = New System.Drawing.Point(-2, -1)
        Me.UcLoadAllocationManipulationByLoadAllocations.Name = "UcLoadAllocationManipulationByLoadAllocations"
        Me.UcLoadAllocationManipulationByLoadAllocations.Size = New System.Drawing.Size(997, 512)
        Me.UcLoadAllocationManipulationByLoadAllocations.TabIndex = 0
        '
        'PnlLoadCapacitorLoadsStatistics
        '
        Me.PnlLoadCapacitorLoadsStatistics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadCapacitorLoadsStatistics.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadCapacitorLoadsStatistics.Border = true
        Me.PnlLoadCapacitorLoadsStatistics.BorderColor = System.Drawing.Color.Black
        Me.PnlLoadCapacitorLoadsStatistics.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlLoadCapacitorLoadsStatistics.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlLoadCapacitorLoadsStatistics.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlLoadCapacitorLoadsStatistics.Controls.Add(Me.UcViewerCurrentLoadsStatistics)
        Me.PnlLoadCapacitorLoadsStatistics.CornerRadius = 20
        Me.PnlLoadCapacitorLoadsStatistics.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlLoadCapacitorLoadsStatistics.Gradient = true
        Me.PnlLoadCapacitorLoadsStatistics.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlLoadCapacitorLoadsStatistics.GradientOffset = 1!
        Me.PnlLoadCapacitorLoadsStatistics.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlLoadCapacitorLoadsStatistics.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlLoadCapacitorLoadsStatistics.Grayscale = false
        Me.PnlLoadCapacitorLoadsStatistics.Image = Nothing
        Me.PnlLoadCapacitorLoadsStatistics.ImageAlpha = 75
        Me.PnlLoadCapacitorLoadsStatistics.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlLoadCapacitorLoadsStatistics.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlLoadCapacitorLoadsStatistics.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlLoadCapacitorLoadsStatistics.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadCapacitorLoadsStatistics.Name = "PnlLoadCapacitorLoadsStatistics"
        Me.PnlLoadCapacitorLoadsStatistics.Rounded = true
        Me.PnlLoadCapacitorLoadsStatistics.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadCapacitorLoadsStatistics.TabIndex = 205
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlLoadCapacitorLoadsStatistics
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlLoadCapacitorLoadsStatistics
        '
        'UcViewerCurrentLoadsStatistics
        '
        Me.UcViewerCurrentLoadsStatistics.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcViewerCurrentLoadsStatistics.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerCurrentLoadsStatistics.Location = New System.Drawing.Point(99, 66)
        Me.UcViewerCurrentLoadsStatistics.Name = "UcViewerCurrentLoadsStatistics"
        Me.UcViewerCurrentLoadsStatistics.Size = New System.Drawing.Size(796, 358)
        Me.UcViewerCurrentLoadsStatistics.TabIndex = 0
        Me.UcViewerCurrentLoadsStatistics.UCViewTitle = false
        '
        'PnlLoadCapacitor
        '
        Me.PnlLoadCapacitor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadCapacitor.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadCapacitor.Border = true
        Me.PnlLoadCapacitor.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlLoadCapacitor.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlLoadCapacitor.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlLoadCapacitor.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlLoadCapacitor.Controls.Add(Me.UcucLoadCapacitorLoadCollectionAdvance)
        Me.PnlLoadCapacitor.CornerRadius = 20
        Me.PnlLoadCapacitor.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlLoadCapacitor.Gradient = true
        Me.PnlLoadCapacitor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlLoadCapacitor.GradientOffset = 1!
        Me.PnlLoadCapacitor.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlLoadCapacitor.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlLoadCapacitor.Grayscale = false
        Me.PnlLoadCapacitor.Image = Nothing
        Me.PnlLoadCapacitor.ImageAlpha = 75
        Me.PnlLoadCapacitor.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlLoadCapacitor.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlLoadCapacitor.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlLoadCapacitor.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadCapacitor.Name = "PnlLoadCapacitor"
        Me.PnlLoadCapacitor.Rounded = true
        Me.PnlLoadCapacitor.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadCapacitor.TabIndex = 206
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlLoadCapacitor
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlLoadCapacitor
        '
        'UcucLoadCapacitorLoadCollectionAdvance
        '
        Me.UcucLoadCapacitorLoadCollectionAdvance.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadCapacitorLoadCollectionAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucLoadCapacitorLoadCollectionAdvance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucLoadCapacitorLoadCollectionAdvance.Location = New System.Drawing.Point(0, 0)
        Me.UcucLoadCapacitorLoadCollectionAdvance.Name = "UcucLoadCapacitorLoadCollectionAdvance"
        Me.UcucLoadCapacitorLoadCollectionAdvance.Size = New System.Drawing.Size(995, 512)
        Me.UcucLoadCapacitorLoadCollectionAdvance.TabIndex = 0
        '
        'FrmcLoadAllocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlLoadCapacitor)
        Me.Controls.Add(Me.PnlLoadAllocation)
        Me.Controls.Add(Me.PnlLoadAllocationRecords)
        Me.Controls.Add(Me.PnlLoadCapacitorLoadsStatistics)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadAllocations"
        Me.Text = "FrmcLoadAllocations"
        Me.Controls.SetChildIndex(Me.PnlLoadCapacitorLoadsStatistics, 0)
        Me.Controls.SetChildIndex(Me.PnlLoadAllocationRecords, 0)
        Me.Controls.SetChildIndex(Me.PnlLoadAllocation, 0)
        Me.Controls.SetChildIndex(Me.PnlLoadCapacitor, 0)
        Me.PnlLoadAllocation.ResumeLayout(false)
        Me.PnlLoadAllocationRecords.ResumeLayout(false)
        Me.PnlLoadCapacitorLoadsStatistics.ResumeLayout(false)
        Me.PnlLoadCapacitor.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlLoadAllocation As System.Windows.Forms.Panel
    Friend WithEvents UcLoadAllocationManipulationByLoadCapacitorLoads As UCLoadAllocationManipulationByLoadCapacitorLoads
    Friend WithEvents PnlLoadAllocationRecords As System.Windows.Forms.Panel
    Friend WithEvents UcLoadAllocationManipulationByLoadAllocations As UCLoadAllocationManipulationByLoadAllocations
    Friend WithEvents PnlLoadCapacitorLoadsStatistics As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcViewerCurrentLoadsStatistics As UCViewerCurrentLoadsStatistics
    Friend WithEvents PnlLoadCapacitor As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcucLoadCapacitorLoadCollectionAdvance As UCUCLoadCapacitorLoadCollectionAdvance
End Class
