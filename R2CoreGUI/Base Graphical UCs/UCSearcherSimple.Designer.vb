<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSearcherSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSearcherSimple))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicRefresh = New System.Windows.Forms.PictureBox()
        Me.UcPersianTextBox = New R2CoreGUI.UCPersianTextBox()
        Me.PicReturn = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout
        CType(Me.PicRefresh,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicReturn,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PicReturn)
        Me.Panel1.Controls.Add(Me.PicRefresh)
        Me.Panel1.Controls.Add(Me.UcPersianTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 36)
        Me.Panel1.TabIndex = 5
        '
        'PicRefresh
        '
        Me.PicRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRefresh.Image = CType(resources.GetObject("PicRefresh.Image"),System.Drawing.Image)
        Me.PicRefresh.Location = New System.Drawing.Point(190, 7)
        Me.PicRefresh.Name = "PicRefresh"
        Me.PicRefresh.Size = New System.Drawing.Size(25, 20)
        Me.PicRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefresh.TabIndex = 4
        Me.PicRefresh.TabStop = false
        '
        'UcPersianTextBox
        '
        Me.UcPersianTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBox.Location = New System.Drawing.Point(3, 3)
        Me.UcPersianTextBox.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBox.Name = "UcPersianTextBox"
        Me.UcPersianTextBox.Size = New System.Drawing.Size(218, 28)
        Me.UcPersianTextBox.TabIndex = 0
        Me.UcPersianTextBox.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox.UCBorder = true
        Me.UcPersianTextBox.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBox.UCEnable = true
        Me.UcPersianTextBox.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBox.UCForeColor = System.Drawing.Color.Gray
        Me.UcPersianTextBox.UCMultiLine = false
        Me.UcPersianTextBox.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBox.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox.UCValue = ""
        '
        'PicReturn
        '
        Me.PicReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicReturn.Image = CType(resources.GetObject("PicReturn.Image"),System.Drawing.Image)
        Me.PicReturn.Location = New System.Drawing.Point(7, 7)
        Me.PicReturn.Name = "PicReturn"
        Me.PicReturn.Size = New System.Drawing.Size(25, 20)
        Me.PicReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicReturn.TabIndex = 3
        Me.PicReturn.TabStop = false
        '
        'UCSearcherSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCSearcherSimple"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(248, 56)
        Me.Panel1.ResumeLayout(false)
        CType(Me.PicRefresh,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicReturn,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UcPersianTextBox As UCPersianTextBox
    Friend WithEvents PicReturn As PictureBox
    Friend WithEvents PicRefresh As PictureBox
End Class
