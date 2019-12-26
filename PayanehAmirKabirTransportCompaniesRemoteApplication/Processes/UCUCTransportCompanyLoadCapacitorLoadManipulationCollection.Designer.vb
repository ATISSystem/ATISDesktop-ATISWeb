Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCTransportCompanyLoadCapacitorLoadManipulationCollection
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
        Me.UcButtonSpecialRefresh = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcButtonSpecialAdd = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout
        Me.PnlTop.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcButtonSpecialRefresh)
        Me.PnlMain.Controls.Add(Me.PnlTop)
        Me.PnlMain.Controls.Add(Me.UcButtonSpecialAdd)
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(568, 400)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonSpecialRefresh
        '
        Me.UcButtonSpecialRefresh.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialRefresh.Location = New System.Drawing.Point(119, 53)
        Me.UcButtonSpecialRefresh.Name = "UcButtonSpecialRefresh"
        Me.UcButtonSpecialRefresh.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialRefresh.Size = New System.Drawing.Size(164, 41)
        Me.UcButtonSpecialRefresh.TabIndex = 2
        Me.UcButtonSpecialRefresh.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialRefresh.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialRefresh.UCEnable = true
        Me.UcButtonSpecialRefresh.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialRefresh.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialRefresh.UCValue = "نمایش مجدد لیست بار"
        '
        'PnlTop
        '
        Me.PnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTop.Controls.Add(Me.UcLabel1)
        Me.PnlTop.Location = New System.Drawing.Point(3, 3)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(562, 45)
        Me.PnlTop.TabIndex = 0
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(560, 43)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "لیست بار شرکت حمل و نقل"
        '
        'UcButtonSpecialAdd
        '
        Me.UcButtonSpecialAdd.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialAdd.Location = New System.Drawing.Point(4, 53)
        Me.UcButtonSpecialAdd.Name = "UcButtonSpecialAdd"
        Me.UcButtonSpecialAdd.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialAdd.Size = New System.Drawing.Size(109, 41)
        Me.UcButtonSpecialAdd.TabIndex = 0
        Me.UcButtonSpecialAdd.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialAdd.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialAdd.UCEnable = true
        Me.UcButtonSpecialAdd.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialAdd.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialAdd.UCValue = "جدید"
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = true
        Me.PnlUCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUCs.Location = New System.Drawing.Point(3, 100)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(562, 295)
        Me.PnlUCs.TabIndex = 1
        '
        'UCUCTransportCompanyLoadCapacitorLoadManipulationCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCTransportCompanyLoadCapacitorLoadManipulationCollection"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(588, 420)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlTop.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents UcLabel1 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents PnlUCs As Panel
    Friend WithEvents UcButtonSpecialRefresh As UCButtonSpecial
    Friend WithEvents UcButtonSpecialAdd As UCButtonSpecial
End Class
