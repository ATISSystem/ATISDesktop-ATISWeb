Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTerafficCardPresenter
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
        Me.PnlHolder = New System.Windows.Forms.Panel()
        Me.UcLabelCardNo = New R2CoreGUI.UCLabel()
        Me.UcLabelCardTypeName = New R2CoreGUI.UCLabel()
        Me.UcLabelCardId = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlHolder.SuspendLayout
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlHolder
        '
        Me.PnlHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHolder.Controls.Add(Me.UcLabelCardNo)
        Me.PnlHolder.Controls.Add(Me.UcLabelCardTypeName)
        Me.PnlHolder.Controls.Add(Me.UcLabelCardId)
        Me.PnlHolder.Location = New System.Drawing.Point(3, 15)
        Me.PnlHolder.Name = "PnlHolder"
        Me.PnlHolder.Size = New System.Drawing.Size(280, 34)
        Me.PnlHolder.TabIndex = 3
        '
        'UcLabelCardNo
        '
        Me.UcLabelCardNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCardNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCardNo.Location = New System.Drawing.Point(195, 3)
        Me.UcLabelCardNo.Name = "UcLabelCardNo"
        Me.UcLabelCardNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCardNo.Size = New System.Drawing.Size(87, 26)
        Me.UcLabelCardNo.TabIndex = 1
        Me.UcLabelCardNo.UCBackColor = System.Drawing.Color.White
        Me.UcLabelCardNo.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCardNo.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelCardNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCardNo.UCValue = "SAF3244"
        '
        'UcLabelCardTypeName
        '
        Me.UcLabelCardTypeName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCardTypeName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCardTypeName.Location = New System.Drawing.Point(2, -1)
        Me.UcLabelCardTypeName.Name = "UcLabelCardTypeName"
        Me.UcLabelCardTypeName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCardTypeName.Size = New System.Drawing.Size(122, 30)
        Me.UcLabelCardTypeName.TabIndex = 3
        Me.UcLabelCardTypeName.UCBackColor = System.Drawing.Color.White
        Me.UcLabelCardTypeName.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCardTypeName.UCForeColor = System.Drawing.Color.Navy
        Me.UcLabelCardTypeName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCardTypeName.UCValue = "دائمی-تریلی"
        '
        'UcLabelCardId
        '
        Me.UcLabelCardId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCardId.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCardId.Location = New System.Drawing.Point(124, -1)
        Me.UcLabelCardId.Name = "UcLabelCardId"
        Me.UcLabelCardId.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCardId.Size = New System.Drawing.Size(69, 30)
        Me.UcLabelCardId.TabIndex = 2
        Me.UcLabelCardId.UCBackColor = System.Drawing.Color.White
        Me.UcLabelCardId.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCardId.UCForeColor = System.Drawing.Color.Maroon
        Me.UcLabelCardId.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCardId.UCValue = "123133"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(189, -1)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(67, 26)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کارت تردد"
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.PnlHolder)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(287, 52)
        Me.PnlMain.TabIndex = 0
        '
        'UCTerafficCardPresenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTerafficCardPresenter"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(293, 58)
        Me.PnlHolder.ResumeLayout(false)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlHolder As System.Windows.Forms.Panel
    Friend WithEvents UcLabelCardNo As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelCardTypeName As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelCardId As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
End Class
