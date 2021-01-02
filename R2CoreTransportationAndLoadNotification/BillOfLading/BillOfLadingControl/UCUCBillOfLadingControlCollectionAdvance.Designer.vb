
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCBillOfLadingControlCollectionAdvance
    Inherits UCGeneralExtended

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
        Me.UcSearcherSimple = New R2CoreGUI.UCSearcherSimple()
        Me.UcucBillOfLadingControlCollection = New R2CoreTransportationAndLoadNotification.UCUCBillOfLadingControlCollection()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcucBillOfLadingControlCollection)
        Me.PnlMain.Controls.Add(Me.UcSearcherSimple)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(254, 414)
        Me.PnlMain.TabIndex = 0
        '
        'UcSearcherSimple
        '
        Me.UcSearcherSimple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherSimple.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherSimple.Location = New System.Drawing.Point(-4, -6)
        Me.UcSearcherSimple.Name = "UcSearcherSimple"
        Me.UcSearcherSimple.Padding = New System.Windows.Forms.Padding(10)
        Me.UcSearcherSimple.Size = New System.Drawing.Size(262, 56)
        Me.UcSearcherSimple.TabIndex = 1
        Me.UcSearcherSimple.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherSimple.UCTextDisabled = "قسمتی از عنوان کنترل بارنامه را وارد نمایید"
        '
        'UcucBillOfLadingControlCollection
        '
        Me.UcucBillOfLadingControlCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucBillOfLadingControlCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucBillOfLadingControlCollection.Location = New System.Drawing.Point(6, 46)
        Me.UcucBillOfLadingControlCollection.Name = "UcucBillOfLadingControlCollection"
        Me.UcucBillOfLadingControlCollection.Size = New System.Drawing.Size(242, 365)
        Me.UcucBillOfLadingControlCollection.TabIndex = 0
        '
        'UCUCBillOfLadingControlCollectionAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCBillOfLadingControlCollectionAdvance"
        Me.Size = New System.Drawing.Size(254, 414)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcucBillOfLadingControlCollection As UCUCBillOfLadingControlCollection
    Friend WithEvents UcSearcherSimple As R2CoreGUI.UCSearcherSimple
End Class
