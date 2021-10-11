
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCResuscitationReserveTurn
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
        Me.UCButtonResuscitation = New R2CoreGUI.UCButtonComputerMessageSender()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcLabelTitle = New R2CoreGUI.UCLabel()
        Me.UcNumberTRRId = New R2CoreGUI.UCNumber()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UCButtonResuscitation)
        Me.PnlMain.Controls.Add(Me.UcDriverImage)
        Me.PnlMain.Controls.Add(Me.UcCarImage)
        Me.PnlMain.Controls.Add(Me.UcDriver)
        Me.PnlMain.Controls.Add(Me.UcCar)
        Me.PnlMain.Controls.Add(Me.UcLabelTitle)
        Me.PnlMain.Controls.Add(Me.UcNumberTRRId)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(811, 277)
        Me.PnlMain.TabIndex = 0
        '
        'UCButtonResuscitation
        '
        Me.UCButtonResuscitation.BackColor = System.Drawing.Color.Transparent
        Me.UCButtonResuscitation.Location = New System.Drawing.Point(6, 6)
        Me.UCButtonResuscitation.Name = "UCButtonResuscitation"
        Me.UCButtonResuscitation.Padding = New System.Windows.Forms.Padding(1)
        Me.UCButtonResuscitation.Size = New System.Drawing.Size(100, 34)
        Me.UCButtonResuscitation.TabIndex = 15
        Me.UCButtonResuscitation.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UCButtonResuscitation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UCButtonResuscitation.UCEnable = False
        Me.UCButtonResuscitation.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UCButtonResuscitation.UCForeColor = System.Drawing.Color.White
        Me.UCButtonResuscitation.UCValue = "احیاء نوبت"
        '
        'UcDriverImage
        '
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(3, 145)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverImage.Size = New System.Drawing.Size(103, 99)
        Me.UcDriverImage.TabIndex = 10
        '
        'UcCarImage
        '
        Me.UcCarImage.BackColor = System.Drawing.Color.White
        Me.UcCarImage.Location = New System.Drawing.Point(3, 56)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(103, 82)
        Me.UcCarImage.TabIndex = 9
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Enabled = False
        Me.UcDriver.Location = New System.Drawing.Point(105, 142)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(701, 105)
        Me.UcDriver.TabIndex = 8
        Me.UcDriver.UCViewButtons = False
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(105, 53)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(701, 88)
        Me.UcCar.TabIndex = 7
        Me.UcCar.UCViewButtons = False
        '
        'UcLabelTitle
        '
        Me.UcLabelTitle._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTitle._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTitle.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTitle.Name = "UcLabelTitle"
        Me.UcLabelTitle.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTitle.Size = New System.Drawing.Size(809, 47)
        Me.UcLabelTitle.TabIndex = 1
        Me.UcLabelTitle.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTitle.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTitle.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelTitle.UCValue = "احیاء نوبت رزرو"
        '
        'UcNumberTRRId
        '
        Me.UcNumberTRRId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberTRRId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTRRId.Location = New System.Drawing.Point(595, 249)
        Me.UcNumberTRRId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberTRRId.Name = "UcNumberTRRId"
        Me.UcNumberTRRId.Size = New System.Drawing.Size(107, 20)
        Me.UcNumberTRRId.TabIndex = 16
        Me.UcNumberTRRId.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberTRRId.UCAllowedMinNumber = CType(-922337206854775808, Long)
        Me.UcNumberTRRId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTRRId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTRRId.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberTRRId.UCBorder = True
        Me.UcNumberTRRId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberTRRId.UCEnable = True
        Me.UcNumberTRRId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTRRId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberTRRId.UCMultiLine = False
        Me.UcNumberTRRId.UCValue = CType(0, Long)
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(708, 243)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(95, 32)
        Me.UcLabel1.TabIndex = 14
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "شماره درخواست"
        '
        'UCResuscitationReserveTurn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCResuscitationReserveTurn"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(831, 297)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelTitle As R2CoreGUI.UCLabel
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcCarImage As R2CoreParkingSystem.UCCarImage
    Friend WithEvents UcDriver As R2CoreParkingSystem.UCDriver
    Friend WithEvents UcCar As R2CoreParkingSystem.UCCar
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UCButtonResuscitation As UCButtonComputerMessageSender
    Friend WithEvents UcNumberTRRId As UCNumber
End Class
