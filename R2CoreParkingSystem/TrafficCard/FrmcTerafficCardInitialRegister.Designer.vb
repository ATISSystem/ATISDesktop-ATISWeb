Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTerafficCardInitialRegister
    Inherits FrmcGeneral

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
        Me.PnlInitialRegister = New System.Windows.Forms.Panel()
        Me.UcLabelNote = New R2CoreGUI.UCLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcCmbTerafficTempCardType = New R2CoreParkingSystem.UCCmbTerafficTempCardType()
        Me.UcrfidCardInitialRegistration = New R2CoreGUI.UCRFIDCardInitialRegistration()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UcCmbTerafficCardType = New R2CoreParkingSystem.UCCmbTerafficCardType()
        Me.PnlInitialRegister.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlInitialRegister
        '
        Me.PnlInitialRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlInitialRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInitialRegister.Controls.Add(Me.UcLabelNote)
        Me.PnlInitialRegister.Controls.Add(Me.GroupBox1)
        Me.PnlInitialRegister.Controls.Add(Me.UcrfidCardInitialRegistration)
        Me.PnlInitialRegister.Controls.Add(Me.GroupBox2)
        Me.PnlInitialRegister.Location = New System.Drawing.Point(5, 50)
        Me.PnlInitialRegister.Name = "PnlInitialRegister"
        Me.PnlInitialRegister.Size = New System.Drawing.Size(995, 512)
        Me.PnlInitialRegister.TabIndex = 203
        '
        'UcLabelNote
        '
        Me.UcLabelNote._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelNote._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelNote.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelNote.Location = New System.Drawing.Point(592, 35)
        Me.UcLabelNote.Name = "UcLabelNote"
        Me.UcLabelNote.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelNote.Size = New System.Drawing.Size(290, 147)
        Me.UcLabelNote.TabIndex = 206
        Me.UcLabelNote.UCBackColor = System.Drawing.Color.White
        Me.UcLabelNote.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelNote.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelNote.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelNote.UCValue = "قبل از ثبت کارت تردد نوع کارت و هزینه تردد را مشخص کنید ، سپس کارت را روی دستگاه "& _ 
    "کارت خوان بکشید"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UcCmbTerafficTempCardType)
        Me.GroupBox1.Font = New System.Drawing.Font("B Zar", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(781, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(156, 90)
        Me.GroupBox1.TabIndex = 204
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "نوع کارت"
        '
        'UcCmbTerafficTempCardType
        '
        Me.UcCmbTerafficTempCardType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbTerafficTempCardType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbTerafficTempCardType.Location = New System.Drawing.Point(8, 28)
        Me.UcCmbTerafficTempCardType.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.UcCmbTerafficTempCardType.Name = "UcCmbTerafficTempCardType"
        Me.UcCmbTerafficTempCardType.Padding = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.UcCmbTerafficTempCardType.Size = New System.Drawing.Size(138, 51)
        Me.UcCmbTerafficTempCardType.TabIndex = 208
        '
        'UcrfidCardInitialRegistration
        '
        Me.UcrfidCardInitialRegistration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcrfidCardInitialRegistration.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardInitialRegistration.Location = New System.Drawing.Point(23, 255)
        Me.UcrfidCardInitialRegistration.Name = "UcrfidCardInitialRegistration"
        Me.UcrfidCardInitialRegistration.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardInitialRegistration.Size = New System.Drawing.Size(468, 133)
        Me.UcrfidCardInitialRegistration.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.UcCmbTerafficCardType)
        Me.GroupBox2.Font = New System.Drawing.Font("B Zar", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(592, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(156, 90)
        Me.GroupBox2.TabIndex = 205
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "هزینه تردد"
        '
        'UcCmbTerafficCardType
        '
        Me.UcCmbTerafficCardType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbTerafficCardType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbTerafficCardType.Location = New System.Drawing.Point(8, 22)
        Me.UcCmbTerafficCardType.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.UcCmbTerafficCardType.Name = "UcCmbTerafficCardType"
        Me.UcCmbTerafficCardType.Padding = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.UcCmbTerafficCardType.Size = New System.Drawing.Size(138, 57)
        Me.UcCmbTerafficCardType.TabIndex = 207
        '
        'FrmcTerafficCardInitialRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlInitialRegister)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTerafficCardInitialRegister"
        Me.Text = "FrmcTerafficCardInitialRegister"
        Me.Controls.SetChildIndex(Me.PnlInitialRegister, 0)
        Me.PnlInitialRegister.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlInitialRegister As System.Windows.Forms.Panel
    Friend WithEvents UcLabelNote As UCLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcrfidCardInitialRegistration As UCRFIDCardInitialRegistration
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UcCmbTerafficTempCardType As UCCmbTerafficTempCardType
    Friend WithEvents UcCmbTerafficCardType As UCCmbTerafficCardType
End Class
