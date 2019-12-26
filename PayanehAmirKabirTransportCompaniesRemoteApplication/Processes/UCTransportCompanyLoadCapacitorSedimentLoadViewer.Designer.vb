<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTransportCompanyLoadCapacitorSedimentLoadViewer
    Inherits UCTransportCompanyLoadCapacitorLoadManipulation

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
        Me.UcLabel13 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcNumberSedimentedLoad = New R2CoreWinFormRemoteApplications.UCNumber()
        Me.SuspendLayout
        '
        'UcLabel13
        '
        Me.UcLabel13.BackColor = System.Drawing.Color.SeaShell
        Me.UcLabel13.Location = New System.Drawing.Point(62, 19)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel13.Size = New System.Drawing.Size(103, 32)
        Me.UcLabel13.TabIndex = 3
        Me.UcLabel13.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel13.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel13.UCForeColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel13.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel13.UCValue = "تعداد بار باقیمانده"
        '
        'UcNumberSedimentedLoad
        '
        Me.UcNumberSedimentedLoad.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberSedimentedLoad.Location = New System.Drawing.Point(31, 24)
        Me.UcNumberSedimentedLoad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberSedimentedLoad.Name = "UcNumberSedimentedLoad"
        Me.UcNumberSedimentedLoad.Size = New System.Drawing.Size(34, 25)
        Me.UcNumberSedimentedLoad.TabIndex = 7
        Me.UcNumberSedimentedLoad.UCBackColor = System.Drawing.Color.White
        Me.UcNumberSedimentedLoad.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberSedimentedLoad.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumberSedimentedLoad.UCEnable = true
        Me.UcNumberSedimentedLoad.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberSedimentedLoad.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberSedimentedLoad.UCHandCursorIcon = false
        Me.UcNumberSedimentedLoad.UCReadOnly = false
        Me.UcNumberSedimentedLoad.UCValue = CType(0,Long)
        '
        'UCTransportCompanyLoadCapacitorSedimentLoadViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcNumberSedimentedLoad)
        Me.Controls.Add(Me.UcLabel13)
        Me.Name = "UCTransportCompanyLoadCapacitorSedimentLoadViewer"
        Me.Size = New System.Drawing.Size(809, 197)
        Me.UCViewButtons = false
        Me.Controls.SetChildIndex(Me.UcLabel13, 0)
        Me.Controls.SetChildIndex(Me.UcNumberSedimentedLoad, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcLabel13 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcNumberSedimentedLoad As R2CoreWinFormRemoteApplications.UCNumber
End Class
