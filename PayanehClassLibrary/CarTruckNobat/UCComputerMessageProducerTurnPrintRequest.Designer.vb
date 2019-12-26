Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCComputerMessageProducerTurnPrintRequest
    Inherits UCComputerMessageProducer

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
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.SuspendLayout
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(116, 63)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(820, 88)
        Me.UcCar.TabIndex = 2
        Me.UcCar.UCViewButtons = false
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
        Me.UcDriver.Size = New System.Drawing.Size(820, 104)
        Me.UcDriver.TabIndex = 3
        Me.UcDriver.UCViewButtons = false
        '
        'UcDriverImage
        '
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(14, 155)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverImage.Size = New System.Drawing.Size(103, 98)
        Me.UcDriverImage.TabIndex = 8
        '
        'UcCarImage
        '
        Me.UcCarImage.BackColor = System.Drawing.Color.White
        Me.UcCarImage.Location = New System.Drawing.Point(14, 67)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(103, 82)
        Me.UcCarImage.TabIndex = 7
        '
        'UCComputerMessageProducerTurnPrintRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcDriverImage)
        Me.Controls.Add(Me.UcCarImage)
        Me.Controls.Add(Me.UcDriver)
        Me.Controls.Add(Me.UcCar)
        Me.Name = "UCComputerMessageProducerTurnPrintRequest"
        Me.Size = New System.Drawing.Size(950, 271)
        Me.Controls.SetChildIndex(Me.UcCar, 0)
        Me.Controls.SetChildIndex(Me.UcDriver, 0)
        Me.Controls.SetChildIndex(Me.UcCarImage, 0)
        Me.Controls.SetChildIndex(Me.UcDriverImage, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcCar As R2CoreParkingSystem.UCCar
    Friend WithEvents UcDriver As R2CoreParkingSystem.UCDriver
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcCarImage As R2CoreParkingSystem.UCCarImage
End Class
