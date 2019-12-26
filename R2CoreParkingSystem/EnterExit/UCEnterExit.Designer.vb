Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEnterExit
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
        Me.PnlLabels = New System.Windows.Forms.Panel()
        Me.LblLPEnter = New System.Windows.Forms.Label()
        Me.LblLpExit = New System.Windows.Forms.Label()
        Me.LblDateShamsiEnter = New System.Windows.Forms.Label()
        Me.LblMaabarNameExit = New System.Windows.Forms.Label()
        Me.LblTimeEnter = New System.Windows.Forms.Label()
        Me.LblMblghExit = New System.Windows.Forms.Label()
        Me.LblCardNoEnter = New System.Windows.Forms.Label()
        Me.LblUserExit = New System.Windows.Forms.Label()
        Me.LblUserEnter = New System.Windows.Forms.Label()
        Me.LblCardNoExit = New System.Windows.Forms.Label()
        Me.LblMblghEnter = New System.Windows.Forms.Label()
        Me.LblTimeExit = New System.Windows.Forms.Label()
        Me.LblMaabarNameEnter = New System.Windows.Forms.Label()
        Me.LblDateShamsiExit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcCarImage = New R2CoreParkingSystem.UCCarImage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.PnlLabels.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.PnlLabels)
        Me.PnlMain.Controls.Add(Me.Label7)
        Me.PnlMain.Controls.Add(Me.Label6)
        Me.PnlMain.Controls.Add(Me.Label5)
        Me.PnlMain.Controls.Add(Me.Label4)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.UcCarImage)
        Me.PnlMain.Controls.Add(Me.Label8)
        Me.PnlMain.Controls.Add(Me.Label9)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(807, 74)
        Me.PnlMain.TabIndex = 0
        '
        'PnlLabels
        '
        Me.PnlLabels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLabels.Controls.Add(Me.LblLPEnter)
        Me.PnlLabels.Controls.Add(Me.LblLpExit)
        Me.PnlLabels.Controls.Add(Me.LblDateShamsiEnter)
        Me.PnlLabels.Controls.Add(Me.LblMaabarNameExit)
        Me.PnlLabels.Controls.Add(Me.LblTimeEnter)
        Me.PnlLabels.Controls.Add(Me.LblMblghExit)
        Me.PnlLabels.Controls.Add(Me.LblCardNoEnter)
        Me.PnlLabels.Controls.Add(Me.LblUserExit)
        Me.PnlLabels.Controls.Add(Me.LblUserEnter)
        Me.PnlLabels.Controls.Add(Me.LblCardNoExit)
        Me.PnlLabels.Controls.Add(Me.LblMblghEnter)
        Me.PnlLabels.Controls.Add(Me.LblTimeExit)
        Me.PnlLabels.Controls.Add(Me.LblMaabarNameEnter)
        Me.PnlLabels.Controls.Add(Me.LblDateShamsiExit)
        Me.PnlLabels.Location = New System.Drawing.Point(72, 20)
        Me.PnlLabels.Name = "PnlLabels"
        Me.PnlLabels.Size = New System.Drawing.Size(694, 50)
        Me.PnlLabels.TabIndex = 51
        '
        'LblLPEnter
        '
        Me.LblLPEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblLPEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblLPEnter.ForeColor = System.Drawing.Color.Black
        Me.LblLPEnter.Location = New System.Drawing.Point(3, 0)
        Me.LblLPEnter.Name = "LblLPEnter"
        Me.LblLPEnter.Size = New System.Drawing.Size(93, 23)
        Me.LblLPEnter.TabIndex = 43
        Me.LblLPEnter.Text = "1396/10/21"
        Me.LblLPEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLpExit
        '
        Me.LblLpExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblLpExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblLpExit.ForeColor = System.Drawing.Color.Black
        Me.LblLpExit.Location = New System.Drawing.Point(3, 27)
        Me.LblLpExit.Name = "LblLpExit"
        Me.LblLpExit.Size = New System.Drawing.Size(93, 23)
        Me.LblLpExit.TabIndex = 50
        Me.LblLpExit.Text = "1396/10/21"
        Me.LblLpExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDateShamsiEnter
        '
        Me.LblDateShamsiEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDateShamsiEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDateShamsiEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblDateShamsiEnter.ForeColor = System.Drawing.Color.Black
        Me.LblDateShamsiEnter.Location = New System.Drawing.Point(611, 0)
        Me.LblDateShamsiEnter.Name = "LblDateShamsiEnter"
        Me.LblDateShamsiEnter.Size = New System.Drawing.Size(80, 23)
        Me.LblDateShamsiEnter.TabIndex = 37
        Me.LblDateShamsiEnter.Text = "1396/10/21"
        Me.LblDateShamsiEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMaabarNameExit
        '
        Me.LblMaabarNameExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMaabarNameExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblMaabarNameExit.ForeColor = System.Drawing.Color.Black
        Me.LblMaabarNameExit.Location = New System.Drawing.Point(98, 27)
        Me.LblMaabarNameExit.Name = "LblMaabarNameExit"
        Me.LblMaabarNameExit.Size = New System.Drawing.Size(100, 23)
        Me.LblMaabarNameExit.TabIndex = 49
        Me.LblMaabarNameExit.Text = "1396/10/21"
        Me.LblMaabarNameExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTimeEnter
        '
        Me.LblTimeEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblTimeEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTimeEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblTimeEnter.ForeColor = System.Drawing.Color.Black
        Me.LblTimeEnter.Location = New System.Drawing.Point(529, 0)
        Me.LblTimeEnter.Name = "LblTimeEnter"
        Me.LblTimeEnter.Size = New System.Drawing.Size(80, 23)
        Me.LblTimeEnter.TabIndex = 38
        Me.LblTimeEnter.Text = "1396/10/21"
        Me.LblTimeEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMblghExit
        '
        Me.LblMblghExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMblghExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblMblghExit.ForeColor = System.Drawing.Color.Black
        Me.LblMblghExit.Location = New System.Drawing.Point(200, 27)
        Me.LblMblghExit.Name = "LblMblghExit"
        Me.LblMblghExit.Size = New System.Drawing.Size(70, 23)
        Me.LblMblghExit.TabIndex = 48
        Me.LblMblghExit.Text = "1396/10/21"
        Me.LblMblghExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCardNoEnter
        '
        Me.LblCardNoEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblCardNoEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCardNoEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblCardNoEnter.ForeColor = System.Drawing.Color.Black
        Me.LblCardNoEnter.Location = New System.Drawing.Point(447, 0)
        Me.LblCardNoEnter.Name = "LblCardNoEnter"
        Me.LblCardNoEnter.Size = New System.Drawing.Size(80, 23)
        Me.LblCardNoEnter.TabIndex = 39
        Me.LblCardNoEnter.Text = "1396/10/21"
        Me.LblCardNoEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUserExit
        '
        Me.LblUserExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblUserExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUserExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblUserExit.ForeColor = System.Drawing.Color.Black
        Me.LblUserExit.Location = New System.Drawing.Point(272, 27)
        Me.LblUserExit.Name = "LblUserExit"
        Me.LblUserExit.Size = New System.Drawing.Size(173, 23)
        Me.LblUserExit.TabIndex = 47
        Me.LblUserExit.Text = "1396/10/21"
        Me.LblUserExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUserEnter
        '
        Me.LblUserEnter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblUserEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUserEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblUserEnter.ForeColor = System.Drawing.Color.Black
        Me.LblUserEnter.Location = New System.Drawing.Point(272, 0)
        Me.LblUserEnter.Name = "LblUserEnter"
        Me.LblUserEnter.Size = New System.Drawing.Size(173, 23)
        Me.LblUserEnter.TabIndex = 40
        Me.LblUserEnter.Text = "1396/10/21"
        Me.LblUserEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCardNoExit
        '
        Me.LblCardNoExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblCardNoExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCardNoExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblCardNoExit.ForeColor = System.Drawing.Color.Black
        Me.LblCardNoExit.Location = New System.Drawing.Point(447, 27)
        Me.LblCardNoExit.Name = "LblCardNoExit"
        Me.LblCardNoExit.Size = New System.Drawing.Size(80, 23)
        Me.LblCardNoExit.TabIndex = 46
        Me.LblCardNoExit.Text = "1396/10/21"
        Me.LblCardNoExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMblghEnter
        '
        Me.LblMblghEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMblghEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblMblghEnter.ForeColor = System.Drawing.Color.Black
        Me.LblMblghEnter.Location = New System.Drawing.Point(200, 0)
        Me.LblMblghEnter.Name = "LblMblghEnter"
        Me.LblMblghEnter.Size = New System.Drawing.Size(70, 23)
        Me.LblMblghEnter.TabIndex = 41
        Me.LblMblghEnter.Text = "1396/10/21"
        Me.LblMblghEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTimeExit
        '
        Me.LblTimeExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblTimeExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTimeExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblTimeExit.ForeColor = System.Drawing.Color.Black
        Me.LblTimeExit.Location = New System.Drawing.Point(529, 27)
        Me.LblTimeExit.Name = "LblTimeExit"
        Me.LblTimeExit.Size = New System.Drawing.Size(80, 23)
        Me.LblTimeExit.TabIndex = 45
        Me.LblTimeExit.Text = "1396/10/21"
        Me.LblTimeExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMaabarNameEnter
        '
        Me.LblMaabarNameEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMaabarNameEnter.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblMaabarNameEnter.ForeColor = System.Drawing.Color.Black
        Me.LblMaabarNameEnter.Location = New System.Drawing.Point(98, 0)
        Me.LblMaabarNameEnter.Name = "LblMaabarNameEnter"
        Me.LblMaabarNameEnter.Size = New System.Drawing.Size(100, 23)
        Me.LblMaabarNameEnter.TabIndex = 42
        Me.LblMaabarNameEnter.Text = "1396/10/21"
        Me.LblMaabarNameEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDateShamsiExit
        '
        Me.LblDateShamsiExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDateShamsiExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDateShamsiExit.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblDateShamsiExit.ForeColor = System.Drawing.Color.Black
        Me.LblDateShamsiExit.Location = New System.Drawing.Point(611, 27)
        Me.LblDateShamsiExit.Name = "LblDateShamsiExit"
        Me.LblDateShamsiExit.Size = New System.Drawing.Size(80, 23)
        Me.LblDateShamsiExit.TabIndex = 44
        Me.LblDateShamsiExit.Text = "1396/10/21"
        Me.LblDateShamsiExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(74, -4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "پلاک"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(170, -4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "معبر"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(272, -4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "مبلغ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(344, -4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "کاربر"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(519, -4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "کارت"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(601, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ساعت"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(683, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "تاریخ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcCarImage
        '
        Me.UcCarImage.BackColor = System.Drawing.Color.Transparent
        Me.UcCarImage.Location = New System.Drawing.Point(3, 19)
        Me.UcCarImage.Name = "UcCarImage"
        Me.UcCarImage.Size = New System.Drawing.Size(63, 51)
        Me.UcCarImage.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(763, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ورود"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(764, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "خروج"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UCEnterExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCEnterExit"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(827, 94)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlLabels.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcCarImage As UCCarImage
    Friend WithEvents LblLpExit As System.Windows.Forms.Label
    Friend WithEvents LblMaabarNameExit As System.Windows.Forms.Label
    Friend WithEvents LblMblghExit As System.Windows.Forms.Label
    Friend WithEvents LblUserExit As System.Windows.Forms.Label
    Friend WithEvents LblCardNoExit As System.Windows.Forms.Label
    Friend WithEvents LblTimeExit As System.Windows.Forms.Label
    Friend WithEvents LblDateShamsiExit As System.Windows.Forms.Label
    Friend WithEvents LblLPEnter As System.Windows.Forms.Label
    Friend WithEvents LblMaabarNameEnter As System.Windows.Forms.Label
    Friend WithEvents LblMblghEnter As System.Windows.Forms.Label
    Friend WithEvents LblUserEnter As System.Windows.Forms.Label
    Friend WithEvents LblCardNoEnter As System.Windows.Forms.Label
    Friend WithEvents LblTimeEnter As System.Windows.Forms.Label
    Friend WithEvents LblDateShamsiEnter As System.Windows.Forms.Label
    Friend WithEvents PnlLabels As System.Windows.Forms.Panel
End Class
