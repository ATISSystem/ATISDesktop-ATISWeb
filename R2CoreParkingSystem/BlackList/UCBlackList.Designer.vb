Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBlackList
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
        Me.UcButtonPardakht = New R2CoreGUI.UCButton()
        Me.UcButtonChangeFlagA = New R2CoreGUI.UCButton()
        Me.PnlSubMain = New System.Windows.Forms.Panel()
        Me.UcMoneynAmount = New R2CoreGUI.UCMoney()
        Me.UcLabelFlagA = New R2CoreGUI.UCLabel()
        Me.UcLabelUser = New R2CoreGUI.UCLabel()
        Me.UcLabelStrDate = New R2CoreGUI.UCLabel()
        Me.UcLabelStrDesc = New R2CoreGUI.UCLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.PnlSubMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcButtonPardakht)
        Me.PnlMain.Controls.Add(Me.UcButtonChangeFlagA)
        Me.PnlMain.Controls.Add(Me.PnlSubMain)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(460, 87)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonPardakht
        '
        Me.UcButtonPardakht.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonPardakht.Location = New System.Drawing.Point(100, 1)
        Me.UcButtonPardakht.Name = "UcButtonPardakht"
        Me.UcButtonPardakht.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonPardakht.Size = New System.Drawing.Size(58, 37)
        Me.UcButtonPardakht.TabIndex = 23
        Me.UcButtonPardakht.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonPardakht.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonPardakht.UCEnable = true
        Me.UcButtonPardakht.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonPardakht.UCForeColor = System.Drawing.Color.White
        Me.UcButtonPardakht.UCValue = "پرداخت"
        '
        'UcButtonChangeFlagA
        '
        Me.UcButtonChangeFlagA.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonChangeFlagA.Location = New System.Drawing.Point(13, 1)
        Me.UcButtonChangeFlagA.Name = "UcButtonChangeFlagA"
        Me.UcButtonChangeFlagA.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonChangeFlagA.Size = New System.Drawing.Size(86, 37)
        Me.UcButtonChangeFlagA.TabIndex = 16
        Me.UcButtonChangeFlagA.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonChangeFlagA.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonChangeFlagA.UCEnable = true
        Me.UcButtonChangeFlagA.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonChangeFlagA.UCForeColor = System.Drawing.Color.White
        Me.UcButtonChangeFlagA.UCValue = "تغییروضعیت"
        '
        'PnlSubMain
        '
        Me.PnlSubMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSubMain.BackColor = System.Drawing.Color.Black
        Me.PnlSubMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSubMain.Controls.Add(Me.UcMoneynAmount)
        Me.PnlSubMain.Controls.Add(Me.UcLabelFlagA)
        Me.PnlSubMain.Controls.Add(Me.UcLabelUser)
        Me.PnlSubMain.Controls.Add(Me.UcLabelStrDate)
        Me.PnlSubMain.Controls.Add(Me.UcLabelStrDesc)
        Me.PnlSubMain.Controls.Add(Me.Label5)
        Me.PnlSubMain.Controls.Add(Me.Label4)
        Me.PnlSubMain.Controls.Add(Me.Label3)
        Me.PnlSubMain.Controls.Add(Me.Label2)
        Me.PnlSubMain.Location = New System.Drawing.Point(2, 17)
        Me.PnlSubMain.Name = "PnlSubMain"
        Me.PnlSubMain.Size = New System.Drawing.Size(452, 65)
        Me.PnlSubMain.TabIndex = 22
        '
        'UcMoneynAmount
        '
        Me.UcMoneynAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneynAmount.Location = New System.Drawing.Point(251, 41)
        Me.UcMoneynAmount.Name = "UcMoneynAmount"
        Me.UcMoneynAmount.Size = New System.Drawing.Size(92, 19)
        Me.UcMoneynAmount.TabIndex = 23
        '
        'UcLabelFlagA
        '
        Me.UcLabelFlagA.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelFlagA.Location = New System.Drawing.Point(7, 36)
        Me.UcLabelFlagA.Name = "UcLabelFlagA"
        Me.UcLabelFlagA.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelFlagA.Size = New System.Drawing.Size(74, 23)
        Me.UcLabelFlagA.TabIndex = 22
        Me.UcLabelFlagA.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelFlagA.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelFlagA.UCForeColor = System.Drawing.Color.White
        Me.UcLabelFlagA.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelFlagA.UCValue = "غیرفعال"
        '
        'UcLabelUser
        '
        Me.UcLabelUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelUser.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelUser.Location = New System.Drawing.Point(87, 36)
        Me.UcLabelUser.Name = "UcLabelUser"
        Me.UcLabelUser.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelUser.Size = New System.Drawing.Size(164, 23)
        Me.UcLabelUser.TabIndex = 15
        Me.UcLabelUser.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelUser.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelUser.UCForeColor = System.Drawing.Color.White
        Me.UcLabelUser.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelUser.UCValue = "مرتضی شاهمرادی"
        '
        'UcLabelStrDate
        '
        Me.UcLabelStrDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrDate.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDate.Location = New System.Drawing.Point(349, 36)
        Me.UcLabelStrDate.Name = "UcLabelStrDate"
        Me.UcLabelStrDate.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrDate.Size = New System.Drawing.Size(98, 23)
        Me.UcLabelStrDate.TabIndex = 13
        Me.UcLabelStrDate.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDate.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrDate.UCForeColor = System.Drawing.Color.White
        Me.UcLabelStrDate.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrDate.UCValue = "1396/10/26"
        '
        'UcLabelStrDesc
        '
        Me.UcLabelStrDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrDesc.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcLabelStrDesc.Location = New System.Drawing.Point(161, -4)
        Me.UcLabelStrDesc.Name = "UcLabelStrDesc"
        Me.UcLabelStrDesc.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrDesc.Size = New System.Drawing.Size(286, 27)
        Me.UcLabelStrDesc.TabIndex = 18
        Me.UcLabelStrDesc.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDesc.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrDesc.UCForeColor = System.Drawing.Color.White
        Me.UcLabelStrDesc.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelStrDesc.UCValue = "روغن ریزی جنب حمام پایانه 30*30 40*40"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(25, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "وضعیت"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(87, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "کاربر"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(278, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "مبلغ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(356, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "تاریخ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCBlackList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCBlackList"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(480, 107)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlSubMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcButtonPardakht As R2CoreGUI.UCButton
    Friend WithEvents UcButtonChangeFlagA As R2CoreGUI.UCButton
    Friend WithEvents PnlSubMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabelFlagA As R2CoreGUI.UCLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UcLabelStrDesc As R2CoreGUI.UCLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UcLabelUser As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelStrDate As R2CoreGUI.UCLabel
    Friend WithEvents UcMoneynAmount As UCMoney
End Class
