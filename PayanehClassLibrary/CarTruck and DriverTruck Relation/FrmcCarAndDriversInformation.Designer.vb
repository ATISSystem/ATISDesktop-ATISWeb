Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcCarAndDriversInformation
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.UcTraficCard = New R2CoreParkingSystem.UCTrafficCard()
        Me.UcButtonSabt = New R2CoreGUI.UCButton()
        Me.PnlCarAndDriversInformation = New System.Windows.Forms.Panel()
        Me.UcNumbernIDCar = New R2CoreGUI.UCNumber()
        Me.UcDriverTruckFirst = New PayanehClassLibrary.UCDriverTruck()
        Me.UcDriverTruckSecond = New PayanehClassLibrary.UCDriverTruck()
        Me.UcCarTruck = New PayanehClassLibrary.UCCarTruck()
        Me.PnlTrucksRelationAnnouncementHalls = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlAnnouncementHallsRelationTruck = New UI.Glass.Panel()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups = New R2CoreGUI.UCButtonDelete()
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls = New PayanehClassLibrary.UCCarTruck()
        Me.PnlTankTreilers = New System.Windows.Forms.Panel()
        Me.UcChangeTankTreilerStatus = New PayanehClassLibrary.UCChangeTankTreilerStatus()
        Me.PnlCarAndDriversInformation.SuspendLayout()
        Me.PnlTrucksRelationAnnouncementHalls.SuspendLayout()
        Me.PnlAnnouncementHallsRelationTruck.SuspendLayout()
        Me.PnlTankTreilers.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-2000, -2000)
        '
        'UcTraficCard
        '
        Me.UcTraficCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTraficCard.BackColor = System.Drawing.Color.Transparent
        Me.UcTraficCard.Location = New System.Drawing.Point(626, -1)
        Me.UcTraficCard.Name = "UcTraficCard"
        Me.UcTraficCard.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTraficCard.Size = New System.Drawing.Size(372, 131)
        Me.UcTraficCard.TabIndex = 199
        '
        'UcButtonSabt
        '
        Me.UcButtonSabt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcButtonSabt.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSabt.Location = New System.Drawing.Point(749, 125)
        Me.UcButtonSabt.Name = "UcButtonSabt"
        Me.UcButtonSabt.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonSabt.Size = New System.Drawing.Size(241, 31)
        Me.UcButtonSabt.TabIndex = 204
        Me.UcButtonSabt.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonSabt.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSabt.UCEnable = True
        Me.UcButtonSabt.UCFont = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSabt.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSabt.UCValue = "ثبت رابطه کارت تردد، خودرو ، راننده اول و دوم"
        '
        'PnlCarAndDriversInformation
        '
        Me.PnlCarAndDriversInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCarAndDriversInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCarAndDriversInformation.Controls.Add(Me.UcNumbernIDCar)
        Me.PnlCarAndDriversInformation.Controls.Add(Me.UcButtonSabt)
        Me.PnlCarAndDriversInformation.Controls.Add(Me.UcTraficCard)
        Me.PnlCarAndDriversInformation.Controls.Add(Me.UcDriverTruckFirst)
        Me.PnlCarAndDriversInformation.Controls.Add(Me.UcDriverTruckSecond)
        Me.PnlCarAndDriversInformation.Controls.Add(Me.UcCarTruck)
        Me.PnlCarAndDriversInformation.Location = New System.Drawing.Point(5, 50)
        Me.PnlCarAndDriversInformation.Name = "PnlCarAndDriversInformation"
        Me.PnlCarAndDriversInformation.Size = New System.Drawing.Size(995, 512)
        Me.PnlCarAndDriversInformation.TabIndex = 205
        '
        'UcNumbernIDCar
        '
        Me.UcNumbernIDCar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumbernIDCar.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernIDCar.Location = New System.Drawing.Point(643, 131)
        Me.UcNumbernIDCar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernIDCar.Name = "UcNumbernIDCar"
        Me.UcNumbernIDCar.Size = New System.Drawing.Size(88, 20)
        Me.UcNumbernIDCar.TabIndex = 205
        Me.UcNumbernIDCar.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumbernIDCar.UCAllowedMinNumber = CType(0, Long)
        Me.UcNumbernIDCar.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernIDCar.UCBackColorDisable = System.Drawing.Color.White
        Me.UcNumbernIDCar.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumbernIDCar.UCBorder = False
        Me.UcNumbernIDCar.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumbernIDCar.UCEnable = False
        Me.UcNumbernIDCar.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernIDCar.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernIDCar.UCMultiLine = False
        Me.UcNumbernIDCar.UCValue = CType(0, Long)
        '
        'UcDriverTruckFirst
        '
        Me.UcDriverTruckFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckFirst.Location = New System.Drawing.Point(5, 154)
        Me.UcDriverTruckFirst.Name = "UcDriverTruckFirst"
        Me.UcDriverTruckFirst.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruckFirst.Size = New System.Drawing.Size(986, 167)
        Me.UcDriverTruckFirst.TabIndex = 201
        Me.UcDriverTruckFirst.UCViewButtons = True
        '
        'UcDriverTruckSecond
        '
        Me.UcDriverTruckSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckSecond.Location = New System.Drawing.Point(5, 322)
        Me.UcDriverTruckSecond.Name = "UcDriverTruckSecond"
        Me.UcDriverTruckSecond.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruckSecond.Size = New System.Drawing.Size(986, 169)
        Me.UcDriverTruckSecond.TabIndex = 202
        Me.UcDriverTruckSecond.UCViewButtons = True
        '
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(5, 5)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(604, 151)
        Me.UcCarTruck.TabIndex = 200
        Me.UcCarTruck.UCViewButtons = True
        '
        'PnlTrucksRelationAnnouncementHalls
        '
        Me.PnlTrucksRelationAnnouncementHalls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTrucksRelationAnnouncementHalls.BackColor = System.Drawing.Color.Transparent
        Me.PnlTrucksRelationAnnouncementHalls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTrucksRelationAnnouncementHalls.Controls.Add(Me.Label1)
        Me.PnlTrucksRelationAnnouncementHalls.Controls.Add(Me.PnlAnnouncementHallsRelationTruck)
        Me.PnlTrucksRelationAnnouncementHalls.Controls.Add(Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups)
        Me.PnlTrucksRelationAnnouncementHalls.Controls.Add(Me.UcCarTruckPnlTrucksRelationAnnouncementHalls)
        Me.PnlTrucksRelationAnnouncementHalls.Location = New System.Drawing.Point(5, 50)
        Me.PnlTrucksRelationAnnouncementHalls.Name = "PnlTrucksRelationAnnouncementHalls"
        Me.PnlTrucksRelationAnnouncementHalls.Size = New System.Drawing.Size(995, 512)
        Me.PnlTrucksRelationAnnouncementHalls.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(778, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ناوگان باری - گروه اعلام بار"
        '
        'PnlAnnouncementHallsRelationTruck
        '
        Me.PnlAnnouncementHallsRelationTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlAnnouncementHallsRelationTruck.BackColor = System.Drawing.Color.Transparent
        Me.PnlAnnouncementHallsRelationTruck.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.PnlAnnouncementHallsRelationTruck.Enabled = False
        Me.PnlAnnouncementHallsRelationTruck.GlassColor = System.Drawing.Color.Transparent
        Me.PnlAnnouncementHallsRelationTruck.Location = New System.Drawing.Point(31, 262)
        Me.PnlAnnouncementHallsRelationTruck.MouseReflection = True
        Me.PnlAnnouncementHallsRelationTruck.Name = "PnlAnnouncementHallsRelationTruck"
        Me.PnlAnnouncementHallsRelationTruck.Opacity = 25
        Me.PnlAnnouncementHallsRelationTruck.Radius = 5.0!
        Me.PnlAnnouncementHallsRelationTruck.Size = New System.Drawing.Size(933, 115)
        Me.PnlAnnouncementHallsRelationTruck.TabIndex = 4
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(11, 18)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(910, 80)
        Me.UcAnnouncementHallSelection.TabIndex = 0
        '
        'UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups
        '
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.Location = New System.Drawing.Point(31, 216)
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.Name = "UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups"
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.Size = New System.Drawing.Size(147, 40)
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.TabIndex = 3
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCEnable = True
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCValue = "حذف همه زیرگروه ها"
        '
        'UcCarTruckPnlTrucksRelationAnnouncementHalls
        '
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.Location = New System.Drawing.Point(31, 55)
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.Name = "UcCarTruckPnlTrucksRelationAnnouncementHalls"
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.Size = New System.Drawing.Size(934, 153)
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.TabIndex = 1
        Me.UcCarTruckPnlTrucksRelationAnnouncementHalls.UCViewButtons = False
        '
        'PnlTankTreilers
        '
        Me.PnlTankTreilers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTankTreilers.BackColor = System.Drawing.Color.Transparent
        Me.PnlTankTreilers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTankTreilers.Controls.Add(Me.UcChangeTankTreilerStatus)
        Me.PnlTankTreilers.Location = New System.Drawing.Point(5, 50)
        Me.PnlTankTreilers.Name = "PnlTankTreilers"
        Me.PnlTankTreilers.Size = New System.Drawing.Size(995, 512)
        Me.PnlTankTreilers.TabIndex = 207
        '
        'UcChangeTankTreilerStatus
        '
        Me.UcChangeTankTreilerStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcChangeTankTreilerStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcChangeTankTreilerStatus.Location = New System.Drawing.Point(20, 55)
        Me.UcChangeTankTreilerStatus.Name = "UcChangeTankTreilerStatus"
        Me.UcChangeTankTreilerStatus.Size = New System.Drawing.Size(952, 312)
        Me.UcChangeTankTreilerStatus.TabIndex = 0
        '
        'FrmcCarAndDriversInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlCarAndDriversInformation)
        Me.Controls.Add(Me.PnlTankTreilers)
        Me.Controls.Add(Me.PnlTrucksRelationAnnouncementHalls)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcCarAndDriversInformation"
        Me.Text = "FrmCarAndDriversInformation"
        Me.Controls.SetChildIndex(Me.PnlTrucksRelationAnnouncementHalls, 0)
        Me.Controls.SetChildIndex(Me.PnlTankTreilers, 0)
        Me.Controls.SetChildIndex(Me.PnlCarAndDriversInformation, 0)
        Me.PnlCarAndDriversInformation.ResumeLayout(False)
        Me.PnlTrucksRelationAnnouncementHalls.ResumeLayout(False)
        Me.PnlTrucksRelationAnnouncementHalls.PerformLayout()
        Me.PnlAnnouncementHallsRelationTruck.ResumeLayout(False)
        Me.PnlTankTreilers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcTraficCard As R2CoreParkingSystem.UCTrafficCard
    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents UcDriverTruckFirst As UCDriverTruck
    Friend WithEvents UcDriverTruckSecond As UCDriverTruck
    Friend WithEvents UcButtonSabt As UCButton
    Friend WithEvents PnlCarAndDriversInformation As System.Windows.Forms.Panel
    Friend WithEvents UcNumbernIDCar As UCNumber
    Friend WithEvents PnlTrucksRelationAnnouncementHalls As System.Windows.Forms.Panel
    Friend WithEvents UcCarTruckPnlTrucksRelationAnnouncementHalls As UCCarTruck
    Friend WithEvents PnlTankTreilers As System.Windows.Forms.Panel
    Friend WithEvents UcChangeTankTreilerStatus As UCChangeTankTreilerStatus
    Friend WithEvents UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups As UCButtonDelete
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents PnlAnnouncementHallsRelationTruck As UI.Glass.Panel
    Friend WithEvents UcAnnouncementHallSelection As R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection
End Class
