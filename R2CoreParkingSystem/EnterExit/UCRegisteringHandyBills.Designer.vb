Imports R2CoreGUI

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
        Me.UcButtonDelete = New R2CoreGUI.UCButtonDelete()
        Me.UcLabelLastRegistered = New R2CoreGUI.UCLabel()
        Me.UcNumberTeadad = New R2CoreGUI.UCNumber()
        Me.UcButton = New R2CoreGUI.UCButton()
        Me.UcLabel5 = New R2CoreGUI.UCLabel()
        Me.UcCmbTerafficCardType = New R2CoreParkingSystem.UCCmbTerafficCardType()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcPersianShamsiDate)
        Me.PnlMain.Controls.Add(Me.UcButtonDelete)
        Me.PnlMain.Controls.Add(Me.UcLabelLastRegistered)
        Me.PnlMain.Controls.Add(Me.UcNumberTeadad)
        Me.PnlMain.Controls.Add(Me.UcButton)
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.UcCmbTerafficCardType)
        Me.PnlMain.Controls.Add(Me.UcLabel4)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(306, 469)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonDelete
        '
        Me.UcButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDelete.Location = New System.Drawing.Point(52, 373)
        Me.UcButtonDelete.Name = "UcButtonDelete"
        Me.UcButtonDelete.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDelete.Size = New System.Drawing.Size(89, 34)
        Me.UcButtonDelete.TabIndex = 369
        Me.UcButtonDelete.UCBackColor = System.Drawing.Color.LightGray
        Me.UcButtonDelete.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDelete.UCEnable = true
        Me.UcButtonDelete.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDelete.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonDelete.UCValue = "حذف"
        '
        'UcLabelLastRegistered
        '
        Me.UcLabelLastRegistered._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLastRegistered._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLastRegistered.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLastRegistered.ForeColor = System.Drawing.Color.Silver
        Me.UcLabelLastRegistered.Location = New System.Drawing.Point(52, 336)
        Me.UcLabelLastRegistered.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabelLastRegistered.Name = "UcLabelLastRegistered"
        Me.UcLabelLastRegistered.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabelLastRegistered.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelLastRegistered.Size = New System.Drawing.Size(162, 29)
        Me.UcLabelLastRegistered.TabIndex = 368
        Me.UcLabelLastRegistered.UCBackColor = System.Drawing.Color.White
        Me.UcLabelLastRegistered.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
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
        Me.UcNumberTeadad.Size = New System.Drawing.Size(206, 25)
        Me.UcNumberTeadad.TabIndex = 363
        Me.UcNumberTeadad.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTeadad.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTeadad.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumberTeadad.UCEnable = true
        Me.UcNumberTeadad.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberTeadad.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberTeadad.UCMultiLine = false
        Me.UcNumberTeadad.UCValue = CType(0,Long)
        '
        'UcButton
        '
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(48, 287)
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
        'UcLabel5
        '
        Me.UcLabel5._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel5._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel5.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(304, 52)
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
        Me.UcCmbTerafficCardType.Size = New System.Drawing.Size(212, 49)
        Me.UcCmbTerafficCardType.TabIndex = 361
        '
        'UcLabel4
        '
        Me.UcLabel4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(101, 200)
        Me.UcLabel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabel4.Size = New System.Drawing.Size(103, 34)
        Me.UcLabel4.TabIndex = 366
        Me.UcLabel4.UCBackColor = System.Drawing.Color.White
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "نوع کارت تردد"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(100, 132)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(2)
        Me.UcLabel3.Size = New System.Drawing.Size(103, 27)
        Me.UcLabel3.TabIndex = 364
        Me.UcLabel3.UCBackColor = System.Drawing.Color.White
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "تاریخ موثر"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(99, 63)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel2.Size = New System.Drawing.Size(103, 28)
        Me.UcLabel2.TabIndex = 362
        Me.UcLabel2.UCBackColor = System.Drawing.Color.White
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "تعداد تردد"
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(89, 167)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(127, 23)
        Me.UcPersianShamsiDate.TabIndex = 370
        Me.UcPersianShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        '
        'UCRegisteringHandyBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCRegisteringHandyBills"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(312, 475)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcNumberTeadad As UCNumber
    Friend WithEvents UcButton As UCButton
    Friend WithEvents UcCmbTerafficCardType As R2CoreParkingSystem.UCCmbTerafficCardType
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabelLastRegistered As UCLabel
    Friend WithEvents UcButtonDelete As UCButtonDelete
    Friend WithEvents UcPersianShamsiDate As UCPersianShamsiDate
End Class
