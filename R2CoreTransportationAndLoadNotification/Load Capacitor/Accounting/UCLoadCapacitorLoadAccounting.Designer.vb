Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadCapacitorLoadAccounting
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
        Me.UcLabelDateTimeComposite = New R2CoreGUI.UCLabel()
        Me.UcLabelAmount = New R2CoreGUI.UCLabel()
        Me.UcLabelAccountTitle = New R2CoreGUI.UCLabel()
        Me.UcLabelUserName = New R2CoreGUI.UCLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Red
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabelDateTimeComposite)
        Me.PnlMain.Controls.Add(Me.UcLabelAmount)
        Me.PnlMain.Controls.Add(Me.UcLabelAccountTitle)
        Me.PnlMain.Controls.Add(Me.UcLabelUserName)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.Label8)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(571, 52)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelDateTimeComposite
        '
        Me.UcLabelDateTimeComposite.BackColor = System.Drawing.Color.Black
        Me.UcLabelDateTimeComposite.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateTimeComposite.ForeColor = System.Drawing.Color.White
        Me.UcLabelDateTimeComposite.Location = New System.Drawing.Point(287, 19)
        Me.UcLabelDateTimeComposite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabelDateTimeComposite.Name = "UcLabelDateTimeComposite"
        Me.UcLabelDateTimeComposite.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabelDateTimeComposite.Size = New System.Drawing.Size(162, 25)
        Me.UcLabelDateTimeComposite.TabIndex = 40
        Me.UcLabelDateTimeComposite.UCBackColor = System.Drawing.Color.White
        Me.UcLabelDateTimeComposite.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDateTimeComposite.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDateTimeComposite.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDateTimeComposite.UCValue = "1397/07/07 10:20:52"
        '
        'UcLabelAmount
        '
        Me.UcLabelAmount.BackColor = System.Drawing.Color.Black
        Me.UcLabelAmount.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelAmount.ForeColor = System.Drawing.Color.White
        Me.UcLabelAmount.Location = New System.Drawing.Point(131, 19)
        Me.UcLabelAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabelAmount.Name = "UcLabelAmount"
        Me.UcLabelAmount.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabelAmount.Size = New System.Drawing.Size(149, 25)
        Me.UcLabelAmount.TabIndex = 39
        Me.UcLabelAmount.UCBackColor = System.Drawing.Color.White
        Me.UcLabelAmount.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelAmount.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelAmount.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAmount.UCValue = "1"
        '
        'UcLabelAccountTitle
        '
        Me.UcLabelAccountTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelAccountTitle.BackColor = System.Drawing.Color.Black
        Me.UcLabelAccountTitle.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelAccountTitle.ForeColor = System.Drawing.Color.White
        Me.UcLabelAccountTitle.Location = New System.Drawing.Point(457, 19)
        Me.UcLabelAccountTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabelAccountTitle.Name = "UcLabelAccountTitle"
        Me.UcLabelAccountTitle.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabelAccountTitle.Size = New System.Drawing.Size(108, 25)
        Me.UcLabelAccountTitle.TabIndex = 38
        Me.UcLabelAccountTitle.UCBackColor = System.Drawing.Color.White
        Me.UcLabelAccountTitle.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelAccountTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelAccountTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAccountTitle.UCValue = "کنسلی مجوز بارگیری"
        '
        'UcLabelUserName
        '
        Me.UcLabelUserName.BackColor = System.Drawing.Color.Black
        Me.UcLabelUserName.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelUserName.ForeColor = System.Drawing.Color.White
        Me.UcLabelUserName.Location = New System.Drawing.Point(3, 19)
        Me.UcLabelUserName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcLabelUserName.Name = "UcLabelUserName"
        Me.UcLabelUserName.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabelUserName.Size = New System.Drawing.Size(121, 25)
        Me.UcLabelUserName.TabIndex = 37
        Me.UcLabelUserName.UCBackColor = System.Drawing.Color.White
        Me.UcLabelUserName.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelUserName.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelUserName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelUserName.UCValue = "تیموری"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(3, -4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "کاربر"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(130, -5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "تعداد - تعداد باقیمانده بار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(286, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "زمان"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(456, -4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "عملیات"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCLoadCapacitorLoadAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadCapacitorLoadAccounting"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(591, 72)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UcLabelUserName As UCLabel
    Friend WithEvents UcLabelDateTimeComposite As UCLabel
    Friend WithEvents UcLabelAmount As UCLabel
    Friend WithEvents UcLabelAccountTitle As UCLabel
End Class
