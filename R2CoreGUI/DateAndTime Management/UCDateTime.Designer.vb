<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDateTime
    Inherits R2CoreGUI.UCGeneral

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDateTime))
        Me.PicClockIcon = New System.Windows.Forms.PictureBox()
        Me.UcLabelDateTime = New R2CoreGUI.UCLabel()
        Me.PnlMain = New System.Windows.Forms.Panel()
        CType(Me.PicClockIcon,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PicClockIcon
        '
        Me.PicClockIcon.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicClockIcon.Image = CType(resources.GetObject("PicClockIcon.Image"),System.Drawing.Image)
        Me.PicClockIcon.Location = New System.Drawing.Point(143, 0)
        Me.PicClockIcon.Name = "PicClockIcon"
        Me.PicClockIcon.Size = New System.Drawing.Size(27, 32)
        Me.PicClockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicClockIcon.TabIndex = 4
        Me.PicClockIcon.TabStop = false
        '
        'UcLabelDateTime
        '
        Me.UcLabelDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcLabelDateTime.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelDateTime.Name = "UcLabelDateTime"
        Me.UcLabelDateTime.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDateTime.Size = New System.Drawing.Size(145, 32)
        Me.UcLabelDateTime.TabIndex = 5
        Me.UcLabelDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateTime.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateTime.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDateTime.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDateTime.UCValue = "1396/12/25   20:59:56"
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PicClockIcon)
        Me.PnlMain.Controls.Add(Me.UcLabelDateTime)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(170, 32)
        Me.PnlMain.TabIndex = 7
        '
        'UCDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDateTime"
        Me.Size = New System.Drawing.Size(170, 32)
        CType(Me.PicClockIcon,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PicClockIcon As System.Windows.Forms.PictureBox
    Friend WithEvents UcLabelDateTime As UCLabel
    Friend WithEvents PnlMain As Panel
End Class
