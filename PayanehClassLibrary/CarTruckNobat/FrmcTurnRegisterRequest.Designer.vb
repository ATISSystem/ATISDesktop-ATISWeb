Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTurnRegisterRequest
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
        Me.PnlSodoorNobat = New System.Windows.Forms.Panel()
        Me.UcCarEnterExitStatus = New R2CoreParkingSystem.UCCarEnterExitStatus()
        Me.UcTerafficCardPresenter = New R2CoreParkingSystem.UCTerafficCardPresenter()
        Me.UcButtonSodoorNobat = New R2CoreGUI.UCButton()
        Me.UcucCarTruckNobatCollection = New PayanehClassLibrary.UCUCCarTruckNobatCollection()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcCarAndDriverPresenter = New R2CoreParkingSystem.UCCarAndDriverPresenter()
        Me.PnlTWS = New System.Windows.Forms.Panel()
        Me.UctwsReport = New PayanehClassLibrary.UCTWSReport()
        Me.PnlAccounting = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.PnlConsole = New System.Windows.Forms.Panel()
        Me.UcucLoggCollection = New R2CoreGUI.UCUCLogCollection()
        Me.PnlCarTruckTurns = New System.Windows.Forms.Panel()
        Me.UcCarImagePnlCarTruckTurns = New R2CoreParkingSystem.UCCarImage()
        Me.UcCarTruckPnlCarTruckTurns = New PayanehClassLibrary.UCCarTruck()
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns = New PayanehClassLibrary.UCUCCarTruckNobatCollection()
        Me.PnlSodoorNobat.SuspendLayout
        Me.PnlTWS.SuspendLayout
        Me.PnlAccounting.SuspendLayout
        Me.PnlConsole.SuspendLayout
        Me.PnlCarTruckTurns.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlSodoorNobat
        '
        Me.PnlSodoorNobat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSodoorNobat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSodoorNobat.Controls.Add(Me.UcCarEnterExitStatus)
        Me.PnlSodoorNobat.Controls.Add(Me.UcTerafficCardPresenter)
        Me.PnlSodoorNobat.Controls.Add(Me.UcButtonSodoorNobat)
        Me.PnlSodoorNobat.Controls.Add(Me.UcucCarTruckNobatCollection)
        Me.PnlSodoorNobat.Controls.Add(Me.UcMoneyWallet)
        Me.PnlSodoorNobat.Controls.Add(Me.UcCarAndDriverPresenter)
        Me.PnlSodoorNobat.Location = New System.Drawing.Point(5, 50)
        Me.PnlSodoorNobat.Name = "PnlSodoorNobat"
        Me.PnlSodoorNobat.Size = New System.Drawing.Size(995, 512)
        Me.PnlSodoorNobat.TabIndex = 200
        '
        'UcCarEnterExitStatus
        '
        Me.UcCarEnterExitStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcCarEnterExitStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcCarEnterExitStatus.Location = New System.Drawing.Point(325, 385)
        Me.UcCarEnterExitStatus.Name = "UcCarEnterExitStatus"
        Me.UcCarEnterExitStatus.Padding = New System.Windows.Forms.Padding(10)
        Me.UcCarEnterExitStatus.Size = New System.Drawing.Size(189, 60)
        Me.UcCarEnterExitStatus.TabIndex = 6
        '
        'UcTerafficCardPresenter
        '
        Me.UcTerafficCardPresenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcTerafficCardPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcTerafficCardPresenter.Location = New System.Drawing.Point(325, 451)
        Me.UcTerafficCardPresenter.Name = "UcTerafficCardPresenter"
        Me.UcTerafficCardPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTerafficCardPresenter.Size = New System.Drawing.Size(331, 58)
        Me.UcTerafficCardPresenter.TabIndex = 5
        '
        'UcButtonSodoorNobat
        '
        Me.UcButtonSodoorNobat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSodoorNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSodoorNobat.Location = New System.Drawing.Point(5, 392)
        Me.UcButtonSodoorNobat.Name = "UcButtonSodoorNobat"
        Me.UcButtonSodoorNobat.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonSodoorNobat.Size = New System.Drawing.Size(88, 115)
        Me.UcButtonSodoorNobat.TabIndex = 4
        Me.UcButtonSodoorNobat.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonSodoorNobat.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSodoorNobat.UCEnable = true
        Me.UcButtonSodoorNobat.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSodoorNobat.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSodoorNobat.UCValue = "صدور نوبت"
        '
        'UcucCarTruckNobatCollection
        '
        Me.UcucCarTruckNobatCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucCarTruckNobatCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucCarTruckNobatCollection.Location = New System.Drawing.Point(5, 3)
        Me.UcucCarTruckNobatCollection.Name = "UcucCarTruckNobatCollection"
        Me.UcucCarTruckNobatCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucCarTruckNobatCollection.Size = New System.Drawing.Size(768, 383)
        Me.UcucCarTruckNobatCollection.TabIndex = 2
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(779, 245)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(211, 262)
        Me.UcMoneyWallet.TabIndex = 1
        '
        'UcCarAndDriverPresenter
        '
        Me.UcCarAndDriverPresenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarAndDriverPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcCarAndDriverPresenter.Location = New System.Drawing.Point(779, 3)
        Me.UcCarAndDriverPresenter.Name = "UcCarAndDriverPresenter"
        Me.UcCarAndDriverPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarAndDriverPresenter.Size = New System.Drawing.Size(211, 236)
        Me.UcCarAndDriverPresenter.TabIndex = 0
        '
        'PnlTWS
        '
        Me.PnlTWS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTWS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTWS.Controls.Add(Me.UctwsReport)
        Me.PnlTWS.Location = New System.Drawing.Point(5, 50)
        Me.PnlTWS.Name = "PnlTWS"
        Me.PnlTWS.Size = New System.Drawing.Size(995, 512)
        Me.PnlTWS.TabIndex = 201
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
        'PnlAccounting
        '
        Me.PnlAccounting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAccounting.Controls.Add(Me.UcAccountingCollection)
        Me.PnlAccounting.Location = New System.Drawing.Point(5, 50)
        Me.PnlAccounting.Name = "PnlAccounting"
        Me.PnlAccounting.Size = New System.Drawing.Size(995, 512)
        Me.PnlAccounting.TabIndex = 6
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountingCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcAccountingCollection.TabIndex = 1
        '
        'PnlConsole
        '
        Me.PnlConsole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlConsole.Controls.Add(Me.UcucLoggCollection)
        Me.PnlConsole.Location = New System.Drawing.Point(5, 50)
        Me.PnlConsole.Name = "PnlConsole"
        Me.PnlConsole.Size = New System.Drawing.Size(995, 512)
        Me.PnlConsole.TabIndex = 202
        '
        'UcucLoggCollection
        '
        Me.UcucLoggCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoggCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucLoggCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcucLoggCollection.Name = "UcucLoggCollection"
        Me.UcucLoggCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucLoggCollection.RecordCounttoView = CType(10,Short)
        Me.UcucLoggCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcucLoggCollection.TabIndex = 0
        '
        'PnlCarTruckTurns
        '
        Me.PnlCarTruckTurns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlCarTruckTurns.BackColor = System.Drawing.Color.Transparent
        Me.PnlCarTruckTurns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCarTruckTurns.Controls.Add(Me.UcCarImagePnlCarTruckTurns)
        Me.PnlCarTruckTurns.Controls.Add(Me.UcCarTruckPnlCarTruckTurns)
        Me.PnlCarTruckTurns.Controls.Add(Me.UcucCarTruckNobatCollectionPnlCarTruckTurns)
        Me.PnlCarTruckTurns.Location = New System.Drawing.Point(5, 50)
        Me.PnlCarTruckTurns.Name = "PnlCarTruckTurns"
        Me.PnlCarTruckTurns.Size = New System.Drawing.Size(995, 512)
        Me.PnlCarTruckTurns.TabIndex = 203
        '
        'UcCarImagePnlCarTruckTurns
        '
        Me.UcCarImagePnlCarTruckTurns.BackColor = System.Drawing.Color.White
        Me.UcCarImagePnlCarTruckTurns.Location = New System.Drawing.Point(9, 4)
        Me.UcCarImagePnlCarTruckTurns.Name = "UcCarImagePnlCarTruckTurns"
        Me.UcCarImagePnlCarTruckTurns.Size = New System.Drawing.Size(184, 148)
        Me.UcCarImagePnlCarTruckTurns.TabIndex = 2
        '
        'UcCarTruckPnlCarTruckTurns
        '
        Me.UcCarTruckPnlCarTruckTurns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarTruckPnlCarTruckTurns.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruckPnlCarTruckTurns.Location = New System.Drawing.Point(199, 2)
        Me.UcCarTruckPnlCarTruckTurns.Name = "UcCarTruckPnlCarTruckTurns"
        Me.UcCarTruckPnlCarTruckTurns.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruckPnlCarTruckTurns.Size = New System.Drawing.Size(788, 153)
        Me.UcCarTruckPnlCarTruckTurns.TabIndex = 1
        Me.UcCarTruckPnlCarTruckTurns.UCViewButtons = false
        '
        'UcucCarTruckNobatCollectionPnlCarTruckTurns
        '
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.BackColor = System.Drawing.Color.Transparent
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.Location = New System.Drawing.Point(5, 161)
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.Name = "UcucCarTruckNobatCollectionPnlCarTruckTurns"
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.Size = New System.Drawing.Size(985, 351)
        Me.UcucCarTruckNobatCollectionPnlCarTruckTurns.TabIndex = 0
        '
        'FrmcTurnRegisterRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSodoorNobat)
        Me.Controls.Add(Me.PnlTWS)
        Me.Controls.Add(Me.PnlAccounting)
        Me.Controls.Add(Me.PnlConsole)
        Me.Controls.Add(Me.PnlCarTruckTurns)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTurnRegisterRequest"
        Me.Text = "FrmcSodoorNobat"
        Me.Controls.SetChildIndex(Me.PnlCarTruckTurns, 0)
        Me.Controls.SetChildIndex(Me.PnlConsole, 0)
        Me.Controls.SetChildIndex(Me.PnlAccounting, 0)
        Me.Controls.SetChildIndex(Me.PnlTWS, 0)
        Me.Controls.SetChildIndex(Me.PnlSodoorNobat, 0)
        Me.PnlSodoorNobat.ResumeLayout(false)
        Me.PnlTWS.ResumeLayout(false)
        Me.PnlAccounting.ResumeLayout(false)
        Me.PnlConsole.ResumeLayout(false)
        Me.PnlCarTruckTurns.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlSodoorNobat As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWallet As R2CoreParkingSystem.UCMoneyWallet
    Friend WithEvents UcCarAndDriverPresenter As R2CoreParkingSystem.UCCarAndDriverPresenter
    Friend WithEvents UcucCarTruckNobatCollection As UCUCCarTruckNobatCollection
    Friend WithEvents UcButtonSodoorNobat As UCButton
    Friend WithEvents PnlTWS As System.Windows.Forms.Panel
    Friend WithEvents UctwsReport As UCTWSReport
    Friend WithEvents UcTerafficCardPresenter As R2CoreParkingSystem.UCTerafficCardPresenter
    Friend WithEvents PnlAccounting As System.Windows.Forms.Panel
    Friend WithEvents UcAccountingCollection As R2CoreParkingSystem.UCAccountingCollection
    Friend WithEvents PnlConsole As System.Windows.Forms.Panel
    Friend WithEvents UcucLoggCollection As UCUCLogCollection
    Friend WithEvents UcCarEnterExitStatus As R2CoreParkingSystem.UCCarEnterExitStatus
    Friend WithEvents PnlCarTruckTurns As System.Windows.Forms.Panel
    Friend WithEvents UcCarImagePnlCarTruckTurns As R2CoreParkingSystem.UCCarImage
    Friend WithEvents UcCarTruckPnlCarTruckTurns As UCCarTruck
    Friend WithEvents UcucCarTruckNobatCollectionPnlCarTruckTurns As UCUCCarTruckNobatCollection
End Class
