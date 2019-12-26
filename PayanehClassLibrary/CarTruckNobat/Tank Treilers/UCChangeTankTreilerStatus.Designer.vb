Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCChangeTankTreilerStatus
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
        Me.UcTankTreilerManipulation = New PayanehClassLibrary.UCTankTreilerManipulation()
        Me.UcCarTruck = New PayanehClassLibrary.UCCarTruck()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcTankTreilerManipulation)
        Me.PnlMain.Controls.Add(Me.UcCarTruck)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(797, 314)
        Me.PnlMain.TabIndex = 0
        '
        'UcTankTreilerManipulation
        '
        Me.UcTankTreilerManipulation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTankTreilerManipulation.BackColor = System.Drawing.Color.Transparent
        Me.UcTankTreilerManipulation.Location = New System.Drawing.Point(229, 162)
        Me.UcTankTreilerManipulation.Name = "UcTankTreilerManipulation"
        Me.UcTankTreilerManipulation.Padding = New System.Windows.Forms.Padding(10)
        Me.UcTankTreilerManipulation.Size = New System.Drawing.Size(339, 135)
        Me.UcTankTreilerManipulation.TabIndex = 1
        '
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(3, 3)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(791, 153)
        Me.UcCarTruck.TabIndex = 0
        Me.UcCarTruck.UCViewButtons = false
        '
        'UCChangeTankTreilerStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCChangeTankTreilerStatus"
        Me.Size = New System.Drawing.Size(797, 314)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents UcTankTreilerManipulation As UCTankTreilerManipulation
End Class
