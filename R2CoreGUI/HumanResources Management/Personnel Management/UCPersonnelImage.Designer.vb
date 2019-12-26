Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersonnelImage
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
        Me.PicPersonnel = New System.Windows.Forms.PictureBox()
        CType(Me.PicPersonnel,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PicPersonnel
        '
        Me.PicPersonnel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPersonnel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPersonnel.Location = New System.Drawing.Point(3, 3)
        Me.PicPersonnel.Name = "PicPersonnel"
        Me.PicPersonnel.Size = New System.Drawing.Size(258, 258)
        Me.PicPersonnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPersonnel.TabIndex = 0
        Me.PicPersonnel.TabStop = false
        '
        'UCPersonnelImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PicPersonnel)
        Me.Name = "UCPersonnelImage"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(264, 264)
        CType(Me.PicPersonnel,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PicPersonnel As System.Windows.Forms.PictureBox
End Class
