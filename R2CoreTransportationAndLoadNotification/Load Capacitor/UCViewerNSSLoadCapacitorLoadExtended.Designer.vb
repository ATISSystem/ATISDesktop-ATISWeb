Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSLoadCapacitorLoadExtended
    Inherits UCLoadCapacitorLoad

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
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.OrderingOptionUser = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OrderingOptionAddress = New System.Windows.Forms.Label()
        Me.OrderingOptionProductReciever = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OrderingOptionLoadStatus = New System.Windows.Forms.Label()
        Me.OrderingOptiondTimeElam = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.UcMinimizeMaximize = New R2CoreGUI.UCMinimizeMaximize()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OrderingOptionLoaderType = New System.Windows.Forms.Label()
        Me.OrderingOptionTransportPrice = New System.Windows.Forms.Label()
        Me.OrderingOptionnCarNumKol = New System.Windows.Forms.Label()
        Me.OrderingOptionTargetCity = New System.Windows.Forms.Label()
        Me.OrderingOptionProduct = New System.Windows.Forms.Label()
        Me.OrderingOptionTransportCompany = New System.Windows.Forms.Label()
        Me.OrderingOptionnEstelamId = New System.Windows.Forms.Label()
        Me.LabelnEstelamId = New System.Windows.Forms.Label()
        Me.LabelTransportCompanyTitle = New System.Windows.Forms.Label()
        Me.LabelGoodTitle = New System.Windows.Forms.Label()
        Me.LabelLoadTargetTitle = New System.Windows.Forms.Label()
        Me.LabelnCarNumKol = New System.Windows.Forms.Label()
        Me.LabelTransportPrice = New System.Windows.Forms.Label()
        Me.LabelLoaderTypeTitle = New System.Windows.Forms.Label()
        Me.LabelStrDescription = New System.Windows.Forms.Label()
        Me.LabelnCarNum = New System.Windows.Forms.Label()
        Me.LabelDateTimeComposite = New System.Windows.Forms.Label()
        Me.LabelLoadStatusTitle = New System.Windows.Forms.Label()
        Me.LabelLoadSourceTitle = New System.Windows.Forms.Label()
        Me.LabelStrBarName = New System.Windows.Forms.Label()
        Me.LabelStrAddress = New System.Windows.Forms.Label()
        Me.LabelLoadAllocationNotOK = New System.Windows.Forms.Label()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.PnlAccounting = New System.Windows.Forms.Panel()
        Me.OrderingOptionTonaj = New System.Windows.Forms.Label()
        Me.LabelnTonaj = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.PnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(929, 63)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(4)
        Me.PnlOutter.Size = New System.Drawing.Size(929, 63)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.MistyRose
        Me.PnlInner.Controls.Add(Me.OrderingOptionUser)
        Me.PnlInner.Controls.Add(Me.Label9)
        Me.PnlInner.Controls.Add(Me.OrderingOptionAddress)
        Me.PnlInner.Controls.Add(Me.OrderingOptionProductReciever)
        Me.PnlInner.Controls.Add(Me.Label12)
        Me.PnlInner.Controls.Add(Me.OrderingOptionLoadStatus)
        Me.PnlInner.Controls.Add(Me.OrderingOptiondTimeElam)
        Me.PnlInner.Controls.Add(Me.PnlTop)
        Me.PnlInner.Controls.Add(Me.LabelDateTimeComposite)
        Me.PnlInner.Controls.Add(Me.LabelLoadStatusTitle)
        Me.PnlInner.Controls.Add(Me.LabelLoadSourceTitle)
        Me.PnlInner.Controls.Add(Me.LabelStrBarName)
        Me.PnlInner.Controls.Add(Me.LabelStrAddress)
        Me.PnlInner.Controls.Add(Me.LabelLoadAllocationNotOK)
        Me.PnlInner.Controls.Add(Me.LabelUserName)
        Me.PnlInner.Controls.Add(Me.PnlAccounting)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(4, 4)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(919, 53)
        Me.PnlInner.TabIndex = 0
        '
        'OrderingOptionUser
        '
        Me.OrderingOptionUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionUser.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionUser.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionUser.Location = New System.Drawing.Point(6, 58)
        Me.OrderingOptionUser.Name = "OrderingOptionUser"
        Me.OrderingOptionUser.Size = New System.Drawing.Size(101, 23)
        Me.OrderingOptionUser.TabIndex = 53
        Me.OrderingOptionUser.Text = "کاربر ثبت بار"
        Me.OrderingOptionUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(109, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 23)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "ت.بلاتکلیف"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionAddress
        '
        Me.OrderingOptionAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderingOptionAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionAddress.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionAddress.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionAddress.Location = New System.Drawing.Point(210, 58)
        Me.OrderingOptionAddress.Name = "OrderingOptionAddress"
        Me.OrderingOptionAddress.Size = New System.Drawing.Size(110, 23)
        Me.OrderingOptionAddress.TabIndex = 39
        Me.OrderingOptionAddress.Text = "آدرس"
        Me.OrderingOptionAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionProductReciever
        '
        Me.OrderingOptionProductReciever.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderingOptionProductReciever.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionProductReciever.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionProductReciever.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionProductReciever.Location = New System.Drawing.Point(314, 58)
        Me.OrderingOptionProductReciever.Name = "OrderingOptionProductReciever"
        Me.OrderingOptionProductReciever.Size = New System.Drawing.Size(202, 23)
        Me.OrderingOptionProductReciever.TabIndex = 38
        Me.OrderingOptionProductReciever.Text = "گیرنده"
        Me.OrderingOptionProductReciever.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(522, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 23)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "مبداء بار"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionLoadStatus
        '
        Me.OrderingOptionLoadStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderingOptionLoadStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionLoadStatus.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionLoadStatus.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionLoadStatus.Location = New System.Drawing.Point(843, 58)
        Me.OrderingOptionLoadStatus.Name = "OrderingOptionLoadStatus"
        Me.OrderingOptionLoadStatus.Size = New System.Drawing.Size(73, 23)
        Me.OrderingOptionLoadStatus.TabIndex = 36
        Me.OrderingOptionLoadStatus.Text = "وضعیت بار"
        Me.OrderingOptionLoadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptiondTimeElam
        '
        Me.OrderingOptiondTimeElam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderingOptiondTimeElam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptiondTimeElam.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptiondTimeElam.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptiondTimeElam.Location = New System.Drawing.Point(699, 58)
        Me.OrderingOptiondTimeElam.Name = "OrderingOptiondTimeElam"
        Me.OrderingOptiondTimeElam.Size = New System.Drawing.Size(142, 23)
        Me.OrderingOptiondTimeElam.TabIndex = 35
        Me.OrderingOptiondTimeElam.Text = "زمان ثبت بار"
        Me.OrderingOptiondTimeElam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTop
        '
        Me.PnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTop.BackColor = System.Drawing.Color.MistyRose
        Me.PnlTop.Controls.Add(Me.LabelnTonaj)
        Me.PnlTop.Controls.Add(Me.OrderingOptionTonaj)
        Me.PnlTop.Controls.Add(Me.UcMinimizeMaximize)
        Me.PnlTop.Controls.Add(Me.Label7)
        Me.PnlTop.Controls.Add(Me.OrderingOptionLoaderType)
        Me.PnlTop.Controls.Add(Me.OrderingOptionTransportPrice)
        Me.PnlTop.Controls.Add(Me.OrderingOptionnCarNumKol)
        Me.PnlTop.Controls.Add(Me.OrderingOptionTargetCity)
        Me.PnlTop.Controls.Add(Me.OrderingOptionProduct)
        Me.PnlTop.Controls.Add(Me.OrderingOptionTransportCompany)
        Me.PnlTop.Controls.Add(Me.OrderingOptionnEstelamId)
        Me.PnlTop.Controls.Add(Me.LabelnEstelamId)
        Me.PnlTop.Controls.Add(Me.LabelTransportCompanyTitle)
        Me.PnlTop.Controls.Add(Me.LabelGoodTitle)
        Me.PnlTop.Controls.Add(Me.LabelLoadTargetTitle)
        Me.PnlTop.Controls.Add(Me.LabelnCarNumKol)
        Me.PnlTop.Controls.Add(Me.LabelTransportPrice)
        Me.PnlTop.Controls.Add(Me.LabelLoaderTypeTitle)
        Me.PnlTop.Controls.Add(Me.LabelStrDescription)
        Me.PnlTop.Controls.Add(Me.LabelnCarNum)
        Me.PnlTop.Location = New System.Drawing.Point(3, 3)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(913, 60)
        Me.PnlTop.TabIndex = 0
        '
        'UcMinimizeMaximize
        '
        Me.UcMinimizeMaximize.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimizeMaximize.Location = New System.Drawing.Point(1, 25)
        Me.UcMinimizeMaximize.Name = "UcMinimizeMaximize"
        Me.UcMinimizeMaximize.Size = New System.Drawing.Size(19, 21)
        Me.UcMinimizeMaximize.TabIndex = 54
        Me.UcMinimizeMaximize.UCCurrentMaxMinStatus = R2Core.R2Enums.MaxMin.Min
        '
        'Label7
        '
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(8, -6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 23)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "باقیمانده"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionLoaderType
        '
        Me.OrderingOptionLoaderType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionLoaderType.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionLoaderType.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionLoaderType.Location = New System.Drawing.Point(71, -6)
        Me.OrderingOptionLoaderType.Name = "OrderingOptionLoaderType"
        Me.OrderingOptionLoaderType.Size = New System.Drawing.Size(122, 23)
        Me.OrderingOptionLoaderType.TabIndex = 40
        Me.OrderingOptionLoaderType.Text = "نوع بارگیر"
        Me.OrderingOptionLoaderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionTransportPrice
        '
        Me.OrderingOptionTransportPrice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionTransportPrice.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionTransportPrice.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionTransportPrice.Location = New System.Drawing.Point(199, -6)
        Me.OrderingOptionTransportPrice.Name = "OrderingOptionTransportPrice"
        Me.OrderingOptionTransportPrice.Size = New System.Drawing.Size(100, 23)
        Me.OrderingOptionTransportPrice.TabIndex = 39
        Me.OrderingOptionTransportPrice.Text = "نرخ حمل"
        Me.OrderingOptionTransportPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionnCarNumKol
        '
        Me.OrderingOptionnCarNumKol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionnCarNumKol.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionnCarNumKol.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionnCarNumKol.Location = New System.Drawing.Point(305, -6)
        Me.OrderingOptionnCarNumKol.Name = "OrderingOptionnCarNumKol"
        Me.OrderingOptionnCarNumKol.Size = New System.Drawing.Size(53, 23)
        Me.OrderingOptionnCarNumKol.TabIndex = 38
        Me.OrderingOptionnCarNumKol.Text = "تعداد کل"
        Me.OrderingOptionnCarNumKol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionTargetCity
        '
        Me.OrderingOptionTargetCity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionTargetCity.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionTargetCity.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionTargetCity.Location = New System.Drawing.Point(364, -6)
        Me.OrderingOptionTargetCity.Name = "OrderingOptionTargetCity"
        Me.OrderingOptionTargetCity.Size = New System.Drawing.Size(129, 23)
        Me.OrderingOptionTargetCity.TabIndex = 37
        Me.OrderingOptionTargetCity.Text = "مقصد"
        Me.OrderingOptionTargetCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionProduct
        '
        Me.OrderingOptionProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionProduct.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionProduct.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionProduct.Location = New System.Drawing.Point(549, -6)
        Me.OrderingOptionProduct.Name = "OrderingOptionProduct"
        Me.OrderingOptionProduct.Size = New System.Drawing.Size(140, 23)
        Me.OrderingOptionProduct.TabIndex = 36
        Me.OrderingOptionProduct.Text = "نوع بار"
        Me.OrderingOptionProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionTransportCompany
        '
        Me.OrderingOptionTransportCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderingOptionTransportCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionTransportCompany.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionTransportCompany.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionTransportCompany.Location = New System.Drawing.Point(695, -6)
        Me.OrderingOptionTransportCompany.Name = "OrderingOptionTransportCompany"
        Me.OrderingOptionTransportCompany.Size = New System.Drawing.Size(131, 23)
        Me.OrderingOptionTransportCompany.TabIndex = 35
        Me.OrderingOptionTransportCompany.Text = "شرکت حمل ونقل"
        Me.OrderingOptionTransportCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderingOptionnEstelamId
        '
        Me.OrderingOptionnEstelamId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderingOptionnEstelamId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionnEstelamId.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionnEstelamId.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionnEstelamId.Location = New System.Drawing.Point(832, -6)
        Me.OrderingOptionnEstelamId.Name = "OrderingOptionnEstelamId"
        Me.OrderingOptionnEstelamId.Size = New System.Drawing.Size(82, 23)
        Me.OrderingOptionnEstelamId.TabIndex = 34
        Me.OrderingOptionnEstelamId.Text = "کد مخزن بار"
        Me.OrderingOptionnEstelamId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelnEstelamId
        '
        Me.LabelnEstelamId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelnEstelamId.BackColor = System.Drawing.Color.Transparent
        Me.LabelnEstelamId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelnEstelamId.Font = New System.Drawing.Font("Alborz Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelnEstelamId.ForeColor = System.Drawing.Color.Red
        Me.LabelnEstelamId.Location = New System.Drawing.Point(832, 15)
        Me.LabelnEstelamId.Name = "LabelnEstelamId"
        Me.LabelnEstelamId.Size = New System.Drawing.Size(78, 23)
        Me.LabelnEstelamId.TabIndex = 55
        Me.LabelnEstelamId.Text = "486523"
        Me.LabelnEstelamId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTransportCompanyTitle
        '
        Me.LabelTransportCompanyTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTransportCompanyTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransportCompanyTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTransportCompanyTitle.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransportCompanyTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTransportCompanyTitle.Location = New System.Drawing.Point(690, 12)
        Me.LabelTransportCompanyTitle.Name = "LabelTransportCompanyTitle"
        Me.LabelTransportCompanyTitle.Size = New System.Drawing.Size(136, 23)
        Me.LabelTransportCompanyTitle.TabIndex = 56
        Me.LabelTransportCompanyTitle.Text = "شمشاد ترابر سپاهان"
        Me.LabelTransportCompanyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGoodTitle
        '
        Me.LabelGoodTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelGoodTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoodTitle.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoodTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelGoodTitle.Location = New System.Drawing.Point(553, 12)
        Me.LabelGoodTitle.Name = "LabelGoodTitle"
        Me.LabelGoodTitle.Size = New System.Drawing.Size(136, 23)
        Me.LabelGoodTitle.TabIndex = 57
        Me.LabelGoodTitle.Text = "تیرآن 14"
        Me.LabelGoodTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadTargetTitle
        '
        Me.LabelLoadTargetTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadTargetTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoadTargetTitle.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoadTargetTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadTargetTitle.Location = New System.Drawing.Point(363, 12)
        Me.LabelLoadTargetTitle.Name = "LabelLoadTargetTitle"
        Me.LabelLoadTargetTitle.Size = New System.Drawing.Size(129, 23)
        Me.LabelLoadTargetTitle.TabIndex = 58
        Me.LabelLoadTargetTitle.Text = "آبادان"
        Me.LabelLoadTargetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelnCarNumKol
        '
        Me.LabelnCarNumKol.BackColor = System.Drawing.Color.Transparent
        Me.LabelnCarNumKol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelnCarNumKol.Font = New System.Drawing.Font("Alborz Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelnCarNumKol.ForeColor = System.Drawing.Color.Red
        Me.LabelnCarNumKol.Location = New System.Drawing.Point(305, 14)
        Me.LabelnCarNumKol.Name = "LabelnCarNumKol"
        Me.LabelnCarNumKol.Size = New System.Drawing.Size(52, 23)
        Me.LabelnCarNumKol.TabIndex = 59
        Me.LabelnCarNumKol.Text = "20"
        Me.LabelnCarNumKol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTransportPrice
        '
        Me.LabelTransportPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransportPrice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTransportPrice.Font = New System.Drawing.Font("Alborz Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelTransportPrice.ForeColor = System.Drawing.Color.Black
        Me.LabelTransportPrice.Location = New System.Drawing.Point(199, 16)
        Me.LabelTransportPrice.Name = "LabelTransportPrice"
        Me.LabelTransportPrice.Size = New System.Drawing.Size(100, 23)
        Me.LabelTransportPrice.TabIndex = 60
        Me.LabelTransportPrice.Text = "3123123123123"
        Me.LabelTransportPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoaderTypeTitle
        '
        Me.LabelLoaderTypeTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoaderTypeTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoaderTypeTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoaderTypeTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelLoaderTypeTitle.Location = New System.Drawing.Point(71, 12)
        Me.LabelLoaderTypeTitle.Name = "LabelLoaderTypeTitle"
        Me.LabelLoaderTypeTitle.Size = New System.Drawing.Size(122, 21)
        Me.LabelLoaderTypeTitle.TabIndex = 61
        Me.LabelLoaderTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStrDescription
        '
        Me.LabelStrDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStrDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelStrDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelStrDescription.Font = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStrDescription.ForeColor = System.Drawing.Color.Blue
        Me.LabelStrDescription.Location = New System.Drawing.Point(50, 31)
        Me.LabelStrDescription.Name = "LabelStrDescription"
        Me.LabelStrDescription.Size = New System.Drawing.Size(860, 22)
        Me.LabelStrDescription.TabIndex = 63
        Me.LabelStrDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelnCarNum
        '
        Me.LabelnCarNum.BackColor = System.Drawing.Color.Transparent
        Me.LabelnCarNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelnCarNum.Font = New System.Drawing.Font("Alborz Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelnCarNum.ForeColor = System.Drawing.Color.Red
        Me.LabelnCarNum.Location = New System.Drawing.Point(4, 15)
        Me.LabelnCarNum.Name = "LabelnCarNum"
        Me.LabelnCarNum.Size = New System.Drawing.Size(62, 23)
        Me.LabelnCarNum.TabIndex = 62
        Me.LabelnCarNum.Text = "4"
        Me.LabelnCarNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDateTimeComposite
        '
        Me.LabelDateTimeComposite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTimeComposite.BackColor = System.Drawing.Color.Transparent
        Me.LabelDateTimeComposite.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelDateTimeComposite.ForeColor = System.Drawing.Color.Green
        Me.LabelDateTimeComposite.Location = New System.Drawing.Point(703, 81)
        Me.LabelDateTimeComposite.Name = "LabelDateTimeComposite"
        Me.LabelDateTimeComposite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelDateTimeComposite.Size = New System.Drawing.Size(138, 23)
        Me.LabelDateTimeComposite.TabIndex = 59
        Me.LabelDateTimeComposite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadStatusTitle
        '
        Me.LabelLoadStatusTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLoadStatusTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadStatusTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadStatusTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadStatusTitle.Location = New System.Drawing.Point(847, 81)
        Me.LabelLoadStatusTitle.Name = "LabelLoadStatusTitle"
        Me.LabelLoadStatusTitle.Size = New System.Drawing.Size(69, 23)
        Me.LabelLoadStatusTitle.TabIndex = 58
        Me.LabelLoadStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadSourceTitle
        '
        Me.LabelLoadSourceTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLoadSourceTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadSourceTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadSourceTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadSourceTitle.Location = New System.Drawing.Point(522, 81)
        Me.LabelLoadSourceTitle.Name = "LabelLoadSourceTitle"
        Me.LabelLoadSourceTitle.Size = New System.Drawing.Size(184, 23)
        Me.LabelLoadSourceTitle.TabIndex = 60
        Me.LabelLoadSourceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStrBarName
        '
        Me.LabelStrBarName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStrBarName.BackColor = System.Drawing.Color.Transparent
        Me.LabelStrBarName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelStrBarName.ForeColor = System.Drawing.Color.Black
        Me.LabelStrBarName.Location = New System.Drawing.Point(318, 81)
        Me.LabelStrBarName.Name = "LabelStrBarName"
        Me.LabelStrBarName.Size = New System.Drawing.Size(198, 23)
        Me.LabelStrBarName.TabIndex = 61
        Me.LabelStrBarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStrAddress
        '
        Me.LabelStrAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStrAddress.BackColor = System.Drawing.Color.Transparent
        Me.LabelStrAddress.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelStrAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelStrAddress.Location = New System.Drawing.Point(210, 81)
        Me.LabelStrAddress.Name = "LabelStrAddress"
        Me.LabelStrAddress.Size = New System.Drawing.Size(110, 23)
        Me.LabelStrAddress.TabIndex = 62
        Me.LabelStrAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadAllocationNotOK
        '
        Me.LabelLoadAllocationNotOK.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadAllocationNotOK.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadAllocationNotOK.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadAllocationNotOK.Location = New System.Drawing.Point(113, 81)
        Me.LabelLoadAllocationNotOK.Name = "LabelLoadAllocationNotOK"
        Me.LabelLoadAllocationNotOK.Size = New System.Drawing.Size(93, 23)
        Me.LabelLoadAllocationNotOK.TabIndex = 63
        Me.LabelLoadAllocationNotOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelUserName
        '
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelUserName.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelUserName.Location = New System.Drawing.Point(3, 81)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(101, 23)
        Me.LabelUserName.TabIndex = 64
        Me.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlAccounting
        '
        Me.PnlAccounting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAccounting.Location = New System.Drawing.Point(10, 107)
        Me.PnlAccounting.Name = "PnlAccounting"
        Me.PnlAccounting.Size = New System.Drawing.Size(903, 253)
        Me.PnlAccounting.TabIndex = 65
        '
        'OrderingOptionTonaj
        '
        Me.OrderingOptionTonaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderingOptionTonaj.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OrderingOptionTonaj.ForeColor = System.Drawing.Color.DarkGray
        Me.OrderingOptionTonaj.Location = New System.Drawing.Point(498, -6)
        Me.OrderingOptionTonaj.Name = "OrderingOptionTonaj"
        Me.OrderingOptionTonaj.Size = New System.Drawing.Size(49, 23)
        Me.OrderingOptionTonaj.TabIndex = 64
        Me.OrderingOptionTonaj.Text = "تناژ"
        Me.OrderingOptionTonaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelnTonaj
        '
        Me.LabelnTonaj.BackColor = System.Drawing.Color.Transparent
        Me.LabelnTonaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelnTonaj.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelnTonaj.ForeColor = System.Drawing.Color.Red
        Me.LabelnTonaj.Location = New System.Drawing.Point(498, 15)
        Me.LabelnTonaj.Name = "LabelnTonaj"
        Me.LabelnTonaj.Size = New System.Drawing.Size(49, 23)
        Me.LabelnTonaj.TabIndex = 65
        Me.LabelnTonaj.Text = "27.5"
        Me.LabelnTonaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCViewerNSSLoadCapacitorLoadExtended
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSLoadCapacitorLoadExtended"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(949, 83)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlOutter.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.PnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlOutter As System.Windows.Forms.Panel
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents PnlTop As System.Windows.Forms.Panel
    Friend WithEvents OrderingOptionAddress As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionProductReciever As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionLoadStatus As System.Windows.Forms.Label
    Friend WithEvents OrderingOptiondTimeElam As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionLoaderType As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionTransportPrice As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionnCarNumKol As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionTargetCity As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionProduct As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionTransportCompany As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionnEstelamId As System.Windows.Forms.Label
    Friend WithEvents OrderingOptionUser As System.Windows.Forms.Label
    Friend WithEvents UcMinimizeMaximize As R2CoreGUI.UCMinimizeMaximize
    Friend WithEvents LabelnEstelamId As Label
    Friend WithEvents LabelStrDescription As Label
    Friend WithEvents LabelTransportCompanyTitle As Label
    Friend WithEvents LabelGoodTitle As Label
    Friend WithEvents LabelLoadTargetTitle As Label
    Friend WithEvents LabelnCarNumKol As Label
    Friend WithEvents LabelTransportPrice As Label
    Friend WithEvents LabelLoaderTypeTitle As Label
    Friend WithEvents LabelnCarNum As Label
    Friend WithEvents LabelDateTimeComposite As Label
    Friend WithEvents LabelLoadStatusTitle As Label
    Friend WithEvents LabelLoadSourceTitle As Label
    Friend WithEvents LabelStrBarName As Label
    Friend WithEvents LabelStrAddress As Label
    Friend WithEvents LabelLoadAllocationNotOK As Label
    Friend WithEvents LabelUserName As Label
    Friend WithEvents PnlAccounting As Panel
    Friend WithEvents LabelnTonaj As Label
    Friend WithEvents OrderingOptionTonaj As Label
End Class
