Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTurnsComputerMessageProducer
    Inherits  FrmcGeneral

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
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest = New PayanehClassLibrary.UCComputerMessageProducerRealTimeTurnRegisterRequest()
        Me.PnlRealTimeTurnRegisterRequest = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlEmergencyTurnRegisterRequest = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest = New PayanehClassLibrary.UCComputerMessageProducerEmergencyTurnRegisterRequest()
        Me.PnlReplicaTurnPrintRequest = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcComputerMessageProducerReplicaTurnPrintRequest = New PayanehClassLibrary.UCComputerMessageProducerReplicaTurnPrintRequest()
        Me.PnlRealTimeTurnRegisterRequest.SuspendLayout
        Me.PnlEmergencyTurnRegisterRequest.SuspendLayout
        Me.PnlReplicaTurnPrintRequest.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'UcComputerMessageProducerRealTimeTurnRegisterRequest
        '
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.Location = New System.Drawing.Point(7, 3)
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.Name = "UcComputerMessageProducerRealTimeTurnRegisterRequest"
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.Size = New System.Drawing.Size(981, 270)
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.TabIndex = 1
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.UCCMNote = ""
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.UCSendIsActive = false
        Me.UcComputerMessageProducerRealTimeTurnRegisterRequest.UCTitle = "درخواست صدور نوبت ناوگان باری - بلادرنگ"
        '
        'PnlRealTimeTurnRegisterRequest
        '
        Me.PnlRealTimeTurnRegisterRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlRealTimeTurnRegisterRequest.BackColor = System.Drawing.Color.Transparent
        Me.PnlRealTimeTurnRegisterRequest.Border = true
        Me.PnlRealTimeTurnRegisterRequest.BorderColor = System.Drawing.Color.Black
        Me.PnlRealTimeTurnRegisterRequest.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlRealTimeTurnRegisterRequest.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlRealTimeTurnRegisterRequest.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlRealTimeTurnRegisterRequest.Controls.Add(Me.UcComputerMessageProducerRealTimeTurnRegisterRequest)
        Me.PnlRealTimeTurnRegisterRequest.CornerRadius = 20
        Me.PnlRealTimeTurnRegisterRequest.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlRealTimeTurnRegisterRequest.Gradient = true
        Me.PnlRealTimeTurnRegisterRequest.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlRealTimeTurnRegisterRequest.GradientOffset = 1!
        Me.PnlRealTimeTurnRegisterRequest.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlRealTimeTurnRegisterRequest.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlRealTimeTurnRegisterRequest.Grayscale = false
        Me.PnlRealTimeTurnRegisterRequest.Image = Nothing
        Me.PnlRealTimeTurnRegisterRequest.ImageAlpha = 75
        Me.PnlRealTimeTurnRegisterRequest.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlRealTimeTurnRegisterRequest.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlRealTimeTurnRegisterRequest.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlRealTimeTurnRegisterRequest.Location = New System.Drawing.Point(5, 50)
        Me.PnlRealTimeTurnRegisterRequest.Name = "PnlRealTimeTurnRegisterRequest"
        Me.PnlRealTimeTurnRegisterRequest.Rounded = true
        Me.PnlRealTimeTurnRegisterRequest.Size = New System.Drawing.Size(995, 512)
        Me.PnlRealTimeTurnRegisterRequest.TabIndex = 202
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlRealTimeTurnRegisterRequest
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlRealTimeTurnRegisterRequest
        '
        'PnlEmergencyTurnRegisterRequest
        '
        Me.PnlEmergencyTurnRegisterRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlEmergencyTurnRegisterRequest.BackColor = System.Drawing.Color.Transparent
        Me.PnlEmergencyTurnRegisterRequest.Border = true
        Me.PnlEmergencyTurnRegisterRequest.BorderColor = System.Drawing.Color.Black
        Me.PnlEmergencyTurnRegisterRequest.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlEmergencyTurnRegisterRequest.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlEmergencyTurnRegisterRequest.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlEmergencyTurnRegisterRequest.Controls.Add(Me.UcComputerMessageProducerEmergencyTurnRegisterRequest)
        Me.PnlEmergencyTurnRegisterRequest.CornerRadius = 20
        Me.PnlEmergencyTurnRegisterRequest.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlEmergencyTurnRegisterRequest.Gradient = true
        Me.PnlEmergencyTurnRegisterRequest.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlEmergencyTurnRegisterRequest.GradientOffset = 1!
        Me.PnlEmergencyTurnRegisterRequest.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlEmergencyTurnRegisterRequest.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlEmergencyTurnRegisterRequest.Grayscale = false
        Me.PnlEmergencyTurnRegisterRequest.Image = Nothing
        Me.PnlEmergencyTurnRegisterRequest.ImageAlpha = 75
        Me.PnlEmergencyTurnRegisterRequest.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlEmergencyTurnRegisterRequest.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlEmergencyTurnRegisterRequest.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlEmergencyTurnRegisterRequest.Location = New System.Drawing.Point(5, 50)
        Me.PnlEmergencyTurnRegisterRequest.Name = "PnlEmergencyTurnRegisterRequest"
        Me.PnlEmergencyTurnRegisterRequest.Rounded = true
        Me.PnlEmergencyTurnRegisterRequest.Size = New System.Drawing.Size(995, 512)
        Me.PnlEmergencyTurnRegisterRequest.TabIndex = 203
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlEmergencyTurnRegisterRequest
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlEmergencyTurnRegisterRequest
        '
        'UcComputerMessageProducerEmergencyTurnRegisterRequest
        '
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.Location = New System.Drawing.Point(7, 3)
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.Name = "UcComputerMessageProducerEmergencyTurnRegisterRequest"
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.Size = New System.Drawing.Size(981, 309)
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.TabIndex = 0
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.UCCMNote = ""
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.UCSendIsActive = false
        Me.UcComputerMessageProducerEmergencyTurnRegisterRequest.UCTitle = "درخواست صدور نوبت ناوگان باری - اضطراری"
        '
        'PnlReplicaTurnPrintRequest
        '
        Me.PnlReplicaTurnPrintRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlReplicaTurnPrintRequest.BackColor = System.Drawing.Color.Transparent
        Me.PnlReplicaTurnPrintRequest.Border = true
        Me.PnlReplicaTurnPrintRequest.BorderColor = System.Drawing.Color.Black
        Me.PnlReplicaTurnPrintRequest.Colors.Add(Me.ColorWithAlpha5)
        Me.PnlReplicaTurnPrintRequest.Colors.Add(Me.ColorWithAlpha6)
        Me.PnlReplicaTurnPrintRequest.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReplicaTurnPrintRequest.Controls.Add(Me.UcComputerMessageProducerReplicaTurnPrintRequest)
        Me.PnlReplicaTurnPrintRequest.CornerRadius = 20
        Me.PnlReplicaTurnPrintRequest.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlReplicaTurnPrintRequest.Gradient = true
        Me.PnlReplicaTurnPrintRequest.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlReplicaTurnPrintRequest.GradientOffset = 1!
        Me.PnlReplicaTurnPrintRequest.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlReplicaTurnPrintRequest.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlReplicaTurnPrintRequest.Grayscale = false
        Me.PnlReplicaTurnPrintRequest.Image = Nothing
        Me.PnlReplicaTurnPrintRequest.ImageAlpha = 75
        Me.PnlReplicaTurnPrintRequest.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlReplicaTurnPrintRequest.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlReplicaTurnPrintRequest.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlReplicaTurnPrintRequest.Location = New System.Drawing.Point(5, 50)
        Me.PnlReplicaTurnPrintRequest.Name = "PnlReplicaTurnPrintRequest"
        Me.PnlReplicaTurnPrintRequest.Rounded = true
        Me.PnlReplicaTurnPrintRequest.Size = New System.Drawing.Size(995, 512)
        Me.PnlReplicaTurnPrintRequest.TabIndex = 204
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha5.Parent = Me.PnlReplicaTurnPrintRequest
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha6.Parent = Me.PnlReplicaTurnPrintRequest
        '
        'UcComputerMessageProducerReplicaTurnPrintRequest
        '
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.BackColor = System.Drawing.Color.Transparent
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.Location = New System.Drawing.Point(7, 3)
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.Name = "UcComputerMessageProducerReplicaTurnPrintRequest"
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.Padding = New System.Windows.Forms.Padding(10)
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.Size = New System.Drawing.Size(981, 270)
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.TabIndex = 0
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.UCCMNote = ""
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.UCSendIsActive = false
        Me.UcComputerMessageProducerReplicaTurnPrintRequest.UCTitle = "درخواست چاپ قبض نوبت - المثنی"
        '
        'FrmcTurnsComputerMessageProducer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlRealTimeTurnRegisterRequest)
        Me.Controls.Add(Me.PnlEmergencyTurnRegisterRequest)
        Me.Controls.Add(Me.PnlReplicaTurnPrintRequest)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTurnsComputerMessageProducer"
        Me.Text = "FrmcTurnsComputerMessageProducer"
        Me.Controls.SetChildIndex(Me.PnlReplicaTurnPrintRequest, 0)
        Me.Controls.SetChildIndex(Me.PnlEmergencyTurnRegisterRequest, 0)
        Me.Controls.SetChildIndex(Me.PnlRealTimeTurnRegisterRequest, 0)
        Me.PnlRealTimeTurnRegisterRequest.ResumeLayout(false)
        Me.PnlEmergencyTurnRegisterRequest.ResumeLayout(false)
        Me.PnlReplicaTurnPrintRequest.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents UcComputerMessageProducerRealTimeTurnRegisterRequest As UCComputerMessageProducerRealTimeTurnRegisterRequest
    Friend WithEvents PnlRealTimeTurnRegisterRequest As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlEmergencyTurnRegisterRequest As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcComputerMessageProducerEmergencyTurnRegisterRequest As UCComputerMessageProducerEmergencyTurnRegisterRequest
    Friend WithEvents PnlReplicaTurnPrintRequest As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcComputerMessageProducerReplicaTurnPrintRequest As UCComputerMessageProducerReplicaTurnPrintRequest
End Class
