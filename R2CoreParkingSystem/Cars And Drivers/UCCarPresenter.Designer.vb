Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarPresenter
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
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlHolder = New System.Windows.Forms.Panel()
        Me.UcLabelStrCarSerialNo = New R2CoreGUI.UCLabel()
        Me.UcLabelStrCarNo = New R2CoreGUI.UCLabel()
        Me.UcCmbCity = New R2CoreParkingSystem.UCCmbCity()
        Me.UcCmbCarType = New R2CoreParkingSystem.UCCmbCarType()
        Me.PnlMain.SuspendLayout
        Me.PnlHolder.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.PnlHolder)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(542, 65)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(437, -6)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(67, 26)
        Me.UcLabel1.TabIndex = 31
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "خودرو"
        '
        'PnlHolder
        '
        Me.PnlHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHolder.Controls.Add(Me.UcLabelStrCarSerialNo)
        Me.PnlHolder.Controls.Add(Me.UcLabelStrCarNo)
        Me.PnlHolder.Controls.Add(Me.UcCmbCity)
        Me.PnlHolder.Controls.Add(Me.UcCmbCarType)
        Me.PnlHolder.Location = New System.Drawing.Point(3, 11)
        Me.PnlHolder.Name = "PnlHolder"
        Me.PnlHolder.Size = New System.Drawing.Size(536, 51)
        Me.PnlHolder.TabIndex = 30
        '
        'UcLabelStrCarSerialNo
        '
        Me.UcLabelStrCarSerialNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrCarSerialNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrCarSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcLabelStrCarSerialNo.Location = New System.Drawing.Point(262, 11)
        Me.UcLabelStrCarSerialNo.Name = "UcLabelStrCarSerialNo"
        Me.UcLabelStrCarSerialNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrCarSerialNo.Size = New System.Drawing.Size(43, 36)
        Me.UcLabelStrCarSerialNo.TabIndex = 31
        Me.UcLabelStrCarSerialNo.UCBackColor = System.Drawing.Color.White
        Me.UcLabelStrCarSerialNo.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrCarSerialNo.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelStrCarSerialNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrCarSerialNo.UCValue = "13"
        '
        'UcLabelStrCarNo
        '
        Me.UcLabelStrCarNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrCarNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrCarNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcLabelStrCarNo.Location = New System.Drawing.Point(429, 11)
        Me.UcLabelStrCarNo.Name = "UcLabelStrCarNo"
        Me.UcLabelStrCarNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrCarNo.Size = New System.Drawing.Size(102, 36)
        Me.UcLabelStrCarNo.TabIndex = 30
        Me.UcLabelStrCarNo.UCBackColor = System.Drawing.Color.White
        Me.UcLabelStrCarNo.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrCarNo.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelStrCarNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrCarNo.UCValue = "813ی48"
        '
        'UcCmbCity
        '
        Me.UcCmbCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbCity.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbCity.Location = New System.Drawing.Point(311, 11)
        Me.UcCmbCity.Name = "UcCmbCity"
        Me.UcCmbCity.Padding = New System.Windows.Forms.Padding(1)
        Me.UcCmbCity.Size = New System.Drawing.Size(112, 36)
        Me.UcCmbCity.TabIndex = 29
        '
        'UcCmbCarType
        '
        Me.UcCmbCarType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbCarType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbCarType.Location = New System.Drawing.Point(3, 11)
        Me.UcCmbCarType.Name = "UcCmbCarType"
        Me.UcCmbCarType.Padding = New System.Windows.Forms.Padding(1)
        Me.UcCmbCarType.Size = New System.Drawing.Size(253, 36)
        Me.UcCmbCarType.TabIndex = 28
        '
        'UCCarPresenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarPresenter"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(548, 71)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlHolder.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcCmbCity As UCCmbCity
    Friend WithEvents UcCmbCarType As UCCmbCarType
    Friend WithEvents PnlHolder As System.Windows.Forms.Panel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelStrCarSerialNo As UCLabel
    Friend WithEvents UcLabelStrCarNo As UCLabel
End Class
