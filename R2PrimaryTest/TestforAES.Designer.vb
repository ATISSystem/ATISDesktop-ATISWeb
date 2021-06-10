<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestforAES
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
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(12, 226)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(776, 111)
        Me.TxtResult.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "09130843148 APIKey Encrypt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "09130843148 MobileNumber Encrypt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(12, 109)
        Me.TxtInput.Multiline = True
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(776, 79)
        Me.TxtInput.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Result"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(473, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(315, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Produce SoftwareUsers APIKeys New Hash"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(473, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(315, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Produce SoftwareUsers UserShenaseh UserPassword New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(281, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Encrypt"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(281, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Decrypt"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(281, 70)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Int64.MinValue"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TestforAES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 374)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtResult)
        Me.Name = "TestforAES"
        Me.Text = "TestforAES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtResult As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
