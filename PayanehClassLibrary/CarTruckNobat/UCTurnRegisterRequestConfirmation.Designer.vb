Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTurnRegisterRequestConfirmation
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
        Me.ChkNobatTruck = New System.Windows.Forms.CheckBox()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.ChkNobatTruck)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(205, 51)
        Me.PnlMain.TabIndex = 0
        '
        'ChkNobatTruck
        '
        Me.ChkNobatTruck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ChkNobatTruck.AutoSize = true
        Me.ChkNobatTruck.BackColor = System.Drawing.Color.Transparent
        Me.ChkNobatTruck.Checked = true
        Me.ChkNobatTruck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkNobatTruck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkNobatTruck.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkNobatTruck.Location = New System.Drawing.Point(8, 3)
        Me.ChkNobatTruck.Name = "ChkNobatTruck"
        Me.ChkNobatTruck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkNobatTruck.Size = New System.Drawing.Size(187, 39)
        Me.ChkNobatTruck.TabIndex = 335
        Me.ChkNobatTruck.Text = "صدور نوبت ناوگان باری"
        Me.ChkNobatTruck.UseVisualStyleBackColor = false
        '
        'UCTurnRegisterRequestConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTurnRegisterRequestConfirmation"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(211, 57)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents ChkNobatTruck As System.Windows.Forms.CheckBox
End Class
