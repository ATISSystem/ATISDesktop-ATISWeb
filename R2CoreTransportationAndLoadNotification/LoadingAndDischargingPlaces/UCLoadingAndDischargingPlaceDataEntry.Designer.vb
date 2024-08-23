<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCLoadingAndDischargingPlaceDataEntry
    Inherits UCLoadingAndDischargingPlace

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabelLADPlaceId = New R2CoreGUI.UCLabel()
        Me.UcPersianTextBoxLADPlaceTilte = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.CButtonDischargingPlaceChangeStatus = New CButtonLib.CButton()
        Me.CButtonLoadingPlaceChangeStatus = New CButtonLib.CButton()
        Me.CButtonNew = New CButtonLib.CButton()
        Me.CButtonDelete = New CButtonLib.CButton()
        Me.CButtonRegister = New CButtonLib.CButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcLabelDischargingActiveStatus = New R2CoreGUI.UCLabel()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcLabelLoadingActiveStatus = New R2CoreGUI.UCLabel()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(1, 1)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(739, 32)
        Me.UcLabelTop.TabIndex = 0
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.LightSteelBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "مبدا بارگیری - محل تخلیه"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(621, 83)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(63, 32)
        Me.UcLabel2.TabIndex = 2
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel2.UCValue = "شرح :"
        '
        'UcLabelLADPlaceId
        '
        Me.UcLabelLADPlaceId._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLADPlaceId._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLADPlaceId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelLADPlaceId.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLADPlaceId.Location = New System.Drawing.Point(55, 51)
        Me.UcLabelLADPlaceId.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcLabelLADPlaceId.Name = "UcLabelLADPlaceId"
        Me.UcLabelLADPlaceId.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcLabelLADPlaceId.Size = New System.Drawing.Size(560, 27)
        Me.UcLabelLADPlaceId.TabIndex = 3
        Me.UcLabelLADPlaceId.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLADPlaceId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcLabelLADPlaceId.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelLADPlaceId.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelLADPlaceId.UCValue = "1075"
        '
        'UcPersianTextBoxLADPlaceTilte
        '
        Me.UcPersianTextBoxLADPlaceTilte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxLADPlaceTilte.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxLADPlaceTilte.Location = New System.Drawing.Point(19, 85)
        Me.UcPersianTextBoxLADPlaceTilte.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcPersianTextBoxLADPlaceTilte.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxLADPlaceTilte.Name = "UcPersianTextBoxLADPlaceTilte"
        Me.UcPersianTextBoxLADPlaceTilte.Size = New System.Drawing.Size(596, 37)
        Me.UcPersianTextBoxLADPlaceTilte.TabIndex = 4
        Me.UcPersianTextBoxLADPlaceTilte.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxLADPlaceTilte.UCBorder = True
        Me.UcPersianTextBoxLADPlaceTilte.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxLADPlaceTilte.UCEnable = True
        Me.UcPersianTextBoxLADPlaceTilte.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxLADPlaceTilte.UCForeColor = System.Drawing.Color.Blue
        Me.UcPersianTextBoxLADPlaceTilte.UCMultiLine = False
        Me.UcPersianTextBoxLADPlaceTilte.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxLADPlaceTilte.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxLADPlaceTilte.UCValue = "انبار تکادو"
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.CButtonDischargingPlaceChangeStatus)
        Me.PnlMain.Controls.Add(Me.CButtonLoadingPlaceChangeStatus)
        Me.PnlMain.Controls.Add(Me.CButtonNew)
        Me.PnlMain.Controls.Add(Me.CButtonDelete)
        Me.PnlMain.Controls.Add(Me.CButtonRegister)
        Me.PnlMain.Controls.Add(Me.GroupBox1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 33)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(739, 255)
        Me.PnlMain.TabIndex = 5
        '
        'CButtonDischargingPlaceChangeStatus
        '
        Me.CButtonDischargingPlaceChangeStatus.Corners.LowerRight = 12
        Me.CButtonDischargingPlaceChangeStatus.Corners.UpperLeft = 12
        Me.CButtonDischargingPlaceChangeStatus.DesignerSelected = False
        Me.CButtonDischargingPlaceChangeStatus.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CButtonDischargingPlaceChangeStatus.ImageIndex = 0
        Me.CButtonDischargingPlaceChangeStatus.Location = New System.Drawing.Point(329, 21)
        Me.CButtonDischargingPlaceChangeStatus.Name = "CButtonDischargingPlaceChangeStatus"
        Me.CButtonDischargingPlaceChangeStatus.Size = New System.Drawing.Size(137, 31)
        Me.CButtonDischargingPlaceChangeStatus.TabIndex = 14
        Me.CButtonDischargingPlaceChangeStatus.Text = "تغییر وضعیت محل تخلیه"
        '
        'CButtonLoadingPlaceChangeStatus
        '
        Me.CButtonLoadingPlaceChangeStatus.Corners.LowerRight = 12
        Me.CButtonLoadingPlaceChangeStatus.Corners.UpperLeft = 12
        Me.CButtonLoadingPlaceChangeStatus.DesignerSelected = False
        Me.CButtonLoadingPlaceChangeStatus.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CButtonLoadingPlaceChangeStatus.ImageIndex = 0
        Me.CButtonLoadingPlaceChangeStatus.Location = New System.Drawing.Point(171, 21)
        Me.CButtonLoadingPlaceChangeStatus.Name = "CButtonLoadingPlaceChangeStatus"
        Me.CButtonLoadingPlaceChangeStatus.Size = New System.Drawing.Size(152, 31)
        Me.CButtonLoadingPlaceChangeStatus.TabIndex = 13
        Me.CButtonLoadingPlaceChangeStatus.Text = "تغییر وضعیت مبدا بارگیری"
        '
        'CButtonNew
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Gold, System.Drawing.Color.Yellow}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonNew.ColorFillBlend = CBlendItems1
        Me.CButtonNew.Corners.LowerRight = 12
        Me.CButtonNew.Corners.UpperLeft = 12
        Me.CButtonNew.DesignerSelected = False
        Me.CButtonNew.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CButtonNew.ForeColor = System.Drawing.Color.Black
        Me.CButtonNew.ImageIndex = 0
        Me.CButtonNew.Location = New System.Drawing.Point(472, 22)
        Me.CButtonNew.Name = "CButtonNew"
        Me.CButtonNew.Size = New System.Drawing.Size(52, 29)
        Me.CButtonNew.TabIndex = 9
        Me.CButtonNew.Text = "جدید"
        '
        'CButtonDelete
        '
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Red, System.Drawing.Color.Crimson}
        CBlendItems2.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonDelete.ColorFillBlend = CBlendItems2
        Me.CButtonDelete.Corners.LowerRight = 12
        Me.CButtonDelete.Corners.UpperLeft = 12
        Me.CButtonDelete.DesignerSelected = False
        Me.CButtonDelete.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CButtonDelete.ImageIndex = 0
        Me.CButtonDelete.Location = New System.Drawing.Point(113, 22)
        Me.CButtonDelete.Name = "CButtonDelete"
        Me.CButtonDelete.Size = New System.Drawing.Size(52, 29)
        Me.CButtonDelete.TabIndex = 5
        Me.CButtonDelete.Text = "حذف"
        '
        'CButtonRegister
        '
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Lime}
        CBlendItems3.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonRegister.ColorFillBlend = CBlendItems3
        Me.CButtonRegister.ColorFillSolid = System.Drawing.SystemColors.ActiveCaption
        Me.CButtonRegister.Corners.LowerLeft = 5
        Me.CButtonRegister.Corners.LowerRight = 12
        Me.CButtonRegister.Corners.UpperLeft = 12
        Me.CButtonRegister.Corners.UpperRight = 5
        Me.CButtonRegister.DesignerSelected = False
        Me.CButtonRegister.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CButtonRegister.ImageIndex = 0
        Me.CButtonRegister.Location = New System.Drawing.Point(35, 22)
        Me.CButtonRegister.Name = "CButtonRegister"
        Me.CButtonRegister.Size = New System.Drawing.Size(72, 29)
        Me.CButtonRegister.TabIndex = 5
        Me.CButtonRegister.Text = "ثبت"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UcLabelDischargingActiveStatus)
        Me.GroupBox1.Controls.Add(Me.UcLabel4)
        Me.GroupBox1.Controls.Add(Me.UcLabelLoadingActiveStatus)
        Me.GroupBox1.Controls.Add(Me.UcLabel3)
        Me.GroupBox1.Controls.Add(Me.UcLabel1)
        Me.GroupBox1.Controls.Add(Me.UcPersianTextBoxLADPlaceTilte)
        Me.GroupBox1.Controls.Add(Me.UcLabel2)
        Me.GroupBox1.Controls.Add(Me.UcLabelLADPlaceId)
        Me.GroupBox1.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(712, 216)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشاهده مبدا بارگیری یا محل تخلیه"
        '
        'UcLabelDischargingActiveStatus
        '
        Me.UcLabelDischargingActiveStatus._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelDischargingActiveStatus._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelDischargingActiveStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelDischargingActiveStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDischargingActiveStatus.Location = New System.Drawing.Point(277, 175)
        Me.UcLabelDischargingActiveStatus.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcLabelDischargingActiveStatus.Name = "UcLabelDischargingActiveStatus"
        Me.UcLabelDischargingActiveStatus.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcLabelDischargingActiveStatus.Size = New System.Drawing.Size(240, 32)
        Me.UcLabelDischargingActiveStatus.TabIndex = 14
        Me.UcLabelDischargingActiveStatus.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDischargingActiveStatus.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelDischargingActiveStatus.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDischargingActiveStatus.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelDischargingActiveStatus.UCValue = " فعال - غیرفعال"
        '
        'UcLabel4
        '
        Me.UcLabel4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel4.Location = New System.Drawing.Point(526, 175)
        Me.UcLabel4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel4.Size = New System.Drawing.Size(174, 32)
        Me.UcLabel4.TabIndex = 13
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel4.UCValue = "وضعیت محل تخلیه :"
        '
        'UcLabelLoadingActiveStatus
        '
        Me.UcLabelLoadingActiveStatus._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLoadingActiveStatus._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLoadingActiveStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelLoadingActiveStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadingActiveStatus.Location = New System.Drawing.Point(277, 143)
        Me.UcLabelLoadingActiveStatus.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.UcLabelLoadingActiveStatus.Name = "UcLabelLoadingActiveStatus"
        Me.UcLabelLoadingActiveStatus.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcLabelLoadingActiveStatus.Size = New System.Drawing.Size(240, 32)
        Me.UcLabelLoadingActiveStatus.TabIndex = 12
        Me.UcLabelLoadingActiveStatus.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadingActiveStatus.UCFont = New System.Drawing.Font("IRMehr", 9.75!)
        Me.UcLabelLoadingActiveStatus.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelLoadingActiveStatus.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelLoadingActiveStatus.UCValue = "فعال - غیرفعال"
        '
        'UcLabel3
        '
        Me.UcLabel3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.Location = New System.Drawing.Point(526, 144)
        Me.UcLabel3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel3.Size = New System.Drawing.Size(174, 32)
        Me.UcLabel3.TabIndex = 11
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel3.UCValue = "وضعیت مبدا بارگیری :"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(618, 51)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(57, 32)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "کد :"
        '
        'UCLoadingAndDischargingPlaceDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.UcLabelTop)
        Me.Name = "UCLoadingAndDischargingPlaceDataEntry"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(741, 289)
        Me.PnlMain.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelLADPlaceId As R2CoreGUI.UCLabel
    Friend WithEvents UcPersianTextBoxLADPlaceTilte As R2CoreGUI.UCPersianTextBox
    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents CButtonRegister As CButtonLib.CButton
    Friend WithEvents CButtonDelete As CButtonLib.CButton
    Friend WithEvents CButtonNew As CButtonLib.CButton
    Friend WithEvents UcLabelLoadingActiveStatus As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel3 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents CButtonLoadingPlaceChangeStatus As CButtonLib.CButton
    Friend WithEvents CButtonDischargingPlaceChangeStatus As CButtonLib.CButton
    Friend WithEvents UcLabel4 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelDischargingActiveStatus As R2CoreGUI.UCLabel
End Class
