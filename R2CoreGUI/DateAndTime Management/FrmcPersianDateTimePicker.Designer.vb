<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPersianDateTimePicker
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcPersianDateTimePicker))
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PersianMonthCalendar = New FreeControls.PersianMonthCalendar()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.CButton = New CButtonLib.CButton()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PersianMonthCalendar
        '
        Me.PersianMonthCalendar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PersianMonthCalendar.BackColor = System.Drawing.Color.White
        Me.PersianMonthCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PersianMonthCalendar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.PersianMonthCalendar.ForeColor = System.Drawing.Color.Black
        Me.PersianMonthCalendar.Location = New System.Drawing.Point(0, 0)
        Me.PersianMonthCalendar.MarkColor = System.Drawing.Color.Green
        Me.PersianMonthCalendar.MaximumSize = New System.Drawing.Size(325, 172)
        Me.PersianMonthCalendar.MinimumSize = New System.Drawing.Size(325, 172)
        Me.PersianMonthCalendar.Name = "PersianMonthCalendar"
        Me.PersianMonthCalendar.ShowToday = true
        Me.PersianMonthCalendar.Size = New System.Drawing.Size(325, 172)
        Me.PersianMonthCalendar.TabIndex = 0
        Me.PersianMonthCalendar.Text = "PersianMonthCalendar1"
        Me.PersianMonthCalendar.TitleBackColor = System.Drawing.Color.SteelBlue
        Me.PersianMonthCalendar.TitleForeColor = System.Drawing.Color.White
        Me.PersianMonthCalendar.Value = CType(resources.GetObject("PersianMonthCalendar.Value"),FreeControls.PersianDate)
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.CButton)
        Me.PnlMain.Controls.Add(Me.PersianMonthCalendar)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(324, 223)
        Me.PnlMain.TabIndex = 1
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.MidnightBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))}
        CBlendItems1.iPoint = New Single() {0!, 0.1208791!, 0.4322344!, 0.5494506!, 1!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.SandyBrown
        Me.CButton.Corners.LowerLeft = 12
        Me.CButton.Corners.LowerRight = 12
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = false
        Me.CButton.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CButton.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CButton.ForeColor = System.Drawing.Color.Navy
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(7, 178)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(47, 37)
        Me.CButton.TabIndex = 6
        Me.CButton.Text = "تایید"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.LightSteelBlue
        Me.CButton.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'FrmcPersianDateTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(330, 229)
        Me.ControlBox = false
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmcPersianDateTimePicker"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = true
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PersianMonthCalendar As FreeControls.PersianMonthCalendar
    Friend WithEvents PnlMain As Panel
    Friend WithEvents CButton As CButtonLib.CButton
End Class
