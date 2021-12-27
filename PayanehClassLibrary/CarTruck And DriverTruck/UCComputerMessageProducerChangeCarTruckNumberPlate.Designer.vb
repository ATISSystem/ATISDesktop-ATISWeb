Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageProducerChangeCarTruckNumberPlate
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
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcPersianTextBoxNewTruck = New R2CoreGUI.UCPersianTextBox()
        Me.SuspendLayout()
        '
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(16, 64)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(815, 153)
        Me.UcCarTruck.TabIndex = 1
        Me.UcCarTruck.UCViewButtons = False
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(623, 217)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(197, 32)
        Me.UcLabel1.TabIndex = 5
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "پلاک ناوگان جدید را وارد کنید : "
        '
        'UcPersianTextBoxNewTruck
        '
        Me.UcPersianTextBoxNewTruck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxNewTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxNewTruck.Location = New System.Drawing.Point(420, 222)
        Me.UcPersianTextBoxNewTruck.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxNewTruck.Name = "UcPersianTextBoxNewTruck"
        Me.UcPersianTextBoxNewTruck.Size = New System.Drawing.Size(202, 27)
        Me.UcPersianTextBoxNewTruck.TabIndex = 6
        Me.UcPersianTextBoxNewTruck.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxNewTruck.UCBorder = True
        Me.UcPersianTextBoxNewTruck.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxNewTruck.UCEnable = True
        Me.UcPersianTextBoxNewTruck.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxNewTruck.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxNewTruck.UCMultiLine = False
        Me.UcPersianTextBoxNewTruck.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxNewTruck.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxNewTruck.UCValue = "rfwrwer"
        '
        'UCComputerMessageProducerChangeCarTruckNumberPlate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcPersianTextBoxNewTruck)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcCarTruck)
        Me.Name = "UCComputerMessageProducerChangeCarTruckNumberPlate"
        Me.Size = New System.Drawing.Size(845, 268)
        Me.Controls.SetChildIndex(Me.UcCarTruck, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.UcPersianTextBoxNewTruck, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcPersianTextBoxNewTruck As UCPersianTextBox
End Class
