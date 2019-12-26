
Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCContractorCompanyFinancialReport
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
        Me.ChkVat = New System.Windows.Forms.CheckBox()
        Me.UcLabel5 = New UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlMain.Controls.Add(Me.ChkVat)
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(365, 488)
        Me.PnlMain.TabIndex = 0
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(15, 75)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(328, 341)
        Me.UcDateTimeHolder.TabIndex = 352
        Me.UcDateTimeHolder.UCDisableTimeSetting = false
        '
        'ChkVat
        '
        Me.ChkVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ChkVat.AutoSize = true
        Me.ChkVat.Checked = true
        Me.ChkVat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkVat.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkVat.Location = New System.Drawing.Point(211, 422)
        Me.ChkVat.Name = "ChkVat"
        Me.ChkVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkVat.Size = New System.Drawing.Size(123, 39)
        Me.ChkVat.TabIndex = 351
        Me.ChkVat.Text = "مبالغ مصوب"
        Me.ChkVat.UseVisualStyleBackColor = true
        '
        'UcLabel5
        '
        Me.UcLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel5.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(363, 52)
        Me.UcLabel5.TabIndex = 350
        Me.UcLabel5.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.White
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "گزارش درآمد حاصل از پارکینگ به تفکیک نوع خودرو"
        '
        'UCContractorCompanyFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCContractorCompanyFinancialReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(371, 494)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcDateTimeHolder As UCDateTimeHolder
    Friend WithEvents ChkVat As System.Windows.Forms.CheckBox
    Friend WithEvents UcLabel5 As UCLabel
End Class
