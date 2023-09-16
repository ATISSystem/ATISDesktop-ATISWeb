
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcMassSMSMessaging
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
        Me.PnlSendSMS = New System.Windows.Forms.Panel()
        Me.UcMassSMSMessaging = New R2CoreParkingSystem.UCMassSMSMessaging()
        Me.PnlSendSMS.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlSendSMS
        '
        Me.PnlSendSMS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSendSMS.BackColor = System.Drawing.Color.Transparent
        Me.PnlSendSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSendSMS.Controls.Add(Me.UcMassSMSMessaging)
        Me.PnlSendSMS.Location = New System.Drawing.Point(5, 50)
        Me.PnlSendSMS.Name = "PnlSendSMS"
        Me.PnlSendSMS.Size = New System.Drawing.Size(995, 512)
        Me.PnlSendSMS.TabIndex = 49
        '
        'UcMassSMSMessaging
        '
        Me.UcMassSMSMessaging.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMassSMSMessaging.BackColor = System.Drawing.Color.White
        Me.UcMassSMSMessaging.Location = New System.Drawing.Point(189, -8)
        Me.UcMassSMSMessaging.Name = "UcMassSMSMessaging"
        Me.UcMassSMSMessaging.Size = New System.Drawing.Size(615, 504)
        Me.UcMassSMSMessaging.TabIndex = 0
        Me.UcMassSMSMessaging.UCViewTitle = False
        '
        'FrmcMassSMSMessaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSendSMS)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMassSMSMessaging"
        Me.Text = "FrmcMassSMSMessaging"
        Me.Controls.SetChildIndex(Me.PnlSendSMS, 0)
        Me.PnlSendSMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlSendSMS As Windows.Forms.Panel
    Friend WithEvents UcMassSMSMessaging As UCMassSMSMessaging
End Class
