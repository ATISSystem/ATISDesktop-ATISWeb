<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessage
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
        Me.UcLabel5 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelCMNote = New R2CoreGUI.UCLabel()
        Me.UcLabelCMTypeTitle = New R2CoreGUI.UCLabel()
        Me.UcLabelDateTime = New R2CoreGUI.UCLabel()
        Me.UcLabelComputerName = New R2CoreGUI.UCLabel()
        Me.UcLabelUserName = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Maroon
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcLabelCMNote)
        Me.PnlMain.Controls.Add(Me.UcLabelCMTypeTitle)
        Me.PnlMain.Controls.Add(Me.UcLabelDateTime)
        Me.PnlMain.Controls.Add(Me.UcLabelComputerName)
        Me.PnlMain.Controls.Add(Me.UcLabelUserName)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(539, 111)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel5
        '
        Me.UcLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(178, 57)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(116, 31)
        Me.UcLabel5.TabIndex = 5
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.DarkGray
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "زمان"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(300, 57)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(110, 31)
        Me.UcLabel3.TabIndex = 3
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.DarkGray
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "کامپیوتر"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(416, 57)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(116, 31)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.DarkGray
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کاربر"
        '
        'UcLabelCMNote
        '
        Me.UcLabelCMNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCMNote.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCMNote.Location = New System.Drawing.Point(4, 23)
        Me.UcLabelCMNote.Name = "UcLabelCMNote"
        Me.UcLabelCMNote.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCMNote.Size = New System.Drawing.Size(531, 39)
        Me.UcLabelCMNote.TabIndex = 7
        Me.UcLabelCMNote.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCMNote.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCMNote.UCForeColor = System.Drawing.Color.Yellow
        Me.UcLabelCMNote.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelCMNote.UCValue = "865ع16 ایران 13"
        '
        'UcLabelCMTypeTitle
        '
        Me.UcLabelCMTypeTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCMTypeTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCMTypeTitle.Location = New System.Drawing.Point(4, -8)
        Me.UcLabelCMTypeTitle.Name = "UcLabelCMTypeTitle"
        Me.UcLabelCMTypeTitle.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCMTypeTitle.Size = New System.Drawing.Size(530, 39)
        Me.UcLabelCMTypeTitle.TabIndex = 0
        Me.UcLabelCMTypeTitle.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCMTypeTitle.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCMTypeTitle.UCForeColor = System.Drawing.Color.White
        Me.UcLabelCMTypeTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelCMTypeTitle.UCValue = "پیام دستوری صدور نوبت ناوگان باری"
        '
        'UcLabelDateTime
        '
        Me.UcLabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateTime.Location = New System.Drawing.Point(178, 78)
        Me.UcLabelDateTime.Name = "UcLabelDateTime"
        Me.UcLabelDateTime.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDateTime.Size = New System.Drawing.Size(116, 32)
        Me.UcLabelDateTime.TabIndex = 6
        Me.UcLabelDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateTime.UCFont = New System.Drawing.Font("B Homa", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateTime.UCForeColor = System.Drawing.Color.Gainsboro
        Me.UcLabelDateTime.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDateTime.UCValue = "1396/12/01 08:00:00"
        '
        'UcLabelComputerName
        '
        Me.UcLabelComputerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelComputerName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelComputerName.Location = New System.Drawing.Point(300, 78)
        Me.UcLabelComputerName.Name = "UcLabelComputerName"
        Me.UcLabelComputerName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelComputerName.Size = New System.Drawing.Size(110, 32)
        Me.UcLabelComputerName.TabIndex = 4
        Me.UcLabelComputerName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelComputerName.UCFont = New System.Drawing.Font("B Homa", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelComputerName.UCForeColor = System.Drawing.Color.Gainsboro
        Me.UcLabelComputerName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelComputerName.UCValue = "مسئول شبکه"
        '
        'UcLabelUserName
        '
        Me.UcLabelUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserName.Location = New System.Drawing.Point(416, 78)
        Me.UcLabelUserName.Name = "UcLabelUserName"
        Me.UcLabelUserName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelUserName.Size = New System.Drawing.Size(116, 32)
        Me.UcLabelUserName.TabIndex = 2
        Me.UcLabelUserName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserName.UCFont = New System.Drawing.Font("B Homa", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelUserName.UCForeColor = System.Drawing.Color.Gainsboro
        Me.UcLabelUserName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelUserName.UCValue = "مرتضی شاهمرادی"
        '
        'UCComputerMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCComputerMessage"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(559, 131)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabelCMTypeTitle As UCLabel
    Friend WithEvents UcLabelCMNote As UCLabel
    Friend WithEvents UcLabelDateTime As UCLabel
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabelComputerName As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelUserName As UCLabel
End Class
