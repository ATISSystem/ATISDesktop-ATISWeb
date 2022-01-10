Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserChargeSavabeghCollection
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
        Me.UcTimeEntry2 = New R2CoreGUI.UCTimeEntry()
        Me.UcTimeEntry1 = New R2CoreGUI.UCTimeEntry()
        Me.UcPersianShamsiDate2 = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcPersianShamsiDate1 = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcButton = New R2CoreGUI.UCButton()
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.UcLabelDaramad = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcTimeEntry2)
        Me.PnlMain.Controls.Add(Me.UcTimeEntry1)
        Me.PnlMain.Controls.Add(Me.UcPersianShamsiDate2)
        Me.PnlMain.Controls.Add(Me.UcPersianShamsiDate1)
        Me.PnlMain.Controls.Add(Me.UcButton)
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.Label25)
        Me.PnlMain.Controls.Add(Me.Label23)
        Me.PnlMain.Controls.Add(Me.Label24)
        Me.PnlMain.Controls.Add(Me.Label26)
        Me.PnlMain.Controls.Add(Me.UcLabelDaramad)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(621, 517)
        Me.PnlMain.TabIndex = 0
        '
        'UcTimeEntry2
        '
        Me.UcTimeEntry2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTimeEntry2.BackColor = System.Drawing.Color.Transparent
        Me.UcTimeEntry2.Location = New System.Drawing.Point(223, 80)
        Me.UcTimeEntry2.Name = "UcTimeEntry2"
        Me.UcTimeEntry2.Size = New System.Drawing.Size(136, 23)
        Me.UcTimeEntry2.TabIndex = 737
        Me.UcTimeEntry2.UCBackColor = System.Drawing.Color.White
        Me.UcTimeEntry2.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTimeEntry2.UCEnable = True
        Me.UcTimeEntry2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTimeEntry2.UCUserTime = "23:59:59"
        '
        'UcTimeEntry1
        '
        Me.UcTimeEntry1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTimeEntry1.BackColor = System.Drawing.Color.Transparent
        Me.UcTimeEntry1.Location = New System.Drawing.Point(422, 80)
        Me.UcTimeEntry1.Name = "UcTimeEntry1"
        Me.UcTimeEntry1.Size = New System.Drawing.Size(134, 23)
        Me.UcTimeEntry1.TabIndex = 736
        Me.UcTimeEntry1.UCBackColor = System.Drawing.Color.White
        Me.UcTimeEntry1.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTimeEntry1.UCEnable = True
        Me.UcTimeEntry1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTimeEntry1.UCUserTime = "00:00:00"
        '
        'UcPersianShamsiDate2
        '
        Me.UcPersianShamsiDate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianShamsiDate2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate2.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate2.Location = New System.Drawing.Point(223, 55)
        Me.UcPersianShamsiDate2.Name = "UcPersianShamsiDate2"
        Me.UcPersianShamsiDate2.Size = New System.Drawing.Size(136, 23)
        Me.UcPersianShamsiDate2.TabIndex = 735
        Me.UcPersianShamsiDate2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'UcPersianShamsiDate1
        '
        Me.UcPersianShamsiDate1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianShamsiDate1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate1.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate1.Location = New System.Drawing.Point(422, 55)
        Me.UcPersianShamsiDate1.Name = "UcPersianShamsiDate1"
        Me.UcPersianShamsiDate1.Size = New System.Drawing.Size(134, 23)
        Me.UcPersianShamsiDate1.TabIndex = 734
        Me.UcPersianShamsiDate1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'UcButton
        '
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(8, 56)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButton.Size = New System.Drawing.Size(160, 43)
        Me.UcButton.TabIndex = 730
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = True
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "نمایش درآمد"
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = True
        Me.PnlUCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUCs.Location = New System.Drawing.Point(3, 135)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(615, 379)
        Me.PnlUCs.TabIndex = 2
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(621, 49)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "عملکرد و سوابق شارژ کاربر"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label25.Font = New System.Drawing.Font("B Zar", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(367, 58)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(43, 21)
        Me.Label25.TabIndex = 717
        Me.Label25.Text = "تاتاریخ:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label23.Font = New System.Drawing.Font("B Zar", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(367, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label23.Size = New System.Drawing.Size(49, 21)
        Me.Label23.TabIndex = 719
        Me.Label23.Text = "تا ساعت:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label24.Font = New System.Drawing.Font("B Zar", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(562, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(49, 21)
        Me.Label24.TabIndex = 718
        Me.Label24.Text = "ازساعت:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label26.Font = New System.Drawing.Font("B Zar", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(562, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(46, 21)
        Me.Label26.TabIndex = 716
        Me.Label26.Text = "ازتاریخ:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelDaramad
        '
        Me.UcLabelDaramad._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelDaramad._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelDaramad.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDaramad.Location = New System.Drawing.Point(8, 97)
        Me.UcLabelDaramad.Name = "UcLabelDaramad"
        Me.UcLabelDaramad.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDaramad.Size = New System.Drawing.Size(160, 32)
        Me.UcLabelDaramad.TabIndex = 731
        Me.UcLabelDaramad.UCBackColor = System.Drawing.Color.White
        Me.UcLabelDaramad.UCFont = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelDaramad.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDaramad.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDaramad.UCValue = "0"
        '
        'UCUserChargeSavabeghCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUserChargeSavabeghCollection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(627, 523)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlUCs As System.Windows.Forms.Panel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelDaramad As R2CoreGUI.UCLabel
    Friend WithEvents UcButton As R2CoreGUI.UCButton
    Friend WithEvents UcTimeEntry2 As UCTimeEntry
    Friend WithEvents UcTimeEntry1 As UCTimeEntry
    Friend WithEvents UcPersianShamsiDate2 As UCPersianShamsiDate
    Friend WithEvents UcPersianShamsiDate1 As UCPersianShamsiDate
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents Label26 As Windows.Forms.Label
End Class
