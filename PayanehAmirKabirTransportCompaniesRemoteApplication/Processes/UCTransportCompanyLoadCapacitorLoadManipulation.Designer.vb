Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTransportCompanyLoadCapacitorLoadManipulation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCTransportCompanyLoadCapacitorLoadManipulation))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UcButtonPermissionEnterExits = New R2CoreWinFormRemoteApplications.UCButton()
        Me.UcPersianTextBoxdDateElam = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcLabel12 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcNumbernEstelamId = New R2CoreWinFormRemoteApplications.UCNumber()
        Me.UcLabel2 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcButtonDelete = New R2CoreWinFormRemoteApplications.UCButton()
        Me.UcButtonRegister = New R2CoreWinFormRemoteApplications.UCButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UcLabel10 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel11 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcPersianTextBoxStrBarName = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcLabelSource = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcNumbernCarNumKol = New R2CoreWinFormRemoteApplications.UCNumber()
        Me.UcSearcherLoads = New PAKTCRemoteApplication.UCSearcherLoads()
        Me.UcLabel5 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcSearcherCities = New PAKTCRemoteApplication.UCSearcherCities()
        Me.UcSearcherCarTypes = New PAKTCRemoteApplication.UCSearcherCarTypes()
        Me.UcPersianTextBoxAddress = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcLabel7 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcPersianTextBoxStrDescription = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcLabel8 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel9 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcNumberStrPriceSug = New R2CoreWinFormRemoteApplications.UCNumber()
        Me.UcLabel4 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel6 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel3 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcucPermissionViewerCollection = New PAKTCRemoteApplication.UCUCPermissionViewerCollection()
        Me.PnlMain.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.Panel3)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(789, 182)
        Me.PnlMain.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 180)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.SeaShell
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UcButtonPermissionEnterExits)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxdDateElam)
        Me.Panel2.Controls.Add(Me.UcLabel12)
        Me.Panel2.Controls.Add(Me.UcNumbernEstelamId)
        Me.Panel2.Controls.Add(Me.UcLabel2)
        Me.Panel2.Controls.Add(Me.UcLabel1)
        Me.Panel2.Controls.Add(Me.UcButtonDelete)
        Me.Panel2.Controls.Add(Me.UcButtonRegister)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 175)
        Me.Panel2.TabIndex = 0
        '
        'UcButtonPermissionEnterExits
        '
        Me.UcButtonPermissionEnterExits.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonPermissionEnterExits.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonPermissionEnterExits.Location = New System.Drawing.Point(140, 3)
        Me.UcButtonPermissionEnterExits.Name = "UcButtonPermissionEnterExits"
        Me.UcButtonPermissionEnterExits.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonPermissionEnterExits.Size = New System.Drawing.Size(144, 34)
        Me.UcButtonPermissionEnterExits.TabIndex = 22
        Me.UcButtonPermissionEnterExits.UCBackColor = System.Drawing.Color.Honeydew
        Me.UcButtonPermissionEnterExits.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonPermissionEnterExits.UCEnable = true
        Me.UcButtonPermissionEnterExits.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonPermissionEnterExits.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonPermissionEnterExits.UCValue = "لیست مجوزهای صادرشده"
        '
        'UcPersianTextBoxdDateElam
        '
        Me.UcPersianTextBoxdDateElam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxdDateElam.Location = New System.Drawing.Point(301, 10)
        Me.UcPersianTextBoxdDateElam.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxdDateElam.Name = "UcPersianTextBoxdDateElam"
        Me.UcPersianTextBoxdDateElam.Size = New System.Drawing.Size(145, 24)
        Me.UcPersianTextBoxdDateElam.TabIndex = 21
        Me.UcPersianTextBoxdDateElam.UCBackColor = System.Drawing.Color.Gainsboro
        Me.UcPersianTextBoxdDateElam.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxdDateElam.UCEnable = false
        Me.UcPersianTextBoxdDateElam.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxdDateElam.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxdDateElam.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxdDateElam.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxdDateElam.UCValue = "1397/04/30 -  12:20:20"
        '
        'UcLabel12
        '
        Me.UcLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel12.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel12.Location = New System.Drawing.Point(447, 5)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel12.Size = New System.Drawing.Size(67, 32)
        Me.UcLabel12.TabIndex = 20
        Me.UcLabel12.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel12.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel12.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel12.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel12.UCValue = "زمان ثبت"
        '
        'UcNumbernEstelamId
        '
        Me.UcNumbernEstelamId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumbernEstelamId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernEstelamId.Location = New System.Drawing.Point(524, 10)
        Me.UcNumbernEstelamId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernEstelamId.Name = "UcNumbernEstelamId"
        Me.UcNumbernEstelamId.Size = New System.Drawing.Size(98, 25)
        Me.UcNumbernEstelamId.TabIndex = 3
        Me.UcNumbernEstelamId.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernEstelamId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernEstelamId.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumbernEstelamId.UCEnable = true
        Me.UcNumbernEstelamId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernEstelamId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernEstelamId.UCHandCursorIcon = true
        Me.UcNumbernEstelamId.UCReadOnly = true
        Me.UcNumbernEstelamId.UCValue = CType(0,Long)
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(623, 3)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(81, 32)
        Me.UcLabel2.TabIndex = 2
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "کدمخزن بار"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(733, 4)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(31, 32)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "بار"
        '
        'UcButtonDelete
        '
        Me.UcButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDelete.Location = New System.Drawing.Point(76, 3)
        Me.UcButtonDelete.Name = "UcButtonDelete"
        Me.UcButtonDelete.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDelete.Size = New System.Drawing.Size(64, 34)
        Me.UcButtonDelete.TabIndex = 5
        Me.UcButtonDelete.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonDelete.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDelete.UCEnable = true
        Me.UcButtonDelete.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDelete.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDelete.UCValue = "حذف بار"
        '
        'UcButtonRegister
        '
        Me.UcButtonRegister.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonRegister.Location = New System.Drawing.Point(9, 3)
        Me.UcButtonRegister.Name = "UcButtonRegister"
        Me.UcButtonRegister.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonRegister.Size = New System.Drawing.Size(67, 34)
        Me.UcButtonRegister.TabIndex = 4
        Me.UcButtonRegister.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonRegister.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonRegister.UCEnable = true
        Me.UcButtonRegister.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonRegister.UCForeColor = System.Drawing.Color.White
        Me.UcButtonRegister.UCValue = "ثبت بار"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcLabel10)
        Me.Panel4.Controls.Add(Me.UcLabel11)
        Me.Panel4.Controls.Add(Me.UcPersianTextBoxStrBarName)
        Me.Panel4.Controls.Add(Me.UcLabelSource)
        Me.Panel4.Controls.Add(Me.UcNumbernCarNumKol)
        Me.Panel4.Controls.Add(Me.UcSearcherLoads)
        Me.Panel4.Controls.Add(Me.UcLabel5)
        Me.Panel4.Controls.Add(Me.UcSearcherCities)
        Me.Panel4.Controls.Add(Me.UcSearcherCarTypes)
        Me.Panel4.Controls.Add(Me.UcPersianTextBoxAddress)
        Me.Panel4.Controls.Add(Me.UcLabel7)
        Me.Panel4.Controls.Add(Me.UcPersianTextBoxStrDescription)
        Me.Panel4.Controls.Add(Me.UcLabel8)
        Me.Panel4.Controls.Add(Me.UcLabel9)
        Me.Panel4.Controls.Add(Me.UcNumberStrPriceSug)
        Me.Panel4.Controls.Add(Me.UcLabel4)
        Me.Panel4.Controls.Add(Me.UcLabel6)
        Me.Panel4.Controls.Add(Me.UcLabel3)
        Me.Panel4.Location = New System.Drawing.Point(3, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(775, 148)
        Me.Panel4.TabIndex = 19
        '
        'UcLabel10
        '
        Me.UcLabel10.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel10.Location = New System.Drawing.Point(41, 82)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel10.Size = New System.Drawing.Size(46, 32)
        Me.UcLabel10.TabIndex = 15
        Me.UcLabel10.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel10.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel10.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel10.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel10.UCValue = "مبداء"
        '
        'UcLabel11
        '
        Me.UcLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel11.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel11.Location = New System.Drawing.Point(723, 110)
        Me.UcLabel11.Name = "UcLabel11"
        Me.UcLabel11.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel11.Size = New System.Drawing.Size(44, 32)
        Me.UcLabel11.TabIndex = 17
        Me.UcLabel11.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel11.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel11.UCForeColor = System.Drawing.Color.DarkViolet
        Me.UcLabel11.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel11.UCValue = "آدرس"
        '
        'UcPersianTextBoxStrBarName
        '
        Me.UcPersianTextBoxStrBarName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxStrBarName.Location = New System.Drawing.Point(560, 85)
        Me.UcPersianTextBoxStrBarName.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxStrBarName.Name = "UcPersianTextBoxStrBarName"
        Me.UcPersianTextBoxStrBarName.Size = New System.Drawing.Size(157, 24)
        Me.UcPersianTextBoxStrBarName.TabIndex = 10
        Me.UcPersianTextBoxStrBarName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrBarName.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxStrBarName.UCEnable = true
        Me.UcPersianTextBoxStrBarName.UCFont = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcPersianTextBoxStrBarName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrBarName.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxStrBarName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrBarName.UCValue = ""
        '
        'UcLabelSource
        '
        Me.UcLabelSource.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSource.Location = New System.Drawing.Point(6, 82)
        Me.UcLabelSource.Name = "UcLabelSource"
        Me.UcLabelSource.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSource.Size = New System.Drawing.Size(41, 32)
        Me.UcLabelSource.TabIndex = 16
        Me.UcLabelSource.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSource.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelSource.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelSource.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelSource.UCValue = "اصفهان"
        '
        'UcNumbernCarNumKol
        '
        Me.UcNumbernCarNumKol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumbernCarNumKol.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernCarNumKol.Location = New System.Drawing.Point(614, 57)
        Me.UcNumbernCarNumKol.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernCarNumKol.Name = "UcNumbernCarNumKol"
        Me.UcNumbernCarNumKol.Size = New System.Drawing.Size(103, 25)
        Me.UcNumbernCarNumKol.TabIndex = 6
        Me.UcNumbernCarNumKol.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernCarNumKol.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernCarNumKol.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumbernCarNumKol.UCEnable = true
        Me.UcNumbernCarNumKol.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernCarNumKol.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernCarNumKol.UCHandCursorIcon = false
        Me.UcNumbernCarNumKol.UCReadOnly = false
        Me.UcNumbernCarNumKol.UCValue = CType(0,Long)
        '
        'UcSearcherLoads
        '
        Me.UcSearcherLoads.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherLoads.BackColor = System.Drawing.Color.White
        Me.UcSearcherLoads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSearcherLoads.Location = New System.Drawing.Point(496, 18)
        Me.UcSearcherLoads.Name = "UcSearcherLoads"
        Me.UcSearcherLoads.Padding = New System.Windows.Forms.Padding(1)
        Me.UcSearcherLoads.Size = New System.Drawing.Size(222, 33)
        Me.UcSearcherLoads.TabIndex = 0
        Me.UcSearcherLoads.UCBackColor = System.Drawing.Color.DeepSkyBlue
        Me.UcSearcherLoads.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherLoads.UCFontSearch = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherLoads.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoads.UCIcon = CType(resources.GetObject("UcSearcherLoads.UCIcon"),System.Drawing.Image)
        Me.UcSearcherLoads.UCMaximizeHight = CType(120,Long)
        Me.UcSearcherLoads.UCMinimizeHight = CType(33,Long)
        Me.UcSearcherLoads.UCMode = R2CoreWinFormRemoteApplications.UCSearcher.UCModeType.DropDown
        Me.UcSearcherLoads.UCSelectedItem = Nothing
        '
        'UcLabel5
        '
        Me.UcLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(719, 53)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(41, 32)
        Me.UcLabel5.TabIndex = 5
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel5.UCValue = "تعداد"
        '
        'UcSearcherCities
        '
        Me.UcSearcherCities.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherCities.BackColor = System.Drawing.Color.White
        Me.UcSearcherCities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSearcherCities.Location = New System.Drawing.Point(175, 18)
        Me.UcSearcherCities.Name = "UcSearcherCities"
        Me.UcSearcherCities.Padding = New System.Windows.Forms.Padding(1)
        Me.UcSearcherCities.Size = New System.Drawing.Size(276, 33)
        Me.UcSearcherCities.TabIndex = 4
        Me.UcSearcherCities.UCBackColor = System.Drawing.Color.Red
        Me.UcSearcherCities.UCFontList = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcSearcherCities.UCFontSearch = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherCities.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherCities.UCIcon = CType(resources.GetObject("UcSearcherCities.UCIcon"),System.Drawing.Image)
        Me.UcSearcherCities.UCMaximizeHight = CType(120,Long)
        Me.UcSearcherCities.UCMinimizeHight = CType(33,Long)
        Me.UcSearcherCities.UCMode = R2CoreWinFormRemoteApplications.UCSearcher.UCModeType.DropDown
        Me.UcSearcherCities.UCSelectedItem = Nothing
        '
        'UcSearcherCarTypes
        '
        Me.UcSearcherCarTypes.BackColor = System.Drawing.Color.White
        Me.UcSearcherCarTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSearcherCarTypes.Location = New System.Drawing.Point(6, 18)
        Me.UcSearcherCarTypes.Name = "UcSearcherCarTypes"
        Me.UcSearcherCarTypes.Padding = New System.Windows.Forms.Padding(1)
        Me.UcSearcherCarTypes.Size = New System.Drawing.Size(131, 33)
        Me.UcSearcherCarTypes.TabIndex = 8
        Me.UcSearcherCarTypes.UCBackColor = System.Drawing.Color.LimeGreen
        Me.UcSearcherCarTypes.UCFontList = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcSearcherCarTypes.UCFontSearch = New System.Drawing.Font("B Homa", 8.25!)
        Me.UcSearcherCarTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherCarTypes.UCIcon = CType(resources.GetObject("UcSearcherCarTypes.UCIcon"),System.Drawing.Image)
        Me.UcSearcherCarTypes.UCMaximizeHight = CType(120,Long)
        Me.UcSearcherCarTypes.UCMinimizeHight = CType(33,Long)
        Me.UcSearcherCarTypes.UCMode = R2CoreWinFormRemoteApplications.UCSearcher.UCModeType.DropDown
        Me.UcSearcherCarTypes.UCSelectedItem = Nothing
        '
        'UcPersianTextBoxAddress
        '
        Me.UcPersianTextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxAddress.Location = New System.Drawing.Point(6, 115)
        Me.UcPersianTextBoxAddress.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxAddress.Name = "UcPersianTextBoxAddress"
        Me.UcPersianTextBoxAddress.Size = New System.Drawing.Size(711, 24)
        Me.UcPersianTextBoxAddress.TabIndex = 18
        Me.UcPersianTextBoxAddress.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAddress.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxAddress.UCEnable = true
        Me.UcPersianTextBoxAddress.UCFont = New System.Drawing.Font("IRMehr", 8.25!)
        Me.UcPersianTextBoxAddress.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAddress.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxAddress.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAddress.UCValue = ""
        '
        'UcLabel7
        '
        Me.UcLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel7.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.Location = New System.Drawing.Point(718, 83)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel7.Size = New System.Drawing.Size(49, 32)
        Me.UcLabel7.TabIndex = 9
        Me.UcLabel7.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel7.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabel7.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel7.UCValue = "گیرنده"
        '
        'UcPersianTextBoxStrDescription
        '
        Me.UcPersianTextBoxStrDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxStrDescription.Location = New System.Drawing.Point(256, 56)
        Me.UcPersianTextBoxStrDescription.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxStrDescription.Name = "UcPersianTextBoxStrDescription"
        Me.UcPersianTextBoxStrDescription.Size = New System.Drawing.Size(291, 24)
        Me.UcPersianTextBoxStrDescription.TabIndex = 14
        Me.UcPersianTextBoxStrDescription.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrDescription.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxStrDescription.UCEnable = true
        Me.UcPersianTextBoxStrDescription.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxStrDescription.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrDescription.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxStrDescription.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrDescription.UCValue = ""
        '
        'UcLabel8
        '
        Me.UcLabel8.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel8.Location = New System.Drawing.Point(107, 50)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel8.Size = New System.Drawing.Size(30, 32)
        Me.UcLabel8.TabIndex = 11
        Me.UcLabel8.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel8.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel8.UCForeColor = System.Drawing.Color.ForestGreen
        Me.UcLabel8.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel8.UCValue = "نرخ"
        '
        'UcLabel9
        '
        Me.UcLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel9.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel9.Location = New System.Drawing.Point(552, 51)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel9.Size = New System.Drawing.Size(55, 32)
        Me.UcLabel9.TabIndex = 13
        Me.UcLabel9.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel9.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel9.UCForeColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel9.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel9.UCValue = "توضیحات"
        '
        'UcNumberStrPriceSug
        '
        Me.UcNumberStrPriceSug.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberStrPriceSug.Location = New System.Drawing.Point(4, 57)
        Me.UcNumberStrPriceSug.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberStrPriceSug.Name = "UcNumberStrPriceSug"
        Me.UcNumberStrPriceSug.Size = New System.Drawing.Size(103, 25)
        Me.UcNumberStrPriceSug.TabIndex = 12
        Me.UcNumberStrPriceSug.UCBackColor = System.Drawing.Color.White
        Me.UcNumberStrPriceSug.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberStrPriceSug.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumberStrPriceSug.UCEnable = true
        Me.UcNumberStrPriceSug.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberStrPriceSug.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberStrPriceSug.UCHandCursorIcon = false
        Me.UcNumberStrPriceSug.UCReadOnly = false
        Me.UcNumberStrPriceSug.UCValue = CType(0,Long)
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(449, 18)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(40, 32)
        Me.UcLabel4.TabIndex = 3
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel4.UCValue = "مقصد"
        '
        'UcLabel6
        '
        Me.UcLabel6.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.Location = New System.Drawing.Point(136, 19)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel6.Size = New System.Drawing.Size(36, 32)
        Me.UcLabel6.TabIndex = 7
        Me.UcLabel6.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel6.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel6.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel6.UCValue = "بارگیر"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(718, 19)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(54, 32)
        Me.UcLabel3.TabIndex = 2
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel3.UCValue = "عنوان بار"
        '
        'UcucPermissionViewerCollection
        '
        Me.UcucPermissionViewerCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucPermissionViewerCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucPermissionViewerCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucPermissionViewerCollection.Location = New System.Drawing.Point(10, 10)
        Me.UcucPermissionViewerCollection.Name = "UcucPermissionViewerCollection"
        Me.UcucPermissionViewerCollection.Size = New System.Drawing.Size(789, 182)
        Me.UcucPermissionViewerCollection.TabIndex = 1
        '
        'UCTransportCompanyLoadCapacitorLoadManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.UcucPermissionViewerCollection)
        Me.Name = "UCTransportCompanyLoadCapacitorLoadManipulation"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(809, 202)
        Me.PnlMain.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UcButtonDelete As UCButton
    Friend WithEvents UcButtonRegister As UCButton
    Friend WithEvents UcNumbernEstelamId As UCNumber
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcSearcherLoads As UCSearcherLoads
    Friend WithEvents UcLabelSource As UCLabel
    Friend WithEvents UcLabel10 As UCLabel
    Friend WithEvents UcPersianTextBoxStrDescription As UCPersianTextBox
    Friend WithEvents UcLabel9 As UCLabel
    Friend WithEvents UcNumberStrPriceSug As UCNumber
    Friend WithEvents UcLabel8 As UCLabel
    Friend WithEvents UcPersianTextBoxStrBarName As UCPersianTextBox
    Friend WithEvents UcLabel7 As UCLabel
    Friend WithEvents UcSearcherCarTypes As UCSearcherCarTypes
    Friend WithEvents UcLabel6 As UCLabel
    Friend WithEvents UcNumbernCarNumKol As UCNumber
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcSearcherCities As UCSearcherCities
    Friend WithEvents UcPersianTextBoxAddress As UCPersianTextBox
    Friend WithEvents UcLabel11 As UCLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UcPersianTextBoxdDateElam As UCPersianTextBox
    Friend WithEvents UcLabel12 As UCLabel
    Friend WithEvents UcButtonPermissionEnterExits As UCButton
    Friend WithEvents UcucPermissionViewerCollection As UCUCPermissionViewerCollection
End Class
