<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSSequentialTurnNumber
    Inherits UCTurn

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
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxSequentialTurnNumber = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel1.Location = New System.Drawing.Point(161, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(90, 28)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Crimson
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "تسلسل نوبت"
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(2, 2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlMain.Size = New System.Drawing.Size(253, 30)
        Me.PnlMain.TabIndex = 1
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcPersianTextBoxSequentialTurnNumber)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(251, 28)
        Me.PnlInner.TabIndex = 1
        '
        'UcPersianTextBoxSequentialTurnNumber
        '
        Me.UcPersianTextBoxSequentialTurnNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxSequentialTurnNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPersianTextBoxSequentialTurnNumber.Location = New System.Drawing.Point(0, 0)
        Me.UcPersianTextBoxSequentialTurnNumber.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxSequentialTurnNumber.Name = "UcPersianTextBoxSequentialTurnNumber"
        Me.UcPersianTextBoxSequentialTurnNumber.Size = New System.Drawing.Size(161, 28)
        Me.UcPersianTextBoxSequentialTurnNumber.TabIndex = 1
        Me.UcPersianTextBoxSequentialTurnNumber.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSequentialTurnNumber.UCBorder = True
        Me.UcPersianTextBoxSequentialTurnNumber.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxSequentialTurnNumber.UCEnable = True
        Me.UcPersianTextBoxSequentialTurnNumber.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxSequentialTurnNumber.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSequentialTurnNumber.UCMultiLine = False
        Me.UcPersianTextBoxSequentialTurnNumber.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSequentialTurnNumber.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSequentialTurnNumber.UCValue = ""
        '
        'UCViewerNSSSequentialTurnNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSSequentialTurnNumber"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(257, 34)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcPersianTextBoxSequentialTurnNumber As R2CoreGUI.UCPersianTextBox
End Class
