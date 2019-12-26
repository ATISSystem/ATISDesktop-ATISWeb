Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTankTreilerManipulation
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
        Me.UcViewerTankTreiler = New PayanehClassLibrary.UCViewerTankTreiler()
        Me.UcButtonChangeStatus = New R2CoreGUI.UCButton()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcButtonChangeStatus)
        Me.PnlMain.Controls.Add(Me.UcViewerTankTreiler)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(319, 115)
        Me.PnlMain.TabIndex = 0
        '
        'UcViewerTankTreiler
        '
        Me.UcViewerTankTreiler.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcViewerTankTreiler.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerTankTreiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcViewerTankTreiler.Location = New System.Drawing.Point(3, 3)
        Me.UcViewerTankTreiler.Name = "UcViewerTankTreiler"
        Me.UcViewerTankTreiler.Padding = New System.Windows.Forms.Padding(5)
        Me.UcViewerTankTreiler.Size = New System.Drawing.Size(311, 58)
        Me.UcViewerTankTreiler.TabIndex = 0
        '
        'UcButtonChangeStatus
        '
        Me.UcButtonChangeStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonChangeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcButtonChangeStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcButtonChangeStatus.Location = New System.Drawing.Point(0, 70)
        Me.UcButtonChangeStatus.Name = "UcButtonChangeStatus"
        Me.UcButtonChangeStatus.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonChangeStatus.Size = New System.Drawing.Size(317, 43)
        Me.UcButtonChangeStatus.TabIndex = 2
        Me.UcButtonChangeStatus.UCBackColor = System.Drawing.Color.RoyalBlue
        Me.UcButtonChangeStatus.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonChangeStatus.UCEnable = true
        Me.UcButtonChangeStatus.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonChangeStatus.UCForeColor = System.Drawing.Color.White
        Me.UcButtonChangeStatus.UCValue = "تغییر وضعیت"
        '
        'UCTankTreilerManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTankTreilerManipulation"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(339, 135)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcButtonChangeStatus As R2CoreGUI.UCButton
    Friend WithEvents UcViewerTankTreiler As UCViewerTankTreiler
End Class
