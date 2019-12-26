

Imports System.Drawing
Imports R2CoreGUI

Public Class UCFP
    Inherits UCGeneral

    Private _Segement As Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint = Nothing
    Public Event UCPicFPClicked(ByVal Pic As Bitmap)

#Region "General Properties"

    Public Property UCFPSegment As Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint
        Get
            Return _Segement
        End Get
        Set(ByVal value As Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint)
            _Segement = value
            PicFP.Image = value.Image
            LblLocation.Text = value.Hand.ToString + "  " + value.Position.ToString
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicFP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicFP.Click
        RaiseEvent UCPicFPClicked(PicFP.Image)
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




  


End Class
