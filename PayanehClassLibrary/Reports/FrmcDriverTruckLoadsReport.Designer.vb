Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcDriverTruckLoadsReport
    Inherits FrmcGeneral


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcDriverTruckLoadReport = New PayanehClassLibrary.UCDriverTruckLoadReport()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcDriverTruckLoadReport)
        Me.Panel1.Location = New System.Drawing.Point(5, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(995, 512)
        Me.Panel1.TabIndex = 208
        '
        'UcDriverTruckLoadReport
        '
        Me.UcDriverTruckLoadReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDriverTruckLoadReport.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckLoadReport.Location = New System.Drawing.Point(64, 26)
        Me.UcDriverTruckLoadReport.Name = "UcDriverTruckLoadReport"
        Me.UcDriverTruckLoadReport.Padding = New System.Windows.Forms.Padding(10)
        Me.UcDriverTruckLoadReport.Size = New System.Drawing.Size(864, 444)
        Me.UcDriverTruckLoadReport.TabIndex = 0
        '
        'FrmcDriverTruckLoadsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcDriverTruckLoadsReport"
        Me.Text = "FrmcDriverTruckLoadsReport"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcDriverTruckLoadReport As UCDriverTruckLoadReport
End Class
