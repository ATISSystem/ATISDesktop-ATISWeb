<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersianDateTimeEntry
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
        Me.UcTimeEntry = New R2CoreGUI.UCTimeEntry()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.SuspendLayout()
        '
        'UcTimeEntry
        '
        Me.UcTimeEntry.BackColor = System.Drawing.Color.Transparent
        Me.UcTimeEntry.Location = New System.Drawing.Point(120, -2)
        Me.UcTimeEntry.Name = "UcTimeEntry"
        Me.UcTimeEntry.Size = New System.Drawing.Size(103, 25)
        Me.UcTimeEntry.TabIndex = 4
        Me.UcTimeEntry.UCBackColor = System.Drawing.Color.White
        Me.UcTimeEntry.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTimeEntry.UCEnable = True
        Me.UcTimeEntry.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTimeEntry.UCUserTime = "19:01:22"
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.White
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(-1, -2)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(127, 23)
        Me.UcPersianShamsiDate.TabIndex = 3
        Me.UcPersianShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'UCPersianDateTimeEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.UcTimeEntry)
        Me.Controls.Add(Me.UcPersianShamsiDate)
        Me.Name = "UCPersianDateTimeEntry"
        Me.Size = New System.Drawing.Size(227, 22)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcTimeEntry As UCTimeEntry
    Friend WithEvents UcPersianShamsiDate As UCPersianShamsiDate
End Class
