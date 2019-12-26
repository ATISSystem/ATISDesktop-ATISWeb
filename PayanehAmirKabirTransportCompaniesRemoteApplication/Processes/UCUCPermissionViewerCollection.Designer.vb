Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCPermissionViewerCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCPermissionViewerCollection))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.picexit = New System.Windows.Forms.PictureBox()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.Panel1.SuspendLayout
        Me.PnlTop.SuspendLayout
        CType(Me.picexit,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PnlUCs)
        Me.Panel1.Controls.Add(Me.PnlTop)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 348)
        Me.Panel1.TabIndex = 0
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = true
        Me.PnlUCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUCs.Location = New System.Drawing.Point(3, 36)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(397, 309)
        Me.PnlUCs.TabIndex = 2
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTop.Controls.Add(Me.picexit)
        Me.PnlTop.Controls.Add(Me.UcLabel1)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(403, 31)
        Me.PnlTop.TabIndex = 1
        '
        'picexit
        '
        Me.picexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.picexit.BackColor = System.Drawing.Color.Transparent
        Me.picexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picexit.Image = CType(resources.GetObject("picexit.Image"),System.Drawing.Image)
        Me.picexit.Location = New System.Drawing.Point(369, 5)
        Me.picexit.Name = "picexit"
        Me.picexit.Size = New System.Drawing.Size(27, 20)
        Me.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picexit.TabIndex = 202
        Me.picexit.TabStop = false
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(401, 29)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "لیست مجوزهای صادر شده"
        '
        'UCUCPermissionViewerCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCUCPermissionViewerCollection"
        Me.Size = New System.Drawing.Size(403, 348)
        Me.Panel1.ResumeLayout(false)
        Me.PnlTop.ResumeLayout(false)
        CType(Me.picexit,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents PnlUCs As Panel
    Friend WithEvents picexit As PictureBox
End Class
