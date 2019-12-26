<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageProducerGeneralMessage
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
        Me.UcPersianTextBox = New R2CoreGUI.UCPersianTextBox()
        Me.SuspendLayout
        '
        'UcPersianTextBox
        '
        Me.UcPersianTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox.Location = New System.Drawing.Point(19, 65)
        Me.UcPersianTextBox.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBox.Name = "UcPersianTextBox"
        Me.UcPersianTextBox.Size = New System.Drawing.Size(345, 30)
        Me.UcPersianTextBox.TabIndex = 1
        Me.UcPersianTextBox.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox.UCEnable = true
        Me.UcPersianTextBox.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBox.UCForeColor = System.Drawing.Color.LightGray
        Me.UcPersianTextBox.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox.UCValue = "متن خود را برای ارسال در این قسمت وارد نمایید"
        '
        'UCComputerMessageProducerGeneralMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcPersianTextBox)
        Me.Name = "UCComputerMessageProducerGeneralMessage"
        Me.Size = New System.Drawing.Size(390, 116)
        Me.UCTitle = CType(1,Long)
        Me.Controls.SetChildIndex(Me.UcPersianTextBox, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcPersianTextBox As UCPersianTextBox
End Class
