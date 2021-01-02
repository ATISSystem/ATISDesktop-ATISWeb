<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSBillOfLadingControlExtended
    Inherits UCBillOfLadingControl

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
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.LblBLCTitle = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(602, 54)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(602, 54)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.LblStatus)
        Me.PnlInner.Controls.Add(Me.LblUserName)
        Me.PnlInner.Controls.Add(Me.LblDateTime)
        Me.PnlInner.Controls.Add(Me.LblBLCTitle)
        Me.PnlInner.Controls.Add(Me.Label8)
        Me.PnlInner.Controls.Add(Me.Label3)
        Me.PnlInner.Controls.Add(Me.Label2)
        Me.PnlInner.Controls.Add(Me.Label1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(598, 50)
        Me.PnlInner.TabIndex = 0
        '
        'LblStatus
        '
        Me.LblStatus.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblStatus.Location = New System.Drawing.Point(-2, 23)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblStatus.Size = New System.Drawing.Size(67, 23)
        Me.LblStatus.TabIndex = 49
        Me.LblStatus.Text = "غیرفعال"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUserName
        '
        Me.LblUserName.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblUserName.ForeColor = System.Drawing.Color.OliveDrab
        Me.LblUserName.Location = New System.Drawing.Point(71, 23)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUserName.Size = New System.Drawing.Size(119, 23)
        Me.LblUserName.TabIndex = 48
        Me.LblUserName.Text = "محمرضا آوینی"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDateTime
        '
        Me.LblDateTime.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblDateTime.ForeColor = System.Drawing.Color.Firebrick
        Me.LblDateTime.Location = New System.Drawing.Point(196, 23)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDateTime.Size = New System.Drawing.Size(161, 23)
        Me.LblDateTime.TabIndex = 47
        Me.LblDateTime.Text = "13991228-152523"
        Me.LblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBLCTitle
        '
        Me.LblBLCTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblBLCTitle.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblBLCTitle.ForeColor = System.Drawing.Color.Blue
        Me.LblBLCTitle.Location = New System.Drawing.Point(367, 23)
        Me.LblBLCTitle.Name = "LblBLCTitle"
        Me.LblBLCTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBLCTitle.Size = New System.Drawing.Size(224, 23)
        Me.LblBLCTitle.TabIndex = 46
        Me.LblBLCTitle.Text = "تفنگساز - 1"
        Me.LblBLCTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 23)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "وضعیت"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(196, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "زمان ثبت"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(71, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "نام کاربر"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(363, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "عنوان"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCViewerNSSBillOfLadingControlExtended
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSBillOfLadingControlExtended"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(612, 64)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LblStatus As Windows.Forms.Label
    Friend WithEvents LblUserName As Windows.Forms.Label
    Friend WithEvents LblDateTime As Windows.Forms.Label
    Friend WithEvents LblBLCTitle As Windows.Forms.Label
End Class
