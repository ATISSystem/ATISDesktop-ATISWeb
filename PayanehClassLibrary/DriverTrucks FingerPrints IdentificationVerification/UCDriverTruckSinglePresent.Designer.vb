Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDriverTruckSinglePresent
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
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelDateShamsi = New R2CoreGUI.UCLabel()
        Me.UcLabelTime = New R2CoreGUI.UCLabel()
        Me.UcLabelPersonFullName = New R2CoreGUI.UCLabel()
        Me.UcLabelLPString = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Yellow
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabel4)
        Me.PnlMain.Controls.Add(Me.UcLabel3)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcLabelDateShamsi)
        Me.PnlMain.Controls.Add(Me.UcLabelTime)
        Me.PnlMain.Controls.Add(Me.UcLabelPersonFullName)
        Me.PnlMain.Controls.Add(Me.UcLabelLPString)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(690, 54)
        Me.PnlMain.TabIndex = 2
        '
        'UcLabel4
        '
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(-3, -6)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(97, 22)
        Me.UcLabel4.TabIndex = 15
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.LightGray
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "تاریخ"
        '
        'UcLabel3
        '
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(100, -7)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(109, 25)
        Me.UcLabel3.TabIndex = 14
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.LightGray
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "ساعت"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(215, -9)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(348, 32)
        Me.UcLabel2.TabIndex = 13
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.LightGray
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "راننده"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(569, -9)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(116, 32)
        Me.UcLabel1.TabIndex = 12
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.LightGray
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "ناوگان"
        '
        'UcLabelDateShamsi
        '
        Me.UcLabelDateShamsi.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi.Location = New System.Drawing.Point(3, 17)
        Me.UcLabelDateShamsi.Name = "UcLabelDateShamsi"
        Me.UcLabelDateShamsi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDateShamsi.Size = New System.Drawing.Size(97, 32)
        Me.UcLabelDateShamsi.TabIndex = 11
        Me.UcLabelDateShamsi.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateShamsi.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateShamsi.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelDateShamsi.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDateShamsi.UCValue = "1394/08/08"
        '
        'UcLabelTime
        '
        Me.UcLabelTime.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTime.Location = New System.Drawing.Point(106, 17)
        Me.UcLabelTime.Name = "UcLabelTime"
        Me.UcLabelTime.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTime.Size = New System.Drawing.Size(109, 32)
        Me.UcLabelTime.TabIndex = 10
        Me.UcLabelTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTime.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTime.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTime.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTime.UCValue = "12:02:02"
        '
        'UcLabelPersonFullName
        '
        Me.UcLabelPersonFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelPersonFullName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelPersonFullName.Location = New System.Drawing.Point(215, 14)
        Me.UcLabelPersonFullName.Name = "UcLabelPersonFullName"
        Me.UcLabelPersonFullName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelPersonFullName.Size = New System.Drawing.Size(348, 32)
        Me.UcLabelPersonFullName.TabIndex = 9
        Me.UcLabelPersonFullName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelPersonFullName.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelPersonFullName.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelPersonFullName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelPersonFullName.UCValue = "مرتضی شاهمرادی دستجردی"
        '
        'UcLabelLPString
        '
        Me.UcLabelLPString.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelLPString.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLPString.Location = New System.Drawing.Point(569, 17)
        Me.UcLabelLPString.Name = "UcLabelLPString"
        Me.UcLabelLPString.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLPString.Size = New System.Drawing.Size(116, 32)
        Me.UcLabelLPString.TabIndex = 8
        Me.UcLabelLPString.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLPString.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelLPString.UCForeColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelLPString.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLPString.UCValue = "813ی48-13"
        '
        'UCDriverTruckSinglePresent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDriverTruckSinglePresent"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(710, 74)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabelDateShamsi As UCLabel
    Friend WithEvents UcLabelTime As UCLabel
    Friend WithEvents UcLabelPersonFullName As UCLabel
    Friend WithEvents UcLabelLPString As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabel3 As UCLabel
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
End Class
