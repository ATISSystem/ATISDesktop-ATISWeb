Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCListBoxCitys
    Inherits UCListBox

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCListBoxCitys))
        Me.PictureBoxZeroDistance = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxZeroDistance,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBoxZeroDistance
        '
        Me.PictureBoxZeroDistance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxZeroDistance.Image = CType(resources.GetObject("PictureBoxZeroDistance.Image"),System.Drawing.Image)
        Me.PictureBoxZeroDistance.Location = New System.Drawing.Point(14, 77)
        Me.PictureBoxZeroDistance.Name = "PictureBoxZeroDistance"
        Me.PictureBoxZeroDistance.Size = New System.Drawing.Size(24, 18)
        Me.PictureBoxZeroDistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxZeroDistance.TabIndex = 1
        Me.PictureBoxZeroDistance.TabStop = false
        '
        'UCListBoxCitys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBoxZeroDistance)
        Me.Name = "UCListBoxCitys"
        Me.Size = New System.Drawing.Size(446, 402)
        Me.Controls.SetChildIndex(Me.PictureBoxZeroDistance, 0)
        CType(Me.PictureBoxZeroDistance,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureBoxZeroDistance As System.Windows.Forms.PictureBox
End Class
