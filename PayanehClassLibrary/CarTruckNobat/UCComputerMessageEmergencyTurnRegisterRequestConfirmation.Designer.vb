Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageEmergencyTurnRegisterRequestConfirmation
    Inherits UCComputerMessage

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
        Me.UcButtonConfirmation = New R2CoreGUI.UCButton()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.SuspendLayout
        '
        'UcButtonConfirmation
        '
        Me.UcButtonConfirmation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonConfirmation.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonConfirmation.Location = New System.Drawing.Point(18, 16)
        Me.UcButtonConfirmation.Name = "UcButtonConfirmation"
        Me.UcButtonConfirmation.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonConfirmation.Size = New System.Drawing.Size(71, 106)
        Me.UcButtonConfirmation.TabIndex = 1
        Me.UcButtonConfirmation.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonConfirmation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonConfirmation.UCEnable = true
        Me.UcButtonConfirmation.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonConfirmation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonConfirmation.UCValue = "تایید"
        '
        'UcDriverImage
        '
        Me.UcDriverImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(94, 16)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverImage.Size = New System.Drawing.Size(83, 107)
        Me.UcDriverImage.TabIndex = 4
        '
        'UCComputerMessageEmergencyTurnRegisterRequestConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcDriverImage)
        Me.Controls.Add(Me.UcButtonConfirmation)
        Me.Name = "UCComputerMessageEmergencyTurnRegisterRequestConfirmation"
        Me.Size = New System.Drawing.Size(850, 143)
        Me.Controls.SetChildIndex(Me.UcButtonConfirmation, 0)
        Me.Controls.SetChildIndex(Me.UcDriverImage, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcButtonConfirmation As UCButton
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
End Class
