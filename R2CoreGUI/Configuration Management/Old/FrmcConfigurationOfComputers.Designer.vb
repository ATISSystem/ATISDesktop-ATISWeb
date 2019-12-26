<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcConfigurationOfComputers
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
        Me.PnlConfigurationOfComputers = New System.Windows.Forms.Panel()
        Me.UcSearcherComputers = New R2CoreGUI.UCSearcherComputers()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcucConfigurationOfComputerCollection = New R2CoreGUI.UCUCConfigurationOfComputerCollection()
        Me.PnlConfigurationOfComputers.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlConfigurationOfComputers
        '
        Me.PnlConfigurationOfComputers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlConfigurationOfComputers.BackColor = System.Drawing.Color.Transparent
        Me.PnlConfigurationOfComputers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlConfigurationOfComputers.Controls.Add(Me.UcSearcherComputers)
        Me.PnlConfigurationOfComputers.Controls.Add(Me.UcLabel1)
        Me.PnlConfigurationOfComputers.Controls.Add(Me.UcucConfigurationOfComputerCollection)
        Me.PnlConfigurationOfComputers.Location = New System.Drawing.Point(5, 50)
        Me.PnlConfigurationOfComputers.Name = "PnlConfigurationOfComputers"
        Me.PnlConfigurationOfComputers.Size = New System.Drawing.Size(995, 512)
        Me.PnlConfigurationOfComputers.TabIndex = 202
        '
        'UcSearcherComputers
        '
        Me.UcSearcherComputers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherComputers.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherComputers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcSearcherComputers.Location = New System.Drawing.Point(627, 12)
        Me.UcSearcherComputers.Name = "UcSearcherComputers"
        Me.UcSearcherComputers.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherComputers.Size = New System.Drawing.Size(263, 31)
        Me.UcSearcherComputers.TabIndex = 0
        Me.UcSearcherComputers.UCBackColor = System.Drawing.Color.YellowGreen
        Me.UcSearcherComputers.UCFontList = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherComputers.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcSearcherComputers.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherComputers.UCIcon = Nothing
        Me.UcSearcherComputers.UCMaximizeHight = CType(120,Long)
        Me.UcSearcherComputers.UCMinimizeHight = CType(31,Long)
        Me.UcSearcherComputers.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherComputers.UCShowIcon = false
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(896, 11)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(87, 32)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "کلاینت :"
        '
        'UcucConfigurationOfComputerCollection
        '
        Me.UcucConfigurationOfComputerCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucConfigurationOfComputerCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucConfigurationOfComputerCollection.Location = New System.Drawing.Point(3, 52)
        Me.UcucConfigurationOfComputerCollection.Name = "UcucConfigurationOfComputerCollection"
        Me.UcucConfigurationOfComputerCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucConfigurationOfComputerCollection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcucConfigurationOfComputerCollection.Size = New System.Drawing.Size(987, 455)
        Me.UcucConfigurationOfComputerCollection.TabIndex = 1
        Me.UcucConfigurationOfComputerCollection.UCTitle = "پیکربندی کلاینت"
        '
        'FrmcConfigurationOfComputers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlConfigurationOfComputers)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcConfigurationOfComputers"
        Me.Text = "FrmcConfigurationOfComputers"
        Me.Controls.SetChildIndex(Me.PnlConfigurationOfComputers, 0)
        Me.PnlConfigurationOfComputers.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlConfigurationOfComputers As Panel
    Friend WithEvents UcSearcherComputers As UCSearcherComputers
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcucConfigurationOfComputerCollection As UCUCConfigurationOfComputerCollection
End Class
