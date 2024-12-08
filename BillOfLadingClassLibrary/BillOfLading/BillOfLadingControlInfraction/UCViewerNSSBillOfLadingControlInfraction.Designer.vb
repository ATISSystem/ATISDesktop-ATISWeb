<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSBillOfLadingControlInfraction
    Inherits UCBillOfLadingControlinfraction

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
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcLabelBLCTitle = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelTime = New R2CoreGUI.UCLabel()
        Me.UcLabelDateShamsi = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(216, 69)
        Me.PnlMain.TabIndex = 1
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlOutter.Size = New System.Drawing.Size(216, 69)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlInner.Controls.Add(Me.UcLabelBLCTitle)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.UcLabelTime)
        Me.PnlInner.Controls.Add(Me.UcLabelDateShamsi)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(214, 67)
        Me.PnlInner.TabIndex = 0
        '
        'UcLabelBLCTitle
        '
        Me.UcLabelBLCTitle._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelBLCTitle._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelBLCTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelBLCTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelBLCTitle.Location = New System.Drawing.Point(3, 4)
        Me.UcLabelBLCTitle.Name = "UcLabelBLCTitle"
        Me.UcLabelBLCTitle.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelBLCTitle.Size = New System.Drawing.Size(207, 28)
        Me.UcLabelBLCTitle.TabIndex = 3
        Me.UcLabelBLCTitle.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelBLCTitle.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelBLCTitle.UCForeColor = System.Drawing.Color.White
        Me.UcLabelBLCTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelBLCTitle.UCValue = "تفنگساز - تیرماه - 1"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(93, 38)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(12, 20)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "-"
        '
        'UcLabelTime
        '
        Me.UcLabelTime._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTime._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelTime.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTime.Location = New System.Drawing.Point(111, 38)
        Me.UcLabelTime.Name = "UcLabelTime"
        Me.UcLabelTime.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTime.Size = New System.Drawing.Size(134, 20)
        Me.UcLabelTime.TabIndex = 0
        Me.UcLabelTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTime.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTime.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTime.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelTime.UCValue = "11:22:31"
        '
        'UcLabelDateShamsi
        '
        Me.UcLabelDateShamsi._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelDateShamsi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelDateShamsi.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi.Location = New System.Drawing.Point(-32, 38)
        Me.UcLabelDateShamsi.Name = "UcLabelDateShamsi"
        Me.UcLabelDateShamsi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDateShamsi.Size = New System.Drawing.Size(120, 20)
        Me.UcLabelDateShamsi.TabIndex = 1
        Me.UcLabelDateShamsi.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateShamsi.UCForeColor = System.Drawing.Color.White
        Me.UcLabelDateShamsi.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelDateShamsi.UCValue = "1399/12/28"
        '
        'UCViewerNSSBillOfLadingControlInfraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSBillOfLadingControlInfraction"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(226, 79)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabelBLCTitle As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelTime As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelDateShamsi As R2CoreGUI.UCLabel
End Class
