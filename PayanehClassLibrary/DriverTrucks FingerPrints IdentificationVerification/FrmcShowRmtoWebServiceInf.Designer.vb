<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcShowRmtoWebServiceInf
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
        Me.TxtInf = New System.Windows.Forms.TextBox()
        Me.TxtSmartCardNo = New System.Windows.Forms.TextBox()
        Me.OpbDriver = New System.Windows.Forms.RadioButton()
        Me.OpbTruck = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnViewInf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtInf
        '
        Me.TxtInf.BackColor = System.Drawing.Color.DarkBlue
        Me.TxtInf.Font = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtInf.ForeColor = System.Drawing.Color.White
        Me.TxtInf.Location = New System.Drawing.Point(15, 122)
        Me.TxtInf.Multiline = True
        Me.TxtInf.Name = "TxtInf"
        Me.TxtInf.ReadOnly = True
        Me.TxtInf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtInf.Size = New System.Drawing.Size(393, 373)
        Me.TxtInf.TabIndex = 0
        '
        'TxtSmartCardNo
        '
        Me.TxtSmartCardNo.BackColor = System.Drawing.Color.DarkBlue
        Me.TxtSmartCardNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSmartCardNo.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TxtSmartCardNo.ForeColor = System.Drawing.Color.Silver
        Me.TxtSmartCardNo.Location = New System.Drawing.Point(81, 42)
        Me.TxtSmartCardNo.Name = "TxtSmartCardNo"
        Me.TxtSmartCardNo.Size = New System.Drawing.Size(102, 16)
        Me.TxtSmartCardNo.TabIndex = 1
        Me.TxtSmartCardNo.Text = "1234567"
        Me.TxtSmartCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpbDriver
        '
        Me.OpbDriver.AutoSize = True
        Me.OpbDriver.Checked = True
        Me.OpbDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpbDriver.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OpbDriver.ForeColor = System.Drawing.Color.White
        Me.OpbDriver.Location = New System.Drawing.Point(338, 12)
        Me.OpbDriver.Name = "OpbDriver"
        Me.OpbDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OpbDriver.Size = New System.Drawing.Size(70, 33)
        Me.OpbDriver.TabIndex = 2
        Me.OpbDriver.TabStop = True
        Me.OpbDriver.Text = "راننده"
        Me.OpbDriver.UseVisualStyleBackColor = True
        '
        'OpbTruck
        '
        Me.OpbTruck.AutoSize = True
        Me.OpbTruck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpbTruck.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.OpbTruck.ForeColor = System.Drawing.Color.White
        Me.OpbTruck.Location = New System.Drawing.Point(259, 12)
        Me.OpbTruck.Name = "OpbTruck"
        Me.OpbTruck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OpbTruck.Size = New System.Drawing.Size(73, 33)
        Me.OpbTruck.TabIndex = 3
        Me.OpbTruck.Text = "ناوگان"
        Me.OpbTruck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "شماره هوشمند را وارد کنید"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnViewInf
        '
        Me.BtnViewInf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnViewInf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewInf.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnViewInf.ForeColor = System.Drawing.Color.Maroon
        Me.BtnViewInf.Location = New System.Drawing.Point(15, 85)
        Me.BtnViewInf.Name = "BtnViewInf"
        Me.BtnViewInf.Size = New System.Drawing.Size(91, 31)
        Me.BtnViewInf.TabIndex = 5
        Me.BtnViewInf.Text = "نمایش"
        Me.BtnViewInf.UseVisualStyleBackColor = False
        '
        'FrmcShowRmtoWebServiceInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(420, 507)
        Me.Controls.Add(Me.BtnViewInf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpbTruck)
        Me.Controls.Add(Me.OpbDriver)
        Me.Controls.Add(Me.TxtSmartCardNo)
        Me.Controls.Add(Me.TxtInf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmcShowRmtoWebServiceInf"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RmtoWebService"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtInf As System.Windows.Forms.TextBox
    Friend WithEvents TxtSmartCardNo As System.Windows.Forms.TextBox
    Friend WithEvents OpbDriver As System.Windows.Forms.RadioButton
    Friend WithEvents OpbTruck As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnViewInf As System.Windows.Forms.Button
End Class
