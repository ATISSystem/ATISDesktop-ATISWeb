<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMonetarySupply
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
        Dim R2CoreStandardMonetaryCreditSupplySourceStructure1 As R2Core.MonetaryCreditSupplySources.R2CoreStandardMonetaryCreditSupplySourceStructure = New R2Core.MonetaryCreditSupplySources.R2CoreStandardMonetaryCreditSupplySourceStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcucMonetaryCreditSupplySourceCollection = New R2CoreGUI.UCUCMonetaryCreditSupplySourceCollection()
        Me.UcMonetarySettingToolInstrumentCollection = New R2CoreGUI.UCMonetarySettingToolInstrumentCollection()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.UcucMonetaryCreditSupplySourceCollection)
        Me.PnlMain.Controls.Add(Me.UcMonetarySettingToolInstrumentCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(2, 2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(398, 201)
        Me.PnlMain.TabIndex = 0
        '
        'UcucMonetaryCreditSupplySourceCollection
        '
        Me.UcucMonetaryCreditSupplySourceCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucMonetaryCreditSupplySourceCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucMonetaryCreditSupplySourceCollection.Location = New System.Drawing.Point(2, 2)
        Me.UcucMonetaryCreditSupplySourceCollection.Name = "UcucMonetaryCreditSupplySourceCollection"
        Me.UcucMonetaryCreditSupplySourceCollection.Size = New System.Drawing.Size(394, 33)
        Me.UcucMonetaryCreditSupplySourceCollection.TabIndex = 0
        R2CoreStandardMonetaryCreditSupplySourceStructure1.Active = True
        R2CoreStandardMonetaryCreditSupplySourceStructure1.AssemblyDll = ""
        R2CoreStandardMonetaryCreditSupplySourceStructure1.AssemblyPath = ""
        R2CoreStandardMonetaryCreditSupplySourceStructure1.Deleted = False
        R2CoreStandardMonetaryCreditSupplySourceStructure1.MCSSColor = System.Drawing.Color.Orange
        R2CoreStandardMonetaryCreditSupplySourceStructure1.MCSSId = CType(1, Long)
        R2CoreStandardMonetaryCreditSupplySourceStructure1.MCSSName = "Cash"
        R2CoreStandardMonetaryCreditSupplySourceStructure1.MCSSTitle = "وجه نقد"
        R2CoreStandardMonetaryCreditSupplySourceStructure1.OCode = "1"
        R2CoreStandardMonetaryCreditSupplySourceStructure1.OName = "Cash"
        R2CoreStandardMonetaryCreditSupplySourceStructure1.ViewFlag = True
        Me.UcucMonetaryCreditSupplySourceCollection.UCCurrentNSS = R2CoreStandardMonetaryCreditSupplySourceStructure1
        Me.UcucMonetaryCreditSupplySourceCollection.UCDefaultMCSSId = CType(1, Long)
        Me.UcucMonetaryCreditSupplySourceCollection.UCViewBorder = True
        '
        'UcMonetarySettingToolInstrumentCollection
        '
        Me.UcMonetarySettingToolInstrumentCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMonetarySettingToolInstrumentCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcMonetarySettingToolInstrumentCollection.Location = New System.Drawing.Point(2, 33)
        Me.UcMonetarySettingToolInstrumentCollection.Name = "UcMonetarySettingToolInstrumentCollection"
        Me.UcMonetarySettingToolInstrumentCollection.Size = New System.Drawing.Size(395, 165)
        Me.UcMonetarySettingToolInstrumentCollection.TabIndex = 1
        '
        'UCMonetarySupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMonetarySupply"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(402, 205)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcucMonetaryCreditSupplySourceCollection As UCUCMonetaryCreditSupplySourceCollection
    Friend WithEvents UcMonetarySettingToolInstrumentCollection As UCMonetarySettingToolInstrumentCollection
End Class
