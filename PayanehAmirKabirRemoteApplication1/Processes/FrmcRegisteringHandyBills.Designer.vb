

Imports System.Windows.Forms

Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcRegisteringHandyBills
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnRegisteringHandyBills = New System.Windows.Forms.Button()
        Me.PnlRegisteringHandyBills = New System.Windows.Forms.Panel()
        Me.UcRegisteringHandyBills = New UCRegisteringHandyBills()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlRegisteringHandyBills.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnRegisteringHandyBills)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 200
        '
        'BtnRegisteringHandyBills
        '
        Me.BtnRegisteringHandyBills.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegisteringHandyBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegisteringHandyBills.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnRegisteringHandyBills.ForeColor = System.Drawing.Color.White
        Me.BtnRegisteringHandyBills.Location = New System.Drawing.Point(6, 3)
        Me.BtnRegisteringHandyBills.Name = "BtnRegisteringHandyBills"
        Me.BtnRegisteringHandyBills.Size = New System.Drawing.Size(178, 35)
        Me.BtnRegisteringHandyBills.TabIndex = 0
        Me.BtnRegisteringHandyBills.Text = "ثبت قبوض دستی پارکینگ"
        Me.BtnRegisteringHandyBills.UseVisualStyleBackColor = false
        '
        'PnlRegisteringHandyBills
        '
        Me.PnlRegisteringHandyBills.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlRegisteringHandyBills.BackColor = System.Drawing.Color.Transparent
        Me.PnlRegisteringHandyBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlRegisteringHandyBills.Controls.Add(Me.UcRegisteringHandyBills)
        Me.PnlRegisteringHandyBills.Location = New System.Drawing.Point(5, 50)
        Me.PnlRegisteringHandyBills.Name = "PnlRegisteringHandyBills"
        Me.PnlRegisteringHandyBills.Size = New System.Drawing.Size(995, 512)
        Me.PnlRegisteringHandyBills.TabIndex = 201
        '
        'UcRegisteringHandyBills
        '
        Me.UcRegisteringHandyBills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcRegisteringHandyBills.BackColor = System.Drawing.Color.Transparent
        Me.UcRegisteringHandyBills.Location = New System.Drawing.Point(356, 50)
        Me.UcRegisteringHandyBills.Name = "UcRegisteringHandyBills"
        Me.UcRegisteringHandyBills.Padding = New System.Windows.Forms.Padding(3)
        Me.UcRegisteringHandyBills.Size = New System.Drawing.Size(315, 431)
        Me.UcRegisteringHandyBills.TabIndex = 0
        '
        'FrmcRegisteringHandyBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlRegisteringHandyBills)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcRegisteringHandyBills"
        Me.FrmPersianName = "ثبت قبوض دستی پارکینگ"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcRegisteringHandyBills"
        Me.Text = "FrmcRegisteringHandyBills"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlRegisteringHandyBills, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlRegisteringHandyBills.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnRegisteringHandyBills As Button
    Friend WithEvents PnlRegisteringHandyBills As Panel
    Friend WithEvents UcRegisteringHandyBills As UCRegisteringHandyBills
End Class
