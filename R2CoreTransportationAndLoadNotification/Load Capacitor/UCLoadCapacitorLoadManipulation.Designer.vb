Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCLoadCapacitorLoadManipulation
    Inherits UCLoadCapacitorLoad

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCLoadCapacitorLoadManipulation))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UcButtonLoadCapacitorLoadSedimentation = New R2CoreGUI.UCButton()
        Me.UcPersianTextBoxLoadPermissionStatus = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite = New R2CoreGUI.UCPersianTextBox()
        Me.UcButtonLoadCapacitorAccounting = New R2CoreGUI.UCButton()
        Me.UcButtonNew = New R2CoreGUI.UCButton()
        Me.UcButtonLoadPermissions = New R2CoreGUI.UCButton()
        Me.UcNumbernCarNum = New R2CoreGUI.UCNumber()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcButtonLoadCapacitorLoadFreeLining = New R2CoreGUI.UCButton()
        Me.UcButtonLoadCapacitorLoadCancelling = New R2CoreGUI.UCButton()
        Me.UcButtonLoadCapacitorLoadDeleting = New R2CoreGUI.UCButton()
        Me.UcButtonLoadCapacitorLoadRegisteringEditing = New R2CoreGUI.UCButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UcNumbernEstelamId = New R2CoreGUI.UCNumber()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlHolder = New System.Windows.Forms.Panel()
        Me.UcSearcherTransportCompanies = New R2CoreTransportationAndLoadNotification.UCSearcherTransportCompanies()
        Me.UcSearcherLoaderTypes = New R2CoreTransportationAndLoadNotification.UCSearcherLoaderTypes()
        Me.UcSearcherLoadSources = New R2CoreTransportationAndLoadNotification.UCSearcherLoadSources()
        Me.UcSearcherLoadTargets = New R2CoreTransportationAndLoadNotification.UCSearcherLoadTargets()
        Me.UcSearcherGoods = New R2CoreTransportationAndLoadNotification.UCSearcherGoods()
        Me.UcPersianTextBoxStrDescription = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxAddress = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxStrBarname = New R2CoreGUI.UCPersianTextBox()
        Me.UcNumberTransportPrice = New R2CoreGUI.UCNumber()
        Me.UcNumbernCarNumKol = New R2CoreGUI.UCNumber()
        Me.UcLabelnCarNumKol = New R2CoreGUI.UCLabel()
        Me.UcLabelNoeBargir1 = New R2CoreTransportationAndLoadNotification.UCLabelNoeBargir()
        Me.UcLabelSherkatHamloNaghl1 = New R2CoreTransportationAndLoadNotification.UCLabelSherkatHamloNaghl()
        Me.UcLabelMaghsadeBar1 = New R2CoreTransportationAndLoadNotification.UCLabelMaghsadeBar()
        Me.UcLabelTransportPrice = New R2CoreGUI.UCLabel()
        Me.UcLabelMabdaeBar1 = New R2CoreTransportationAndLoadNotification.UCLabelMabdaeBar()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabelNoeBar1 = New R2CoreTransportationAndLoadNotification.UCLabelNoeBar()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcucLoadCapacitorAccountingCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadCapacitorAccountingCollection()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlHolder.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Controls.Add(Me.UcucLoadCapacitorAccountingCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1037, 178)
        Me.PnlMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(1037, 178)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaShell
        Me.Panel2.Controls.Add(Me.UcButtonLoadCapacitorLoadSedimentation)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxLoadPermissionStatus)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite)
        Me.Panel2.Controls.Add(Me.UcButtonLoadCapacitorAccounting)
        Me.Panel2.Controls.Add(Me.UcButtonNew)
        Me.Panel2.Controls.Add(Me.UcButtonLoadPermissions)
        Me.Panel2.Controls.Add(Me.UcNumbernCarNum)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.UcButtonLoadCapacitorLoadFreeLining)
        Me.Panel2.Controls.Add(Me.UcButtonLoadCapacitorLoadCancelling)
        Me.Panel2.Controls.Add(Me.UcButtonLoadCapacitorLoadDeleting)
        Me.Panel2.Controls.Add(Me.UcButtonLoadCapacitorLoadRegisteringEditing)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.UcNumbernEstelamId)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PnlHolder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1031, 172)
        Me.Panel2.TabIndex = 0
        '
        'UcButtonLoadCapacitorLoadSedimentation
        '
        Me.UcButtonLoadCapacitorLoadSedimentation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonLoadCapacitorLoadSedimentation.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadCapacitorLoadSedimentation.Location = New System.Drawing.Point(422, 138)
        Me.UcButtonLoadCapacitorLoadSedimentation.Name = "UcButtonLoadCapacitorLoadSedimentation"
        Me.UcButtonLoadCapacitorLoadSedimentation.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadCapacitorLoadSedimentation.Size = New System.Drawing.Size(83, 30)
        Me.UcButtonLoadCapacitorLoadSedimentation.TabIndex = 16
        Me.UcButtonLoadCapacitorLoadSedimentation.UCBackColor = System.Drawing.Color.ForestGreen
        Me.UcButtonLoadCapacitorLoadSedimentation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadCapacitorLoadSedimentation.UCEnable = True
        Me.UcButtonLoadCapacitorLoadSedimentation.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadCapacitorLoadSedimentation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadCapacitorLoadSedimentation.UCValue = "رسوب بار"
        '
        'UcPersianTextBoxLoadPermissionStatus
        '
        Me.UcPersianTextBoxLoadPermissionStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxLoadPermissionStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxLoadPermissionStatus.Location = New System.Drawing.Point(515, 10)
        Me.UcPersianTextBoxLoadPermissionStatus.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxLoadPermissionStatus.Name = "UcPersianTextBoxLoadPermissionStatus"
        Me.UcPersianTextBoxLoadPermissionStatus.Size = New System.Drawing.Size(85, 25)
        Me.UcPersianTextBoxLoadPermissionStatus.TabIndex = 11
        Me.UcPersianTextBoxLoadPermissionStatus.UCBackColor = System.Drawing.Color.Gainsboro
        Me.UcPersianTextBoxLoadPermissionStatus.UCBorder = True
        Me.UcPersianTextBoxLoadPermissionStatus.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxLoadPermissionStatus.UCEnable = False
        Me.UcPersianTextBoxLoadPermissionStatus.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxLoadPermissionStatus.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxLoadPermissionStatus.UCMultiLine = False
        Me.UcPersianTextBoxLoadPermissionStatus.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxLoadPermissionStatus.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxLoadPermissionStatus.UCValue = "کنسل شده"
        '
        'UcPersianTextBoxLoadCapacitorLoadDateTimeComposite
        '
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.Location = New System.Drawing.Point(665, 10)
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.Name = "UcPersianTextBoxLoadCapacitorLoadDateTimeComposite"
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.Size = New System.Drawing.Size(129, 25)
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.TabIndex = 5
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCBackColor = System.Drawing.Color.Gainsboro
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCBorder = True
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCEnable = False
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCMultiLine = False
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxLoadCapacitorLoadDateTimeComposite.UCValue = ""
        '
        'UcButtonLoadCapacitorAccounting
        '
        Me.UcButtonLoadCapacitorAccounting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonLoadCapacitorAccounting.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadCapacitorAccounting.Location = New System.Drawing.Point(315, 138)
        Me.UcButtonLoadCapacitorAccounting.Name = "UcButtonLoadCapacitorAccounting"
        Me.UcButtonLoadCapacitorAccounting.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadCapacitorAccounting.Size = New System.Drawing.Size(107, 30)
        Me.UcButtonLoadCapacitorAccounting.TabIndex = 15
        Me.UcButtonLoadCapacitorAccounting.UCBackColor = System.Drawing.Color.DarkGoldenrod
        Me.UcButtonLoadCapacitorAccounting.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadCapacitorAccounting.UCEnable = True
        Me.UcButtonLoadCapacitorAccounting.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadCapacitorAccounting.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadCapacitorAccounting.UCValue = "نمایش اکانتینگ بار"
        '
        'UcButtonNew
        '
        Me.UcButtonNew.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonNew.Location = New System.Drawing.Point(11, 7)
        Me.UcButtonNew.Name = "UcButtonNew"
        Me.UcButtonNew.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonNew.Size = New System.Drawing.Size(52, 30)
        Me.UcButtonNew.TabIndex = 14
        Me.UcButtonNew.UCBackColor = System.Drawing.Color.MidnightBlue
        Me.UcButtonNew.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonNew.UCEnable = True
        Me.UcButtonNew.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonNew.UCForeColor = System.Drawing.Color.White
        Me.UcButtonNew.UCValue = "جدید"
        '
        'UcButtonLoadPermissions
        '
        Me.UcButtonLoadPermissions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonLoadPermissions.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadPermissions.Location = New System.Drawing.Point(11, 138)
        Me.UcButtonLoadPermissions.Name = "UcButtonLoadPermissions"
        Me.UcButtonLoadPermissions.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadPermissions.Size = New System.Drawing.Size(138, 30)
        Me.UcButtonLoadPermissions.TabIndex = 13
        Me.UcButtonLoadPermissions.UCBackColor = System.Drawing.Color.RoyalBlue
        Me.UcButtonLoadPermissions.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadPermissions.UCEnable = True
        Me.UcButtonLoadPermissions.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadPermissions.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadPermissions.UCValue = "مجوزهای بارگیری صادر شده"
        '
        'UcNumbernCarNum
        '
        Me.UcNumbernCarNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumbernCarNum.Font = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernCarNum.Location = New System.Drawing.Point(421, 15)
        Me.UcNumbernCarNum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernCarNum.Name = "UcNumbernCarNum"
        Me.UcNumbernCarNum.Size = New System.Drawing.Size(39, 19)
        Me.UcNumbernCarNum.TabIndex = 12
        Me.UcNumbernCarNum.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumbernCarNum.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumbernCarNum.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernCarNum.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernCarNum.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumbernCarNum.UCBorder = True
        Me.UcNumbernCarNum.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumbernCarNum.UCEnable = False
        Me.UcNumbernCarNum.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernCarNum.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernCarNum.UCMultiLine = False
        Me.UcNumbernCarNum.UCValue = CType(0, Long)
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(464, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "باقیمانده"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(605, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "وضعیت بار"
        '
        'UcButtonLoadCapacitorLoadFreeLining
        '
        Me.UcButtonLoadCapacitorLoadFreeLining.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonLoadCapacitorLoadFreeLining.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadCapacitorLoadFreeLining.Location = New System.Drawing.Point(148, 138)
        Me.UcButtonLoadCapacitorLoadFreeLining.Name = "UcButtonLoadCapacitorLoadFreeLining"
        Me.UcButtonLoadCapacitorLoadFreeLining.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadCapacitorLoadFreeLining.Size = New System.Drawing.Size(89, 30)
        Me.UcButtonLoadCapacitorLoadFreeLining.TabIndex = 9
        Me.UcButtonLoadCapacitorLoadFreeLining.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcButtonLoadCapacitorLoadFreeLining.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadCapacitorLoadFreeLining.UCEnable = True
        Me.UcButtonLoadCapacitorLoadFreeLining.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadCapacitorLoadFreeLining.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadCapacitorLoadFreeLining.UCValue = "بار خط آزاد"
        '
        'UcButtonLoadCapacitorLoadCancelling
        '
        Me.UcButtonLoadCapacitorLoadCancelling.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonLoadCapacitorLoadCancelling.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadCapacitorLoadCancelling.Location = New System.Drawing.Point(236, 138)
        Me.UcButtonLoadCapacitorLoadCancelling.Name = "UcButtonLoadCapacitorLoadCancelling"
        Me.UcButtonLoadCapacitorLoadCancelling.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadCapacitorLoadCancelling.Size = New System.Drawing.Size(79, 30)
        Me.UcButtonLoadCapacitorLoadCancelling.TabIndex = 8
        Me.UcButtonLoadCapacitorLoadCancelling.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonLoadCapacitorLoadCancelling.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadCapacitorLoadCancelling.UCEnable = True
        Me.UcButtonLoadCapacitorLoadCancelling.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadCapacitorLoadCancelling.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadCapacitorLoadCancelling.UCValue = "کنسلی بار"
        '
        'UcButtonLoadCapacitorLoadDeleting
        '
        Me.UcButtonLoadCapacitorLoadDeleting.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadCapacitorLoadDeleting.Location = New System.Drawing.Point(195, 7)
        Me.UcButtonLoadCapacitorLoadDeleting.Name = "UcButtonLoadCapacitorLoadDeleting"
        Me.UcButtonLoadCapacitorLoadDeleting.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadCapacitorLoadDeleting.Size = New System.Drawing.Size(54, 30)
        Me.UcButtonLoadCapacitorLoadDeleting.TabIndex = 7
        Me.UcButtonLoadCapacitorLoadDeleting.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonLoadCapacitorLoadDeleting.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadCapacitorLoadDeleting.UCEnable = True
        Me.UcButtonLoadCapacitorLoadDeleting.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadCapacitorLoadDeleting.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadCapacitorLoadDeleting.UCValue = "حذف بار"
        '
        'UcButtonLoadCapacitorLoadRegisteringEditing
        '
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.Location = New System.Drawing.Point(63, 7)
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.Name = "UcButtonLoadCapacitorLoadRegisteringEditing"
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.Size = New System.Drawing.Size(132, 30)
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.TabIndex = 6
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.UCBackColor = System.Drawing.Color.ForestGreen
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.UCEnable = True
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadCapacitorLoadRegisteringEditing.UCValue = "ثبت و ویرایش اطلاعات بار"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(798, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "زمان ثبت"
        '
        'UcNumbernEstelamId
        '
        Me.UcNumbernEstelamId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumbernEstelamId.Font = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernEstelamId.Location = New System.Drawing.Point(853, 15)
        Me.UcNumbernEstelamId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernEstelamId.Name = "UcNumbernEstelamId"
        Me.UcNumbernEstelamId.Size = New System.Drawing.Size(65, 19)
        Me.UcNumbernEstelamId.TabIndex = 3
        Me.UcNumbernEstelamId.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumbernEstelamId.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumbernEstelamId.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernEstelamId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernEstelamId.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumbernEstelamId.UCBorder = True
        Me.UcNumbernEstelamId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumbernEstelamId.UCEnable = False
        Me.UcNumbernEstelamId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernEstelamId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernEstelamId.UCMultiLine = False
        Me.UcNumbernEstelamId.UCValue = CType(0, Long)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(923, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "کد مخزن بار"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(991, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "بار"
        '
        'PnlHolder
        '
        Me.PnlHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHolder.Controls.Add(Me.Panel3)
        Me.PnlHolder.Controls.Add(Me.UcSearcherTransportCompanies)
        Me.PnlHolder.Controls.Add(Me.UcSearcherLoadSources)
        Me.PnlHolder.Controls.Add(Me.UcSearcherLoadTargets)
        Me.PnlHolder.Controls.Add(Me.UcSearcherGoods)
        Me.PnlHolder.Controls.Add(Me.UcPersianTextBoxStrDescription)
        Me.PnlHolder.Controls.Add(Me.UcPersianTextBoxAddress)
        Me.PnlHolder.Controls.Add(Me.UcPersianTextBoxStrBarname)
        Me.PnlHolder.Controls.Add(Me.UcNumberTransportPrice)
        Me.PnlHolder.Controls.Add(Me.UcNumbernCarNumKol)
        Me.PnlHolder.Controls.Add(Me.UcLabelnCarNumKol)
        Me.PnlHolder.Controls.Add(Me.UcLabelSherkatHamloNaghl1)
        Me.PnlHolder.Controls.Add(Me.UcLabelMaghsadeBar1)
        Me.PnlHolder.Controls.Add(Me.UcLabelTransportPrice)
        Me.PnlHolder.Controls.Add(Me.UcLabelMabdaeBar1)
        Me.PnlHolder.Controls.Add(Me.UcLabel3)
        Me.PnlHolder.Controls.Add(Me.UcLabel2)
        Me.PnlHolder.Controls.Add(Me.UcLabelNoeBar1)
        Me.PnlHolder.Controls.Add(Me.UcLabel1)
        Me.PnlHolder.Location = New System.Drawing.Point(3, 24)
        Me.PnlHolder.Name = "PnlHolder"
        Me.PnlHolder.Size = New System.Drawing.Size(1025, 130)
        Me.PnlHolder.TabIndex = 0
        '
        'UcSearcherTransportCompanies
        '
        Me.UcSearcherTransportCompanies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherTransportCompanies.Location = New System.Drawing.Point(729, 14)
        Me.UcSearcherTransportCompanies.Name = "UcSearcherTransportCompanies"
        Me.UcSearcherTransportCompanies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherTransportCompanies.Size = New System.Drawing.Size(197, 31)
        Me.UcSearcherTransportCompanies.TabIndex = 1
        Me.UcSearcherTransportCompanies.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherTransportCompanies.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherTransportCompanies.UCIcon = CType(resources.GetObject("UcSearcherTransportCompanies.UCIcon"), System.Drawing.Image)
        Me.UcSearcherTransportCompanies.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherTransportCompanies.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherTransportCompanies.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherTransportCompanies.UCShowDomainIcon = False
        '
        'UcSearcherLoaderTypes
        '
        Me.UcSearcherLoaderTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherLoaderTypes.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoaderTypes.Location = New System.Drawing.Point(0, 0)
        Me.UcSearcherLoaderTypes.Name = "UcSearcherLoaderTypes"
        Me.UcSearcherLoaderTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoaderTypes.Size = New System.Drawing.Size(191, 31)
        Me.UcSearcherLoaderTypes.TabIndex = 7
        Me.UcSearcherLoaderTypes.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoaderTypes.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoaderTypes.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoaderTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoaderTypes.UCIcon = Nothing
        Me.UcSearcherLoaderTypes.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoaderTypes.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoaderTypes.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherLoaderTypes.UCShowDomainIcon = False
        '
        'UcSearcherLoadSources
        '
        Me.UcSearcherLoadSources.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherLoadSources.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoadSources.Enabled = False
        Me.UcSearcherLoadSources.Location = New System.Drawing.Point(811, 48)
        Me.UcSearcherLoadSources.Name = "UcSearcherLoadSources"
        Me.UcSearcherLoadSources.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoadSources.Size = New System.Drawing.Size(115, 31)
        Me.UcSearcherLoadSources.TabIndex = 5
        Me.UcSearcherLoadSources.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoadSources.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadSources.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadSources.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoadSources.UCIcon = Nothing
        Me.UcSearcherLoadSources.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoadSources.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoadSources.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherLoadSources.UCShowDomainIcon = False
        '
        'UcSearcherLoadTargets
        '
        Me.UcSearcherLoadTargets.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoadTargets.Location = New System.Drawing.Point(262, 14)
        Me.UcSearcherLoadTargets.Name = "UcSearcherLoadTargets"
        Me.UcSearcherLoadTargets.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoadTargets.Size = New System.Drawing.Size(185, 31)
        Me.UcSearcherLoadTargets.TabIndex = 3
        Me.UcSearcherLoadTargets.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoadTargets.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadTargets.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadTargets.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoadTargets.UCIcon = Nothing
        Me.UcSearcherLoadTargets.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoadTargets.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoadTargets.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherLoadTargets.UCShowDomainIcon = False
        '
        'UcSearcherGoods
        '
        Me.UcSearcherGoods.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherGoods.Location = New System.Drawing.Point(500, 14)
        Me.UcSearcherGoods.Name = "UcSearcherGoods"
        Me.UcSearcherGoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherGoods.Size = New System.Drawing.Size(188, 31)
        Me.UcSearcherGoods.TabIndex = 9
        Me.UcSearcherGoods.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherGoods.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherGoods.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherGoods.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherGoods.UCIcon = Nothing
        Me.UcSearcherGoods.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherGoods.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherGoods.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherGoods.UCShowDomainIcon = False
        '
        'UcPersianTextBoxStrDescription
        '
        Me.UcPersianTextBoxStrDescription.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxStrDescription.Location = New System.Drawing.Point(7, 84)
        Me.UcPersianTextBoxStrDescription.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxStrDescription.Name = "UcPersianTextBoxStrDescription"
        Me.UcPersianTextBoxStrDescription.Size = New System.Drawing.Size(541, 28)
        Me.UcPersianTextBoxStrDescription.TabIndex = 19
        Me.UcPersianTextBoxStrDescription.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrDescription.UCBorder = True
        Me.UcPersianTextBoxStrDescription.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxStrDescription.UCEnable = True
        Me.UcPersianTextBoxStrDescription.UCFont = New System.Drawing.Font("IRMehr", 9.0!)
        Me.UcPersianTextBoxStrDescription.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrDescription.UCMultiLine = False
        Me.UcPersianTextBoxStrDescription.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxStrDescription.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrDescription.UCValue = ""
        '
        'UcPersianTextBoxAddress
        '
        Me.UcPersianTextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxAddress.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxAddress.Location = New System.Drawing.Point(609, 84)
        Me.UcPersianTextBoxAddress.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxAddress.Name = "UcPersianTextBoxAddress"
        Me.UcPersianTextBoxAddress.Size = New System.Drawing.Size(317, 28)
        Me.UcPersianTextBoxAddress.TabIndex = 17
        Me.UcPersianTextBoxAddress.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAddress.UCBorder = True
        Me.UcPersianTextBoxAddress.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxAddress.UCEnable = True
        Me.UcPersianTextBoxAddress.UCFont = New System.Drawing.Font("IRMehr", 9.0!)
        Me.UcPersianTextBoxAddress.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAddress.UCMultiLine = False
        Me.UcPersianTextBoxAddress.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxAddress.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAddress.UCValue = ""
        '
        'UcPersianTextBoxStrBarname
        '
        Me.UcPersianTextBoxStrBarname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxStrBarname.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxStrBarname.Location = New System.Drawing.Point(7, 50)
        Me.UcPersianTextBoxStrBarname.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxStrBarname.Name = "UcPersianTextBoxStrBarname"
        Me.UcPersianTextBoxStrBarname.Size = New System.Drawing.Size(498, 28)
        Me.UcPersianTextBoxStrBarname.TabIndex = 15
        Me.UcPersianTextBoxStrBarname.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrBarname.UCBorder = True
        Me.UcPersianTextBoxStrBarname.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxStrBarname.UCEnable = True
        Me.UcPersianTextBoxStrBarname.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxStrBarname.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrBarname.UCMultiLine = False
        Me.UcPersianTextBoxStrBarname.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxStrBarname.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrBarname.UCValue = ""
        '
        'UcNumberTransportPrice
        '
        Me.UcNumberTransportPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberTransportPrice.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTransportPrice.Location = New System.Drawing.Point(566, 53)
        Me.UcNumberTransportPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberTransportPrice.Name = "UcNumberTransportPrice"
        Me.UcNumberTransportPrice.Size = New System.Drawing.Size(80, 25)
        Me.UcNumberTransportPrice.TabIndex = 13
        Me.UcNumberTransportPrice.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberTransportPrice.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumberTransportPrice.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTransportPrice.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTransportPrice.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberTransportPrice.UCBorder = True
        Me.UcNumberTransportPrice.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberTransportPrice.UCEnable = True
        Me.UcNumberTransportPrice.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTransportPrice.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberTransportPrice.UCMultiLine = False
        Me.UcNumberTransportPrice.UCValue = CType(0, Long)
        '
        'UcNumbernCarNumKol
        '
        Me.UcNumbernCarNumKol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumbernCarNumKol.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernCarNumKol.Location = New System.Drawing.Point(705, 52)
        Me.UcNumbernCarNumKol.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernCarNumKol.Name = "UcNumbernCarNumKol"
        Me.UcNumbernCarNumKol.Size = New System.Drawing.Size(52, 25)
        Me.UcNumbernCarNumKol.TabIndex = 11
        Me.UcNumbernCarNumKol.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumbernCarNumKol.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumbernCarNumKol.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernCarNumKol.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernCarNumKol.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumbernCarNumKol.UCBorder = True
        Me.UcNumbernCarNumKol.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumbernCarNumKol.UCEnable = True
        Me.UcNumbernCarNumKol.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumbernCarNumKol.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernCarNumKol.UCMultiLine = False
        Me.UcNumbernCarNumKol.UCValue = CType(0, Long)
        '
        'UcLabelnCarNumKol
        '
        Me.UcLabelnCarNumKol._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelnCarNumKol._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelnCarNumKol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelnCarNumKol.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelnCarNumKol.Location = New System.Drawing.Point(756, 47)
        Me.UcLabelnCarNumKol.Name = "UcLabelnCarNumKol"
        Me.UcLabelnCarNumKol.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelnCarNumKol.Size = New System.Drawing.Size(54, 32)
        Me.UcLabelnCarNumKol.TabIndex = 10
        Me.UcLabelnCarNumKol.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelnCarNumKol.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelnCarNumKol.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelnCarNumKol.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelnCarNumKol.UCValue = "تعداد کل"
        '
        'UcLabelNoeBargir1
        '
        Me.UcLabelNoeBargir1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelNoeBargir1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelNoeBargir1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelNoeBargir1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelNoeBargir1.Location = New System.Drawing.Point(191, -3)
        Me.UcLabelNoeBargir1.Name = "UcLabelNoeBargir1"
        Me.UcLabelNoeBargir1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelNoeBargir1.Size = New System.Drawing.Size(57, 32)
        Me.UcLabelNoeBargir1.TabIndex = 6
        Me.UcLabelNoeBargir1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelNoeBargir1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelNoeBargir1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelNoeBargir1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelNoeBargir1.UCValue = "نوع بارگیر"
        '
        'UcLabelSherkatHamloNaghl1
        '
        Me.UcLabelSherkatHamloNaghl1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSherkatHamloNaghl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelSherkatHamloNaghl1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl1.Location = New System.Drawing.Point(927, 14)
        Me.UcLabelSherkatHamloNaghl1.Name = "UcLabelSherkatHamloNaghl1"
        Me.UcLabelSherkatHamloNaghl1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSherkatHamloNaghl1.Size = New System.Drawing.Size(97, 33)
        Me.UcLabelSherkatHamloNaghl1.TabIndex = 0
        Me.UcLabelSherkatHamloNaghl1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSherkatHamloNaghl1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSherkatHamloNaghl1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelSherkatHamloNaghl1.UCValue = "شرکت حمل و نقل"
        '
        'UcLabelMaghsadeBar1
        '
        Me.UcLabelMaghsadeBar1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelMaghsadeBar1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelMaghsadeBar1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelMaghsadeBar1.Location = New System.Drawing.Point(440, 12)
        Me.UcLabelMaghsadeBar1.Name = "UcLabelMaghsadeBar1"
        Me.UcLabelMaghsadeBar1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelMaghsadeBar1.Size = New System.Drawing.Size(65, 36)
        Me.UcLabelMaghsadeBar1.TabIndex = 2
        Me.UcLabelMaghsadeBar1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelMaghsadeBar1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelMaghsadeBar1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelMaghsadeBar1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelMaghsadeBar1.UCValue = "مقصد بار"
        '
        'UcLabelTransportPrice
        '
        Me.UcLabelTransportPrice._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTransportPrice._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTransportPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelTransportPrice.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTransportPrice.Location = New System.Drawing.Point(647, 46)
        Me.UcLabelTransportPrice.Name = "UcLabelTransportPrice"
        Me.UcLabelTransportPrice.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTransportPrice.Size = New System.Drawing.Size(53, 32)
        Me.UcLabelTransportPrice.TabIndex = 12
        Me.UcLabelTransportPrice.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTransportPrice.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTransportPrice.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTransportPrice.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTransportPrice.UCValue = "نرخ حمل"
        '
        'UcLabelMabdaeBar1
        '
        Me.UcLabelMabdaeBar1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelMabdaeBar1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelMabdaeBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelMabdaeBar1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelMabdaeBar1.Location = New System.Drawing.Point(927, 46)
        Me.UcLabelMabdaeBar1.Name = "UcLabelMabdaeBar1"
        Me.UcLabelMabdaeBar1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelMabdaeBar1.Size = New System.Drawing.Size(61, 32)
        Me.UcLabelMabdaeBar1.TabIndex = 4
        Me.UcLabelMabdaeBar1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelMabdaeBar1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelMabdaeBar1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelMabdaeBar1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelMabdaeBar1.UCValue = "مبداء بار"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(547, 81)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(56, 32)
        Me.UcLabel3.TabIndex = 18
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "توضیحات"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(926, 81)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(39, 32)
        Me.UcLabel2.TabIndex = 16
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "آدرس"
        '
        'UcLabelNoeBar1
        '
        Me.UcLabelNoeBar1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelNoeBar1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelNoeBar1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelNoeBar1.Location = New System.Drawing.Point(687, 14)
        Me.UcLabelNoeBar1.Name = "UcLabelNoeBar1"
        Me.UcLabelNoeBar1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelNoeBar1.Size = New System.Drawing.Size(48, 32)
        Me.UcLabelNoeBar1.TabIndex = 8
        Me.UcLabelNoeBar1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelNoeBar1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelNoeBar1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelNoeBar1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelNoeBar1.UCValue = "نوع بار"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(500, 48)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(47, 32)
        Me.UcLabel1.TabIndex = 14
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "گیرنده"
        '
        'UcucLoadCapacitorAccountingCollection
        '
        Me.UcucLoadCapacitorAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadCapacitorAccountingCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucLoadCapacitorAccountingCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucLoadCapacitorAccountingCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcucLoadCapacitorAccountingCollection.Name = "UcucLoadCapacitorAccountingCollection"
        Me.UcucLoadCapacitorAccountingCollection.Size = New System.Drawing.Size(1037, 178)
        Me.UcucLoadCapacitorAccountingCollection.TabIndex = 1
        Me.UcucLoadCapacitorAccountingCollection.UCViewUCPictureExit = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UcLabelNoeBargir1)
        Me.Panel3.Controls.Add(Me.UcSearcherLoaderTypes)
        Me.Panel3.Location = New System.Drawing.Point(8, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 31)
        Me.Panel3.TabIndex = 20
        '
        'UCLoadCapacitorLoadManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadCapacitorLoadManipulation"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1047, 188)
        Me.PnlMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlHolder.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PnlHolder As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UcNumbernEstelamId As R2CoreGUI.UCNumber
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UcPersianTextBoxLoadCapacitorLoadDateTimeComposite As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcSearcherGoods As UCSearcherGoods
    Friend WithEvents UcLabelNoeBar1 As UCLabelNoeBar
    Friend WithEvents UcSearcherLoaderTypes As UCSearcherLoaderTypes
    Friend WithEvents UcLabelNoeBargir1 As UCLabelNoeBargir
    Friend WithEvents UcSearcherLoadSources As UCSearcherLoadSources
    Friend WithEvents UcLabelMabdaeBar1 As UCLabelMabdaeBar
    Friend WithEvents UcSearcherLoadTargets As UCSearcherLoadTargets
    Friend WithEvents UcLabelSherkatHamloNaghl1 As UCLabelSherkatHamloNaghl
    Friend WithEvents UcLabelMaghsadeBar1 As UCLabelMaghsadeBar
    Friend WithEvents UcLabelnCarNumKol As R2CoreGUI.UCLabel
    Friend WithEvents UcNumberTransportPrice As R2CoreGUI.UCNumber
    Friend WithEvents UcLabelTransportPrice As R2CoreGUI.UCLabel
    Friend WithEvents UcNumbernCarNumKol As R2CoreGUI.UCNumber
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcPersianTextBoxStrBarname As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxStrDescription As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxAddress As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabel3 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonLoadCapacitorLoadFreeLining As R2CoreGUI.UCButton
    Friend WithEvents UcButtonLoadCapacitorLoadCancelling As R2CoreGUI.UCButton
    Friend WithEvents UcButtonLoadCapacitorLoadDeleting As R2CoreGUI.UCButton
    Friend WithEvents UcButtonLoadCapacitorLoadRegisteringEditing As R2CoreGUI.UCButton
    Friend WithEvents UcPersianTextBoxLoadPermissionStatus As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UcNumbernCarNum As R2CoreGUI.UCNumber
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UcButtonLoadPermissions As R2CoreGUI.UCButton
    Friend WithEvents UcButtonNew As R2CoreGUI.UCButton
    Friend WithEvents UcSearcherTransportCompanies As UCSearcherTransportCompanies
    Friend WithEvents UcButtonLoadCapacitorAccounting As R2CoreGUI.UCButton
    Friend WithEvents UcucLoadCapacitorAccountingCollection As UCUCLoadCapacitorAccountingCollection
    Friend WithEvents UcButtonLoadCapacitorLoadSedimentation As R2CoreGUI.UCButton
    Friend WithEvents Panel3 As Panel
End Class
