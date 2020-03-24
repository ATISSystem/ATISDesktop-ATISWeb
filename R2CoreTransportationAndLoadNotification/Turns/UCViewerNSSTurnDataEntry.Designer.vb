<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSTurnDataEntry
    Inherits UCTurn

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCViewerNSSTurnDataEntry))
        Dim R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2 As R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure = New R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcNumberTargetYear = New R2CoreGUI.UCNumber()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UcNumberTurnId = New R2CoreGUI.UCNumber()
        Me.UcLabelTurnStatus = New R2CoreGUI.UCLabel()
        Me.UcLabelTruck = New R2CoreGUI.UCLabel()
        Me.UcLabelTruckDriver = New R2CoreGUI.UCLabel()
        Me.UcLabelDateTimeComposite = New R2CoreGUI.UCLabel()
        Me.UcucSequentialTurnCollection = New R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection()
        Me.PnlMain.SuspendLayout()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Controls.Add(Me.UcucSequentialTurnCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.Size = New System.Drawing.Size(477, 79)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Location = New System.Drawing.Point(3, 29)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(469, 47)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcNumberTargetYear)
        Me.PnlInner.Controls.Add(Me.PictureBox1)
        Me.PnlInner.Controls.Add(Me.UcNumberTurnId)
        Me.PnlInner.Controls.Add(Me.UcLabelTurnStatus)
        Me.PnlInner.Controls.Add(Me.UcLabelTruck)
        Me.PnlInner.Controls.Add(Me.UcLabelTruckDriver)
        Me.PnlInner.Controls.Add(Me.UcLabelDateTimeComposite)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(465, 43)
        Me.PnlInner.TabIndex = 0
        '
        'UcNumberTargetYear
        '
        Me.UcNumberTargetYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberTargetYear.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTargetYear.Location = New System.Drawing.Point(382, 2)
        Me.UcNumberTargetYear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberTargetYear.Name = "UcNumberTargetYear"
        Me.UcNumberTargetYear.Size = New System.Drawing.Size(57, 18)
        Me.UcNumberTargetYear.TabIndex = 10
        Me.UcNumberTargetYear.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTargetYear.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTargetYear.UCBorder = True
        Me.UcNumberTargetYear.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberTargetYear.UCEnable = True
        Me.UcNumberTargetYear.UCFont = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTargetYear.UCForeColor = System.Drawing.Color.Red
        Me.UcNumberTargetYear.UCMultiLine = False
        Me.UcNumberTargetYear.UCValue = CType(1399, Long)
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(443, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'UcNumberTurnId
        '
        Me.UcNumberTurnId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberTurnId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTurnId.Location = New System.Drawing.Point(382, 21)
        Me.UcNumberTurnId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberTurnId.Name = "UcNumberTurnId"
        Me.UcNumberTurnId.Size = New System.Drawing.Size(57, 20)
        Me.UcNumberTurnId.TabIndex = 1
        Me.UcNumberTurnId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTurnId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTurnId.UCBorder = True
        Me.UcNumberTurnId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberTurnId.UCEnable = True
        Me.UcNumberTurnId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTurnId.UCForeColor = System.Drawing.Color.Red
        Me.UcNumberTurnId.UCMultiLine = False
        Me.UcNumberTurnId.UCValue = CType(21235, Long)
        '
        'UcLabelTurnStatus
        '
        Me.UcLabelTurnStatus._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTurnStatus._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTurnStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelTurnStatus.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTurnStatus.Location = New System.Drawing.Point(4, 3)
        Me.UcLabelTurnStatus.Name = "UcLabelTurnStatus"
        Me.UcLabelTurnStatus.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTurnStatus.Size = New System.Drawing.Size(152, 21)
        Me.UcLabelTurnStatus.TabIndex = 5
        Me.UcLabelTurnStatus.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTurnStatus.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTurnStatus.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTurnStatus.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTurnStatus.UCValue = "احیا شده - کنسلی مجوز"
        '
        'UcLabelTruck
        '
        Me.UcLabelTruck._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTruck._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTruck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTruck.Location = New System.Drawing.Point(304, 3)
        Me.UcLabelTruck.Name = "UcLabelTruck"
        Me.UcLabelTruck.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTruck.Size = New System.Drawing.Size(80, 21)
        Me.UcLabelTruck.TabIndex = 2
        Me.UcLabelTruck.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTruck.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTruck.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTruck.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTruck.UCValue = "375ع23-13"
        '
        'UcLabelTruckDriver
        '
        Me.UcLabelTruckDriver._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTruckDriver._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTruckDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelTruckDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTruckDriver.Location = New System.Drawing.Point(4, 21)
        Me.UcLabelTruckDriver.Name = "UcLabelTruckDriver"
        Me.UcLabelTruckDriver.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTruckDriver.Size = New System.Drawing.Size(362, 21)
        Me.UcLabelTruckDriver.TabIndex = 3
        Me.UcLabelTruckDriver.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelTruckDriver.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTruckDriver.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelTruckDriver.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTruckDriver.UCValue = "مرتضی شاهمرادی"
        '
        'UcLabelDateTimeComposite
        '
        Me.UcLabelDateTimeComposite._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelDateTimeComposite._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelDateTimeComposite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelDateTimeComposite.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateTimeComposite.Location = New System.Drawing.Point(162, 3)
        Me.UcLabelDateTimeComposite.Name = "UcLabelDateTimeComposite"
        Me.UcLabelDateTimeComposite.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDateTimeComposite.Size = New System.Drawing.Size(136, 21)
        Me.UcLabelDateTimeComposite.TabIndex = 4
        Me.UcLabelDateTimeComposite.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDateTimeComposite.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelDateTimeComposite.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDateTimeComposite.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDateTimeComposite.UCValue = "1397/07/14 - 10:88:88"
        '
        'UcucSequentialTurnCollection
        '
        Me.UcucSequentialTurnCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucSequentialTurnCollection.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcucSequentialTurnCollection.Location = New System.Drawing.Point(5, 5)
        Me.UcucSequentialTurnCollection.Name = "UcucSequentialTurnCollection"
        Me.UcucSequentialTurnCollection.Size = New System.Drawing.Size(467, 22)
        Me.UcucSequentialTurnCollection.TabIndex = 6
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.Active = True
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.Deleted = False
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.SequentialTurnColor = "Yellow"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.SequentialTurnId = CType(2, Long)
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.SequentialTurnKeyWord = "T"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.SequentialTurnTitle = "تسلسل نوبت جاده ای"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2.ViewFlag = True
        Me.UcucSequentialTurnCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure2
        Me.UcucSequentialTurnCollection.UCSimulatedSequentialTurnId = CType(2, Long)
        '
        'UCViewerNSSTurnDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSTurnDataEntry"
        Me.Size = New System.Drawing.Size(477, 79)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlOutter As System.Windows.Forms.Panel
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents UcNumberTurnId As R2CoreGUI.UCNumber
    Friend WithEvents UcLabelTurnStatus As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelDateTimeComposite As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelTruckDriver As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelTruck As R2CoreGUI.UCLabel
    Friend WithEvents UcucSequentialTurnCollection As UCUCSequentialTurnCollection
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UcNumberTargetYear As R2CoreGUI.UCNumber
End Class
