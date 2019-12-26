
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcGeneral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcGeneral))
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.TxtLocalMessage = New System.Windows.Forms.TextBox()
        Me.LblformPersianName = New System.Windows.Forms.Label()
        Me.LblformEnglishName = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlHeader.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicExit
        '
        Me.PicExit.BackColor = System.Drawing.Color.White
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"), System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(232, 5)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(25, 26)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 43
        Me.PicExit.TabStop = False
        '
        'TxtLocalMessage
        '
        Me.TxtLocalMessage.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtLocalMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocalMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLocalMessage.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtLocalMessage.ForeColor = System.Drawing.Color.White
        Me.TxtLocalMessage.Location = New System.Drawing.Point(1, 570)
        Me.TxtLocalMessage.Multiline = True
        Me.TxtLocalMessage.Name = "TxtLocalMessage"
        Me.TxtLocalMessage.ReadOnly = True
        Me.TxtLocalMessage.Size = New System.Drawing.Size(1001, 27)
        Me.TxtLocalMessage.TabIndex = 44
        '
        'LblformPersianName
        '
        Me.LblformPersianName.BackColor = System.Drawing.Color.White
        Me.LblformPersianName.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblformPersianName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblformPersianName.Location = New System.Drawing.Point(6, -3)
        Me.LblformPersianName.Name = "LblformPersianName"
        Me.LblformPersianName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblformPersianName.Size = New System.Drawing.Size(226, 42)
        Me.LblformPersianName.TabIndex = 45
        Me.LblformPersianName.Text = "گزارش اسناد دریافتنی"
        '
        'LblformEnglishName
        '
        Me.LblformEnglishName.BackColor = System.Drawing.Color.White
        Me.LblformEnglishName.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblformEnglishName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblformEnglishName.Location = New System.Drawing.Point(62, 25)
        Me.LblformEnglishName.Name = "LblformEnglishName"
        Me.LblformEnglishName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblformEnglishName.Size = New System.Drawing.Size(167, 14)
        Me.LblformEnglishName.TabIndex = 46
        Me.LblformEnglishName.Text = "FrmcSanadSabt"
        Me.LblformEnglishName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlHeader
        '
        Me.PnlHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlHeader.BackColor = System.Drawing.Color.White
        Me.PnlHeader.Controls.Add(Me.PicExit)
        Me.PnlHeader.Controls.Add(Me.LblformEnglishName)
        Me.PnlHeader.Controls.Add(Me.LblformPersianName)
        Me.PnlHeader.Location = New System.Drawing.Point(741, 3)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(260, 41)
        Me.PnlHeader.TabIndex = 47
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BackColor = System.Drawing.Color.Red
        Me.PnlMain.Controls.Add(Me.PnlHeader)
        Me.PnlMain.Controls.Add(Me.TxtLocalMessage)
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlMain.Size = New System.Drawing.Size(1003, 598)
        Me.PnlMain.TabIndex = 48
        '
        'PnlInner
        '
        Me.PnlInner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(1001, 596)
        Me.PnlInner.TabIndex = 48
        '
        'FrmcGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(10, 121)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmcGeneral"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmcGeneral"
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicExit As System.Windows.Forms.PictureBox
    Friend WithEvents TxtLocalMessage As System.Windows.Forms.TextBox
    Friend WithEvents LblformPersianName As System.Windows.Forms.Label
    Friend WithEvents LblformEnglishName As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlInner As Panel
End Class
