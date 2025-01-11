Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCLoadPermissionCancellation
    Inherits UCLoadPermission

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.CheckBoxLoadCapacitorLoad = New System.Windows.Forms.CheckBox()
        Me.UcNumberLoadAllocationId = New R2CoreGUI.UCNumber()
        Me.CheckBoxTurn = New System.Windows.Forms.CheckBox()
        Me.UcButtonLoadPermissionCancelling = New R2CoreGUI.UCButton()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlBorder = New System.Windows.Forms.Panel()
        Me.UcButtonLoadAllocationToOther = New R2CoreGUI.UCButton()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcPersianTextBoxDescription = New R2CoreGUI.UCPersianTextBox()
        Me.UcViewerNSSLoadPermissionExtended = New R2CoreTransportationAndLoadNotification.UCViewerNSSLoadPermissionExtended()
        Me.UcViewerNSSSequentialTurnNumber = New R2CoreTransportationAndLoadNotification.UCViewerNSSSequentialTurnNumber()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.PnlMain.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.PnlBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Size = New System.Drawing.Size(1020, 433)
        Me.PnlMain.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.CheckBoxLoadCapacitorLoad)
        Me.PnlInner.Controls.Add(Me.UcNumberLoadAllocationId)
        Me.PnlInner.Controls.Add(Me.CheckBoxTurn)
        Me.PnlInner.Controls.Add(Me.UcButtonLoadPermissionCancelling)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.PnlBorder)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(1016, 429)
        Me.PnlInner.TabIndex = 16
        '
        'CheckBoxLoadCapacitorLoad
        '
        Me.CheckBoxLoadCapacitorLoad.AutoSize = True
        Me.CheckBoxLoadCapacitorLoad.Checked = True
        Me.CheckBoxLoadCapacitorLoad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLoadCapacitorLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxLoadCapacitorLoad.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBoxLoadCapacitorLoad.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxLoadCapacitorLoad.Location = New System.Drawing.Point(158, 8)
        Me.CheckBoxLoadCapacitorLoad.Name = "CheckBoxLoadCapacitorLoad"
        Me.CheckBoxLoadCapacitorLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxLoadCapacitorLoad.Size = New System.Drawing.Size(134, 27)
        Me.CheckBoxLoadCapacitorLoad.TabIndex = 17
        Me.CheckBoxLoadCapacitorLoad.Text = "بازگردانی بار / کنسلی بار"
        Me.CheckBoxLoadCapacitorLoad.UseVisualStyleBackColor = True
        '
        'UcNumberLoadAllocationId
        '
        Me.UcNumberLoadAllocationId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberLoadAllocationId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberLoadAllocationId.Location = New System.Drawing.Point(779, 9)
        Me.UcNumberLoadAllocationId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberLoadAllocationId.Name = "UcNumberLoadAllocationId"
        Me.UcNumberLoadAllocationId.Size = New System.Drawing.Size(100, 25)
        Me.UcNumberLoadAllocationId.TabIndex = 14
        Me.UcNumberLoadAllocationId.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberLoadAllocationId.UCAllowedMinNumber = CType(-923372036854775808, Long)
        Me.UcNumberLoadAllocationId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberLoadAllocationId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberLoadAllocationId.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberLoadAllocationId.UCBorder = True
        Me.UcNumberLoadAllocationId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberLoadAllocationId.UCEnable = True
        Me.UcNumberLoadAllocationId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberLoadAllocationId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberLoadAllocationId.UCMultiLine = False
        Me.UcNumberLoadAllocationId.UCValue = CType(0, Long)
        '
        'CheckBoxTurn
        '
        Me.CheckBoxTurn.AutoSize = True
        Me.CheckBoxTurn.Checked = True
        Me.CheckBoxTurn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTurn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxTurn.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBoxTurn.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxTurn.Location = New System.Drawing.Point(300, 8)
        Me.CheckBoxTurn.Name = "CheckBoxTurn"
        Me.CheckBoxTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxTurn.Size = New System.Drawing.Size(142, 27)
        Me.CheckBoxTurn.TabIndex = 1
        Me.CheckBoxTurn.Text = "احیاء نوبت / ابطال نوبت"
        Me.CheckBoxTurn.UseVisualStyleBackColor = True
        '
        'UcButtonLoadPermissionCancelling
        '
        Me.UcButtonLoadPermissionCancelling.BackColor = System.Drawing.Color.PaleTurquoise
        Me.UcButtonLoadPermissionCancelling.Location = New System.Drawing.Point(12, 3)
        Me.UcButtonLoadPermissionCancelling.Name = "UcButtonLoadPermissionCancelling"
        Me.UcButtonLoadPermissionCancelling.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadPermissionCancelling.Size = New System.Drawing.Size(133, 36)
        Me.UcButtonLoadPermissionCancelling.TabIndex = 16
        Me.UcButtonLoadPermissionCancelling.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonLoadPermissionCancelling.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadPermissionCancelling.UCEnable = True
        Me.UcButtonLoadPermissionCancelling.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadPermissionCancelling.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadPermissionCancelling.UCValue = "کنسلی مجوز"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(888, 6)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel1.Size = New System.Drawing.Size(102, 27)
        Me.UcLabel1.TabIndex = 15
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "شماره تخصیص بار"
        '
        'PnlBorder
        '
        Me.PnlBorder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBorder.Controls.Add(Me.UcButtonLoadAllocationToOther)
        Me.PnlBorder.Controls.Add(Me.UcLabel3)
        Me.PnlBorder.Controls.Add(Me.UcPersianTextBoxDescription)
        Me.PnlBorder.Controls.Add(Me.UcViewerNSSLoadPermissionExtended)
        Me.PnlBorder.Controls.Add(Me.UcViewerNSSSequentialTurnNumber)
        Me.PnlBorder.Controls.Add(Me.UcLabel2)
        Me.PnlBorder.Controls.Add(Me.UcCar)
        Me.PnlBorder.Controls.Add(Me.UcDriver)
        Me.PnlBorder.Location = New System.Drawing.Point(3, 22)
        Me.PnlBorder.Name = "PnlBorder"
        Me.PnlBorder.Size = New System.Drawing.Size(1009, 403)
        Me.PnlBorder.TabIndex = 16
        '
        'UcButtonLoadAllocationToOther
        '
        Me.UcButtonLoadAllocationToOther.BackColor = System.Drawing.Color.PaleTurquoise
        Me.UcButtonLoadAllocationToOther.Location = New System.Drawing.Point(8, 143)
        Me.UcButtonLoadAllocationToOther.Name = "UcButtonLoadAllocationToOther"
        Me.UcButtonLoadAllocationToOther.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadAllocationToOther.Size = New System.Drawing.Size(133, 36)
        Me.UcButtonLoadAllocationToOther.TabIndex = 19
        Me.UcButtonLoadAllocationToOther.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonLoadAllocationToOther.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadAllocationToOther.UCEnable = True
        Me.UcButtonLoadAllocationToOther.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadAllocationToOther.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadAllocationToOther.UCValue = "تخصیص به راننده دیگر"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.Location = New System.Drawing.Point(426, 24)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel3.Size = New System.Drawing.Size(167, 27)
        Me.UcLabel3.TabIndex = 19
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel3.UCValue = "شرح کنسلی مجوز بارگیری"
        '
        'UcPersianTextBoxDescription
        '
        Me.UcPersianTextBoxDescription.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxDescription.Location = New System.Drawing.Point(8, 24)
        Me.UcPersianTextBoxDescription.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxDescription.Name = "UcPersianTextBoxDescription"
        Me.UcPersianTextBoxDescription.Size = New System.Drawing.Size(416, 27)
        Me.UcPersianTextBoxDescription.TabIndex = 18
        Me.UcPersianTextBoxDescription.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDescription.UCBorder = True
        Me.UcPersianTextBoxDescription.UCBorderColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxDescription.UCEnable = True
        Me.UcPersianTextBoxDescription.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxDescription.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDescription.UCMultiLine = False
        Me.UcPersianTextBoxDescription.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxDescription.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxDescription.UCValue = ""
        '
        'UcViewerNSSLoadPermissionExtended
        '
        Me.UcViewerNSSLoadPermissionExtended.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcViewerNSSLoadPermissionExtended.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSLoadPermissionExtended.Location = New System.Drawing.Point(-2, 48)
        Me.UcViewerNSSLoadPermissionExtended.Name = "UcViewerNSSLoadPermissionExtended"
        Me.UcViewerNSSLoadPermissionExtended.Padding = New System.Windows.Forms.Padding(10)
        Me.UcViewerNSSLoadPermissionExtended.Size = New System.Drawing.Size(1012, 89)
        Me.UcViewerNSSLoadPermissionExtended.TabIndex = 0
        Me.UcViewerNSSLoadPermissionExtended.UCNSSCurrent = Nothing
        '
        'UcViewerNSSSequentialTurnNumber
        '
        Me.UcViewerNSSSequentialTurnNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcViewerNSSSequentialTurnNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSSequentialTurnNumber.Location = New System.Drawing.Point(618, 143)
        Me.UcViewerNSSSequentialTurnNumber.Name = "UcViewerNSSSequentialTurnNumber"
        Me.UcViewerNSSSequentialTurnNumber.Padding = New System.Windows.Forms.Padding(2)
        Me.UcViewerNSSSequentialTurnNumber.Size = New System.Drawing.Size(257, 34)
        Me.UcViewerNSSSequentialTurnNumber.TabIndex = 20
        Me.UcViewerNSSSequentialTurnNumber.UCNSSCurrent = Nothing
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(880, 147)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel2.Size = New System.Drawing.Size(125, 27)
        Me.UcLabel2.TabIndex = 16
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "ناوگان - راننده موافق"
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(6, 186)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(998, 88)
        Me.UcCar.TabIndex = 1
        Me.UcCar.UCViewButtons = False
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Location = New System.Drawing.Point(8, 276)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(996, 121)
        Me.UcDriver.TabIndex = 17
        Me.UcDriver.UCViewButtons = False
        '
        'UCLoadPermissionCancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadPermissionCancellation"
        Me.Size = New System.Drawing.Size(1020, 433)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.PnlInner.PerformLayout()
        Me.PnlBorder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxTurn As System.Windows.Forms.CheckBox
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents UcButtonLoadPermissionCancelling As UCButton
    Friend WithEvents PnlBorder As System.Windows.Forms.Panel
    Friend WithEvents UcNumberLoadAllocationId As UCNumber
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcViewerNSSLoadPermissionExtended As UCViewerNSSLoadPermissionExtended
    Friend WithEvents CheckBoxLoadCapacitorLoad As Windows.Forms.CheckBox
    Friend WithEvents UcCar As R2CoreParkingSystem.UCCar
    Friend WithEvents UcDriver As R2CoreParkingSystem.UCDriver
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcPersianTextBoxDescription As UCPersianTextBox
    Friend WithEvents UcViewerNSSSequentialTurnNumber As UCViewerNSSSequentialTurnNumber
    Friend WithEvents UcButtonLoadAllocationToOther As UCButton
End Class
