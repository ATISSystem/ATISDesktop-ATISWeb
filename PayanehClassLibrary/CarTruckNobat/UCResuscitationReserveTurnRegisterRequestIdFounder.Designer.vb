
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCResuscitationReserveTurnRegisterRequestIdFounder
    Inherits UCGeneral


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
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcLabelTurnRegisteringRequestId = New R2CoreGUI.UCLabel()
        Me.CButtonTurnPrintRequestIdFound = New CButtonLib.CButton()
        Me.UcPersianDateTimeEntry = New R2CoreGUI.UCPersianDateTimeEntry()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(2, 2)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(808, 72)
        Me.PnlOutter.TabIndex = 2
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcLabelTurnRegisteringRequestId)
        Me.PnlInner.Controls.Add(Me.CButtonTurnPrintRequestIdFound)
        Me.PnlInner.Controls.Add(Me.UcPersianDateTimeEntry)
        Me.PnlInner.Controls.Add(Me.UcLabelTop)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(804, 68)
        Me.PnlInner.TabIndex = 2
        '
        'UcLabelTurnRegisteringRequestId
        '
        Me.UcLabelTurnRegisteringRequestId._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTurnRegisteringRequestId._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTurnRegisteringRequestId.BackColor = System.Drawing.Color.White
        Me.UcLabelTurnRegisteringRequestId.Location = New System.Drawing.Point(125, 40)
        Me.UcLabelTurnRegisteringRequestId.Name = "UcLabelTurnRegisteringRequestId"
        Me.UcLabelTurnRegisteringRequestId.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTurnRegisteringRequestId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelTurnRegisteringRequestId.Size = New System.Drawing.Size(104, 25)
        Me.UcLabelTurnRegisteringRequestId.TabIndex = 352
        Me.UcLabelTurnRegisteringRequestId.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTurnRegisteringRequestId.UCFont = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcLabelTurnRegisteringRequestId.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabelTurnRegisteringRequestId.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTurnRegisteringRequestId.UCValue = "0"
        '
        'CButtonTurnPrintRequestIdFound
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0!, 0.2993827!, 0.9969136!, 1.0!}
        Me.CButtonTurnPrintRequestIdFound.ColorFillBlend = CBlendItems1
        Me.CButtonTurnPrintRequestIdFound.ColorFillSolid = System.Drawing.SystemColors.ActiveCaption
        Me.CButtonTurnPrintRequestIdFound.Corners.LowerRight = 10
        Me.CButtonTurnPrintRequestIdFound.Corners.UpperLeft = 10
        Me.CButtonTurnPrintRequestIdFound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonTurnPrintRequestIdFound.DesignerSelected = False
        Me.CButtonTurnPrintRequestIdFound.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonTurnPrintRequestIdFound.ImageIndex = 0
        Me.CButtonTurnPrintRequestIdFound.Location = New System.Drawing.Point(6, 40)
        Me.CButtonTurnPrintRequestIdFound.Name = "CButtonTurnPrintRequestIdFound"
        Me.CButtonTurnPrintRequestIdFound.Size = New System.Drawing.Size(113, 24)
        Me.CButtonTurnPrintRequestIdFound.TabIndex = 353
        Me.CButtonTurnPrintRequestIdFound.Text = "تایید"
        '
        'UcPersianDateTimeEntry
        '
        Me.UcPersianDateTimeEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianDateTimeEntry.BackColor = System.Drawing.Color.White
        Me.UcPersianDateTimeEntry.Location = New System.Drawing.Point(421, 38)
        Me.UcPersianDateTimeEntry.Name = "UcPersianDateTimeEntry"
        Me.UcPersianDateTimeEntry.Size = New System.Drawing.Size(227, 26)
        Me.UcPersianDateTimeEntry.TabIndex = 350
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
        Me.UcLabelTop.Size = New System.Drawing.Size(804, 37)
        Me.UcLabelTop.TabIndex = 349
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelTop.UCValue = "تعیین تاریخ و زمان نوبت رزرو"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(646, 32)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(155, 32)
        Me.UcLabel1.TabIndex = 351
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "تاریخ و زمان نوبت رزرو :"
        '
        'UCResuscitationReserveTurnRegisterRequestIdFounder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlOutter)
        Me.Name = "UCResuscitationReserveTurnRegisterRequestIdFounder"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(812, 76)
        Me.PnlOutter.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents UcPersianDateTimeEntry As UCPersianDateTimeEntry
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelTurnRegisteringRequestId As UCLabel
    Friend WithEvents CButtonTurnPrintRequestIdFound As CButtonLib.CButton
End Class
