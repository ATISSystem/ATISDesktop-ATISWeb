
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCSearcherLoadingAndDischargingPlaces
    Inherits UCSearcherAdvance

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSearcherLoadingAndDischargingPlaces))
        Me.PicUnActives = New System.Windows.Forms.PictureBox()
        CType(Me.PicUnActives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicUnActives
        '
        Me.PicUnActives.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicUnActives.Image = CType(resources.GetObject("PicUnActives.Image"), System.Drawing.Image)
        Me.PicUnActives.Location = New System.Drawing.Point(50, 70)
        Me.PicUnActives.Name = "PicUnActives"
        Me.PicUnActives.Size = New System.Drawing.Size(100, 100)
        Me.PicUnActives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUnActives.TabIndex = 7
        Me.PicUnActives.TabStop = False
        '
        'UCSearcherLoadingAndDischargingPlaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "UCSearcherLoadingAndDischargingPlaces"
        Me.Size = New System.Drawing.Size(287, 293)
        Me.UCBackColor = System.Drawing.Color.MediumVioletRed
        Me.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CType(Me.PicUnActives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicUnActives As Windows.Forms.PictureBox
End Class
