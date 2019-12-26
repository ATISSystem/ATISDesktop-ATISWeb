<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRFIDCardTextMaintainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCRFIDCardTextMaintainer))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcTextBoxRFIDCardId = New R2CoreGUI.UCTextBox()
        Me.UcTextBoxRFIDCardNO = New R2CoreGUI.UCTextBox()
        Me.PictureRF = New System.Windows.Forms.PictureBox()
        Me.PicReturn = New System.Windows.Forms.PictureBox()
        Me.PnlMain.SuspendLayout
        CType(Me.PictureRF,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicReturn,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcTextBoxRFIDCardId)
        Me.PnlMain.Controls.Add(Me.UcTextBoxRFIDCardNO)
        Me.PnlMain.Controls.Add(Me.PictureRF)
        Me.PnlMain.Controls.Add(Me.PicReturn)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(240, 31)
        Me.PnlMain.TabIndex = 0
        '
        'UcTextBoxRFIDCardId
        '
        Me.UcTextBoxRFIDCardId.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxRFIDCardId.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcTextBoxRFIDCardId.Location = New System.Drawing.Point(30, 0)
        Me.UcTextBoxRFIDCardId.Name = "UcTextBoxRFIDCardId"
        Me.UcTextBoxRFIDCardId.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxRFIDCardId.Size = New System.Drawing.Size(54, 29)
        Me.UcTextBoxRFIDCardId.TabIndex = 3
        Me.UcTextBoxRFIDCardId.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxRFIDCardId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxRFIDCardId.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcTextBoxRFIDCardId.UCEnable = false
        Me.UcTextBoxRFIDCardId.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxRFIDCardId.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxRFIDCardId.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxRFIDCardId.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxRFIDCardId.UCMultiLine = false
        Me.UcTextBoxRFIDCardId.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxRFIDCardId.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxRFIDCardId.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxRFIDCardId.UCValue = ""
        '
        'UcTextBoxRFIDCardNO
        '
        Me.UcTextBoxRFIDCardNO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxRFIDCardNO.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxRFIDCardNO.Location = New System.Drawing.Point(84, 0)
        Me.UcTextBoxRFIDCardNO.Name = "UcTextBoxRFIDCardNO"
        Me.UcTextBoxRFIDCardNO.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxRFIDCardNO.Size = New System.Drawing.Size(124, 29)
        Me.UcTextBoxRFIDCardNO.TabIndex = 0
        Me.UcTextBoxRFIDCardNO.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxRFIDCardNO.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxRFIDCardNO.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcTextBoxRFIDCardNO.UCEnable = true
        Me.UcTextBoxRFIDCardNO.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxRFIDCardNO.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxRFIDCardNO.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.English
        Me.UcTextBoxRFIDCardNO.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxRFIDCardNO.UCMultiLine = false
        Me.UcTextBoxRFIDCardNO.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxRFIDCardNO.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxRFIDCardNO.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxRFIDCardNO.UCValue = ""
        '
        'PictureRF
        '
        Me.PictureRF.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureRF.Image = CType(resources.GetObject("PictureRF.Image"),System.Drawing.Image)
        Me.PictureRF.Location = New System.Drawing.Point(208, 0)
        Me.PictureRF.Name = "PictureRF"
        Me.PictureRF.Size = New System.Drawing.Size(30, 29)
        Me.PictureRF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureRF.TabIndex = 2
        Me.PictureRF.TabStop = false
        '
        'PicReturn
        '
        Me.PicReturn.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicReturn.Image = CType(resources.GetObject("PicReturn.Image"),System.Drawing.Image)
        Me.PicReturn.Location = New System.Drawing.Point(0, 0)
        Me.PicReturn.Name = "PicReturn"
        Me.PicReturn.Size = New System.Drawing.Size(30, 29)
        Me.PicReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicReturn.TabIndex = 1
        Me.PicReturn.TabStop = false
        '
        'UCRFIDCardTextMaintainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCRFIDCardTextMaintainer"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(246, 37)
        Me.PnlMain.ResumeLayout(false)
        CType(Me.PictureRF,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicReturn,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcTextBoxRFIDCardNO As UCTextBox
    Friend WithEvents PicReturn As PictureBox
    Friend WithEvents PictureRF As PictureBox
    Friend WithEvents UcTextBoxRFIDCardId As UCTextBox
End Class
