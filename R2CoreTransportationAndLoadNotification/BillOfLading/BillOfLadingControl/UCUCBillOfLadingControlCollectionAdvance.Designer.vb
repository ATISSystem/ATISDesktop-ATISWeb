﻿
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
        Me.UcucBillOfLadingControlCollection = New R2CoreTransportationAndLoadNotification.UCUCBillOfLadingControlCollection()
        Me.UcSearcherSimple = New R2CoreGUI.UCSearcherSimple()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcucBillOfLadingControlCollection)
        Me.PnlMain.Controls.Add(Me.UcSearcherSimple)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(451, 473)
        Me.PnlMain.TabIndex = 0
        '
        'UcucBillOfLadingControlCollection
        '
        Me.UcucBillOfLadingControlCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucBillOfLadingControlCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucBillOfLadingControlCollection.Location = New System.Drawing.Point(6, 98)
        Me.UcucBillOfLadingControlCollection.Name = "UcucBillOfLadingControlCollection"
        Me.UcucBillOfLadingControlCollection.Size = New System.Drawing.Size(439, 372)
        Me.UcucBillOfLadingControlCollection.TabIndex = 0
        '
        'UcSearcherSimple
        '
        Me.UcSearcherSimple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcSearcherSimple.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherSimple.Location = New System.Drawing.Point(-4, 46)
        Me.UcSearcherSimple.Name = "UcSearcherSimple"
        Me.UcSearcherSimple.Padding = New System.Windows.Forms.Padding(10)
        Me.UcSearcherSimple.Size = New System.Drawing.Size(459, 56)
        Me.UcSearcherSimple.TabIndex = 1
        Me.UcSearcherSimple.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherSimple.UCTextDisabled = "قسمتی از عنوان کنترل بارنامه را وارد نمایید"
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(451, 52)
        Me.UcLabelTop.TabIndex = 354
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "لیست کنترل بارنامه"
        '
        'UCUCBillOfLadingControlCollectionAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCBillOfLadingControlCollectionAdvance"
        Me.Size = New System.Drawing.Size(451, 473)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcucBillOfLadingControlCollection As UCUCBillOfLadingControlCollection
    Friend WithEvents UcSearcherSimple As R2CoreGUI.UCSearcherSimple
    Friend WithEvents UcLabelTop As UCLabel
End Class
