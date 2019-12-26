Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCComputerMessageTurnPrint
    Inherits UCComputerMessage


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
        Me.UcButtonNobatPrint = New R2CoreGUI.UCButton()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.SuspendLayout()
        '
        'UcButtonNobatPrint
        '
        Me.UcButtonNobatPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonNobatPrint.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonNobatPrint.Location = New System.Drawing.Point(16, 18)
        Me.UcButtonNobatPrint.Name = "UcButtonNobatPrint"
        Me.UcButtonNobatPrint.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonNobatPrint.Size = New System.Drawing.Size(71, 94)
        Me.UcButtonNobatPrint.TabIndex = 2
        Me.UcButtonNobatPrint.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonNobatPrint.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonNobatPrint.UCEnable = True
        Me.UcButtonNobatPrint.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonNobatPrint.UCForeColor = System.Drawing.Color.White
        Me.UcButtonNobatPrint.UCValue = "چاپ نوبت"
        '
        'UcDriverImage
        '
        Me.UcDriverImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(92, 17)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverImage.Size = New System.Drawing.Size(83, 95)
        Me.UcDriverImage.TabIndex = 3
        '
        'UCComputerMessageNobatPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcDriverImage)
        Me.Controls.Add(Me.UcButtonNobatPrint)
        Me.Name = "UCComputerMessageNobatPrint"
        Me.Controls.SetChildIndex(Me.UcButtonNobatPrint, 0)
        Me.Controls.SetChildIndex(Me.UcDriverImage, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcButtonNobatPrint As UCButton
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
End Class
