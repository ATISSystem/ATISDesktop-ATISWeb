Imports R2CoreGUI

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
        Me.UcDateTimeHolder = New R2CoreGUI.UCDateTimeHolder()
        Me.ChkVat = New System.Windows.Forms.CheckBox()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlMain.Controls.Add(Me.ChkVat)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(433, 314)
        Me.PnlMain.TabIndex = 0
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(120, 75)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(192, 186)
        Me.UcDateTimeHolder.TabIndex = 352
        Me.UcDateTimeHolder.UCDisableTimeSetting = true
        Me.UcDateTimeHolder.UCTime1 = "07:00:00"
        Me.UcDateTimeHolder.UCTime2 = "06:59:59"
        Me.UcDateTimeHolder.UCViewTitle = false
        '
        'ChkVat
        '
        Me.ChkVat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkVat.AutoSize = true
        Me.ChkVat.Checked = true
        Me.ChkVat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkVat.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkVat.Location = New System.Drawing.Point(92, 267)
        Me.ChkVat.Name = "ChkVat"
        Me.ChkVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkVat.Size = New System.Drawing.Size(248, 39)
        Me.ChkVat.TabIndex = 351
        Me.ChkVat.Text = "مبالغ مصوب(بدون ارزش افزوده)"
        Me.ChkVat.UseVisualStyleBackColor = true
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(433, 52)
        Me.UcLabelTop.TabIndex = 350
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش کلی درآمد حاصل از پارکینگ به تفکیک نوع خودرو"
        '
        'UCContractorCompanyFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCContractorCompanyFinancialReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(439, 320)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcDateTimeHolder As R2CoreGUI.UCDateTimeHolder
    Friend WithEvents ChkVat As System.Windows.Forms.CheckBox
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
End Class
