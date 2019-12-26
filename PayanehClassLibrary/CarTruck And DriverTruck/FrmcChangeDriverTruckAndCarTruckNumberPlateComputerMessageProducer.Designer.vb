Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcChangeDriverTruckAndCarTruckNumberPlateComputerMessageProducer
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
        Me.PnlComputerMessageSender = New System.Windows.Forms.Panel()
        Me.UcComputerMessageProducerChangeDriverTruck1 = New PayanehClassLibrary.UCComputerMessageProducerChangeDriverTruck()
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1 = New PayanehClassLibrary.UCComputerMessageProducerChangeCarTruckNumberPlate()
        Me.PnlComputerMessageSender.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlComputerMessageSender
        '
        Me.PnlComputerMessageSender.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlComputerMessageSender.BackColor = System.Drawing.Color.Transparent
        Me.PnlComputerMessageSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlComputerMessageSender.Controls.Add(Me.UcComputerMessageProducerChangeDriverTruck1)
        Me.PnlComputerMessageSender.Controls.Add(Me.UcComputerMessageProducerChangeCarTruckNumberPlate1)
        Me.PnlComputerMessageSender.Location = New System.Drawing.Point(5, 50)
        Me.PnlComputerMessageSender.Name = "PnlComputerMessageSender"
        Me.PnlComputerMessageSender.Size = New System.Drawing.Size(995, 512)
        Me.PnlComputerMessageSender.TabIndex = 202
        '
        'UcComputerMessageProducerChangeDriverTruck1
        '
        Me.UcComputerMessageProducerChangeDriverTruck1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerChangeDriverTruck1.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerChangeDriverTruck1.Location = New System.Drawing.Point(112, 252)
        Me.UcComputerMessageProducerChangeDriverTruck1.Name = "UcComputerMessageProducerChangeDriverTruck1"
        Me.UcComputerMessageProducerChangeDriverTruck1.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerChangeDriverTruck1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcComputerMessageProducerChangeDriverTruck1.Size = New System.Drawing.Size(768, 251)
        Me.UcComputerMessageProducerChangeDriverTruck1.TabIndex = 1
        Me.UcComputerMessageProducerChangeDriverTruck1.UCCMNote = ""
        Me.UcComputerMessageProducerChangeDriverTruck1.UCTitle = ""
        Me.UcComputerMessageProducerChangeDriverTruck1.UCSendIsActive = false
        '
        'UcComputerMessageProducerChangeCarTruckNumberPlate1
        '
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.Location = New System.Drawing.Point(112, 6)
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.Name = "UcComputerMessageProducerChangeCarTruckNumberPlate1"
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.Size = New System.Drawing.Size(768, 251)
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.TabIndex = 0
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.UCCMNote = ""
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.UCtitle = ""
        Me.UcComputerMessageProducerChangeCarTruckNumberPlate1.UCSendIsActive = false
        '
        'FrmcChangeDriverTruckAndCarTruckNumberPlateComputerMessageProducer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlComputerMessageSender)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcChangeDriverTruckAndCarTruckNumberPlateComputerMessageProducer"
        Me.Text = "FrmcChangeDriverTruckAndCarTruckNumberPlateComputerMessageProducer"
        Me.Controls.SetChildIndex(Me.PnlComputerMessageSender, 0)
        Me.PnlComputerMessageSender.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlComputerMessageSender As System.Windows.Forms.Panel
    Friend WithEvents UcComputerMessageProducerChangeDriverTruck1 As UCComputerMessageProducerChangeDriverTruck
    Friend WithEvents UcComputerMessageProducerChangeCarTruckNumberPlate1 As UCComputerMessageProducerChangeCarTruckNumberPlate
End Class
