
Imports System.Windows
Imports System.Windows.Forms
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFP
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
        Me.PicFP = New System.Windows.Forms.PictureBox()
        Me.LblLocation = New System.Windows.Forms.Label()
        CType(Me.PicFP,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PicFP
        '
        Me.PicFP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicFP.Location = New System.Drawing.Point(2, 2)
        Me.PicFP.Name = "PicFP"
        Me.PicFP.Size = New System.Drawing.Size(75, 61)
        Me.PicFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFP.TabIndex = 0
        Me.PicFP.TabStop = false
        '
        'LblLocation
        '
        Me.LblLocation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblLocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblLocation.Location = New System.Drawing.Point(2, 66)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(75, 15)
        Me.LblLocation.TabIndex = 1
        Me.LblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCFP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.LblLocation)
        Me.Controls.Add(Me.PicFP)
        Me.Name = "UCFP"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(79, 83)
        CType(Me.PicFP,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PicFP As PictureBox
    Friend WithEvents LblLocation As System.Windows.Forms.Label

End Class
