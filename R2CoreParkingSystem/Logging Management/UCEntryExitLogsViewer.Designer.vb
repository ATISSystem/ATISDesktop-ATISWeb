
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCEntryExitLogsViewer
    Inherits UCLog

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCEntryExitLogsViewer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxUserName = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabel7 = New R2CoreGUI.UCLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxTime = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxDateShamsi = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabel9 = New R2CoreGUI.UCLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxEntryExitTitle = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabel12 = New R2CoreGUI.UCLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxLPString = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabel14 = New R2CoreGUI.UCLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxMessage = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabel16 = New R2CoreGUI.UCLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UcLabel18 = New R2CoreGUI.UCLabel()
        Me.UcPersianTextBoxTrafficCard = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcLabelSharh = New R2CoreGUI.UCLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxUserName)
        Me.Panel1.Controls.Add(Me.UcLabel7)
        Me.Panel1.Location = New System.Drawing.Point(632, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 27)
        Me.Panel1.TabIndex = 12
        '
        'UcPersianTextBoxUserName
        '
        Me.UcPersianTextBoxUserName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxUserName.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxUserName.Location = New System.Drawing.Point(4, 2)
        Me.UcPersianTextBoxUserName.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxUserName.Name = "UcPersianTextBoxUserName"
        Me.UcPersianTextBoxUserName.Size = New System.Drawing.Size(174, 23)
        Me.UcPersianTextBoxUserName.TabIndex = 23
        Me.UcPersianTextBoxUserName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxUserName.UCBorder = True
        Me.UcPersianTextBoxUserName.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxUserName.UCEnable = False
        Me.UcPersianTextBoxUserName.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxUserName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxUserName.UCMultiLine = True
        Me.UcPersianTextBoxUserName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxUserName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxUserName.UCValue = "مرتضی شاهمرادی"
        '
        'UcLabel7
        '
        Me.UcLabel7._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel7._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel7.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel7.ForeColor = System.Drawing.Color.Black
        Me.UcLabel7.Location = New System.Drawing.Point(184, 0)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel7.Size = New System.Drawing.Size(64, 27)
        Me.UcLabel7.TabIndex = 5
        Me.UcLabel7.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel7.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel7.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel7.UCValue = "کاربر : "
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxTime)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxDateShamsi)
        Me.Panel2.Controls.Add(Me.UcLabel9)
        Me.Panel2.Location = New System.Drawing.Point(632, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 28)
        Me.Panel2.TabIndex = 13
        '
        'UcPersianTextBoxTime
        '
        Me.UcPersianTextBoxTime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTime.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTime.Location = New System.Drawing.Point(109, -1)
        Me.UcPersianTextBoxTime.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTime.Name = "UcPersianTextBoxTime"
        Me.UcPersianTextBoxTime.Size = New System.Drawing.Size(70, 25)
        Me.UcPersianTextBoxTime.TabIndex = 22
        Me.UcPersianTextBoxTime.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTime.UCBorder = True
        Me.UcPersianTextBoxTime.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTime.UCEnable = False
        Me.UcPersianTextBoxTime.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTime.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTime.UCMultiLine = True
        Me.UcPersianTextBoxTime.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTime.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTime.UCValue = "25:45:52"
        '
        'UcPersianTextBoxDateShamsi
        '
        Me.UcPersianTextBoxDateShamsi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxDateShamsi.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxDateShamsi.Location = New System.Drawing.Point(3, 0)
        Me.UcPersianTextBoxDateShamsi.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxDateShamsi.Name = "UcPersianTextBoxDateShamsi"
        Me.UcPersianTextBoxDateShamsi.Size = New System.Drawing.Size(102, 25)
        Me.UcPersianTextBoxDateShamsi.TabIndex = 21
        Me.UcPersianTextBoxDateShamsi.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDateShamsi.UCBorder = True
        Me.UcPersianTextBoxDateShamsi.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxDateShamsi.UCEnable = False
        Me.UcPersianTextBoxDateShamsi.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxDateShamsi.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDateShamsi.UCMultiLine = True
        Me.UcPersianTextBoxDateShamsi.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxDateShamsi.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxDateShamsi.UCValue = "1400/10/28"
        '
        'UcLabel9
        '
        Me.UcLabel9._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel9._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel9.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel9.ForeColor = System.Drawing.Color.Black
        Me.UcLabel9.Location = New System.Drawing.Point(185, 0)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel9.Size = New System.Drawing.Size(62, 28)
        Me.UcLabel9.TabIndex = 6
        Me.UcLabel9.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel9.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel9.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel9.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel9.UCValue = " زمان: "
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.UcPersianTextBoxEntryExitTitle)
        Me.Panel3.Controls.Add(Me.UcLabel12)
        Me.Panel3.Location = New System.Drawing.Point(632, 152)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 31)
        Me.Panel3.TabIndex = 17
        '
        'UcPersianTextBoxEntryExitTitle
        '
        Me.UcPersianTextBoxEntryExitTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxEntryExitTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxEntryExitTitle.Location = New System.Drawing.Point(4, 6)
        Me.UcPersianTextBoxEntryExitTitle.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxEntryExitTitle.Name = "UcPersianTextBoxEntryExitTitle"
        Me.UcPersianTextBoxEntryExitTitle.Size = New System.Drawing.Size(175, 23)
        Me.UcPersianTextBoxEntryExitTitle.TabIndex = 26
        Me.UcPersianTextBoxEntryExitTitle.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxEntryExitTitle.UCBorder = True
        Me.UcPersianTextBoxEntryExitTitle.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxEntryExitTitle.UCEnable = False
        Me.UcPersianTextBoxEntryExitTitle.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxEntryExitTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxEntryExitTitle.UCMultiLine = True
        Me.UcPersianTextBoxEntryExitTitle.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxEntryExitTitle.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxEntryExitTitle.UCValue = "ورود"
        '
        'UcLabel12
        '
        Me.UcLabel12._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel12._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel12.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel12.ForeColor = System.Drawing.Color.Black
        Me.UcLabel12.Location = New System.Drawing.Point(184, 0)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel12.Size = New System.Drawing.Size(65, 31)
        Me.UcLabel12.TabIndex = 6
        Me.UcLabel12.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel12.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel12.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel12.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel12.UCValue = "ورود/خروج :"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.UcPersianTextBoxLPString)
        Me.Panel4.Controls.Add(Me.UcLabel14)
        Me.Panel4.Location = New System.Drawing.Point(632, 127)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(249, 31)
        Me.Panel4.TabIndex = 16
        '
        'UcPersianTextBoxLPString
        '
        Me.UcPersianTextBoxLPString.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxLPString.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxLPString.Location = New System.Drawing.Point(3, 6)
        Me.UcPersianTextBoxLPString.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxLPString.Name = "UcPersianTextBoxLPString"
        Me.UcPersianTextBoxLPString.Size = New System.Drawing.Size(175, 23)
        Me.UcPersianTextBoxLPString.TabIndex = 25
        Me.UcPersianTextBoxLPString.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxLPString.UCBorder = True
        Me.UcPersianTextBoxLPString.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxLPString.UCEnable = False
        Me.UcPersianTextBoxLPString.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxLPString.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxLPString.UCMultiLine = True
        Me.UcPersianTextBoxLPString.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxLPString.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxLPString.UCValue = "752ع52-13"
        '
        'UcLabel14
        '
        Me.UcLabel14._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel14._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel14.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel14.ForeColor = System.Drawing.Color.Black
        Me.UcLabel14.Location = New System.Drawing.Point(185, 0)
        Me.UcLabel14.Name = "UcLabel14"
        Me.UcLabel14.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel14.Size = New System.Drawing.Size(64, 31)
        Me.UcLabel14.TabIndex = 6
        Me.UcLabel14.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel14.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel14.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel14.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel14.UCValue = "پلاک: :"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.UcPersianTextBoxMessage)
        Me.Panel5.Controls.Add(Me.UcLabel16)
        Me.Panel5.Location = New System.Drawing.Point(3, 38)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(623, 152)
        Me.Panel5.TabIndex = 15
        '
        'UcPersianTextBoxMessage
        '
        Me.UcPersianTextBoxMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxMessage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxMessage.Location = New System.Drawing.Point(3, 1)
        Me.UcPersianTextBoxMessage.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxMessage.Name = "UcPersianTextBoxMessage"
        Me.UcPersianTextBoxMessage.Size = New System.Drawing.Size(549, 147)
        Me.UcPersianTextBoxMessage.TabIndex = 20
        Me.UcPersianTextBoxMessage.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxMessage.UCBorder = True
        Me.UcPersianTextBoxMessage.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxMessage.UCEnable = True
        Me.UcPersianTextBoxMessage.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxMessage.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxMessage.UCMultiLine = True
        Me.UcPersianTextBoxMessage.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxMessage.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxMessage.UCValue = resources.GetString("UcPersianTextBoxMessage.UCValue")
        '
        'UcLabel16
        '
        Me.UcLabel16._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel16._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel16.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel16.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel16.ForeColor = System.Drawing.Color.Black
        Me.UcLabel16.Location = New System.Drawing.Point(547, 0)
        Me.UcLabel16.Name = "UcLabel16"
        Me.UcLabel16.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel16.Size = New System.Drawing.Size(76, 152)
        Me.UcLabel16.TabIndex = 6
        Me.UcLabel16.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel16.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel16.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel16.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel16.UCValue = "پیام سیستم: "
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.UcLabel18)
        Me.Panel6.Controls.Add(Me.UcPersianTextBoxTrafficCard)
        Me.Panel6.Location = New System.Drawing.Point(632, 101)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(249, 31)
        Me.Panel6.TabIndex = 14
        '
        'UcLabel18
        '
        Me.UcLabel18._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel18._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel18.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel18.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel18.ForeColor = System.Drawing.Color.Black
        Me.UcLabel18.Location = New System.Drawing.Point(184, 0)
        Me.UcLabel18.Name = "UcLabel18"
        Me.UcLabel18.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel18.Size = New System.Drawing.Size(65, 31)
        Me.UcLabel18.TabIndex = 6
        Me.UcLabel18.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel18.UCFont = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel18.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel18.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel18.UCValue = "کارت تردد :"
        '
        'UcPersianTextBoxTrafficCard
        '
        Me.UcPersianTextBoxTrafficCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTrafficCard.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTrafficCard.Location = New System.Drawing.Point(3, 3)
        Me.UcPersianTextBoxTrafficCard.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTrafficCard.Name = "UcPersianTextBoxTrafficCard"
        Me.UcPersianTextBoxTrafficCard.Size = New System.Drawing.Size(175, 23)
        Me.UcPersianTextBoxTrafficCard.TabIndex = 24
        Me.UcPersianTextBoxTrafficCard.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTrafficCard.UCBorder = True
        Me.UcPersianTextBoxTrafficCard.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTrafficCard.UCEnable = False
        Me.UcPersianTextBoxTrafficCard.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTrafficCard.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTrafficCard.UCMultiLine = True
        Me.UcPersianTextBoxTrafficCard.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTrafficCard.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTrafficCard.UCValue = "1243123cdf"
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Lavender
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabelSharh)
        Me.PnlMain.Controls.Add(Me.Panel6)
        Me.PnlMain.Controls.Add(Me.Panel2)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Controls.Add(Me.Panel4)
        Me.PnlMain.Controls.Add(Me.Panel3)
        Me.PnlMain.Controls.Add(Me.Panel5)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(882, 195)
        Me.PnlMain.TabIndex = 19
        '
        'UcLabelSharh
        '
        Me.UcLabelSharh._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSharh._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSharh.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelSharh.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelSharh.ForeColor = System.Drawing.Color.Black
        Me.UcLabelSharh.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelSharh.Name = "UcLabelSharh"
        Me.UcLabelSharh.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSharh.Size = New System.Drawing.Size(880, 34)
        Me.UcLabelSharh.TabIndex = 18
        Me.UcLabelSharh.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSharh.UCFont = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSharh.UCForeColor = System.Drawing.Color.White
        Me.UcLabelSharh.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelSharh.UCValue = " نسیت مشنسیت مشتی مشنی شمنتی شی شسی"
        '
        'UCEntryExitLogsViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCEntryExitLogsViewer"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(888, 201)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents UcLabel7 As UCLabel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents UcLabel9 As UCLabel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents UcLabel12 As UCLabel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents UcLabel14 As UCLabel
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents UcLabel16 As UCLabel
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents UcLabel18 As UCLabel
    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelSharh As UCLabel
    Friend WithEvents UcPersianTextBoxMessage As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxUserName As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxTime As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxDateShamsi As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxEntryExitTitle As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxLPString As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxTrafficCard As UCPersianTextBox
End Class
