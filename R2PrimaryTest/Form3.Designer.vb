<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxConcat1 = New System.Windows.Forms.TextBox()
        Me.TextBoxConcat2 = New System.Windows.Forms.TextBox()
        Me.TextBoxTerraficCardTypeSqlString = New System.Windows.Forms.TextBox()
        Me.TextBoxReport = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(174, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Tomato
        Me.Button3.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(100, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 78)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "شروع "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBoxConcat1
        '
        Me.TextBoxConcat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBoxConcat1.Location = New System.Drawing.Point(12, 69)
        Me.TextBoxConcat1.Name = "TextBoxConcat1"
        Me.TextBoxConcat1.Size = New System.Drawing.Size(122, 22)
        Me.TextBoxConcat1.TabIndex = 3
        Me.TextBoxConcat1.Text = "13980101070000"
        Me.TextBoxConcat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxConcat2
        '
        Me.TextBoxConcat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBoxConcat2.Location = New System.Drawing.Point(140, 69)
        Me.TextBoxConcat2.Name = "TextBoxConcat2"
        Me.TextBoxConcat2.Size = New System.Drawing.Size(122, 22)
        Me.TextBoxConcat2.TabIndex = 4
        Me.TextBoxConcat2.Text = "13980201070000"
        Me.TextBoxConcat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxTerraficCardTypeSqlString
        '
        Me.TextBoxTerraficCardTypeSqlString.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBoxTerraficCardTypeSqlString.Location = New System.Drawing.Point(28, 41)
        Me.TextBoxTerraficCardTypeSqlString.Name = "TextBoxTerraficCardTypeSqlString"
        Me.TextBoxTerraficCardTypeSqlString.Size = New System.Drawing.Size(701, 22)
        Me.TextBoxTerraficCardTypeSqlString.TabIndex = 5
        Me.TextBoxTerraficCardTypeSqlString.Text = "((CardType=2 or CardType=3) and NoMoney=0 and DateShamsiEdit<>'1399/01/01'"
        Me.TextBoxTerraficCardTypeSqlString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxReport
        '
        Me.TextBoxReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBoxReport.Location = New System.Drawing.Point(12, 176)
        Me.TextBoxReport.Multiline = True
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxReport.Size = New System.Drawing.Size(692, 122)
        Me.TextBoxReport.TabIndex = 6
        Me.TextBoxReport.Text = " "
        Me.TextBoxReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBoxResult.Location = New System.Drawing.Point(12, 304)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxResult.Size = New System.Drawing.Size(692, 122)
        Me.TextBoxResult.TabIndex = 7
        Me.TextBoxResult.Text = " "
        Me.TextBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(174, 97)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(93, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(93, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(336, 97)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\SA.mdb"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(596, 69)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(133, 31)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "SmartCard test"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(596, 106)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(133, 31)
        Me.Button11.TabIndex = 15
        Me.Button11.Text = "SmartCard test"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(596, 139)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(133, 31)
        Me.Button12.TabIndex = 16
        Me.Button12.Text = "SmartCard test"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(417, 97)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 20
        Me.Button16.Text = "Button16"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Purple
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.White
        Me.Button17.Location = New System.Drawing.Point(12, 346)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(154, 41)
        Me.Button17.TabIndex = 21
        Me.Button17.Text = "ایجاد مجوزهای فرآیندی وب شرکت های حمل و نقلی"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Purple
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.White
        Me.Button18.Location = New System.Drawing.Point(12, 393)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(154, 41)
        Me.Button18.TabIndex = 22
        Me.Button18.Text = "ایجاد روابط نهادی شرکت های حمل ونقل با گروههای وب"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Purple
        Me.Button19.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button19.ForeColor = System.Drawing.SystemColors.Control
        Me.Button19.Location = New System.Drawing.Point(12, 303)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(237, 41)
        Me.Button19.TabIndex = 23
        Me.Button19.Text = "SMSs Who True Sending"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(12, 97)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(75, 23)
        Me.Button22.TabIndex = 26
        Me.Button22.Text = "Button22"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.Maroon
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.White
        Me.Button28.Location = New System.Drawing.Point(498, 74)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(77, 92)
        Me.Button28.TabIndex = 32
        Me.Button28.Text = "Goto Security"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 450)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBoxReport)
        Me.Controls.Add(Me.TextBoxTerraficCardTypeSqlString)
        Me.Controls.Add(Me.TextBoxConcat2)
        Me.Controls.Add(Me.TextBoxConcat1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxConcat1 As TextBox
    Friend WithEvents TextBoxConcat2 As TextBox
    Friend WithEvents TextBoxTerraficCardTypeSqlString As TextBox
    Friend WithEvents TextBoxReport As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button28 As Button
End Class
