
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSpecialLoadSelector
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.RBIsSpecialLoad2 = New System.Windows.Forms.RadioButton()
        Me.RBIsSpecialLoad1 = New System.Windows.Forms.RadioButton()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabel4)
        Me.PnlMain.Controls.Add(Me.RBIsSpecialLoad2)
        Me.PnlMain.Controls.Add(Me.RBIsSpecialLoad1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(2, 2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(262, 31)
        Me.PnlMain.TabIndex = 26
        '
        'UcLabel4
        '
        Me.UcLabel4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel4.BackColor = System.Drawing.Color.Yellow
        Me.UcLabel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel4.Location = New System.Drawing.Point(176, 0)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel4.Size = New System.Drawing.Size(84, 29)
        Me.UcLabel4.TabIndex = 28
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "مشخصات بار : "
        '
        'RBIsSpecialLoad2
        '
        Me.RBIsSpecialLoad2.AutoSize = true
        Me.RBIsSpecialLoad2.Font = New System.Drawing.Font("B Homa", 9.75!)
        Me.RBIsSpecialLoad2.Location = New System.Drawing.Point(3, 1)
        Me.RBIsSpecialLoad2.Name = "RBIsSpecialLoad2"
        Me.RBIsSpecialLoad2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBIsSpecialLoad2.Size = New System.Drawing.Size(63, 27)
        Me.RBIsSpecialLoad2.TabIndex = 27
        Me.RBIsSpecialLoad2.TabStop = true
        Me.RBIsSpecialLoad2.Text = "بار عادی"
        Me.RBIsSpecialLoad2.UseVisualStyleBackColor = true
        '
        'RBIsSpecialLoad1
        '
        Me.RBIsSpecialLoad1.AutoSize = true
        Me.RBIsSpecialLoad1.Font = New System.Drawing.Font("B Homa", 9.75!)
        Me.RBIsSpecialLoad1.Location = New System.Drawing.Point(69, 1)
        Me.RBIsSpecialLoad1.Name = "RBIsSpecialLoad1"
        Me.RBIsSpecialLoad1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBIsSpecialLoad1.Size = New System.Drawing.Size(104, 27)
        Me.RBIsSpecialLoad1.TabIndex = 26
        Me.RBIsSpecialLoad1.TabStop = true
        Me.RBIsSpecialLoad1.Text = "بار با شرایط خاص"
        Me.RBIsSpecialLoad1.UseVisualStyleBackColor = true
        '
        'UCSpecialLoadSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCSpecialLoadSelector"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(266, 35)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabel4 As R2CoreGUI.UCLabel
    Friend WithEvents RBIsSpecialLoad2 As Windows.Forms.RadioButton
    Friend WithEvents RBIsSpecialLoad1 As Windows.Forms.RadioButton
End Class
