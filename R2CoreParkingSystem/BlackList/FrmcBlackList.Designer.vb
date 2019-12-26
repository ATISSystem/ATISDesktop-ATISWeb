Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcBlackList
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
        Me.PnlBlackList = New System.Windows.Forms.Panel()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcucBlackListCollection = New R2CoreParkingSystem.UCUCBlackListCollection()
        Me.PnlBlackList.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlBlackList
        '
        Me.PnlBlackList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlBlackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBlackList.Controls.Add(Me.UcMoneyWallet)
        Me.PnlBlackList.Controls.Add(Me.UcucBlackListCollection)
        Me.PnlBlackList.Location = New System.Drawing.Point(5, 50)
        Me.PnlBlackList.Name = "PnlBlackList"
        Me.PnlBlackList.Size = New System.Drawing.Size(995, 512)
        Me.PnlBlackList.TabIndex = 200
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(784, 9)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(197, 262)
        Me.UcMoneyWallet.TabIndex = 1
        '
        'UcucBlackListCollection
        '
        Me.UcucBlackListCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucBlackListCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucBlackListCollection.Location = New System.Drawing.Point(6, 9)
        Me.UcucBlackListCollection.Name = "UcucBlackListCollection"
        Me.UcucBlackListCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucBlackListCollection.Size = New System.Drawing.Size(761, 498)
        Me.UcucBlackListCollection.TabIndex = 0
        '
        'FrmcBlackList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlBlackList)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcBlackList"
        Me.Text = "FrmcBlackList"
        Me.Controls.SetChildIndex(Me.PnlBlackList, 0)
        Me.PnlBlackList.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlBlackList As System.Windows.Forms.Panel
    Friend WithEvents UcucBlackListCollection As UCUCBlackListCollection
    Friend WithEvents UcMoneyWallet As R2CoreParkingSystem.UCMoneyWallet
End Class
