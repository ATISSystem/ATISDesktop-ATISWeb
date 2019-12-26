<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageProducer
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcComputerMessageSender = New R2CoreGUI.UCButtonComputerMessageSender()
        Me.UcLabelCMTypeTitle = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcComputerMessageSender)
        Me.PnlMain.Controls.Add(Me.UcLabelCMTypeTitle)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(583, 71)
        Me.PnlMain.TabIndex = 0
        '
        'UcComputerMessageSender
        '
        Me.UcComputerMessageSender.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageSender.Location = New System.Drawing.Point(8, 6)
        Me.UcComputerMessageSender.Name = "UcComputerMessageSender"
        Me.UcComputerMessageSender.Padding = New System.Windows.Forms.Padding(1)
        Me.UcComputerMessageSender.Size = New System.Drawing.Size(129, 34)
        Me.UcComputerMessageSender.TabIndex = 1
        Me.UcComputerMessageSender.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcComputerMessageSender.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcComputerMessageSender.UCEnable = false
        Me.UcComputerMessageSender.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcComputerMessageSender.UCForeColor = System.Drawing.Color.White
        Me.UcComputerMessageSender.UCValue = "ارسال پیام"
        '
        'UcLabelCMTypeTitle
        '
        Me.UcLabelCMTypeTitle._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelCMTypeTitle._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelCMTypeTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCMTypeTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelCMTypeTitle.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelCMTypeTitle.Name = "UcLabelCMTypeTitle"
        Me.UcLabelCMTypeTitle.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCMTypeTitle.Size = New System.Drawing.Size(581, 47)
        Me.UcLabelCMTypeTitle.TabIndex = 0
        Me.UcLabelCMTypeTitle.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelCMTypeTitle.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCMTypeTitle.UCForeColor = System.Drawing.Color.White
        Me.UcLabelCMTypeTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelCMTypeTitle.UCValue = ""
        '
        'UCComputerMessageProducer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCComputerMessageProducer"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(603, 91)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabelCMTypeTitle As UCLabel
    Friend WithEvents UcComputerMessageSender As UCButtonComputerMessageSender
End Class
