Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageChangeDriverTruck
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
        Me.UcButtonChangeDriverTruck = New R2CoreGUI.UCButton()
        Me.SuspendLayout
        '
        'UcButtonChangeDriverTruck
        '
        Me.UcButtonChangeDriverTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonChangeDriverTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonChangeDriverTruck.Location = New System.Drawing.Point(18, 16)
        Me.UcButtonChangeDriverTruck.Name = "UcButtonChangeDriverTruck"
        Me.UcButtonChangeDriverTruck.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonChangeDriverTruck.Size = New System.Drawing.Size(90, 94)
        Me.UcButtonChangeDriverTruck.TabIndex = 2
        Me.UcButtonChangeDriverTruck.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonChangeDriverTruck.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonChangeDriverTruck.UCEnable = true
        Me.UcButtonChangeDriverTruck.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonChangeDriverTruck.UCForeColor = System.Drawing.Color.White
        Me.UcButtonChangeDriverTruck.UCValue = "تغییر نام راننده ناوگان باری"
        '
        'UCComputerMessageChangeDriverTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcButtonChangeDriverTruck)
        Me.Name = "UCComputerMessageChangeDriverTruck"
        Me.Controls.SetChildIndex(Me.UcButtonChangeDriverTruck, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcButtonChangeDriverTruck As UCButton
End Class
