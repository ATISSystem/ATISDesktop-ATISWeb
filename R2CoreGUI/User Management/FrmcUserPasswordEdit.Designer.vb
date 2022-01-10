<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcUserPasswordEdit
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcButton = New R2CoreGUI.UCButton()
        Me.UcTextBoxNewUserPassword = New R2CoreGUI.UCTextBox()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1500)
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcButton)
        Me.PnlMain.Controls.Add(Me.UcTextBoxNewUserPassword)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Location = New System.Drawing.Point(5, 50)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(995, 512)
        Me.PnlMain.TabIndex = 205
        '
        'UcButton
        '
        Me.UcButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(416, 256)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButton.Size = New System.Drawing.Size(160, 50)
        Me.UcButton.TabIndex = 204
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = true
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "تغییر رمز عبور"
        '
        'UcTextBoxNewUserPassword
        '
        Me.UcTextBoxNewUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTextBoxNewUserPassword.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxNewUserPassword.Location = New System.Drawing.Point(372, 219)
        Me.UcTextBoxNewUserPassword.Name = "UcTextBoxNewUserPassword"
        Me.UcTextBoxNewUserPassword.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxNewUserPassword.Size = New System.Drawing.Size(248, 31)
        Me.UcTextBoxNewUserPassword.TabIndex = 203
        Me.UcTextBoxNewUserPassword.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxNewUserPassword.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxNewUserPassword.UCBorder = True
        Me.UcTextBoxNewUserPassword.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxNewUserPassword.UCBorderCornerRedius = 5
        Me.UcTextBoxNewUserPassword.UCEnable = True
        Me.UcTextBoxNewUserPassword.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxNewUserPassword.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxNewUserPassword.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxNewUserPassword.UCMaxCharacterReached = CType(50, Short)
        Me.UcTextBoxNewUserPassword.UCMaxNumber = CType(99999, Long)
        Me.UcTextBoxNewUserPassword.UCMultiLine = False
        Me.UcTextBoxNewUserPassword.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxNewUserPassword.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UcTextBoxNewUserPassword.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxNewUserPassword.UCValue = ""
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(463, 190)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(67, 32)
        Me.UcLabel2.TabIndex = 202
        Me.UcLabel2.UCBackColor = System.Drawing.Color.White
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "رمز جدید"
        '
        'FrmcUserPasswordEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMain)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcUserPasswordEdit"
        Me.Text = "FrmcUserPasswordEdit"
        Me.Controls.SetChildIndex(Me.PnlMain, 0)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcButton As UCButton
    Friend WithEvents UcTextBoxNewUserPassword As UCTextBox
    Friend WithEvents UcLabel2 As UCLabel
End Class
