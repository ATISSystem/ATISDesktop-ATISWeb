Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadPermissionCancellation
    Inherits UCLoadPermission

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
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcNumberLoadAllocationId = New R2CoreGUI.UCNumber()
        Me.CheckBoxTurn = New System.Windows.Forms.CheckBox()
        Me.UcButtonLoadPermissionCancelling = New R2CoreGUI.UCButton()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlBorder = New System.Windows.Forms.Panel()
        Me.UcViewerNSSLoadPermissionExtended = New R2CoreTransportationAndLoadNotification.UCViewerNSSLoadPermissionExtended()
        Me.PnlMain.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.PnlBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Size = New System.Drawing.Size(902, 125)
        Me.PnlMain.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcNumberLoadAllocationId)
        Me.PnlInner.Controls.Add(Me.CheckBoxTurn)
        Me.PnlInner.Controls.Add(Me.UcButtonLoadPermissionCancelling)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.PnlBorder)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(898, 121)
        Me.PnlInner.TabIndex = 16
        '
        'UcNumberLoadAllocationId
        '
        Me.UcNumberLoadAllocationId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberLoadAllocationId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberLoadAllocationId.Location = New System.Drawing.Point(661, 9)
        Me.UcNumberLoadAllocationId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberLoadAllocationId.Name = "UcNumberLoadAllocationId"
        Me.UcNumberLoadAllocationId.Size = New System.Drawing.Size(100, 25)
        Me.UcNumberLoadAllocationId.TabIndex = 14
        Me.UcNumberLoadAllocationId.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberLoadAllocationId.UCAllowedMinNumber = CType(-923372036854775808, Long)
        Me.UcNumberLoadAllocationId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberLoadAllocationId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberLoadAllocationId.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberLoadAllocationId.UCBorder = True
        Me.UcNumberLoadAllocationId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberLoadAllocationId.UCEnable = True
        Me.UcNumberLoadAllocationId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberLoadAllocationId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberLoadAllocationId.UCMultiLine = False
        Me.UcNumberLoadAllocationId.UCValue = CType(0, Long)
        '
        'CheckBoxTurn
        '
        Me.CheckBoxTurn.AutoSize = True
        Me.CheckBoxTurn.Checked = True
        Me.CheckBoxTurn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTurn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxTurn.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBoxTurn.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxTurn.Location = New System.Drawing.Point(144, 8)
        Me.CheckBoxTurn.Name = "CheckBoxTurn"
        Me.CheckBoxTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxTurn.Size = New System.Drawing.Size(142, 27)
        Me.CheckBoxTurn.TabIndex = 1
        Me.CheckBoxTurn.Text = "احیاء نوبت / ابطال نوبت"
        Me.CheckBoxTurn.UseVisualStyleBackColor = True
        '
        'UcButtonLoadPermissionCancelling
        '
        Me.UcButtonLoadPermissionCancelling.BackColor = System.Drawing.Color.PaleTurquoise
        Me.UcButtonLoadPermissionCancelling.Location = New System.Drawing.Point(12, 5)
        Me.UcButtonLoadPermissionCancelling.Name = "UcButtonLoadPermissionCancelling"
        Me.UcButtonLoadPermissionCancelling.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadPermissionCancelling.Size = New System.Drawing.Size(116, 36)
        Me.UcButtonLoadPermissionCancelling.TabIndex = 16
        Me.UcButtonLoadPermissionCancelling.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonLoadPermissionCancelling.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadPermissionCancelling.UCEnable = True
        Me.UcButtonLoadPermissionCancelling.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonLoadPermissionCancelling.UCForeColor = System.Drawing.Color.White
        Me.UcButtonLoadPermissionCancelling.UCValue = "کنسلی مجوز"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(770, 6)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel1.Size = New System.Drawing.Size(102, 27)
        Me.UcLabel1.TabIndex = 15
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabel1.UCValue = "شماره تخصیص بار"
        '
        'PnlBorder
        '
        Me.PnlBorder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBorder.Controls.Add(Me.UcViewerNSSLoadPermissionExtended)
        Me.PnlBorder.Location = New System.Drawing.Point(3, 22)
        Me.PnlBorder.Name = "PnlBorder"
        Me.PnlBorder.Size = New System.Drawing.Size(891, 95)
        Me.PnlBorder.TabIndex = 16
        '
        'UcViewerNSSLoadPermissionExtended
        '
        Me.UcViewerNSSLoadPermissionExtended.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcViewerNSSLoadPermissionExtended.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSLoadPermissionExtended.Location = New System.Drawing.Point(-2, 11)
        Me.UcViewerNSSLoadPermissionExtended.Name = "UcViewerNSSLoadPermissionExtended"
        Me.UcViewerNSSLoadPermissionExtended.Padding = New System.Windows.Forms.Padding(10)
        Me.UcViewerNSSLoadPermissionExtended.Size = New System.Drawing.Size(894, 89)
        Me.UcViewerNSSLoadPermissionExtended.TabIndex = 0
        Me.UcViewerNSSLoadPermissionExtended.UCNSSCurrent = Nothing
        '
        'UCLoadPermissionCancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadPermissionCancellation"
        Me.Size = New System.Drawing.Size(902, 125)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.PnlInner.PerformLayout()
        Me.PnlBorder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxTurn As System.Windows.Forms.CheckBox
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents UcButtonLoadPermissionCancelling As UCButton
    Friend WithEvents PnlBorder As System.Windows.Forms.Panel
    Friend WithEvents UcNumberLoadAllocationId As UCNumber
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcViewerNSSLoadPermissionExtended As UCViewerNSSLoadPermissionExtended
End Class
