Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLstViewerAllOfnEnterExitId
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
        Dim R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1 As R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure = New R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.LstViewerAllOfnEnterExitId = New System.Windows.Forms.ListView()
        Me.UcucSequentialTurnCollection = New R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.LstViewerAllOfnEnterExitId)
        Me.PnlMain.Controls.Add(Me.UcucSequentialTurnCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(2, 2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(487, 238)
        Me.PnlMain.TabIndex = 0
        '
        'LstViewerAllOfnEnterExitId
        '
        Me.LstViewerAllOfnEnterExitId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstViewerAllOfnEnterExitId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstViewerAllOfnEnterExitId.GridLines = True
        Me.LstViewerAllOfnEnterExitId.Location = New System.Drawing.Point(3, 36)
        Me.LstViewerAllOfnEnterExitId.Name = "LstViewerAllOfnEnterExitId"
        Me.LstViewerAllOfnEnterExitId.Size = New System.Drawing.Size(479, 197)
        Me.LstViewerAllOfnEnterExitId.TabIndex = 2
        Me.LstViewerAllOfnEnterExitId.UseCompatibleStateImageBehavior = False
        Me.LstViewerAllOfnEnterExitId.View = System.Windows.Forms.View.List
        '
        'UcucSequentialTurnCollection
        '
        Me.UcucSequentialTurnCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucSequentialTurnCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucSequentialTurnCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucSequentialTurnCollection.Location = New System.Drawing.Point(3, 3)
        Me.UcucSequentialTurnCollection.Name = "UcucSequentialTurnCollection"
        Me.UcucSequentialTurnCollection.Padding = New System.Windows.Forms.Padding(1)
        Me.UcucSequentialTurnCollection.Size = New System.Drawing.Size(479, 27)
        Me.UcucSequentialTurnCollection.TabIndex = 1
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.Active = True
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.Deleted = False
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnColor = "Yellow"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnId = CType(2, Long)
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnKeyWord = "T"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.SequentialTurnTitle = "تسلسل نوبت تریلی"
        R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1.ViewFlag = True
        Me.UcucSequentialTurnCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure1
        Me.UcucSequentialTurnCollection.UCSimulatedSequentialTurnId = CType(2, Long)
        '
        'UCLstViewerAllOfnEnterExitId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLstViewerAllOfnEnterExitId"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(491, 242)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcucSequentialTurnCollection As R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection
    Friend WithEvents LstViewerAllOfnEnterExitId As Windows.Forms.ListView
End Class
