Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarTruckUpdateInf
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
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcCarTruck = New PayanehClassLibrary.UCCarTruck()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcButtonSpecialCancel = New R2CoreGUI.UCButtonSpecial()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcButtonSpecialConfirm = New R2CoreGUI.UCButtonSpecial()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
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
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(4, 43)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(723, 153)
        Me.UcCarTruck.TabIndex = 0
        Me.UcCarTruck.UCViewButtons = false
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(737, 251)
        Me.PnlMain.TabIndex = 1
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(737, 251)
        Me.PnlOutter.TabIndex = 1
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcButtonSpecialCancel)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.UcButtonSpecialConfirm)
        Me.PnlInner.Controls.Add(Me.UcCarTruck)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Padding = New System.Windows.Forms.Padding(5)
        Me.PnlInner.Size = New System.Drawing.Size(731, 245)
        Me.PnlInner.TabIndex = 0
        '
        'UcButtonSpecialCancel
        '
        Me.UcButtonSpecialCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonSpecialCancel.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialCancel.Location = New System.Drawing.Point(381, 198)
        Me.UcButtonSpecialCancel.Name = "UcButtonSpecialCancel"
        Me.UcButtonSpecialCancel.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialCancel.Size = New System.Drawing.Size(96, 41)
        Me.UcButtonSpecialCancel.TabIndex = 3
        Me.UcButtonSpecialCancel.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonSpecialCancel.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialCancel.UCEnable = true
        Me.UcButtonSpecialCancel.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialCancel.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSpecialCancel.UCValue = "انصراف"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(5, 5)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(721, 32)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Red
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "ناوگان باری - شماره هوشمند ناوگان را وارد نمایید و سپس کلید اینتر را فشار دهید"
        '
        'UcButtonSpecialConfirm
        '
        Me.UcButtonSpecialConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonSpecialConfirm.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialConfirm.Location = New System.Drawing.Point(253, 198)
        Me.UcButtonSpecialConfirm.Name = "UcButtonSpecialConfirm"
        Me.UcButtonSpecialConfirm.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialConfirm.Size = New System.Drawing.Size(122, 41)
        Me.UcButtonSpecialConfirm.TabIndex = 1
        Me.UcButtonSpecialConfirm.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialConfirm.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialConfirm.UCEnable = false
        Me.UcButtonSpecialConfirm.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialConfirm.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialConfirm.UCValue = "تایید"
        '
        'UCCarTruckUpdateInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarTruckUpdateInf"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(747, 261)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonSpecialConfirm As R2CoreGUI.UCButtonSpecial
    Friend WithEvents UcButtonSpecialCancel As UCButtonSpecial
End Class
