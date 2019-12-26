Imports R2CoreWinFormRemoteApplications

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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnTransferPersonelFingerPrintsIntoClock4 = New System.Windows.Forms.Button()
        Me.PnlSoldRFIDCardsReport = New System.Windows.Forms.Panel()
        Me.UcSoldRFIDCardsReport = New PayanehAmirKabirRemoteApplication.UCSoldRFIDCardsReport()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlSoldRFIDCardsReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnTransferPersonelFingerPrintsIntoClock4)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 201
        '
        'BtnTransferPersonelFingerPrintsIntoClock4
        '
        Me.BtnTransferPersonelFingerPrintsIntoClock4.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnTransferPersonelFingerPrintsIntoClock4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransferPersonelFingerPrintsIntoClock4.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnTransferPersonelFingerPrintsIntoClock4.ForeColor = System.Drawing.Color.White
        Me.BtnTransferPersonelFingerPrintsIntoClock4.Location = New System.Drawing.Point(6, 3)
        Me.BtnTransferPersonelFingerPrintsIntoClock4.Name = "BtnTransferPersonelFingerPrintsIntoClock4"
        Me.BtnTransferPersonelFingerPrintsIntoClock4.Size = New System.Drawing.Size(236, 35)
        Me.BtnTransferPersonelFingerPrintsIntoClock4.TabIndex = 0
        Me.BtnTransferPersonelFingerPrintsIntoClock4.Text = "گزارش تعدادی کارت آر-اف فروش رفته"
        Me.BtnTransferPersonelFingerPrintsIntoClock4.UseVisualStyleBackColor = false
        '
        'PnlSoldRFIDCardsReport
        '
        Me.PnlSoldRFIDCardsReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSoldRFIDCardsReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlSoldRFIDCardsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSoldRFIDCardsReport.Controls.Add(Me.UcSoldRFIDCardsReport)
        Me.PnlSoldRFIDCardsReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlSoldRFIDCardsReport.Name = "PnlSoldRFIDCardsReport"
        Me.PnlSoldRFIDCardsReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlSoldRFIDCardsReport.TabIndex = 202
        '
        'UcSoldRFIDCardsReport
        '
        Me.UcSoldRFIDCardsReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSoldRFIDCardsReport.BackColor = System.Drawing.Color.Transparent
        Me.UcSoldRFIDCardsReport.Location = New System.Drawing.Point(300, 32)
        Me.UcSoldRFIDCardsReport.Name = "UcSoldRFIDCardsReport"
        Me.UcSoldRFIDCardsReport.Size = New System.Drawing.Size(392, 444)
        Me.UcSoldRFIDCardsReport.TabIndex = 0
        '
        'FrmcSoldRFIDCardsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSoldRFIDCardsReport)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcSoldRFIDCardsReport"
        Me.FrmPersianName = "گزارش کارت های آر-اف"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcSoldRFIDCardsReport"
        Me.Text = "FrmcSoldRFIDCardsReport"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlSoldRFIDCardsReport, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlSoldRFIDCardsReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnTransferPersonelFingerPrintsIntoClock4 As Button
    Friend WithEvents PnlSoldRFIDCardsReport As Panel
    Friend WithEvents UcSoldRFIDCardsReport As UCSoldRFIDCardsReport
End Class
