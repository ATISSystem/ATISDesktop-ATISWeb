Imports R2CoreGUI
Imports R2CoreParkingSystem

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcEnterExit
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
        Me.PnlEnterExit = New System.Windows.Forms.Panel()
        Me.UcBlackListCompositBlackListViewer = New R2CoreParkingSystem.UCBlackListCompositBlackListViewer()
        Me.UcCarPresenter = New R2CoreParkingSystem.UCCarPresenter()
        Me.UCReserveTurnRegisterRequest = New PayanehClassLibrary.UCReserveTurnRegisterRequest()
        Me.UcTerafficCardPresenter = New R2CoreParkingSystem.UCTerafficCardPresenter()
        Me.UcTurnRegisterRequestConfirmation = New PayanehClassLibrary.UCTurnRegisterRequestConfirmation()
        Me.UcCarTruckUpdateInf = New PayanehClassLibrary.UcCarTruckUpdateInf()
        Me.UcCarAndTrafficCard = New R2CoreParkingSystem.UCCarAndTerafficCard()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.UcMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge()
        Me.PnlMoneyWalletChargeSavabegh = New System.Windows.Forms.Panel()
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh = New R2CoreParkingSystem.UCTerafficCardPresenter()
        Me.UcMoneyWalletChargeSavabeghCollection = New R2CoreParkingSystem.UCMoneyWalletChargeSavabeghCollection()
        Me.PnlUserChargeSavabegh = New System.Windows.Forms.Panel()
        Me.UcUserChargeSavabeghCollection = New R2CoreParkingSystem.UCUserChargeSavabeghCollection()
        Me.PnlAccounting = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.PnlEnterExitReport = New System.Windows.Forms.Panel()
        Me.UcucEnterExitCollection = New R2CoreParkingSystem.UCUCEnterExitCollection()
        Me.PnlMoneyWalletCharge = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletChargeSavabeghCollection()
        Me.UcMoneyWalletChargePnlMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge()
        Me.PnlEnterExit.SuspendLayout
        Me.PnlMoneyWalletChargeSavabegh.SuspendLayout
        Me.PnlUserChargeSavabegh.SuspendLayout
        Me.PnlAccounting.SuspendLayout
        Me.PnlEnterExitReport.SuspendLayout
        Me.PnlMoneyWalletCharge.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlEnterExit
        '
        Me.PnlEnterExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlEnterExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlEnterExit.Controls.Add(Me.UcBlackListCompositBlackListViewer)
        Me.PnlEnterExit.Controls.Add(Me.UcCarTruckUpdateInf)
        Me.PnlEnterExit.Controls.Add(Me.UcCarPresenter)
        Me.PnlEnterExit.Controls.Add(Me.UCReserveTurnRegisterRequest)
        Me.PnlEnterExit.Controls.Add(Me.UcTerafficCardPresenter)
        Me.PnlEnterExit.Controls.Add(Me.UcTurnRegisterRequestConfirmation)
        Me.PnlEnterExit.Controls.Add(Me.UcCarAndTrafficCard)
        Me.PnlEnterExit.Controls.Add(Me.UcMoneyWallet)
        Me.PnlEnterExit.Controls.Add(Me.UcCarImage)
        Me.PnlEnterExit.Controls.Add(Me.UcMoneyWalletCharge)
        Me.PnlEnterExit.Location = New System.Drawing.Point(5, 50)
        Me.PnlEnterExit.Name = "PnlEnterExit"
        Me.PnlEnterExit.Size = New System.Drawing.Size(995, 512)
        Me.PnlEnterExit.TabIndex = 200
        '
        'UcCarTruckUpdateInf
        '
        Me.UcCarTruckUpdateInf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruckUpdateInf.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruckUpdateInf.Location = New System.Drawing.Point(15, 126)
        Me.UcCarTruckUpdateInf.Name = "UcCarTruckUpdateInf"
        Me.UcCarTruckUpdateInf.Size = New System.Drawing.Size(726, 261)
        Me.UcCarTruckUpdateInf.TabIndex = 0
        Me.UcCarTruckUpdateInf.Visible = false
        '
        'UcBlackListCompositBlackListViewer
        '
        Me.UcBlackListCompositBlackListViewer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                                              Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBlackListCompositBlackListViewer.BackColor = System.Drawing.Color.Transparent
        Me.UcBlackListCompositBlackListViewer.Location = New System.Drawing.Point(15, 126)
        Me.UcBlackListCompositBlackListViewer.Name = "UcBlackListCompositBlackListViewer"
        Me.UcBlackListCompositBlackListViewer.Padding = New System.Windows.Forms.Padding(5)
        Me.UcBlackListCompositBlackListViewer.Size = New System.Drawing.Size(726, 125)
        Me.UcBlackListCompositBlackListViewer.TabIndex = 345
        Me.UcBlackListCompositBlackListViewer.Visible = False
        '
        'UcCarPresenter
        '
        Me.UcCarPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcCarPresenter.Location = New System.Drawing.Point(13, 11)
        Me.UcCarPresenter.Name = "UcCarPresenter"
        Me.UcCarPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarPresenter.Size = New System.Drawing.Size(410, 74)
        Me.UcCarPresenter.TabIndex = 343
        '
        'UCReserveTurnRegisterRequest
        '
        Me.UCReserveTurnRegisterRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UCReserveTurnRegisterRequest.BackColor = System.Drawing.Color.Transparent
        Me.UCReserveTurnRegisterRequest.Location = New System.Drawing.Point(13, 120)
        Me.UCReserveTurnRegisterRequest.Name = "UCReserveTurnRegisterRequest"
        Me.UCReserveTurnRegisterRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.UCReserveTurnRegisterRequest.Size = New System.Drawing.Size(133, 40)
        Me.UCReserveTurnRegisterRequest.TabIndex = 380
        '
        'UcTerafficCardPresenter
        '
        Me.UcTerafficCardPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcTerafficCardPresenter.Location = New System.Drawing.Point(13, 74)
        Me.UcTerafficCardPresenter.Name = "UcTerafficCardPresenter"
        Me.UcTerafficCardPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTerafficCardPresenter.Size = New System.Drawing.Size(293, 50)
        Me.UcTerafficCardPresenter.TabIndex = 342
        '
        'UcTurnRegisterRequestConfirmation
        '
        Me.UcTurnRegisterRequestConfirmation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTurnRegisterRequestConfirmation.BackColor = System.Drawing.Color.Transparent
        Me.UcTurnRegisterRequestConfirmation.Location = New System.Drawing.Point(507, 21)
        Me.UcTurnRegisterRequestConfirmation.Name = "UcTurnRegisterRequestConfirmation"
        Me.UcTurnRegisterRequestConfirmation.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTurnRegisterRequestConfirmation.Size = New System.Drawing.Size(232, 62)
        Me.UcTurnRegisterRequestConfirmation.TabIndex = 341
        Me.UcTurnRegisterRequestConfirmation.UCChkTruckNobat = True
        '
        'UcCarAndTrafficCard
        '
        Me.UcCarAndTrafficCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarAndTrafficCard.BackColor = System.Drawing.Color.Transparent
        Me.UcCarAndTrafficCard.Location = New System.Drawing.Point(757, 275)
        Me.UcCarAndTrafficCard.Name = "UcCarAndTrafficCard"
        Me.UcCarAndTrafficCard.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarAndTrafficCard.Size = New System.Drawing.Size(230, 232)
        Me.UcCarAndTrafficCard.TabIndex = 339
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(757, 3)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(229, 272)
        Me.UcMoneyWallet.TabIndex = 338
        '
        'UcCarImage
        '
        Me.UcCarImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarImage.BackColor = System.Drawing.Color.Transparent
        Me.UcCarImage.Location = New System.Drawing.Point(3, 3)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(748, 504)
        Me.UcCarImage.TabIndex = 344
        '
        'UcMoneyWalletCharge
        '
        Me.UcMoneyWalletCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletCharge.Location = New System.Drawing.Point(34, 142)
        Me.UcMoneyWalletCharge.Name = "UcMoneyWalletCharge"
        Me.UcMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletCharge.Size = New System.Drawing.Size(690, 350)
        Me.UcMoneyWalletCharge.TabIndex = 340
        Me.UcMoneyWalletCharge.UCConfigurationIndex = CType(0, Long)
        Me.UcMoneyWalletCharge.UCLocalPrintFlagforUCPrintBillan = False
        '
        'PnlMoneyWalletChargeSavabegh
        '
        Me.PnlMoneyWalletChargeSavabegh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletChargeSavabegh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletChargeSavabegh.Controls.Add(Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh)
        Me.PnlMoneyWalletChargeSavabegh.Controls.Add(Me.UcMoneyWalletChargeSavabeghCollection)
        Me.PnlMoneyWalletChargeSavabegh.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletChargeSavabegh.Name = "PnlMoneyWalletChargeSavabegh"
        Me.PnlMoneyWalletChargeSavabegh.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletChargeSavabegh.TabIndex = 341
        '
        'UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh
        '
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.BackColor = System.Drawing.Color.Transparent
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.Location = New System.Drawing.Point(612, 0)
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.Name = "UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh"
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.Size = New System.Drawing.Size(347, 58)
        Me.UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.TabIndex = 2
        '
        'UcMoneyWalletChargeSavabeghCollection
        '
        Me.UcMoneyWalletChargeSavabeghCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletChargeSavabeghCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletChargeSavabeghCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletChargeSavabeghCollection.Location = New System.Drawing.Point(30, 64)
        Me.UcMoneyWalletChargeSavabeghCollection.Name = "UcMoneyWalletChargeSavabeghCollection"
        Me.UcMoneyWalletChargeSavabeghCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletChargeSavabeghCollection.Size = New System.Drawing.Size(929, 429)
        Me.UcMoneyWalletChargeSavabeghCollection.TabIndex = 1
        '
        'PnlUserChargeSavabegh
        '
        Me.PnlUserChargeSavabegh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUserChargeSavabegh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUserChargeSavabegh.Controls.Add(Me.UcUserChargeSavabeghCollection)
        Me.PnlUserChargeSavabegh.Location = New System.Drawing.Point(5, 50)
        Me.PnlUserChargeSavabegh.Name = "PnlUserChargeSavabegh"
        Me.PnlUserChargeSavabegh.Size = New System.Drawing.Size(995, 512)
        Me.PnlUserChargeSavabegh.TabIndex = 342
        '
        'UcUserChargeSavabeghCollection
        '
        Me.UcUserChargeSavabeghCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcUserChargeSavabeghCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcUserChargeSavabeghCollection.Location = New System.Drawing.Point(30, 12)
        Me.UcUserChargeSavabeghCollection.Name = "UcUserChargeSavabeghCollection"
        Me.UcUserChargeSavabeghCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcUserChargeSavabeghCollection.Size = New System.Drawing.Size(942, 492)
        Me.UcUserChargeSavabeghCollection.TabIndex = 0
        '
        'PnlAccounting
        '
        Me.PnlAccounting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAccounting.Controls.Add(Me.UcAccountingCollection)
        Me.PnlAccounting.Location = New System.Drawing.Point(5, 50)
        Me.PnlAccounting.Name = "PnlAccounting"
        Me.PnlAccounting.Size = New System.Drawing.Size(995, 512)
        Me.PnlAccounting.TabIndex = 343
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Location = New System.Drawing.Point(5, 12)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(980, 499)
        Me.UcAccountingCollection.TabIndex = 0
        '
        'PnlEnterExitReport
        '
        Me.PnlEnterExitReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlEnterExitReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlEnterExitReport.Controls.Add(Me.UcucEnterExitCollection)
        Me.PnlEnterExitReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlEnterExitReport.Name = "PnlEnterExitReport"
        Me.PnlEnterExitReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlEnterExitReport.TabIndex = 344
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
        'PnlMoneyWalletCharge
        '
        Me.PnlMoneyWalletCharge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge)
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcMoneyWalletChargePnlMoneyWalletCharge)
        Me.PnlMoneyWalletCharge.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletCharge.Name = "PnlMoneyWalletCharge"
        Me.PnlMoneyWalletCharge.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletCharge.TabIndex = 345
        '
        'UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge
        '
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Location = New System.Drawing.Point(9, 349)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Name = "UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge"
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Size = New System.Drawing.Size(975, 158)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.TabIndex = 3
        '
        'UcMoneyWalletChargePnlMoneyWalletCharge
        '
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.Location = New System.Drawing.Point(9, 3)
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.Name = "UcMoneyWalletChargePnlMoneyWalletCharge"
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.Size = New System.Drawing.Size(975, 340)
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.TabIndex = 2
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.UCConfigurationIndex = CType(1, Long)
        Me.UcMoneyWalletChargePnlMoneyWalletCharge.UCLocalPrintFlagforUCPrintBillan = False
        '
        'FrmcEnterExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlEnterExit)
        Me.Controls.Add(Me.PnlEnterExitReport)
        Me.Controls.Add(Me.PnlUserChargeSavabegh)
        Me.Controls.Add(Me.PnlAccounting)
        Me.Controls.Add(Me.PnlMoneyWalletChargeSavabegh)
        Me.Controls.Add(Me.PnlMoneyWalletCharge)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcEnterExit"
        Me.Text = "FrmcEnterExit2"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletCharge, 0)
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletChargeSavabegh, 0)
        Me.Controls.SetChildIndex(Me.PnlAccounting, 0)
        Me.Controls.SetChildIndex(Me.PnlUserChargeSavabegh, 0)
        Me.Controls.SetChildIndex(Me.PnlEnterExitReport, 0)
        Me.Controls.SetChildIndex(Me.PnlEnterExit, 0)
        Me.PnlEnterExit.ResumeLayout(false)
        Me.PnlMoneyWalletChargeSavabegh.ResumeLayout(false)
        Me.PnlUserChargeSavabegh.ResumeLayout(false)
        Me.PnlAccounting.ResumeLayout(false)
        Me.PnlEnterExitReport.ResumeLayout(false)
        Me.PnlMoneyWalletCharge.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlEnterExit As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWallet As R2CoreParkingSystem.UCMoneyWallet
    Friend WithEvents UcCarAndTrafficCard As R2CoreParkingSystem.UCCarAndTerafficCard
    Friend WithEvents UcMoneyWalletCharge As UCMoneyWalletCharge
    Friend WithEvents PnlMoneyWalletChargeSavabegh As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletChargeSavabeghCollection As UCMoneyWalletChargeSavabeghCollection
    Friend WithEvents PnlUserChargeSavabegh As System.Windows.Forms.Panel
    Friend WithEvents UcUserChargeSavabeghCollection As UCUserChargeSavabeghCollection
    Friend WithEvents PnlAccounting As System.Windows.Forms.Panel
    Friend WithEvents UcAccountingCollection As UCAccountingCollection
    Friend WithEvents PnlEnterExitReport As System.Windows.Forms.Panel
    Friend WithEvents UcucEnterExitCollection As UCUCEnterExitCollection
    Friend WithEvents UcTurnRegisterRequestConfirmation As UCTurnRegisterRequestConfirmation
    Friend WithEvents UcTerafficCardPresenter As UCTerafficCardPresenter
    Friend WithEvents UcCarPresenter As UCCarPresenter
    Friend WithEvents UCReserveTurnRegisterRequest As UCReserveTurnRegisterRequest
    Friend WithEvents UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh As UCTerafficCardPresenter
    Friend WithEvents UcCarImage As UCCarImage
    Friend WithEvents PnlMoneyWalletCharge As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge As UCMoneyWalletChargeSavabeghCollection
    Friend WithEvents UcMoneyWalletChargePnlMoneyWalletCharge As UCMoneyWalletCharge
    Friend WithEvents UcBlackListCompositBlackListViewer As UCBlackListCompositBlackListViewer
    Friend WithEvents UcCarTruckUpdateInf As UcCarTruckUpdateInf
End Class
