
Imports System.Windows.Forms 

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersianMonths
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
        Me.LstMonths = New System.Windows.Forms.ListBox()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.LstMonths)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(113, 353)
        Me.PnlMain.TabIndex = 0
        '
        'LstMonths
        '
        Me.LstMonths.BackColor = System.Drawing.Color.White
        Me.LstMonths.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstMonths.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstMonths.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LstMonths.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LstMonths.FormattingEnabled = true
        Me.LstMonths.IntegralHeight = false
        Me.LstMonths.ItemHeight = 29
        Me.LstMonths.Items.AddRange(New Object() {"فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"})
        Me.LstMonths.Location = New System.Drawing.Point(0, 0)
        Me.LstMonths.Name = "LstMonths"
        Me.LstMonths.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LstMonths.Size = New System.Drawing.Size(111, 351)
        Me.LstMonths.TabIndex = 0
        '
        'UCPersianMonths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPersianMonths"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(119, 359)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents LstMonths As ListBox
End Class
