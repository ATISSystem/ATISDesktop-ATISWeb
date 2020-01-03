Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcMoneyWalletCharge
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
        Me.PnlMoneyWalletCharge = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletChargeSavabeghCollection()
        Me.UcMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge()
        Me.PnlUserChargeSavabegh = New System.Windows.Forms.Panel()
        Me.UcUserChargeSavabeghCollection = New R2CoreParkingSystem.UCUserChargeSavabeghCollection()
        Me.PnlMoneyWalletChargeSavabegh = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletChargeSavabeghCollection = New R2CoreParkingSystem.UCMoneyWalletChargeSavabeghCollection()
        Me.PnlAccounting = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.PnlMoneyWalletCharge.SuspendLayout
        Me.PnlUserChargeSavabegh.SuspendLayout
        Me.PnlMoneyWalletChargeSavabegh.SuspendLayout
        Me.PnlAccounting.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlMoneyWalletCharge
        '
        Me.PnlMoneyWalletCharge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge)
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcMoneyWalletCharge)
        Me.PnlMoneyWalletCharge.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletCharge.Name = "PnlMoneyWalletCharge"
        Me.PnlMoneyWalletCharge.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletCharge.TabIndex = 201
        '
        'UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge
        '
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Location = New System.Drawing.Point(10, 323)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Name = "UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge"
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.Size = New System.Drawing.Size(975, 184)
        Me.UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.TabIndex = 1
        '
        'UcMoneyWalletCharge
        '
        Me.UcMoneyWalletCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletCharge.Location = New System.Drawing.Point(10, 3)
        Me.UcMoneyWalletCharge.Name = "UcMoneyWalletCharge"
        Me.UcMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletCharge.Size = New System.Drawing.Size(975, 314)
        Me.UcMoneyWalletCharge.TabIndex = 0
        Me.UcMoneyWalletCharge.UCConfigurationIndex = CType(2, Long)
        Me.UcMoneyWalletCharge.UCLocalPrintFlagforUCPrintBillan = True
        '
        'PnlUserChargeSavabegh
        '
        Me.PnlUserChargeSavabegh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUserChargeSavabegh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUserChargeSavabegh.Controls.Add(Me.UcUserChargeSavabeghCollection)
        Me.PnlUserChargeSavabegh.Location = New System.Drawing.Point(5, 50)
        Me.PnlUserChargeSavabegh.Name = "PnlUserChargeSavabegh"
        Me.PnlUserChargeSavabegh.Size = New System.Drawing.Size(995, 512)
        Me.PnlUserChargeSavabegh.TabIndex = 202
        '
        'UcUserChargeSavabeghCollection
        '
        Me.UcUserChargeSavabeghCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcUserChargeSavabeghCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUserChargeSavabeghCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcUserChargeSavabeghCollection.Name = "UcUserChargeSavabeghCollection"
        Me.UcUserChargeSavabeghCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcUserChargeSavabeghCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcUserChargeSavabeghCollection.TabIndex = 0
        '
        'PnlMoneyWalletChargeSavabegh
        '
        Me.PnlMoneyWalletChargeSavabegh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletChargeSavabegh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletChargeSavabegh.Controls.Add(Me.UcMoneyWalletChargeSavabeghCollection)
        Me.PnlMoneyWalletChargeSavabegh.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletChargeSavabegh.Name = "PnlMoneyWalletChargeSavabegh"
        Me.PnlMoneyWalletChargeSavabegh.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletChargeSavabegh.TabIndex = 203
        '
        'UcMoneyWalletChargeSavabeghCollection
        '
        Me.UcMoneyWalletChargeSavabeghCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletChargeSavabeghCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletChargeSavabeghCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMoneyWalletChargeSavabeghCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcMoneyWalletChargeSavabeghCollection.Name = "UcMoneyWalletChargeSavabeghCollection"
        Me.UcMoneyWalletChargeSavabeghCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletChargeSavabeghCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcMoneyWalletChargeSavabeghCollection.TabIndex = 0
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
        Me.PnlAccounting.TabIndex = 344
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Location = New System.Drawing.Point(5, 12)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(980, 499)
        Me.UcAccountingCollection.TabIndex = 0
        '
        'FrmcMoneyWalletCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletCharge)
        Me.Controls.Add(Me.PnlUserChargeSavabegh)
        Me.Controls.Add(Me.PnlAccounting)
        Me.Controls.Add(Me.PnlMoneyWalletChargeSavabegh)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletCharge"
        Me.Text = "FrmMoneyWalletCharge"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletChargeSavabegh, 0)
        Me.Controls.SetChildIndex(Me.PnlAccounting, 0)
        Me.Controls.SetChildIndex(Me.PnlUserChargeSavabegh, 0)
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletCharge, 0)
        Me.PnlMoneyWalletCharge.ResumeLayout(false)
        Me.PnlUserChargeSavabegh.ResumeLayout(false)
        Me.PnlMoneyWalletChargeSavabegh.ResumeLayout(false)
        Me.PnlAccounting.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMoneyWalletCharge As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletCharge As UCMoneyWalletCharge
    Friend WithEvents PnlUserChargeSavabegh As System.Windows.Forms.Panel
    Friend WithEvents UcUserChargeSavabeghCollection As UCUserChargeSavabeghCollection
    Friend WithEvents PnlMoneyWalletChargeSavabegh As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletChargeSavabeghCollection As UCMoneyWalletChargeSavabeghCollection
    Friend WithEvents PnlAccounting As System.Windows.Forms.Panel
    Friend WithEvents UcAccountingCollection As UCAccountingCollection
    Friend WithEvents UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge As UCMoneyWalletChargeSavabeghCollection
End Class
