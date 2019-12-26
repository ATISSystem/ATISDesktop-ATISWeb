Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPublicConfigurations
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
        Me.PnlPublicConfigurationOfR2Core = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationsOfCore = New R2CoreGUI.UCConfigurationsOfCore()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlPublicConfigurationOfR2CoreParkingSystem = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationOfParkingCore = New R2CoreParkingSystem.UCConfigurationOfParkingCore()
        Me.PnlPublicConfigurationOfPayanehCore = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationOfPayanehCore = New PayanehClassLibrary.UCConfigurationOfPayanehCore()
        Me.PnlPublicConfigurationOfTransportCompanies = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha7 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationOfTransportCompanies = New PayanehClassLibrary.UCConfigurationOfTransportCompanies()
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha9 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha10 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationOfAnnouncementHalls = New R2CoreTransportationAndLoadNotification.UCConfigurationOfAnnouncementHalls()
        Me.PnlPublicConfigurationOfR2Core.SuspendLayout
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.SuspendLayout
        Me.PnlPublicConfigurationOfPayanehCore.SuspendLayout
        Me.PnlPublicConfigurationOfTransportCompanies.SuspendLayout
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(171, 178)
        '
        'PnlPublicConfigurationOfR2Core
        '
        Me.PnlPublicConfigurationOfR2Core.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPublicConfigurationOfR2Core.BackColor = System.Drawing.Color.Transparent
        Me.PnlPublicConfigurationOfR2Core.Border = true
        Me.PnlPublicConfigurationOfR2Core.BorderColor = System.Drawing.Color.Black
        Me.PnlPublicConfigurationOfR2Core.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlPublicConfigurationOfR2Core.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlPublicConfigurationOfR2Core.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlPublicConfigurationOfR2Core.Controls.Add(Me.UcConfigurationsOfCore)
        Me.PnlPublicConfigurationOfR2Core.CornerRadius = 20
        Me.PnlPublicConfigurationOfR2Core.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlPublicConfigurationOfR2Core.Gradient = true
        Me.PnlPublicConfigurationOfR2Core.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlPublicConfigurationOfR2Core.GradientOffset = 1!
        Me.PnlPublicConfigurationOfR2Core.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlPublicConfigurationOfR2Core.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlPublicConfigurationOfR2Core.Grayscale = false
        Me.PnlPublicConfigurationOfR2Core.Image = Nothing
        Me.PnlPublicConfigurationOfR2Core.ImageAlpha = 75
        Me.PnlPublicConfigurationOfR2Core.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlPublicConfigurationOfR2Core.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlPublicConfigurationOfR2Core.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlPublicConfigurationOfR2Core.Location = New System.Drawing.Point(5, 50)
        Me.PnlPublicConfigurationOfR2Core.Name = "PnlPublicConfigurationOfR2Core"
        Me.PnlPublicConfigurationOfR2Core.Rounded = true
        Me.PnlPublicConfigurationOfR2Core.Size = New System.Drawing.Size(995, 512)
        Me.PnlPublicConfigurationOfR2Core.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlPublicConfigurationOfR2Core
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlPublicConfigurationOfR2Core
        '
        'UcConfigurationsOfCore
        '
        Me.UcConfigurationsOfCore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationsOfCore.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationsOfCore.Location = New System.Drawing.Point(3, 1)
        Me.UcConfigurationsOfCore.Name = "UcConfigurationsOfCore"
        Me.UcConfigurationsOfCore.Padding = New System.Windows.Forms.Padding(5)
        Me.UcConfigurationsOfCore.Size = New System.Drawing.Size(985, 439)
        Me.UcConfigurationsOfCore.TabIndex = 0
        Me.UcConfigurationsOfCore.UCTitle = "تنظیمات پایه سیستم"
        Me.UcConfigurationsOfCore.UCViewTitle = false
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlPublicConfigurationOfR2CoreParkingSystem
        '
        'PnlPublicConfigurationOfR2CoreParkingSystem
        '
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.BackColor = System.Drawing.Color.Transparent
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Border = true
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.BorderColor = System.Drawing.Color.Black
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Controls.Add(Me.UcConfigurationOfParkingCore)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.CornerRadius = 20
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Gradient = true
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.GradientOffset = 1!
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Grayscale = false
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Image = Nothing
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.ImageAlpha = 75
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Location = New System.Drawing.Point(5, 50)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Name = "PnlPublicConfigurationOfR2CoreParkingSystem"
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Rounded = true
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.Size = New System.Drawing.Size(995, 512)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.TabIndex = 51
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlPublicConfigurationOfR2CoreParkingSystem
        '
        'UcConfigurationOfParkingCore
        '
        Me.UcConfigurationOfParkingCore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationOfParkingCore.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationOfParkingCore.Location = New System.Drawing.Point(2, 1)
        Me.UcConfigurationOfParkingCore.Name = "UcConfigurationOfParkingCore"
        Me.UcConfigurationOfParkingCore.Padding = New System.Windows.Forms.Padding(2)
        Me.UcConfigurationOfParkingCore.Size = New System.Drawing.Size(990, 511)
        Me.UcConfigurationOfParkingCore.TabIndex = 0
        Me.UcConfigurationOfParkingCore.UCTitle = ""
        Me.UcConfigurationOfParkingCore.UCViewTitle = false
        '
        'PnlPublicConfigurationOfPayanehCore
        '
        Me.PnlPublicConfigurationOfPayanehCore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPublicConfigurationOfPayanehCore.BackColor = System.Drawing.Color.Transparent
        Me.PnlPublicConfigurationOfPayanehCore.Border = true
        Me.PnlPublicConfigurationOfPayanehCore.BorderColor = System.Drawing.Color.Black
        Me.PnlPublicConfigurationOfPayanehCore.Colors.Add(Me.ColorWithAlpha5)
        Me.PnlPublicConfigurationOfPayanehCore.Colors.Add(Me.ColorWithAlpha6)
        Me.PnlPublicConfigurationOfPayanehCore.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlPublicConfigurationOfPayanehCore.Controls.Add(Me.UcConfigurationOfPayanehCore)
        Me.PnlPublicConfigurationOfPayanehCore.CornerRadius = 20
        Me.PnlPublicConfigurationOfPayanehCore.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlPublicConfigurationOfPayanehCore.Gradient = true
        Me.PnlPublicConfigurationOfPayanehCore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlPublicConfigurationOfPayanehCore.GradientOffset = 1!
        Me.PnlPublicConfigurationOfPayanehCore.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlPublicConfigurationOfPayanehCore.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlPublicConfigurationOfPayanehCore.Grayscale = false
        Me.PnlPublicConfigurationOfPayanehCore.Image = Nothing
        Me.PnlPublicConfigurationOfPayanehCore.ImageAlpha = 75
        Me.PnlPublicConfigurationOfPayanehCore.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlPublicConfigurationOfPayanehCore.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlPublicConfigurationOfPayanehCore.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlPublicConfigurationOfPayanehCore.Location = New System.Drawing.Point(5, 50)
        Me.PnlPublicConfigurationOfPayanehCore.Name = "PnlPublicConfigurationOfPayanehCore"
        Me.PnlPublicConfigurationOfPayanehCore.Rounded = true
        Me.PnlPublicConfigurationOfPayanehCore.Size = New System.Drawing.Size(995, 512)
        Me.PnlPublicConfigurationOfPayanehCore.TabIndex = 52
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha5.Parent = Me.PnlPublicConfigurationOfPayanehCore
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha6.Parent = Me.PnlPublicConfigurationOfPayanehCore
        '
        'UcConfigurationOfPayanehCore
        '
        Me.UcConfigurationOfPayanehCore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationOfPayanehCore.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationOfPayanehCore.Location = New System.Drawing.Point(1, 1)
        Me.UcConfigurationOfPayanehCore.Name = "UcConfigurationOfPayanehCore"
        Me.UcConfigurationOfPayanehCore.Padding = New System.Windows.Forms.Padding(2)
        Me.UcConfigurationOfPayanehCore.Size = New System.Drawing.Size(990, 452)
        Me.UcConfigurationOfPayanehCore.TabIndex = 0
        Me.UcConfigurationOfPayanehCore.UCTitle = ""
        Me.UcConfigurationOfPayanehCore.UCViewTitle = false
        '
        'PnlPublicConfigurationOfTransportCompanies
        '
        Me.PnlPublicConfigurationOfTransportCompanies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPublicConfigurationOfTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.PnlPublicConfigurationOfTransportCompanies.Border = true
        Me.PnlPublicConfigurationOfTransportCompanies.BorderColor = System.Drawing.Color.Black
        Me.PnlPublicConfigurationOfTransportCompanies.Colors.Add(Me.ColorWithAlpha7)
        Me.PnlPublicConfigurationOfTransportCompanies.Colors.Add(Me.ColorWithAlpha8)
        Me.PnlPublicConfigurationOfTransportCompanies.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlPublicConfigurationOfTransportCompanies.Controls.Add(Me.UcConfigurationOfTransportCompanies)
        Me.PnlPublicConfigurationOfTransportCompanies.CornerRadius = 20
        Me.PnlPublicConfigurationOfTransportCompanies.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlPublicConfigurationOfTransportCompanies.Gradient = true
        Me.PnlPublicConfigurationOfTransportCompanies.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlPublicConfigurationOfTransportCompanies.GradientOffset = 1!
        Me.PnlPublicConfigurationOfTransportCompanies.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlPublicConfigurationOfTransportCompanies.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlPublicConfigurationOfTransportCompanies.Grayscale = false
        Me.PnlPublicConfigurationOfTransportCompanies.Image = Nothing
        Me.PnlPublicConfigurationOfTransportCompanies.ImageAlpha = 75
        Me.PnlPublicConfigurationOfTransportCompanies.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlPublicConfigurationOfTransportCompanies.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlPublicConfigurationOfTransportCompanies.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlPublicConfigurationOfTransportCompanies.Location = New System.Drawing.Point(5, 50)
        Me.PnlPublicConfigurationOfTransportCompanies.Name = "PnlPublicConfigurationOfTransportCompanies"
        Me.PnlPublicConfigurationOfTransportCompanies.Rounded = true
        Me.PnlPublicConfigurationOfTransportCompanies.Size = New System.Drawing.Size(995, 512)
        Me.PnlPublicConfigurationOfTransportCompanies.TabIndex = 53
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha7.Parent = Me.PnlPublicConfigurationOfTransportCompanies
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha8.Parent = Me.PnlPublicConfigurationOfTransportCompanies
        '
        'UcConfigurationOfTransportCompanies
        '
        Me.UcConfigurationOfTransportCompanies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationOfTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationOfTransportCompanies.Location = New System.Drawing.Point(2, -3)
        Me.UcConfigurationOfTransportCompanies.Name = "UcConfigurationOfTransportCompanies"
        Me.UcConfigurationOfTransportCompanies.Padding = New System.Windows.Forms.Padding(2)
        Me.UcConfigurationOfTransportCompanies.Size = New System.Drawing.Size(990, 336)
        Me.UcConfigurationOfTransportCompanies.TabIndex = 0
        Me.UcConfigurationOfTransportCompanies.UCTitle = ""
        Me.UcConfigurationOfTransportCompanies.UCViewTitle = false
        '
        'PnlPublicConfigurationOfTransportationAndLoadNotification
        '
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.BackColor = System.Drawing.Color.Transparent
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Border = true
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.BorderColor = System.Drawing.Color.Black
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Colors.Add(Me.ColorWithAlpha9)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Colors.Add(Me.ColorWithAlpha10)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Controls.Add(Me.UcConfigurationOfAnnouncementHalls)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.CornerRadius = 20
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Gradient = true
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.GradientOffset = 1!
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Grayscale = false
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Image = Nothing
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.ImageAlpha = 75
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Location = New System.Drawing.Point(5, 50)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Name = "PnlPublicConfigurationOfTransportationAndLoadNotification"
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Rounded = true
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.Size = New System.Drawing.Size(995, 512)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.TabIndex = 54
        '
        'ColorWithAlpha9
        '
        Me.ColorWithAlpha9.Alpha = 255
        Me.ColorWithAlpha9.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha9.Parent = Me.PnlPublicConfigurationOfTransportationAndLoadNotification
        '
        'ColorWithAlpha10
        '
        Me.ColorWithAlpha10.Alpha = 255
        Me.ColorWithAlpha10.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha10.Parent = Me.PnlPublicConfigurationOfTransportationAndLoadNotification
        '
        'UcConfigurationOfAnnouncementHalls
        '
        Me.UcConfigurationOfAnnouncementHalls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationOfAnnouncementHalls.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationOfAnnouncementHalls.Location = New System.Drawing.Point(2, 7)
        Me.UcConfigurationOfAnnouncementHalls.Name = "UcConfigurationOfAnnouncementHalls"
        Me.UcConfigurationOfAnnouncementHalls.Padding = New System.Windows.Forms.Padding(2)
        Me.UcConfigurationOfAnnouncementHalls.Size = New System.Drawing.Size(990, 500)
        Me.UcConfigurationOfAnnouncementHalls.TabIndex = 0
        Me.UcConfigurationOfAnnouncementHalls.UCTitle = ""
        Me.UcConfigurationOfAnnouncementHalls.UCViewTitle = false
        '
        'FrmcPublicConfigurations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPublicConfigurationOfR2Core)
        Me.Controls.Add(Me.PnlPublicConfigurationOfR2CoreParkingSystem)
        Me.Controls.Add(Me.PnlPublicConfigurationOfTransportationAndLoadNotification)
        Me.Controls.Add(Me.PnlPublicConfigurationOfPayanehCore)
        Me.Controls.Add(Me.PnlPublicConfigurationOfTransportCompanies)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPublicConfigurations"
        Me.Text = "FrmcConfiguration"
        Me.Controls.SetChildIndex(Me.PnlPublicConfigurationOfTransportCompanies, 0)
        Me.Controls.SetChildIndex(Me.PnlPublicConfigurationOfPayanehCore, 0)
        Me.Controls.SetChildIndex(Me.PnlPublicConfigurationOfTransportationAndLoadNotification, 0)
        Me.Controls.SetChildIndex(Me.PnlPublicConfigurationOfR2CoreParkingSystem, 0)
        Me.Controls.SetChildIndex(Me.PnlPublicConfigurationOfR2Core, 0)
        Me.PnlPublicConfigurationOfR2Core.ResumeLayout(false)
        Me.PnlPublicConfigurationOfR2CoreParkingSystem.ResumeLayout(false)
        Me.PnlPublicConfigurationOfPayanehCore.ResumeLayout(false)
        Me.PnlPublicConfigurationOfTransportCompanies.ResumeLayout(false)
        Me.PnlPublicConfigurationOfTransportationAndLoadNotification.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlPublicConfigurationOfR2Core As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationsOfCore As UCConfigurationsOfCore
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlPublicConfigurationOfR2CoreParkingSystem As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationOfParkingCore As R2CoreParkingSystem.UCConfigurationOfParkingCore
    Friend WithEvents PnlPublicConfigurationOfPayanehCore As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationOfPayanehCore As UCConfigurationOfPayanehCore
    Friend WithEvents PnlPublicConfigurationOfTransportCompanies As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha7 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationOfTransportCompanies As UCConfigurationOfTransportCompanies
    Friend WithEvents PnlPublicConfigurationOfTransportationAndLoadNotification As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha9 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha10 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationOfAnnouncementHalls As R2CoreTransportationAndLoadNotification.UCConfigurationOfAnnouncementHalls
End Class
