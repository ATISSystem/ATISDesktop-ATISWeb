Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadTargetTravelLength
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
        Me.UcSearcher = New R2CoreGUI.UCSearcherSimple()
        Me.UcCity = New R2CoreParkingSystem.UCCity()
        Me.UcListBoxCitys = New R2CoreParkingSystem.UCListBoxCitys()
        Me.UcLabel6 = New R2CoreGUI.UCLabel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcSearcher)
        Me.PnlMain.Controls.Add(Me.UcCity)
        Me.PnlMain.Controls.Add(Me.UcListBoxCitys)
        Me.PnlMain.Controls.Add(Me.UcLabel6)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(449, 556)
        Me.PnlMain.TabIndex = 0
        '
        'UcSearcher
        '
        Me.UcSearcher.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcher.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcher.Location = New System.Drawing.Point(4, 87)
        Me.UcSearcher.Name = "UcSearcher"
        Me.UcSearcher.Padding = New System.Windows.Forms.Padding(10)
        Me.UcSearcher.Size = New System.Drawing.Size(433, 56)
        Me.UcSearcher.TabIndex = 15
        '
        'UcCity
        '
        Me.UcCity.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.UcCity.BackColor = System.Drawing.Color.Transparent
        Me.UcCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UcCity.Location = New System.Drawing.Point(4, 467)
        Me.UcCity.Name = "UcCity"
        Me.UcCity.Padding = New System.Windows.Forms.Padding(10)
        Me.UcCity.Size = New System.Drawing.Size(440, 79)
        Me.UcCity.TabIndex = 14
        '
        'UcListBoxCitys
        '
        Me.UcListBoxCitys.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.UcListBoxCitys.BackColor = System.Drawing.Color.Transparent
        Me.UcListBoxCitys.Location = New System.Drawing.Point(4, 138)
        Me.UcListBoxCitys.Name = "UcListBoxCitys"
        Me.UcListBoxCitys.Padding = New System.Windows.Forms.Padding(10)
        Me.UcListBoxCitys.Size = New System.Drawing.Size(436, 334)
        Me.UcListBoxCitys.TabIndex = 13
        Me.UcListBoxCitys.UCBackColor = System.Drawing.Color.White
        Me.UcListBoxCitys.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcListBoxCitys.UCForeColor = System.Drawing.Color.Black
        Me.UcListBoxCitys.UCTitle = "لیست شهرها"
        '
        'UcLabel6
        '
        Me.UcLabel6._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel6._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel6.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel6.Location = New System.Drawing.Point(4, 59)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel6.Size = New System.Drawing.Size(440, 33)
        Me.UcLabel6.TabIndex = 12
        Me.UcLabel6.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel6.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel6.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel6.UCValue = "قسمتی از نام شهر مورد جستجو را وارد نمایید"
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
        Me.UcLabelTop.Size = New System.Drawing.Size(449, 53)
        Me.UcLabelTop.TabIndex = 11
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "مقاصد حمل بار"
        '
        'UCLoadTargetTravelLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadTargetTravelLength"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(459, 566)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcSearcher As R2CoreGUI.UCSearcherSimple
    Friend WithEvents UcCity As UCCity
    Friend WithEvents UcListBoxCitys As UCListBoxCitys
    Friend WithEvents UcLabel6 As R2CoreGUI.UCLabel
End Class
