Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCTurnValidity
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
        Me.UcucSequentialTurnCollection = New R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcNumber = New R2CoreGUI.UCNumber()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabelCurrentTurnValidity = New R2CoreGUI.UCLabel()
        Me.SuspendLayout()
        '
        'UcucSequentialTurnCollection
        '
        Me.UcucSequentialTurnCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucSequentialTurnCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucSequentialTurnCollection.Location = New System.Drawing.Point(21, 83)
        Me.UcucSequentialTurnCollection.Name = "UcucSequentialTurnCollection"
        Me.UcucSequentialTurnCollection.Size = New System.Drawing.Size(914, 45)
        Me.UcucSequentialTurnCollection.TabIndex = 0
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
        Me.UcLabelTop.Size = New System.Drawing.Size(965, 52)
        Me.UcLabelTop.TabIndex = 353
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "ثبت و اطلاع رسانی اعتبار نوبت ها"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(850, 164)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(93, 32)
        Me.UcLabel1.TabIndex = 354
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "شماره اعتبار :"
        '
        'UcNumber
        '
        Me.UcNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumber.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumber.Location = New System.Drawing.Point(697, 172)
        Me.UcNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumber.Name = "UcNumber"
        Me.UcNumber.Size = New System.Drawing.Size(151, 20)
        Me.UcNumber.TabIndex = 355
        Me.UcNumber.UCAllowedMaxNumber = CType(100000000, Long)
        Me.UcNumber.UCAllowedMinNumber = CType(0, Long)
        Me.UcNumber.UCBackColor = System.Drawing.Color.White
        Me.UcNumber.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumber.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumber.UCBorder = True
        Me.UcNumber.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumber.UCEnable = True
        Me.UcNumber.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumber.UCForeColor = System.Drawing.Color.Black
        Me.UcNumber.UCMultiLine = False
        Me.UcNumber.UCValue = CType(0, Long)
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(552, 164)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(100, 38)
        Me.UcButtonSpecial.TabIndex = 356
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = True
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "ثبت اعتبار"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(826, 138)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(117, 32)
        Me.UcLabel2.TabIndex = 357
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "شماره اعتبار فعلی:"
        '
        'UcLabelCurrentTurnValidity
        '
        Me.UcLabelCurrentTurnValidity._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelCurrentTurnValidity._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelCurrentTurnValidity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelCurrentTurnValidity.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCurrentTurnValidity.Location = New System.Drawing.Point(703, 138)
        Me.UcLabelCurrentTurnValidity.Name = "UcLabelCurrentTurnValidity"
        Me.UcLabelCurrentTurnValidity.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCurrentTurnValidity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabelCurrentTurnValidity.Size = New System.Drawing.Size(117, 32)
        Me.UcLabelCurrentTurnValidity.TabIndex = 358
        Me.UcLabelCurrentTurnValidity.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCurrentTurnValidity.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcLabelCurrentTurnValidity.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelCurrentTurnValidity.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelCurrentTurnValidity.UCValue = "0"
        '
        'UCTurnValidity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.UcLabelCurrentTurnValidity)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.UcButtonSpecial)
        Me.Controls.Add(Me.UcNumber)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcLabelTop)
        Me.Controls.Add(Me.UcucSequentialTurnCollection)
        Me.Name = "UCTurnValidity"
        Me.Size = New System.Drawing.Size(965, 240)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcucSequentialTurnCollection As R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcNumber As R2CoreGUI.UCNumber
    Friend WithEvents UcButtonSpecial As R2CoreGUI.UCButtonSpecial
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabelCurrentTurnValidity As R2CoreGUI.UCLabel
End Class
