Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageProducerRealTimeTurnRegisterRequest
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
        Dim R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1 As R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure = New R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.UcucSequentialTurnCollection = New R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection()
        Me.SuspendLayout()
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(116, 101)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(785, 88)
        Me.UcCar.TabIndex = 1
        Me.UcCar.UCViewButtons = False
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Enabled = False
        Me.UcDriver.Location = New System.Drawing.Point(116, 186)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(785, 105)
        Me.UcDriver.TabIndex = 4
        Me.UcDriver.UCViewButtons = False
        '
        'UcCarImage
        '
        Me.UcCarImage.BackColor = System.Drawing.Color.White
        Me.UcCarImage.Location = New System.Drawing.Point(14, 104)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(103, 82)
        Me.UcCarImage.TabIndex = 5
        '
        'UcDriverImage
        '
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(14, 189)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverImage.Size = New System.Drawing.Size(103, 99)
        Me.UcDriverImage.TabIndex = 6
        '
        'UcucSequentialTurnCollection
        '
        Me.UcucSequentialTurnCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucSequentialTurnCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucSequentialTurnCollection.Location = New System.Drawing.Point(19, 62)
        Me.UcucSequentialTurnCollection.Name = "UcucSequentialTurnCollection"
        Me.UcucSequentialTurnCollection.Size = New System.Drawing.Size(876, 38)
        Me.UcucSequentialTurnCollection.TabIndex = 7
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.Active = True
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.Deleted = False
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnColor = "Red"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnId = CType(0, Long)
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnKeyWord = "N"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnTitle = "نامعلوم"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.ViewFlag = True
        Me.UcucSequentialTurnCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1
        '
        'UCComputerMessageProducerRealTimeTurnRegisterRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcucSequentialTurnCollection)
        Me.Controls.Add(Me.UcDriverImage)
        Me.Controls.Add(Me.UcCarImage)
        Me.Controls.Add(Me.UcDriver)
        Me.Controls.Add(Me.UcCar)
        Me.Name = "UCComputerMessageProducerRealTimeTurnRegisterRequest"
        Me.Size = New System.Drawing.Size(915, 304)
        Me.Controls.SetChildIndex(Me.UcCar, 0)
        Me.Controls.SetChildIndex(Me.UcDriver, 0)
        Me.Controls.SetChildIndex(Me.UcCarImage, 0)
        Me.Controls.SetChildIndex(Me.UcDriverImage, 0)
        Me.Controls.SetChildIndex(Me.UcucSequentialTurnCollection, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcCar As R2CoreParkingSystem.UCCar
    Friend WithEvents UcDriver As R2CoreParkingSystem.UCDriver
    Friend WithEvents UcCarImage As R2CoreParkingSystem.UCCarImage
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcucSequentialTurnCollection As R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection
End Class
