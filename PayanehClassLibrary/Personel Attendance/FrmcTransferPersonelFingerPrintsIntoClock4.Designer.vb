Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTransferPersonelFingerPrintsIntoClock4
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.PnlTransferPersonelFingerPrintsIntoClock4 = New System.Windows.Forms.Panel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcPersianTextBoxSal = New R2CoreGUI.UCPersianTextBox()
        Me.UcButton = New R2CoreGUI.UCButton()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcPersianMonths = New R2CoreGUI.UCPersianMonths()
        Me.PnlTransferPersonelFingerPrintsIntoClock4.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlTransferPersonelFingerPrintsIntoClock4
        '
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Controls.Add(Me.UcLabel2)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Controls.Add(Me.UcPersianTextBoxSal)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Controls.Add(Me.UcButton)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Controls.Add(Me.UcLabel1)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Controls.Add(Me.UcPersianMonths)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Location = New System.Drawing.Point(5, 50)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Name = "PnlTransferPersonelFingerPrintsIntoClock4"
        Me.PnlTransferPersonelFingerPrintsIntoClock4.Size = New System.Drawing.Size(995, 512)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.TabIndex = 201
        '
        'UcLabel2
        '
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(406, 30)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(178, 32)
        Me.UcLabel2.TabIndex = 4
        Me.UcLabel2.UCBackColor = System.Drawing.Color.White
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.DarkRed
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel2.UCValue = "سال مورد نظر را وارد نمایید :"
        '
        'UcPersianTextBoxSal
        '
        Me.UcPersianTextBoxSal.Location = New System.Drawing.Point(304, 32)
        Me.UcPersianTextBoxSal.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxSal.Name = "UcPersianTextBoxSal"
        Me.UcPersianTextBoxSal.Size = New System.Drawing.Size(99, 30)
        Me.UcPersianTextBoxSal.TabIndex = 3
        Me.UcPersianTextBoxSal.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSal.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxSal.UCEnable = true
        Me.UcPersianTextBoxSal.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxSal.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSal.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSal.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSal.UCValue = ""
        '
        'UcButton
        '
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(301, 462)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButton.Size = New System.Drawing.Size(118, 41)
        Me.UcButton.TabIndex = 2
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = true
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "انتقال"
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(365, 59)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(219, 32)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.DarkRed
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "ماه مورد نظر را انتخاب نمایید :"
        '
        'UcPersianMonths
        '
        Me.UcPersianMonths.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianMonths.Location = New System.Drawing.Point(301, 97)
        Me.UcPersianMonths.Name = "UcPersianMonths"
        Me.UcPersianMonths.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersianMonths.Size = New System.Drawing.Size(283, 359)
        Me.UcPersianMonths.TabIndex = 0
        '
        'FrmcTransferPersonelFingerPrintsIntoClock4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTransferPersonelFingerPrintsIntoClock4)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTransferPersonelFingerPrintsIntoClock4"
        Me.Text = "FrmcTransferPersonelFingerPrintsIntoClock4"
        Me.Controls.SetChildIndex(Me.PnlTransferPersonelFingerPrintsIntoClock4, 0)
        Me.PnlTransferPersonelFingerPrintsIntoClock4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlTransferPersonelFingerPrintsIntoClock4 As System.Windows.Forms.Panel
    Friend WithEvents UcButton As UCButton
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcPersianMonths As UCPersianMonths
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcPersianTextBoxSal As UCPersianTextBox
End Class
