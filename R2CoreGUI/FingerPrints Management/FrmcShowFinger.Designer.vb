<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcShowFinger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        CType(Me.PicFP,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PicFP
        '
        Me.PicFP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFP.Location = New System.Drawing.Point(0, 0)
        Me.PicFP.Name = "PicFP"
        Me.PicFP.Size = New System.Drawing.Size(403, 410)
        Me.PicFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFP.TabIndex = 0
        Me.PicFP.TabStop = false
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.PicFP)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(405, 412)
        Me.PnlMain.TabIndex = 1
        '
        'FrmcShowFinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(407, 414)
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmcShowFinger"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FingerPrintViewer"
        CType(Me.PicFP,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Public WithEvents PicFP As System.Windows.Forms.PictureBox
    Friend WithEvents PnlMain As Windows.Forms.Panel
End Class
