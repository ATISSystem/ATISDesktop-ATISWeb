Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSearcherTransportCompanies
    Inherits UCSearcheradvance

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSearcherTransportCompanies))
        Me.SuspendLayout
        '
        'UCSearcherTransportCompanies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "UCSearcherTransportCompanies"
        Me.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UCIcon = CType(resources.GetObject("$this.UCIcon"),System.Drawing.Image)
        Me.UCMaximizeHight = CType(200,Long)
        Me.UCShowDomainIcon = true
        Me.ResumeLayout(false)

End Sub

End Class
