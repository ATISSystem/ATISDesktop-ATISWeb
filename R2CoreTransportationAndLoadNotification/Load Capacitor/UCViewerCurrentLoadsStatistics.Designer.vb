Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTotalLoadsViewerforLoadCapacitor
    Inherits UCGeneral 

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
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcLabelRegisteredLoads = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelReleasedLoads = New R2CoreGUI.UCLabel()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcLabelRemainingLoads = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(173, 37)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(173, 37)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcLabel4)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.UcLabelRegisteredLoads)
        Me.PnlInner.Controls.Add(Me.UcLabelReleasedLoads)
        Me.PnlInner.Controls.Add(Me.UcLabelRemainingLoads)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(169, 33)
        Me.PnlInner.TabIndex = 0
        '
        'UcLabelRegisteredLoads
        '
        Me.UcLabelRegisteredLoads._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelRegisteredLoads._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelRegisteredLoads.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelRegisteredLoads.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelRegisteredLoads.Location = New System.Drawing.Point(0, 3)
        Me.UcLabelRegisteredLoads.Name = "UcLabelRegisteredLoads"
        Me.UcLabelRegisteredLoads.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelRegisteredLoads.Size = New System.Drawing.Size(52, 26)
        Me.UcLabelRegisteredLoads.TabIndex = 351
        Me.UcLabelRegisteredLoads.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelRegisteredLoads.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelRegisteredLoads.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelRegisteredLoads.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelRegisteredLoads.UCValue = "2532"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(43, 3)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(21, 26)
        Me.UcLabel1.TabIndex = 352
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "/"
        '
        'UcLabelReleasedLoads
        '
        Me.UcLabelReleasedLoads._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelReleasedLoads._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelReleasedLoads.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelReleasedLoads.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelReleasedLoads.Location = New System.Drawing.Point(54, 3)
        Me.UcLabelReleasedLoads.Name = "UcLabelReleasedLoads"
        Me.UcLabelReleasedLoads.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelReleasedLoads.Size = New System.Drawing.Size(55, 26)
        Me.UcLabelReleasedLoads.TabIndex = 353
        Me.UcLabelReleasedLoads.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelReleasedLoads.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelReleasedLoads.UCForeColor = System.Drawing.Color.ForestGreen
        Me.UcLabelReleasedLoads.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelReleasedLoads.UCValue = "2532"
        '
        'UcLabel4
        '
        Me.UcLabel4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(101, 3)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(21, 26)
        Me.UcLabel4.TabIndex = 354
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "/"
        '
        'UcLabelRemainingLoads
        '
        Me.UcLabelRemainingLoads._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelRemainingLoads._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelRemainingLoads.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelRemainingLoads.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelRemainingLoads.Location = New System.Drawing.Point(116, 3)
        Me.UcLabelRemainingLoads.Name = "UcLabelRemainingLoads"
        Me.UcLabelRemainingLoads.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelRemainingLoads.Size = New System.Drawing.Size(55, 26)
        Me.UcLabelRemainingLoads.TabIndex = 355
        Me.UcLabelRemainingLoads.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelRemainingLoads.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelRemainingLoads.UCForeColor = System.Drawing.Color.MediumBlue
        Me.UcLabelRemainingLoads.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelRemainingLoads.UCValue = "2532"
        '
        'UCTotalLoadsViewerforLoadCapacitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTotalLoadsViewerforLoadCapacitor"
        Me.Size = New System.Drawing.Size(173, 37)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabelRegisteredLoads As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelReleasedLoads As UCLabel
    Friend WithEvents UcLabelRemainingLoads As UCLabel
End Class
