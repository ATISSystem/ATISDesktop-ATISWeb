<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCComputerMessageReserveTurnRegisterRequestConfirmation
    Inherits R2CoreGUI.UCComputerMessage

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
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty1 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Me.UcButtonConfirmation = New R2CoreGUI.UCButtonCButton()
        Me.UcTextBoxMobileNumber = New R2CoreGUI.UCTextBox()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.SuspendLayout
        '
        'UcButtonConfirmation
        '
        Me.UcButtonConfirmation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonConfirmation.Location = New System.Drawing.Point(18, 16)
        Me.UcButtonConfirmation.Name = "UcButtonConfirmation"
        Me.UcButtonConfirmation.Size = New System.Drawing.Size(100, 106)
        Me.UcButtonConfirmation.TabIndex = 2
        Me.UcButtonConfirmation.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Gold, System.Drawing.Color.Gold}
        CBlendItems1.iPoint = New Single() {0!, 1!}
        Me.UcButtonConfirmation.UCColorFillBlend = CBlendItems1
        Me.UcButtonConfirmation.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty1.All = 16
        CornersProperty1.LowerLeft = 16
        CornersProperty1.LowerRight = 16
        CornersProperty1.UpperLeft = 16
        CornersProperty1.UpperRight = 16
        Me.UcButtonConfirmation.UCCorners = CornersProperty1
        Me.UcButtonConfirmation.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonConfirmation.UCEnable = true
        Me.UcButtonConfirmation.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonConfirmation.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonConfirmation.UCText = "تایید درخواست صدور نوبت رزرو"
        '
        'UcTextBoxMobileNumber
        '
        Me.UcTextBoxMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxMobileNumber.Location = New System.Drawing.Point(125, 78)
        Me.UcTextBoxMobileNumber.Name = "UcTextBoxMobileNumber"
        Me.UcTextBoxMobileNumber.Size = New System.Drawing.Size(118, 22)
        Me.UcTextBoxMobileNumber.TabIndex = 3
        Me.UcTextBoxMobileNumber.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxMobileNumber.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxMobileNumber.UCBorder = true
        Me.UcTextBoxMobileNumber.UCBorderColor = System.Drawing.Color.Black
        Me.UcTextBoxMobileNumber.UCEnable = true
        Me.UcTextBoxMobileNumber.UCFont = New System.Drawing.Font("Alborz Titr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcTextBoxMobileNumber.UCForeColor = System.Drawing.Color.Red
        Me.UcTextBoxMobileNumber.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxMobileNumber.UCMaxCharacterReached = CType(11,Short)
        Me.UcTextBoxMobileNumber.UCMaxNumber = CType(99999999999,Long)
        Me.UcTextBoxMobileNumber.UCMultiLine = false
        Me.UcTextBoxMobileNumber.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.OnlyDigit
        Me.UcTextBoxMobileNumber.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxMobileNumber.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxMobileNumber.UCValue = "09132043148"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(125, 43)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(116, 32)
        Me.UcLabel2.TabIndex = 4
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "شماره موبایل"
        '
        'UCComputerMessageReserveTurnRegisterRequestConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.UcTextBoxMobileNumber)
        Me.Controls.Add(Me.UcButtonConfirmation)
        Me.Name = "UCComputerMessageReserveTurnRegisterRequestConfirmation"
        Me.Size = New System.Drawing.Size(691, 143)
        Me.Controls.SetChildIndex(Me.UcButtonConfirmation, 0)
        Me.Controls.SetChildIndex(Me.UcTextBoxMobileNumber, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcButtonConfirmation As R2CoreGUI.UCButtonCButton
    Friend WithEvents UcTextBoxMobileNumber As R2CoreGUI.UCTextBox
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
End Class
