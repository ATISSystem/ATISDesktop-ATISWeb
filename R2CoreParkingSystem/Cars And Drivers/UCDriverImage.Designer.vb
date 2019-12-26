Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDriverImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDriverImage))
        Me.PicDriver = New System.Windows.Forms.PictureBox()
        CType(Me.PicDriver,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PicDriverTruck
        '
        Me.PicDriver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicDriver.Image = CType(resources.GetObject("PicDriver.Image"),System.Drawing.Image)
        Me.PicDriver.Location = New System.Drawing.Point(3, 3)
        Me.PicDriver.Name = "PicDriver"
        Me.PicDriver.Size = New System.Drawing.Size(258, 277)
        Me.PicDriver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDriver.TabIndex = 0
        Me.PicDriver.TabStop = false
        '
        'UCDriverTruckImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PicDriver)
        Me.Name = "UCDriverTruckImage"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(264, 283)
        CType(Me.PicDriver,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PicDriver As System.Windows.Forms.PictureBox
End Class
