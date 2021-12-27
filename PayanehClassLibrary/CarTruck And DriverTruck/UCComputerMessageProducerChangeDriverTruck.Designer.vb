Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageProducerChangeDriverTruck
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
        Me.UcCarTruck = New PayanehClassLibrary.UCCarTruck()
        Me.UcTextBoxTruckDriverNationalCode = New R2CoreGUI.UCTextBox()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.SuspendLayout()
        '
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(16, 62)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(849, 153)
        Me.UcCarTruck.TabIndex = 1
        Me.UcCarTruck.UCViewButtons = False
        '
        'UcTextBoxTruckDriverNationalCode
        '
        Me.UcTextBoxTruckDriverNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxTruckDriverNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxTruckDriverNationalCode.Location = New System.Drawing.Point(520, 220)
        Me.UcTextBoxTruckDriverNationalCode.Name = "UcTextBoxTruckDriverNationalCode"
        Me.UcTextBoxTruckDriverNationalCode.Size = New System.Drawing.Size(135, 28)
        Me.UcTextBoxTruckDriverNationalCode.TabIndex = 2
        Me.UcTextBoxTruckDriverNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxTruckDriverNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxTruckDriverNationalCode.UCBorder = True
        Me.UcTextBoxTruckDriverNationalCode.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxTruckDriverNationalCode.UCEnable = True
        Me.UcTextBoxTruckDriverNationalCode.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxTruckDriverNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxTruckDriverNationalCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxTruckDriverNationalCode.UCMaxCharacterReached = CType(50, Short)
        Me.UcTextBoxTruckDriverNationalCode.UCMaxNumber = CType(99999, Long)
        Me.UcTextBoxTruckDriverNationalCode.UCMultiLine = False
        Me.UcTextBoxTruckDriverNationalCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxTruckDriverNationalCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxTruckDriverNationalCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxTruckDriverNationalCode.UCValue = ""
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(661, 217)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(197, 32)
        Me.UcLabel1.TabIndex = 3
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "کد ملی راننده جدید را وارد کنید : "
        '
        'UCComputerMessageProducerChangeDriverTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcTextBoxTruckDriverNationalCode)
        Me.Controls.Add(Me.UcCarTruck)
        Me.Name = "UCComputerMessageProducerChangeDriverTruck"
        Me.Size = New System.Drawing.Size(879, 269)
        Me.Controls.SetChildIndex(Me.UcCarTruck, 0)
        Me.Controls.SetChildIndex(Me.UcTextBoxTruckDriverNationalCode, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents UcTextBoxTruckDriverNationalCode As UCTextBox
    Friend WithEvents UcLabel1 As UCLabel
End Class
