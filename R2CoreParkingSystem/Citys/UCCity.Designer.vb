Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCity
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
        Me.UcLabel5 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelStrCityName = New R2CoreGUI.UCLabel()
        Me.UcLabelnCityCode = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcNumbernDistance = New R2CoreGUI.UCNumber()
        Me.UcNumbernProvince = New R2CoreGUI.UCNumber()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcNumbernProvince)
        Me.PnlMain.Controls.Add(Me.UcNumbernDistance)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcLabelStrCityName)
        Me.PnlMain.Controls.Add(Me.UcLabelnCityCode)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(461, 59)
        Me.PnlMain.TabIndex = 1
        '
        'UcLabel5
        '
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.ForeColor = System.Drawing.Color.Black
        Me.UcLabel5.Location = New System.Drawing.Point(51, -6)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(64, 31)
        Me.UcLabel5.TabIndex = 5
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "فاصله(ساعت)"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.ForeColor = System.Drawing.Color.Black
        Me.UcLabel3.Location = New System.Drawing.Point(121, -6)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(221, 31)
        Me.UcLabel3.TabIndex = 3
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "نام شهر"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.ForeColor = System.Drawing.Color.Black
        Me.UcLabel1.Location = New System.Drawing.Point(348, -6)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(103, 31)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کدشهر"
        '
        'UcLabelStrCityName
        '
        Me.UcLabelStrCityName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrCityName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrCityName.ForeColor = System.Drawing.Color.Black
        Me.UcLabelStrCityName.Location = New System.Drawing.Point(121, 22)
        Me.UcLabelStrCityName.Name = "UcLabelStrCityName"
        Me.UcLabelStrCityName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrCityName.Size = New System.Drawing.Size(221, 32)
        Me.UcLabelStrCityName.TabIndex = 4
        Me.UcLabelStrCityName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrCityName.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrCityName.UCForeColor = System.Drawing.Color.DarkRed
        Me.UcLabelStrCityName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrCityName.UCValue = "تهران اصفهان خراسان ایلام ایران"
        '
        'UcLabelnCityCode
        '
        Me.UcLabelnCityCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelnCityCode.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelnCityCode.ForeColor = System.Drawing.Color.Black
        Me.UcLabelnCityCode.Location = New System.Drawing.Point(348, 22)
        Me.UcLabelnCityCode.Name = "UcLabelnCityCode"
        Me.UcLabelnCityCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelnCityCode.Size = New System.Drawing.Size(103, 32)
        Me.UcLabelnCityCode.TabIndex = 2
        Me.UcLabelnCityCode.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelnCityCode.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelnCityCode.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelnCityCode.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelnCityCode.UCValue = "11320000"
        '
        'UcLabel2
        '
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.ForeColor = System.Drawing.Color.Black
        Me.UcLabel2.Location = New System.Drawing.Point(7, -7)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(38, 31)
        Me.UcLabel2.TabIndex = 7
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "کدویژه"
        '
        'UcNumbernDistance
        '
        Me.UcNumbernDistance.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernDistance.Location = New System.Drawing.Point(51, 31)
        Me.UcNumbernDistance.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernDistance.Name = "UcNumbernDistance"
        Me.UcNumbernDistance.Size = New System.Drawing.Size(64, 16)
        Me.UcNumbernDistance.TabIndex = 9
        Me.UcNumbernDistance.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernDistance.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernDistance.UCBorder = System.Windows.Forms.BorderStyle.None
        Me.UcNumbernDistance.UCEnable = true
        Me.UcNumbernDistance.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernDistance.UCForeColor = System.Drawing.Color.Red
        Me.UcNumbernDistance.UCValue = CType(24,Long)
        '
        'UcNumbernProvince
        '
        Me.UcNumbernProvince.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernProvince.Location = New System.Drawing.Point(7, 31)
        Me.UcNumbernProvince.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernProvince.Name = "UcNumbernProvince"
        Me.UcNumbernProvince.Size = New System.Drawing.Size(38, 16)
        Me.UcNumbernProvince.TabIndex = 10
        Me.UcNumbernProvince.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernProvince.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernProvince.UCBorder = System.Windows.Forms.BorderStyle.None
        Me.UcNumbernProvince.UCEnable = true
        Me.UcNumbernProvince.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernProvince.UCForeColor = System.Drawing.Color.Red
        Me.UcNumbernProvince.UCValue = CType(11,Long)
        '
        'UCCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCity"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(481, 79)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelStrCityName As UCLabel
    Friend WithEvents UcLabelnCityCode As UCLabel
    Friend WithEvents UcNumbernProvince As UCNumber
    Friend WithEvents UcNumbernDistance As UCNumber
    Friend WithEvents UcLabel2 As UCLabel
End Class
