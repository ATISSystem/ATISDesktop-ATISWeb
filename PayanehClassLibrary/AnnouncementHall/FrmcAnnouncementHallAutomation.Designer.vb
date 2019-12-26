Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcAnnouncementHallAutomation
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.PnlSodoorAndPrintNobatRequest = New System.Windows.Forms.Panel()
        Me.UcComputerMessageProducerSodoorNobat = New PayanehClassLibrary.UCComputerMessageProducerRealTimeTurnRegisterRequest()
        Me.UcComputerMessageProducerPrintNobat = New PayanehClassLibrary.UCComputerMessageProducerTurnPrintRequest()
        Me.PnlTurnResuscitationCancellation = New System.Windows.Forms.Panel()
        Me.UcViewerTankTreiler = New PayanehClassLibrary.UCViewerTankTreiler()
        Me.UcCarEnterExitStatus = New R2CoreParkingSystem.UCCarEnterExitStatus()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcCarAndDriverPresenter = New R2CoreParkingSystem.UCCarAndDriverPresenter()
        Me.UcucCarTruckNobatCollection = New PayanehClassLibrary.UCUCCarTruckNobatCollection()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.PnlTurnsCancellation = New System.Windows.Forms.Panel()
        Me.UcLabel5 = New R2CoreGUI.UCLabel()
        Me.UcLstViewerAllOfnEnterExitId = New PayanehClassLibrary.UCLstViewerAllOfnEnterExitId()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcButtonTurnsCancellation = New R2CoreGUI.UCButton()
        Me.PnlEnterExitReport = New System.Windows.Forms.Panel()
        Me.UcucEnterExitCollection = New R2CoreParkingSystem.UCUCEnterExitCollection()
        Me.PnlSediment = New System.Windows.Forms.Panel()
        Me.UcResuscitationSedimentedLoadbynEstelamId = New PayanehClassLibrary.UCResuscitationSedimentedLoadbynEstelamId()
        Me.UcSedimentalLoadControlPanel = New PayanehClassLibrary.UCSedimentalLoadControlPanel()
        Me.PNLTWS = New System.Windows.Forms.Panel()
        Me.UctwsReport = New PayanehClassLibrary.UCTWSReport()
        Me.PnlSodoorAndPrintNobatRequest.SuspendLayout
        Me.PnlTurnResuscitationCancellation.SuspendLayout
        Me.PnlTurnsCancellation.SuspendLayout
        Me.PnlEnterExitReport.SuspendLayout
        Me.PnlSediment.SuspendLayout
        Me.PNLTWS.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlSodoorAndPrintNobatRequest
        '
        Me.PnlSodoorAndPrintNobatRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSodoorAndPrintNobatRequest.BackColor = System.Drawing.Color.Transparent
        Me.PnlSodoorAndPrintNobatRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSodoorAndPrintNobatRequest.Controls.Add(Me.UcComputerMessageProducerSodoorNobat)
        Me.PnlSodoorAndPrintNobatRequest.Controls.Add(Me.UcComputerMessageProducerPrintNobat)
        Me.PnlSodoorAndPrintNobatRequest.Location = New System.Drawing.Point(5, 50)
        Me.PnlSodoorAndPrintNobatRequest.Name = "PnlSodoorAndPrintNobatRequest"
        Me.PnlSodoorAndPrintNobatRequest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlSodoorAndPrintNobatRequest.Size = New System.Drawing.Size(995, 512)
        Me.PnlSodoorAndPrintNobatRequest.TabIndex = 201
        '
        'UcComputerMessageProducerSodoorNobat
        '
        Me.UcComputerMessageProducerSodoorNobat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerSodoorNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerSodoorNobat.Location = New System.Drawing.Point(32, -4)
        Me.UcComputerMessageProducerSodoorNobat.Name = "UcComputerMessageProducerSodoorNobat"
        Me.UcComputerMessageProducerSodoorNobat.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerSodoorNobat.Size = New System.Drawing.Size(919, 267)
        Me.UcComputerMessageProducerSodoorNobat.TabIndex = 2
        Me.UcComputerMessageProducerSodoorNobat.UCCMNote = ""
        Me.UcComputerMessageProducerSodoorNobat.UCTitle =""
        Me.UcComputerMessageProducerSodoorNobat.UCSendIsActive = false
        '
        'UcComputerMessageProducerPrintNobat
        '
        Me.UcComputerMessageProducerPrintNobat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerPrintNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerPrintNobat.Location = New System.Drawing.Point(30, 249)
        Me.UcComputerMessageProducerPrintNobat.Name = "UcComputerMessageProducerPrintNobat"
        Me.UcComputerMessageProducerPrintNobat.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerPrintNobat.Size = New System.Drawing.Size(921, 265)
        Me.UcComputerMessageProducerPrintNobat.TabIndex = 1
        Me.UcComputerMessageProducerPrintNobat.UCCMNote = ""
        Me.UcComputerMessageProducerPrintNobat.UCtitle = ""
        Me.UcComputerMessageProducerPrintNobat.UCSendIsActive = false
        '
        'PnlTurnResuscitationCancellation
        '
        Me.PnlTurnResuscitationCancellation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTurnResuscitationCancellation.BackColor = System.Drawing.Color.Transparent
        Me.PnlTurnResuscitationCancellation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTurnResuscitationCancellation.Controls.Add(Me.UcViewerTankTreiler)
        Me.PnlTurnResuscitationCancellation.Controls.Add(Me.UcCarEnterExitStatus)
        Me.PnlTurnResuscitationCancellation.Controls.Add(Me.UcMoneyWallet)
        Me.PnlTurnResuscitationCancellation.Controls.Add(Me.UcCarAndDriverPresenter)
        Me.PnlTurnResuscitationCancellation.Controls.Add(Me.UcucCarTruckNobatCollection)
        Me.PnlTurnResuscitationCancellation.Controls.Add(Me.UcCar)
        Me.PnlTurnResuscitationCancellation.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PnlTurnResuscitationCancellation.Location = New System.Drawing.Point(5, 50)
        Me.PnlTurnResuscitationCancellation.Name = "PnlTurnResuscitationCancellation"
        Me.PnlTurnResuscitationCancellation.Size = New System.Drawing.Size(995, 512)
        Me.PnlTurnResuscitationCancellation.TabIndex = 202
        '
        'UcViewerTankTreiler
        '
        Me.UcViewerTankTreiler.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerTankTreiler.Location = New System.Drawing.Point(145, 97)
        Me.UcViewerTankTreiler.Name = "UcViewerTankTreiler"
        Me.UcViewerTankTreiler.Padding = New System.Windows.Forms.Padding(5)
        Me.UcViewerTankTreiler.Size = New System.Drawing.Size(242, 59)
        Me.UcViewerTankTreiler.TabIndex = 8
        Me.UcViewerTankTreiler.UCNSSCurrentCarTruck = Nothing
        '
        'UcCarEnterExitStatus
        '
        Me.UcCarEnterExitStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarEnterExitStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcCarEnterExitStatus.Location = New System.Drawing.Point(589, 96)
        Me.UcCarEnterExitStatus.Name = "UcCarEnterExitStatus"
        Me.UcCarEnterExitStatus.Padding = New System.Windows.Forms.Padding(10)
        Me.UcCarEnterExitStatus.Size = New System.Drawing.Size(189, 60)
        Me.UcCarEnterExitStatus.TabIndex = 7
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(775, 243)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(211, 262)
        Me.UcMoneyWallet.TabIndex = 5
        '
        'UcCarAndDriverPresenter
        '
        Me.UcCarAndDriverPresenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarAndDriverPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcCarAndDriverPresenter.Location = New System.Drawing.Point(775, 1)
        Me.UcCarAndDriverPresenter.Name = "UcCarAndDriverPresenter"
        Me.UcCarAndDriverPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarAndDriverPresenter.Size = New System.Drawing.Size(211, 236)
        Me.UcCarAndDriverPresenter.TabIndex = 4
        '
        'UcucCarTruckNobatCollection
        '
        Me.UcucCarTruckNobatCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucCarTruckNobatCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucCarTruckNobatCollection.Location = New System.Drawing.Point(3, 166)
        Me.UcucCarTruckNobatCollection.Name = "UcucCarTruckNobatCollection"
        Me.UcucCarTruckNobatCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucCarTruckNobatCollection.Size = New System.Drawing.Size(768, 346)
        Me.UcucCarTruckNobatCollection.TabIndex = 3
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(144, 1)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(629, 88)
        Me.UcCar.TabIndex = 0
        Me.UcCar.UCViewButtons = false
        '
        'PnlTurnsCancellation
        '
        Me.PnlTurnsCancellation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTurnsCancellation.BackColor = System.Drawing.Color.Transparent
        Me.PnlTurnsCancellation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTurnsCancellation.Controls.Add(Me.UcLabel5)
        Me.PnlTurnsCancellation.Controls.Add(Me.UcLstViewerAllOfnEnterExitId)
        Me.PnlTurnsCancellation.Controls.Add(Me.UcLabel2)
        Me.PnlTurnsCancellation.Controls.Add(Me.UcLabel1)
        Me.PnlTurnsCancellation.Controls.Add(Me.UcButtonTurnsCancellation)
        Me.PnlTurnsCancellation.Location = New System.Drawing.Point(5, 50)
        Me.PnlTurnsCancellation.Name = "PnlTurnsCancellation"
        Me.PnlTurnsCancellation.Size = New System.Drawing.Size(995, 512)
        Me.PnlTurnsCancellation.TabIndex = 203
        '
        'UcLabel5
        '
        Me.UcLabel5._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel5._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(667, 8)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(297, 47)
        Me.UcLabel5.TabIndex = 11
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "ابطال گروهی نوبت ها"
        '
        'UcLstViewerAllOfnEnterExitId
        '
        Me.UcLstViewerAllOfnEnterExitId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLstViewerAllOfnEnterExitId.BackColor = System.Drawing.Color.Transparent
        Me.UcLstViewerAllOfnEnterExitId.Location = New System.Drawing.Point(10, 127)
        Me.UcLstViewerAllOfnEnterExitId.Name = "UcLstViewerAllOfnEnterExitId"
        Me.UcLstViewerAllOfnEnterExitId.Padding = New System.Windows.Forms.Padding(10)
        Me.UcLstViewerAllOfnEnterExitId.Size = New System.Drawing.Size(973, 306)
        Me.UcLstViewerAllOfnEnterExitId.TabIndex = 6
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(461, 89)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(471, 32)
        Me.UcLabel2.TabIndex = 5
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel2.UCValue = "(دقت کنید که کلیه نوبت های کمتر از اعتبار (و شامل اعتبار) باطل می گردند)"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(632, 61)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(297, 32)
        Me.UcLabel1.TabIndex = 3
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "شماره نوبت اعتبار را از لیست انتخاب نمایید"
        '
        'UcButtonTurnsCancellation
        '
        Me.UcButtonTurnsCancellation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonTurnsCancellation.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonTurnsCancellation.Location = New System.Drawing.Point(437, 429)
        Me.UcButtonTurnsCancellation.Name = "UcButtonTurnsCancellation"
        Me.UcButtonTurnsCancellation.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonTurnsCancellation.Size = New System.Drawing.Size(118, 49)
        Me.UcButtonTurnsCancellation.TabIndex = 1
        Me.UcButtonTurnsCancellation.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonTurnsCancellation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonTurnsCancellation.UCEnable = true
        Me.UcButtonTurnsCancellation.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonTurnsCancellation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonTurnsCancellation.UCValue = "ابطال گروهی"
        '
        'PnlEnterExitReport
        '
        Me.PnlEnterExitReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlEnterExitReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlEnterExitReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlEnterExitReport.Controls.Add(Me.UcucEnterExitCollection)
        Me.PnlEnterExitReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlEnterExitReport.Name = "PnlEnterExitReport"
        Me.PnlEnterExitReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlEnterExitReport.TabIndex = 345
        '
        'UcucEnterExitCollection
        '
        Me.UcucEnterExitCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucEnterExitCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucEnterExitCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcucEnterExitCollection.Name = "UcucEnterExitCollection"
        Me.UcucEnterExitCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucEnterExitCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcucEnterExitCollection.TabIndex = 0
        '
        'PnlSediment
        '
        Me.PnlSediment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSediment.BackColor = System.Drawing.Color.Transparent
        Me.PnlSediment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSediment.Controls.Add(Me.UcResuscitationSedimentedLoadbynEstelamId)
        Me.PnlSediment.Controls.Add(Me.UcSedimentalLoadControlPanel)
        Me.PnlSediment.Location = New System.Drawing.Point(5, 50)
        Me.PnlSediment.Name = "PnlSediment"
        Me.PnlSediment.Size = New System.Drawing.Size(995, 512)
        Me.PnlSediment.TabIndex = 346
        '
        'UcResuscitationSedimentedLoadbynEstelamId
        '
        Me.UcResuscitationSedimentedLoadbynEstelamId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcResuscitationSedimentedLoadbynEstelamId.BackColor = System.Drawing.Color.Transparent
        Me.UcResuscitationSedimentedLoadbynEstelamId.Location = New System.Drawing.Point(90, 406)
        Me.UcResuscitationSedimentedLoadbynEstelamId.Name = "UcResuscitationSedimentedLoadbynEstelamId"
        Me.UcResuscitationSedimentedLoadbynEstelamId.Size = New System.Drawing.Size(809, 103)
        Me.UcResuscitationSedimentedLoadbynEstelamId.TabIndex = 1
        '
        'UcSedimentalLoadControlPanel
        '
        Me.UcSedimentalLoadControlPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSedimentalLoadControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.UcSedimentalLoadControlPanel.Location = New System.Drawing.Point(83, -3)
        Me.UcSedimentalLoadControlPanel.Name = "UcSedimentalLoadControlPanel"
        Me.UcSedimentalLoadControlPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.UcSedimentalLoadControlPanel.Size = New System.Drawing.Size(826, 416)
        Me.UcSedimentalLoadControlPanel.TabIndex = 0
        '
        'PNLTWS
        '
        Me.PNLTWS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PNLTWS.BackColor = System.Drawing.Color.Transparent
        Me.PNLTWS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNLTWS.Controls.Add(Me.UctwsReport)
        Me.PNLTWS.Location = New System.Drawing.Point(5, 50)
        Me.PNLTWS.Name = "PNLTWS"
        Me.PNLTWS.Size = New System.Drawing.Size(995, 512)
        Me.PNLTWS.TabIndex = 348
        '
        'UctwsReport
        '
        Me.UctwsReport.BackColor = System.Drawing.Color.Transparent
        Me.UctwsReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UctwsReport.Location = New System.Drawing.Point(0, 0)
        Me.UctwsReport.Name = "UctwsReport"
        Me.UctwsReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UctwsReport.Size = New System.Drawing.Size(993, 510)
        Me.UctwsReport.TabIndex = 0
        '
        'FrmcAnnouncementHallAutomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTurnResuscitationCancellation)
        Me.Controls.Add(Me.PnlSodoorAndPrintNobatRequest)
        Me.Controls.Add(Me.PnlEnterExitReport)
        Me.Controls.Add(Me.PNLTWS)
        Me.Controls.Add(Me.PnlSediment)
        Me.Controls.Add(Me.PnlTurnsCancellation)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcAnnouncementHallAutomation"
        Me.Text = "FrmcAnnouncementHallAutomation"
        Me.Controls.SetChildIndex(Me.PnlTurnsCancellation, 0)
        Me.Controls.SetChildIndex(Me.PnlSediment, 0)
        Me.Controls.SetChildIndex(Me.PNLTWS, 0)
        Me.Controls.SetChildIndex(Me.PnlEnterExitReport, 0)
        Me.Controls.SetChildIndex(Me.PnlSodoorAndPrintNobatRequest, 0)
        Me.Controls.SetChildIndex(Me.PnlTurnResuscitationCancellation, 0)
        Me.PnlSodoorAndPrintNobatRequest.ResumeLayout(false)
        Me.PnlTurnResuscitationCancellation.ResumeLayout(false)
        Me.PnlTurnsCancellation.ResumeLayout(false)
        Me.PnlEnterExitReport.ResumeLayout(false)
        Me.PnlSediment.ResumeLayout(false)
        Me.PNLTWS.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlSodoorAndPrintNobatRequest As System.Windows.Forms.Panel
    Friend WithEvents UcComputerMessageProducerPrintNobat As UCComputerMessageProducerTurnPrintRequest
    Friend WithEvents UcComputerMessageProducerSodoorNobat As UCComputerMessageProducerRealTimeTurnRegisterRequest
    Friend WithEvents PnlTurnResuscitationCancellation As System.Windows.Forms.Panel
    Friend WithEvents UcCar As R2CoreParkingSystem.UCCar
    Friend WithEvents UcucCarTruckNobatCollection As UCUCCarTruckNobatCollection
    Friend WithEvents UcMoneyWallet As R2CoreParkingSystem.UCMoneyWallet
    Friend WithEvents UcCarAndDriverPresenter As R2CoreParkingSystem.UCCarAndDriverPresenter
    Friend WithEvents UcCarEnterExitStatus As R2CoreParkingSystem.UCCarEnterExitStatus
    Friend WithEvents PnlTurnsCancellation As System.Windows.Forms.Panel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcButtonTurnsCancellation As UCButton
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLstViewerAllOfnEnterExitId As UCLstViewerAllOfnEnterExitId
    Friend WithEvents PnlEnterExitReport As System.Windows.Forms.Panel
    Friend WithEvents UcucEnterExitCollection As R2CoreParkingSystem.UCUCEnterExitCollection
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents PnlSediment As System.Windows.Forms.Panel
    Friend WithEvents PNLTWS As System.Windows.Forms.Panel
    Friend WithEvents UctwsReport As UCTWSReport
    Friend WithEvents UcSedimentalLoadControlPanel As UCSedimentalLoadControlPanel
    Friend WithEvents UcResuscitationSedimentedLoadbynEstelamId As UCResuscitationSedimentedLoadbynEstelamId
    Friend WithEvents UcViewerTankTreiler As UCViewerTankTreiler
End Class
