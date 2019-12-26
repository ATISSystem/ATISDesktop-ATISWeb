
Imports  R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMainMenu
    Inherits R2CoreWinFormRemoteApplications.FrmcMainMenu

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcMainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.UcButtonSpecialContractorCompanyFinancialReport = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialPersonnelEnterExitReport = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialRegisteringHandyBills = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4 = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialTruckersAssociationFinancialReport = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialUserChargeReport = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcButtonSpecialSoldRFIDCardsReport = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 568)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(997, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(997, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = false
        '
        'UcButtonSpecialContractorCompanyFinancialReport
        '
        Me.UcButtonSpecialContractorCompanyFinancialReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialContractorCompanyFinancialReport.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialContractorCompanyFinancialReport.Location = New System.Drawing.Point(578, 182)
        Me.UcButtonSpecialContractorCompanyFinancialReport.Name = "UcButtonSpecialContractorCompanyFinancialReport"
        Me.UcButtonSpecialContractorCompanyFinancialReport.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialContractorCompanyFinancialReport.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialContractorCompanyFinancialReport.TabIndex = 2
        Me.UcButtonSpecialContractorCompanyFinancialReport.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialContractorCompanyFinancialReport.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialContractorCompanyFinancialReport.UCEnable = true
        Me.UcButtonSpecialContractorCompanyFinancialReport.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialContractorCompanyFinancialReport.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialContractorCompanyFinancialReport.UCValue = "گزارش درآمد حاصل از پارکینگ"
        '
        'UcButtonSpecialPersonnelEnterExitReport
        '
        Me.UcButtonSpecialPersonnelEnterExitReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialPersonnelEnterExitReport.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialPersonnelEnterExitReport.Location = New System.Drawing.Point(578, 247)
        Me.UcButtonSpecialPersonnelEnterExitReport.Name = "UcButtonSpecialPersonnelEnterExitReport"
        Me.UcButtonSpecialPersonnelEnterExitReport.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialPersonnelEnterExitReport.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialPersonnelEnterExitReport.TabIndex = 3
        Me.UcButtonSpecialPersonnelEnterExitReport.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialPersonnelEnterExitReport.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialPersonnelEnterExitReport.UCEnable = true
        Me.UcButtonSpecialPersonnelEnterExitReport.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialPersonnelEnterExitReport.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialPersonnelEnterExitReport.UCValue = "گزارش تردد پرسنل"
        '
        'UcButtonSpecialRegisteringHandyBills
        '
        Me.UcButtonSpecialRegisteringHandyBills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialRegisteringHandyBills.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialRegisteringHandyBills.Location = New System.Drawing.Point(578, 312)
        Me.UcButtonSpecialRegisteringHandyBills.Name = "UcButtonSpecialRegisteringHandyBills"
        Me.UcButtonSpecialRegisteringHandyBills.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialRegisteringHandyBills.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialRegisteringHandyBills.TabIndex = 4
        Me.UcButtonSpecialRegisteringHandyBills.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialRegisteringHandyBills.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialRegisteringHandyBills.UCEnable = true
        Me.UcButtonSpecialRegisteringHandyBills.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialRegisteringHandyBills.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialRegisteringHandyBills.UCValue = "ثبت قبوض دستی پارکینگ"
        '
        'UcButtonSpecialTransferPersonelFingerPrintsIntoClock4
        '
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.Location = New System.Drawing.Point(578, 377)
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.Name = "UcButtonSpecialTransferPersonelFingerPrintsIntoClock4"
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.TabIndex = 5
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCEnable = true
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCValue = "انتقال اطلاعات تردد پرسنل (اثر انگشت)"
        '
        'UcButtonSpecialTruckersAssociationFinancialReport
        '
        Me.UcButtonSpecialTruckersAssociationFinancialReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialTruckersAssociationFinancialReport.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialTruckersAssociationFinancialReport.Location = New System.Drawing.Point(578, 117)
        Me.UcButtonSpecialTruckersAssociationFinancialReport.Name = "UcButtonSpecialTruckersAssociationFinancialReport"
        Me.UcButtonSpecialTruckersAssociationFinancialReport.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialTruckersAssociationFinancialReport.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialTruckersAssociationFinancialReport.TabIndex = 6
        Me.UcButtonSpecialTruckersAssociationFinancialReport.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialTruckersAssociationFinancialReport.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialTruckersAssociationFinancialReport.UCEnable = true
        Me.UcButtonSpecialTruckersAssociationFinancialReport.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialTruckersAssociationFinancialReport.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialTruckersAssociationFinancialReport.UCValue = "گزارش درآمد حاصل از نوبت ناوگان باری"
        '
        'UcButtonSpecialUserChargeReport
        '
        Me.UcButtonSpecialUserChargeReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialUserChargeReport.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialUserChargeReport.Location = New System.Drawing.Point(578, 52)
        Me.UcButtonSpecialUserChargeReport.Name = "UcButtonSpecialUserChargeReport"
        Me.UcButtonSpecialUserChargeReport.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialUserChargeReport.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialUserChargeReport.TabIndex = 7
        Me.UcButtonSpecialUserChargeReport.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialUserChargeReport.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialUserChargeReport.UCEnable = true
        Me.UcButtonSpecialUserChargeReport.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialUserChargeReport.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialUserChargeReport.UCValue = "گزارش درآمد حاصل از شارژ کارت تردد"
        '
        'UcButtonSpecialSoldRFIDCardsReport
        '
        Me.UcButtonSpecialSoldRFIDCardsReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecialSoldRFIDCardsReport.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialSoldRFIDCardsReport.Location = New System.Drawing.Point(578, 442)
        Me.UcButtonSpecialSoldRFIDCardsReport.Name = "UcButtonSpecialSoldRFIDCardsReport"
        Me.UcButtonSpecialSoldRFIDCardsReport.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialSoldRFIDCardsReport.Size = New System.Drawing.Size(303, 52)
        Me.UcButtonSpecialSoldRFIDCardsReport.TabIndex = 8
        Me.UcButtonSpecialSoldRFIDCardsReport.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialSoldRFIDCardsReport.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialSoldRFIDCardsReport.UCEnable = true
        Me.UcButtonSpecialSoldRFIDCardsReport.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecialSoldRFIDCardsReport.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialSoldRFIDCardsReport.UCValue = "گزارش کارت های آر-اف"
        '
        'FrmcMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.UcButtonSpecialSoldRFIDCardsReport)
        Me.Controls.Add(Me.UcButtonSpecialUserChargeReport)
        Me.Controls.Add(Me.UcButtonSpecialTruckersAssociationFinancialReport)
        Me.Controls.Add(Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4)
        Me.Controls.Add(Me.UcButtonSpecialRegisteringHandyBills)
        Me.Controls.Add(Me.UcButtonSpecialPersonnelEnterExitReport)
        Me.Controls.Add(Me.UcButtonSpecialContractorCompanyFinancialReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMainMenu"
        Me.Controls.SetChildIndex(Me.UcButtonSpecialContractorCompanyFinancialReport, 0)
        Me.Controls.SetChildIndex(Me.UcButtonSpecialPersonnelEnterExitReport, 0)
        Me.Controls.SetChildIndex(Me.UcButtonSpecialRegisteringHandyBills, 0)
        Me.Controls.SetChildIndex(Me.UcButtonSpecialTransferPersonelFingerPrintsIntoClock4, 0)
        Me.Controls.SetChildIndex(Me.UcButtonSpecialTruckersAssociationFinancialReport, 0)
        Me.Controls.SetChildIndex(Me.UcButtonSpecialUserChargeReport, 0)
        Me.Controls.SetChildIndex(Me.UcButtonSpecialSoldRFIDCardsReport, 0)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UcButtonSpecialContractorCompanyFinancialReport As UCButtonSpecial
    Friend WithEvents UcButtonSpecialPersonnelEnterExitReport As UCButtonSpecial
    Friend WithEvents UcButtonSpecialRegisteringHandyBills As UCButtonSpecial
    Friend WithEvents UcButtonSpecialTransferPersonelFingerPrintsIntoClock4 As UCButtonSpecial
    Friend WithEvents UcButtonSpecialTruckersAssociationFinancialReport As UCButtonSpecial
    Friend WithEvents UcButtonSpecialUserChargeReport As UCButtonSpecial
    Friend WithEvents UcButtonSpecialSoldRFIDCardsReport As UCButtonSpecial
End Class
