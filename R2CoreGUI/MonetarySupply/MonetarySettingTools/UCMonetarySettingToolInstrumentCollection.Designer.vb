<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMonetarySettingToolInstrumentCollection
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
        Dim R2CoreStandardMonetarySettingToolStructure1 As R2Core.MonetarySettingTools.R2CoreStandardMonetarySettingToolStructure = New R2Core.MonetarySettingTools.R2CoreStandardMonetarySettingToolStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcucMonetarySettingToolCollection = New R2CoreGUI.UCUCMonetarySettingToolCollection()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.UcAmount = New R2CoreGUI.UCMoney()
        Me.PnlMonetarySettingToolInstrumentHolder = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcucMonetarySettingToolCollection)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Controls.Add(Me.PnlMonetarySettingToolInstrumentHolder)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(778, 198)
        Me.PnlMain.TabIndex = 0
        '
        'UcucMonetarySettingToolCollection
        '
        Me.UcucMonetarySettingToolCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucMonetarySettingToolCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucMonetarySettingToolCollection.Location = New System.Drawing.Point(0, 163)
        Me.UcucMonetarySettingToolCollection.Name = "UcucMonetarySettingToolCollection"
        Me.UcucMonetarySettingToolCollection.Size = New System.Drawing.Size(777, 33)
        Me.UcucMonetarySettingToolCollection.TabIndex = 0
        R2CoreStandardMonetarySettingToolStructure1.Active = True
        R2CoreStandardMonetarySettingToolStructure1.AssemblyDll = "R2CoreGUI.Dll"
        R2CoreStandardMonetarySettingToolStructure1.AssemblyPath = "R2CoreGUI.UCMonetarySettingToolUserPadInstrument"
        R2CoreStandardMonetarySettingToolStructure1.Deleted = False
        R2CoreStandardMonetarySettingToolStructure1.MSTColor = System.Drawing.Color.Blue
        R2CoreStandardMonetarySettingToolStructure1.MSTId = CType(1, Long)
        R2CoreStandardMonetarySettingToolStructure1.MSTName = "UserPad"
        R2CoreStandardMonetarySettingToolStructure1.MSTTitle = "پد کاربر"
        R2CoreStandardMonetarySettingToolStructure1.OCode = "1"
        R2CoreStandardMonetarySettingToolStructure1.OName = "UserPad"
        R2CoreStandardMonetarySettingToolStructure1.ViewFlag = True
        Me.UcucMonetarySettingToolCollection.UCCurrentNSS = R2CoreStandardMonetarySettingToolStructure1
        Me.UcucMonetarySettingToolCollection.UCDefaultMSTId = CType(1, Long)
        Me.UcucMonetarySettingToolCollection.UCViewBorder = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UcLabel1)
        Me.Panel1.Controls.Add(Me.UcButtonSpecial)
        Me.Panel1.Controls.Add(Me.UcAmount)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(105, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 198)
        Me.Panel1.TabIndex = 8
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(34, 2)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(62, 32)
        Me.UcLabel1.TabIndex = 7
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "مبلغ"
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(7, 100)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(111, 54)
        Me.UcButtonSpecial.TabIndex = 6
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.White
        Me.UcButtonSpecial.UCEnable = True
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "تایید"
        '
        'UcAmount
        '
        Me.UcAmount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UcAmount.Location = New System.Drawing.Point(8, 51)
        Me.UcAmount.Name = "UcAmount"
        Me.UcAmount.Size = New System.Drawing.Size(103, 32)
        Me.UcAmount.TabIndex = 5
        Me.UcAmount.UCBackColor = System.Drawing.Color.White
        Me.UcAmount.UCBorder = False
        Me.UcAmount.UCBorderColor = System.Drawing.Color.Red
        Me.UcAmount.UCFont = New System.Drawing.Font("Alborz Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcAmount.UCForeColor = System.Drawing.Color.Black
        '
        'PnlMonetarySettingToolInstrumentHolder
        '
        Me.PnlMonetarySettingToolInstrumentHolder.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMonetarySettingToolInstrumentHolder.Location = New System.Drawing.Point(230, 0)
        Me.PnlMonetarySettingToolInstrumentHolder.Name = "PnlMonetarySettingToolInstrumentHolder"
        Me.PnlMonetarySettingToolInstrumentHolder.Size = New System.Drawing.Size(548, 198)
        Me.PnlMonetarySettingToolInstrumentHolder.TabIndex = 1
        '
        'UCMonetarySettingToolInstrumentCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMonetarySettingToolInstrumentCollection"
        Me.Size = New System.Drawing.Size(778, 198)
        Me.PnlMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlMonetarySettingToolInstrumentHolder As Panel
    Friend WithEvents UcucMonetarySettingToolCollection As UCUCMonetarySettingToolCollection
    Friend WithEvents UcAmount As UCMoney
    Friend WithEvents UcButtonSpecial As UCButtonSpecial
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents Panel1 As Panel
End Class
