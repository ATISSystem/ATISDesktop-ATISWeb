<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLog
    Inherits  UCGeneral


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
        Me.UcLabelTime = New R2CoreGUI.UCLabel()
        Me.UcLabelOptional1 = New R2CoreGUI.UCLabel()
        Me.UcLabelUserName = New R2CoreGUI.UCLabel()
        Me.UcLabelDateShamsi = New R2CoreGUI.UCLabel()
        Me.UcLabelSharh = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabelTime)
        Me.PnlMain.Controls.Add(Me.UcLabelOptional1)
        Me.PnlMain.Controls.Add(Me.UcLabelUserName)
        Me.PnlMain.Controls.Add(Me.UcLabelDateShamsi)
        Me.PnlMain.Controls.Add(Me.UcLabelSharh)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(841, 55)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelTime
        '
        Me.UcLabelTime.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTime.Location = New System.Drawing.Point(148, 24)
        Me.UcLabelTime.Name = "UcLabelTime"
        Me.UcLabelTime.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTime.Size = New System.Drawing.Size(112, 23)
        Me.UcLabelTime.TabIndex = 4
        Me.UcLabelTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTime.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTime.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTime.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTime.UCValue = "1396/11/25"
        '
        'UcLabelOptional1
        '
        Me.UcLabelOptional1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelOptional1.Location = New System.Drawing.Point(3, 3)
        Me.UcLabelOptional1.Name = "UcLabelOptional1"
        Me.UcLabelOptional1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelOptional1.Size = New System.Drawing.Size(112, 23)
        Me.UcLabelOptional1.TabIndex = 3
        Me.UcLabelOptional1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelOptional1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelOptional1.UCForeColor = System.Drawing.Color.White
        Me.UcLabelOptional1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelOptional1.UCValue = "1231313123"
        '
        'UcLabelUserName
        '
        Me.UcLabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserName.Location = New System.Drawing.Point(121, 3)
        Me.UcLabelUserName.Name = "UcLabelUserName"
        Me.UcLabelUserName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelUserName.Size = New System.Drawing.Size(166, 23)
        Me.UcLabelUserName.TabIndex = 2
        Me.UcLabelUserName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelUserName.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelUserName.UCForeColor = System.Drawing.Color.White
        Me.UcLabelUserName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelUserName.UCValue = "مرتضی شاهمرادی"
        '
        'UcLabelDateShamsi
        '
        Me.UcLabelDateShamsi.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi.Location = New System.Drawing.Point(3, 24)
        Me.UcLabelDateShamsi.Name = "UcLabelDateShamsi"
        Me.UcLabelDateShamsi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDateShamsi.Size = New System.Drawing.Size(112, 23)
        Me.UcLabelDateShamsi.TabIndex = 1
        Me.UcLabelDateShamsi.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateShamsi.UCForeColor = System.Drawing.Color.White
        Me.UcLabelDateShamsi.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDateShamsi.UCValue = "1396/11/25"
        '
        'UcLabelSharh
        '
        Me.UcLabelSharh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelSharh.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSharh.Location = New System.Drawing.Point(293, 3)
        Me.UcLabelSharh.Name = "UcLabelSharh"
        Me.UcLabelSharh.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSharh.Size = New System.Drawing.Size(543, 51)
        Me.UcLabelSharh.TabIndex = 0
        Me.UcLabelSharh.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSharh.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelSharh.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSharh.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelSharh.UCValue = ""
        '
        'UCLogg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLogg"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(851, 65)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabelOptional1 As UCLabel
    Friend WithEvents UcLabelUserName As UCLabel
    Friend WithEvents UcLabelDateShamsi As UCLabel
    Friend WithEvents UcLabelSharh As UCLabel
    Friend WithEvents UcLabelTime As UCLabel
End Class
