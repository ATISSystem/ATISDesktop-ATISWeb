<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRFIDCard
    Inherits  UCGeneral

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCRFIDCard))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PicStartReading = New System.Windows.Forms.PictureBox()
        Me.PicStopReading = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxCardNo = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxCardId = New R2CoreGUI.UCPersianTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        CType(Me.PicStartReading,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicStopReading,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.PicStartReading)
        Me.PnlMain.Controls.Add(Me.PicStopReading)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.Panel2)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(351, 71)
        Me.PnlMain.TabIndex = 0
        '
        'PicStartReading
        '
        Me.PicStartReading.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicStartReading.Image = CType(resources.GetObject("PicStartReading.Image"),System.Drawing.Image)
        Me.PicStartReading.Location = New System.Drawing.Point(36, 8)
        Me.PicStartReading.Name = "PicStartReading"
        Me.PicStartReading.Size = New System.Drawing.Size(19, 16)
        Me.PicStartReading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStartReading.TabIndex = 20
        Me.PicStartReading.TabStop = false
        '
        'PicStopReading
        '
        Me.PicStopReading.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicStopReading.Image = CType(resources.GetObject("PicStopReading.Image"),System.Drawing.Image)
        Me.PicStopReading.Location = New System.Drawing.Point(11, 8)
        Me.PicStopReading.Name = "PicStopReading"
        Me.PicStopReading.Size = New System.Drawing.Size(19, 16)
        Me.PicStopReading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStopReading.TabIndex = 19
        Me.PicStopReading.TabStop = false
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(238, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "کارت آراف آی دی"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxCardNo)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxCardId)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(3, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 40)
        Me.Panel2.TabIndex = 1
        '
        'UcPersianTextBoxCardNo
        '
        Me.UcPersianTextBoxCardNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxCardNo.Location = New System.Drawing.Point(152, 7)
        Me.UcPersianTextBoxCardNo.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxCardNo.Name = "UcPersianTextBoxCardNo"
        Me.UcPersianTextBoxCardNo.Size = New System.Drawing.Size(102, 24)
        Me.UcPersianTextBoxCardNo.TabIndex = 17
        Me.UcPersianTextBoxCardNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxCardNo.UCEnable = false
        Me.UcPersianTextBoxCardNo.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcPersianTextBoxCardNo.UCForeColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxCardNo.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxCardNo.UCValue = ""
        '
        'UcPersianTextBoxCardId
        '
        Me.UcPersianTextBoxCardId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxCardId.Location = New System.Drawing.Point(5, 7)
        Me.UcPersianTextBoxCardId.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxCardId.Name = "UcPersianTextBoxCardId"
        Me.UcPersianTextBoxCardId.Size = New System.Drawing.Size(84, 24)
        Me.UcPersianTextBoxCardId.TabIndex = 16
        Me.UcPersianTextBoxCardId.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxCardId.UCEnable = false
        Me.UcPersianTextBoxCardId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcPersianTextBoxCardId.UCForeColor = System.Drawing.Color.Red
        Me.UcPersianTextBoxCardId.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxCardId.UCValue = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "کد کارت :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "شماره کارت :"
        '
        'UCRFIDCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCRFIDCard"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(357, 77)
        Me.PnlMain.ResumeLayout(false)
        CType(Me.PicStartReading,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicStopReading,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UcPersianTextBoxCardNo As UCPersianTextBox
    Friend WithEvents UcPersianTextBoxCardId As UCPersianTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicStartReading As PictureBox
    Friend WithEvents PicStopReading As PictureBox
End Class
