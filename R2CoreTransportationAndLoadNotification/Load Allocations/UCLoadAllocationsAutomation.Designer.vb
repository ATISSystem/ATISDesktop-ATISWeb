Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadAllocationsAutomation
    Inherits UCGeneralExtended

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
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcButtonStart = New R2CoreGUI.UCButtonSpecial()
        Me.UcButtonStop = New R2CoreGUI.UCButtonSpecial()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcucLoadAllocationCollection = New R2CoreTransportationAndLoadNotification.UCUCLoadAllocationCollection()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(663, 43)
        Me.UcLabelTop.TabIndex = 11
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "سرویس صدور مجوز بارگیری - بر اساس تخصیص های صادر شده"
        '
        'UcButtonStart
        '
        Me.UcButtonStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonStart.BackColor = System.Drawing.Color.Black
        Me.UcButtonStart.Location = New System.Drawing.Point(503, 49)
        Me.UcButtonStart.Name = "UcButtonStart"
        Me.UcButtonStart.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonStart.Size = New System.Drawing.Size(158, 45)
        Me.UcButtonStart.TabIndex = 12
        Me.UcButtonStart.UCBackColor = System.Drawing.Color.LawnGreen
        Me.UcButtonStart.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonStart.UCEnable = true
        Me.UcButtonStart.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonStart.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonStart.UCValue = "فعال سازی سرویس"
        '
        'UcButtonStop
        '
        Me.UcButtonStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonStop.BackColor = System.Drawing.Color.Black
        Me.UcButtonStop.Location = New System.Drawing.Point(381, 49)
        Me.UcButtonStop.Name = "UcButtonStop"
        Me.UcButtonStop.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonStop.Size = New System.Drawing.Size(116, 45)
        Me.UcButtonStop.TabIndex = 13
        Me.UcButtonStop.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonStop.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonStop.UCEnable = false
        Me.UcButtonStop.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonStop.UCForeColor = System.Drawing.Color.White
        Me.UcButtonStop.UCValue = "توقف سرویس"
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcucLoadAllocationCollection)
        Me.PnlMain.Controls.Add(Me.UcButtonStart)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcButtonStop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(665, 509)
        Me.PnlMain.TabIndex = 14
        '
        'UcucLoadAllocationCollection
        '
        Me.UcucLoadAllocationCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucLoadAllocationCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadAllocationCollection.Location = New System.Drawing.Point(3, 102)
        Me.UcucLoadAllocationCollection.Name = "UcucLoadAllocationCollection"
        Me.UcucLoadAllocationCollection.Size = New System.Drawing.Size(657, 402)
        Me.UcucLoadAllocationCollection.TabIndex = 14
        '
        'UCLoadAllocationsAutomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadAllocationsAutomation"
        Me.Size = New System.Drawing.Size(665, 509)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonStart As R2CoreGUI.UCButtonSpecial
    Friend WithEvents UcButtonStop As R2CoreGUI.UCButtonSpecial
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcucLoadAllocationCollection As UCUCLoadAllocationCollection
End Class
