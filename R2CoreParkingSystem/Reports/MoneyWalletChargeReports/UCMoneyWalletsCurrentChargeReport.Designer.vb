Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMoneyWalletsCurrentChargeReport
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
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcButtonSpecial)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcPersianShamsiDate)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(350, 316)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(350, 52)
        Me.UcLabelTop.TabIndex = 351
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش موجودی شارژ کیف های پول"
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(112, 178)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(127, 27)
        Me.UcPersianShamsiDate.TabIndex = 354
        Me.UcPersianShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(3, 64)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(344, 108)
        Me.UcLabel1.TabIndex = 355
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "تاریخ مبنا (کیف هایی که بعد از این تاریخ حداقل یک فعالیت داشته اند وارد گزارش می "& _ 
    "شوند) را وارد نمایید"
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(100, 225)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(150, 45)
        Me.UcButtonSpecial.TabIndex = 356
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = true
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "مشاهده گزارش"
        '
        'UCMoneyWalletsCurrentChargeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMoneyWalletsCurrentChargeReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(356, 322)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonSpecial As UCButtonSpecial
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcPersianShamsiDate As UCPersianShamsiDate
End Class
