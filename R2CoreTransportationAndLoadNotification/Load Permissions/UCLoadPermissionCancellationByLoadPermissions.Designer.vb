Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadPermissionCancellationByLoadPermissions
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcLoadPermissionCancellation = New R2CoreTransportationAndLoadNotification.UCLoadPermissionCancellation()
        Me.UcucLoadPermissionCollectionAdvance = New R2CoreTransportationAndLoadNotification.UCUCLoadPermissionCollectionAdvance()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UcLoadPermissionCancellation)
        Me.Panel1.Controls.Add(Me.UcucLoadPermissionCollectionAdvance)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 551)
        Me.Panel1.TabIndex = 0
        '
        'UcLoadPermissionCancellation
        '
        Me.UcLoadPermissionCancellation.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadPermissionCancellation.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLoadPermissionCancellation.Location = New System.Drawing.Point(0, 0)
        Me.UcLoadPermissionCancellation.Name = "UcLoadPermissionCancellation"
        Me.UcLoadPermissionCancellation.Size = New System.Drawing.Size(913, 125)
        Me.UcLoadPermissionCancellation.TabIndex = 1
        Me.UcLoadPermissionCancellation.UCBackColor = System.Drawing.Color.Black
        Me.UcLoadPermissionCancellation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcLoadPermissionCancellation.UCNSSCurrent = Nothing
        '
        'UcucLoadPermissionCollectionAdvance
        '
        Me.UcucLoadPermissionCollectionAdvance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadPermissionCollectionAdvance.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadPermissionCollectionAdvance.Location = New System.Drawing.Point(0, 131)
        Me.UcucLoadPermissionCollectionAdvance.Name = "UcucLoadPermissionCollectionAdvance"
        Me.UcucLoadPermissionCollectionAdvance.Size = New System.Drawing.Size(913, 417)
        Me.UcucLoadPermissionCollectionAdvance.TabIndex = 0
        '
        'UCLoadPermissionCancellationByLoadPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCLoadPermissionCancellationByLoadPermissions"
        Me.Size = New System.Drawing.Size(913, 551)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcLoadPermissionCancellation As UCLoadPermissionCancellation
    Friend WithEvents UcucLoadPermissionCollectionAdvance As UCUCLoadPermissionCollectionAdvance
End Class
