
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports R2Core.BaseStandardClass

Imports R2Core.DatabaseManagement
Imports R2Core.HumanResourcesManagement.Personnel
Imports R2CoreGUI

Public Class UCPersonnelImage
    Inherits UCGeneral

    Public Event UCClickedEvent(PersonnelNSS As R2CoreStandardPersonnelStructure)
    Private _CurrentNSS As R2CoreStandardPersonnelStructure=Nothing



#Region "General Properties"

    <Browsable(false)>
    Public ReadOnly Property UCGetImage() As R2CoreImage
        Get
            If Object.Equals(My.Resources.DefaultPersonnelImage, PicPersonnel.Image) = True Then
                Throw New R2CorePersonnelImageCaptureException
            Else
                Return New R2CoreImage(PicPersonnel.Image)
            End If
        End Get
    End Property
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        Try
            PicPersonnel.Image = My.Resources.DefaultPersonnelImage
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewPersonnelImage(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
        Try
            _CurrentNSS=YourNSSPersonnel
            PicPersonnel.Image = R2CorePersonnelMClassManagement.GetPersonnelImage(YourNSSPersonnel,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS).GetImage()
            If Object.Equals(PicPersonnel.Image, Nothing) Then
                Throw New R2CorePersonnelNotExistException
            End If
        Catch exx As R2CorePersonnelNotExistException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewImage(YourImage As R2CoreImage)
        Try
            PicPersonnel.Image = YourImage.GetImage()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSavePersonnelImage(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
        Try
            R2CorePersonnelMClassManagement.SavePersonnelImage(YourNSSPersonnel,new R2CoreImage(PicPersonnel.Image),R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicPersonnel_Click(sender As Object, e As EventArgs) Handles PicPersonnel.Click
        Try
            ''Dim frmImageViewer As New FrmcImageViewer
            ''frmImageViewer.ViewImage(PicPersonnel.Image)
            ''frmImageViewer.ShowDialog()
            RaiseEvent UCClickedEvent(_CurrentNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
