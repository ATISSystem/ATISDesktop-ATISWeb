Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcLoadingAndDischargingPlaces
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
        Me.PnlLADPlaces = New System.Windows.Forms.Panel()
        Me.UcSearcherLoadingAndDischargingPlaces = New R2CoreTransportationAndLoadNotification.UCSearcherLoadingAndDischargingPlaces()
        Me.UcLoadingAndDischargingPlaceDataEntry = New R2CoreTransportationAndLoadNotification.UCLoadingAndDischargingPlaceDataEntry()
        Me.PnlLADPlaces.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -334)
        '
        'PnlLADPlaces
        '
        Me.PnlLADPlaces.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLADPlaces.BackColor = System.Drawing.Color.Transparent
        Me.PnlLADPlaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLADPlaces.Controls.Add(Me.UcSearcherLoadingAndDischargingPlaces)
        Me.PnlLADPlaces.Controls.Add(Me.UcLoadingAndDischargingPlaceDataEntry)
        Me.PnlLADPlaces.Location = New System.Drawing.Point(5, 50)
        Me.PnlLADPlaces.Name = "PnlLADPlaces"
        Me.PnlLADPlaces.Size = New System.Drawing.Size(995, 512)
        Me.PnlLADPlaces.TabIndex = 49
        '
        'UcSearcherLoadingAndDischargingPlaces
        '
        Me.UcSearcherLoadingAndDischargingPlaces.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSearcherLoadingAndDischargingPlaces.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherLoadingAndDischargingPlaces.Location = New System.Drawing.Point(481, 37)
        Me.UcSearcherLoadingAndDischargingPlaces.Name = "UcSearcherLoadingAndDischargingPlaces"
        Me.UcSearcherLoadingAndDischargingPlaces.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherLoadingAndDischargingPlaces.Size = New System.Drawing.Size(275, 165)
        Me.UcSearcherLoadingAndDischargingPlaces.TabIndex = 0
        Me.UcSearcherLoadingAndDischargingPlaces.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherLoadingAndDischargingPlaces.UCFillFirstTime = False
        Me.UcSearcherLoadingAndDischargingPlaces.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadingAndDischargingPlaces.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherLoadingAndDischargingPlaces.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherLoadingAndDischargingPlaces.UCIcon = Nothing
        Me.UcSearcherLoadingAndDischargingPlaces.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherLoadingAndDischargingPlaces.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherLoadingAndDischargingPlaces.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.Simple
        Me.UcSearcherLoadingAndDischargingPlaces.UCShowDomainIcon = False
        '
        'UcLoadingAndDischargingPlaceDataEntry
        '
        Me.UcLoadingAndDischargingPlaceDataEntry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLoadingAndDischargingPlaceDataEntry.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadingAndDischargingPlaceDataEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcLoadingAndDischargingPlaceDataEntry.Location = New System.Drawing.Point(52, 208)
        Me.UcLoadingAndDischargingPlaceDataEntry.Name = "UcLoadingAndDischargingPlaceDataEntry"
        Me.UcLoadingAndDischargingPlaceDataEntry.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLoadingAndDischargingPlaceDataEntry.Size = New System.Drawing.Size(888, 299)
        Me.UcLoadingAndDischargingPlaceDataEntry.TabIndex = 1
        Me.UcLoadingAndDischargingPlaceDataEntry.UCNSSCurrent = Nothing
        '
        'FrmcLoadingAndDischargingPlaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlLADPlaces)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadingAndDischargingPlaces"
        Me.Text = "FrmcLoadingAndDischargingPlaces"
        Me.Controls.SetChildIndex(Me.PnlLADPlaces, 0)
        Me.PnlLADPlaces.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlLADPlaces As Windows.Forms.Panel
    Friend WithEvents UcSearcherLoadingAndDischargingPlaces As UCSearcherLoadingAndDischargingPlaces
    Friend WithEvents UcLoadingAndDischargingPlaceDataEntry As UCLoadingAndDischargingPlaceDataEntry
End Class
