
Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRegisteringHandyBills
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
        Me.UcButtonDelete = New UCButtonDelete()
        Me.UcLabelLastRegistered = New UCLabel()
        Me.UcNumberTeadad = New UCNumber()
        Me.UcButton = New UCButton()
        Me.UcTextBoxDate = New UCTextBox()
        Me.UcLabel5 = New UCLabel()
        Me.UcCmbTerafficCardType = New UCCmbTerafficCardType()
        Me.UcLabel4 = New UCLabel()
        Me.UcLabel3 = New UCLabel()
        Me.UcLabel2 = New UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcButtonDelete)
        Me.PnlMain.Controls.Add(Me.UcLabelLastRegistered)
        Me.PnlMain.Controls.Add(Me.UcNumberTeadad)
        Me.PnlMain.Controls.Add(Me.UcButton)
        Me.PnlMain.Controls.Add(Me.UcTextBoxDate)
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.UcCmbTerafficCardType)
        Me.PnlMain.Controls.Add(Me.UcLabel4)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(309, 435)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonDelete
        '
        Me.UcButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDelete.Location = New System.Drawing.Point(46, 375)
        Me.UcButtonDelete.Name = "UcButtonDelete"
        Me.UcButtonDelete.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDelete.Size = New System.Drawing.Size(95, 34)
        Me.UcButtonDelete.TabIndex = 370
        Me.UcButtonDelete.UCBackColor = System.Drawing.Color.LightGray
        Me.UcButtonDelete.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDelete.UCEnable = true
        Me.UcButtonDelete.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDelete.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonDelete.UCValue = "حذف"
        '
        'UcLabelLastRegistered
        '
        Me.UcLabelLastRegistered.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLastRegistered.Location = New System.Drawing.Point(46, 339)
        Me.UcLabelLastRegistered.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabelLastRegistered.Name = "UcLabelLastRegistered"
        Me.UcLabelLastRegistered.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabelLastRegistered.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelLastRegistered.Size = New System.Drawing.Size(138, 28)
        Me.UcLabelLastRegistered.TabIndex = 368
        Me.UcLabelLastRegistered.UCBackColor = System.Drawing.Color.White
        Me.UcLabelLastRegistered.UCFont = New System.Drawing.Font("B Homa", 9.75!)
        Me.UcLabelLastRegistered.UCForeColor = System.Drawing.Color.Gray
        Me.UcLabelLastRegistered.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelLastRegistered.UCValue = "تعداد ثبت شده : 23"
        '
        'UcNumberTeadad
        '
        Me.UcNumberTeadad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberTeadad.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberTeadad.Location = New System.Drawing.Point(52, 92)
        Me.UcNumberTeadad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberTeadad.Name = "UcNumberTeadad"
        Me.UcNumberTeadad.Size = New System.Drawing.Size(209, 25)
        Me.UcNumberTeadad.TabIndex = 363
        Me.UcNumberTeadad.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTeadad.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTeadad.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumberTeadad.UCEnable = true
        Me.UcNumberTeadad.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberTeadad.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberTeadad.UCValue = CType(0,Long)
        '
        'UcButton
        '
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(46, 290)
        Me.UcButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButton.Size = New System.Drawing.Size(95, 39)
        Me.UcButton.TabIndex = 367
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = true
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "ثبت"
        '
        'UcTextBoxDate
        '
        Me.UcTextBoxDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxDate.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxDate.Location = New System.Drawing.Point(48, 159)
        Me.UcTextBoxDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcTextBoxDate.MaxCharacterReached = CType(50,Short)
        Me.UcTextBoxDate.Name = "UcTextBoxDate"
        Me.UcTextBoxDate.Padding = New System.Windows.Forms.Padding(2)
        Me.UcTextBoxDate.Size = New System.Drawing.Size(213, 30)
        Me.UcTextBoxDate.TabIndex = 365
        Me.UcTextBoxDate.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxDate.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxDate.UCEnable = true
        Me.UcTextBoxDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxDate.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxDate.UCInputLanguageType = R2CoreWinFormRemoteApplicationsEnums.InputLanguageType.None
        Me.UcTextBoxDate.UCOnlyDigit = R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcTextBoxDate.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxDate.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxDate.UCValue = ""
        '
        'UcLabel5
        '
        Me.UcLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel5.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(307, 52)
        Me.UcLabel5.TabIndex = 351
        Me.UcLabel5.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.White
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "ثبت قبوض دستی پارکینگ"
        '
        'UcCmbTerafficCardType
        '
        Me.UcCmbTerafficCardType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbTerafficCardType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbTerafficCardType.Location = New System.Drawing.Point(46, 231)
        Me.UcCmbTerafficCardType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcCmbTerafficCardType.Name = "UcCmbTerafficCardType"
        Me.UcCmbTerafficCardType.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcCmbTerafficCardType.Size = New System.Drawing.Size(215, 49)
        Me.UcCmbTerafficCardType.TabIndex = 361
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(101, 200)
        Me.UcLabel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabel4.Size = New System.Drawing.Size(106, 34)
        Me.UcLabel4.TabIndex = 366
        Me.UcLabel4.UCBackColor = System.Drawing.Color.White
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "نوع کارت تردد"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(100, 132)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabel3.Size = New System.Drawing.Size(106, 27)
        Me.UcLabel3.TabIndex = 364
        Me.UcLabel3.UCBackColor = System.Drawing.Color.White
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "تاریخ موثر"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(99, 63)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel2.Size = New System.Drawing.Size(106, 28)
        Me.UcLabel2.TabIndex = 362
        Me.UcLabel2.UCBackColor = System.Drawing.Color.White
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "تعداد تردد"
        '
        'UCRegisteringHandyBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCRegisteringHandyBills"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(315, 441)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcNumberTeadad As UCNumber
    Friend WithEvents UcButton As UCButton
    Friend WithEvents UcTextBoxDate As UCTextBox
    Friend WithEvents UcCmbTerafficCardType As UCCmbTerafficCardType
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabelLastRegistered As UCLabel
    Friend WithEvents UcButtonDelete As UCButtonDelete
End Class
