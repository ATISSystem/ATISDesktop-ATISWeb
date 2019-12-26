

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDateTimeHolder
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
        Me.UcLabel5 = New UCLabel()
        Me.UcButton = New UCButton()
        Me.UcPersianTextBoxDate1 = New UCPersianTextBox()
        Me.UcPersianTextBoxTime2 = New UCPersianTextBox()
        Me.UcLabel1 = New UCLabel()
        Me.UcPersianTextBoxDate2 = New UCPersianTextBox()
        Me.UcLabel2 = New UCLabel()
        Me.UcPersianTextBoxTime1 = New UCPersianTextBox()
        Me.UcLabel3 = New UCLabel()
        Me.UcLabel4 = New UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.UcButton)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxDate1)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxTime2)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxDate2)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxTime1)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabel4)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(335, 333)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel5
        '
        Me.UcLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel5.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(333, 52)
        Me.UcLabel5.TabIndex = 348
        Me.UcLabel5.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.White
        Me.UcLabel5.UCValue = "محدوده زمانی"
        '
        'UcButton
        '
        Me.UcButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(12, 264)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButton.Size = New System.Drawing.Size(167, 42)
        Me.UcButton.TabIndex = 17
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = true
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "چاپ"
        '
        'UcPersianTextBoxDate1
        '
        Me.UcPersianTextBoxDate1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxDate1.Location = New System.Drawing.Point(12, 83)
        Me.UcPersianTextBoxDate1.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxDate1.Name = "UcPersianTextBoxDate1"
        Me.UcPersianTextBoxDate1.Size = New System.Drawing.Size(248, 40)
        Me.UcPersianTextBoxDate1.TabIndex = 9
        Me.UcPersianTextBoxDate1.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDate1.UCEnable = true
        Me.UcPersianTextBoxDate1.UCFont = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxDate1.UCForeColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxDate1.UCOnlyDigit = R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxDate1.UCValue = "1396/10/25"
        '
        'UcPersianTextBoxTime2
        '
        Me.UcPersianTextBoxTime2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTime2.Location = New System.Drawing.Point(12, 211)
        Me.UcPersianTextBoxTime2.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxTime2.Name = "UcPersianTextBoxTime2"
        Me.UcPersianTextBoxTime2.Size = New System.Drawing.Size(248, 34)
        Me.UcPersianTextBoxTime2.TabIndex = 16
        Me.UcPersianTextBoxTime2.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTime2.UCEnable = true
        Me.UcPersianTextBoxTime2.UCFont = New System.Drawing.Font("IRMehr", 12!)
        Me.UcPersianTextBoxTime2.UCForeColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxTime2.UCOnlyDigit = R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxTime2.UCValue = "06:59:59"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(263, 85)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel1.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel1.TabIndex = 10
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCValue = "از تاریخ"
        '
        'UcPersianTextBoxDate2
        '
        Me.UcPersianTextBoxDate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxDate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxDate2.Location = New System.Drawing.Point(12, 166)
        Me.UcPersianTextBoxDate2.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxDate2.Name = "UcPersianTextBoxDate2"
        Me.UcPersianTextBoxDate2.Size = New System.Drawing.Size(248, 41)
        Me.UcPersianTextBoxDate2.TabIndex = 15
        Me.UcPersianTextBoxDate2.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDate2.UCEnable = true
        Me.UcPersianTextBoxDate2.UCFont = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxDate2.UCForeColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxDate2.UCOnlyDigit = R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxDate2.UCValue = "1396/10/25"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(263, 125)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel2.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel2.TabIndex = 11
        Me.UcLabel2.UCBackColor = System.Drawing.Color.White
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCValue = "از ساعت"
        '
        'UcPersianTextBoxTime1
        '
        Me.UcPersianTextBoxTime1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTime1.Location = New System.Drawing.Point(12, 127)
        Me.UcPersianTextBoxTime1.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxTime1.Name = "UcPersianTextBoxTime1"
        Me.UcPersianTextBoxTime1.Size = New System.Drawing.Size(248, 33)
        Me.UcPersianTextBoxTime1.TabIndex = 14
        Me.UcPersianTextBoxTime1.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTime1.UCEnable = true
        Me.UcPersianTextBoxTime1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxTime1.UCForeColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxTime1.UCOnlyDigit = R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxTime1.UCValue = "07:00:00"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.Location = New System.Drawing.Point(263, 167)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel3.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel3.TabIndex = 12
        Me.UcLabel3.UCBackColor = System.Drawing.Color.White
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCValue = "تا تاریخ"
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.Location = New System.Drawing.Point(263, 210)
        Me.UcLabel4.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel4.Size = New System.Drawing.Size(61, 34)
        Me.UcLabel4.TabIndex = 13
        Me.UcLabel4.UCBackColor = System.Drawing.Color.White
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCValue = "تا ساعت"
        '
        'UCDateTimeHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDateTimeHolder"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(341, 339)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcButton As UCButton
    Friend WithEvents UcPersianTextBoxDate1 As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxTime2 As UCPersianTextBox
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcPersianTextBoxDate2 As UCPersianTextBox
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcPersianTextBoxTime1 As UCPersianTextBox
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabel5 As UCLabel
End Class
