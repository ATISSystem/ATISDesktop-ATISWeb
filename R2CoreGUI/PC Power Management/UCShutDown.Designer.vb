<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCShutDown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCShutDown))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicShutDown = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PicShutDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PicShutDown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 144)
        Me.Panel1.TabIndex = 0
        '
        'PicShutDown
        '
        Me.PicShutDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShutDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicShutDown.Image = CType(resources.GetObject("PicShutDown.Image"), System.Drawing.Image)
        Me.PicShutDown.Location = New System.Drawing.Point(0, 0)
        Me.PicShutDown.Name = "PicShutDown"
        Me.PicShutDown.Size = New System.Drawing.Size(144, 144)
        Me.PicShutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShutDown.TabIndex = 0
        Me.PicShutDown.TabStop = False
        '
        'UCShutDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCShutDown"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicShutDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PicShutDown As PictureBox
End Class
