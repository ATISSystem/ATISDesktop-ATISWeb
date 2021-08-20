
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreParkingSystem

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDriverTruck
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcNumberStrSmartCardNoSearch = New R2CoreGUI.UCNumber()
        Me.UcButtonNew = New R2CoreGUI.UCButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcButtonSabt = New R2CoreGUI.UCButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcNumberStrSmartCardNo = New R2CoreGUI.UCNumber()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcNumberDriverNationalCode = New R2CoreGUI.UCNumber()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcNumberDriverNationalCode)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.UcNumberStrSmartCardNoSearch)
        Me.PnlMain.Controls.Add(Me.UcButtonNew)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.UcButtonSabt)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(820, 161)
        Me.PnlMain.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(564, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "شماره هوشمند راننده"
        '
        'UcNumberStrSmartCardNoSearch
        '
        Me.UcNumberStrSmartCardNoSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberStrSmartCardNoSearch.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberStrSmartCardNoSearch.Location = New System.Drawing.Point(424, 3)
        Me.UcNumberStrSmartCardNoSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberStrSmartCardNoSearch.Name = "UcNumberStrSmartCardNoSearch"
        Me.UcNumberStrSmartCardNoSearch.Size = New System.Drawing.Size(134, 25)
        Me.UcNumberStrSmartCardNoSearch.TabIndex = 24
        Me.UcNumberStrSmartCardNoSearch.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberStrSmartCardNoSearch.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumberStrSmartCardNoSearch.UCBackColor = System.Drawing.Color.White
        Me.UcNumberStrSmartCardNoSearch.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberStrSmartCardNoSearch.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberStrSmartCardNoSearch.UCBorder = True
        Me.UcNumberStrSmartCardNoSearch.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberStrSmartCardNoSearch.UCEnable = True
        Me.UcNumberStrSmartCardNoSearch.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberStrSmartCardNoSearch.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberStrSmartCardNoSearch.UCMultiLine = False
        Me.UcNumberStrSmartCardNoSearch.UCValue = CType(0, Long)
        '
        'UcButtonNew
        '
        Me.UcButtonNew.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonNew.Location = New System.Drawing.Point(126, 0)
        Me.UcButtonNew.Name = "UcButtonNew"
        Me.UcButtonNew.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonNew.Size = New System.Drawing.Size(60, 32)
        Me.UcButtonNew.TabIndex = 23
        Me.UcButtonNew.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcButtonNew.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonNew.UCEnable = True
        Me.UcButtonNew.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonNew.UCForeColor = System.Drawing.Color.White
        Me.UcButtonNew.UCValue = "جدید"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(684, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "راننده ناوگان باری"
        '
        'UcButtonSabt
        '
        Me.UcButtonSabt.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSabt.Location = New System.Drawing.Point(35, 0)
        Me.UcButtonSabt.Name = "UcButtonSabt"
        Me.UcButtonSabt.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonSabt.Size = New System.Drawing.Size(85, 32)
        Me.UcButtonSabt.TabIndex = 22
        Me.UcButtonSabt.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcButtonSabt.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSabt.UCEnable = True
        Me.UcButtonSabt.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSabt.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSabt.UCValue = "ثبت"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcNumberStrSmartCardNo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.UcDriver)
        Me.Panel1.Location = New System.Drawing.Point(7, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 139)
        Me.Panel1.TabIndex = 1
        '
        'UcNumberStrSmartCardNo
        '
        Me.UcNumberStrSmartCardNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberStrSmartCardNo.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberStrSmartCardNo.Location = New System.Drawing.Point(566, 111)
        Me.UcNumberStrSmartCardNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberStrSmartCardNo.Name = "UcNumberStrSmartCardNo"
        Me.UcNumberStrSmartCardNo.Size = New System.Drawing.Size(134, 25)
        Me.UcNumberStrSmartCardNo.TabIndex = 21
        Me.UcNumberStrSmartCardNo.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberStrSmartCardNo.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumberStrSmartCardNo.UCBackColor = System.Drawing.Color.White
        Me.UcNumberStrSmartCardNo.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberStrSmartCardNo.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberStrSmartCardNo.UCBorder = True
        Me.UcNumberStrSmartCardNo.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberStrSmartCardNo.UCEnable = True
        Me.UcNumberStrSmartCardNo.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberStrSmartCardNo.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberStrSmartCardNo.UCMultiLine = False
        Me.UcNumberStrSmartCardNo.UCValue = CType(0, Long)
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(698, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "شماره هوشمند : "
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Location = New System.Drawing.Point(7, 9)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(791, 101)
        Me.UcDriver.TabIndex = 0
        Me.UcDriver.UCViewButtons = True
        '
        'UcNumberDriverNationalCode
        '
        Me.UcNumberDriverNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberDriverNationalCode.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberDriverNationalCode.Location = New System.Drawing.Point(269, 3)
        Me.UcNumberDriverNationalCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberDriverNationalCode.Name = "UcNumberDriverNationalCode"
        Me.UcNumberDriverNationalCode.Size = New System.Drawing.Size(90, 25)
        Me.UcNumberDriverNationalCode.TabIndex = 27
        Me.UcNumberDriverNationalCode.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberDriverNationalCode.UCAllowedMinNumber = CType(-922337203685477, Long)
        Me.UcNumberDriverNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcNumberDriverNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberDriverNationalCode.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberDriverNationalCode.UCBorder = True
        Me.UcNumberDriverNationalCode.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberDriverNationalCode.UCEnable = True
        Me.UcNumberDriverNationalCode.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberDriverNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberDriverNationalCode.UCMultiLine = False
        Me.UcNumberDriverNationalCode.UCValue = CType(0, Long)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(366, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "کد ملی"
        '
        'UCDriverTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDriverTruck"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(826, 167)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UcDriver As UCDriver
    Friend WithEvents Label1 As Label
    Friend WithEvents UcNumberStrSmartCardNo As R2CoreGUI.UCNumber
    Friend WithEvents Label8 As Label
    Friend WithEvents UcButtonSabt As R2CoreGUI.UCButton
    Friend WithEvents UcButtonNew As UCButton
    Friend WithEvents UcNumberStrSmartCardNoSearch As UCNumber
    Friend WithEvents Label2 As Label
    Friend WithEvents UcNumberDriverNationalCode As UCNumber
    Friend WithEvents Label3 As Label
End Class
