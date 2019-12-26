Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarAndDriverPresenter
    Inherits UCCarAndDriver

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
        Me.UcLabelDriverSecond = New R2CoreGUI.UCLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcLabelDriverFirst = New R2CoreGUI.UCLabel()
        Me.UcLabelCar = New R2CoreGUI.UCLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabelDriverSecond)
        Me.PnlMain.Controls.Add(Me.UcLabelDriverFirst)
        Me.PnlMain.Controls.Add(Me.UcLabelCar)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label4)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(205, 224)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelDriverSecond
        '
        Me.UcLabelDriverSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDriverSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverSecond.Location = New System.Drawing.Point(0, 185)
        Me.UcLabelDriverSecond.Name = "UcLabelDriverSecond"
        Me.UcLabelDriverSecond.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDriverSecond.Size = New System.Drawing.Size(205, 32)
        Me.UcLabelDriverSecond.TabIndex = 7
        Me.UcLabelDriverSecond.UCBackColor = System.Drawing.Color.White
        Me.UcLabelDriverSecond.UCFont = New System.Drawing.Font("B Homa", 14.25!)
        Me.UcLabelDriverSecond.UCForeColor = System.Drawing.Color.IndianRed
        Me.UcLabelDriverSecond.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDriverSecond.UCValue = "رضا شاهمرادی"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "راننده دوم"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelDriverFirst
        '
        Me.UcLabelDriverFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDriverFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverFirst.Location = New System.Drawing.Point(3, 128)
        Me.UcLabelDriverFirst.Name = "UcLabelDriverFirst"
        Me.UcLabelDriverFirst.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDriverFirst.Size = New System.Drawing.Size(199, 32)
        Me.UcLabelDriverFirst.TabIndex = 5
        Me.UcLabelDriverFirst.UCBackColor = System.Drawing.Color.White
        Me.UcLabelDriverFirst.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDriverFirst.UCForeColor = System.Drawing.Color.Brown
        Me.UcLabelDriverFirst.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDriverFirst.UCValue = "مرتضی شاهمرادی"
        '
        'UcLabelCar
        '
        Me.UcLabelCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCar.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCar.ForeColor = System.Drawing.Color.Red
        Me.UcLabelCar.Location = New System.Drawing.Point(0, 71)
        Me.UcLabelCar.Name = "UcLabelCar"
        Me.UcLabelCar.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCar.Size = New System.Drawing.Size(205, 32)
        Me.UcLabelCar.TabIndex = 4
        Me.UcLabelCar.UCBackColor = System.Drawing.Color.White
        Me.UcLabelCar.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCar.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelCar.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCar.UCValue = "813ی48-13"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "راننده اول"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 46)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "خودرو - راننده"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره خودرو"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCCarAndDriverPresenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarAndDriverPresenter"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(211, 230)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcLabelDriverSecond As UCLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UcLabelDriverFirst As UCLabel
    Friend WithEvents UcLabelCar As UCLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
