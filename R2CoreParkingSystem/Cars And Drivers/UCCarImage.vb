
Imports System.Drawing
Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreLPR.ConfigurationManagement


Public Class UCCarImage
    Inherits UCGeneral

    Private _SnapShot As Bitmap = Nothing
    Private _CurrentLicensePlateBlob As AForge.Imaging.Blob = Nothing
    Private _LPReport As String = String.Empty
    Private ImageCropDividW As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
    Private ImageCropDividH As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
    Private ImageCropDividX As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2)
    Private ImageCropDividY As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
    Private ImageCropDividWidht As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 4)
    Private ImageCropDividHight As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 5)



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub UCSetMarginColor(YourMarginColor As Color)
        PnlMain.BackColor = YourMarginColor
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        PicCar.Image = Nothing

    End Sub

    Public Function UCTakeAndViewImage(YourCamera As R2TwoCamera) As Bitmap
        Try
            Dim Camera As R2Camera = New R2Camera(R2CoreParkingSystemMClassCameraManagement.GetCameraSetting(YourCamera))
            _SnapShot = Camera.GetAniPhoto()
            PicCar.Image = _SnapShot
            Return _SnapShot
        Catch ex As R2CoreParkingSystemCameraFailException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Private Sub UCViewImage(YourImage As R2CoreImage)
        PicCar.Image = YourImage.GetImage()
    End Sub

    Public Sub UCViewColor(YourColor As Color)
        PicCar.Image = Nothing
        PicCar.BackColor=YourColor
    End Sub

    Public Sub UCViewDefaultCarImage(YourTerafficCardType As TerafficCardType)
        If YourTerafficCardType = TerafficCardType.Savari Then
            PicCar.Image = My.Resources.DefaultCarImageSavari
        Else
            PicCar.Image = My.Resources.DefaultCarImageTereilli
        End If
    End Sub

    Public Function UCGetLP() As R2StandardLicensePlateStructure
        Try
            _CurrentLicensePlateBlob = Nothing
            Dim myLP As R2StandardLicensePlateStructure = R2CoreParkingSystemMClassEnterExitManagement.GetLPFromLPR(_SnapShot, _LPReport, _CurrentLicensePlateBlob)
            If _CurrentLicensePlateBlob IsNot Nothing Then
                UCDrawLPRectangle()
            End If
            Return myLP
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Sub UCDrawRangeRectangle()
        Try
            Dim G As Graphics = Graphics.FromImage(PicCar.Image)
            Dim myODividW As Double = PicCar.Image.Width / ImageCropDividW
            Dim myODividH As Double = PicCar.Image.Height / ImageCropDividH
            G.DrawRectangle(New Pen(Brushes.Red, 10), New Rectangle(New Point(ImageCropDividX * myODividW, ImageCropDividY * myODividH), New Size(ImageCropDividWidht * myODividW, ImageCropDividHight * myODividH)))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCDrawLPRectangle()
        Try
            Dim G As Graphics = Graphics.FromImage(PicCar.Image)
            Dim myODividW As Double = PicCar.Image.Width / ImageCropDividW
            Dim myODividH As Double = PicCar.Image.Height / ImageCropDividH
            If Not (_CurrentLicensePlateBlob Is Nothing) Then
                G.DrawRectangle(New Pen(Brushes.Red, 10), New Rectangle(New Point(_CurrentLicensePlateBlob.Rectangle.X + ImageCropDividX * myODividW, _CurrentLicensePlateBlob.Rectangle.Y + ImageCropDividY * myODividH), New Size(_CurrentLicensePlateBlob.Rectangle.Width, _CurrentLicensePlateBlob.Rectangle.Height)))
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCDrawLP(YourLP As String)
        Try
            If YourLP.Length < 9 Then Exit Sub
            Dim StrFont As Font = New System.Drawing.Font("B ZAR", 80 * (PicCar.Height / PicCar.Width), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Dim G As Graphics = Graphics.FromImage(PicCar.Image)
            Dim a As Char() = YourLP.Trim.ToCharArray()
            G.DrawString(a(4), StrFont, Brushes.YellowGreen, 100, PicCar.Image.Height - 140)
            G.DrawString(a(5), StrFont, Brushes.YellowGreen, 130, PicCar.Image.Height - 140)
            G.DrawString(a(3), StrFont, Brushes.YellowGreen, 170, PicCar.Image.Height - 140)
            G.DrawString(a(0), StrFont, Brushes.YellowGreen, 230, PicCar.Image.Height - 140)
            G.DrawString(a(1), StrFont, Brushes.YellowGreen, 260, PicCar.Image.Height - 140)
            G.DrawString(a(2), StrFont, Brushes.YellowGreen, 290, PicCar.Image.Height - 140)
            G.DrawString(a(6), StrFont, Brushes.YellowGreen, 320, PicCar.Image.Height - 140)
            G.DrawString(a(7), StrFont, Brushes.YellowGreen, 350, PicCar.Image.Height - 140)
            G.DrawString(a(8), StrFont, Brushes.YellowGreen, 380, PicCar.Image.Height - 140)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCDrawText(YourText As String, YourLocation As Point)
        Try
            Dim G As Graphics = Graphics.FromImage(PicCar.Image)
            G.DrawString(YourText, New System.Drawing.Font("B ZAR", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte)), Brushes.YellowGreen, YourLocation.X, YourLocation.Y)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCDrawLeftText(YourText As String)
        Try
            Dim G As Graphics = Graphics.FromImage(PicCar.Image)
            G.DrawString(YourText, New System.Drawing.Font("B ZAR", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte)), Brushes.YellowGreen, New Point(50, PicCar.Image.Height - 120))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSaveCarEnterExitImage(YourNSSEnterExit As R2StandardEnterExitStructure)
        Try
            If (PicCar.Image Is My.Resources.DefaultCarImageSavari) Or (PicCar.Image Is My.Resources.DefaultCarImageTereilli) Then
            Else
                R2CoreParkingSystemMClassCars.SaveCarEnterExitImage(New R2CoreImage(PicCar.Image), YourNSSEnterExit,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarEnterExitImage(YourNSSCar As R2StandardCarStructure)
        Try
            UCViewImage(R2CoreParkingSystemMClassCars.GetCarEnterExitImage(YourNSSCar,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarEnterExitImage(YourNSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            UCViewImage(R2CoreParkingSystemMClassCars.GetCarEnterExitImage(YourNSSTerraficCard,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarEnterExitImage(YourNSSEnterExit As R2StandardEnterExitStructure)
        Try
            UCViewImage(R2CoreParkingSystemMClassCars.GetCarEnterExitImage(YourNSSEnterExit,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
