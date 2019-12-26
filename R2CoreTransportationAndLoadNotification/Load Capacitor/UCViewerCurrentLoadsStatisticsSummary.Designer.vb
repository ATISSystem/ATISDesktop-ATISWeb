Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerCurrentLoadsStatisticsSummary
    Inherits  UCGeneral 

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcLabelReleased = New R2CoreGUI.UCLabel()
        Me.UcLabelAnnounced = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.UcLabelReleased)
        Me.PnlMain.Controls.Add(Me.UcLabelAnnounced)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(114, 28)
        Me.PnlMain.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "/"
        '
        'UcLabelReleased
        '
        Me.UcLabelReleased._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelReleased._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelReleased.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelReleased.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelReleased.Location = New System.Drawing.Point(67, 3)
        Me.UcLabelReleased.Name = "UcLabelReleased"
        Me.UcLabelReleased.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelReleased.Size = New System.Drawing.Size(41, 25)
        Me.UcLabelReleased.TabIndex = 3
        Me.UcLabelReleased.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelReleased.UCFont = New System.Drawing.Font("Alborz Titr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelReleased.UCForeColor = System.Drawing.Color.Navy
        Me.UcLabelReleased.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelReleased.UCValue = "126"
        '
        'UcLabelAnnounced
        '
        Me.UcLabelAnnounced._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelAnnounced._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelAnnounced.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelAnnounced.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAnnounced.ForeColor = System.Drawing.Color.MediumBlue
        Me.UcLabelAnnounced.Location = New System.Drawing.Point(0, 3)
        Me.UcLabelAnnounced.Name = "UcLabelAnnounced"
        Me.UcLabelAnnounced.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelAnnounced.Size = New System.Drawing.Size(44, 22)
        Me.UcLabelAnnounced.TabIndex = 1
        Me.UcLabelAnnounced.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAnnounced.UCFont = New System.Drawing.Font("Alborz Titr", 14.25!)
        Me.UcLabelAnnounced.UCForeColor = System.Drawing.Color.Green
        Me.UcLabelAnnounced.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabelAnnounced.UCValue = "126"
        '
        'UCViewerCurrentLoadsStatisticsSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerCurrentLoadsStatisticsSummary"
        Me.Size = New System.Drawing.Size(114, 28)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelAnnounced As R2CoreGUI.UCLabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents UcLabelReleased As R2CoreGUI.UCLabel
End Class
