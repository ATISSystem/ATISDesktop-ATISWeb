<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcAnnouncementHallMonitoring
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcAnnouncementHallMonitoring))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlLoaderLicenses = New System.Windows.Forms.Panel()
        Me.PnlAnnouncementHallMonitoringBulletin = New System.Windows.Forms.Panel()
        Me.PictureBoxPicturesOnLed = New System.Windows.Forms.PictureBox()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlLoaderLicensesDetails = New System.Windows.Forms.Panel()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.PicErrorIndicator = New System.Windows.Forms.PictureBox()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.UcPersianTextBoxBulletin = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabelDriverNameFamily = New R2CoreGUI.UCLabel()
        Me.UcLabelTurnNumber = New R2CoreGUI.UCLabel()
        Me.UcLabelCarTruckPlateString = New R2CoreGUI.UCLabel()
        Me.UcLabelLoadTitle = New R2CoreGUI.UCLabel()
        Me.UcLabelLoadTarget = New R2CoreGUI.UCLabel()
        Me.UcLabelShippingCompany = New R2CoreGUI.UCLabel()
        Me.UcLabelDescription = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcLabel5 = New R2CoreGUI.UCLabel()
        Me.UcLabel6 = New R2CoreGUI.UCLabel()
        Me.UcLabel7 = New R2CoreGUI.UCLabel()
        Me.UcDateTime1 = New R2CoreGUI.UCDateTime()
        Me.PnlMain.SuspendLayout
        Me.PnlLoaderLicenses.SuspendLayout
        Me.PnlAnnouncementHallMonitoringBulletin.SuspendLayout
        CType(Me.PictureBoxPicturesOnLed,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlBottom.SuspendLayout
        Me.PnlTop.SuspendLayout
        Me.PnlLoaderLicensesDetails.SuspendLayout
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicErrorIndicator,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.PnlBottom)
        Me.PnlMain.Controls.Add(Me.PnlTop)
        Me.PnlMain.Controls.Add(Me.PnlLoaderLicenses)
        Me.PnlMain.Controls.Add(Me.PnlAnnouncementHallMonitoringBulletin)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(975, 680)
        Me.PnlMain.TabIndex = 0
        '
        'PnlLoaderLicenses
        '
        Me.PnlLoaderLicenses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoaderLicenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoaderLicenses.Controls.Add(Me.PnlLoaderLicensesDetails)
        Me.PnlLoaderLicenses.Controls.Add(Me.UcDriverImage)
        Me.PnlLoaderLicenses.Location = New System.Drawing.Point(8, 39)
        Me.PnlLoaderLicenses.Name = "PnlLoaderLicenses"
        Me.PnlLoaderLicenses.Size = New System.Drawing.Size(957, 602)
        Me.PnlLoaderLicenses.TabIndex = 3
        '
        'PnlAnnouncementHallMonitoringBulletin
        '
        Me.PnlAnnouncementHallMonitoringBulletin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlAnnouncementHallMonitoringBulletin.Controls.Add(Me.UcPersianTextBoxBulletin)
        Me.PnlAnnouncementHallMonitoringBulletin.Controls.Add(Me.PictureBoxPicturesOnLed)
        Me.PnlAnnouncementHallMonitoringBulletin.Location = New System.Drawing.Point(8, 39)
        Me.PnlAnnouncementHallMonitoringBulletin.Name = "PnlAnnouncementHallMonitoringBulletin"
        Me.PnlAnnouncementHallMonitoringBulletin.Size = New System.Drawing.Size(957, 602)
        Me.PnlAnnouncementHallMonitoringBulletin.TabIndex = 2
        '
        'PictureBoxPicturesOnLed
        '
        Me.PictureBoxPicturesOnLed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxPicturesOnLed.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxPicturesOnLed.Name = "PictureBoxPicturesOnLed"
        Me.PictureBoxPicturesOnLed.Size = New System.Drawing.Size(957, 602)
        Me.PictureBoxPicturesOnLed.TabIndex = 1
        Me.PictureBoxPicturesOnLed.TabStop = false
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Silver
        Me.PnlBottom.Controls.Add(Me.UcDateTime1)
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Location = New System.Drawing.Point(0, 647)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(975, 33)
        Me.PnlBottom.TabIndex = 1
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Silver
        Me.PnlTop.Controls.Add(Me.PicErrorIndicator)
        Me.PnlTop.Controls.Add(Me.PicExit)
        Me.PnlTop.Controls.Add(Me.UcLabelTop)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(975, 33)
        Me.PnlTop.TabIndex = 0
        '
        'PnlLoaderLicensesDetails
        '
        Me.PnlLoaderLicensesDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelDescription)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelShippingCompany)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelLoadTarget)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelLoadTitle)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelCarTruckPlateString)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelTurnNumber)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabelDriverNameFamily)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel5)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel6)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel7)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel4)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel3)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel2)
        Me.PnlLoaderLicensesDetails.Controls.Add(Me.UcLabel1)
        Me.PnlLoaderLicensesDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLoaderLicensesDetails.Location = New System.Drawing.Point(0, 0)
        Me.PnlLoaderLicensesDetails.Name = "PnlLoaderLicensesDetails"
        Me.PnlLoaderLicensesDetails.Size = New System.Drawing.Size(390, 600)
        Me.PnlLoaderLicensesDetails.TabIndex = 1
        '
        'PicExit
        '
        Me.PicExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"),System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(945, 1)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(33, 27)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 2
        Me.PicExit.TabStop = false
        '
        'PicErrorIndicator
        '
        Me.PicErrorIndicator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicErrorIndicator.Enabled = false
        Me.PicErrorIndicator.Image = CType(resources.GetObject("PicErrorIndicator.Image"),System.Drawing.Image)
        Me.PicErrorIndicator.Location = New System.Drawing.Point(0, -3)
        Me.PicErrorIndicator.Name = "PicErrorIndicator"
        Me.PicErrorIndicator.Size = New System.Drawing.Size(33, 33)
        Me.PicErrorIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicErrorIndicator.TabIndex = 3
        Me.PicErrorIndicator.TabStop = false
        '
        'UcDriverImage
        '
        Me.UcDriverImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(390, 0)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverImage.Size = New System.Drawing.Size(566, 601)
        Me.UcDriverImage.TabIndex = 0
        '
        'UcPersianTextBoxBulletin
        '
        Me.UcPersianTextBoxBulletin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPersianTextBoxBulletin.Location = New System.Drawing.Point(0, 0)
        Me.UcPersianTextBoxBulletin.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxBulletin.Name = "UcPersianTextBoxBulletin"
        Me.UcPersianTextBoxBulletin.Size = New System.Drawing.Size(957, 602)
        Me.UcPersianTextBoxBulletin.TabIndex = 0
        Me.UcPersianTextBoxBulletin.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxBulletin.UCBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxBulletin.UCEnable = true
        Me.UcPersianTextBoxBulletin.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxBulletin.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxBulletin.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxBulletin.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxBulletin.UCValue = ""
        '
        'UcLabelTop
        '
        Me.UcLabelTop.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(975, 33)
        Me.UcLabelTop.TabIndex = 0
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTop.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = ""
        '
        'UcLabelDriverNameFamily
        '
        Me.UcLabelDriverNameFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDriverNameFamily.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverNameFamily.Location = New System.Drawing.Point(4, 21)
        Me.UcLabelDriverNameFamily.Name = "UcLabelDriverNameFamily"
        Me.UcLabelDriverNameFamily.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDriverNameFamily.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelDriverNameFamily.TabIndex = 0
        Me.UcLabelDriverNameFamily.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverNameFamily.UCFont = New System.Drawing.Font("IRMehr", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDriverNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDriverNameFamily.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDriverNameFamily.UCValue = "مرتضی شاهمرادی"
        '
        'UcLabelTurnNumber
        '
        Me.UcLabelTurnNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelTurnNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTurnNumber.Location = New System.Drawing.Point(4, 98)
        Me.UcLabelTurnNumber.Name = "UcLabelTurnNumber"
        Me.UcLabelTurnNumber.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTurnNumber.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelTurnNumber.TabIndex = 1
        Me.UcLabelTurnNumber.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTurnNumber.UCFont = New System.Drawing.Font("IRMehr", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTurnNumber.UCForeColor = System.Drawing.Color.Green
        Me.UcLabelTurnNumber.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTurnNumber.UCValue = "8754854"
        '
        'UcLabelCarTruckPlateString
        '
        Me.UcLabelCarTruckPlateString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCarTruckPlateString.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckPlateString.Location = New System.Drawing.Point(4, 186)
        Me.UcLabelCarTruckPlateString.Name = "UcLabelCarTruckPlateString"
        Me.UcLabelCarTruckPlateString.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCarTruckPlateString.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelCarTruckPlateString.TabIndex = 2
        Me.UcLabelCarTruckPlateString.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckPlateString.UCFont = New System.Drawing.Font("IRMehr", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCarTruckPlateString.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelCarTruckPlateString.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCarTruckPlateString.UCValue = "524ع17-13"
        '
        'UcLabelLoadTitle
        '
        Me.UcLabelLoadTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelLoadTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadTitle.Location = New System.Drawing.Point(2, 275)
        Me.UcLabelLoadTitle.Name = "UcLabelLoadTitle"
        Me.UcLabelLoadTitle.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadTitle.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelLoadTitle.TabIndex = 3
        Me.UcLabelLoadTitle.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadTitle.UCFont = New System.Drawing.Font("IRMehr", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelLoadTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelLoadTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadTitle.UCValue = "آهن تیر 14"
        '
        'UcLabelLoadTarget
        '
        Me.UcLabelLoadTarget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelLoadTarget.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadTarget.Location = New System.Drawing.Point(6, 371)
        Me.UcLabelLoadTarget.Name = "UcLabelLoadTarget"
        Me.UcLabelLoadTarget.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadTarget.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelLoadTarget.TabIndex = 4
        Me.UcLabelLoadTarget.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadTarget.UCFont = New System.Drawing.Font("IRMehr", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelLoadTarget.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabelLoadTarget.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadTarget.UCValue = "تهران"
        '
        'UcLabelShippingCompany
        '
        Me.UcLabelShippingCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelShippingCompany.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelShippingCompany.Location = New System.Drawing.Point(4, 453)
        Me.UcLabelShippingCompany.Name = "UcLabelShippingCompany"
        Me.UcLabelShippingCompany.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelShippingCompany.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelShippingCompany.TabIndex = 5
        Me.UcLabelShippingCompany.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelShippingCompany.UCFont = New System.Drawing.Font("IRMehr", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelShippingCompany.UCForeColor = System.Drawing.Color.Purple
        Me.UcLabelShippingCompany.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelShippingCompany.UCValue = "تفنگساز"
        '
        'UcLabelDescription
        '
        Me.UcLabelDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDescription.Location = New System.Drawing.Point(5, 540)
        Me.UcLabelDescription.Name = "UcLabelDescription"
        Me.UcLabelDescription.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDescription.Size = New System.Drawing.Size(380, 51)
        Me.UcLabelDescription.TabIndex = 6
        Me.UcLabelDescription.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDescription.UCFont = New System.Drawing.Font("IRMehr", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDescription.UCForeColor = System.Drawing.Color.Crimson
        Me.UcLabelDescription.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDescription.UCValue = "دوبندل"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(159, -2)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(70, 30)
        Me.UcLabel1.TabIndex = 7
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "راننده"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(159, 75)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(70, 30)
        Me.UcLabel2.TabIndex = 8
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "نوبت"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(159, 162)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(70, 30)
        Me.UcLabel3.TabIndex = 9
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "ناوگان"
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(159, 251)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(70, 30)
        Me.UcLabel4.TabIndex = 10
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "نوع بار"
        '
        'UcLabel5
        '
        Me.UcLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(159, 350)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(70, 30)
        Me.UcLabel5.TabIndex = 11
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "مقصد"
        '
        'UcLabel6
        '
        Me.UcLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel6.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.Location = New System.Drawing.Point(124, 430)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel6.Size = New System.Drawing.Size(136, 30)
        Me.UcLabel6.TabIndex = 12
        Me.UcLabel6.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel6.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel6.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel6.UCValue = "شرکت حمل و نقل"
        '
        'UcLabel7
        '
        Me.UcLabel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel7.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.Location = New System.Drawing.Point(159, 518)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel7.Size = New System.Drawing.Size(70, 30)
        Me.UcLabel7.TabIndex = 13
        Me.UcLabel7.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel7.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel7.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel7.UCValue = "توضیحات"
        '
        'UcDateTime1
        '
        Me.UcDateTime1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDateTime1.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTime1.Location = New System.Drawing.Point(399, 1)
        Me.UcDateTime1.Name = "UcDateTime1"
        Me.UcDateTime1.Size = New System.Drawing.Size(170, 32)
        Me.UcDateTime1.TabIndex = 0
        Me.UcDateTime1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcDateTime1.UCClockIconAppierance = true
        Me.UcDateTime1.UCEnable = true
        Me.UcDateTime1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcDateTime1.UCForeColor = System.Drawing.Color.Black
        '
        'FrmcAnnouncementHallMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(995, 700)
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmcAnnouncementHallMonitoring"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnlMain.ResumeLayout(false)
        Me.PnlLoaderLicenses.ResumeLayout(false)
        Me.PnlAnnouncementHallMonitoringBulletin.ResumeLayout(false)
        CType(Me.PictureBoxPicturesOnLed,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlBottom.ResumeLayout(false)
        Me.PnlTop.ResumeLayout(false)
        Me.PnlLoaderLicensesDetails.ResumeLayout(false)
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicErrorIndicator,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlAnnouncementHallMonitoringBulletin As Panel
    Friend WithEvents PnlBottom As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlLoaderLicenses As Panel
    Friend WithEvents PictureBoxPicturesOnLed As PictureBox
    Friend WithEvents UcPersianTextBoxBulletin As R2CoreGUI.UCPersianTextBox
    Friend WithEvents PnlLoaderLicensesDetails As Panel
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents PicErrorIndicator As PictureBox
    Friend WithEvents PicExit As PictureBox
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcDateTime1 As R2CoreGUI.UCDateTime
    Friend WithEvents UcLabelDescription As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelShippingCompany As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelLoadTarget As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelLoadTitle As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelCarTruckPlateString As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelTurnNumber As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelDriverNameFamily As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel5 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel6 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel7 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel4 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel3 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
End Class
