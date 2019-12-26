<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRFIDCardInitialRegistration
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
        Me.UcButtonReadBuffer = New R2CoreGUI.UCButton()
        Me.UcButtonWriteBuffer = New R2CoreGUI.UCButton()
        Me.UcrfidCardTextMaintainer = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.LblDefualtText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuffer = New System.Windows.Forms.TextBox()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcButtonReadBuffer)
        Me.PnlMain.Controls.Add(Me.UcButtonWriteBuffer)
        Me.PnlMain.Controls.Add(Me.UcrfidCardTextMaintainer)
        Me.PnlMain.Controls.Add(Me.LblDefualtText)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.TxtBuffer)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(452, 127)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonReadBuffer
        '
        Me.UcButtonReadBuffer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonReadBuffer.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonReadBuffer.Location = New System.Drawing.Point(111, 85)
        Me.UcButtonReadBuffer.Name = "UcButtonReadBuffer"
        Me.UcButtonReadBuffer.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonReadBuffer.Size = New System.Drawing.Size(98, 34)
        Me.UcButtonReadBuffer.TabIndex = 207
        Me.UcButtonReadBuffer.UCBackColor = System.Drawing.Color.Coral
        Me.UcButtonReadBuffer.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonReadBuffer.UCEnable = true
        Me.UcButtonReadBuffer.UCFont = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonReadBuffer.UCForeColor = System.Drawing.Color.White
        Me.UcButtonReadBuffer.UCValue = "Read Buffer"
        '
        'UcButtonWriteBuffer
        '
        Me.UcButtonWriteBuffer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonWriteBuffer.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonWriteBuffer.Location = New System.Drawing.Point(8, 85)
        Me.UcButtonWriteBuffer.Name = "UcButtonWriteBuffer"
        Me.UcButtonWriteBuffer.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonWriteBuffer.Size = New System.Drawing.Size(97, 34)
        Me.UcButtonWriteBuffer.TabIndex = 206
        Me.UcButtonWriteBuffer.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonWriteBuffer.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonWriteBuffer.UCEnable = true
        Me.UcButtonWriteBuffer.UCFont = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonWriteBuffer.UCForeColor = System.Drawing.Color.White
        Me.UcButtonWriteBuffer.UCValue = "Write Buffer"
        '
        'UcrfidCardTextMaintainer
        '
        Me.UcrfidCardTextMaintainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcrfidCardTextMaintainer.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainer.Location = New System.Drawing.Point(240, 84)
        Me.UcrfidCardTextMaintainer.Name = "UcrfidCardTextMaintainer"
        Me.UcrfidCardTextMaintainer.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainer.Size = New System.Drawing.Size(201, 34)
        Me.UcrfidCardTextMaintainer.TabIndex = 205
        Me.UcrfidCardTextMaintainer.UCEnable = false
        Me.UcrfidCardTextMaintainer.UCValue = ""
        '
        'LblDefualtText
        '
        Me.LblDefualtText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDefualtText.AutoSize = true
        Me.LblDefualtText.BackColor = System.Drawing.Color.Transparent
        Me.LblDefualtText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDefualtText.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblDefualtText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LblDefualtText.Location = New System.Drawing.Point(312, 8)
        Me.LblDefualtText.Name = "LblDefualtText"
        Me.LblDefualtText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDefualtText.Size = New System.Drawing.Size(105, 22)
        Me.LblDefualtText.TabIndex = 202
        Me.LblDefualtText.Text = "DefualtText"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(23, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(156, 22)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "RFIDCard Buffer"
        '
        'TxtBuffer
        '
        Me.TxtBuffer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TxtBuffer.BackColor = System.Drawing.Color.White
        Me.TxtBuffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuffer.Font = New System.Drawing.Font("Times New Roman", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtBuffer.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuffer.Location = New System.Drawing.Point(8, 44)
        Me.TxtBuffer.MaxLength = 0
        Me.TxtBuffer.Multiline = true
        Me.TxtBuffer.Name = "TxtBuffer"
        Me.TxtBuffer.ReadOnly = true
        Me.TxtBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBuffer.Size = New System.Drawing.Size(433, 35)
        Me.TxtBuffer.TabIndex = 200
        Me.TxtBuffer.Text = " "
        Me.TxtBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCRFIDCardInitialRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCRFIDCardInitialRegistration"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(458, 133)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents LblDefualtText As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuffer As TextBox
    Friend WithEvents UcrfidCardTextMaintainer As UCRFIDCardTextMaintainer
    Friend WithEvents UcButtonReadBuffer As UCButton
    Friend WithEvents UcButtonWriteBuffer As UCButton
End Class
