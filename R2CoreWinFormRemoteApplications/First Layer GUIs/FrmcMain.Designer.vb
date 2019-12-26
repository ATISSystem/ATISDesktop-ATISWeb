
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcMain))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PicMinimize = New System.Windows.Forms.PictureBox()
        Me.picexit = New System.Windows.Forms.PictureBox()
        Me.LblApplicationDomainDisplayTitle = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        CType(Me.PicMinimize,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picexit,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.LightSlateGray
        Me.PnlMain.Controls.Add(Me.PicMinimize)
        Me.PnlMain.Controls.Add(Me.picexit)
        Me.PnlMain.Controls.Add(Me.LblApplicationDomainDisplayTitle)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1003, 109)
        Me.PnlMain.TabIndex = 0
        '
        'PicMinimize
        '
        Me.PicMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMinimize.Image = CType(resources.GetObject("PicMinimize.Image"),System.Drawing.Image)
        Me.PicMinimize.Location = New System.Drawing.Point(937, 8)
        Me.PicMinimize.Name = "PicMinimize"
        Me.PicMinimize.Size = New System.Drawing.Size(19, 20)
        Me.PicMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMinimize.TabIndex = 202
        Me.PicMinimize.TabStop = false
        '
        'picexit
        '
        Me.picexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.picexit.BackColor = System.Drawing.Color.Transparent
        Me.picexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picexit.Image = CType(resources.GetObject("picexit.Image"),System.Drawing.Image)
        Me.picexit.Location = New System.Drawing.Point(962, 8)
        Me.picexit.Name = "picexit"
        Me.picexit.Size = New System.Drawing.Size(27, 20)
        Me.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picexit.TabIndex = 201
        Me.picexit.TabStop = false
        '
        'LblApplicationDomainDisplayTitle
        '
        Me.LblApplicationDomainDisplayTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblApplicationDomainDisplayTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblApplicationDomainDisplayTitle.Font = New System.Drawing.Font("B Homa", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblApplicationDomainDisplayTitle.ForeColor = System.Drawing.Color.White
        Me.LblApplicationDomainDisplayTitle.Location = New System.Drawing.Point(553, 20)
        Me.LblApplicationDomainDisplayTitle.Name = "LblApplicationDomainDisplayTitle"
        Me.LblApplicationDomainDisplayTitle.Size = New System.Drawing.Size(421, 67)
        Me.LblApplicationDomainDisplayTitle.TabIndex = 203
        Me.LblApplicationDomainDisplayTitle.Text = "پایانه امیر کبیر اصفهان"
        Me.LblApplicationDomainDisplayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmcMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1005, 111)
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmcMain"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmcMain"
        Me.PnlMain.ResumeLayout(false)
        CType(Me.PicMinimize,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picexit,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PicMinimize As PictureBox
    Friend WithEvents picexit As PictureBox
    Friend WithEvents LblApplicationDomainDisplayTitle As Label
End Class
