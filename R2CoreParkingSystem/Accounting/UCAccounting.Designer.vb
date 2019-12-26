
Imports R2CoreGUI.UCGeneral

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAccounting
    Inherits R2CoreGUI.UCGeneral


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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblProcessName = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblDateShamsi = New System.Windows.Forms.Label()
        Me.LblCurrentCharge = New System.Windows.Forms.Label()
        Me.LblMblgh = New System.Windows.Forms.Label()
        Me.LblReminderCharge = New System.Windows.Forms.Label()
        Me.LblMaabarName = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.LblUserName)
        Me.PnlMain.Controls.Add(Me.LblMaabarName)
        Me.PnlMain.Controls.Add(Me.LblReminderCharge)
        Me.PnlMain.Controls.Add(Me.LblMblgh)
        Me.PnlMain.Controls.Add(Me.LblCurrentCharge)
        Me.PnlMain.Controls.Add(Me.LblDateShamsi)
        Me.PnlMain.Controls.Add(Me.LblTime)
        Me.PnlMain.Controls.Add(Me.LblProcessName)
        Me.PnlMain.Controls.Add(Me.Label8)
        Me.PnlMain.Controls.Add(Me.Label7)
        Me.PnlMain.Controls.Add(Me.Label6)
        Me.PnlMain.Controls.Add(Me.Label5)
        Me.PnlMain.Controls.Add(Me.Label4)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(789, 47)
        Me.PnlMain.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(616, -4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 23)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "عملیات"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(548, -4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "ساعت"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(458, -4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "تاریخ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(377, -4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "موجودی"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(306, -5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "مبلغ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(220, -4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "باقیمانده"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(119, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "محل"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(3, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "کاربر"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblProcessName
        '
        Me.LblProcessName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblProcessName.BackColor = System.Drawing.Color.White
        Me.LblProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProcessName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblProcessName.ForeColor = System.Drawing.Color.Black
        Me.LblProcessName.Location = New System.Drawing.Point(616, 18)
        Me.LblProcessName.Name = "LblProcessName"
        Me.LblProcessName.Size = New System.Drawing.Size(167, 23)
        Me.LblProcessName.TabIndex = 33
        Me.LblProcessName.Text = "عملیات"
        Me.LblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTime
        '
        Me.LblTime.BackColor = System.Drawing.Color.White
        Me.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTime.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblTime.ForeColor = System.Drawing.Color.Black
        Me.LblTime.Location = New System.Drawing.Point(548, 18)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(67, 23)
        Me.LblTime.TabIndex = 34
        Me.LblTime.Text = "عملیات"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDateShamsi
        '
        Me.LblDateShamsi.BackColor = System.Drawing.Color.White
        Me.LblDateShamsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDateShamsi.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblDateShamsi.ForeColor = System.Drawing.Color.Black
        Me.LblDateShamsi.Location = New System.Drawing.Point(458, 18)
        Me.LblDateShamsi.Name = "LblDateShamsi"
        Me.LblDateShamsi.Size = New System.Drawing.Size(89, 23)
        Me.LblDateShamsi.TabIndex = 35
        Me.LblDateShamsi.Text = "عملیات"
        Me.LblDateShamsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCurrentCharge
        '
        Me.LblCurrentCharge.BackColor = System.Drawing.Color.White
        Me.LblCurrentCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCurrentCharge.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblCurrentCharge.ForeColor = System.Drawing.Color.Black
        Me.LblCurrentCharge.Location = New System.Drawing.Point(377, 18)
        Me.LblCurrentCharge.Name = "LblCurrentCharge"
        Me.LblCurrentCharge.Size = New System.Drawing.Size(80, 23)
        Me.LblCurrentCharge.TabIndex = 36
        Me.LblCurrentCharge.Text = "عملیات"
        Me.LblCurrentCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMblgh
        '
        Me.LblMblgh.BackColor = System.Drawing.Color.White
        Me.LblMblgh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMblgh.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblMblgh.ForeColor = System.Drawing.Color.Black
        Me.LblMblgh.Location = New System.Drawing.Point(306, 18)
        Me.LblMblgh.Name = "LblMblgh"
        Me.LblMblgh.Size = New System.Drawing.Size(70, 23)
        Me.LblMblgh.TabIndex = 37
        Me.LblMblgh.Text = "عملیات"
        Me.LblMblgh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblReminderCharge
        '
        Me.LblReminderCharge.BackColor = System.Drawing.Color.White
        Me.LblReminderCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblReminderCharge.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblReminderCharge.ForeColor = System.Drawing.Color.Black
        Me.LblReminderCharge.Location = New System.Drawing.Point(220, 18)
        Me.LblReminderCharge.Name = "LblReminderCharge"
        Me.LblReminderCharge.Size = New System.Drawing.Size(85, 23)
        Me.LblReminderCharge.TabIndex = 38
        Me.LblReminderCharge.Text = "عملیات"
        Me.LblReminderCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMaabarName
        '
        Me.LblMaabarName.BackColor = System.Drawing.Color.White
        Me.LblMaabarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMaabarName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblMaabarName.ForeColor = System.Drawing.Color.Black
        Me.LblMaabarName.Location = New System.Drawing.Point(119, 18)
        Me.LblMaabarName.Name = "LblMaabarName"
        Me.LblMaabarName.Size = New System.Drawing.Size(100, 23)
        Me.LblMaabarName.TabIndex = 39
        Me.LblMaabarName.Text = "عملیات"
        Me.LblMaabarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUserName
        '
        Me.LblUserName.BackColor = System.Drawing.Color.White
        Me.LblUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUserName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblUserName.ForeColor = System.Drawing.Color.Black
        Me.LblUserName.Location = New System.Drawing.Point(3, 18)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(115, 23)
        Me.LblUserName.TabIndex = 40
        Me.LblUserName.Text = "عملیات"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCAccounting"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(809, 67)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblProcessName As System.Windows.Forms.Label
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents LblMaabarName As System.Windows.Forms.Label
    Friend WithEvents LblReminderCharge As System.Windows.Forms.Label
    Friend WithEvents LblMblgh As System.Windows.Forms.Label
    Friend WithEvents LblCurrentCharge As System.Windows.Forms.Label
    Friend WithEvents LblDateShamsi As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
End Class
