<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCConfigurationSetting
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
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCName = New System.Windows.Forms.Label()
        Me.LabelOrientation = New System.Windows.Forms.Label()
        Me.LabelCId = New System.Windows.Forms.Label()
        Me.TextBoxCValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.MediumVioletRed
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.LabelDescription)
        Me.PnlMain.Controls.Add(Me.Label4)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.LabelCName)
        Me.PnlMain.Controls.Add(Me.LabelOrientation)
        Me.PnlMain.Controls.Add(Me.LabelCId)
        Me.PnlMain.Controls.Add(Me.TextBoxCValue)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(723, 111)
        Me.PnlMain.TabIndex = 0
        '
        'LabelDescription
        '
        Me.LabelDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelDescription.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LabelDescription.ForeColor = System.Drawing.Color.Honeydew
        Me.LabelDescription.Location = New System.Drawing.Point(-1, 0)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(723, 25)
        Me.LabelDescription.TabIndex = 12
        Me.LabelDescription.Text = "عنوان"
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(3, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ترتیب مقادیر"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(443, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "عنوان"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(671, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "کد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCName
        '
        Me.LabelCName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelCName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelCName.Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LabelCName.ForeColor = System.Drawing.Color.GhostWhite
        Me.LabelCName.Location = New System.Drawing.Point(447, 41)
        Me.LabelCName.Name = "LabelCName"
        Me.LabelCName.Size = New System.Drawing.Size(218, 25)
        Me.LabelCName.TabIndex = 14
        Me.LabelCName.Text = "44"
        Me.LabelCName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelOrientation
        '
        Me.LabelOrientation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelOrientation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelOrientation.Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LabelOrientation.ForeColor = System.Drawing.Color.Ivory
        Me.LabelOrientation.Location = New System.Drawing.Point(2, 41)
        Me.LabelOrientation.Name = "LabelOrientation"
        Me.LabelOrientation.Size = New System.Drawing.Size(435, 25)
        Me.LabelOrientation.TabIndex = 15
        Me.LabelOrientation.Text = "44"
        Me.LabelOrientation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCId
        '
        Me.LabelCId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelCId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelCId.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LabelCId.ForeColor = System.Drawing.Color.White
        Me.LabelCId.Location = New System.Drawing.Point(671, 41)
        Me.LabelCId.Name = "LabelCId"
        Me.LabelCId.Size = New System.Drawing.Size(47, 25)
        Me.LabelCId.TabIndex = 13
        Me.LabelCId.Text = "44"
        Me.LabelCId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxCValue
        '
        Me.TextBoxCValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBoxCValue.BackColor = System.Drawing.Color.MediumVioletRed
        Me.TextBoxCValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCValue.ForeColor = System.Drawing.Color.White
        Me.TextBoxCValue.Location = New System.Drawing.Point(16, 85)
        Me.TextBoxCValue.Multiline = true
        Me.TextBoxCValue.Name = "TextBoxCValue"
        Me.TextBoxCValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxCValue.Size = New System.Drawing.Size(693, 20)
        Me.TextBoxCValue.TabIndex = 11
        Me.TextBoxCValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(-1, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(719, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "مقدار"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCConfiguration"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(733, 121)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCValue As TextBox
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelCName As Label
    Friend WithEvents LabelOrientation As Label
    Friend WithEvents LabelCId As Label
End Class
