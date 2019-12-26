<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersonnelPresenter
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcPersonnelImage = New R2CoreGUI.UCPersonnelImage()
        Me.UcLabelNameFamily = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcPersonnelImage)
        Me.PnlMain.Controls.Add(Me.UcLabelNameFamily)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(200, 200)
        Me.PnlMain.TabIndex = 0
        '
        'UcPersonnelImage
        '
        Me.UcPersonnelImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersonnelImage.Location = New System.Drawing.Point(3, 41)
        Me.UcPersonnelImage.Name = "UcPersonnelImage"
        Me.UcPersonnelImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersonnelImage.Size = New System.Drawing.Size(192, 154)
        Me.UcPersonnelImage.TabIndex = 1
        '
        'UcLabelNameFamily
        '
        Me.UcLabelNameFamily._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelNameFamily._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelNameFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelNameFamily.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelNameFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcLabelNameFamily.Location = New System.Drawing.Point(2, 3)
        Me.UcLabelNameFamily.Name = "UcLabelNameFamily"
        Me.UcLabelNameFamily.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelNameFamily.Size = New System.Drawing.Size(192, 32)
        Me.UcLabelNameFamily.TabIndex = 0
        Me.UcLabelNameFamily.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelNameFamily.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelNameFamily.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelNameFamily.UCValue = ""
        '
        'UCPersonnelPresenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPersonnelPresenter"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(220, 220)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabelNameFamily As UCLabel
    Friend WithEvents UcPersonnelImage As UCPersonnelImage
End Class
