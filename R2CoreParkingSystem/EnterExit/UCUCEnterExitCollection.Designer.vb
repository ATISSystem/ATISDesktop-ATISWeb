Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCEnterExitCollection
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
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcCarEnterExitStatus = New R2CoreParkingSystem.UCCarEnterExitStatus()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcCarImage)
        Me.PnlMain.Controls.Add(Me.UcDriver)
        Me.PnlMain.Controls.Add(Me.UcCar)
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcCarEnterExitStatus)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1049, 495)
        Me.PnlMain.TabIndex = 0
        '
        'UcCarImage
        '
        Me.UcCarImage.BackColor = System.Drawing.Color.White
        Me.UcCarImage.Location = New System.Drawing.Point(3, 62)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(198, 183)
        Me.UcCarImage.TabIndex = 14
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Enabled = false
        Me.UcDriver.Location = New System.Drawing.Point(207, 148)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(834, 100)
        Me.UcDriver.TabIndex = 13
        Me.UcDriver.UCViewButtons = false
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(207, 59)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(834, 88)
        Me.UcCar.TabIndex = 12
        Me.UcCar.UCViewButtons = false
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = true
        Me.PnlUCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUCs.Location = New System.Drawing.Point(3, 292)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(1043, 200)
        Me.PnlUCs.TabIndex = 11
        '
        'UcLabelTop
        '
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(1049, 53)
        Me.UcLabelTop.TabIndex = 10
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "سوابق تردد خودرو"
        '
        'UcCarEnterExitStatus
        '
        Me.UcCarEnterExitStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarEnterExitStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcCarEnterExitStatus.Location = New System.Drawing.Point(351, 238)
        Me.UcCarEnterExitStatus.Name = "UcCarEnterExitStatus"
        Me.UcCarEnterExitStatus.Padding = New System.Windows.Forms.Padding(10)
        Me.UcCarEnterExitStatus.Size = New System.Drawing.Size(347, 60)
        Me.UcCarEnterExitStatus.TabIndex = 15
        '
        'UCUCEnterExitCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCEnterExitCollection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(1055, 501)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlUCs As System.Windows.Forms.Panel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcCarImage As UCCarImage
    Friend WithEvents UcDriver As UCDriver
    Friend WithEvents UcCar As UCCar
    Friend WithEvents UcCarEnterExitStatus As UCCarEnterExitStatus
End Class
