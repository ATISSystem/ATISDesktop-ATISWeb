Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCResuscitationSedimentedLoadbynEstelamId
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
        Me.UcButtonResuscitation = New R2CoreGUI.UCButton()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcNumbernEstelamId = New R2CoreGUI.UCNumber()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcButtonResuscitation)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcNumbernEstelamId)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(476, 103)
        Me.PnlMain.TabIndex = 0
        '
        'UcButtonResuscitation
        '
        Me.UcButtonResuscitation.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonResuscitation.Location = New System.Drawing.Point(15, 59)
        Me.UcButtonResuscitation.Name = "UcButtonResuscitation"
        Me.UcButtonResuscitation.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonResuscitation.Size = New System.Drawing.Size(66, 34)
        Me.UcButtonResuscitation.TabIndex = 13
        Me.UcButtonResuscitation.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonResuscitation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonResuscitation.UCEnable = true
        Me.UcButtonResuscitation.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonResuscitation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonResuscitation.UCValue = "احیاء"
        '
        'UcLabelTop
        '
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(476, 53)
        Me.UcLabelTop.TabIndex = 12
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "احیاء بار رسوب شده"
        '
        'UcNumbernEstelamId
        '
        Me.UcNumbernEstelamId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernEstelamId.Location = New System.Drawing.Point(88, 65)
        Me.UcNumbernEstelamId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernEstelamId.Name = "UcNumbernEstelamId"
        Me.UcNumbernEstelamId.Size = New System.Drawing.Size(100, 25)
        Me.UcNumbernEstelamId.TabIndex = 1
        Me.UcNumbernEstelamId.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernEstelamId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernEstelamId.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumbernEstelamId.UCEnable = true
        Me.UcNumbernEstelamId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernEstelamId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernEstelamId.UCValue = CType(0,Long)
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(195, 57)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(269, 32)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.MediumBlue
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کد مخزن بار را برای بار مورد نظر وارد نمایید :"
        '
        'UCResuscitationSedimentedLoadbynEstelamId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCResuscitationSedimentedLoadbynEstelamId"
        Me.Size = New System.Drawing.Size(476, 103)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcNumbernEstelamId As R2CoreGUI.UCNumber
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonResuscitation As UCButton
    Friend WithEvents UcLabelTop As UCLabel
End Class
