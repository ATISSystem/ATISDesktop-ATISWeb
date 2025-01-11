<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarNativenessManipulation
    Inherits UCCarNativeness


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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcLabelCarLPR = New R2CoreGUI.UCLabel()
        Me.CButtonCarNativeness = New CButtonLib.CButton()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcPersianShamsiDate)
        Me.PnlMain.Controls.Add(Me.UcLabelCarLPR)
        Me.PnlMain.Controls.Add(Me.CButtonCarNativeness)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(332, 31)
        Me.PnlMain.TabIndex = 2
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(89, -1)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(140, 23)
        Me.UcPersianShamsiDate.TabIndex = 3
        Me.UcPersianShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'UcLabelCarLPR
        '
        Me.UcLabelCarLPR._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelCarLPR._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelCarLPR.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarLPR.Location = New System.Drawing.Point(2, 0)
        Me.UcLabelCarLPR.Name = "UcLabelCarLPR"
        Me.UcLabelCarLPR.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCarLPR.Size = New System.Drawing.Size(81, 26)
        Me.UcLabelCarLPR.TabIndex = 2
        Me.UcLabelCarLPR.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarLPR.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelCarLPR.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelCarLPR.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCarLPR.UCValue = "888ع88-88"
        '
        'CButtonCarNativeness
        '
        Me.CButtonCarNativeness.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0!, 0.4537037!, 1.0!}
        Me.CButtonCarNativeness.ColorFillBlend = CBlendItems1
        Me.CButtonCarNativeness.Corners.LowerLeft = 10
        Me.CButtonCarNativeness.Corners.UpperRight = 10
        Me.CButtonCarNativeness.DesignerSelected = True
        Me.CButtonCarNativeness.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonCarNativeness.ImageIndex = 0
        Me.CButtonCarNativeness.Location = New System.Drawing.Point(235, 1)
        Me.CButtonCarNativeness.Name = "CButtonCarNativeness"
        Me.CButtonCarNativeness.Size = New System.Drawing.Size(92, 25)
        Me.CButtonCarNativeness.TabIndex = 0
        Me.CButtonCarNativeness.Text = "غیر بومی"
        '
        'UCCarNativenessManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarNativenessManipulation"
        Me.Size = New System.Drawing.Size(332, 31)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcPersianShamsiDate As R2CoreGUI.UCPersianShamsiDate
    Friend WithEvents UcLabelCarLPR As R2CoreGUI.UCLabel
    Friend WithEvents CButtonCarNativeness As CButtonLib.CButton
End Class
