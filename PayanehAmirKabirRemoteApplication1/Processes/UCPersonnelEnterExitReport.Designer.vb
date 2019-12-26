
Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersonnelEnterExitReport
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
        Me.UcDateTimeHolder = New UCDateTimeHolder()
        Me.UcLabel5 = New UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(488, 413)
        Me.PnlMain.TabIndex = 0
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(18, 67)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(448, 324)
        Me.UcDateTimeHolder.TabIndex = 351
        Me.UcDateTimeHolder.UCDisableTimeSetting = true
        '
        'UcLabel5
        '
        Me.UcLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel5.Location = New System.Drawing.Point(3, 3)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(488, 52)
        Me.UcLabel5.TabIndex = 350
        Me.UcLabel5.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.White
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "گزارش تردد پرسنل"
        '
        'UCPersonnelEnterExitReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPersonnelEnterExitReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(494, 419)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcDateTimeHolder As UCDateTimeHolder
End Class
