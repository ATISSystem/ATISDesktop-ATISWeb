Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcSoldRFIDCardsReport
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
        Me.PnlSoldRFIDCardsReport = New System.Windows.Forms.Panel()
        Me.UcSoldRFIDCards = New R2CoreParkingSystem.UCSoldRFIDCards()
        Me.PnlSoldRFIDCardsReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlSoldRFIDCardsReport
        '
        Me.PnlSoldRFIDCardsReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSoldRFIDCardsReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlSoldRFIDCardsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSoldRFIDCardsReport.Controls.Add(Me.UcSoldRFIDCards)
        Me.PnlSoldRFIDCardsReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlSoldRFIDCardsReport.Name = "PnlSoldRFIDCardsReport"
        Me.PnlSoldRFIDCardsReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlSoldRFIDCardsReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlSoldRFIDCardsReport.TabIndex = 203
        '
        'UcSoldRFIDCards
        '
        Me.UcSoldRFIDCards.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSoldRFIDCards.BackColor = System.Drawing.Color.Transparent
        Me.UcSoldRFIDCards.Location = New System.Drawing.Point(388, 37)
        Me.UcSoldRFIDCards.Name = "UcSoldRFIDCards"
        Me.UcSoldRFIDCards.Padding = New System.Windows.Forms.Padding(10)
        Me.UcSoldRFIDCards.Size = New System.Drawing.Size(216, 264)
        Me.UcSoldRFIDCards.TabIndex = 0
        Me.UcSoldRFIDCards.UCViewTitle = false
        '
        'FrmcSoldRFIDCardsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSoldRFIDCardsReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcSoldRFIDCardsReport"
        Me.Text = "FrmcSoldRFIDCardsReport"
        Me.Controls.SetChildIndex(Me.PnlSoldRFIDCardsReport, 0)
        Me.PnlSoldRFIDCardsReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlSoldRFIDCardsReport As System.Windows.Forms.Panel
    Friend WithEvents UcSoldRFIDCards As UCSoldRFIDCards
End Class
