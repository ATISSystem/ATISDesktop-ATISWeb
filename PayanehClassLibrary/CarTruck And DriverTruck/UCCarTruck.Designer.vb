
Imports R2CoreGUI
Imports R2CoreParkingSystem
Imports R2CoreParkingSystem.Cars

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarTruck
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcNumberStrBodyNoSearch = New R2CoreGUI.UCNumber()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcButtonNew = New R2CoreGUI.UCButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcButtonSabt = New R2CoreGUI.UCButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UcNumberStrBodyNo = New R2CoreGUI.UCTextBox()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcNumberStrBodyNoSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UcButtonNew)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.UcButtonSabt)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 147)
        Me.Panel1.TabIndex = 0
        '
        'UcNumberStrBodyNoSearch
        '
        Me.UcNumberStrBodyNoSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberStrBodyNoSearch.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberStrBodyNoSearch.Location = New System.Drawing.Point(261, 6)
        Me.UcNumberStrBodyNoSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberStrBodyNoSearch.Name = "UcNumberStrBodyNoSearch"
        Me.UcNumberStrBodyNoSearch.Size = New System.Drawing.Size(102, 20)
        Me.UcNumberStrBodyNoSearch.TabIndex = 0
        Me.UcNumberStrBodyNoSearch.UCAllowedMaxNumber = CType(9223372036854775807,Long)
        Me.UcNumberStrBodyNoSearch.UCAllowedMinNumber = CType(-922337203685477580,Long)
        Me.UcNumberStrBodyNoSearch.UCBackColor = System.Drawing.Color.White
        Me.UcNumberStrBodyNoSearch.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberStrBodyNoSearch.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberStrBodyNoSearch.UCBorder = true
        Me.UcNumberStrBodyNoSearch.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberStrBodyNoSearch.UCEnable = true
        Me.UcNumberStrBodyNoSearch.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberStrBodyNoSearch.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberStrBodyNoSearch.UCMultiLine = false
        Me.UcNumberStrBodyNoSearch.UCValue = CType(0,Long)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(370, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "شماره هوشمند ناوگان"
        '
        'UcButtonNew
        '
        Me.UcButtonNew.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonNew.Location = New System.Drawing.Point(126, 0)
        Me.UcButtonNew.Name = "UcButtonNew"
        Me.UcButtonNew.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonNew.Size = New System.Drawing.Size(56, 32)
        Me.UcButtonNew.TabIndex = 27
        Me.UcButtonNew.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcButtonNew.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonNew.UCEnable = true
        Me.UcButtonNew.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonNew.UCForeColor = System.Drawing.Color.White
        Me.UcButtonNew.UCValue = "جدید"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(493, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ناوگان باری"
        '
        'UcButtonSabt
        '
        Me.UcButtonSabt.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSabt.Location = New System.Drawing.Point(35, 0)
        Me.UcButtonSabt.Name = "UcButtonSabt"
        Me.UcButtonSabt.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonSabt.Size = New System.Drawing.Size(85, 32)
        Me.UcButtonSabt.TabIndex = 26
        Me.UcButtonSabt.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcButtonSabt.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSabt.UCEnable = true
        Me.UcButtonSabt.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSabt.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSabt.UCValue = "ثبت"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UcNumberStrBodyNo)
        Me.Panel2.Controls.Add(Me.UcCar)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(7, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(587, 125)
        Me.Panel2.TabIndex = 25
        '
        'UcNumberStrBodyNo
        '
        Me.UcNumberStrBodyNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberStrBodyNo.BackColor = System.Drawing.Color.Transparent
        Me.UcNumberStrBodyNo.Location = New System.Drawing.Point(350, 95)
        Me.UcNumberStrBodyNo.Name = "UcNumberStrBodyNo"
        Me.UcNumberStrBodyNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcNumberStrBodyNo.Size = New System.Drawing.Size(134, 25)
        Me.UcNumberStrBodyNo.TabIndex = 23
        Me.UcNumberStrBodyNo.UCBackColor = System.Drawing.Color.White
        Me.UcNumberStrBodyNo.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberStrBodyNo.UCBorder = true
        Me.UcNumberStrBodyNo.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberStrBodyNo.UCEnable = true
        Me.UcNumberStrBodyNo.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!)
        Me.UcNumberStrBodyNo.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberStrBodyNo.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcNumberStrBodyNo.UCMaxCharacterReached = CType(50,Short)
        Me.UcNumberStrBodyNo.UCMaxNumber = CType(99999,Long)
        Me.UcNumberStrBodyNo.UCMultiLine = false
        Me.UcNumberStrBodyNo.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcNumberStrBodyNo.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcNumberStrBodyNo.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcNumberStrBodyNo.UCValue = "0"
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(3, 16)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(579, 80)
        Me.UcCar.TabIndex = 22
        Me.UcCar.UCViewButtons = true
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.Location = New System.Drawing.Point(482, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "شماره هوشمند : "
        '
        'UCCarTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCCarTruck"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(606, 153)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcButtonNew As R2CoreGUI.UCButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcButtonSabt As R2CoreGUI.UCButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UcCar As UCCar
    Friend WithEvents UcNumberStrBodyNo As UCTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UcNumberStrBodyNoSearch As UCNumber
End Class
