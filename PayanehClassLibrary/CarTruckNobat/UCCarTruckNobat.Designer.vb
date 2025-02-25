Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarTruckNobat
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
        Me.UcButtonEmergencyResuscitationNobat = New R2CoreGUI.UCButton()
        Me.UcButtonResuscitationNonCreditTurn = New R2CoreGUI.UCButton()
        Me.UcButtonResuscitationNobat = New R2CoreGUI.UCButton()
        Me.UcButtonEbtalNobat = New R2CoreGUI.UCButton()
        Me.UcButtonChop = New R2CoreGUI.UCButton()
        Me.PnlSubMain = New System.Windows.Forms.Panel()
        Me.LblLastChangedStatusDateShamsi = New System.Windows.Forms.Label()
        Me.LblTurnStatusDescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblSequentialNumber = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblDriver = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblEnterTime = New System.Windows.Forms.Label()
        Me.LblEnterDate = New System.Windows.Forms.Label()
        Me.LblnEnterExitId = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.PnlSubMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcButtonEmergencyResuscitationNobat)
        Me.PnlMain.Controls.Add(Me.UcButtonResuscitationNonCreditTurn)
        Me.PnlMain.Controls.Add(Me.UcButtonResuscitationNobat)
        Me.PnlMain.Controls.Add(Me.UcButtonEbtalNobat)
        Me.PnlMain.Controls.Add(Me.UcButtonChop)
        Me.PnlMain.Controls.Add(Me.PnlSubMain)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(841, 128)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonEmergencyResuscitationNobat
        '
        Me.UcButtonEmergencyResuscitationNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonEmergencyResuscitationNobat.Enabled = False
        Me.UcButtonEmergencyResuscitationNobat.Location = New System.Drawing.Point(337, 4)
        Me.UcButtonEmergencyResuscitationNobat.Name = "UcButtonEmergencyResuscitationNobat"
        Me.UcButtonEmergencyResuscitationNobat.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonEmergencyResuscitationNobat.Size = New System.Drawing.Size(140, 37)
        Me.UcButtonEmergencyResuscitationNobat.TabIndex = 19
        Me.UcButtonEmergencyResuscitationNobat.UCBackColor = System.Drawing.Color.Firebrick
        Me.UcButtonEmergencyResuscitationNobat.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonEmergencyResuscitationNobat.UCEnable = True
        Me.UcButtonEmergencyResuscitationNobat.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonEmergencyResuscitationNobat.UCForeColor = System.Drawing.Color.White
        Me.UcButtonEmergencyResuscitationNobat.UCValue = "احیاء اضطراری نوبت"
        '
        'UcButtonResuscitationNonCreditTurn
        '
        Me.UcButtonResuscitationNonCreditTurn.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonResuscitationNonCreditTurn.Enabled = False
        Me.UcButtonResuscitationNonCreditTurn.Location = New System.Drawing.Point(216, 4)
        Me.UcButtonResuscitationNonCreditTurn.Name = "UcButtonResuscitationNonCreditTurn"
        Me.UcButtonResuscitationNonCreditTurn.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonResuscitationNonCreditTurn.Size = New System.Drawing.Size(118, 37)
        Me.UcButtonResuscitationNonCreditTurn.TabIndex = 18
        Me.UcButtonResuscitationNonCreditTurn.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonResuscitationNonCreditTurn.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonResuscitationNonCreditTurn.UCEnable = True
        Me.UcButtonResuscitationNonCreditTurn.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonResuscitationNonCreditTurn.UCForeColor = System.Drawing.Color.White
        Me.UcButtonResuscitationNonCreditTurn.UCValue = "احیاء نوبت زیر اعتبار"
        '
        'UcButtonResuscitationNobat
        '
        Me.UcButtonResuscitationNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonResuscitationNobat.Enabled = False
        Me.UcButtonResuscitationNobat.Location = New System.Drawing.Point(160, 3)
        Me.UcButtonResuscitationNobat.Name = "UcButtonResuscitationNobat"
        Me.UcButtonResuscitationNobat.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonResuscitationNobat.Size = New System.Drawing.Size(55, 37)
        Me.UcButtonResuscitationNobat.TabIndex = 17
        Me.UcButtonResuscitationNobat.UCBackColor = System.Drawing.Color.Firebrick
        Me.UcButtonResuscitationNobat.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonResuscitationNobat.UCEnable = True
        Me.UcButtonResuscitationNobat.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonResuscitationNobat.UCForeColor = System.Drawing.Color.White
        Me.UcButtonResuscitationNobat.UCValue = "احیاء"
        '
        'UcButtonEbtalNobat
        '
        Me.UcButtonEbtalNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonEbtalNobat.Location = New System.Drawing.Point(53, 3)
        Me.UcButtonEbtalNobat.Name = "UcButtonEbtalNobat"
        Me.UcButtonEbtalNobat.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonEbtalNobat.Size = New System.Drawing.Size(104, 37)
        Me.UcButtonEbtalNobat.TabIndex = 16
        Me.UcButtonEbtalNobat.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonEbtalNobat.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonEbtalNobat.UCEnable = True
        Me.UcButtonEbtalNobat.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonEbtalNobat.UCForeColor = System.Drawing.Color.White
        Me.UcButtonEbtalNobat.UCValue = "ابطال"
        '
        'UcButtonChop
        '
        Me.UcButtonChop.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonChop.Location = New System.Drawing.Point(11, 3)
        Me.UcButtonChop.Name = "UcButtonChop"
        Me.UcButtonChop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonChop.Size = New System.Drawing.Size(43, 37)
        Me.UcButtonChop.TabIndex = 0
        Me.UcButtonChop.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonChop.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonChop.UCEnable = True
        Me.UcButtonChop.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonChop.UCForeColor = System.Drawing.Color.White
        Me.UcButtonChop.UCValue = "چاپ"
        '
        'PnlSubMain
        '
        Me.PnlSubMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSubMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSubMain.Controls.Add(Me.LblLastChangedStatusDateShamsi)
        Me.PnlSubMain.Controls.Add(Me.LblTurnStatusDescription)
        Me.PnlSubMain.Controls.Add(Me.Label6)
        Me.PnlSubMain.Controls.Add(Me.Label8)
        Me.PnlSubMain.Controls.Add(Me.Label1)
        Me.PnlSubMain.Controls.Add(Me.Label7)
        Me.PnlSubMain.Controls.Add(Me.LblSequentialNumber)
        Me.PnlSubMain.Controls.Add(Me.LblStatus)
        Me.PnlSubMain.Controls.Add(Me.Label2)
        Me.PnlSubMain.Controls.Add(Me.Label3)
        Me.PnlSubMain.Controls.Add(Me.Label4)
        Me.PnlSubMain.Controls.Add(Me.LblDriver)
        Me.PnlSubMain.Controls.Add(Me.Label5)
        Me.PnlSubMain.Controls.Add(Me.LblEnterTime)
        Me.PnlSubMain.Controls.Add(Me.LblEnterDate)
        Me.PnlSubMain.Controls.Add(Me.LblnEnterExitId)
        Me.PnlSubMain.Location = New System.Drawing.Point(3, 17)
        Me.PnlSubMain.Name = "PnlSubMain"
        Me.PnlSubMain.Size = New System.Drawing.Size(835, 108)
        Me.PnlSubMain.TabIndex = 15
        '
        'LblLastChangedStatusDateShamsi
        '
        Me.LblLastChangedStatusDateShamsi.BackColor = System.Drawing.Color.Transparent
        Me.LblLastChangedStatusDateShamsi.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblLastChangedStatusDateShamsi.ForeColor = System.Drawing.Color.Black
        Me.LblLastChangedStatusDateShamsi.Location = New System.Drawing.Point(3, 71)
        Me.LblLastChangedStatusDateShamsi.Name = "LblLastChangedStatusDateShamsi"
        Me.LblLastChangedStatusDateShamsi.Size = New System.Drawing.Size(110, 23)
        Me.LblLastChangedStatusDateShamsi.TabIndex = 43
        Me.LblLastChangedStatusDateShamsi.Text = "عملیات"
        Me.LblLastChangedStatusDateShamsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTurnStatusDescription
        '
        Me.LblTurnStatusDescription.BackColor = System.Drawing.Color.Transparent
        Me.LblTurnStatusDescription.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblTurnStatusDescription.ForeColor = System.Drawing.Color.Black
        Me.LblTurnStatusDescription.Location = New System.Drawing.Point(123, 71)
        Me.LblTurnStatusDescription.Name = "LblTurnStatusDescription"
        Me.LblTurnStatusDescription.Size = New System.Drawing.Size(151, 23)
        Me.LblTurnStatusDescription.TabIndex = 42
        Me.LblTurnStatusDescription.Text = "عملیات"
        Me.LblTurnStatusDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(597, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "تسلسل"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(119, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 23)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "وضعیت شاخص"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(751, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "شاخص"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(3, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 23)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "تاریخ تغییر وضعیت"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSequentialNumber
        '
        Me.LblSequentialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSequentialNumber.BackColor = System.Drawing.Color.Transparent
        Me.LblSequentialNumber.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblSequentialNumber.ForeColor = System.Drawing.Color.Black
        Me.LblSequentialNumber.Location = New System.Drawing.Point(597, 71)
        Me.LblSequentialNumber.Name = "LblSequentialNumber"
        Me.LblSequentialNumber.Size = New System.Drawing.Size(148, 23)
        Me.LblSequentialNumber.TabIndex = 39
        Me.LblSequentialNumber.Text = "T1403/888888"
        Me.LblSequentialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStatus
        '
        Me.LblStatus.BackColor = System.Drawing.Color.Transparent
        Me.LblStatus.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblStatus.ForeColor = System.Drawing.Color.Black
        Me.LblStatus.Location = New System.Drawing.Point(280, 71)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(68, 23)
        Me.LblStatus.TabIndex = 38
        Me.LblStatus.Text = "عملیات"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(507, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "تاریخ صدور"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(419, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ساعت صدور"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(350, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "راننده"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDriver
        '
        Me.LblDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDriver.BackColor = System.Drawing.Color.Transparent
        Me.LblDriver.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblDriver.ForeColor = System.Drawing.Color.Black
        Me.LblDriver.Location = New System.Drawing.Point(354, 71)
        Me.LblDriver.Name = "LblDriver"
        Me.LblDriver.Size = New System.Drawing.Size(59, 23)
        Me.LblDriver.TabIndex = 37
        Me.LblDriver.Text = "عملیات"
        Me.LblDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(280, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "وضعیت"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEnterTime
        '
        Me.LblEnterTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEnterTime.BackColor = System.Drawing.Color.Transparent
        Me.LblEnterTime.Font = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnterTime.ForeColor = System.Drawing.Color.Black
        Me.LblEnterTime.Location = New System.Drawing.Point(423, 71)
        Me.LblEnterTime.Name = "LblEnterTime"
        Me.LblEnterTime.Size = New System.Drawing.Size(78, 23)
        Me.LblEnterTime.TabIndex = 36
        Me.LblEnterTime.Text = "عملیات"
        Me.LblEnterTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEnterDate
        '
        Me.LblEnterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEnterDate.BackColor = System.Drawing.Color.Transparent
        Me.LblEnterDate.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblEnterDate.ForeColor = System.Drawing.Color.Black
        Me.LblEnterDate.Location = New System.Drawing.Point(507, 71)
        Me.LblEnterDate.Name = "LblEnterDate"
        Me.LblEnterDate.Size = New System.Drawing.Size(84, 23)
        Me.LblEnterDate.TabIndex = 35
        Me.LblEnterDate.Text = "1398/88/88"
        Me.LblEnterDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblnEnterExitId
        '
        Me.LblnEnterExitId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblnEnterExitId.BackColor = System.Drawing.Color.Transparent
        Me.LblnEnterExitId.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblnEnterExitId.ForeColor = System.Drawing.Color.Black
        Me.LblnEnterExitId.Location = New System.Drawing.Point(747, 71)
        Me.LblnEnterExitId.Name = "LblnEnterExitId"
        Me.LblnEnterExitId.Size = New System.Drawing.Size(83, 23)
        Me.LblnEnterExitId.TabIndex = 34
        Me.LblnEnterExitId.Text = "8888888"
        Me.LblnEnterExitId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCCarTruckNobat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarTruckNobat"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(861, 148)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlSubMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcButtonChop As R2CoreGUI.UCButton
    Friend WithEvents PnlSubMain As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UcButtonEbtalNobat As UCButton
    Friend WithEvents UcButtonResuscitationNobat As UCButton
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblDriver As System.Windows.Forms.Label
    Friend WithEvents LblEnterTime As System.Windows.Forms.Label
    Friend WithEvents LblEnterDate As System.Windows.Forms.Label
    Friend WithEvents LblnEnterExitId As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblSequentialNumber As System.Windows.Forms.Label
    Friend WithEvents LblLastChangedStatusDateShamsi As Windows.Forms.Label
    Friend WithEvents LblTurnStatusDescription As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents UcButtonResuscitationNonCreditTurn As UCButton
    Friend WithEvents UcButtonEmergencyResuscitationNobat As UCButton
End Class
