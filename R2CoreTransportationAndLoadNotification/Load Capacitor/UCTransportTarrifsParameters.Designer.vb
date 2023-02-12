
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCTransportTarrifsParameters
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
        Me.PnlParams = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblLoaderType = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.PnlParams)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.Size = New System.Drawing.Size(789, 128)
        Me.PnlMain.TabIndex = 0
        '
        'PnlParams
        '
        Me.PnlParams.AutoScroll = True
        Me.PnlParams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlParams.Location = New System.Drawing.Point(5, 5)
        Me.PnlParams.Name = "PnlParams"
        Me.PnlParams.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlParams.Size = New System.Drawing.Size(777, 116)
        Me.PnlParams.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شرایط بار - پارامترهای موثر در تعرفه حمل بار"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(494, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(39, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "بارگیر :"
        '
        'LblLoaderType
        '
        Me.LblLoaderType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblLoaderType.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblLoaderType.ForeColor = System.Drawing.Color.Red
        Me.LblLoaderType.Location = New System.Drawing.Point(327, -4)
        Me.LblLoaderType.Name = "LblLoaderType"
        Me.LblLoaderType.Size = New System.Drawing.Size(167, 23)
        Me.LblLoaderType.TabIndex = 2
        Me.LblLoaderType.Text = " "
        Me.LblLoaderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCTransportTarrifsParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.LblLoaderType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTransportTarrifsParameters"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(809, 148)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlParams As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LblLoaderType As Windows.Forms.Label
End Class
