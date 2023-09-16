
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCActivateUnActivateSMSOwner
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCActivateUnActivateSMSOwner))
        Me.CButtonActivateUnActivateSMSOwner = New CButtonLib.CButton()
        Me.PicRefresh = New System.Windows.Forms.PictureBox()
        CType(Me.PicRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CButtonActivateUnActivateSMSOwner
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CButtonActivateUnActivateSMSOwner.ColorFillBlend = CBlendItems1
        Me.CButtonActivateUnActivateSMSOwner.ColorFillSolid = System.Drawing.Color.DarkGray
        Me.CButtonActivateUnActivateSMSOwner.Corners.LowerRight = 9
        Me.CButtonActivateUnActivateSMSOwner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonActivateUnActivateSMSOwner.DesignerSelected = False
        Me.CButtonActivateUnActivateSMSOwner.Dock = System.Windows.Forms.DockStyle.Right
        Me.CButtonActivateUnActivateSMSOwner.Enabled = False
        Me.CButtonActivateUnActivateSMSOwner.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButtonActivateUnActivateSMSOwner.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonActivateUnActivateSMSOwner.ImageIndex = 0
        Me.CButtonActivateUnActivateSMSOwner.Location = New System.Drawing.Point(19, 0)
        Me.CButtonActivateUnActivateSMSOwner.Name = "CButtonActivateUnActivateSMSOwner"
        Me.CButtonActivateUnActivateSMSOwner.Size = New System.Drawing.Size(155, 27)
        Me.CButtonActivateUnActivateSMSOwner.TabIndex = 24
        Me.CButtonActivateUnActivateSMSOwner.Text = "فعال سازی اس ام اس"
        Me.CButtonActivateUnActivateSMSOwner.TextShadowShow = False
        '
        'PicRefresh
        '
        Me.PicRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicRefresh.Image = CType(resources.GetObject("PicRefresh.Image"), System.Drawing.Image)
        Me.PicRefresh.Location = New System.Drawing.Point(0, 0)
        Me.PicRefresh.Margin = New System.Windows.Forms.Padding(5)
        Me.PicRefresh.Name = "PicRefresh"
        Me.PicRefresh.Size = New System.Drawing.Size(19, 27)
        Me.PicRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicRefresh.TabIndex = 25
        Me.PicRefresh.TabStop = False
        '
        'UCActivateUnActivateSMSOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PicRefresh)
        Me.Controls.Add(Me.CButtonActivateUnActivateSMSOwner)
        Me.Name = "UCActivateUnActivateSMSOwner"
        Me.Size = New System.Drawing.Size(174, 27)
        CType(Me.PicRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CButtonActivateUnActivateSMSOwner As CButtonLib.CButton
    Friend WithEvents PicRefresh As Windows.Forms.PictureBox
End Class
