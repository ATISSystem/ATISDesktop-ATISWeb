Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCMonetarySettingToolExitCarProcessInstrument
    Inherits UCMonetarySettingToolInstrument


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
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(347, 60)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(27, 7)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(287, 47)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "فرآیند خروج خودرو - محاسبه هزینه"
        '
        'UCMonetarySettingToolExitCarProcessInstrument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMonetarySettingToolExitCarProcessInstrument"
        Me.Size = New System.Drawing.Size(347, 60)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabel1 As UCLabel
End Class
