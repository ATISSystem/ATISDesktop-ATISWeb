
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageProducerEmergencyTurnRegisterRequest
    Inherits UCComputerMessageProducer

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
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcPersianTextBoxNote = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.SuspendLayout
        '
        'UcDriverImage
        '
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(14, 155)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverImage.Size = New System.Drawing.Size(103, 99)
        Me.UcDriverImage.TabIndex = 10
        '
        'UcCarImage
        '
        Me.UcCarImage.BackColor = System.Drawing.Color.White
        Me.UcCarImage.Location = New System.Drawing.Point(14, 66)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(103, 82)
        Me.UcCarImage.TabIndex = 9
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Enabled = false
        Me.UcDriver.Location = New System.Drawing.Point(116, 152)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(828, 105)
        Me.UcDriver.TabIndex = 8
        Me.UcDriver.UCViewButtons = false
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(116, 63)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(828, 88)
        Me.UcCar.TabIndex = 7
        Me.UcCar.UCViewButtons = false
        '
        'UcPersianTextBoxNote
        '
        Me.UcPersianTextBoxNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxNote.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxNote.Location = New System.Drawing.Point(583, 260)
        Me.UcPersianTextBoxNote.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxNote.Name = "UcPersianTextBoxNote"
        Me.UcPersianTextBoxNote.Size = New System.Drawing.Size(300, 27)
        Me.UcPersianTextBoxNote.TabIndex = 11
        Me.UcPersianTextBoxNote.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxNote.UCBorder = true
        Me.UcPersianTextBoxNote.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxNote.UCEnable = true
        Me.UcPersianTextBoxNote.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxNote.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxNote.UCMultiLine = false
        Me.UcPersianTextBoxNote.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxNote.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxNote.UCValue = ""
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(889, 256)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(57, 32)
        Me.UcLabel1.TabIndex = 12
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "توضیحات "
        '
        'UCComputerMessageProducerEmergencyTurnRegisterRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcPersianTextBoxNote)
        Me.Controls.Add(Me.UcDriverImage)
        Me.Controls.Add(Me.UcCarImage)
        Me.Controls.Add(Me.UcDriver)
        Me.Controls.Add(Me.UcCar)
        Me.Name = "UCComputerMessageProducerEmergencyTurnRegisterRequest"
        Me.Size = New System.Drawing.Size(958, 304)
        Me.Controls.SetChildIndex(Me.UcCar, 0)
        Me.Controls.SetChildIndex(Me.UcDriver, 0)
        Me.Controls.SetChildIndex(Me.UcCarImage, 0)
        Me.Controls.SetChildIndex(Me.UcDriverImage, 0)
        Me.Controls.SetChildIndex(Me.UcPersianTextBoxNote, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcCarImage As R2CoreParkingSystem.UCCarImage
    Friend WithEvents UcDriver As R2CoreParkingSystem.UCDriver
    Friend WithEvents UcCar As R2CoreParkingSystem.UCCar
    Friend WithEvents UcPersianTextBoxNote As UCPersianTextBox
    Friend WithEvents UcLabel1 As UCLabel
End Class
