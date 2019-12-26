
Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcFirst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcFirst))
        Me.LblApplicationDomainDisplayTitle = New System.Windows.Forms.Label()
        Me.UcButtonSpecialSystemEntry = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialWebServiceConnectingTest = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcButtonSpecialUserCancellation = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'LblApplicationDomainDisplayTitle
        '
        Me.LblApplicationDomainDisplayTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblApplicationDomainDisplayTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblApplicationDomainDisplayTitle.Font = New System.Drawing.Font("B Homa", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblApplicationDomainDisplayTitle.ForeColor = System.Drawing.Color.White
        Me.LblApplicationDomainDisplayTitle.Location = New System.Drawing.Point(21, 9)
        Me.LblApplicationDomainDisplayTitle.Name = "LblApplicationDomainDisplayTitle"
        Me.LblApplicationDomainDisplayTitle.Size = New System.Drawing.Size(421, 67)
        Me.LblApplicationDomainDisplayTitle.TabIndex = 204
        Me.LblApplicationDomainDisplayTitle.Text = "پایانه امیر کبیر اصفهان"
        Me.LblApplicationDomainDisplayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcButtonSpecialSystemEntry
        '
        Me.UcButtonSpecialSystemEntry.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialSystemEntry.Location = New System.Drawing.Point(108, 139)
        Me.UcButtonSpecialSystemEntry.Name = "UcButtonSpecialSystemEntry"
        Me.UcButtonSpecialSystemEntry.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialSystemEntry.Size = New System.Drawing.Size(242, 51)
        Me.UcButtonSpecialSystemEntry.TabIndex = 205
        Me.UcButtonSpecialSystemEntry.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialSystemEntry.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialSystemEntry.UCEnable = true
        Me.UcButtonSpecialSystemEntry.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialSystemEntry.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialSystemEntry.UCValue = "ورود به سیستم"
        '
        'UcButtonSpecialWebServiceConnectingTest
        '
        Me.UcButtonSpecialWebServiceConnectingTest.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialWebServiceConnectingTest.Location = New System.Drawing.Point(108, 79)
        Me.UcButtonSpecialWebServiceConnectingTest.Name = "UcButtonSpecialWebServiceConnectingTest"
        Me.UcButtonSpecialWebServiceConnectingTest.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialWebServiceConnectingTest.Size = New System.Drawing.Size(242, 49)
        Me.UcButtonSpecialWebServiceConnectingTest.TabIndex = 206
        Me.UcButtonSpecialWebServiceConnectingTest.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialWebServiceConnectingTest.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialWebServiceConnectingTest.UCEnable = true
        Me.UcButtonSpecialWebServiceConnectingTest.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialWebServiceConnectingTest.UCForeColor = System.Drawing.Color.DarkSlateGray
        Me.UcButtonSpecialWebServiceConnectingTest.UCValue = "تست اتصال به وب سرویس"
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.LightSlateGray
        Me.PnlMain.Controls.Add(Me.UcButtonSpecialUserCancellation)
        Me.PnlMain.Controls.Add(Me.LblApplicationDomainDisplayTitle)
        Me.PnlMain.Controls.Add(Me.UcButtonSpecialWebServiceConnectingTest)
        Me.PnlMain.Controls.Add(Me.UcButtonSpecialSystemEntry)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(465, 255)
        Me.PnlMain.TabIndex = 207
        '
        'UcButtonSpecialUserCancellation
        '
        Me.UcButtonSpecialUserCancellation.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialUserCancellation.Location = New System.Drawing.Point(108, 196)
        Me.UcButtonSpecialUserCancellation.Name = "UcButtonSpecialUserCancellation"
        Me.UcButtonSpecialUserCancellation.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialUserCancellation.Size = New System.Drawing.Size(242, 42)
        Me.UcButtonSpecialUserCancellation.TabIndex = 207
        Me.UcButtonSpecialUserCancellation.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonSpecialUserCancellation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialUserCancellation.UCEnable = true
        Me.UcButtonSpecialUserCancellation.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialUserCancellation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSpecialUserCancellation.UCValue = "انصراف"
        '
        'FrmcFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(467, 257)
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmcFirst"
        Me.Opacity = 0.9R
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmcFirst"
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents LblApplicationDomainDisplayTitle As Label
    Friend WithEvents UcButtonSpecialSystemEntry As UCButtonSpecial
    Friend WithEvents UcButtonSpecialWebServiceConnectingTest As UCButtonSpecial
    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcButtonSpecialUserCancellation As UCButtonSpecial
End Class
