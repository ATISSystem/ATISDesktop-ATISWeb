Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcDriverTruckPresentDermalog
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
        Me.PnlDriverTruckPresentDermalog = New System.Windows.Forms.Panel()
        Me.UcCarEnterExitStatus = New R2CoreParkingSystem.UCCarEnterExitStatus()
        Me.UcCarTruckNobat = New PayanehClassLibrary.UCCarTruckNobat()
        Me.UcDriverTruckPresentCollection = New PayanehClassLibrary.UCDriverTruckPresentCollection()
        Me.UcTerafficCardPresenter = New R2CoreParkingSystem.UCTerafficCardPresenter()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcCarAndTerafficCard = New R2CoreParkingSystem.UCCarAndTerafficCard()
        Me.UcFingerPrintCapturerDermalog = New UCFingerPrintCapturerDermalog()
        Me.UcDriverImage = New R2CoreParkingSystem.UCDriverImage()
        Me.UcCarPresenter = New R2CoreParkingSystem.UCCarPresenter()
        Me.PnlTerafficCardAccounting = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.PnlCarTruckAndDriverInformation = New System.Windows.Forms.Panel()
        Me.UcDriverTruckSecond = New PayanehClassLibrary.UCDriverTruck()
        Me.UcDriverTruckFirst = New PayanehClassLibrary.UCDriverTruck()
        Me.UcCarTruck = New PayanehClassLibrary.UCCarTruck()
        Me.PnlDriverTruckPresentDermalog.SuspendLayout()
        Me.PnlTerafficCardAccounting.SuspendLayout()
        Me.PnlCarTruckAndDriverInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlDriverTruckPresentDermalog
        '
        Me.PnlDriverTruckPresentDermalog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDriverTruckPresentDermalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcCarEnterExitStatus)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcCarTruckNobat)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcDriverTruckPresentCollection)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcMoneyWallet)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcCarAndTerafficCard)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcFingerPrintCapturerDermalog)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcDriverImage)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcCarPresenter)
        Me.PnlDriverTruckPresentDermalog.Controls.Add(Me.UcTerafficCardPresenter)
        Me.PnlDriverTruckPresentDermalog.Location = New System.Drawing.Point(5, 50)
        Me.PnlDriverTruckPresentDermalog.Name = "PnlDriverTruckPresentDermalog"
        Me.PnlDriverTruckPresentDermalog.Size = New System.Drawing.Size(995, 512)
        Me.PnlDriverTruckPresentDermalog.TabIndex = 206
        '
        'UcCarEnterExitStatus
        '
        Me.UcCarEnterExitStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcCarEnterExitStatus.Location = New System.Drawing.Point(5, 130)
        Me.UcCarEnterExitStatus.Name = "UcCarEnterExitStatus"
        Me.UcCarEnterExitStatus.Padding = New System.Windows.Forms.Padding(10)
        Me.UcCarEnterExitStatus.Size = New System.Drawing.Size(268, 60)
        Me.UcCarEnterExitStatus.TabIndex = 207
        '
        'UcCarTruckNobat
        '
        Me.UcCarTruckNobat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruckNobat.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruckNobat.Location = New System.Drawing.Point(0, -15)
        Me.UcCarTruckNobat.Name = "UcCarTruckNobat"
        Me.UcCarTruckNobat.Padding = New System.Windows.Forms.Padding(10)
        Me.UcCarTruckNobat.Size = New System.Drawing.Size(539, 79)
        Me.UcCarTruckNobat.TabIndex = 7
        Me.UcCarTruckNobat.UCViewButtons = False
        '
        'UcDriverTruckPresentCollection
        '
        Me.UcDriverTruckPresentCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckPresentCollection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UcDriverTruckPresentCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverTruckPresentCollection.Location = New System.Drawing.Point(9, 410)
        Me.UcDriverTruckPresentCollection.Name = "UcDriverTruckPresentCollection"
        Me.UcDriverTruckPresentCollection.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverTruckPresentCollection.Size = New System.Drawing.Size(522, 97)
        Me.UcDriverTruckPresentCollection.TabIndex = 5
        '
        'UcTerafficCardPresenter
        '
        Me.UcTerafficCardPresenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTerafficCardPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcTerafficCardPresenter.Location = New System.Drawing.Point(274, 122)
        Me.UcTerafficCardPresenter.Name = "UcTerafficCardPresenter"
        Me.UcTerafficCardPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTerafficCardPresenter.Size = New System.Drawing.Size(264, 64)
        Me.UcTerafficCardPresenter.TabIndex = 3
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(317, 184)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(214, 231)
        Me.UcMoneyWallet.TabIndex = 2
        '
        'UcCarAndTerafficCard
        '
        Me.UcCarAndTerafficCard.BackColor = System.Drawing.Color.Transparent
        Me.UcCarAndTerafficCard.Location = New System.Drawing.Point(9, 184)
        Me.UcCarAndTerafficCard.Name = "UcCarAndTerafficCard"
        Me.UcCarAndTerafficCard.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarAndTerafficCard.Size = New System.Drawing.Size(235, 230)
        Me.UcCarAndTerafficCard.TabIndex = 1
        '
        'UcFingerPrintCapturerDermalog
        '
        Me.UcFingerPrintCapturerDermalog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcFingerPrintCapturerDermalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerDermalog.Location = New System.Drawing.Point(543, 5)
        Me.UcFingerPrintCapturerDermalog.Name = "UcFingerPrintCapturerDermalog"
        Me.UcFingerPrintCapturerDermalog.Size = New System.Drawing.Size(443, 502)
        Me.UcFingerPrintCapturerDermalog.TabIndex = 0
        Me.UcFingerPrintCapturerDermalog.UCDDevice_OnDetectChekFlag = True
        Me.UcFingerPrintCapturerDermalog.UCLifenessScore = CType(0, Long)
        '
        'UcDriverImage
        '
        Me.UcDriverImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverImage.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImage.Location = New System.Drawing.Point(543, 5)
        Me.UcDriverImage.Name = "UcDriverImage"
        Me.UcDriverImage.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverImage.Size = New System.Drawing.Size(443, 502)
        Me.UcDriverImage.TabIndex = 6
        '
        'UcCarPresenter
        '
        Me.UcCarPresenter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarPresenter.BackColor = System.Drawing.Color.Transparent
        Me.UcCarPresenter.Location = New System.Drawing.Point(7, 56)
        Me.UcCarPresenter.Name = "UcCarPresenter"
        Me.UcCarPresenter.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarPresenter.Size = New System.Drawing.Size(532, 71)
        Me.UcCarPresenter.TabIndex = 4
        '
        'PnlTerafficCardAccounting
        '
        Me.PnlTerafficCardAccounting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTerafficCardAccounting.BackColor = System.Drawing.Color.Transparent
        Me.PnlTerafficCardAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTerafficCardAccounting.Controls.Add(Me.UcAccountingCollection)
        Me.PnlTerafficCardAccounting.Location = New System.Drawing.Point(5, 50)
        Me.PnlTerafficCardAccounting.Name = "PnlTerafficCardAccounting"
        Me.PnlTerafficCardAccounting.Size = New System.Drawing.Size(995, 512)
        Me.PnlTerafficCardAccounting.TabIndex = 207
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountingCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcAccountingCollection.TabIndex = 0
        '
        'PnlCarTruckAndDriverInformation
        '
        Me.PnlCarTruckAndDriverInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCarTruckAndDriverInformation.BackColor = System.Drawing.Color.Transparent
        Me.PnlCarTruckAndDriverInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCarTruckAndDriverInformation.Controls.Add(Me.UcDriverTruckSecond)
        Me.PnlCarTruckAndDriverInformation.Controls.Add(Me.UcDriverTruckFirst)
        Me.PnlCarTruckAndDriverInformation.Controls.Add(Me.UcCarTruck)
        Me.PnlCarTruckAndDriverInformation.Location = New System.Drawing.Point(5, 50)
        Me.PnlCarTruckAndDriverInformation.Name = "PnlCarTruckAndDriverInformation"
        Me.PnlCarTruckAndDriverInformation.Size = New System.Drawing.Size(995, 512)
        Me.PnlCarTruckAndDriverInformation.TabIndex = 208
        '
        'UcDriverTruckSecond
        '
        Me.UcDriverTruckSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckSecond.Location = New System.Drawing.Point(8, 337)
        Me.UcDriverTruckSecond.Name = "UcDriverTruckSecond"
        Me.UcDriverTruckSecond.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruckSecond.Size = New System.Drawing.Size(978, 167)
        Me.UcDriverTruckSecond.TabIndex = 2
        Me.UcDriverTruckSecond.UCViewButtons = False
        '
        'UcDriverTruckFirst
        '
        Me.UcDriverTruckFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckFirst.Location = New System.Drawing.Point(8, 164)
        Me.UcDriverTruckFirst.Name = "UcDriverTruckFirst"
        Me.UcDriverTruckFirst.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruckFirst.Size = New System.Drawing.Size(978, 167)
        Me.UcDriverTruckFirst.TabIndex = 1
        Me.UcDriverTruckFirst.UCViewButtons = False
        '
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(8, 5)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(978, 153)
        Me.UcCarTruck.TabIndex = 0
        Me.UcCarTruck.UCViewButtons = False
        '
        'FrmcDriverTruckPresentDermalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlDriverTruckPresentDermalog)
        Me.Controls.Add(Me.PnlCarTruckAndDriverInformation)
        Me.Controls.Add(Me.PnlTerafficCardAccounting)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcDriverTruckPresentDermalog"
        Me.Text = "FrmcDriverTruckPresentDermalog"
        Me.Controls.SetChildIndex(Me.PnlTerafficCardAccounting, 0)
        Me.Controls.SetChildIndex(Me.PnlCarTruckAndDriverInformation, 0)
        Me.Controls.SetChildIndex(Me.PnlDriverTruckPresentDermalog, 0)
        Me.PnlDriverTruckPresentDermalog.ResumeLayout(False)
        Me.PnlTerafficCardAccounting.ResumeLayout(False)
        Me.PnlCarTruckAndDriverInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlDriverTruckPresentDermalog As System.Windows.Forms.Panel
    Friend WithEvents UcFingerPrintCapturerDermalog As UCFingerPrintCapturerDermalog
    Friend WithEvents UcCarPresenter As R2CoreParkingSystem.UCCarPresenter
    Friend WithEvents UcTerafficCardPresenter As R2CoreParkingSystem.UCTerafficCardPresenter
    Friend WithEvents UcMoneyWallet As R2CoreParkingSystem.UCMoneyWallet
    Friend WithEvents UcCarAndTerafficCard As R2CoreParkingSystem.UCCarAndTerafficCard
    Friend WithEvents UcDriverTruckPresentCollection As UCDriverTruckPresentCollection
    Friend WithEvents UcDriverImage As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcCarTruckNobat As UCCarTruckNobat
    Friend WithEvents UcCarEnterExitStatus As R2CoreParkingSystem.UCCarEnterExitStatus
    Friend WithEvents PnlTerafficCardAccounting As System.Windows.Forms.Panel
    Friend WithEvents UcAccountingCollection As R2CoreParkingSystem.UCAccountingCollection
    Friend WithEvents PnlCarTruckAndDriverInformation As System.Windows.Forms.Panel
    Friend WithEvents UcDriverTruckSecond As UCDriverTruck
    Friend WithEvents UcDriverTruckFirst As UCDriverTruck
    Friend WithEvents UcCarTruck As UCCarTruck
End Class
