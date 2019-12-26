

Imports R2CoreGUI
Imports R2CoreParkingSystem

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCCarTruckNobatCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCCarTruckNobatCollection))
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.UcCarPresenter = New R2CoreParkingSystem.UCCarPresenter()
        Me.PicRefresh = New System.Windows.Forms.PictureBox()
        CType(Me.PicRefresh,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UcLabelTop
        '
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(3, 3)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(743, 53)
        Me.UcLabelTop.TabIndex = 11
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "ناوگان باری - لیست نوبت های صادره"
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = true
        Me.PnlUCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUCs.Location = New System.Drawing.Point(3, 131)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlUCs.Size = New System.Drawing.Size(743, 268)
        Me.PnlUCs.TabIndex = 13
        '
        'UcCarPresenter
        '
        Me.UcCarPresenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcCarPresenter.Location = New System.Drawing.Point(329, 53)
        Me.UcCarPresenter.Name = "UcCarPresenter"
        Me.UcCarPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarPresenter.Size = New System.Drawing.Size(417, 72)
        Me.UcCarPresenter.TabIndex = 14
        '
        'PicRefresh
        '
        Me.PicRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRefresh.Image = CType(resources.GetObject("PicRefresh.Image"),System.Drawing.Image)
        Me.PicRefresh.Location = New System.Drawing.Point(6, 81)
        Me.PicRefresh.Name = "PicRefresh"
        Me.PicRefresh.Size = New System.Drawing.Size(32, 27)
        Me.PicRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefresh.TabIndex = 15
        Me.PicRefresh.TabStop = false
        '
        'UCUCCarTruckNobatCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PicRefresh)
        Me.Controls.Add(Me.PnlUCs)
        Me.Controls.Add(Me.UcLabelTop)
        Me.Controls.Add(Me.UcCarPresenter)
        Me.Name = "UCUCCarTruckNobatCollection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(749, 405)
        CType(Me.PicRefresh,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents PnlUCs As System.Windows.Forms.Panel
    Friend WithEvents UcCarPresenter As UCCarPresenter
    Friend WithEvents PicRefresh As System.Windows.Forms.PictureBox
End Class
