Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBlackListReport
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBAllBlackList = New System.Windows.Forms.RadioButton()
        Me.RBActiveBlackList = New System.Windows.Forms.RadioButton()
        Me.UcDateTimeHolder = New R2CoreGUI.UCDateTimeHolder()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(284, 282)
        Me.PnlMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.RBAllBlackList)
        Me.Panel1.Controls.Add(Me.RBActiveBlackList)
        Me.Panel1.Location = New System.Drawing.Point(16, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 37)
        Me.Panel1.TabIndex = 356
        '
        'RBAllBlackList
        '
        Me.RBAllBlackList.AutoSize = true
        Me.RBAllBlackList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBAllBlackList.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBAllBlackList.Location = New System.Drawing.Point(0, 0)
        Me.RBAllBlackList.Name = "RBAllBlackList"
        Me.RBAllBlackList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBAllBlackList.Size = New System.Drawing.Size(116, 33)
        Me.RBAllBlackList.TabIndex = 355
        Me.RBAllBlackList.Text = "کل لیست سیاه"
        Me.RBAllBlackList.UseVisualStyleBackColor = true
        '
        'RBActiveBlackList
        '
        Me.RBActiveBlackList.AutoSize = true
        Me.RBActiveBlackList.Checked = true
        Me.RBActiveBlackList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBActiveBlackList.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBActiveBlackList.Location = New System.Drawing.Point(121, 0)
        Me.RBActiveBlackList.Name = "RBActiveBlackList"
        Me.RBActiveBlackList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBActiveBlackList.Size = New System.Drawing.Size(128, 33)
        Me.RBActiveBlackList.TabIndex = 354
        Me.RBActiveBlackList.TabStop = true
        Me.RBActiveBlackList.Text = "لیست سیاه فعال"
        Me.RBActiveBlackList.UseVisualStyleBackColor = true
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(42, 94)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(201, 181)
        Me.UcDateTimeHolder.TabIndex = 353
        Me.UcDateTimeHolder.UCDisableTimeSetting = false
        Me.UcDateTimeHolder.UCTime1 = "00:00:00"
        Me.UcDateTimeHolder.UCTime2 = "23:59:59"
        Me.UcDateTimeHolder.UCViewTitle = false
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
        Me.UcLabelTop.Size = New System.Drawing.Size(284, 52)
        Me.UcLabelTop.TabIndex = 352
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش تخلفات - لیست سیاه"
        '
        'UCBlackListReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCBlackListReport"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(304, 302)
        Me.PnlMain.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcDateTimeHolder As R2CoreGUI.UCDateTimeHolder
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents RBAllBlackList As Windows.Forms.RadioButton
    Friend WithEvents RBActiveBlackList As Windows.Forms.RadioButton
End Class
