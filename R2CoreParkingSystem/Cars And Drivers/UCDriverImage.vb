
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports R2Core.BaseStandardClass

Imports R2Core.DatabaseManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCDriverImage
    Inherits UCGeneral

    Private _NSSDriver As R2StandardDriverStructure = Nothing


#Region "General Properties"

    Public ReadOnly Property UCGetImage() As R2CoreImage
        Get
            If Object.Equals(My.Resources.DefaultDriverImage, PicDriver.Image) = True Then
                Throw New DriverImageCaptureException
            Else
                Return New R2CoreImage(PicDriver.Image)
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
            PicDriver.Image = My.Resources.DefaultDriverImage
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCTakeAndViewImageFromStream(YourCamera As R2CameraType) As Bitmap
        Try
            Dim Camera As R2Camera = New R2Camera(R2CoreParkingSystemMClassCameraManagement.GetCameraSetting(YourCamera))
            PicDriver.Image = Camera.GetAniPhoto()
            Camera = Nothing
        Catch exx As R2CoreParkingSystemCameraFailException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Dim CameraForTakeAndViewImageFromVideoPlayer As R2Camera = New R2Camera(R2CoreParkingSystemMClassCameraManagement.GetCameraSetting(R2TwoCamera.Camera1))
    Public Function UCTakeAndViewImageFromVideoPlayer(YourTerafficCardType As TerafficCardType, YourCamera As R2CameraType) As Bitmap
        Try
            CameraForTakeAndViewImageFromVideoPlayer.SetAniCarPhoto(YourTerafficCardType)
            PicDriver.Image = CameraForTakeAndViewImageFromVideoPlayer.CarCapturedImage
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Sub UCViewDriverImage(YourNSSDriver As R2StandardDriverStructure)
        Try
            _NSSDriver = YourNSSDriver
            PicDriver.Image = R2CoreParkingSystemMClassDrivers.GetDriverImage(YourNSSDriver,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS).GetImage()
        Catch exx As DriverImageNotExistException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewImage(YourImage As R2CoreImage)
        Try
            _NSSDriver = Nothing
            PicDriver.Image = YourImage.GetImage()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicDriver_Click(sender As Object, e As EventArgs) Handles PicDriver.Click
        Try
            Dim frmImageViewer As New FrmcImageViewer
            frmImageViewer.ViewImage(PicDriver.Image)
            frmImageViewer.ShowDialog()
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
