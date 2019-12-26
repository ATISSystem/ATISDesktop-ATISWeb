Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageChangeCarTruckNumberPlate
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
        Me.UcButtonChangeCarTruckNumberPlate = New R2CoreGUI.UCButton()
        Me.SuspendLayout
        '
        'UcButtonChangeCarTruckNumberPlate
        '
        Me.UcButtonChangeCarTruckNumberPlate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonChangeCarTruckNumberPlate.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonChangeCarTruckNumberPlate.Location = New System.Drawing.Point(16, 18)
        Me.UcButtonChangeCarTruckNumberPlate.Name = "UcButtonChangeCarTruckNumberPlate"
        Me.UcButtonChangeCarTruckNumberPlate.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonChangeCarTruckNumberPlate.Size = New System.Drawing.Size(90, 94)
        Me.UcButtonChangeCarTruckNumberPlate.TabIndex = 7
        Me.UcButtonChangeCarTruckNumberPlate.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonChangeCarTruckNumberPlate.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonChangeCarTruckNumberPlate.UCEnable = true
        Me.UcButtonChangeCarTruckNumberPlate.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonChangeCarTruckNumberPlate.UCForeColor = System.Drawing.Color.White
        Me.UcButtonChangeCarTruckNumberPlate.UCValue = "تغییر پلاک ناوگان باری"
        '
        'UCComputerMessageChangeCarTruckNumberPlate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcButtonChangeCarTruckNumberPlate)
        Me.Name = "UCComputerMessageChangeCarTruckNumberPlate"
        Me.Controls.SetChildIndex(Me.UcButtonChangeCarTruckNumberPlate, 0)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents UcButtonChangeCarTruckNumberPlate As UCButton
End Class
