Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMoneyWallet
    Inherits  UCGeneral

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
        Me.PnLBottom = New System.Windows.Forms.Panel()
        Me.UcLabelAccountName = New R2CoreGUI.UCLabel()
        Me.UcLabelReminderCharge = New R2CoreGUI.UCLabel()
        Me.UcLabelMblgh = New R2CoreGUI.UCLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcLabelCardNo = New R2CoreGUI.UCLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UcLabelCurrentCharge = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnLBottom.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnLBottom)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.UcLabelCardNo)
        Me.PnlMain.Controls.Add(Me.Label6)
        Me.PnlMain.Controls.Add(Me.UcLabelCurrentCharge)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(197, 230)
        Me.PnlMain.TabIndex = 0
        '
        'PnLBottom
        '
        Me.PnLBottom.Controls.Add(Me.UcLabelAccountName)
        Me.PnLBottom.Controls.Add(Me.UcLabelReminderCharge)
        Me.PnLBottom.Controls.Add(Me.UcLabelMblgh)
        Me.PnLBottom.Controls.Add(Me.Label13)
        Me.PnLBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnLBottom.Location = New System.Drawing.Point(0, 145)
        Me.PnLBottom.Name = "PnLBottom"
        Me.PnLBottom.Size = New System.Drawing.Size(197, 85)
        Me.PnLBottom.TabIndex = 348
        Me.PnLBottom.Visible = false
        '
        'UcLabelAccountName
        '
        Me.UcLabelAccountName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelAccountName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountName.Font = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelAccountName.ForeColor = System.Drawing.Color.Navy
        Me.UcLabelAccountName.Location = New System.Drawing.Point(1, -15)
        Me.UcLabelAccountName.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.UcLabelAccountName.Name = "UcLabelAccountName"
        Me.UcLabelAccountName.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UcLabelAccountName.Size = New System.Drawing.Size(194, 37)
        Me.UcLabelAccountName.TabIndex = 346
        Me.UcLabelAccountName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAccountName.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelAccountName.UCForeColor = System.Drawing.Color.Navy
        Me.UcLabelAccountName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAccountName.UCValue = "هزینه تردد"
        '
        'UcLabelReminderCharge
        '
        Me.UcLabelReminderCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelReminderCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelReminderCharge.Location = New System.Drawing.Point(1, 60)
        Me.UcLabelReminderCharge.Name = "UcLabelReminderCharge"
        Me.UcLabelReminderCharge.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelReminderCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelReminderCharge.Size = New System.Drawing.Size(194, 26)
        Me.UcLabelReminderCharge.TabIndex = 345
        Me.UcLabelReminderCharge.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelReminderCharge.UCFont = New System.Drawing.Font("B Titr", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelReminderCharge.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelReminderCharge.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelReminderCharge.UCValue = ""
        '
        'UcLabelMblgh
        '
        Me.UcLabelMblgh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelMblgh.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelMblgh.Location = New System.Drawing.Point(1, 16)
        Me.UcLabelMblgh.Name = "UcLabelMblgh"
        Me.UcLabelMblgh.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelMblgh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelMblgh.Size = New System.Drawing.Size(194, 25)
        Me.UcLabelMblgh.TabIndex = 344
        Me.UcLabelMblgh.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelMblgh.UCFont = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold)
        Me.UcLabelMblgh.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelMblgh.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelMblgh.UCValue = ""
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(5, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(187, 37)
        Me.Label13.TabIndex = 339
        Me.Label13.Text = "باقیمانده"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(197, 52)
        Me.UcLabel1.TabIndex = 347
        Me.UcLabel1.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کیف پول"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(178, 29)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "شماره"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelCardNo
        '
        Me.UcLabelCardNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCardNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCardNo.Location = New System.Drawing.Point(9, 75)
        Me.UcLabelCardNo.Name = "UcLabelCardNo"
        Me.UcLabelCardNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCardNo.Size = New System.Drawing.Size(178, 22)
        Me.UcLabelCardNo.TabIndex = 345
        Me.UcLabelCardNo.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCardNo.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelCardNo.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabelCardNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCardNo.UCValue = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(9, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(178, 39)
        Me.Label6.TabIndex = 337
        Me.Label6.Text = "موجودی فعلی"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelCurrentCharge
        '
        Me.UcLabelCurrentCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCurrentCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCurrentCharge.Location = New System.Drawing.Point(3, 118)
        Me.UcLabelCurrentCharge.Name = "UcLabelCurrentCharge"
        Me.UcLabelCurrentCharge.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCurrentCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelCurrentCharge.Size = New System.Drawing.Size(191, 24)
        Me.UcLabelCurrentCharge.TabIndex = 349
        Me.UcLabelCurrentCharge.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCurrentCharge.UCFont = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCurrentCharge.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelCurrentCharge.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCurrentCharge.UCValue = ""
        '
        'UCMoneyWallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMoneyWallet"
        Me.Size = New System.Drawing.Size(197, 230)
        Me.PnlMain.ResumeLayout(false)
        Me.PnLBottom.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcLabelCardNo As R2CoreGUI.UCLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UcLabelCurrentCharge As UCLabel
    Friend WithEvents PnLBottom As System.Windows.Forms.Panel
    Friend WithEvents UcLabelAccountName As UCLabel
    Friend WithEvents UcLabelReminderCharge As UCLabel
    Friend WithEvents UcLabelMblgh As UCLabel
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
