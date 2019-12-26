Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageSedimentedLoadAllocationAndPermssion
    Inherits UCComputerMessage

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
        Me.UcLabelTransportCompany = New R2CoreGUI.UCLabel()
        Me.UcLabelProductName = New R2CoreGUI.UCLabel()
        Me.UcButtonLoadAllocateAndPermission = New R2CoreGUI.UCButton()
        Me.SuspendLayout
        '
        'UcLabelTransportCompany
        '
        Me.UcLabelTransportCompany.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTransportCompany.Location = New System.Drawing.Point(15, 83)
        Me.UcLabelTransportCompany.Name = "UcLabelTransportCompany"
        Me.UcLabelTransportCompany.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTransportCompany.Size = New System.Drawing.Size(217, 30)
        Me.UcLabelTransportCompany.TabIndex = 1
        Me.UcLabelTransportCompany.UCBackColor = System.Drawing.Color.Olive
        Me.UcLabelTransportCompany.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTransportCompany.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTransportCompany.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTransportCompany.UCValue = ""
        '
        'UcLabelProductName
        '
        Me.UcLabelProductName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelProductName.Location = New System.Drawing.Point(15, 49)
        Me.UcLabelProductName.Name = "UcLabelProductName"
        Me.UcLabelProductName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelProductName.Size = New System.Drawing.Size(318, 30)
        Me.UcLabelProductName.TabIndex = 2
        Me.UcLabelProductName.UCBackColor = System.Drawing.Color.Gold
        Me.UcLabelProductName.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelProductName.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelProductName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelProductName.UCValue = ""
        '
        'UcButtonLoadAllocateAndPermission
        '
        Me.UcButtonLoadAllocateAndPermission.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonLoadAllocateAndPermission.Location = New System.Drawing.Point(15, 12)
        Me.UcButtonLoadAllocateAndPermission.Name = "UcButtonLoadAllocateAndPermission"
        Me.UcButtonLoadAllocateAndPermission.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonLoadAllocateAndPermission.Size = New System.Drawing.Size(169, 34)
        Me.UcButtonLoadAllocateAndPermission.TabIndex = 3
        Me.UcButtonLoadAllocateAndPermission.UCBackColor = System.Drawing.Color.Snow
        Me.UcButtonLoadAllocateAndPermission.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonLoadAllocateAndPermission.UCEnable = true
        Me.UcButtonLoadAllocateAndPermission.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonLoadAllocateAndPermission.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonLoadAllocateAndPermission.UCValue = "تخصیص بار و صدور مجوز بارگیری"
        '
        'UCComputerMessageSedimentedLoadAllocationAndPermssion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcButtonLoadAllocateAndPermission)
        Me.Controls.Add(Me.UcLabelProductName)
        Me.Controls.Add(Me.UcLabelTransportCompany)
        Me.Name = "UCComputerMessageSedimentedLoadAllocationAndPermssion"
        Me.Controls.SetChildIndex(Me.UcLabelTransportCompany, 0)
        Me.Controls.SetChildIndex(Me.UcLabelProductName, 0)
        Me.Controls.SetChildIndex(Me.UcButtonLoadAllocateAndPermission, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcLabelTransportCompany As UCLabel
    Friend WithEvents UcLabelProductName As UCLabel
    Friend WithEvents UcButtonLoadAllocateAndPermission As UCButton
End Class
