

Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

Imports AForge.Video.DirectShow
Imports AForge.Vision.Motion

Imports R2Core
Imports R2Core.SoftwareUserManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.FileShareRawGroupsManagement
Imports R2Core.LoggingManagement
Imports R2Core.DesktopProcessesManagement
Imports R2Core.R2PrimaryFileSharingWS
Imports R2Core.MonetarySettingTools
Imports R2CoreGUI
Imports R2CoreLPR.ConfigurationManagement
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreLPR.LicensePlateRecognizer
Imports R2CoreParkingSystem
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.DataBaseManagement
Imports R2CoreParkingSystem.ExceptionManagement
Imports R2CoreParkingSystem.FileShareRawGroupsManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.SoftwareUsersManagement
Imports R2Core.EntityRelationManagement
Imports R2CoreParkingSystem.EntityRelations
Imports R2Core.PermissionManagement
Imports R2CoreParkingSystem.SoftwareUsersManagement.Exceptions
Imports R2Core.RequesterManagement
Imports R2Core.PredefinedMessagesManagement
Imports R2CoreParkingSystem.PredefinedMessagesManagement
Imports R2CoreParkingSystem.AccountingManagement.ExceptionManagement
Imports R2Core.SecurityAlgorithmsManagement.SQLInjectionPrevention
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2CoreParkingSystem.TrafficCardsManagement.ExceptionManagement
Imports R2Core.MoneyWallet.MoneyWallet
Imports R2Core.MoneyWallet.Exceptions
Imports R2Core.SMS
Imports R2Core.SMS.Exceptions

Namespace Logging

    Public MustInherit Class R2CoreParkingSystemLogType
        Inherits R2CoreLogType

        Public Shared ReadOnly Property EntryExit As Int64 = 61
    End Class

    Public Class R2CoreParkingSystemLogManager

        Public Function GetEntryExitLogsWithTrafficCard(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As List(Of R2CoreStandardLoggingExtendedStructure)
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As New DataSet
                InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                     "Select Top 50 Logs.*,SoftwareUsers.UserName,LoggingTypes.LogColor from R2PrimaryLogging.dbo.TblLogging as Logs
                       Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On Logs.Userid=SoftwareUsers.UserId 
                       Inner Join R2PrimaryLogging.dbo.TblLoggingTypes as LoggingTypes On Logs.LogType=LoggingTypes.LogId 
                      Where Optional1 Like '%" & YourTrafficCard.CardNo & "%' order by DateTimeMilladi Desc", 0, Ds)
                Dim Lst As New List(Of R2CoreStandardLoggingExtendedStructure)
                For Loopx As Int64 = 1 To Ds.Tables(0).Rows.Count - 1
                    Dim NSSLog = New R2CoreStandardLoggingExtendedStructure(New R2CoreStandardLoggingStructure(Ds.Tables(0).Rows(Loopx).Item("logid"), Ds.Tables(0).Rows(Loopx).Item("LogType"), Ds.Tables(0).Rows(Loopx).Item("sharh").trim, Ds.Tables(0).Rows(Loopx).Item("optional1").trim, Ds.Tables(0).Rows(Loopx).Item("optional2").trim, Ds.Tables(0).Rows(Loopx).Item("optional3").trim, Ds.Tables(0).Rows(Loopx).Item("optional4").trim, Ds.Tables(0).Rows(Loopx).Item("optional5").trim, Ds.Tables(0).Rows(Loopx).Item("userid"), Ds.Tables(0).Rows(Loopx).Item("datetimemilladi"), Ds.Tables(0).Rows(Loopx).Item("dateshamsi").trim), Ds.Tables(0).Rows(Loopx).Item("UserName").trim, Color.FromName(Ds.Tables(0).Rows(Loopx).Item("LogColor").trim))
                    Lst.Add(NSSLog)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

End Namespace

Namespace DataBaseManagement

    Public Class R2ClassSqlConnectionSepas
        Inherits R2ClassSqlConnection

        Public Sub New()
            MyBase.New()
            Try
                _Connection = New SqlClient.SqlConnection(DefaultConnectionString.Replace("@IC", "Dbtransport"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
    End Class


End Namespace

Namespace CamerasManagement

    Public Enum R2ActiveType
        None = 0
        Active = 1
        InActive = 2
        ISDead = 3
        Pause = 4
    End Enum
    Public Enum R2TwoCamera
        None = 0
        Camera1 = 1
        Camera2 = 2
    End Enum
    Public Enum R2CameraType
        None = 0
        EnterCamera = 1
        ExitCamera = 2
        Bidirectional = 3
    End Enum
    Public Enum R2CaptureType
        None = 0
        DefaultCapture = 1
        AniiCapture = 2
        ThresholdCapture = 3
        LPRCapture = 4
    End Enum

    Public Class R2StandardCameraSettingStructure
        Public Sub New()
            MyBase.New()
            CameraActive = R2ActiveType.None
            CameraConnectionString = ""
            CaptureType = R2CaptureType.None
            CameraType = R2CameraType.None
            CameraName = ""
        End Sub

        Public Sub New(ByVal CameraActivee As R2ActiveType, ByVal CameraConnectionStringg As String, ByVal CaptureTypee As R2CaptureType, ByVal CameraTypee As R2CameraType, ByVal CameraNamee As String)
            CameraActive = CameraActivee
            CameraConnectionString = CameraConnectionStringg
            CaptureType = CaptureTypee
            CameraType = CameraTypee
            CameraName = CameraNamee
        End Sub

        Public Property CameraActive As R2ActiveType = R2ActiveType.None

        Public Property CameraConnectionString As String

        Public Property CaptureType As R2CaptureType = R2CaptureType.None

        Public Property CameraType As R2CameraType = R2CameraType.None

        Public Property CameraName As String
    End Class

    Public Class R2Camera

        Private CameraSetting As R2StandardCameraSettingStructure = New R2StandardCameraSettingStructure
        Public Event CameraRaisedError(ByRef Camera As R2Camera, ByVal Err As String)
        Public Event CameraActivate(ByRef Camera As R2Camera)
        Public Event CameraInActivate(ByRef Camera As R2Camera)
        Public Event CameraLPRecognized(ByRef Camera As R2Camera)
        Public Event CameraThresholdRecognized(ByRef Camera As R2Camera)
        Public Detector As MotionDetector = New MotionDetector(New TwoFramesDifferenceDetector(), New MotionAreaHighlighting())
        'Public WithEvents CameraVideoSource As IVideoSource
        Public LPR As R2CoreLicensePlateRecognizer
        Public CarCapturedImage As Bitmap
        Public LP As R2StandardLicensePlateStructure = New R2StandardLicensePlateStructure
        Private WithEvents VideoSourcePlayer As AForge.Controls.VideoSourcePlayer = New AForge.Controls.VideoSourcePlayer()
        Private myR2DateTime As R2Core.DateAndTimeManagement.R2DateTime = New R2Core.DateAndTimeManagement.R2DateTime
        'Private VideoFileReader As AForge.Video.FFMPEG.VideoFileReader

        Public Sub New(ByVal YourCameraSetting As R2StandardCameraSettingStructure)
            Try
                CameraSetting.CameraName = YourCameraSetting.CameraName
                CameraSetting.CaptureType = YourCameraSetting.CaptureType
                CameraSetting.CameraType = YourCameraSetting.CameraType
                CameraSetting.CameraConnectionString = YourCameraSetting.CameraConnectionString
                CameraSetting.CameraActive = YourCameraSetting.CameraActive
                If CameraSetting.CameraActive = R2ActiveType.Active Then CameraActive = R2ActiveType.Active
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Property CameraActive As R2ActiveType
            Get
                Return CameraSetting.CameraActive
            End Get
            Set(ByVal value As R2ActiveType)
                Try
                    If value = R2ActiveType.Active Then
                        If Mid(CameraSetting.CameraConnectionString, 1, 5).ToUpper = "INDEX" Then 'دوربین محلی
                            VideoSourcePlayer.VideoSource = New VideoCaptureDevice((New FilterInfoCollection(FilterCategory.VideoInputDevice))(0).MonikerString)
                            VideoSourcePlayer.Start()
                        ElseIf Mid(CameraSetting.CameraConnectionString, 1, 5).ToUpper = "HTTP:" Then 'دوربين آي پي 
                            VideoSourcePlayer.VideoSource = New AForge.Video.MJPEGStream(CameraSetting.CameraConnectionString)
                            VideoSourcePlayer.Start()
                        ElseIf Mid(CameraSetting.CameraConnectionString, 1, 5).ToUpper = "RTSP:" Then 'دوربين آي پي 
                            'VideoFileReader = New AForge.Video.FFMPEG.VideoFileReader
                        End If
                        RaiseEvent CameraActivate(Me)
                    ElseIf value = R2ActiveType.InActive Then
                        If VideoSourcePlayer.VideoSource IsNot Nothing Then
                            If VideoSourcePlayer.IsRunning = True Then
                                VideoSourcePlayer.SignalToStop()
                                VideoSourcePlayer.WaitForStop()
                            End If
                        End If
                        VideoSourcePlayer = Nothing
                        RaiseEvent CameraInActivate(Me)
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Set
        End Property

        'Private myAniCarImage As Bitmap = Nothing
        'Private Sub CameraVideoSource_NewFrame(ByVal sender As Object, ByVal eventArgs As AForge.Video.NewFrameEventArgs) Handles CameraVideoSource.NewFrame
        '    Try
        '        If CameraSetting.CaptureType = R2CaptureType.ThresholdCapture Then
        '            Dim MotionLevel As Single = Detector.ProcessFrame(eventArgs.Frame) * 10000
        '            If (MotionLevel > ConfigurationManagement.R2CoreParkingSystemMClassConfigurationManagement.GetThresholdLevelMin) And (MotionLevel < ConfigurationManagement.R2CoreParkingSystemMClassConfigurationManagement.GetThresholdLevelMax) Then
        '                CarCapturedImage = eventArgs.Frame
        '                LP = New R2CoreLPR.LicensePlate.R2StandardLicensePlateStructure
        '                RaiseEvent CameraThresholdRecognized(Me)
        '            End If
        '        ElseIf CameraSetting.CaptureType = R2CaptureType.LPRCapture Then
        '            'Dim myLP As R2CoreLPR.LicensePlate.R2StandardLicensePlateStructure = LPR.LicensePlateRecognitionProccess(eventArgs.Frame)
        '            'If myLP IsNot Nothing Then
        '            '    CarCapturedImage = eventArgs.Frame
        '            '    LP = myLP
        '            '    RaiseEvent CameraLPRecognized(Me)
        '            'End If
        '        ElseIf CameraSetting.CaptureType = R2CaptureType.AniiCapture Then
        '            myAniCarImage = New Bitmap(eventArgs.Frame)
        '            myPictureBox.Image = myAniCarImage
        '        End If
        '    Catch ex As Exception
        '        If R2CoreParkingSystem.ConfigurationManagement.R2CoreParkingSystemMClassConfigurationManagement.GetProgrammerDebugFlag = True Then Windows.Forms.MessageBox.Show("CameraVideoSource_NewFrame" + vbCrLf + ex.Message.ToString)
        '        RaiseEvent CameraRaisedError(Me, CameraSetting.CameraName + ":" + "CameraVideoSource_NewFrame()." + ex.Message.ToString)
        '    End Try
        'End Sub

        Private Sub VideoSourcePlayer_PlayingFinished(ByVal sender As Object, ByVal reason As AForge.Video.ReasonToFinishPlaying) Handles VideoSourcePlayer.PlayingFinished
            RaiseEvent CameraRaisedError(Me, CameraSetting.CameraName + ":" + "VideoSourcePlayer_PlayingFinished()." + reason.ToString)
        End Sub

        'Private Sub VideoSourcePlayer_VideoSourceError(ByVal sender As Object, ByVal eventArgs As AForge.Video.VideoSourceErrorEventArgs) Handles VideoSourcePlayer.er
        '    If R2CoreParkingSystem.ConfigurationManagement.R2CoreParkingSystemMClassConfigurationManagement.GetProgrammerDebugFlag = True Then Windows.Forms.MessageBox.Show("CameraVideoSource_VideoSourceError" + vbCrLf + eventArgs.Description)
        '    RaiseEvent CameraRaisedError(Me, CameraSetting.CameraName + ":" + "CameraVideoSource_VideoSourceError()." + eventArgs.Description)
        'End Sub

        Public Sub SetAniCarPhoto(YourTerafficCardType As TerafficCardType)
            Try
                If Mid(CameraSetting.CameraConnectionString, 1, 5).ToUpper = "INDEX" Then 'WebCam
                    If VideoSourcePlayer.IsRunning = True Then
                        CarCapturedImage = VideoSourcePlayer.GetCurrentVideoFrame
                    Else
                        VideoSourcePlayer.Start()
                        CarCapturedImage = VideoSourcePlayer.GetCurrentVideoFrame()
                        If CarCapturedImage Is Nothing Then
                            SetDefaultCarImage(YourTerafficCardType)
                        End If
                    End If
                ElseIf Mid(CameraSetting.CameraConnectionString, 1, 5).ToUpper = "HTTP:" Then 'Mjpeg
                    If VideoSourcePlayer.IsRunning = True Then
                        CarCapturedImage = VideoSourcePlayer.GetCurrentVideoFrame
                    Else
                        VideoSourcePlayer.Start()
                        CarCapturedImage = VideoSourcePlayer.GetCurrentVideoFrame()
                        If CarCapturedImage Is Nothing Then
                            SetDefaultCarImage(YourTerafficCardType)
                        End If
                    End If
                ElseIf Mid(CameraSetting.CameraConnectionString, 1, 5).ToUpper = "RTSP:" Then 'FFmpg
                    'VideoFileReader.Open(CameraSetting.CameraConnectionString)
                    'CarCapturedImage = VideoFileReader.ReadVideoFrame
                    'If CarCapturedImage Is Nothing Then
                    '    SetDefaultCarImage(YourTerafficCardType)
                    'End If
                    'VideoFileReader.Close()
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub StopCamera()
            Try
                If VideoSourcePlayer IsNot Nothing Then
                    If VideoSourcePlayer.IsRunning = True Then
                        VideoSourcePlayer.SignalToStop()
                        VideoSourcePlayer.WaitForStop()
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub SetDefaultCarImage(YourTerafficCardType As TerafficCardType)
            If YourTerafficCardType = TerafficCardType.Savari Then
                CarCapturedImage = My.Resources.DefaultCarImageSavari
            Else
                CarCapturedImage = My.Resources.DefaultCarImageTereilli
            End If
        End Sub

        Public Function GetAniPhoto() As Bitmap
            Try
                Dim Request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(CameraSetting.CameraConnectionString), Net.HttpWebRequest)
                Request.Credentials = New Net.NetworkCredential(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 6), R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 7))
                Request.KeepAlive = False
                Dim Response As Net.HttpWebResponse = DirectCast(Request.GetResponse, Net.HttpWebResponse)
                Return Image.FromStream(Response.GetResponseStream())
            Catch exx As Exception When TypeOf exx Is GetNSSException OrElse TypeOf exx Is GetDataException
                Throw exx
            Catch ex As Exception
                Throw New R2CoreParkingSystemCameraFailException
            End Try
        End Function
    End Class

    Public Class R2CoreParkingSystemMClassCameraManagement

        Public Shared Function GetCameraSetting(ByVal TwoCamera As R2TwoCamera) As R2StandardCameraSettingStructure
            Try
                Dim myCameraActive As R2ActiveType
                Dim myCameraConnectionString As String
                Dim myCameraName As String
                Dim myCameraType As R2CameraType
                Dim myCameraCaptureType As R2CaptureType
                If TwoCamera = R2TwoCamera.Camera1 Then
                    myCameraActive = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 0)
                    myCameraConnectionString = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 2)
                    myCameraName = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 1)
                    myCameraType = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 4)
                    myCameraCaptureType = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 5)
                Else
                    myCameraActive = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreParkingSystemConfigurations.Camera2, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 0)
                    myCameraConnectionString = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 2)
                    myCameraName = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 1)
                    myCameraType = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreParkingSystemConfigurations.Camera2, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 4)
                    myCameraCaptureType = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreParkingSystemConfigurations.Camera2, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 5)
                End If
                Return New R2StandardCameraSettingStructure(myCameraActive, myCameraConnectionString, myCameraCaptureType, myCameraType, myCameraName)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetDefualtCarImage(YourTerafficCardType As TerafficCardType) As Bitmap
            Try
                If YourTerafficCardType = TerafficCardType.Savari Then
                    Return My.Resources.DefaultCarImageSavari
                Else
                    Return My.Resources.DefaultCarImageTereilli
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetCarCapturedImageEnter(ByVal YourEnterExitId As Int64, ByVal YourFileTypex As String) As Image
            Try
                Dim ImagePath As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.SaveCarPicture, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
                If IO.File.Exists(ImagePath + "\" + YourEnterExitId.ToString.Trim + "." + YourFileTypex) = True Then
                    Return Image.FromFile(ImagePath + "\" + YourEnterExitId.ToString.Trim + "." + YourFileTypex)
                Else
                    ''Return My.Resources.DefaultCarImage
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreParkingSystemCameraFailException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "ارتباط با دوربین برقرار نیست"
            End Get
        End Property

    End Class


End Namespace

Namespace EnterExitManagement
    Public Enum R2EnterStatus
        None = 0
        NotUserPullCard = 1
        BlackList = 2
        EnterNoMoney = 3
        NormalEnter = 4
        LowCharge = 5
    End Enum
    Public Enum R2ExitStatus
        None = 0
        ExitNoMony = 1
        BlackList = 2
        NotUserPullCard = 3
        NormalExit = 4
        SystemExit = 5
    End Enum
    Public Enum R2EnterExitRequestType
        None = 0
        EnterRequest = 1
        ExitRequest = 2
    End Enum

    Public Class R2StandardEnterExitStructure
        Public Sub New()
            MyBase.New()
            EnterExitId = 0
            DateTimeMilladiEnter = ""
            DateShamsiEnter = ""
            TimeEnter = ""
            PhotoCaptureTypeEnter = R2CaptureType.None
            CameraTypeEnter = R2CameraType.None
            PhotoEnter = Nothing
            CardNoEnter = ""
            UserIdEnter = 0
            EnterStatus = R2EnterStatus.None
            MblghEnter = 0
            GateEnter = 0
            LPEnter = Nothing
            DateTimeMilladiExit = ""
            DateShamsiExit = ""
            TimeExit = ""
            PhotoCaptureTypeExit = R2CaptureType.None
            CameraTypeExit = R2CameraType.None
            PhotoExit = Nothing
            CardNoExit = ""
            UserIdExit = 0
            ExitStatus = R2ExitStatus.None
            MblghExit = 0
            GateExit = 0
            LPExit = Nothing
            FlagA = False
        End Sub

        Public Sub New(ByVal EnterExitIdd As Int64, ByVal DateTimeMilladiEnterr As DateTime, ByVal DateShamsiEnterr As String, ByVal TimeEnterr As String, ByVal PhotoCaptureTypeEnterr As R2CaptureType, ByVal CameraTypeEnterr As R2CameraType, ByRef PhotoEnterr As Drawing.Image, ByVal CardNoEnterr As String, ByVal UserIdEnterr As Int64, ByVal EnterStatuss As R2EnterStatus, ByVal MblghEnterr As Int64, ByVal GateEnterr As Byte, ByVal LPEnterr As R2StandardLicensePlateStructure, ByVal DateTimeMilladiExitt As DateTime, ByVal DateShamsiExitt As String, ByVal TimeExitt As String, ByVal PhotoCaptureTypeExitt As R2CaptureType, ByVal CameraTypeExitt As R2CameraType, ByRef PhotoExitt As Drawing.Image, ByVal CardNoExitt As String, ByVal UserIdExitt As Int64, ByVal ExitStatuss As R2ExitStatus, ByVal MblghExitt As Int64, ByVal GateExitt As Byte, ByVal LPExitt As R2StandardLicensePlateStructure, ByVal FlagAA As Boolean)
            EnterExitId = EnterExitIdd
            DateTimeMilladiEnter = DateTimeMilladiEnterr
            DateShamsiEnter = DateShamsiEnterr
            TimeEnter = TimeEnterr
            PhotoCaptureTypeEnter = PhotoCaptureTypeEnterr
            CameraTypeEnter = CameraTypeEnterr
            PhotoEnter = PhotoEnterr
            CardNoEnter = CardNoEnterr
            UserIdEnter = UserIdEnterr
            EnterStatus = EnterStatuss
            MblghEnter = MblghEnterr
            GateEnter = GateEnterr
            LPEnter = LPEnterr
            DateTimeMilladiExit = DateTimeMilladiExitt
            DateShamsiExit = DateShamsiExitt
            TimeExit = TimeExitt
            PhotoCaptureTypeExit = PhotoCaptureTypeExitt
            CameraTypeExit = CameraTypeExitt
            PhotoExit = PhotoExitt
            CardNoExit = CardNoExitt
            UserIdExit = UserIdExitt
            ExitStatus = ExitStatuss
            MblghExit = MblghExitt
            GateExit = GateExitt
            LPExit = LPExitt
            FlagA = FlagAA
        End Sub

        Public Property EnterExitId As Int64

        Public Property DateTimeMilladiEnter As DateTime

        Public Property DateShamsiEnter As String

        Public Property TimeEnter As String

        Public Property PhotoCaptureTypeEnter As R2CaptureType

        Public Property CameraTypeEnter As R2CameraType

        Public Property PhotoEnter As Image

        Public Property CardNoEnter As String

        Public Property UserIdEnter As Byte

        Public Property EnterStatus As R2EnterStatus

        Public Property MblghEnter As Int64

        Public Property GateEnter As Byte

        Public Property LPEnter As R2StandardLicensePlateStructure

        Public Property DateTimeMilladiExit As DateTime

        Public Property DateShamsiExit As String

        Public Property TimeExit As String

        Public Property PhotoCaptureTypeExit As R2CaptureType

        Public Property CameraTypeExit As R2CameraType

        Public Property PhotoExit As Image

        Public Property CardNoExit As String

        Public Property UserIdExit As Byte

        Public Property ExitStatus As R2ExitStatus

        Public Property MblghExit As Int64

        Public Property GateExit As Byte

        Public Property LPExit As R2StandardLicensePlateStructure

        Public Property FlagA As Boolean
    End Class

    Public Class R2StandardEnterExitExtendedStructure
        Inherits R2StandardEnterExitStructure

        Public Sub New()
            MyBase.New
            _GateEnterName = String.Empty
            _UserNameEnter = String.Empty
            _GateExitName = String.Empty
            _UserNameExit = String.Empty
        End Sub

        Public Sub New(YourNSS As R2StandardEnterExitStructure, YourGateEnterName As String, YourUserNameEnter As String, YourGateExitName As String, YourUserNameExit As String)
            MyBase.New(YourNSS.EnterExitId, YourNSS.DateTimeMilladiEnter, YourNSS.DateShamsiEnter, YourNSS.TimeEnter, YourNSS.PhotoCaptureTypeEnter, YourNSS.CameraTypeEnter, YourNSS.PhotoEnter, YourNSS.CardNoEnter, YourNSS.UserIdEnter, YourNSS.EnterStatus, YourNSS.MblghEnter, YourNSS.GateEnter, YourNSS.LPEnter, YourNSS.DateTimeMilladiExit, YourNSS.DateShamsiExit, YourNSS.TimeExit, YourNSS.PhotoCaptureTypeExit, YourNSS.CameraTypeExit, YourNSS.PhotoExit, YourNSS.CardNoExit, YourNSS.UserIdExit, YourNSS.ExitStatus, YourNSS.MblghExit, YourNSS.GateExit, YourNSS.LPExit, YourNSS.FlagA)
            _GateEnterName = YourGateEnterName
            _UserNameEnter = YourUserNameEnter
            _GateExitName = YourGateExitName
            _UserNameExit = YourUserNameExit
        End Sub

        Public Property GateEnterName() As String
        Public Property UserNameEnter() As String
        Public Property GateExitName() As String
        Public Property UserNameExit() As String

    End Class

    Public Class R2CoreParkingSystemMClassEnterExitManagement

        Private Shared _DateTime As DateAndTimeManagement.R2DateTime = New DateAndTimeManagement.R2DateTime
        Public Shared Function GetLPFromLPR(ByRef YourCarImage As Bitmap, ByRef YourReport As String, ByRef LicensePlateBlob As AForge.Imaging.Blob) As R2StandardLicensePlateStructure
            Try
                Dim myLP As R2StandardLicensePlateStructure = Nothing
                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.LPRIsActive, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 0) = True Then
                    If YourCarImage IsNot Nothing Then
                        Dim _LPR = New R2CoreLicensePlateRecognizer
                        myLP = _LPR.LicensePlateRecognitionProccess(YourCarImage, YourReport, LicensePlateBlob)
                    End If
                End If
                Return myLP
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function InsertEnterExit(ByVal EnterExitStruct As R2StandardEnterExitStructure) As UInt64
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "select top 1 enterexitid from R2PrimaryParkingSystem.dbo.TblEntryExit order by enterexitid desc"
                Dim myEnterExitId As Int64 = CmdSql.ExecuteScalar + 1
                CmdSql.Parameters.AddWithValue("@EnterExitId", myEnterExitId)
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiEnter", EnterExitStruct.DateTimeMilladiEnter)
                CmdSql.Parameters.AddWithValue("@DateShamsiEnter", EnterExitStruct.DateShamsiEnter)
                CmdSql.Parameters.AddWithValue("@TimeEnter", EnterExitStruct.TimeEnter)
                CmdSql.Parameters.AddWithValue("@PhotoCaptureTypeEnter", EnterExitStruct.PhotoCaptureTypeEnter)
                CmdSql.Parameters.AddWithValue("@CameraTypeEnter", EnterExitStruct.CameraTypeEnter)
                CmdSql.Parameters.AddWithValue("@CardNoEnter", EnterExitStruct.CardNoEnter)
                CmdSql.Parameters.AddWithValue("@UserIdEnter", EnterExitStruct.UserIdEnter)
                CmdSql.Parameters.AddWithValue("@EnterStatus", EnterExitStruct.EnterStatus)
                CmdSql.Parameters.AddWithValue("@MblghEnter", EnterExitStruct.MblghEnter)
                CmdSql.Parameters.AddWithValue("@GateEnter", EnterExitStruct.GateEnter)
                CmdSql.Parameters.AddWithValue("@PelakEnter", EnterExitStruct.LPEnter.Pelak)
                CmdSql.Parameters.AddWithValue("@SerialEnter", EnterExitStruct.LPEnter.Serial)
                CmdSql.Parameters.AddWithValue("@CityEnter", EnterExitStruct.LPEnter.City)
                CmdSql.Parameters.AddWithValue("@PelakTypeEnter", 0)
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiExit", EnterExitStruct.DateTimeMilladiExit)
                CmdSql.Parameters.AddWithValue("@DateShamsiExit", EnterExitStruct.DateShamsiExit)
                CmdSql.Parameters.AddWithValue("@TimeExit", EnterExitStruct.TimeExit)
                CmdSql.Parameters.AddWithValue("@PhotoCaptureTypeExit", EnterExitStruct.PhotoCaptureTypeExit)
                CmdSql.Parameters.AddWithValue("@CameraTypeExit", EnterExitStruct.CameraTypeExit)
                CmdSql.Parameters.AddWithValue("@CardNoExit", EnterExitStruct.CardNoExit)
                CmdSql.Parameters.AddWithValue("@UserIdExit", EnterExitStruct.UserIdExit)
                CmdSql.Parameters.AddWithValue("@ExitStatus", EnterExitStruct.ExitStatus)
                CmdSql.Parameters.AddWithValue("@MblghExit", EnterExitStruct.MblghExit)
                CmdSql.Parameters.AddWithValue("@GateExit", EnterExitStruct.GateExit)
                CmdSql.Parameters.AddWithValue("@PelakExit", EnterExitStruct.LPExit.Pelak)
                CmdSql.Parameters.AddWithValue("@SerialExit", EnterExitStruct.LPExit.Serial)
                CmdSql.Parameters.AddWithValue("@CityExit", EnterExitStruct.LPExit.City)
                CmdSql.Parameters.AddWithValue("@PelakTypeExit", 0)
                CmdSql.Parameters.AddWithValue("@FlagA", EnterExitStruct.FlagA)
                CmdSql.CommandText = "insert into R2PrimaryParkingSystem.dbo.TblEntryExit values(@EnterExitId,@DateTimeMilladiEnter,@DateShamsiEnter,@TimeEnter,@PhotoCaptureTypeEnter,@CameraTypeEnter,@CardNoEnter,@UserIdEnter,@EnterStatus,@MblghEnter,@GateEnter,@PelakEnter,@SerialEnter,@CityEnter,@PelakTypeEnter,@DateTimeMilladiExit,@DateShamsiExit,@TimeExit,@PhotoCaptureTypeExit,@CameraTypeExit,@CardNoExit,@UserIdExit,@ExitStatus,@MblghExit,@GateExit,@PelakExit,@SerialExit,@CityExit,@PelakTypeExit,@FlagA)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Return myEnterExitId
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UpdateForExit(ByVal EnterExitStruct As R2StandardEnterExitStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiExit", EnterExitStruct.DateTimeMilladiExit)
                CmdSql.Parameters.AddWithValue("@DateShamsiExit", EnterExitStruct.DateShamsiExit)
                CmdSql.Parameters.AddWithValue("@TimeExit", EnterExitStruct.TimeExit)
                CmdSql.Parameters.AddWithValue("@PhotoCaptureTypeExit", EnterExitStruct.PhotoCaptureTypeExit)
                CmdSql.Parameters.AddWithValue("@CameraTypeExit", EnterExitStruct.CameraTypeExit)
                CmdSql.Parameters.AddWithValue("@CardNoExit", EnterExitStruct.CardNoExit)
                CmdSql.Parameters.AddWithValue("@UserIdExit", EnterExitStruct.UserIdExit)
                CmdSql.Parameters.AddWithValue("@ExitStatus", EnterExitStruct.ExitStatus)
                CmdSql.Parameters.AddWithValue("@MblghExit", EnterExitStruct.MblghExit)
                CmdSql.Parameters.AddWithValue("@GateExit", EnterExitStruct.GateExit)
                CmdSql.Parameters.AddWithValue("@PelakExit", EnterExitStruct.LPExit.Pelak)
                CmdSql.Parameters.AddWithValue("@SerialExit", EnterExitStruct.LPExit.Serial)
                CmdSql.Parameters.AddWithValue("@PelakTypeExit", EnterExitStruct.LPExit.PelakType)
                CmdSql.Parameters.AddWithValue("@FlagA", EnterExitStruct.FlagA)
                CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblEntryExit set DateTimeMilladiExit=@DateTimeMilladiExit,DateShamsiExit=@DateShamsiExit,TimeExit=@TimeExit,PhotoCaptureTypeExit=@PhotoCaptureTypeExit,CameraTypeExit=@CameraTypeExit,CardNoExit=@CardNoExit,UserIdExit=@UserIdExit,ExitStatus=@ExitStatus,MblghExit=@MblghExit,GateExit=@GateExit,PelakExit=@PelakExit,SerialExit=@SerialExit,PelakTypeExit=@PelakTypeExit,FlagA=1 where EnterExitId=" & EnterExitStruct.EnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Shared Function GetEnterExitRequestType(ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByRef EnterExitId As Int64) As R2EnterExitRequestType
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim ds As New DataSet
                Da.SelectCommand = New SqlCommand("select top 1 flaga,EnterExitId from R2PrimaryParkingSystem.dbo.TblEntryExit where (ltrim(rtrim(cardnoenter))='" & YourTrafficCard.CardNo & "') or (ltrim(rtrim(cardnoexit))='" & YourTrafficCard.CardNo & "') order by DateTimeMilladiEnter desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                ds.Tables.Clear()
                If Da.Fill(ds) = 0 Then Return R2EnterExitRequestType.EnterRequest
                If ds.Tables(0).Rows(0).Item("flaga") = True Then
                    Return R2EnterExitRequestType.EnterRequest
                Else
                    EnterExitId = ds.Tables(0).Rows(0).Item("EnterExitId")
                    Return R2EnterExitRequestType.ExitRequest
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetEnterExitTavaghof(YourDateInterval As DateInterval, ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (MblghA<>0) and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                Else
                    If YourDateInterval = DateInterval.Hour Then
                        Return DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                    ElseIf YourDateInterval = DateInterval.Minute Then
                        Return DateDiff(DateInterval.Minute, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                    ElseIf YourDateInterval = DateInterval.Day Then
                        Return DateDiff(DateInterval.Day, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                    End If
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetEnterExitMblgh(ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByVal EnterExitRequestType As R2EnterExitRequestType, ByRef Tavaghof As Int64) As Int64
            Try
                'تعیین نوع کارت از نظر موقتی و دایمی
                If YourTrafficCard.TempCardType = TerafficTempCardType.Temp Then
                    Return GetEnterExitMblghTempTerraficCard(YourTrafficCard, EnterExitRequestType, Tavaghof)
                ElseIf YourTrafficCard.TempCardType = TerafficTempCardType.None Then
                    Throw New TerafficCardTempCardTypeException
                End If

                'کارت های دائمی
                'مبلغ پایه و تاخیر بر اساس نوع کارت تردد
                Dim myMblghPayeh, myMblgDelay As Int64
                If YourTrafficCard.CardType = TerafficCardType.Savari Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 0)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 0)
                ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 2)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 2)
                ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 1)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 1)
                ElseIf YourTrafficCard.CardType = TerafficCardType.Tereili Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 3)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 3)
                End If

                'کارتهای با تردد آزاد
                If YourTrafficCard.NoMoney = True Then Return 0

                'احراز معیار محاسبه بر اساس نوع کارت
                Dim Ds As New DataSet
                If YourTrafficCard.CardType = TerafficCardType.Savari Then
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (MblghA<>0) and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount = 0 Then
                        Return myMblghPayeh
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (MblghA<>0) and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount = 0 Then
                        Return myMblghPayeh
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (MblghA<>0) and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount = 0 Then
                        Return myMblghPayeh
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.Tereili Then
                    If EnterExitRequestType = R2EnterExitRequestType.EnterRequest Then
                        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (MblghA<>0) and ((EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") Or (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SherkatHazinehNobat & ")) order by DateMilladiA desc", 1, Ds).GetRecordsCount = 0 Then
                            Return myMblghPayeh
                        End If
                    ElseIf EnterExitRequestType = R2EnterExitRequestType.ExitRequest Then
                        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (MblghA<>0) and ((EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") Or (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SherkatHazinehNobat & ")) order by DateMilladiA desc", 1, Ds).GetRecordsCount = 0 Then
                            Return myMblghPayeh
                        End If
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.None Then
                    Throw New Exception("استفاده از این کارت  ممنوع است" + vbCrLf + "نوع  کارت تردد نامشخص است")
                End If
                Tavaghof = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                'محاسبه هزینه نهایی
                If EnterExitRequestType = R2EnterExitRequestType.EnterRequest Then
                    If YourTrafficCard.CardType = TerafficCardType.Savari Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4) Then Return myMblghPayeh
                    ElseIf YourTrafficCard.CardType = TerafficCardType.Tereili Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1) Then Return myMblghPayeh
                    ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5) Then Return myMblghPayeh
                    ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6) Then Return myMblghPayeh
                    End If
                ElseIf EnterExitRequestType = R2EnterExitRequestType.ExitRequest Then
                    If YourTrafficCard.CardType = TerafficCardType.Savari Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    ElseIf YourTrafficCard.CardType = TerafficCardType.Tereili Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    End If
                ElseIf EnterExitRequestType = R2EnterExitRequestType.None Then
                    Throw New Exception("خطای اساسی - نوع تردد درخواستی از متد محاسبه هزینه تردد نادرست است")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Function GetEnterExitMblghTempTerraficCard(ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByVal EnterExitRequestType As R2EnterExitRequestType, ByRef Tavaghof As Int16) As Int64
            Try
                'مبلغ پایه و تاخیر بر اساس نوع کارت تردد
                Dim myMblghPayeh, myMblgDelay As Int64
                If YourTrafficCard.CardType = TerafficCardType.Savari Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 4)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 4)
                ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 6)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 6)
                ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 5)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 5)
                ElseIf YourTrafficCard.CardType = TerafficCardType.Tereili Then
                    myMblghPayeh = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 7)
                    myMblgDelay = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 7)
                End If

                If EnterExitRequestType = R2EnterExitRequestType.EnterRequest Then
                    Return myMblghPayeh
                ElseIf EnterExitRequestType = R2EnterExitRequestType.ExitRequest Then
                    Dim Ds As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (ltrim(rtrim(CardId))=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & ") order by DateMilladiA desc", 1, Ds)
                    Tavaghof = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())

                    If YourTrafficCard.CardType = TerafficCardType.Savari Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    ElseIf YourTrafficCard.CardType = TerafficCardType.Tereili Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                        If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6) Then
                            Return (((Tavaghof - R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6)) \ R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)) + 1) * myMblgDelay
                        Else
                            Return 0
                        End If
                    End If
                ElseIf EnterExitRequestType = R2EnterExitRequestType.None Then
                    Throw New Exception("خطای اساسی - نوع تردد درخواستی از متد محاسبه هزینه تردد نادرست است")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub OpenGate(ByVal EnterExitRequest As R2EnterExitRequestType)
        End Sub

        Public Shared Function GetEnterExitStatusName(ByVal YourEnterExitStatus As Integer, ByVal YourEERequest As R2EnterExitRequestType) As String
            If YourEERequest = R2EnterExitRequestType.EnterRequest Then
                Select Case YourEnterExitStatus
                    Case 0 : Return "نامعلوم"
                    Case 1 : Return "کارت تردد کشیده نشده"
                    Case 2 : Return "لیست سیاه"
                    Case 3 : Return "ورودآزاد"
                    Case 4 : Return "تردد عادی"
                End Select
            ElseIf YourEERequest = R2EnterExitRequestType.ExitRequest Then
                Select Case YourEnterExitStatus
                    Case 0 : Return "نامعلوم"
                    Case 1 : Return "خروج آزاد"
                    Case 2 : Return "لیست سیاه"
                    Case 3 : Return "کارت تردد کشیده نشده"
                    Case 4 : Return "تردد عادی"
                End Select
            End If
        End Function

        Public Shared Function GetEnterExitRequestTypeName(ByVal YourEnterExitRequestType As R2EnterExitRequestType) As String
            If YourEnterExitRequestType = R2EnterExitRequestType.EnterRequest Then
                Return "ورود"
            ElseIf YourEnterExitRequestType = R2EnterExitRequestType.ExitRequest Then
                Return "خروج"
            End If
        End Function

        Public Shared Function GetCarLastEnterExitId(YourTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("select Top 1 EnterExitId from R2PrimaryParkingSystem.dbo.TblEntryExit where (ltrim(rtrim(cardnoenter))='" & YourTerafficCard.CardNo & "') order by DateTimeMilladiEnter desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Throw New CarHasNoEnterExitRecordException
                Return Ds.Tables(0).Rows(0).Item("EnterExitId")
            Catch ex As CarHasNoEnterExitRecordException
                Throw ex
            Catch ex As Exception
                Throw New Exception("R2ParkingSystem.EnterExit.R2MClassEnterExit.GetCarCapturedImageEnter()." + ex.Message.ToString)
            End Try
        End Function

        Public Shared Function GetLPfromEnterExit(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As R2StandardLicensePlateStructure
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryParkingSystem.dbo.TblEntryExit where (CardNoEnter='" & YourTrafficCard.CardNo & "') order by DateTimeMilladiEnter desc", 1, DS).GetRecordsCount = 0 Then
                    Return Nothing
                Else
                    Return New R2StandardLicensePlateStructure(DS.Tables(0).Rows(0).Item("PelakEnter"), DS.Tables(0).Rows(0).Item("SerialEnter"), DS.Tables(0).Rows(0).Item("CityEnter"), DS.Tables(0).Rows(0).Item("PelakTypeEnter"))
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsTrafficCardEnterExitStatusWithMaabarMatch(YourEnterExitRequest As R2EnterExitRequestType, YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
            Try
                Dim Compos As String = (0 + YourTrafficCard.CardType).ToString() + (0 + YourEnterExitRequest).ToString
                Dim A As String() = Split(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.TrafficCardEERequestStatusWithMaabarMatch, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0), "-")
                If A.Contains(Compos) = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLastTrafficCardWhichNotExited(YourLP As R2StandardLicensePlateStructure, ByRef YourEnterExitId As Int64) As R2CoreParkingSystemStandardTrafficCardStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 EnterExitId,CardNoEnter from R2PrimaryParkingSystem.dbo.TblEntryExit Where FlagA=0 and PelakEnter='" & YourLP.Pelak & "' and SerialEnter='" & YourLP.Serial & "' and CityEnter='" & YourLP.City & "' Order By EnterExitId Desc", 1, Ds).GetRecordsCount() = 0 Then
                    Return Nothing
                End If
                YourEnterExitId = Ds.Tables(0).Rows(0).Item("EnterExitId")
                Return R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(Ds.Tables(0).Rows(0).Item("CardNoEnter").ToString())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetEnterExitIdforTerafficCardWhichNotExited(YourTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 EnterExitId from R2PrimaryParkingSystem.dbo.TblEntryExit Where FlagA=0 and  CardNoEnter='" & YourTerafficCard.CardNo & "' Order By EnterExitId Desc", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New TerafficCardLastExitedException
                End If
                Return Ds.Tables(0).Rows(0).Item("EnterExitId")
            Catch exx As TerafficCardLastExitedException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ExitTempTerafficCard(YourTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourMblgh As Int64, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                If YourMblgh <= R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(YourTerafficCard) Then
                    Dim LastEnterExitId As Int64
                    LastEnterExitId = R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitIdforTerafficCardWhichNotExited(YourTerafficCard)
                    R2CoreParkingSystemMClassEnterExitManagement.UpdateForExit(New R2StandardEnterExitStructure(LastEnterExitId, _DateTime.GetCurrentDateTimeMilladiFormated(), "", "", R2CaptureType.None, R2CameraType.None, Nothing, "", 0, R2EnterStatus.None, 0, 0, Nothing, _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, R2CaptureType.None, R2CameraType.None, Nothing, YourTerafficCard.CardNo, YourUserNSS.UserId, R2ExitStatus.NotUserPullCard, YourMblgh, R2CoreMClassConfigurationManagement.GetComputerCode, New R2StandardLicensePlateStructure(), True))
                    R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(YourTerafficCard, BagPayType.MinusMoney, YourMblgh, R2CoreParkingSystemAccountings.ExitTemp, YourUserNSS)
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "خروج موقت کارت تردد انجام گرفت", YourTerafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Else
                    Throw New MoneyWalletCurrentChargeNotEnoughException
                End If
            Catch exxx As TerafficCardLastExitedException
                Throw exxx
            Catch exx As MoneyWalletCurrentChargeNotEnoughException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared RegisteringHandyBillsFixedCardNo As String = "94A36342"
        Private Shared RegisteringHandyBillsFixedTime As String = "08:00:00"
        Public Shared Sub RegisteringHandyBills(YourTeadad As Int64, YourShamsiDate As R2StandardDateAndTimeStructure, YourTerafficCardType As TerafficCardType, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim myMblgh As Int64 = Microsoft.VisualBasic.Switch(YourTerafficCardType = TerafficCardType.Savari, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 0), YourTerafficCardType = TerafficCardType.SixCharkh, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 2), YourTerafficCardType = TerafficCardType.TenCharkh, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 1), YourTerafficCardType = TerafficCardType.Tereili, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 3))
                For Loopx As Int64 = 0 To YourTeadad - 1
                    R2CoreParkingSystemMClassAccountingManagement.InsertAccounting(New R2StandardEnterExitAccountingStructure(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(RegisteringHandyBillsFixedCardNo), R2CoreParkingSystemAccountings.RegisteringHandyBills, YourShamsiDate.DateShamsiFull, RegisteringHandyBillsFixedTime, _DateTime.GetMilladiDateTimeFromDateShamsiFull(YourShamsiDate.DateShamsiFull, RegisteringHandyBillsFixedTime), Nothing, R2CoreMClassConfigurationManagement.GetComputerCode(), myMblgh, YourUserNSS.UserId, 0, 0))
                Next
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeleteRegisteredHandyBills(YourShamsiDate As R2StandardDateAndTimeStructure, YourTerafficCardType As TerafficCardType)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Dim myMblgh As Int64 = Microsoft.VisualBasic.Switch(YourTerafficCardType = TerafficCardType.Savari, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 0), YourTerafficCardType = TerafficCardType.SixCharkh, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 2), YourTerafficCardType = TerafficCardType.TenCharkh, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 1), YourTerafficCardType = TerafficCardType.Tereili, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 3))
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Delete R2Primary.dbo.TblAccounting Where CardId=" & R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(RegisteringHandyBillsFixedCardNo).CardId & " and TimeA='" & RegisteringHandyBillsFixedTime & "' and DateShamsiA='" & YourShamsiDate.DateShamsiFull & "' and MblghA=" & myMblgh & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetTotalRegisteredHandyBills(YourShamsiDate As R2StandardDateAndTimeStructure, YourTerafficCardType As TerafficCardType) As Int64
            Try
                Dim myMblgh As Int64 = Microsoft.VisualBasic.Switch(YourTerafficCardType = TerafficCardType.Savari, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 0), YourTerafficCardType = TerafficCardType.SixCharkh, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 2), YourTerafficCardType = TerafficCardType.TenCharkh, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 1), YourTerafficCardType = TerafficCardType.Tereili, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 3))
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) as CountX from R2Primary.dbo.TblAccounting Where CardId=" & R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(RegisteringHandyBillsFixedCardNo).CardId & " and TimeA='" & RegisteringHandyBillsFixedTime & "' and DateShamsiA='" & YourShamsiDate.DateShamsiFull & "' and MblghA=" & myMblgh & "", 1, Ds).GetRecordsCount() <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("CountX")
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetEnterExitCollection(YourNSSCar As R2StandardCarStructure, YourTotalNumberOfRecordsRequested As Int64) As List(Of R2StandardEnterExitExtendedStructure)
            Try
                Dim Lst As List(Of R2StandardEnterExitExtendedStructure) = New List(Of R2StandardEnterExitExtendedStructure)
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                 "Select Top " & YourTotalNumberOfRecordsRequested & " ComputerEnter.MName as GateEnterName,ComputerExit.MName as GateExitName,SoftwareUserEnter.UserName as UserNameEnter,SoftwareUserExit.UserName as UserNameExit,EnterExit.*  from R2PrimaryParkingSystem.dbo.TblEntryExit as EnterExit
                        Inner Join R2Primary.dbo.TblComputers as ComputerEnter On EnterExit.GateEnter=ComputerEnter.MId
                        Inner Join R2Primary.dbo.TblComputers as ComputerExit On EnterExit.GateExit=ComputerExit.MId
                        Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUserEnter On EnterExit.UserIdEnter=SoftwareUserEnter.UserId
                        Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUserExit On EnterExit.UserIdExit=SoftwareUserExit.UserId
                    Where PelakEnter='" & YourNSSCar.StrCarNo & "' and SerialEnter='" & YourNSSCar.StrCarSerialNo & "' and CityEnter='" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(YourNSSCar.nIdCity) & "' Order By DateTimeMilladiEnter Desc", 1, Ds)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2StandardEnterExitExtendedStructure(New R2StandardEnterExitStructure(Ds.Tables(0).Rows(Loopx).Item("EnterExitId"), Ds.Tables(0).Rows(Loopx).Item("DateTimeMilladiEnter"), Ds.Tables(0).Rows(Loopx).Item("DateShamsiEnter"), Ds.Tables(0).Rows(Loopx).Item("TimeEnter"), R2CaptureType.None, R2CameraType.None, Nothing, Ds.Tables(0).Rows(Loopx).Item("CardNoEnter"), Ds.Tables(0).Rows(Loopx).Item("UserIdEnter"), Ds.Tables(0).Rows(Loopx).Item("EnterStatus"), Ds.Tables(0).Rows(Loopx).Item("MblghEnter"), Ds.Tables(0).Rows(Loopx).Item("GateEnter"), New R2StandardLicensePlateStructure(Ds.Tables(0).Rows(Loopx).Item("PelakEnter"), Ds.Tables(0).Rows(Loopx).Item("SerialEnter"), Ds.Tables(0).Rows(Loopx).Item("CityEnter"), Ds.Tables(0).Rows(Loopx).Item("PelakTypeEnter")), Ds.Tables(0).Rows(Loopx).Item("DateTimeMilladiExit"), Ds.Tables(0).Rows(Loopx).Item("DateShamsiExit"), Ds.Tables(0).Rows(Loopx).Item("TimeExit"), R2CaptureType.None, R2CameraType.None, Nothing, Ds.Tables(0).Rows(Loopx).Item("CardNoExit"), Ds.Tables(0).Rows(Loopx).Item("UserIdExit"), Ds.Tables(0).Rows(Loopx).Item("ExitStatus"), Ds.Tables(0).Rows(Loopx).Item("MblghExit"), Ds.Tables(0).Rows(Loopx).Item("GateExit"), New R2StandardLicensePlateStructure(Ds.Tables(0).Rows(Loopx).Item("PelakExit"), Ds.Tables(0).Rows(Loopx).Item("SerialExit"), Ds.Tables(0).Rows(Loopx).Item("CityExit"), Ds.Tables(0).Rows(Loopx).Item("PelakTypeExit")), Ds.Tables(0).Rows(Loopx).Item("flaga")), Ds.Tables(0).Rows(Loopx).Item("GateEnterName").trim, Ds.Tables(0).Rows(Loopx).Item("UserNameEnter").trim, Ds.Tables(0).Rows(Loopx).Item("GateExitName").trim, Ds.Tables(0).Rows(Loopx).Item("UserNameExit").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetEnterExitCollection(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourTotalNumberOfRecordsRequested As Int64) As List(Of R2StandardEnterExitExtendedStructure)
            Try
                Dim Lst As List(Of R2StandardEnterExitExtendedStructure) = New List(Of R2StandardEnterExitExtendedStructure)
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                                       "Select Top " & YourTotalNumberOfRecordsRequested & " ComputerEnter.MName as GateEnterName,ComputerExit.MName as GateExitName,SoftwareUserEnter.UserName as UserNameEnter,SoftwareUserExit.UserName as UserNameExit,EnterExit.*  from R2PrimaryParkingSystem.dbo.TblEntryExit as EnterExit
                        Inner Join R2Primary.dbo.TblComputers as ComputerEnter On EnterExit.GateEnter=ComputerEnter.MId
                        Inner Join R2Primary.dbo.TblComputers as ComputerExit On EnterExit.GateExit=ComputerExit.MId
                        Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUserEnter On EnterExit.UserIdEnter=SoftwareUserEnter.UserId
                        Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUserExit On EnterExit.UserIdExit=SoftwareUserExit.UserId
                    Where CardNoEnter='" & YourNSSTerafficCard.CardNo & "' Order By DateTimeMilladiEnter Desc", 1, Ds)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2StandardEnterExitExtendedStructure(New R2StandardEnterExitStructure(Ds.Tables(0).Rows(Loopx).Item("EnterExitId"), Ds.Tables(0).Rows(Loopx).Item("DateTimeMilladiEnter"), Ds.Tables(0).Rows(Loopx).Item("DateShamsiEnter"), Ds.Tables(0).Rows(Loopx).Item("TimeEnter"), R2CaptureType.None, R2CameraType.None, Nothing, Ds.Tables(0).Rows(Loopx).Item("CardNoEnter"), Ds.Tables(0).Rows(Loopx).Item("UserIdEnter"), Ds.Tables(0).Rows(Loopx).Item("EnterStatus"), Ds.Tables(0).Rows(Loopx).Item("MblghEnter"), Ds.Tables(0).Rows(Loopx).Item("GateEnter"), New R2StandardLicensePlateStructure(Ds.Tables(0).Rows(Loopx).Item("PelakEnter"), Ds.Tables(0).Rows(Loopx).Item("SerialEnter"), Ds.Tables(0).Rows(Loopx).Item("CityEnter"), Ds.Tables(0).Rows(Loopx).Item("PelakTypeEnter")), Ds.Tables(0).Rows(Loopx).Item("DateTimeMilladiExit"), Ds.Tables(0).Rows(Loopx).Item("DateShamsiExit"), Ds.Tables(0).Rows(Loopx).Item("TimeExit"), R2CaptureType.None, R2CameraType.None, Nothing, Ds.Tables(0).Rows(Loopx).Item("CardNoExit"), Ds.Tables(0).Rows(Loopx).Item("UserIdExit"), Ds.Tables(0).Rows(Loopx).Item("ExitStatus"), Ds.Tables(0).Rows(Loopx).Item("MblghExit"), Ds.Tables(0).Rows(Loopx).Item("GateExit"), New R2StandardLicensePlateStructure(Ds.Tables(0).Rows(Loopx).Item("PelakExit"), Ds.Tables(0).Rows(Loopx).Item("SerialExit"), Ds.Tables(0).Rows(Loopx).Item("CityExit"), Ds.Tables(0).Rows(Loopx).Item("PelakTypeExit")), Ds.Tables(0).Rows(Loopx).Item("flaga")), Ds.Tables(0).Rows(Loopx).Item("GateEnterName").trim, Ds.Tables(0).Rows(Loopx).Item("UserNameEnter").trim, Ds.Tables(0).Rows(Loopx).Item("GateExitName").trim, Ds.Tables(0).Rows(Loopx).Item("UserNameExit").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public Class TerafficCardLastExitedException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "کارت تردد قبلا خروج شده است"
            End Get
        End Property
    End Class

    Public Class CarHasNoEnterExitRecordException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "برای این خودرو تا این لحظه ترددی ثبت نشده است "
            End Get
        End Property
    End Class

    Public Class TerafficCardTempCardTypeException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "نوع کارت تردد نامشخص است - استفاده از کارت مورد نظر ممنوع است"
            End Get
        End Property
    End Class

    Public Class CarIsNotPresentInParkingException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "خودرو در پارکینگ حضور ندارد"
            End Get
        End Property
    End Class

    Public Class TrafficCardMustReadingBySecondRFReaderException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "ورود کارت با کارت خوان دوم امکان پذير نيست"
            End Get
        End Property
    End Class

End Namespace

Namespace TrafficCardsManagement

    Public Enum TerafficCardType
        None = 0 : Savari = 1 : Tereili = 2 : TenCharkh = 3 : SixCharkh = 4
    End Enum

    Public Enum TerafficTempCardType
        None = 0 : NoTemp = 1 : Temp = 2
    End Enum

    Public Class R2CoreParkingSystemStandardTrafficCardStructure
        Inherits R2StandardStructure

        Private myCardId As String
        Private myCardNo As String
        Private myCharge As Int64
        Private myUserIdSabt As Byte
        Private myUserIdEdit As Byte
        Private myPelakType As Byte
        Private myPelak As String
        Private mySerial As String
        Private myNoMoney As Boolean
        Private myActive As Boolean
        Private myCompanyName As String
        Private myNameFamily As String
        Private myMobile As String
        Private myAddress As String
        Private myTel As String
        Private myTahvilg As String
        Private myDateTimeMilladiSabt As DateTime
        Private myDateTimeMilladiEdit As DateTime
        Private myDateShamsiSabt As String
        Private myDateShamsiEdit As String
        Private myCardType As TerafficCardType
        Private myTempCardType As TerafficTempCardType



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            myCardId = "" : myCardNo = "" : myCharge = 0 : myUserIdSabt = 0 : myUserIdEdit = 0 : myPelakType = 0 : myPelak = ""
            mySerial = "" : myNoMoney = False : myActive = False : myCompanyName = "" : myNameFamily = "" : myMobile = ""
            myAddress = "" : myTel = "" : myTahvilg = "" : myDateTimeMilladiSabt = Now : myDateTimeMilladiEdit = Now : myDateShamsiSabt = "" : myDateShamsiEdit = ""
            myCardType = TerafficCardType.None : myTempCardType = TerafficTempCardType.None
        End Sub
        Public Sub New(ByVal CardIdd As String, ByVal CardNoo As String, ByVal Chargee As Int32, ByVal UserIdSabtt As Byte, ByVal UserIdEditt As Byte, ByVal PelakTypee As Byte, ByVal Pelakk As String, ByVal Seriall As String, ByVal NoMoneyy As Boolean, ByVal Activee As Boolean, ByVal CompanyNamee As String, ByVal NameFamilyy As String, ByVal Mobilee As String, ByVal Addresss As String, ByVal Tell As String, ByVal Tahvilgg As String, ByVal DateTimeMilladiSabtt As DateTime, ByVal DateTimeMilladiEditt As DateTime, ByVal DateShamsiSabtt As String, ByVal DateShamsiEditt As String, ByVal CardTypee As TerafficCardType, ByVal TempCardTypee As TerafficTempCardType)
            MyBase.New(CardIdd, CardNoo)
            myCardId = CardIdd
            myCardNo = CardNoo
            myCharge = Chargee
            myUserIdSabt = UserIdSabtt
            myUserIdEdit = UserIdEditt
            myPelakType = PelakTypee
            myPelak = Pelakk
            mySerial = Seriall
            myNoMoney = NoMoneyy
            myActive = Activee
            myCompanyName = CompanyNamee
            myNameFamily = NameFamilyy
            myMobile = Mobilee
            myAddress = Addresss
            myTel = Tell
            myTahvilg = Tahvilgg
            myDateTimeMilladiSabt = DateTimeMilladiSabtt
            myDateTimeMilladiEdit = DateTimeMilladiEditt
            myDateShamsiSabt = DateShamsiSabtt
            myDateShamsiEdit = DateShamsiEditt
            myCardType = CardTypee
            myTempCardType = TempCardTypee
        End Sub
#End Region
#Region "Properting Management"
        Public Property CardId() As String
            Get
                Return myCardId.Trim
            End Get
            Set(ByVal Value As String)
                myCardId = Value
            End Set
        End Property
        Public Property CardNo() As String
            Get
                Return myCardNo.Trim()
            End Get
            Set(ByVal Value As String)
                myCardNo = Value
            End Set
        End Property
        Public Property Charge() As Int32
            Get
                Return myCharge
            End Get
            Set(ByVal Value As Int32)
                myCharge = Value
            End Set
        End Property
        Public Property UserIdSabt() As Byte
            Get
                Return myUserIdSabt
            End Get
            Set(ByVal Value As Byte)
                myUserIdSabt = Value
            End Set
        End Property
        Public Property UserIdEdit() As Byte
            Get
                Return myUserIdEdit
            End Get
            Set(ByVal Value As Byte)
                myUserIdEdit = Value
            End Set
        End Property
        Public Property PelakType() As Byte
            Get
                Return myPelakType
            End Get
            Set(ByVal Value As Byte)
                myPelakType = Value
            End Set
        End Property
        Public Property Pelak() As String
            Get
                Return myPelak.Trim()
            End Get
            Set(ByVal Value As String)
                myPelak = Value
            End Set
        End Property
        Public Property Serial() As String
            Get
                Return mySerial.Trim()
            End Get
            Set(ByVal Value As String)
                mySerial = Value
            End Set
        End Property
        Public Property NoMoney() As Boolean
            Get
                Return myNoMoney
            End Get
            Set(ByVal Value As Boolean)
                myNoMoney = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return myActive
            End Get
            Set(ByVal Value As Boolean)
                myActive = Value
            End Set
        End Property
        Public Property CompanyName() As String
            Get
                Return myCompanyName.Trim()
            End Get
            Set(ByVal Value As String)
                myCompanyName = Value
            End Set
        End Property
        Public Property NameFamily() As String
            Get
                Return myNameFamily.Trim()
            End Get
            Set(ByVal Value As String)
                myNameFamily = Value
            End Set
        End Property
        Public Property Mobile() As String
            Get
                Return myMobile.Trim()
            End Get
            Set(ByVal Value As String)
                myMobile = Value
            End Set
        End Property
        Public Property Address() As String
            Get
                Return myAddress.Trim()
            End Get
            Set(ByVal Value As String)
                myAddress = Value
            End Set
        End Property
        Public Property Tel() As String
            Get
                Return myTel.Trim()
            End Get
            Set(ByVal Value As String)
                myTel = Value
            End Set
        End Property
        Public Property Tahvilg() As String
            Get
                Return myTahvilg.Trim()
            End Get
            Set(ByVal Value As String)
                myTahvilg = Value
            End Set
        End Property
        Public Property DateTimeMilladiSabt() As DateTime
            Get
                Return myDateTimeMilladiSabt
            End Get
            Set(ByVal Value As DateTime)
                myDateTimeMilladiSabt = Value
            End Set
        End Property
        Public Property DateTimeMilladiEdit() As DateTime
            Get
                Return myDateTimeMilladiEdit
            End Get
            Set(ByVal Value As DateTime)
                myDateTimeMilladiEdit = Value
            End Set
        End Property
        Public Property DateShamsiSabt() As String
            Get
                Return myDateShamsiSabt.Trim()
            End Get
            Set(ByVal Value As String)
                myDateShamsiSabt = Value
            End Set
        End Property
        Public Property DateShamsiEdit() As String
            Get
                Return myDateShamsiEdit.Trim()
            End Get
            Set(ByVal Value As String)
                myDateShamsiEdit = Value
            End Set
        End Property
        Public Property CardType As TerafficCardType
            Get
                Return myCardType
            End Get
            Set(ByVal value As TerafficCardType)
                myCardType = value
            End Set
        End Property
        Public Property TempCardType As TerafficTempCardType
            Get
                Return myTempCardType
            End Get
            Set(ByVal value As TerafficTempCardType)
                myTempCardType = value
            End Set
        End Property
#End Region


    End Class

    Public Class R2CoreParkingSystemInstanceTrafficCardsManager
        Private ReadOnly _DateTime As R2DateTime = New R2DateTime()

        Public Function GetNSSTrafficCard(ByVal YourCardId As Int64) As R2CoreParkingSystemStandardTrafficCardStructure
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblRFIDCards Where CardId=" & YourCardId & "", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New TerraficCardNotFoundException
                Else
                    Return New R2CoreParkingSystemStandardTrafficCardStructure(Ds.Tables(0).Rows(0).Item("CardId"), Ds.Tables(0).Rows(0).Item("CardNo"), Ds.Tables(0).Rows(0).Item("Charge"), Ds.Tables(0).Rows(0).Item("UserIdSabt"), Ds.Tables(0).Rows(0).Item("UserIdEdit"), Ds.Tables(0).Rows(0).Item("PelakType"), Ds.Tables(0).Rows(0).Item("Pelak"), Ds.Tables(0).Rows(0).Item("Serial"), Ds.Tables(0).Rows(0).Item("NoMoney"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("CompanyName"), Ds.Tables(0).Rows(0).Item("NameFamily"), Ds.Tables(0).Rows(0).Item("Mobile"), Ds.Tables(0).Rows(0).Item("Address"), Ds.Tables(0).Rows(0).Item("Tel"), Ds.Tables(0).Rows(0).Item("Tahvilg"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiSabt"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiEdit"), Ds.Tables(0).Rows(0).Item("DateShamsiSabt"), Ds.Tables(0).Rows(0).Item("DateShamsiEdit"), Ds.Tables(0).Rows(0).Item("CardType"), Ds.Tables(0).Rows(0).Item("TempCardType"))
                End If
            Catch exx As TerraficCardNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTrafficCard(ByVal YourCardNo As String) As R2CoreParkingSystemStandardTrafficCardStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblRFIDCards Where Cardno='" & YourCardNo & "' Order By ltrim(rtrim(CardId)) Desc", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New TerraficCardNotFoundException
                Else
                    Return New R2CoreParkingSystemStandardTrafficCardStructure(Ds.Tables(0).Rows(0).Item("CardId"), Ds.Tables(0).Rows(0).Item("CardNo"), Ds.Tables(0).Rows(0).Item("Charge"), Ds.Tables(0).Rows(0).Item("UserIdSabt"), Ds.Tables(0).Rows(0).Item("UserIdEdit"), Ds.Tables(0).Rows(0).Item("PelakType"), Ds.Tables(0).Rows(0).Item("Pelak"), Ds.Tables(0).Rows(0).Item("Serial"), Ds.Tables(0).Rows(0).Item("NoMoney"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("CompanyName"), Ds.Tables(0).Rows(0).Item("NameFamily"), Ds.Tables(0).Rows(0).Item("Mobile"), Ds.Tables(0).Rows(0).Item("Address"), Ds.Tables(0).Rows(0).Item("Tel"), Ds.Tables(0).Rows(0).Item("Tahvilg"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiSabt"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiEdit"), Ds.Tables(0).Rows(0).Item("DateShamsiSabt"), Ds.Tables(0).Rows(0).Item("DateShamsiEdit"), Ds.Tables(0).Rows(0).Item("CardType"), Ds.Tables(0).Rows(0).Item("TempCardType"))
                End If
            Catch ex As TerraficCardNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub UpdatingTrafficCard(ByVal YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourEditLevel As R2Enums.EditLevel)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Cmdsql.Connection.Open()
                If YourEditLevel = R2Enums.EditLevel.LowLevel Then
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards Set UserIdEdit=" & YourNSSTerafficCard.UserIdEdit & ",Pelak='" & YourNSSTerafficCard.Pelak & "',Serial='" & YourNSSTerafficCard.Serial & "',CompanyName='" & YourNSSTerafficCard.CompanyName & "',NameFamily='" & YourNSSTerafficCard.NameFamily & "',Mobile='" & YourNSSTerafficCard.Mobile & "',Address='" & YourNSSTerafficCard.Address & "',Tel='" & YourNSSTerafficCard.Tel & "',Tahvilg='" & YourNSSTerafficCard.Tahvilg & "',CardType=" & YourNSSTerafficCard.CardType & ",TempCardType=" & YourNSSTerafficCard.TempCardType & ",DateTimeMilladiEdit='" & _DateTime.GetCurrentDateTimeMilladiFormated() & "',DateShamsiEdit='" & _DateTime.GetCurrentDateShamsiFull() & "' Where CardNo='" & YourNSSTerafficCard.CardNo & "'"
                ElseIf YourEditLevel = R2Enums.EditLevel.HighLevel Then
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards Set UserIdEdit=" & YourNSSTerafficCard.UserIdEdit & ",Pelak='" & YourNSSTerafficCard.Pelak & "',Serial='" & YourNSSTerafficCard.Serial & "',NoMoney=" & IIf(YourNSSTerafficCard.NoMoney = True, 1, 0) & ",Active=" & IIf(YourNSSTerafficCard.Active = True, 1, 0) & ",CompanyName='" & YourNSSTerafficCard.CompanyName & "',NameFamily='" & YourNSSTerafficCard.NameFamily & "',Mobile='" & YourNSSTerafficCard.Mobile & "',Address='" & YourNSSTerafficCard.Address & "',Tel='" & YourNSSTerafficCard.Tel & "',Tahvilg='" & YourNSSTerafficCard.Tahvilg & "',CardType=" & YourNSSTerafficCard.CardType & ",TempCardType=" & YourNSSTerafficCard.TempCardType & ",DateTimeMilladiEdit='" & _DateTime.GetCurrentDateTimeMilladiFormated() & "',DateShamsiEdit='" & _DateTime.GetCurrentDateShamsiFull() & "' Where CardNo='" & YourNSSTerafficCard.CardNo & "'"
                End If
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

    Public Class R2CoreParkingSystemMClassTrafficCardManagement
        Private Shared ReadOnly _DateTime As R2DateTime = New R2DateTime()

        Public Shared Function IsTerafficCardNoConfirm(ByVal CardNo As String) As Boolean
            Try
                GetNSSTrafficCard(CardNo)
                Return True
            Catch exx As GetNSSException
                Return False
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Sub TrafficCardSabt(ByRef TrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "insert into R2Primary.dbo.tblrfidcards(CardId,CardNo,Charge,UseriDSabt,UserIdEdit,PelakType,Pelak,Serial,NoMoney,Active,CompanyName,NameFamily,Mobile,Address,Tel,Tahvilg,DateTimeMilladiSabt,DateTimeMilladiEdit,DateShamsiSabt,DateShamsiEdit,CardType,TempCardType) values('" & TrafficCard.CardId & "','" & TrafficCard.CardNo & "'," & TrafficCard.Charge & "," & TrafficCard.UserIdSabt & "," & TrafficCard.UserIdEdit & "," & TrafficCard.PelakType & ",'" & TrafficCard.Pelak & "','" & TrafficCard.Serial & "'," & IIf(TrafficCard.NoMoney = True, 1, 0) & "," & IIf(TrafficCard.Active = True, 1, 0) & ",'" & TrafficCard.CompanyName & "','" & TrafficCard.NameFamily & "','" & TrafficCard.Mobile & "','" & TrafficCard.Address & "','" & TrafficCard.Tel & "','" & TrafficCard.Tahvilg & "','" & TrafficCard.DateTimeMilladiSabt.ToString("yyyy-MM-dd HH:mm:ss") & "','" & TrafficCard.DateTimeMilladiEdit.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & TrafficCard.DateShamsiSabt & "','" & TrafficCard.DateShamsiEdit & "'," & TrafficCard.CardType & "," & TrafficCard.TempCardType & ")"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
        Public Shared Sub UpdateTrafficCardType(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblRfidCards Set CardType=" & YourNSSTerafficCard.CardType & ",TempCardType=" & YourNSSTerafficCard.TempCardType & " Where CardNo='" & YourNSSTerafficCard.CardNo & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
        Public Shared Sub TerafficCardEdit(ByVal YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourEditLevel As R2Enums.EditLevel)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Cmdsql.Connection.Open()
                If YourEditLevel = R2Enums.EditLevel.LowLevel Then
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards Set UserIdEdit=" & YourNSSTerafficCard.UserIdEdit & ",Pelak='" & YourNSSTerafficCard.Pelak & "',Serial='" & YourNSSTerafficCard.Serial & "',CompanyName='" & YourNSSTerafficCard.CompanyName & "',NameFamily='" & YourNSSTerafficCard.NameFamily & "',Mobile='" & YourNSSTerafficCard.Mobile & "',Address='" & YourNSSTerafficCard.Address & "',Tel='" & YourNSSTerafficCard.Tel & "',Tahvilg='" & YourNSSTerafficCard.Tahvilg & "',CardType=" & YourNSSTerafficCard.CardType & ",TempCardType=" & YourNSSTerafficCard.TempCardType & ",DateTimeMilladiEdit='" & _DateTime.GetCurrentDateTimeMilladiFormated() & "',DateShamsiEdit='" & _DateTime.GetCurrentDateShamsiFull() & "' Where CardNo='" & YourNSSTerafficCard.CardNo & "'"
                ElseIf YourEditLevel = R2Enums.EditLevel.HighLevel Then
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards Set UserIdEdit=" & YourNSSTerafficCard.UserIdEdit & ",Pelak='" & YourNSSTerafficCard.Pelak & "',Serial='" & YourNSSTerafficCard.Serial & "',NoMoney=" & IIf(YourNSSTerafficCard.NoMoney = True, 1, 0) & ",Active=" & IIf(YourNSSTerafficCard.Active = True, 1, 0) & ",CompanyName='" & YourNSSTerafficCard.CompanyName & "',NameFamily='" & YourNSSTerafficCard.NameFamily & "',Mobile='" & YourNSSTerafficCard.Mobile & "',Address='" & YourNSSTerafficCard.Address & "',Tel='" & YourNSSTerafficCard.Tel & "',Tahvilg='" & YourNSSTerafficCard.Tahvilg & "',CardType=" & YourNSSTerafficCard.CardType & ",TempCardType=" & YourNSSTerafficCard.TempCardType & ",DateTimeMilladiEdit='" & _DateTime.GetCurrentDateTimeMilladiFormated() & "',DateShamsiEdit='" & _DateTime.GetCurrentDateShamsiFull() & "' Where CardNo='" & YourNSSTerafficCard.CardNo & "'"
                End If
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
        Public Shared Function GetNSSTrafficCard(ByVal CardNo As String) As R2CoreParkingSystemStandardTrafficCardStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblRFIDCards Where Cardno='" & CardNo & "' Order By CardId Desc", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New TerraficCardNotFoundException
                Else
                    Return New R2CoreParkingSystemStandardTrafficCardStructure(Ds.Tables(0).Rows(0).Item("CardId"), Ds.Tables(0).Rows(0).Item("CardNo"), Ds.Tables(0).Rows(0).Item("Charge"), Ds.Tables(0).Rows(0).Item("UserIdSabt"), Ds.Tables(0).Rows(0).Item("UserIdEdit"), Ds.Tables(0).Rows(0).Item("PelakType"), Ds.Tables(0).Rows(0).Item("Pelak"), Ds.Tables(0).Rows(0).Item("Serial"), Ds.Tables(0).Rows(0).Item("NoMoney"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("CompanyName"), Ds.Tables(0).Rows(0).Item("NameFamily"), Ds.Tables(0).Rows(0).Item("Mobile"), Ds.Tables(0).Rows(0).Item("Address"), Ds.Tables(0).Rows(0).Item("Tel"), Ds.Tables(0).Rows(0).Item("Tahvilg"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiSabt"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiEdit"), Ds.Tables(0).Rows(0).Item("DateShamsiSabt"), Ds.Tables(0).Rows(0).Item("DateShamsiEdit"), Ds.Tables(0).Rows(0).Item("CardType"), Ds.Tables(0).Rows(0).Item("TempCardType"))
                End If
            Catch exx As TerraficCardNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetTrafficCardMobile(ByVal CardNo As String) As String
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("select mobile from R2Primary.dbo.tblrfidcards where ltrim(rtrim(cardno))='" & CardNo & "' order by cardno")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                ds.Tables.Clear()
                If Da.Fill(ds) <> 0 Then
                    Return ds.Tables(0).Rows(0).Item("mobile").TRIM
                Else
                    Throw New Exception("كارت تردد مورد نظر در سرور يافت نشد")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetNSSTrafficCard(ByVal YourCardId As Int64) As R2CoreParkingSystemStandardTrafficCardStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblRFIDCards Where CardId=" & YourCardId & "", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New TerraficCardNotFoundException
                Else
                    Return New R2CoreParkingSystemStandardTrafficCardStructure(Ds.Tables(0).Rows(0).Item("CardId"), Ds.Tables(0).Rows(0).Item("CardNo"), Ds.Tables(0).Rows(0).Item("Charge"), Ds.Tables(0).Rows(0).Item("UserIdSabt"), Ds.Tables(0).Rows(0).Item("UserIdEdit"), Ds.Tables(0).Rows(0).Item("PelakType"), Ds.Tables(0).Rows(0).Item("Pelak"), Ds.Tables(0).Rows(0).Item("Serial"), Ds.Tables(0).Rows(0).Item("NoMoney"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("CompanyName"), Ds.Tables(0).Rows(0).Item("NameFamily"), Ds.Tables(0).Rows(0).Item("Mobile"), Ds.Tables(0).Rows(0).Item("Address"), Ds.Tables(0).Rows(0).Item("Tel"), Ds.Tables(0).Rows(0).Item("Tahvilg"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiSabt"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiEdit"), Ds.Tables(0).Rows(0).Item("DateShamsiSabt"), Ds.Tables(0).Rows(0).Item("DateShamsiEdit"), Ds.Tables(0).Rows(0).Item("CardType"), Ds.Tables(0).Rows(0).Item("TempCardType"))
                End If
            Catch ex As TerraficCardNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function IsTrafficCardTypeSupported(ByVal CardNo As String) As Boolean
            Try
                Dim T As R2CoreParkingSystemStandardTrafficCardStructure = GetNSSTrafficCard(CardNo)
                Dim A As String() = Split(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.TerafficCardsTypeSupport, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0), "-")
                If A.Contains(T.CardType) = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetTrafficCardTypeName(ByVal YourCardNo As String) As String
            Dim T As R2CoreParkingSystemStandardTrafficCardStructure = GetNSSTrafficCard(YourCardNo)
            Select Case T.CardType
                Case TerafficCardType.Savari
                    Return "سواری"
                Case TerafficCardType.SixCharkh
                    Return "دو محور - شش چرخ"
                Case TerafficCardType.TenCharkh
                    Return "سه محور - ده چرخ"
                Case TerafficCardType.Tereili
                    Return "تريلی"
                Case TerafficCardType.None
                    Return "نامعلوم"
            End Select
        End Function
        Public Shared Function GetTrafficCardTempTypeName(ByVal CardNo As String) As String
            Dim T As R2CoreParkingSystemStandardTrafficCardStructure = GetNSSTrafficCard(CardNo)
            Select Case T.TempCardType
                Case TerafficTempCardType.Temp
                    Return "موقت"
                Case TerafficTempCardType.NoTemp
                    Return "دائمی"
            End Select
        End Function
        Public Shared Function GetTrafficCardsTeadadReal() As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("SELECT COUNT(*) FROM R2Primary.dbo.TblRFIDCards GROUP BY CardNo")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Return Da.Fill(Ds)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Sub DisallowTerafficCard(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblRFIDCards Set NoMoney=0,Active=0 Where Cardno='" & YourNSSTerafficCard.CardNo & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
        Public Shared Sub TerafficCardInitialRegister(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                UpdateTrafficCardType(YourNSSTerafficCard)
                'کسر هزینه کارت تردد در صورتی که دائمی باشد و نه موقت
                If YourNSSTerafficCard.TempCardType = TerafficTempCardType.NoTemp Then
                    R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(YourNSSTerafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 2), R2CoreParkingSystemAccountings.HazinehKart, YourUserNSS)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
        Public Shared Function GetDSTerafficCardType() As DataSet
            Try
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select TypeName,TypeCode from R2PrimaryParkingSystem.dbo.TblTerafficCardType Order by TypeCode", 1000, Ds)
                Return Ds
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetTerafficCardTypeNameFromTypeCode(YourTypeCode As Int64) As String
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select TypeName from R2PrimaryParkingSystem.dbo.TblTerafficCardType  Where TypeCode=" & YourTypeCode & "", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0).trim
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetTerafficCardTypeCodeFromTypeName(YourTypeName As String) As Int64
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select TypeCode from R2PrimaryParkingSystem.dbo.TblTerafficCardType  Where ltrim(rtrim(TypeName))='" & YourTypeName.Trim & "'", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetDSTerafficTempCardType() As DataSet
            Try
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select TempTypeName,TempTypeCode from R2PrimaryParkingSystem.dbo.TblTerafficTempCardType Order by TempTypeCode", 1000, Ds)
                Return Ds
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetTerafficTempCardTypeNameFromTempTypeCode(YourTempTypeCode As Int64) As String
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select TempTypeName from R2PrimaryParkingSystem.dbo.TblTerafficTempCardType  Where TempTypeCode=" & YourTempTypeCode & "", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0).trim
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetTerafficTempCardTypeCodeFromTempTypeName(YourTempTypeName As String) As Int64
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select TempTypeCode from R2PrimaryParkingSystem.dbo.TblTerafficTempCardType  Where ltrim(rtrim(TempTypeName))='" & YourTempTypeName.Trim & "'", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Namespace ExceptionManagement

        Public Class RelatedTerraficCardNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کارت تردد مرتبط یافت نشد"
                End Get
            End Property
        End Class

        Public Class TerraficCardNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کارت تردد یافت نشد"
                End Get
            End Property
        End Class

        Public Class TrafficCardNotActiveException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "كارت تردد غير فعال است " + vbCrLf + "استفاده از اين كارت ممنوع و غير مجاز است"
                End Get
            End Property
        End Class

        Public Class TrafficCardTypeNotSupportedOnThisComputerException
            Inherits ApplicationException

            Private _Message As String = String.Empty

            Public Sub New(YourMessage As String)
                _Message = YourMessage
            End Sub

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "این نوع کارت تردد در این کامپیوتر پشتيبانی نمی شود" + vbCrLf + _Message
                End Get
            End Property
        End Class

        Public Class TrafficCardNotMatchWithThisGateException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت ورود یا خروج کارت با این معبر مطابقت ندارد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace ConfigurationManagement

    Public MustInherit Class R2CoreParkingSystemConfigurations
        Inherits R2Core.ConfigurationManagement.R2CoreConfigurations

        Public Shared ReadOnly Property PersonChargeMessage As Int64 = 12
        Public Shared ReadOnly Property Camera1 As Int64 = 13
        Public Shared ReadOnly Property Camera2 As Int64 = 14
        Public Shared ReadOnly Property MoneyWalletCharge As Int64 = 15
        Public Shared ReadOnly Property ImageProcessing As Int64 = 16
        Public Shared ReadOnly Property EnterExitAccountingCanPrint As Int64 = 17
        Public Shared ReadOnly Property SepasSystem As Int64 = 18
        Public Shared ReadOnly Property TerafficCardsTypeSupport As Int64 = 19
        Public Shared ReadOnly Property SaveCarPicture As Int64 = 20
        Public Shared ReadOnly Property TrafficCardEERequestStatusWithMaabarMatch As Int64 = 23
        Public Shared ReadOnly Property TarrifsMblghPaye As Int64 = 28
        Public Shared ReadOnly Property TarrifsMblghDelay As Int64 = 29
        Public Shared ReadOnly Property TarrifsMblghApproved As Int64 = 30
        Public Shared ReadOnly Property ChargeActiveOnThisLocation As Int64 = 39
        Public Shared ReadOnly Property LPRIsActive As Int64 = 40
        Public Shared ReadOnly Property TarrifsMeselanius As Int64 = 41
        Public Shared ReadOnly Property FrmcEnterExitSetting As Int64 = 48



    End Class


End Namespace

Namespace AccountingManagement
    Public Enum R2CoreParkingSystemAccountings
        NoneType = 0
        EnterType = 1
        ExitType = 2
        ChargeType = 3
        AnjomanHazinehNobat = 4 'هزینه نوبت انجمن - تریلی و اطاقدار 
        AnjomanHazinehSodorMojavezUpTo72Saat = 5 'در سالن
        AnjomanHazinehSodorMojavezKiosk = 6 'در کیوسک
        XXX1 = 7
        XXX2 = 8
        HazinehKart = 9 'هزینه کارت تردد
        TransferallChargeToAnother = 10 'انتقال همه موجودی کارت
        SherkatHazinehNobat = 11 'منظور هزینه شرکت وقتی نوبت در اتاق کامپیوتر صادر می گردد
        BlackList = 12 'لیست سیاه
        ExitTemp = 13 'خروج موقت
        ExitSystem = 14 'خروج توسط سیستم
        MoneyWalletReturnAmount = 15 'بازگشت مبلغ مازاد کسر شده
        PrintCopyOfTurn = 16 'چاپ قبض نوبت المثنی
        RegisteringHandyBills = 17 'ثبت قبوض دستی پاکینگ
        SherkatChangeDriverTruck = 18  'هزینه تغییر نام راننده ناوگان باری - شرکت
        SherkatChangeCarTruckNumberPlate = 19 'هزینه تغییر پلاک ناوگان باری - شرکت
        AnjomanChangeDriverTruck = 20  'هزینه تغییر نام راننده ناوگان باری - انجمن
        AnjomanChangeCarTruckNumberPlate = 21 'هزینه تغییر پلاک ناوگان باری - انجمن
        TruckersAssociationControllingMoneyWallet = 22 'کارکرد کیف پول کنترلی کامیونداران
        RegisteringSoftwareUserSMSCost = 23 'هزینه اس ام اس فرآیند فعال سازی کاربر
        SoftwareUserShenasehPasswordSMSCost = 24 'هزینه ارسال اس ام اس شناسه و رمز عبور کاربر
        SoftwareUserSMSOwnerServiceCost = 25 'هزینه فعال سازی سرویس اس ام اس
    End Enum

    Public Class R2StandardEnterExitAccountingStructure

        Private _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure
        Private _EEAccountingProcessType As R2CoreParkingSystemAccountings
        Private _DateShamsiA As String
        Private _TimeA As String
        Private _DateTimeMilladiA As DateTime
        Private _NSSCar As R2StandardCarStructure
        Private _MaabarCode As String
        Private _MblghA As Int64
        Private _UserIdA As Int64
        Private _CurrentChargeA As Int64
        Private _ReminderChargeA As Int64

#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            _NSSTrafficCard = Nothing : _EEAccountingProcessType = R2CoreParkingSystemAccountings.NoneType
            _DateShamsiA = "" : _TimeA = "" : _DateTimeMilladiA = Nothing : _NSSCar = Nothing
            _MaabarCode = "" : _MblghA = 0 : _UserIdA = 0 : _CurrentChargeA = 0 : _ReminderChargeA = 0
        End Sub
        Public Sub New(ByVal YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByVal YourEEAccountingProcessType As R2CoreParkingSystemAccountings, ByVal YourDateShamsiA As String, ByVal YourTimeA As String, ByVal YourDateTimeMilladiA As DateTime, ByVal YourNSSCar As R2StandardCarStructure, ByVal YourMaabarCode As String, ByVal YourMblghA As Int64, ByVal YourUserIdA As Int64, ByVal YourCurrentChargeA As Int64, ByVal YourReminderChargeA As Int64)
            _NSSTrafficCard = YourNSSTrafficCard
            _EEAccountingProcessType = YourEEAccountingProcessType
            _DateShamsiA = YourDateShamsiA
            _TimeA = YourTimeA
            _DateTimeMilladiA = YourDateTimeMilladiA
            _NSSCar = YourNSSCar
            _MaabarCode = YourMaabarCode
            _MblghA = YourMblghA
            _UserIdA = YourUserIdA
            _CurrentChargeA = YourCurrentChargeA
            _ReminderChargeA = YourReminderChargeA
        End Sub
#End Region
#Region "Properting Management"
        Public Property NSSTrafficCard() As R2CoreParkingSystemStandardTrafficCardStructure
            Get
                Return _NSSTrafficCard
            End Get
            Set(ByVal Value As R2CoreParkingSystemStandardTrafficCardStructure)
                _NSSTrafficCard = Value
            End Set
        End Property
        Public Property EEAccountingProcessType() As R2CoreParkingSystemAccountings
            Get
                Return _EEAccountingProcessType
            End Get
            Set(ByVal Value As R2CoreParkingSystemAccountings)
                _EEAccountingProcessType = Value
            End Set
        End Property
        Public Property DateShamsiA() As String
            Get
                Return _DateShamsiA
            End Get
            Set(ByVal Value As String)
                _DateShamsiA = Value
            End Set
        End Property
        Public Property TimeA() As String
            Get
                Return _TimeA
            End Get
            Set(ByVal Value As String)
                _TimeA = Value
            End Set
        End Property
        Public Property DateTimeMilladiA() As DateTime
            Get
                Return _DateTimeMilladiA
            End Get
            Set(ByVal Value As DateTime)
                _DateTimeMilladiA = Value
            End Set
        End Property
        Public Property NSSCar() As R2StandardCarStructure
            Get
                Return _NSSCar
            End Get
            Set(ByVal Value As R2StandardCarStructure)
                _NSSCar = Value
            End Set
        End Property
        Public Property MaabarCode() As String
            Get
                Return _MaabarCode
            End Get
            Set(ByVal Value As String)
                _MaabarCode = Value
            End Set
        End Property
        Public Property MblghA() As Int64
            Get
                Return _MblghA
            End Get
            Set(ByVal Value As Int64)
                _MblghA = Value
            End Set
        End Property
        Public Property UserIdA() As Int64
            Get
                Return _UserIdA
            End Get
            Set(ByVal Value As Int64)
                _UserIdA = Value
            End Set
        End Property
        Public Property CurrentChargeA() As Int64
            Get
                Return _CurrentChargeA
            End Get
            Set(ByVal Value As Int64)
                _CurrentChargeA = Value
            End Set
        End Property
        Public Property ReminderChargeA() As Int64
            Get
                Return _ReminderChargeA
            End Get
            Set(ByVal Value As Int64)
                _ReminderChargeA = Value
            End Set
        End Property
#End Region


    End Class

    Public Class R2StandardEnterExitAccountingExtendedStructure
        Inherits R2StandardEnterExitAccountingStructure

        Public Sub New()
            MyBase.New
            _ColorName = String.Empty
            _AccountName = String.Empty
            _ComputerName = String.Empty
            _UserName = String.Empty
        End Sub

        Public Sub New(YourNSS As R2StandardEnterExitAccountingStructure, YourColorName As String, YourAccountName As String, YourComputerName As String, YourUserName As String)
            MyBase.New(YourNSS.NSSTrafficCard, YourNSS.EEAccountingProcessType, YourNSS.DateShamsiA, YourNSS.TimeA, YourNSS.DateTimeMilladiA, YourNSS.NSSCar, YourNSS.MaabarCode, YourNSS.MblghA, YourNSS.UserIdA, YourNSS.CurrentChargeA, YourNSS.ReminderChargeA)
            _ColorName = YourColorName
            _AccountName = YourAccountName
            _ComputerName = YourComputerName
            _UserName = YourUserName
        End Sub

        Public Property ColorName() As String
        Public Property AccountName() As String
        Public Property ComputerName() As String
        Public Property UserName() As String

    End Class

    Public Class R2CoreParkingSystemInstanceAccountingManager
        Public Function GetAccountingCollection(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourTotalNumberofAccounts As Int64) As List(Of R2StandardEnterExitAccountingExtendedStructure)
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Try
                Dim Lst = New List(Of R2StandardEnterExitAccountingExtendedStructure)
                Dim Ds As DataSet
                InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top " & YourTotalNumberofAccounts & " Accounting.EEAccountingProcessType,Accountings.AColor,Accountings.AName,Accounting.TimeA,Accounting.DateShamsiA,Accounting.CurrentChargeA,Accounting.MblghA,Accounting.ReminderChargeA,Computers.MName,SoftwareUsers.UserName,Accounting.DateMilladiA,Accounting.maabarcode,Accounting.userida from R2Primary.dbo.TblAccounting as Accounting
                         Inner Join  R2Primary.dbo.TblAccountingCodingTypes as Accountings On Accounting.EEAccountingProcessType=Accountings.ACode
                         Inner Join R2Primary.dbo.TblComputers as Computers On Accounting.MaabarCode=Computers.MId
                         Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On Accounting.UserIdA=SoftwareUsers.UserId
                      Where Accounting.CardId=" & YourTrafficCard.CardId & "  Order by Accounting.DateMilladiA Desc", 0, Ds)
                For Loopx As Int16 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim myEEAProcessType As String = Ds.Tables(0).Rows(Loopx).Item("EEAccountingProcessType")
                    Dim myDateShamsiA As String = Ds.Tables(0).Rows(Loopx).Item("dateshamsia")
                    Dim myTimeA As String = Ds.Tables(0).Rows(Loopx).Item("TimeA")
                    Dim myDateTimeMilladiA As DateTime = Ds.Tables(0).Rows(Loopx).Item("datemilladia")
                    Dim myNSSCar As R2StandardCarStructure = New R2StandardCarStructure
                    Dim myMaabarCode As String = Ds.Tables(0).Rows(Loopx).Item("maabarcode")
                    Dim myMblghA As Int64 = Ds.Tables(0).Rows(Loopx).Item("mblgha")
                    Dim myUserIdA As Int64 = Ds.Tables(0).Rows(Loopx).Item("userida")
                    Dim myCurrentChargeA As Int64 = Ds.Tables(0).Rows(Loopx).Item("currentchargea")
                    Dim myReminderChargeA As Int64 = Ds.Tables(0).Rows(Loopx).Item("reminderchargea")
                    Lst.Add(New R2StandardEnterExitAccountingExtendedStructure(New R2StandardEnterExitAccountingStructure(YourTrafficCard, myEEAProcessType, myDateShamsiA, myTimeA, myDateTimeMilladiA, myNSSCar, myMaabarCode, myMblghA, myUserIdA, myCurrentChargeA, myReminderChargeA), Ds.Tables(0).Rows(Loopx).Item("AColor").trim, Ds.Tables(0).Rows(Loopx).Item("AName").trim, Ds.Tables(0).Rows(Loopx).Item("MName").trim, Ds.Tables(0).Rows(Loopx).Item("UserName").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub InsertAccounting(ByVal YourEEAcounting As R2StandardEnterExitAccountingStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                If YourEEAcounting.NSSCar Is Nothing Then
                    CmdSql.CommandText = "insert into R2Primary.dbo.TblAccounting(CardId,EEAccountingProcessType,DateShamsiA,TimeA,DateMilladiA,PelakA,SerialA,CityA,PelakTypeA,MaabarCode,MblghA,UseridA,CurrentChargeA,ReminderChargeA) values('" & YourEEAcounting.NSSTrafficCard.CardId & "'," & YourEEAcounting.EEAccountingProcessType & ",'" & YourEEAcounting.DateShamsiA & "','" & YourEEAcounting.TimeA & "','" & YourEEAcounting.DateTimeMilladiA.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','','','" & Now.Millisecond.ToString() + Rnd().ToString() & "',0,'" & YourEEAcounting.MaabarCode & "'," & YourEEAcounting.MblghA & "," & YourEEAcounting.UserIdA & "," & YourEEAcounting.CurrentChargeA & "," & YourEEAcounting.ReminderChargeA & ")"
                Else
                    CmdSql.CommandText = "insert into R2Primary.dbo.TblAccounting(CardId,EEAccountingProcessType,DateShamsiA,TimeA,DateMilladiA,PelakA,SerialA,CityA,PelakTypeA,MaabarCode,MblghA,UseridA,CurrentChargeA,ReminderChargeA) values('" & YourEEAcounting.NSSTrafficCard.CardId & "'," & YourEEAcounting.EEAccountingProcessType & ",'" & YourEEAcounting.DateShamsiA & "','" & YourEEAcounting.TimeA & "','" & YourEEAcounting.DateTimeMilladiA.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & YourEEAcounting.NSSCar.StrCarNo & "','" & YourEEAcounting.NSSCar.StrCarSerialNo & "','" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(YourEEAcounting.NSSCar.nIdCity) & "'," & R2PelakType.None & ",'" & R2CoreMClassConfigurationManagement.GetComputerCode() & "'," & YourEEAcounting.MblghA & "," & YourEEAcounting.UserIdA & "," & YourEEAcounting.CurrentChargeA & "," & YourEEAcounting.ReminderChargeA & ")"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Public Class R2CoreParkingSystemMClassAccountingManagement

        Private Shared _DateTime As R2DateTime = New R2DateTime()

        Public Shared Function GetAccountingNamebyAccountingCode(ByVal YourAccountingCode As R2CoreParkingSystemAccountings) As String
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select AName from R2Primary.dbo.TblAccountingCodingTypes Where ACode=" & YourAccountingCode & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Ds.Tables(0).Rows(0).Item("AName").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub InsertAccounting(ByVal YourEEAcounting As R2StandardEnterExitAccountingStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                If YourEEAcounting.NSSCar Is Nothing Then
                    CmdSql.CommandText = "insert into R2Primary.dbo.TblAccounting(CardId,EEAccountingProcessType,DateShamsiA,TimeA,DateMilladiA,PelakA,SerialA,CityA,PelakTypeA,MaabarCode,MblghA,UseridA,CurrentChargeA,ReminderChargeA) values('" & YourEEAcounting.NSSTrafficCard.CardId & "'," & YourEEAcounting.EEAccountingProcessType & ",'" & YourEEAcounting.DateShamsiA & "','" & YourEEAcounting.TimeA & "','" & YourEEAcounting.DateTimeMilladiA.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','','','" & Now.Millisecond.ToString() + Rnd().ToString() & "',0,'" & YourEEAcounting.MaabarCode & "'," & YourEEAcounting.MblghA & "," & YourEEAcounting.UserIdA & "," & YourEEAcounting.CurrentChargeA & "," & YourEEAcounting.ReminderChargeA & ")"
                Else
                    CmdSql.CommandText = "insert into R2Primary.dbo.TblAccounting(CardId,EEAccountingProcessType,DateShamsiA,TimeA,DateMilladiA,PelakA,SerialA,CityA,PelakTypeA,MaabarCode,MblghA,UseridA,CurrentChargeA,ReminderChargeA) values('" & YourEEAcounting.NSSTrafficCard.CardId & "'," & YourEEAcounting.EEAccountingProcessType & ",'" & YourEEAcounting.DateShamsiA & "','" & YourEEAcounting.TimeA & "','" & YourEEAcounting.DateTimeMilladiA.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & YourEEAcounting.NSSCar.StrCarNo & "','" & YourEEAcounting.NSSCar.StrCarSerialNo & "','" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(YourEEAcounting.NSSCar.nIdCity) & "'," & R2PelakType.None & ",'" & R2CoreMClassConfigurationManagement.GetComputerCode() & "'," & YourEEAcounting.MblghA & "," & YourEEAcounting.UserIdA & "," & YourEEAcounting.CurrentChargeA & "," & YourEEAcounting.ReminderChargeA & ")"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetAccountingColorbyAccountingCode(ByVal YourAccountingCode As R2CoreParkingSystemAccountings) As String
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select AColor from R2Primary.dbo.TblAccountingCodingTypes Where ACode=" & YourAccountingCode & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Ds.Tables(0).Rows(0).Item("AColor").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAccountingCollection(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourTotalNumberofAccounts As Int64) As List(Of R2StandardEnterExitAccountingExtendedStructure)
            Try
                Dim Lst As List(Of R2StandardEnterExitAccountingExtendedStructure) = New List(Of R2StandardEnterExitAccountingExtendedStructure)
                Dim Ds As DataSet = New DataSet
                R2Core.DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top " & YourTotalNumberofAccounts & " Accounting.EEAccountingProcessType,Accountings.AColor,Accountings.AName,Accounting.TimeA,Accounting.DateShamsiA,Accounting.CurrentChargeA,Accounting.MblghA,Accounting.ReminderChargeA,Computers.MName,SoftwareUsers.UserName,Accounting.DateMilladiA,Accounting.maabarcode,Accounting.userida from R2Primary.dbo.TblAccounting as Accounting
                         Inner Join  R2Primary.dbo.TblAccountingCodingTypes as Accountings On Accounting.EEAccountingProcessType=Accountings.ACode
                         Inner Join R2Primary.dbo.TblComputers as Computers On Accounting.MaabarCode=Computers.MId
                         Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On Accounting.UserIdA=SoftwareUsers.UserId
                      Where Accounting.CardId=" & YourTrafficCard.CardId & "  Order by Accounting.DateMilladiA Desc", 1, Ds)
                For Loopx As Int16 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim myEEAProcessType As String = Ds.Tables(0).Rows(Loopx).Item("EEAccountingProcessType")
                    Dim myDateShamsiA As String = Ds.Tables(0).Rows(Loopx).Item("dateshamsia")
                    Dim myTimeA As String = Ds.Tables(0).Rows(Loopx).Item("TimeA")
                    Dim myDateTimeMilladiA As DateTime = Ds.Tables(0).Rows(Loopx).Item("datemilladia")
                    Dim myNSSCar As R2StandardCarStructure = New R2StandardCarStructure
                    Dim myMaabarCode As String = Ds.Tables(0).Rows(Loopx).Item("maabarcode")
                    Dim myMblghA As Int64 = Ds.Tables(0).Rows(Loopx).Item("mblgha")
                    Dim myUserIdA As Int64 = Ds.Tables(0).Rows(Loopx).Item("userida")
                    Dim myCurrentChargeA As Int64 = Ds.Tables(0).Rows(Loopx).Item("currentchargea")
                    Dim myReminderChargeA As Int64 = Ds.Tables(0).Rows(Loopx).Item("reminderchargea")
                    Lst.Add(New R2StandardEnterExitAccountingExtendedStructure(New R2StandardEnterExitAccountingStructure(YourTrafficCard, myEEAProcessType, myDateShamsiA, myTimeA, myDateTimeMilladiA, myNSSCar, myMaabarCode, myMblghA, myUserIdA, myCurrentChargeA, myReminderChargeA), Ds.Tables(0).Rows(Loopx).Item("AColor").trim, Ds.Tables(0).Rows(Loopx).Item("AName").trim, Ds.Tables(0).Rows(Loopx).Item("MName").trim, Ds.Tables(0).Rows(Loopx).Item("UserName").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLastAccounting(YourAccountingCodeType As Int64) As R2StandardEnterExitAccountingStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim DS As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top 1 * from R2Primary.dbo.TblAccounting as Accounting
                      Where Accounting.EEAccountingProcessType=" & YourAccountingCodeType & "
                      Order By Accounting.DateMilladiA Desc", 0, DS).GetRecordsCount <> 0 Then
                    Return New R2StandardEnterExitAccountingStructure(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(Convert.ToInt64(DS.Tables(0).Rows(0).Item("CardId"))), DS.Tables(0).Rows(0).Item("EEAccountingProcessType"), DS.Tables(0).Rows(0).Item("DateShamsiA"), DS.Tables(0).Rows(0).Item("TimeA"), DS.Tables(0).Rows(0).Item("DateMilladiA"), Nothing, DS.Tables(0).Rows(0).Item("MaabarCode"), DS.Tables(0).Rows(0).Item("MblghA"), DS.Tables(0).Rows(0).Item("UserIdA"), DS.Tables(0).Rows(0).Item("CurrentChargeA"), DS.Tables(0).Rows(0).Item("ReminderChargeA"))
                Else
                    Throw New LastAccountingRecordforAccountingCodeTypeNotFoundException
                End If
            Catch ex As LastAccountingRecordforAccountingCodeTypeNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace ExceptionManagement

        Public Class LastAccountingRecordforAccountingCodeTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "رکوردی برای نوع اکانتینگ مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace MoneyWalletManagement

    Public Enum BagPayType
        None = 0
        AddMoney = 1
        MinusMoney = 2
    End Enum

    Public Class R2CoreParkingSystemInstanceMoneyWalletManager
        Private _DateTime As R2DateTime = New R2DateTime

        Public Function GetMoneyWalletCharge(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("select top 1 charge from R2Primary.dbo.tblrfidcards where ltrim(rtrim(cardno))='" & YourNSSTrafficCard.CardNo & "' order by cardID DESC")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                ds.Tables.Clear()
                If Da.Fill(ds) <> 0 Then
                    Return ds.Tables(0).Rows(0).Item("charge")
                Else
                    Throw New MoneyWalletNotExistException
                End If
            Catch ex As MoneyWalletNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub ActMoneyWalletNextStatus(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagType As BagPayType, YourMblgh As Int64, YourAccountCode As R2CoreParkingSystemAccountings, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager()
            Dim InstanceAccounting = New R2CoreParkingSystemInstanceAccountingManager()
            Try
                Dim myNSSCar As R2StandardCarStructure = Nothing
                Try
                    myNSSCar = InstanceCars.GetNSSCar(InstanceCars.GetnIdCarFromCardId(YourNSSTrafficCard.CardId))
                Catch ex As R2CoreParkingSystemRelatedCarNotExistException
                Catch ex As RelatedTerraficCardNotFoundException
                Catch exx As GetDataException
                Catch ex As GetNSSException
                End Try
                Dim myMoneyWalletCurrentCharge As Int64 = GetMoneyWalletCharge(YourNSSTrafficCard)
                Dim myMoneyWalletReminder As Int64
                If YourBagType = BagPayType.AddMoney Then
                    myMoneyWalletReminder = myMoneyWalletCurrentCharge + YourMblgh
                ElseIf YourBagType = BagPayType.MinusMoney Then
                    myMoneyWalletReminder = myMoneyWalletCurrentCharge - YourMblgh
                End If
                InstanceAccounting.InsertAccounting(New R2StandardEnterExitAccountingStructure(YourNSSTrafficCard, YourAccountCode, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), _DateTime.GetCurrentDateTimeMilladiFormated(), myNSSCar, R2CoreMClassConfigurationManagement.GetComputerCode(), YourMblgh, YourUserNSS.UserId, myMoneyWalletCurrentCharge, myMoneyWalletReminder))
                AddMinusMoneyWallet(YourNSSTrafficCard, YourBagType, YourMblgh)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub AddMinusMoneyWallet(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagPayType As BagPayType, YourMblgh As Int64)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
                If YourBagPayType = BagPayType.AddMoney Then
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards set Charge=charge+" & YourMblgh & " where CardNo='" & YourNSSTrafficCard.CardNo & "'"
                Else
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards set Charge=charge-" & YourMblgh & " where CardNo='" & YourNSSTrafficCard.CardNo & "'"
                End If
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSMoneyWallet(YourNSSSoftwareuser As R2CoreStandardSoftwareUserStructure) As R2CoreParkingSystemStandardTrafficCardStructure
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
            Try
                Dim Ds As New DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                   "Select Top 1 TCardsRCar.CardId
                    from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                          Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On SoftwareUsers.UserId=EntityRelations.E1 
                          Inner Join dbtransport.dbo.TbDriver as Drivers On EntityRelations.E2=Drivers.nIDDriver 
                          Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Drivers.nIDDriver=CarAndPersons.nIDPerson
                          Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
                          Inner Join R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars as TCardsRCar On Cars.nIDCar=TCardsRCar.nCarId 
                    Where SoftwareUsers.UserId=" & YourNSSSoftwareuser.UserId & " and SoftwareUsers.UserActive=1 and SoftwareUsers.Deleted=0 and EntityRelations.RelationActive=1 and  
                              EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and Cars.ViewFlag=1 and TCardsRCar.RelationActive=1 and CarAndPersons.snRelation=2 
                              and ((DATEDIFF(SECOND,TCardsRCar.RelationTimeStamp,getdate())<240) or (TCardsRCar.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                              and ((DATEDIFF(SECOND,CarAndPersons.RelationTimeStamp,getdate())<240) or (CarAndPersons.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                    Order By CarAndPersons.nIDCarAndPerson Desc,TCardsRCar.RelationId Desc,TCardsRCar.RelationTimeStamp Desc", 0, Ds).GetRecordsCount <> 0 Then
                    Return InstanceTrafficCards.GetNSSTrafficCard(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("CardId")))
                Else
                    Throw New SoftwareUserMoneyWalletNotFoundException
                End If
            Catch ex As SoftwareUserMoneyWalletNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Function

    End Class

    Public Class R2CoreParkingSystemMClassMoneyWalletManagement

        Private Shared _DateTime As R2DateTime = New R2DateTime

        Public Shared Sub ActMoneyWalletNextStatus(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagType As BagPayType, YourMblgh As Int64, YourAccountCode As R2CoreParkingSystemAccountings, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim myNSSCar As R2StandardCarStructure = Nothing
                Try
                    myNSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(YourNSSTrafficCard.CardId))
                Catch ex As R2CoreParkingSystemRelatedCarNotExistException
                Catch ex As RelatedTerraficCardNotFoundException
                Catch exx As GetDataException
                Catch ex As GetNSSException
                End Try
                Dim myMoneyWalletCurrentCharge As Int64 = GetMoneyWalletCharge(YourNSSTrafficCard)
                Dim myMoneyWalletReminder As Int64
                If YourBagType = BagPayType.AddMoney Then
                    myMoneyWalletReminder = myMoneyWalletCurrentCharge + YourMblgh
                ElseIf YourBagType = BagPayType.MinusMoney Then
                    myMoneyWalletReminder = myMoneyWalletCurrentCharge - YourMblgh
                End If
                R2CoreParkingSystemMClassAccountingManagement.InsertAccounting(New R2StandardEnterExitAccountingStructure(YourNSSTrafficCard, YourAccountCode, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), _DateTime.GetCurrentDateTimeMilladiFormated(), myNSSCar, R2CoreMClassConfigurationManagement.GetComputerCode(), YourMblgh, YourUserNSS.UserId, myMoneyWalletCurrentCharge, myMoneyWalletReminder))
                AddMinusMoneyWallet(YourNSSTrafficCard, YourBagType, YourMblgh)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetMoneyWalletCharge(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("select top 1 charge from R2Primary.dbo.tblrfidcards where ltrim(rtrim(cardno))='" & YourNSSTrafficCard.CardNo & "' order by cardID DESC")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                ds.Tables.Clear()
                If Da.Fill(ds) <> 0 Then
                    Return ds.Tables(0).Rows(0).Item("charge")
                Else
                    Throw New MoneyWalletNotExistException
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub AddMinusMoneyWallet(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagPayType As BagPayType, YourMblgh As Int64)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
                If YourBagPayType = BagPayType.AddMoney Then
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards set Charge=charge+" & YourMblgh & " where CardNo='" & YourNSSTrafficCard.CardNo & "'"
                Else
                    Cmdsql.CommandText = "Update R2Primary.dbo.TblRfidCards set Charge=charge-" & YourMblgh & " where CardNo='" & YourNSSTrafficCard.CardNo & "'"
                End If
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetMoneyWalletReminder(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagPayType As BagPayType, YourMblgh As Int64) As Int64
            Try
                If YourBagPayType = BagPayType.AddMoney Then
                    Return GetMoneyWalletCharge(YourNSSTrafficCard) + YourMblgh
                ElseIf YourBagPayType = BagPayType.MinusMoney Then
                    Return GetMoneyWalletCharge(YourNSSTrafficCard) - YourMblgh
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetMoneyWalletAllMoney(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourAccountType As R2CoreParkingSystemAccountings, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim myAllMoney As Int64 = GetMoneyWalletCharge(YourNSSTrafficCard)
                If myAllMoney >= 0 Then
                    ActMoneyWalletNextStatus(YourNSSTrafficCard, BagPayType.MinusMoney, myAllMoney, YourAccountType, YourUserNSS)
                Else
                    ActMoneyWalletNextStatus(YourNSSTrafficCard, BagPayType.AddMoney, -myAllMoney, YourAccountType, YourUserNSS)
                End If
                Return myAllMoney
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Shared Sub TransferSourceMoneyWalletChargeToSecond(ByVal YourNSSSourceTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByVal YourNSSSecondTrafficCard As R2CoreParkingSystemStandardRFIDCardStructure)
        '    Try
        '        Dim myAllMoney as Int64= GetMoneyWalletAllMoney(YourNSSSourceTrafficCard,R2CoreParkingSystemAccountings.TransferallChargeToAnother)
        '        ActMoneyWalletNextStatus(YourNSSSecondTrafficCard,BagPayType.AddMoney,myAllMoney,R2CoreParkingSystemAccountings.TransferallChargeToAnother)
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Sub

    End Class

    Public Class MoneyWalletNotExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "کیف پول مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class MoneyWalletCurrentChargeNotEnoughException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "موجودی کیف پول کافی نیست"
            End Get
        End Property
    End Class


End Namespace

Namespace MoneyWalletChargeManagement

    Public Class R2StandardMoneyWalletChargeStructure

        Public Sub New()
            MyBase.New()
            _NSSTrafficCard = Nothing
            _Mblgh = Int64.MinValue
            _UserId = Int64.MinValue
            _Mobile = String.Empty
            _DateTimeMilladi = String.Empty
            _DateShamsi = String.Empty
            _TimeCharge = String.Empty
            _Radifx = Int32.MinValue
            _Tash = Int64.MinValue
        End Sub

        Public Sub New(ByVal YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByVal YourMblgh As Int64, ByVal YourUserId As Int64, ByVal YourMobile As String, ByVal YourDateTimeMilladi As DateTime, ByVal YourDateShamsi As String, ByVal YourTash As Int64, ByVal YourRadifx As Int32, ByVal YourTimeCharge As String)
            _NSSTrafficCard = YourNSSTrafficCard
            _Mblgh = YourMblgh
            _UserId = YourUserId
            _Mobile = YourMobile
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Radifx = YourRadifx
            _TimeCharge = YourTimeCharge
            _Tash = YourTash
        End Sub

        Public Property NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure

        Public Property Radifx As Int32

        Public Property DateShamsi As String

        Public Property TimeCharge As String

        Public Property DateTimeMilladi As DateTime

        Public Property Mblgh As Int64

        Public Property UserId As Int64

        Public Property Mobile As String

        Public Property Tash As Int64


    End Class

    Public Class R2StandardMoneyWalletChargeExtendedStructure
        Inherits R2StandardMoneyWalletChargeStructure

        Public Sub New()
            MyBase.New()
            _UserName = String.Empty
        End Sub

        Public Sub New(ByVal YourNSSMoneyWalletCharge As R2StandardMoneyWalletChargeStructure, YourUserName As String)
            MyBase.New(YourNSSMoneyWalletCharge.NSSTrafficCard, YourNSSMoneyWalletCharge.Mblgh, YourNSSMoneyWalletCharge.UserId, YourNSSMoneyWalletCharge.Mobile, YourNSSMoneyWalletCharge.DateTimeMilladi, YourNSSMoneyWalletCharge.DateShamsi, YourNSSMoneyWalletCharge.Tash, YourNSSMoneyWalletCharge.Radifx, YourNSSMoneyWalletCharge.TimeCharge)
            _UserName = YourUserName
        End Sub

        Public Property UserName As String

    End Class

    Public Class R2CoreParkingSystemInstanceMoneyWalletChargeManager
        Private _DateTime As R2DateTime = New R2DateTime()

        Public Sub SabtCharge(ByVal MoneyWalletCharge As R2StandardMoneyWalletChargeStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
                Cmdsql.CommandText = "select top 1 radifx from R2Primary.dbo.TblMoneyWalletCharges where CardId='" & MoneyWalletCharge.NSSTrafficCard.CardId & "' order by radifx desc"
                Dim myRadifx As Int32 = Cmdsql.ExecuteScalar + 1
                Cmdsql.CommandText = "insert into R2Primary.dbo.TblMoneyWalletCharges(CardId,Radifx,DateShamsi,TimeCharge,DateTimeMilladi,Mblgh,UserId,Mobile,Tash) values('" & MoneyWalletCharge.NSSTrafficCard.CardId & "'," & myRadifx & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "'," & MoneyWalletCharge.Mblgh & "," & MoneyWalletCharge.UserId & ",'" & MoneyWalletCharge.Mobile & "'," & MoneyWalletCharge.Tash & ")"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then
                    Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Public Class R2CoreParkingSystemMClassMoneyWalletChargeManagement

        Private Shared _DateTime As R2DateTime = New R2DateTime()

        Public Shared Sub SabtCharge(ByVal MoneyWalletCharge As R2StandardMoneyWalletChargeStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
                Cmdsql.CommandText = "select top 1 radifx from R2Primary.dbo.TblMoneyWalletCharges where CardId='" & MoneyWalletCharge.NSSTrafficCard.CardId & "' order by radifx desc"
                Dim myRadifx As Int32 = Cmdsql.ExecuteScalar + 1
                Cmdsql.CommandText = "insert into R2Primary.dbo.TblMoneyWalletCharges(CardId,Radifx,DateShamsi,TimeCharge,DateTimeMilladi,Mblgh,UserId,Mobile,Tash) values('" & MoneyWalletCharge.NSSTrafficCard.CardId & "'," & myRadifx & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "'," & MoneyWalletCharge.Mblgh & "," & MoneyWalletCharge.UserId & ",'" & MoneyWalletCharge.Mobile & "'," & MoneyWalletCharge.Tash & ")"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then
                    Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function HaveMoneyWalletChargeSavabegh(ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Boolean
            Try
                Dim Ds As New DataSet
                If R2Core.DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "select cardid from R2Primary.dbo.TblMoneyWalletCharges where cardid=" & YourTrafficCard.CardId & "", 1, Ds).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetMoneyWalletChargeCollection(ByVal YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourTotalNumberofRecordsRequested As Int64) As List(Of R2StandardMoneyWalletChargeExtendedStructure)
            Try
                Dim Lst As List(Of R2StandardMoneyWalletChargeExtendedStructure) = New List(Of R2StandardMoneyWalletChargeExtendedStructure)
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select Top " & YourTotalNumberofRecordsRequested & " SoftWare.UserName,Charge.* from R2Primary.dbo.TblMoneyWalletCharges AS Charge 
                               Inner Join R2Primary.dbo.TblSoftwareUsers as SoftWare On Charge.UserId=SoftWare.UserId
                             Where Charge.CardId='" & YourNSSTrafficCard.CardId & "' Order by DateTimeMilladi Desc", 1, Ds)
                For loopx As Int16 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2StandardMoneyWalletChargeExtendedStructure(New R2StandardMoneyWalletChargeStructure(YourNSSTrafficCard, Ds.Tables(0).Rows(loopx).Item("mblgh"), Ds.Tables(0).Rows(loopx).Item("userid"), Ds.Tables(0).Rows(0).Item("Mobile").trim, Ds.Tables(0).Rows(loopx).Item("DateTimeMilladi"), Ds.Tables(0).Rows(loopx).Item("DateShamsi").trim, Ds.Tables(0).Rows(loopx).Item("Tash"), Ds.Tables(0).Rows(loopx).Item("Radifx"), Ds.Tables(0).Rows(loopx).Item("TimeCharge").trim), Ds.Tables(0).Rows(loopx).Item("UserName").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class ChargingAmountInvalidException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    'مبلغ مورد نظر در محدوده مجاز نیست
                    Return (New R2CoreMClassPredefinedMessagesManager).GetNSS(R2CoreParkingSystemPredefinedMessages.AmountInvalid).MsgContent
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace UserChargeProcessManagement

    Public Class R2StandardUserChargeProcessStructure

        Public Sub New()
            MyBase.New()
            _TrafficCardNo = String.Empty
            _Mblgh = Int64.MinValue
            _DateShamsi = String.Empty
            _TimeCharge = String.Empty
        End Sub

        Public Sub New(ByVal YourTrafficCardNo As String, ByVal YourMblgh As Int64, ByVal YourDateShamsi As String, ByVal YourTimeCharge As String)
            _TrafficCardNo = YourTrafficCardNo
            _DateShamsi = YourDateShamsi
            _TimeCharge = YourTimeCharge
            _Mblgh = YourMblgh
        End Sub

        Public Property TrafficCardNo As String

        Public Property DateShamsi As String

        Public Property TimeCharge As String

        Public Property Mblgh As Int64

    End Class

    Public Class R2CoreParkingSystemMClassUserChargeProcessManagement
        Private Shared _DateTime As R2DateTime = New R2DateTime()

        Public Shared Function GetUserChargeProcessCollection(YourNSSUser As R2CoreStandardSoftwareUserStructure, YourDate1 As String, YourDate2 As String, YourTime1 As String, YourTime2 As String, YourTotalNumberofRecordsRequested As Int64) As List(Of R2StandardUserChargeProcessStructure)
            Try
                Dim myConcat1 As String = YourDate1 + YourTime1
                Dim myConcat2 As String = YourDate2 + YourTime2
                Dim Lst As List(Of R2StandardUserChargeProcessStructure) = New List(Of R2StandardUserChargeProcessStructure)
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                            "Select Top " & YourTotalNumberofRecordsRequested & " RFIDCards.CardNo,Charge.* from R2Primary.dbo.TblMoneyWalletCharges as Charge
                                Inner Join R2Primary.dbo.TblRFIDCards as RFIDCards On Charge.CardId=RFIDCards.CardId
                                  Where (DateShamsi+TimeCharge>='" & myConcat1 & "') and (DateShamsi+TimeCharge<='" & myConcat2 & "') and (UserId=" & YourNSSUser.UserId & ") Order by DateTimeMilladi Desc", 1, Ds)
                For loopx As Int16 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2StandardUserChargeProcessStructure(Ds.Tables(0).Rows(loopx).Item("CardNo"), Ds.Tables(0).Rows(loopx).Item("Mblgh"), Ds.Tables(0).Rows(loopx).Item("DateShamsi").trim, Ds.Tables(0).Rows(loopx).Item("TimeCharge").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTotalAmountofUserChargeProcess(YourNSSUser As R2CoreStandardSoftwareUserStructure, YourDate1 As String, YourDate2 As String, YourTime1 As String, YourTime2 As String) As Int64
            Try
                Dim myConcat1 As String = YourDate1 + YourTime1
                Dim myConcat2 As String = YourDate2 + YourTime2
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Sum(Mblgh) as Sumx from R2Primary.dbo.TblMoneyWalletCharges where (DateShamsi+TimeCharge>='" & myConcat1 & "') and (DateShamsi+TimeCharge<='" & myConcat2 & "') and (UserId=" & YourNSSUser.UserId & ")", 1, DS).GetRecordsCount() <> 0 Then
                    If Object.Equals(DBNull.Value, DS.Tables(0).Rows(0).Item("Sumx")) Then
                        Return 0
                    Else
                        Return DS.Tables(0).Rows(0).Item("Sumx")
                    End If
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

End Namespace

Namespace Cars

    Public Class R2StandardCarStructure
        Inherits BaseStandardClass.R2StandardStructure

        Private mynIdCar As String
        Private mysnCarType As String
        Private myStrCarNo As String
        Private myStrCarSerialNo As String
        Private mynIdCity As String



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            mynIdCar = "" : mysnCarType = "" : myStrCarNo = "" : myStrCarSerialNo = "" : mynIdCity = ""
        End Sub

        Public Sub New(ByVal nIdCarr As String, ByVal snCarTypee As String, ByVal StrCarNoo As String, ByVal StrCarSerialNoo As String, ByVal nIdCityy As String)
            MyBase.New(nIdCarr, StrCarNoo)
            mynIdCar = nIdCarr
            mysnCarType = snCarTypee
            myStrCarNo = StrCarNoo
            myStrCarSerialNo = StrCarSerialNoo
            mynIdCity = nIdCityy
        End Sub
#End Region
#Region "Properting Management"
        Public Property nIdCar() As String
            Get
                Return mynIdCar
            End Get
            Set(ByVal Value As String)
                mynIdCar = Value
            End Set
        End Property
        Public Property snCarType() As String
            Get
                Return mysnCarType
            End Get
            Set(ByVal Value As String)
                mysnCarType = Value
            End Set
        End Property
        Public Property StrCarNo() As String
            Get
                Return myStrCarNo.Trim()
            End Get
            Set(ByVal Value As String)
                myStrCarNo = Value
            End Set
        End Property
        Public Property StrCarSerialNo() As String
            Get
                Return myStrCarSerialNo.Trim()
            End Get
            Set(ByVal Value As String)
                myStrCarSerialNo = Value
            End Set
        End Property
        Public Property nIdCity() As String
            Get
                Return mynIdCity.Trim()
            End Get
            Set(ByVal Value As String)
                mynIdCity = Value
            End Set
        End Property
#End Region
#Region "Subroutins And Functions"
        Public Function GetCarPelakSerialComposit() As String
            Return StrCarNo.Trim & "-" & StrCarSerialNo.Trim
        End Function
#End Region



    End Class

    Public Class R2CoreParkingSystemInstanceCarsManager
        Public Function GetNSSCar(YournIdCar As String) As R2StandardCarStructure
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from dbtransport.dbo.TbCar Where nIdCar=" & YournIdCar & "")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardCarStructure = New R2StandardCarStructure
                    NSS.nIdCar = Ds.Tables(0).Rows(0).Item("nIdCar")
                    NSS.snCarType = Ds.Tables(0).Rows(0).Item("snCarType")
                    NSS.StrCarNo = Ds.Tables(0).Rows(0).Item("StrCarNo")
                    NSS.StrCarSerialNo = Ds.Tables(0).Rows(0).Item("StrCarSerialNo")
                    NSS.nIdCity = Ds.Tables(0).Rows(0).Item("nIdCity")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetnIdCarFromCardId(YourCardId As String) As Int64
            Try
                Dim Da As New SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 nCarId from R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Where (CardId='" & YourCardId & "') and (RelationActive=1) and ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) or (RelationTimeStamp='2015-01-01 00:00:00.000')) Order By RelationId Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("nCarId")
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetnIdPersonFirst(YournIdCar As Int64) As Int64
            Try
                Dim da As New SqlDataAdapter : Dim ds As New DataSet
                da.SelectCommand = New SqlCommand("Select Top 1 nIdPerson from dbtransport.dbo.TbCarAndPerson where (nIdCar=" & YournIdCar & ") and (snRelation=2) And ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) Or (RelationTimeStamp='2015-01-01 00:00:00.000')) Order By nIDCarAndPerson Desc")
                da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                ds.Tables.Clear()
                If da.Fill(ds) <> 0 Then
                    Return ds.Tables(0).Rows(0).Item("nIdPerson")
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetCardIdFromnIdCar(YournCarId As Int64) As Int64
            Try
                Dim Da As New SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CardId from R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Where (nCarId=" & YournCarId & ") and (RelationActive=1) and ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) or (RelationTimeStamp='2015-01-01 00:00:00.000')) Order By RelationId Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("CardId")
                Else
                    Throw New RelatedTerraficCardNotFoundException
                End If
            Catch ex As RelatedTerraficCardNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreParkingSystemMClassCars

        Private Shared _DateTime As New R2DateTime
        Private Shared _R2PrimaryFSWS As R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()

        Public Shared Function IsExistCar(YourNSS As R2StandardCarStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select StrCarNo,StrCarSerialNo from dbtransport.dbo.TbCar Where StrCarNo='" & YourNSS.StrCarNo & "' and StrCarSerialNo='" & YourNSS.StrCarSerialNo & "' and nIdCity=" & YourNSS.nIdCity & "", 1, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSCar(YournIdCar As String) As R2StandardCarStructure
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from dbtransport.dbo.TbCar Where nIdCar=" & YournIdCar & "")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardCarStructure = New R2StandardCarStructure
                    NSS.nIdCar = Ds.Tables(0).Rows(0).Item("nIdCar")
                    NSS.snCarType = Ds.Tables(0).Rows(0).Item("snCarType")
                    NSS.StrCarNo = Ds.Tables(0).Rows(0).Item("StrCarNo")
                    NSS.StrCarSerialNo = Ds.Tables(0).Rows(0).Item("StrCarSerialNo")
                    NSS.nIdCity = Ds.Tables(0).Rows(0).Item("nIdCity")
                    Return NSS
                Else
                    Throw New RelatedTerraficCardNotFoundException
                End If
            Catch exx As RelatedTerraficCardNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function InsertCar(YourNSS As R2StandardCarStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                ''If IsExistCar(YourNSS) = True Then Throw New Exception("خودرو با مشخصات مورد نظر قبلا ثبت شده است")
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Select top 1 * from dbtransport.dbo.tbcar with (tablockx)" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Select IDENT_CURRENT('dbtransport.dbo.tbCar')"
                Dim mynIdCar As Int64 = CmdSql.ExecuteScalar + 1
                CmdSql.CommandText = "Insert Into dbtransport.dbo.tbCar(snCarType,StrCarNo,StrCarSerialNo,nIdCity,StrBodyNo,nUserID,strFanniDate,ViewFlag) Values(" & YourNSS.snCarType & ",'" & YourNSS.StrCarNo & "','" & YourNSS.StrCarSerialNo & "'," & YourNSS.nIdCity & ",'" & mynIdCar & "'," & YourUserNSS.UserId & ",'" & _DateTime.GetCurrentDateShamsiFull & "',1)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Return mynIdCar
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UpdateCar(YourNSS As R2StandardCarStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                Dim mynIdCar As Int64 = YourNSS.nIdCar
                CmdSql.CommandText = "Update dbtransport.dbo.tbCar Set snCarType=" & YourNSS.snCarType & ",StrCarNo='" & YourNSS.StrCarNo & "',StrCarSerialNo='" & YourNSS.StrCarSerialNo & "',nIdCity=" & YourNSS.nIdCity & " Where nIdCar=" & mynIdCar & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeleteCar(YourNSS As R2StandardCarStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                Dim mynIdCar As Int64 = YourNSS.nIdCar
                CmdSql.CommandText = "Delete dbtransport.dbo.tbCar Where nIdCar=" & mynIdCar & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetnIdCarFromCardId(YourCardId As String) As Int64
            Try
                Dim Da As New SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 nCarId from R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Where (CardId='" & YourCardId & "') and (RelationActive=1) and ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) or (RelationTimeStamp='2015-01-01 00:00:00.000')) Order By RelationId Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("nCarId")
                Else
                    Throw New R2CoreParkingSystemRelatedCarNotExistException
                End If
            Catch ex As R2CoreParkingSystemRelatedCarNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCardIdFromnIdCar(YournCarId As Int64) As Int64
            Try
                Dim Da As New SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CardId from R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Where (nCarId=" & YournCarId & ") and (RelationActive=1) and ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) or (RelationTimeStamp='2015-01-01 00:00:00.000')) Order By RelationId Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("CardId")
                Else
                    Throw New RelatedTerraficCardNotFoundException
                End If
            Catch ex As RelatedTerraficCardNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetnIdPersonFirst(YournIdCar As Int64) As Int64
            Try
                Dim da As New SqlDataAdapter : Dim ds As New DataSet
                da.SelectCommand = New SqlCommand("Select Top 1 nIdPerson from dbtransport.dbo.TbCarAndPerson where (nIdCar=" & YournIdCar & ") and (snRelation=2) And ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) Or (RelationTimeStamp='2015-01-01 00:00:00.000')) Order By nIDCarAndPerson Desc")
                da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                ds.Tables.Clear()
                If da.Fill(ds) <> 0 Then
                    Return ds.Tables(0).Rows(0).Item("nIdPerson")
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetnIdPersonSecond(YournIdCar As Int64) As Int64
            Try
                Dim da As New SqlDataAdapter : Dim ds As New DataSet
                da.SelectCommand = New SqlCommand("Select Top 1 nIdPerson from dbtransport.dbo.TbCarAndPerson where (nIdCar=" & YournIdCar & ") and (snRelation=3) And ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) Or (RelationTimeStamp='2015-01-01 00:00:00.000'))  Order By nIDCarAndPerson Desc")
                da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                ds.Tables.Clear()
                If da.Fill(ds) <> 0 Then
                    Return ds.Tables(0).Rows(0).Item("nIdPerson")
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetnIdCar(YourLP As R2StandardLicensePlateStructure) As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 nIdCar from dbtransport.dbo.TbCar Where StrCarNo='" & YourLP.Pelak & "' and StrCarSerialNo='" & YourLP.Serial & "' and nIdCity=" & R2CoreParkingSystemMClassCitys.GetnCityCodeFromStrCityName(YourLP.City) & " Order By nIdCar Desc")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("nIdCar")
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Shared Sub MakeRelationCarAndPerson(ByVal YourSepasCarId As Int64, ByVal YourPersonId As Int64)
        '    Dim CmdSql As New SqlClient.SqlCommand
        '    CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
        '    Try
        '        CmdSql.CommandText = "Insert Into dbtransport.dbo.tbcarandperson(nidcar,nidperson,snrelation,ddate) Values(" & YourSepasCarId & "," & YourPersonId & ",2,'" & _DateTime.GetCurrentDateShamsiFull & "')"
        '        CmdSql.Connection.Open()
        '        CmdSql.ExecuteNonQuery()
        '        CmdSql.Connection.Close()
        '    Catch ex As Exception
        '        If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Sub

        Public Shared Sub CreateCar(ByVal YourLP As R2StandardLicensePlateStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.CommandText = "Insert into dbtransport.dbo.tbcar(sncartype,strcarno,strcarserialno,nidcity,strbodyno,nuserid) values(505,'" & YourLP.Pelak & "','" & YourLP.Serial & "',99960000,'" & "موقت" & "',9999)"
                CmdSql.Connection.Open()
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetCarEnterExitImage(YourNSSCar As R2StandardCarStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
            Try
                Dim _NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSCar.nIdCar))
                Dim CarImage As R2CoreImage
                Try
                    CarImage = GetCarImage(New R2CoreFile(R2CoreParkingSystemMClassEnterExitManagement.GetCarLastEnterExitId(_NSSTerafficCard).ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 2)), YourNSSUser)
                    Return CarImage
                Catch ex As CarHasNoEnterExitRecordException
                Catch exx As R2CoreParkingSystemCarImageNotExistException
                End Try
                If _NSSTerafficCard.CardType = TerafficCardType.Savari Then
                    Return New R2CoreImage(My.Resources.DefaultCarImageSavari)
                ElseIf _NSSTerafficCard.CardType = TerafficCardType.Tereili Then
                    Return New R2CoreImage(My.Resources.DefaultCarImageTereilli)
                ElseIf _NSSTerafficCard.CardType = TerafficCardType.SixCharkh Or _NSSTerafficCard.CardType = TerafficCardType.TenCharkh Then
                    Return New R2CoreImage(My.Resources.DefaultCarImageTereilli)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCarEnterExitImage(YourNSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
            Try
                Dim CarImage As R2CoreImage
                Try
                    CarImage = GetCarImage(New R2CoreFile(R2CoreParkingSystemMClassEnterExitManagement.GetCarLastEnterExitId(YourNSSTerraficCard).ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 2)), YourNSSUser)
                    Return CarImage
                Catch exx As R2CoreParkingSystemCarImageNotExistException
                    If YourNSSTerraficCard.CardType = TerafficCardType.Savari Then
                        Return New R2CoreImage(My.Resources.DefaultCarImageSavari)
                    ElseIf YourNSSTerraficCard.CardType = TerafficCardType.Tereili Then
                        Return New R2CoreImage(My.Resources.DefaultCarImageTereilli)
                    ElseIf YourNSSTerraficCard.CardType = TerafficCardType.SixCharkh Or YourNSSTerraficCard.CardType = TerafficCardType.TenCharkh Then
                        Return New R2CoreImage(My.Resources.DefaultCarImageTereilli)
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCarEnterExitImage(YourNSSEnterExit As R2StandardEnterExitStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
            Try
                Dim CarImage As R2CoreImage
                Try
                    CarImage = GetCarImage(New R2CoreFile(YourNSSEnterExit.EnterExitId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 2)), YourNSSUser)
                    Return CarImage
                Catch exx As R2CoreParkingSystemCarImageNotExistException
                    Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure
                    NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourNSSEnterExit.CardNoEnter)
                    If NSSTerafficCard.CardType = TerafficCardType.Savari Then
                        Return New R2CoreImage(My.Resources.DefaultCarImageSavari)
                    ElseIf NSSTerafficCard.CardType = TerafficCardType.Tereili Then
                        Return New R2CoreImage(My.Resources.DefaultCarImageTereilli)
                    ElseIf NSSTerafficCard.CardType = TerafficCardType.SixCharkh Or NSSTerafficCard.CardType = TerafficCardType.TenCharkh Then
                        Return New R2CoreImage(My.Resources.DefaultCarImageTereilli)
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub SaveCarEnterExitImage(YourCarImage As R2CoreImage, YourNSSEnterExit As R2StandardEnterExitStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Try
                SaveCarImage(YourCarImage, New R2CoreFile(YourNSSEnterExit.EnterExitId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 2)), YourNSSUser)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared Sub SaveCarImage(YourCarImage As R2CoreImage, YourFileInf As R2CoreFile, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Try
                _R2PrimaryFSWS.WebMethodSaveFile(R2CoreParkingSystemRawGroups.CarImages, YourFileInf.FileName, YourCarImage.GetImageByte(), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared Function GetCarImage(YourFileInf As R2CoreFile, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
            Try
                If _R2PrimaryFSWS.WebMethodIOFileExist(R2CoreParkingSystemRawGroups.CarImages, YourFileInf.FileName, _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword)) = True Then
                    Return New R2CoreImage(_R2PrimaryFSWS.WebMethodGetFile(R2CoreParkingSystemRawGroups.CarImages, YourFileInf.FileName, _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword)))
                Else
                    Throw New R2CoreParkingSystemCarImageNotExistException
                End If
            Catch exx As R2CoreParkingSystemCarImageNotExistException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub CreateRelationBetweenTerafficCardAndCar(YourNSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourNSSCar As R2StandardCarStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Set RelationActive=0 Where CardId=" & YourNSSTerraficCard.CardId & " or nCarId=" & YourNSSCar.nIdCar & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert into R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars(CardId,nCarId,RelationActive,RelationTimeStamp) Values(" & YourNSSTerraficCard.CardId & "," & YourNSSCar.nIdCar & ",1,'2015-01-01 00:00:00.000')"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
    End Class

    Public Class CarNotExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "خودروی مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class DuplicateCarExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "خودرو با مشخصات مورد نظر قبلا وجود دارد"
            End Get
        End Property
    End Class

    Public Class R2CoreParkingSystemCarImageNotExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "تصویر خودروی مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class R2CoreParkingSystemRelatedCarNotExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "اطلاعات خودروی مرتبط با کارت تردد یافت نشد" + vbCrLf + "به واحد ثبت مشخصات مراجعه نمایید"
            End Get
        End Property
    End Class


End Namespace

Namespace CarType

    Public Class R2CoreParkingSystemCarTypeManager

        Public Function GetCarTypeNameFromsnCarType(YourCarType As String) As String
            Try
                Dim Ds As New DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCarName from dbtransport.dbo.TbCarType Where snCarType=" & YourCarType & "", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreParkingSystemMClassCarType

        Public Shared TereiliKafiCode As String = "505"

        Public Shared Function GetDSCarType() As DataSet
            Try
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCarName from dbtransport.dbo.TbCarType Order by StrCarName", 1000, Ds)
                Return Ds
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCarTypeNameFromsnCarType(YourCarType As String) As String
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCarName from dbtransport.dbo.TbCarType Where snCarType=" & YourCarType & "", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetsnCarTypeFromStrCarName(YourCarName As String) As String
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select top 1 snCarType from dbtransport.dbo.TbCarType Where StrCarName='" & YourCarName & "'", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function




    End Class
End Namespace

Namespace BlackList

    Public Class R2StandardBlackListStructure
        Private _nId As Int64
        Private _nTruckNo As String
        Private _nPlakSerial As String
        Private _nPlakPlac As Int64
        Private _StrDesc As String
        Private _FlagA As Boolean
        Private _nAmount As Int64
        Private _StrDate As String
        Private _nUser As Int64

        Public Sub New()
            MyBase.New()
            _nId = 0 : _nTruckNo = "" : _nPlakSerial = "" : _nPlakPlac = 0 : _StrDesc = "" : _FlagA = True : _nAmount = 0 : _StrDate = "" : _nUser = 0
        End Sub

        Public Sub New(ByVal YournId As Int64, ByVal YournTruckNo As String, YournPlakSerial As String, YourPlakPlac As Int64, YourStrDesc As String, YourFlagA As Boolean, YournAmount As Int64, YourStrDate As String, YournUser As Int64)
            _nId = YournId
            _nTruckNo = YournTruckNo
            _nPlakSerial = YournPlakSerial
            _nPlakPlac = YourPlakPlac
            _StrDesc = YourStrDesc
            _FlagA = YourFlagA
            _nAmount = YournAmount
            _StrDate = YourStrDate
            _nUser = YournUser
        End Sub

        Public Property nId() As Int64
            Get
                Return _nId
            End Get
            Set(ByVal Value As Int64)
                _nId = Value
            End Set
        End Property
        Public Property nTruckNo() As String
            Get
                Return _nTruckNo
            End Get
            Set(ByVal Value As String)
                _nTruckNo = Value
            End Set
        End Property
        Public Property nPlakSerial() As String
            Get
                Return _nPlakSerial
            End Get
            Set(ByVal Value As String)
                _nPlakSerial = Value
            End Set
        End Property
        Public Property nPlakPlac() As Int64
            Get
                Return _nPlakPlac
            End Get
            Set(ByVal Value As Int64)
                _nPlakPlac = Value
            End Set
        End Property
        Public Property StrDesc() As String
            Get
                Return _StrDesc
            End Get
            Set(ByVal Value As String)
                _StrDesc = Value
            End Set
        End Property
        Public Property FlagA() As Boolean
            Get
                Return _FlagA
            End Get
            Set(ByVal Value As Boolean)
                _FlagA = Value
            End Set
        End Property
        Public Property nAmount() As Int64
            Get
                Return _nAmount
            End Get
            Set(ByVal Value As Int64)
                _nAmount = Value
            End Set
        End Property
        Public Property StrDate() As String
            Get
                Return _StrDate
            End Get
            Set(ByVal Value As String)
                _StrDate = Value
            End Set
        End Property
        Public Property nUser() As Int64
            Get
                Return _nUser
            End Get
            Set(ByVal Value As Int64)
                _nUser = Value
            End Set
        End Property


    End Class

    Public Class R2CoreParkingSystemInstanceBlackListManager
        Private _DateTime As New R2DateTime

        Public Enum R2CoreParkingSystemBlackListType
            None = 0
            AllBlackLists = 1
            ActiveBlackLists = 2
        End Enum

        Public Function GetBlackList(YourNSSCar As R2StandardCarStructure, YourBlackListType As R2CoreParkingSystemBlackListType) As List(Of R2StandardBlackListStructure)
            Try
                Dim InstanceSqlDataBox = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                Dim Ds As DataSet
                If YourBlackListType = R2CoreParkingSystemBlackListType.ActiveBlackLists Then
                    InstanceSqlDataBox.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbBlackList Where ltrim(rtrim(nTruckNo))='" & YourNSSCar.StrCarNo & "' and ltrim(rtrim(nPlakSerial))='" & YourNSSCar.StrCarSerialNo & "' and nPlakPlac=" & YourNSSCar.nIdCity & " and flaga=0 Order By nId Desc", 1, Ds)
                ElseIf YourBlackListType = R2CoreParkingSystemBlackListType.AllBlackLists Then
                    InstanceSqlDataBox.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbBlackList Where ltrim(rtrim(nTruckNo))='" & YourNSSCar.StrCarNo & "' and ltrim(rtrim(nPlakSerial))='" & YourNSSCar.StrCarSerialNo & "' and nPlakPlac=" & YourNSSCar.nIdCity & " Order By nId Desc", 1, Ds)
                Else
                    Return Nothing
                End If

                Dim Lst As List(Of R2StandardBlackListStructure) = New List(Of R2StandardBlackListStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2StandardBlackListStructure(Ds.Tables(0).Rows(Loopx).Item("nId"), Ds.Tables(0).Rows(Loopx).Item("nTruckNo"), Ds.Tables(0).Rows(Loopx).Item("nPlakSerial"), Ds.Tables(0).Rows(Loopx).Item("nPlakPlac"), Ds.Tables(0).Rows(Loopx).Item("StrDesc"), Ds.Tables(0).Rows(Loopx).Item("FlagA"), Ds.Tables(0).Rows(Loopx).Item("nAmount"), IIf(Object.Equals(Ds.Tables(0).Rows(Loopx).Item("StrDate"), DBNull.Value), "", Ds.Tables(0).Rows(Loopx).Item("StrDate")), IIf(Object.Equals(Ds.Tables(0).Rows(Loopx).Item("nUser"), DBNull.Value), InstanceSoftwareUsers.GetNSSSystemUser.UserId, Ds.Tables(0).Rows(Loopx).Item("nUser"))))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function HasCarBlackList(YourNSSCar As R2StandardCarStructure, ByRef YourNSSBlackList As R2StandardBlackListStructure) As Boolean
            Try
                Dim InstanceSqlDataBox = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                Dim Ds As DataSet
                If InstanceSqlDataBox.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "
                  Select Top 1 * from dbtransport.dbo.TbBlackList Where ltrim(rtrim(nTruckNo))='" & YourNSSCar.StrCarNo & "' 
                     and ltrim(rtrim(nPlakSerial))='" & YourNSSCar.StrCarSerialNo & "' and 
                     nPlakPlac=" & YourNSSCar.nIdCity & " and flaga=0 Order By nId Desc", 3600, Ds).GetRecordsCount <> 0 Then
                    YourNSSBlackList = New R2StandardBlackListStructure(Ds.Tables(0).Rows(0).Item("nId"), Ds.Tables(0).Rows(0).Item("nTruckNo"), Ds.Tables(0).Rows(0).Item("nPlakSerial"), Ds.Tables(0).Rows(0).Item("nPlakPlac"), Ds.Tables(0).Rows(0).Item("StrDesc"), Ds.Tables(0).Rows(0).Item("FlagA"), Ds.Tables(0).Rows(0).Item("nAmount"), IIf(Object.Equals(Ds.Tables(0).Rows(0).Item("StrDate"), DBNull.Value), "", Ds.Tables(0).Rows(0).Item("StrDate")), IIf(Object.Equals(Ds.Tables(0).Rows(0).Item("nUser"), DBNull.Value), InstanceSoftwareUsers.GetNSSSystemUser.UserId, Ds.Tables(0).Rows(0).Item("nUser")))
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreParkingSystemMClassBlackList

        Private Shared _DateTime As New R2DateTime

        Public Enum R2CoreParkingSystemBlackListType
            None = 0
            AllBlackLists = 1
            ActiveBlackLists = 2
        End Enum

        Public Shared Function GetBlackList(YourNSSCar As R2StandardCarStructure, YourBlackListType As R2CoreParkingSystemBlackListType) As List(Of R2StandardBlackListStructure)
            Try
                Dim Ds As DataSet
                If YourBlackListType = R2CoreParkingSystemBlackListType.ActiveBlackLists Then
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbBlackList Where ltrim(rtrim(nTruckNo))='" & YourNSSCar.StrCarNo & "' and ltrim(rtrim(nPlakSerial))='" & YourNSSCar.StrCarSerialNo & "' and nPlakPlac=" & YourNSSCar.nIdCity & " and flaga=0 Order By nId Desc", 1, Ds)
                ElseIf YourBlackListType = R2CoreParkingSystemBlackListType.AllBlackLists Then
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbBlackList Where ltrim(rtrim(nTruckNo))='" & YourNSSCar.StrCarNo & "' and ltrim(rtrim(nPlakSerial))='" & YourNSSCar.StrCarSerialNo & "' and nPlakPlac=" & YourNSSCar.nIdCity & " Order By nId Desc", 1, Ds)
                Else
                    Return Nothing
                End If

                Dim Lst As List(Of R2StandardBlackListStructure) = New List(Of R2StandardBlackListStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2StandardBlackListStructure(Ds.Tables(0).Rows(Loopx).Item("nId"), Ds.Tables(0).Rows(Loopx).Item("nTruckNo"), Ds.Tables(0).Rows(Loopx).Item("nPlakSerial"), Ds.Tables(0).Rows(Loopx).Item("nPlakPlac"), Ds.Tables(0).Rows(Loopx).Item("StrDesc"), Ds.Tables(0).Rows(Loopx).Item("FlagA"), Ds.Tables(0).Rows(Loopx).Item("nAmount"), IIf(Object.Equals(Ds.Tables(0).Rows(Loopx).Item("StrDate"), DBNull.Value), "", Ds.Tables(0).Rows(Loopx).Item("StrDate")), IIf(Object.Equals(Ds.Tables(0).Rows(Loopx).Item("nUser"), DBNull.Value), R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser.UserId, Ds.Tables(0).Rows(Loopx).Item("nUser"))))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCompositBlackList(YourNSSCar As R2StandardCarStructure) As String
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select StrDesc from dbtransport.dbo.TbBlackList Where nTruckNo='" & YourNSSCar.StrCarNo & "' and nPlakSerial='" & YourNSSCar.StrCarSerialNo & "' and nPlakPlac=" & YourNSSCar.nIdCity & " and flaga=0 Order By StrDate Desc", 1, Ds).GetRecordsCount = 0 Then Return String.Empty
                Dim SB As StringBuilder = New StringBuilder()
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    SB.Append(Ds.Tables(0).Rows(Loopx).Item("StrDesc").trim).AppendLine()
                Next
                Return SB.ToString()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ChangeBlackListMblgh(YourNSSBlackList As R2StandardBlackListStructure, YourNewAmount As Int64, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbBlackList Set nAmount=" & YourNewAmount & ",StrDate='" & _DateTime.GetCurrentDateShamsiFull() & "',nUser=" & YourUserNSS.UserId & " Where nId=" & YourNSSBlackList.nId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "مبلغ تخلف برای لیست سیاه خودرو تغییر یافت" + vbCrLf + YourNSSBlackList.nId.ToString() + vbCrLf + YourNewAmount.ToString(), 0, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

End Namespace

Namespace Drivers
    Public Class R2StandardDriverStructure
        Inherits BaseStandardClass.R2StandardStructure

        Private mynIdPerson As String
        Private myStrPersonFullName As String
        Private myStrNationalCode As String
        Private myStrFatherName As String
        Private myStrAddress As String
        Private mystrDrivingLicenceNo As String
        'تلفن
        Private myStrIdNo As String



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            mynIdPerson = "" : myStrPersonFullName = "" : myStrNationalCode = "" : myStrFatherName = "" : myStrAddress = "" : mystrDrivingLicenceNo = "" : myStrIdNo = ""
        End Sub

        Public Sub New(ByVal nIdPersonn As String, ByVal StrPersonFullNamee As String, ByVal StrNationalCodee As String, ByVal StrFatherNamee As String, ByVal StrAddresss As String, ByVal StrIdNoo As String, ByVal strDrivingLicenceNoo As String)
            MyBase.New(nIdPersonn, StrPersonFullNamee)
            mynIdPerson = nIdPersonn
            myStrPersonFullName = StrPersonFullNamee
            myStrNationalCode = StrNationalCodee
            myStrFatherName = StrFatherNamee
            myStrAddress = StrAddresss
            myStrIdNo = StrIdNoo
            mystrDrivingLicenceNo = strDrivingLicenceNoo
        End Sub
#End Region
#Region "Properting Management"
        Public Property nIdPerson() As String
            Get
                Return mynIdPerson
            End Get
            Set(ByVal Value As String)
                mynIdPerson = Value
            End Set
        End Property
        Public Property StrPersonFullName() As String
            Get
                Return myStrPersonFullName.Trim()
            End Get
            Set(ByVal Value As String)
                myStrPersonFullName = Value
            End Set
        End Property
        Public Property StrNationalCode() As String
            Get
                Return myStrNationalCode.Trim()
            End Get
            Set(ByVal Value As String)
                myStrNationalCode = Value
            End Set
        End Property
        Public Property StrFatherName() As String
            Get
                Return myStrFatherName.Trim()
            End Get
            Set(ByVal Value As String)
                myStrFatherName = Value
            End Set
        End Property
        Public Property StrAddress() As String
            Get
                Return myStrAddress.Trim()
            End Get
            Set(ByVal Value As String)
                myStrAddress = Value
            End Set
        End Property
        Public Property StrIdNo() As String
            Get
                Return myStrIdNo.Trim()
            End Get
            Set(ByVal Value As String)
                myStrIdNo = Value
            End Set
        End Property
        Public Property strDrivingLicenceNo() As String
            Get
                Return mystrDrivingLicenceNo.Trim()
            End Get
            Set(ByVal Value As String)
                mystrDrivingLicenceNo = Value
            End Set
        End Property

#End Region


    End Class

    Public Class R2CoreParkingSystemDriverNationalCode
        Public Sub New(YourDriverNationalCode As String)
            DriverNationalCode = YourDriverNationalCode
        End Sub

        Public DriverNationalCode As String

    End Class

    Public Class R2CoreParkingSystemInstanceDriversManager
        Public Function GetNSSDriver(YournIdPerson As String) As R2StandardDriverStructure
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver Where P.nIdPerson=" & YournIdPerson & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardDriverStructure = New R2StandardDriverStructure
                    NSS.nIdPerson = Ds.Tables(0).Rows(0).Item("nIdPerson")
                    NSS.StrPersonFullName = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                    NSS.StrNationalCode = Ds.Tables(0).Rows(0).Item("StrNationalCode")
                    NSS.StrFatherName = Ds.Tables(0).Rows(0).Item("StrFatherName")
                    NSS.StrAddress = Ds.Tables(0).Rows(0).Item("StrAddress")
                    NSS.StrIdNo = Ds.Tables(0).Rows(0).Item("StrIdNo") 'تلفن
                    NSS.strDrivingLicenceNo = Ds.Tables(0).Rows(0).Item("strDrivingLicenceNo")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreParkingSystemMClassDrivers

        Private Shared _R2PrimaryFSWS As R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()

        Public Shared Function IsExistDriver(YourNSS As R2StandardDriverStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select P.StrPersonFullName from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIdPerson=D.nIdDriver Where P.StrNationalCode='" & YourNSS.StrNationalCode & "' Or D.StrDrivingLicenceNo='" & YourNSS.strDrivingLicenceNo & "'", 1, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSDriver(YournIdPerson As String) As R2StandardDriverStructure
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver Where P.nIdPerson=" & YournIdPerson & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardDriverStructure = New R2StandardDriverStructure
                    NSS.nIdPerson = Ds.Tables(0).Rows(0).Item("nIdPerson")
                    NSS.StrPersonFullName = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                    NSS.StrNationalCode = Ds.Tables(0).Rows(0).Item("StrNationalCode")
                    NSS.StrFatherName = Ds.Tables(0).Rows(0).Item("StrFatherName")
                    NSS.StrAddress = Ds.Tables(0).Rows(0).Item("StrAddress")
                    NSS.StrIdNo = Ds.Tables(0).Rows(0).Item("StrIdNo") 'تلفن
                    NSS.strDrivingLicenceNo = Ds.Tables(0).Rows(0).Item("strDrivingLicenceNo")
                    Return NSS
                Else
                    Throw New DriverNotFoundException
                End If
            Catch exx As DriverNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ExistDriver(YourNationalCode As R2CoreParkingSystemDriverNationalCode) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                  "Select strNationalCode from dbtransport.dbo.TbPerson as P 
                                     inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver 
                                   Where P.strNationalCode='" & YourNationalCode.DriverNationalCode & "'", 0, DS).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function InsertDriver(YourNSS As R2StandardDriverStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Select top 1 * from dbtransport.dbo.tbperson with (tablockx)" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Select IDENT_CURRENT('dbtransport.dbo.tbperson')"
                Dim mynIdPerson As Int64 = CmdSql.ExecuteScalar + 1
                CmdSql.CommandText = "Insert Into dbtransport.dbo.tbPerson(strPersonName,strpersonFamily,strIDNO,strNationalCode,strFatherName,strAddress) Values('" & YourNSS.StrPersonFullName & "','','" & YourNSS.StrIdNo & "','" & YourNSS.StrNationalCode & "','" & YourNSS.StrFatherName & "','" & YourNSS.StrAddress & "')"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbDriver(nIDDriver,StrDriverCode,strDrivingLicenceNo,strSmartcardNo) Values(" & mynIdPerson & ",0,'" & YourNSS.strDrivingLicenceNo & "','" & mynIdPerson & "')"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Dim NSSDriver = R2CoreParkingSystemMClassDrivers.GetNSSDriver(mynIdPerson)
                Dim UserId = R2CoreMClassSoftwareUsersManagement.RegisteringSoftwareUser(New R2CoreStandardSoftwareUserStructure(Nothing, Nothing, Nothing, NSSDriver.StrPersonFullName, Nothing, Nothing, Nothing, String.Empty, False, True, R2CoreParkingSystemSoftwareUserTypes.Driver, NSSDriver.StrIdNo, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, YourUserNSS.UserId, Nothing, Nothing, True, Nothing), YourUserNSS)
                R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver, UserId, NSSDriver.nIdPerson, Nothing), RelationDeactiveTypes.BothDeactive)
                'به دست آوردن لیست فرآیندهای موبایلی قابل دسترسی برای نوع کاربر راننده و ارسال به مدیریت مجوز
                Dim ComposeSearchString As String = R2CoreParkingSystemSoftwareUserTypes.Driver.ToString + ":"
                Dim AllofSoftwareUserTypes1 As String() = Split(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SoftwareUserTypesAccessMobileProcesses), ";")
                If Mid(AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length) <> String.Empty Then
                    Dim AllofMobileProcessesIds As String() = Split(Mid(AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), ",")
                    R2CoreMClassPermissionsManagement.RegisteringPermissions(R2CorePermissionTypes.SoftwareUsersAccessMobileProcesses, UserId, AllofMobileProcessesIds)
                End If
                'به دست آوردن لیست گروههای فرآیند موبایلی برای نوع کاربر راننده و ارسال آن به مدیریت روابط نهادی
                Dim AllofSoftwareUserTypes2 As String() = Split(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SoftwareUserTypesRelationMobileProcessGroups), ";")
                If Mid(AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length) <> String.Empty Then
                    Dim AllofMobileProcessGroupsIds As String() = Split(Mid(AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), ",")
                    R2CoreMClassEntityRelationManagement.RegisteringEntityRelations(R2CoreEntityRelationTypes.SoftwareUser_MobileProcessGroup, UserId, AllofMobileProcessGroupsIds)
                End If
                Return mynIdPerson
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UpdateDriver(YourNSS As R2StandardDriverStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                Dim mynIdPerson As Int64 = YourNSS.nIdPerson
                CmdSql.CommandText = "Update dbtransport.dbo.tbPerson Set strPersonName='" & YourNSS.StrPersonFullName & "',StrPersonFamily='',strIDNO='" & YourNSS.StrIdNo & "',strNationalCode='" & YourNSS.StrNationalCode & "',strFatherName='" & YourNSS.StrFatherName & "',strAddress='" & YourNSS.StrAddress & "' Where nIdPerson=" & mynIdPerson & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update dbtransport.dbo.TbDriver Set strDrivingLicenceNo='" & YourNSS.strDrivingLicenceNo & "' Where nIdDriver=" & mynIdPerson & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

                Dim NSSUser As R2CoreStandardSoftwareUserStructure
                Try
                    NSSUser = R2CoreParkingSystemMClassSoftwareUsersManagement.GetNSSSoftwareUser(mynIdPerson)
                    R2CoreMClassSoftwareUsersManagement.EditingSoftwareUser(New R2CoreStandardSoftwareUserStructure(NSSUser.UserId, Nothing, Nothing, YourNSS.StrPersonFullName, Nothing, Nothing, Nothing, NSSUser.UserPinCode, NSSUser.UserCanCharge, True, NSSUser.UserTypeId, YourNSS.StrIdNo, NSSUser.UserStatus, String.Empty, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, YourNSSUser.UserId, Nothing, Nothing, NSSUser.ViewFlag, NSSUser.Deleted), YourNSSUser)
                Catch ex As SoftwareUserRelatedThisDriverNotFoundException
                    Dim NSSDriverTemp = R2CoreParkingSystemMClassDrivers.GetNSSDriver(YourNSS.nIdPerson)
                    Dim UserId = R2CoreMClassSoftwareUsersManagement.RegisteringSoftwareUser(New R2CoreStandardSoftwareUserStructure(Nothing, Nothing, Nothing, NSSDriverTemp.StrPersonFullName, Nothing, Nothing, Nothing, String.Empty, False, True, R2CoreParkingSystemSoftwareUserTypes.Driver, NSSDriverTemp.StrIdNo, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, YourNSSUser.UserId, Nothing, Nothing, True, Nothing), YourNSSUser)
                    R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver, UserId, NSSDriverTemp.nIdPerson, Nothing), RelationDeactiveTypes.BothDeactive)
                    'به دست آوردن لیست فرآیندهای موبایلی قابل دسترسی برای نوع کاربر راننده و ارسال به مدیریت مجوز
                    Dim ComposeSearchString As String = R2CoreParkingSystemSoftwareUserTypes.Driver.ToString + ":"
                    Dim AllofSoftwareUserTypes1 As String() = Split(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SoftwareUserTypesAccessMobileProcesses), ";")
                    Dim AllofMobileProcessesIds As String() = Split(Mid(AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), ",")
                    R2CoreMClassPermissionsManagement.RegisteringPermissions(R2CorePermissionTypes.SoftwareUsersAccessMobileProcesses, UserId, AllofMobileProcessesIds)
                    'به دست آوردن لیست گروههای فرآیند موبایلی برای نوع کاربر راننده و ارسال آن به مدیریت روابط نهادی
                    Dim AllofSoftwareUserTypes2 As String() = Split(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SoftwareUserTypesRelationMobileProcessGroups), ";")
                    Dim AllofMobileProcessGroupsIds As String() = Split(Mid(AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), ",")
                    R2CoreMClassEntityRelationManagement.RegisteringEntityRelations(R2CoreEntityRelationTypes.SoftwareUser_MobileProcessGroup, UserId, AllofMobileProcessGroupsIds)
                Catch ex As Exception
                    Throw ex
                End Try
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeleteDriver(YourNSS As R2StandardDriverStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                Dim mynIdPerson As Int64 = YourNSS.nIdPerson
                CmdSql.CommandText = "Delete dbtransport.dbo.tbPerson Where nIdPerson=" & mynIdPerson & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Delete dbtransport.dbo.TbDriver Where nIdDriver=" & mynIdPerson & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetNSSTempDriver() As R2StandardDriverStructure
            Return GetNSSDriver("98484") 'راننده موقت
        End Function

        Public Shared Function GetCountOfCarsSecondDriverAttached(YourNSSSecondDriver As R2StandardDriverStructure) As Int64
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "select Count(*) as CountX from dbtransport.dbo.TbCarAndPerson where (nIdPerson=" & YourNSSSecondDriver.nIdPerson & ") and (SnRelation=3) And ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) Or (RelationTimeStamp='2015-01-01 00:00:00.000'))", 1, Ds).GetRecordsCount() = 0 Then
                    Return 0
                Else
                    Return Ds.Tables(0).Rows(0).Item("CountX")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCountOfDriversAttachedCar(YourNSSCar As R2StandardCarStructure) As Int64
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "select Count(*) as CountX from dbtransport.dbo.TbCarAndPerson where (nIdCar=" & YourNSSCar.nIdCar & ") and (SnRelation=2 or SnRelation=3) And ((DATEDIFF(SECOND,RelationTimeStamp,getdate())<240) Or (RelationTimeStamp='2015-01-01 00:00:00.000'))", 1, Ds).GetRecordsCount() = 0 Then
                    Return 0
                Else
                    Return Ds.Tables(0).Rows(0).Item("CountX")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetDriverImage(YourNSSDriver As R2StandardDriverStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
            Try
                If _R2PrimaryFSWS.WebMethodIOFileExist(R2CoreParkingSystemRawGroups.DriverImages, YourNSSDriver.nIdPerson.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 1), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword)) = False Then
                    Throw New DriverImageNotExistException
                End If
                Return New R2CoreImage(_R2PrimaryFSWS.WebMethodGetFile(R2CoreParkingSystemRawGroups.DriverImages, YourNSSDriver.nIdPerson.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 1), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword)))
            Catch exx As DriverImageNotExistException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub SaveDriverImage(YourNSSDriver As R2StandardDriverStructure, YourDriverImage As R2CoreImage, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Try
                _R2PrimaryFSWS.WebMethodSaveFile(R2CoreParkingSystemRawGroups.DriverImages, YourNSSDriver.nIdPerson.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 1), YourDriverImage.GetImageByte(), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeleteDriverImage(YourNSSDriver As R2StandardDriverStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Try
                _R2PrimaryFSWS.WebMethodDeleteFile(R2CoreParkingSystemRawGroups.DriverImages, YourNSSDriver.nIdPerson.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 1), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Public Class DriverImageNothingException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "تصویر راننده مشخص نیست"
            End Get
        End Property
    End Class

    Public Class DriverImageCaptureException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "تصویر راننده آماده نیست"
            End Get
        End Property
    End Class

    Public Class DriverImageNotExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "تصویر راننده ثبت نشده است"
            End Get
        End Property
    End Class

    Public Class DriverNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "راننده با کد شاخص مورد نظر یافت نشد"
            End Get
        End Property
    End Class


End Namespace

Namespace City

    Public Class R2CoreParkingSystemCitysManager

        Public Function GetCityNameFromnCityCode(YourCityCode As String) As String
            Try
                Dim Ds As New DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCityName from dbtransport.dbo.TbCity Where nCityCode=" & YourCityCode & "", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreParkingSystemMClassCitys

        Public Shared IRANCityCode As String = "99960000"

        Public Shared Function GetNSSCity(YournCityCode As Int64) As R2StandardCityStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 * from dbtransport.dbo.TbCity Where nCityCode=" & YournCityCode & "", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Return New R2StandardCityStructure(Ds.Tables(0).Rows(0).Item("nCityCode"), Ds.Tables(0).Rows(0).Item("StrCityName").trim, Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDistance") / 25), Ds.Tables(0).Rows(0).Item("nProvince"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSCity(YourCityTitle As String) As R2StandardCityStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 * from dbtransport.dbo.TbCity Where strCityName like '%" & YourCityTitle.Trim() & "%'", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Return New R2StandardCityStructure(Ds.Tables(0).Rows(0).Item("nCityCode"), Ds.Tables(0).Rows(0).Item("StrCityName").trim, Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDistance") / 25), Ds.Tables(0).Rows(0).Item("nProvince"))
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Class R2StandardCityStructure
            Inherits BaseStandardClass.R2StandardStructure

            Private mynCityCode As Int64
            Private myStrCityName As String
            Private mynDistance As Int64
            Private mynProvince As Int64



#Region "Constructing Management"
            Public Sub New()
                MyBase.New()
                mynCityCode = 0 : myStrCityName = "" : mynDistance = 0 : mynProvince = 0
            End Sub

            Public Sub New(ByVal YournCityCode As Int64, ByVal YourStrCityName As String, ByVal YournDistance As Int64, ByVal YournProvince As Int64)
                MyBase.New(YournCityCode, YourStrCityName)
                mynCityCode = YournCityCode
                myStrCityName = YourStrCityName
                mynDistance = YournDistance
                mynProvince = YournProvince
            End Sub
#End Region
#Region "Properting Management"
            Public Property nCityCode() As Int64
                Get
                    Return mynCityCode
                End Get
                Set(ByVal Value As Int64)
                    mynCityCode = Value
                End Set
            End Property
            Public Property StrCityName() As String
                Get
                    Return myStrCityName.Trim()
                End Get
                Set(ByVal Value As String)
                    myStrCityName = Value
                End Set
            End Property
            Public Property nDistance() As Int64
                Get
                    Return mynDistance
                End Get
                Set(ByVal Value As Int64)
                    mynDistance = Value
                End Set
            End Property
            Public Property nProvince() As Int64
                Get
                    Return mynProvince
                End Get
                Set(ByVal Value As Int64)
                    mynProvince = Value
                End Set
            End Property

#End Region


        End Class

        Public Shared Function GetDSCity() As DataSet
            Try
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCityName from dbtransport.dbo.TbCity Order by StrCityName", 1000, Ds)
                Return Ds
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCityNameFromnCityCode(YourCityCode As String) As String
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCityName from dbtransport.dbo.TbCity Where nCityCode=" & YourCityCode & "", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetnCityCodeFromStrCityName(YourCityName As String) As String
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select top 1 nCityCode from dbtransport.dbo.TbCity Where Viewflag=1 and Deleted=0 and StrCityName='" & YourCityName & "'", 10, Ds).GetRecordsCount <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item(0)
                Else
                    Throw New GetDataException
                End If
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetListOfCitys_SearchIntroCharacters(YourSearchStr As String) As List(Of R2StandardCityStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSearchStr)
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbCity Where Viewflag=1 and Deleted=0 and StrCityNAME LIKE '%" & YourSearchStr.Replace("ی", "ي").Replace("ک", "ك") & "%' Order by StrCityName", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Dim Lst As List(Of R2StandardCityStructure) = New List(Of R2StandardCityStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As R2StandardCityStructure = New R2StandardCityStructure(Ds.Tables(0).Rows(Loopx).Item("nCityCode"), Ds.Tables(0).Rows(Loopx).Item("StrCityName").trim, Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nDistance") / 25), Ds.Tables(0).Rows(Loopx).Item("nProvince"))
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetListOfCitys_SearchforLeftCharacters(YourSearchStr As String) As List(Of R2StandardCityStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSearchStr)
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbCity Where Left(StrCityNAME," & YourSearchStr.Length & ")='" & YourSearchStr.Replace("ی", "ي").Replace("ک", "ك") & "' Order by StrCityName", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Dim Lst As List(Of R2StandardCityStructure) = New List(Of R2StandardCityStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As R2StandardCityStructure = New R2StandardCityStructure(Ds.Tables(0).Rows(Loopx).Item("nCityCode"), Ds.Tables(0).Rows(Loopx).Item("StrCityName").trim, Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nDistance") / 25), Ds.Tables(0).Rows(Loopx).Item("nProvince"))
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetListOfCitysWhichDistanceIsZero() As List(Of R2StandardCityStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * from dbtransport.dbo.TbCity Where nDistance=0 Order by StrCityName", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Dim Lst As List(Of R2StandardCityStructure) = New List(Of R2StandardCityStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As R2StandardCityStructure = New R2StandardCityStructure(Ds.Tables(0).Rows(Loopx).Item("nCityCode"), Ds.Tables(0).Rows(Loopx).Item("StrCityName").trim, Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nDistance") / 25), Ds.Tables(0).Rows(Loopx).Item("nProvince"))
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ChangeCityDistance(YourNSS As R2StandardCityStructure, YourDistance As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbTransport.dbo.TbCity Set nDistance=" & YourDistance * 25 & " Where nCityCode=" & YourNSS.nCityCode & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ChangeCityProvince(YourNSS As R2StandardCityStructure, YourProvince As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbTransport.dbo.TbCity Set nProvince=" & YourProvince & " Where nCityCode=" & YourNSS.nCityCode & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub



    End Class

End Namespace

Namespace DriverMonitor
    Public Class R2CoreParkingSystemDriverMonitorStructure

        Private myMaabarCode As String
        Private myCardId As String
        Private myCurrentCharge As Int64
        Private myMblgh As UInt64
        Private myReminderCharge As Int64
        Private myMessage As String
        Private myFontSize As Single
        Private myColor As Color
        Private myLP As R2StandardLicensePlateStructure = Nothing
        Private myChangeDateTime As DateTime

#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            myMaabarCode = "" : myCardId = "" : myCurrentCharge = 0 : myMblgh = 0 : myReminderCharge = 0 : myMessage = ""
            myFontSize = 0 : myColor = Color.White : myLP = Nothing : myChangeDateTime = Nothing
        End Sub
        Public Sub New(ByVal YourMaabarCode As String, ByVal YourCardId As String, ByVal YourCurrentCharge As Int64, ByVal YourMblgh As UInt64, ByVal YourReminderCharge As Int64, ByVal YourMessage As String, ByVal YourFontSize As Single, ByVal YourColor As Color, ByVal YourLP As R2StandardLicensePlateStructure, ByVal YourChangeDateTime As DateTime)
            myMaabarCode = YourMaabarCode
            myCardId = YourCardId
            myCurrentCharge = YourCurrentCharge
            myMblgh = YourMblgh
            myReminderCharge = YourReminderCharge
            myMessage = YourMessage
            myFontSize = YourFontSize
            myColor = YourColor
            myLP = YourLP
            myChangeDateTime = YourChangeDateTime
        End Sub
#End Region
#Region "Properting Management"
        Public Property MaabarCode() As String
            Get
                Return myMaabarCode
            End Get
            Set(ByVal Value As String)
                myMaabarCode = Value
            End Set
        End Property
        Public Property CardId() As String
            Get
                Return myCardId
            End Get
            Set(ByVal Value As String)
                myCardId = Value
            End Set
        End Property
        Public Property CurrentCharge() As Int64
            Get
                Return myCurrentCharge
            End Get
            Set(ByVal Value As Int64)
                myCurrentCharge = Value
            End Set
        End Property
        Public Property Mblgh() As UInt64
            Get
                Return myMblgh
            End Get
            Set(ByVal Value As UInt64)
                myMblgh = Value
            End Set
        End Property
        Public Property ReminderCharge() As Int64
            Get
                Return myReminderCharge
            End Get
            Set(ByVal Value As Int64)
                myReminderCharge = Value
            End Set
        End Property
        Public Property Message() As String
            Get
                Return myMessage
            End Get
            Set(ByVal Value As String)
                myMessage = Value
            End Set
        End Property
        Public Property FontSize() As Single
            Get
                Return myFontSize
            End Get
            Set(ByVal Value As Single)
                myFontSize = Value
            End Set
        End Property
        Public Property Colorr() As Color
            Get
                Return myColor
            End Get
            Set(ByVal Value As Color)
                myColor = Value
            End Set
        End Property
        Public Property LP() As R2StandardLicensePlateStructure
            Get
                Return myLP
            End Get
            Set(ByVal Value As R2StandardLicensePlateStructure)
                myLP = Value
            End Set
        End Property
        Public Property ChangeDateTime() As DateTime
            Get
                Return myChangeDateTime
            End Get
            Set(ByVal Value As DateTime)
                myChangeDateTime = Value
            End Set
        End Property
#End Region


    End Class

    Public Class R2CoreParkingSystemMClassDriverMonitor
        'Public Shared Sub ExecDriverMonitor()
        '    Try
        '        If System.Windows.Forms.Screen.AllScreens().Length < 2 Then
        '            Throw New Exception("مانيتور راننده را به پورت كارت گرافيك كامپيوتر متصل نماييد")
        '            Exit Sub
        '        End If
        '        Process.Start(Environment.CurrentDirectory + "\ParkingSystemDriverMonitor.exe")
        '    Catch ex As Exception
        '        Throw New Exception("R2CoreParkingSystem.DriverMonitor.R2CoreParkingSystemMClassDriverMonitor.ExecDriverMonitor()." + ex.Message.ToString)
        '    End Try
        'End Sub

        Public Shared Sub UpdateDriverMonitorInfForMaabar(ByVal YourParkingSystemDriverMonitorStructure As R2CoreParkingSystemDriverMonitorStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                If YourParkingSystemDriverMonitorStructure.LP Is Nothing Then
                    CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblDriverMonitoring Set CardId='" & YourParkingSystemDriverMonitorStructure.CardId & "',CurrentCharge=" & YourParkingSystemDriverMonitorStructure.CurrentCharge & ",Mblgh=" & YourParkingSystemDriverMonitorStructure.Mblgh & ",ReminderCharge=" & YourParkingSystemDriverMonitorStructure.ReminderCharge & ",FontSize=" & YourParkingSystemDriverMonitorStructure.FontSize & ",Color='" & YourParkingSystemDriverMonitorStructure.Colorr.ToString & "',Pelak='',Serial='',ChangeDateTime='" & YourParkingSystemDriverMonitorStructure.ChangeDateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "',Message='" & YourParkingSystemDriverMonitorStructure.Message & "'  where   MaabarCode='" & YourParkingSystemDriverMonitorStructure.MaabarCode & "'"
                Else
                    CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblDriverMonitoring Set CardId='" & YourParkingSystemDriverMonitorStructure.CardId & "',CurrentCharge=" & YourParkingSystemDriverMonitorStructure.CurrentCharge & ",Mblgh=" & YourParkingSystemDriverMonitorStructure.Mblgh & ",ReminderCharge=" & YourParkingSystemDriverMonitorStructure.ReminderCharge & ",FontSize=" & YourParkingSystemDriverMonitorStructure.FontSize & ",Color='" & YourParkingSystemDriverMonitorStructure.Colorr.ToString & "',Pelak='" & YourParkingSystemDriverMonitorStructure.LP.Pelak & "',Serial='" & YourParkingSystemDriverMonitorStructure.LP.Serial & "',ChangeDateTime='" & YourParkingSystemDriverMonitorStructure.ChangeDateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "',Message='" & YourParkingSystemDriverMonitorStructure.Message & "'  where   MaabarCode='" & YourParkingSystemDriverMonitorStructure.MaabarCode & "'"
                End If

                CmdSql.ExecuteNonQuery() : CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
    End Class
End Namespace

Namespace AuthenticationManagement

    Public MustInherit Class R2CoreParkingSystemMClassAuthenticationManagement


    End Class

End Namespace

Namespace ProcessesManagement

    Public MustInherit Class R2CoreParkingSystemProcesses
        Inherits R2CoreDesktopProcesses

        Public Shared ReadOnly FrmcBlackList As Int64 = 3
        Public Shared ReadOnly FrmcTempExitTerafficCard As Int64 = 4
        Public Shared ReadOnly FrmcMoneyWalletReturnAmount As Int64 = 5
        Public Shared ReadOnly FrmcMoneyWalletTransferCharge As Int64 = 6
        Public Shared ReadOnly FrmcMoneyWalletCharge As Int64 = 7
        Public Shared ReadOnly FrmcUserChargeReport As Int64 = 8
        Public Shared ReadOnly FrmcTerafficCardEdit As Int64 = 9
        Public Shared ReadOnly FrmcTerafficCardInitialRegister As Int64 = 10
        Public Shared ReadOnly FrmcBlackListFinancialReport As Int64 = 20
        Public Shared ReadOnly FrmcMoneyWalletsCurrentChargeReport = 22
        Public Shared ReadOnly FrmcMoneyWalletAccounting As Int64 = 25
        Public Shared ReadOnly FrmcUserChargeSavabegh As Int64 = 26
        Public Shared ReadOnly FrmcCarEnterExitReport As Int64 = 27
        Public Shared ReadOnly FrmcMoneyWalletChargeSavabegh As Int64 = 28
        Public Shared ReadOnly FrmcRegisteringHandyBills As Int64 = 29
        Public Shared ReadOnly FrmcSoldRFIDCardsReport As Int64 = 48
        Public Shared ReadOnly FrmcParkingTotalEnteranceSeparationByTerraficCardReport As Int64 = 49
        Public Shared ReadOnly FrmcPresentCarsInParkingReport As Int64 = 50
        Public Shared ReadOnly FrmcCarEntranceReport As Int64 = 51
        Public Shared ReadOnly FrmcLoadTargetsTravelLength As Int64 = 57
        Public Shared ReadOnly FrmcTerraficCardsIdentityReport As Int64 = 59
        Public Shared ReadOnly FrmcBlackListReport As Int64 = 60
        Public Shared ReadOnly FrmcCarEntryExitLogViewer As Int64 = 69


    End Class

End Namespace

Namespace ExceptionManagement

    Public Class TerafficCardLastExitedException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "کارت تردد قبلا خروج شده است"
            End Get
        End Property
    End Class

End Namespace

Namespace FileShareRawGroupsManagement

    Public MustInherit Class R2CoreParkingSystemRawGroups
        Inherits R2Core.FileShareRawGroupsManagement.R2CoreRawGroups

        Public Shared ReadOnly DriverImages As Int64 = 2
        Public Shared ReadOnly CarImages As Int64 = 3

    End Class

End Namespace

Namespace ReportsManagement

    Public MustInherit Class R2CoreParkingSystemReports
        Inherits R2Core.ReportsManagement.R2CoreReports

        Public Shared ReadOnly SoldRFIDCardsReport As Int64 = 13
        Public Shared ReadOnly ParkingTotalEnteranceSeparationByTerraficCardReport As Int64 = 14
        Public Shared ReadOnly PresentCarsInParkingReport As Int64 = 15
        Public Shared ReadOnly CarEntranceReport As Int64 = 16
        Public Shared ReadOnly BlackListFinacialReport As Int64 = 22
        Public Shared ReadOnly MoneyWalletsCurrentChargeReport As Int64 = 23
        Public Shared ReadOnly TerraficCardsIdentityReport As Int64 = 26
        Public Shared ReadOnly BlackListReport As Int64 = 27

    End Class

    Public Class R2CoreParkingSystemMClassReportsManagement

        Private Shared _DateTime As New R2DateTime

        Public Shared Sub ReportingInformationProviderUsersChargeReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection
            Try

                Dim _Concat1 As String = YourDateTime1.GetConcatString
                Dim _Concat2 As String = YourDateTime2.GetConcatString
                Dim DS As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Sum(Mblgh) as Sumx,UserId from R2Primary.dbo.TblMoneyWalletCharges where (Replace(DateShamsi,'/','')+Replace(TimeCharge,':','')>='" & _Concat1 & "') and (Replace(DateShamsi,'/','')+Replace(TimeCharge,':','')<='" & _Concat2 & "') Group By UserId Order By UserId", 3600, DS)
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "delete R2PrimaryReports.dbo.TblRFIDCardChargeUserReport" : CmdSql.ExecuteNonQuery()
                For loopx As Int16 = 0 To DS.Tables(0).Rows.Count - 1
                    Dim myUserName As String = R2CoreMClassSoftwareUsersManagement.GetNSSUser(DS.Tables(0).Rows(loopx).Item("userid")).UserName
                    Dim myMblgh As Int64 = DS.Tables(0).Rows(loopx).Item("sumx")
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblRFIDCardChargeUserReport(DateShamsi1,DateShamsi2,Time1,Time2,ReportDateShamsi,ReportTime,UserName,Mblgh) values('" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "','" & YourDateTime1.Time & "','" & YourDateTime2.Time & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "','" & myUserName & "'," & myMblgh & ")"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderSoldRFIDCardsReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblSoldRFIDCards" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText =
                    "Insert Into R2PrimaryReports.dbo.TblSoldRFIDCards Select  '" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "',Count(*) as Total,TerafficCardTypes.TypeCode,TerafficCardTypes.TypeName,Sum(MblghA) as Jam from (Select * from R2Primary.dbo.TblRFIDCards as RFIDCards
                       Where  RFIDCards.DateShamsiSabt>='" & YourDateTime1.DateShamsiFull & "' and RFIDCards.DateShamsiSabt<='" & YourDateTime2.DateShamsiFull & "' and
                              RFIDCards.CardId in 
		                        (Select Distinct CardId from R2Primary.dbo.TblAccounting 
                                   Where EEAccountingProcessType =1)) as RFIDCardsTargets
                         Inner Join R2Primary.dbo.TblAccounting as Accounting On RFIDCardsTargets.CardId=Accounting.CardId
                         Inner Join R2PrimaryParkingSystem.dbo.TblTerafficCardType as TerafficCardTypes On RFIDCardsTargets.CardType=TerafficCardTypes.TypeCode
                     Where Accounting.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.HazinehKart & "
                     Group By TerafficCardTypes.TypeCode,TerafficCardTypes.TypeName"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderParkingTotalEnteranceSeparationByTerraficCardReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand(
                    "Select 'ورود' as EE,inf.*,TerafficCardType.TypeName  FROM (SELECT EnterExit.DateShamsiEnter as DateShamsi,RFIDCards.CardType,Count(*) as CountResult FROM R2PrimaryParkingSystem.dbo.TblEntryExit AS EnterExit
                       Inner Join (Select Distinct CardNo,CardType from R2Primary.dbo.TblRFIDCards) as RFIDCards On EnterExit.CardNoEnter=RFIDCards.CardNo 
                           Where DateShamsiEnter >='" & YourDateTime1.DateShamsiFull & "' and DateShamsiEnter <='" & YourDateTime2.DateShamsiFull & "' 
                           Group By   EnterExit.DateShamsiEnter, RFIDCards.CardType) as Inf
                       Inner Join R2PrimaryParkingSystem.dbo.TblTerafficCardType as TerafficCardType On inf.CardType=TerafficCardType.TypeCode  
                     UNION 
                     Select 'خروج' as EE,inf.*,TerafficCardType.TypeName  FROM (SELECT EnterExit.DateShamsiExit as DateShamsi,RFIDCards.CardType,Count(*) as CountResult FROM R2PrimaryParkingSystem.dbo.TblEntryExit AS EnterExit
                       Inner Join (Select Distinct CardNo,CardType from R2Primary.dbo.TblRFIDCards) as RFIDCards On EnterExit.CardNoExit =RFIDCards.CardNo 
                        Where DateShamsiExit >='" & YourDateTime1.DateShamsiFull & "' and DateShamsiExit <='" & YourDateTime2.DateShamsiFull & "' 
                        Group By   EnterExit.DateShamsiExit, RFIDCards.CardType) as Inf
                       Inner Join R2PrimaryParkingSystem.dbo.TblTerafficCardType as TerafficCardType On inf.CardType=TerafficCardType.TypeCode  
                             Order By DateShamsi,CardType,EE")
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblParkingTotalEnteranceSeparationByTerraficCardReport" : CmdSql.ExecuteNonQuery()
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblParkingTotalEnteranceSeparationByTerraficCardReport(DateTimeShamsi1,DateTimeShamsi2,EE,DateShamsi,CardType,CountResult,TerraficCardName) Values('" & YourDateTime1.DateShamsiFull + " " + YourDateTime1.Time & "','" & YourDateTime2.DateShamsiFull + " " + YourDateTime2.Time & "','" & Ds.Tables(0).Rows(Loopx).Item("EE") & "','" & Ds.Tables(0).Rows(Loopx).Item("DateShamsi") & "'," & Ds.Tables(0).Rows(Loopx).Item("CardType") & "," & Ds.Tables(0).Rows(Loopx).Item("CountResult") & ",'" & Ds.Tables(0).Rows(Loopx).Item("TypeName") & "')"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderPresentCarsInParkingReport(YourDateTime As R2StandardDateAndTimeStructure, YourTerraficCardType As TerafficCardType, YourViewCarImages As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                If YourTerraficCardType = TerafficCardType.None Then
                    Da.SelectCommand = New SqlClient.SqlCommand(
                        "Select EnterExit.EnterExitId,EnterExit.DateShamsiEnter,EnterExit.TimeEnter,EnterExit.CardNoEnter,UserEnter.UserName,EnterExit.MblghEnter,ComputerEnter.MDisplayTitle,EnterExit.PelakEnter ,EnterExit.SerialEnter
                           from R2PrimaryParkingSystem.dbo.TblEntryExit as EnterExit
                         Inner Join (Select Distinct CardNo,CardType From R2Primary.dbo.TblRFIDCards) as RFIDCards On EnterExit.CardNoEnter=RFIDCards.CardNo
                         Inner Join R2Primary.dbo.TblSoftwareUsers as UserEnter On EnterExit.UserIdEnter=UserEnter.UserId 
                         Inner Join R2Primary.dbo.TblSoftwareUsers as UserExit On EnterExit.UserIdExit=UserExit.UserId 
                         Inner Join R2Primary.dbo.TblComputers as ComputerEnter On EnterExit.GateEnter=ComputerEnter.MId 
                         Inner Join R2Primary.dbo.TblComputers as ComputerExit On EnterExit.GateEnter=ComputerExit.MId 
                     Where EnterExit.FlagA=0 and EnterExit.DateShamsiEnter>='" & YourDateTime.DateShamsiFull & "'
	                 ORDER BY EnterExit.DateShamsiEnter ,EnterExit.TimeEnter ")
                Else
                    Da.SelectCommand = New SqlClient.SqlCommand(
                        "Select EnterExit.EnterExitId,EnterExit.DateShamsiEnter,EnterExit.TimeEnter,EnterExit.CardNoEnter,UserEnter.UserName,EnterExit.MblghEnter,ComputerEnter.MDisplayTitle,EnterExit.PelakEnter ,EnterExit.SerialEnter
                           from R2PrimaryParkingSystem.dbo.TblEntryExit as EnterExit
                         Inner Join (Select Distinct CardNo,CardType From R2Primary.dbo.TblRFIDCards) as RFIDCards On EnterExit.CardNoEnter=RFIDCards.CardNo
                         Inner Join R2Primary.dbo.TblSoftwareUsers as UserEnter On EnterExit.UserIdEnter=UserEnter.UserId 
                         Inner Join R2Primary.dbo.TblSoftwareUsers as UserExit On EnterExit.UserIdExit=UserExit.UserId 
                         Inner Join R2Primary.dbo.TblComputers as ComputerEnter On EnterExit.GateEnter=ComputerEnter.MId 
                         Inner Join R2Primary.dbo.TblComputers as ComputerExit On EnterExit.GateEnter=ComputerExit.MId 
                     Where RFIDCards.CardType = " & YourTerraficCardType & " and EnterExit.FlagA=0 and EnterExit.DateShamsiEnter>='" & YourDateTime.DateShamsiFull & "'
	                 ORDER BY EnterExit.DateShamsiEnter ,EnterExit.TimeEnter ")
                End If
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblPresentCarsInParkingReport" : CmdSql.ExecuteNonQuery()

                CmdSql.Parameters.Add("@EnterExitId", SqlDbType.BigInt)
                CmdSql.Parameters.Add("@DateShamsiEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@TimeEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@CardNoEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@UserName", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@MblghEnter", SqlDbType.Money)
                CmdSql.Parameters.Add("@MDisplayTitle", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@Pelak", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@Serial", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@CarImage", SqlDbType.Image)

                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSSEnterExit As R2StandardEnterExitStructure = Nothing
                    Dim CarImage As R2CoreImage = Nothing
                    Dim CarImageByte As Byte() = (New R2CoreImage(My.Resources.NoImageFound)).GetImageByte()
                    If YourViewCarImages = True Then
                        Try
                            NSSEnterExit = New R2StandardEnterExitStructure(Ds.Tables(0).Rows(Loopx).Item("EnterExitId"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Ds.Tables(0).Rows(Loopx).Item("CardNoEnter"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                            CarImage = R2CoreParkingSystemMClassCars.GetCarEnterExitImage(NSSEnterExit, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                            CarImageByte = CarImage.GetImageByte()
                        Catch ex As Exception
                        End Try
                    End If
                    CmdSql.Parameters("@EnterExitId").Value = Ds.Tables(0).Rows(Loopx).Item("EnterExitId")
                    CmdSql.Parameters("@DateShamsiEnter").Value = Ds.Tables(0).Rows(Loopx).Item("DateShamsiEnter")
                    CmdSql.Parameters("@TimeEnter").Value = Ds.Tables(0).Rows(Loopx).Item("TimeEnter")
                    CmdSql.Parameters("@CardNoEnter").Value = Ds.Tables(0).Rows(Loopx).Item("CardNoEnter")
                    CmdSql.Parameters("@UserName").Value = Ds.Tables(0).Rows(Loopx).Item("UserName")
                    CmdSql.Parameters("@MblghEnter").Value = Ds.Tables(0).Rows(Loopx).Item("MblghEnter")
                    CmdSql.Parameters("@MDisplayTitle").Value = Ds.Tables(0).Rows(Loopx).Item("MDisplayTitle")
                    CmdSql.Parameters("@Pelak").Value = Ds.Tables(0).Rows(Loopx).Item("PelakEnter")
                    CmdSql.Parameters("@Serial").Value = Ds.Tables(0).Rows(Loopx).Item("SerialEnter")
                    CmdSql.Parameters("@CarImage").Value = CarImageByte
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblPresentCarsInParkingReport Values(@EnterExitId,@DateShamsiEnter,@TimeEnter,@CardNoEnter,@UserName,@MblghEnter,@MDisplayTitle,@Pelak,@Serial,@CarImage)"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderCarEntranceReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourNSSCar As R2StandardCarStructure, YourEntranceDateTimeSupport As R2CoreParkingSystem.EnterExitManagement.R2EnterExitRequestType, YourViewCarImages As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim SqlTerraficCardOrNumberPlate As String = String.Empty
                If YourTerraficCard Is Nothing Then
                    SqlTerraficCardOrNumberPlate = " PelakEnter='" & YourNSSCar.StrCarNo & "' and SerialEnter='" & YourNSSCar.StrCarSerialNo & "'"
                ElseIf YourNSSCar Is Nothing Then
                    SqlTerraficCardOrNumberPlate = " CardNoEnter='" & YourTerraficCard.CardNo & "'"
                End If
                Dim SqlEntranceDateTimeSupport As String = String.Empty
                If YourEntranceDateTimeSupport = R2EnterExitRequestType.EnterRequest Then
                    SqlEntranceDateTimeSupport = " and replace(EnterExit.DateShamsiEnter,'/','')+replace(EnterExit.TimeEnter,':','')>='" & YourDateTime1.GetConcatString & "' and replace(EnterExit.DateShamsiEnter,'/','')+replace(EnterExit.TimeEnter,':','')<='" & YourDateTime2.GetConcatString & "'"
                ElseIf YourEntranceDateTimeSupport = R2EnterExitRequestType.ExitRequest Then
                    SqlEntranceDateTimeSupport = " and replace(EnterExit.DateShamsiExit,'/','')+replace(EnterExit.TimeExit,':','')>='" & YourDateTime1.GetConcatString & "' and replace(EnterExit.DateShamsiExit,'/','')+replace(EnterExit.TimeExit,':','')<='" & YourDateTime2.GetConcatString & "'"
                End If
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand(
                    "Select EnterExit.EnterExitId,EnterExit.CardNoEnter,EnterExit.DateShamsiEnter,EnterExit.TimeEnter,EnterExit.PelakEnter,EnterExit.SerialEnter,EnterExit.MblghEnter,ComputerEnter.MName as ComputerEnter,SoftwareUserEnter.UserName as UserEnter,EnterExit.DateShamsiExit,EnterExit.TimeExit,EnterExit.PelakExit,EnterExit.SerialExit,EnterExit.MblghExit,ComputerExit.MName as ComputerExit,SoftwareUserExit.UserName as UserExit
                      from R2PrimaryParkingSystem.dbo.TblEntryExit as EnterExit
                           Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUserEnter On EnterExit.UserIdEnter=SoftwareUserEnter.UserId
                           Inner Join R2Primary.dbo.TblComputers as ComputerEnter On EnterExit.GateEnter = ComputerEnter.MId
                           Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUserExit On EnterExit.UserIdExit=SoftwareUserExit.UserId
                           Inner Join R2Primary.dbo.TblComputers as ComputerExit On EnterExit.GateExit = ComputerExit.MId
                      Where " + SqlTerraficCardOrNumberPlate + SqlEntranceDateTimeSupport + " Order By EnterExit.DateTimeMilladiEnter")

                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblCarEntranceReport " : CmdSql.ExecuteNonQuery()

                CmdSql.Parameters.Add("@EnterExitId", SqlDbType.BigInt)
                CmdSql.Parameters.Add("@CardNoEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@DateShamsiEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@TimeEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@PelakEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@SerialEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@MblghEnter", SqlDbType.Money)
                CmdSql.Parameters.Add("@ComputerEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@UserEnter", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@DateShamsiExit", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@TimeExit", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@PelakExit", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@SerialExit", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@MblghExit", SqlDbType.Money)
                CmdSql.Parameters.Add("@ComputerExit", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@UserExit", SqlDbType.NVarChar)
                CmdSql.Parameters.Add("@CarImage", SqlDbType.Image)

                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSSEnterExit As R2StandardEnterExitStructure = Nothing
                    Dim CarImage As R2CoreImage = Nothing
                    Dim CarImageByte As Byte() = (New R2CoreImage(My.Resources.NoImageFound)).GetImageByte()
                    If YourViewCarImages = True Then
                        Try
                            NSSEnterExit = New R2StandardEnterExitStructure(Ds.Tables(0).Rows(Loopx).Item("EnterExitId"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Ds.Tables(0).Rows(Loopx).Item("CardNoEnter"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                            CarImage = R2CoreParkingSystemMClassCars.GetCarEnterExitImage(NSSEnterExit, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                            CarImageByte = CarImage.GetImageByte()
                        Catch ex As Exception
                        End Try
                    End If
                    CmdSql.Parameters("@EnterExitId").Value = Ds.Tables(0).Rows(Loopx).Item("EnterExitId")
                    CmdSql.Parameters("@CardNoEnter").Value = Ds.Tables(0).Rows(Loopx).Item("CardNoEnter")
                    CmdSql.Parameters("@DateShamsiEnter").Value = Ds.Tables(0).Rows(Loopx).Item("DateShamsiEnter")
                    CmdSql.Parameters("@TimeEnter").Value = Ds.Tables(0).Rows(Loopx).Item("TimeEnter")
                    CmdSql.Parameters("@PelakEnter").Value = Ds.Tables(0).Rows(Loopx).Item("PelakEnter")
                    CmdSql.Parameters("@SerialEnter").Value = Ds.Tables(0).Rows(Loopx).Item("SerialEnter")
                    CmdSql.Parameters("@MblghEnter").Value = Ds.Tables(0).Rows(Loopx).Item("MblghEnter")
                    CmdSql.Parameters("@ComputerEnter").Value = Ds.Tables(0).Rows(Loopx).Item("ComputerEnter")
                    CmdSql.Parameters("@UserEnter").Value = Ds.Tables(0).Rows(Loopx).Item("UserEnter")
                    CmdSql.Parameters("@DateShamsiExit").Value = Ds.Tables(0).Rows(Loopx).Item("DateShamsiExit")
                    CmdSql.Parameters("@TimeExit").Value = Ds.Tables(0).Rows(Loopx).Item("TimeExit")
                    CmdSql.Parameters("@PelakExit").Value = Ds.Tables(0).Rows(Loopx).Item("PelakExit")
                    CmdSql.Parameters("@SerialExit").Value = Ds.Tables(0).Rows(Loopx).Item("SerialExit")
                    CmdSql.Parameters("@MblghExit").Value = Ds.Tables(0).Rows(Loopx).Item("MblghExit")
                    CmdSql.Parameters("@ComputerExit").Value = Ds.Tables(0).Rows(Loopx).Item("ComputerExit")
                    CmdSql.Parameters("@UserExit").Value = Ds.Tables(0).Rows(Loopx).Item("UserExit")
                    CmdSql.Parameters("@CarImage").Value = CarImageByte
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblCarEntranceReport Values(@EnterExitId,@CardNoEnter,@DateShamsiEnter,@TimeEnter,@PelakEnter,@SerialEnter,@MblghEnter,@ComputerEnter,@UserEnter,@DateShamsiExit,@TimeExit,@PelakExit,@SerialExit,@MblghExit,@ComputerExit,@UserExit,@CarImage)"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderBlackListFinancialReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Concat1 As String = YourDateTime1.DateShamsiFull.Replace("/", "") + YourDateTime1.Time.Replace(":", "")
                Dim Concat2 As String = YourDateTime2.DateShamsiFull.Replace("/", "") + YourDateTime2.Time.Replace(":", "")

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblBlackListFinancialReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblBlackListFinancialReport
                     Select Accounting.cardid,Accounting.DateShamsiA as DateShamsi,Accounting.TimeA,Accounting.PelakA as Pelak,Accounting.SerialA as Serial,Accounting.MblghA as Mblgh,Computers.MDisplayTitle as ComputerName,SoftwareUsers.UserName from R2Primary.dbo.TblAccounting as Accounting 
                        Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On Accounting.UserIdA=SoftwareUsers.UserId
                        Inner Join R2Primary.dbo.TblComputers as Computers On Accounting.MaabarCode=Computers.MId
                          Where (((Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':',''))>='" & Concat1 & "') And ((Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,'/',''))<='" & Concat2 & "')) And (Accounting.EEAccountingProcessType=12) 
                          Order BY Accounting.DateMilladiA"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderMoneyWalletsCurrentChargeReport(YourBaseDate As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblMoneyWalletsCurrentChargeReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblMoneyWalletsCurrentChargeReport
                                         Select '" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "',* from (Select Distinct CardId,Charge from R2Primary.dbo.TblRFIDCards as RFIDCards Where RFIDCards.CardId In
                                                           (Select Distinct CardId from R2Primary.dbo.TblAccounting as Accounting
                                                              Where Accounting.DateShamsiA>='" & YourBaseDate.DateShamsiFull & "')) as DataBox"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderTerraficCardsIdentityReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblTerraficCardsIdentity" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblTerraficCardsIdentity
                                       Select '" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "',Count(*) as Counting,TCT.TypeName 
                                        from R2Primary.dbo.TblRFIDCards as RFs 
                                          Inner Join R2PrimaryParkingSystem.dbo.TblTerafficCardType as TCT On RFs.CardType=TCT.TypeCode 
                                        Where RFs.DateShamsiSabt>='" & YourDateTime1.DateShamsiFull & "' and RFs.DateShamsiSabt<='" & YourDateTime2.DateShamsiFull & "' and TCT.Deleted=0 
                                        Group By TCT.TypeName "
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderBlackListReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourBlackListType As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblBlackListReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblBlackListReport
                                      Select BlackList.nTruckNo as Pelak,BlackList.nPlakserial as Serial,BlackList.strDesc as Description,BlackList.nAmount as Amount,BlackList.strDate as DateShamsi,SoftwareUsers.UserName as UserName 
                                      From dbtransport.dbo.tbblacklist as BlackList
                                         Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On BlackList.nUser=SoftwareUsers.UserId 
                                      Where " & IIf(YourBlackListType = R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.ActiveBlackLists, " BlackList.flagA=0 and", String.Empty) & " BlackList.strDate>='" & YourDateTime1.DateShamsiFull & "' and BlackList.strDate<='" & YourDateTime2.DateShamsiFull & "'
                                      Order By BlackList.strDate ,BlackList.strDesc "
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class


End Namespace

Namespace MonetarySettingTools

    Public MustInherit Class R2CoreParkingSystemMonetarySettingTools
        Inherits R2CoreMonetarySettingTools
        Public Shared ReadOnly Property ExitCarProcess As Int64 = 2
    End Class

End Namespace

Namespace SoftwareUsersManagement

    Public MustInherit Class R2CoreParkingSystemSoftwareUserTypes
        Inherits R2CoreSoftwareUserTypes
        Public Shared ReadOnly Property Driver As Int64 = 3

    End Class

    Public Class R2CoreParkingSystemInstanceSoftwareUsersManager
        Public Function GetNSSSoftwareUser(YourDriverId As Int64) As R2CoreStandardSoftwareUserStructure
            Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
            Dim InstanceSoftwareUser As New R2CoreInstanseSoftwareUsersManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Top 1 SoftwareUsers.UserId from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                                Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On SoftwareUsers.UserId=EntityRelations.E1 
	                            Inner Join dbtransport.dbo.TbDriver as Drivers On EntityRelations.E2=Drivers.nIDDriver 
                          Where SoftwareUsers.Deleted=0 and EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and
                                EntityRelations.RelationActive=1 and Drivers.nIDDriver=" & YourDriverId & "", 0, Ds).GetRecordsCount = 0 Then Throw New SoftwareUserRelatedThisDriverNotFoundException
                Return InstanceSoftwareUser.GetNSSUser(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("UserId")))
            Catch ex As SoftwareUserRelatedThisDriverNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public NotInheritable Class R2CoreParkingSystemMClassSoftwareUsersManagement
        Public Shared Function GetNSSSoftwareUser(YourDriverId As Int64) As R2CoreStandardSoftwareUserStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Top 1 SoftwareUsers.UserId from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                                Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On SoftwareUsers.UserId=EntityRelations.E1 
	                            Inner Join dbtransport.dbo.TbDriver as Drivers On EntityRelations.E2=Drivers.nIDDriver 
                          Where SoftwareUsers.Deleted=0 and EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and
                                EntityRelations.RelationActive=1 and Drivers.nIDDriver=" & YourDriverId & "", 0, Ds).GetRecordsCount = 0 Then Throw New SoftwareUserRelatedThisDriverNotFoundException
                Return R2CoreMClassSoftwareUsersManagement.GetNSSUser(Ds.Tables(0).Rows(0).Item("UserId"))
            Catch ex As SoftwareUserRelatedThisDriverNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class SoftwareUserRelatedThisDriverNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مشخصات کاربری مرتبط  با راننده مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace EntityRelations

    Public MustInherit Class R2CoreParkingSystemEntityRelationTypes
        Inherits R2CoreEntityRelationTypes
        Public Shared ReadOnly SoftwareUser_Driver As Int64 = 2
    End Class

End Namespace

Namespace RequesterManagement

    Public MustInherit Class R2CoreParkingSystemRequesters
        Inherits R2CoreRequesters

    End Class



End Namespace

Namespace PermissionManagement

    Public MustInherit Class R2CoreParkingSystemPermissionTypes
    End Class


End Namespace

Namespace EntityManagement

    Public MustInherit Class R2CoreParkingSystemEntities

    End Class



End Namespace

Namespace MobileProcessesManagement

    Public MustInherit Class R2CoreParkingSystemMobileProcesses
        Public Shared ReadOnly MoneyWallet As Int64 = 7
    End Class

End Namespace

Namespace PredefinedMessagesManagement
    Public MustInherit Class R2CoreParkingSystemPredefinedMessages
        Public Shared ReadOnly AmountInvalid As Int64 = 5
    End Class

End Namespace

Namespace SMS
    Public Class R2CoreParkingSystemMCLassSMSManager
        Private _DateTime As New R2DateTime

        Private Sub RegisteringSMSOwner(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure, YourUserCreatorId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceMoneyWallet = New R2CoreParkingSystemInstanceMoneyWalletManager
                Dim NSSMoneyWallet = InstanceMoneyWallet.GetNSSMoneyWallet(YourNSSSoftwareUser)
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Update R2PrimarySMSSystem.dbo.TblSMSOwners Set Active=0 Where UserId=" & YourNSSSoftwareUser.UserId & " and Active=1"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblSMSOwners(UserId,MoneyWalletId,IsSendingActive,DateTimeMilladi,DateShamsi,Time,UserCreatorId,ViewFlag,Active,Deleted)
                                      Values(" & YourNSSSoftwareUser.UserId & "," & NSSMoneyWallet.CardId & ",1,'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "'," & YourUserCreatorId & ",1,1,0)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As SoftwareUserMoneyWalletNotFoundException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub RegisterAndActiveSMSOwner(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure, YourUserCreatorId As Int64)
            Try
                Dim InstanceSoftwareUser = New R2CoreInstanseSoftwareUsersManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim InstanceMoneyWallet = New R2CoreParkingSystemInstanceMoneyWalletManager
                Dim NSSMoneyWallet = InstanceMoneyWallet.GetNSSMoneyWallet(YourNSSSoftwareUser)
                If NSSMoneyWallet.Charge < InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.SmsSystemSetting, 7) Then
                    Throw New MoneyWalletCurrentChargeNotEnoughException
                End If
                'کسر هزینه فعال سازی برای مدت معین
                InstanceMoneyWallet.ActMoneyWalletNextStatus(NSSMoneyWallet, BagPayType.MinusMoney, InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.SmsSystemSetting, 7), R2CoreParkingSystemAccountings.SoftwareUserSMSOwnerServiceCost, InstanceSoftwareUser.GetNSSSystemUser())
                RegisteringSMSOwner(YourNSSSoftwareUser, YourUserCreatorId)
            Catch ex As SoftwareUserMoneyWalletNotFoundException
                Throw ex
            Catch ex As MoneyWalletCurrentChargeNotEnoughException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub ActivateSMSOwner(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure, YourUserCreatorId As Int64)
            Try
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim InstanceSMS = New R2CoreMClassSMSManager
                Dim NSSSMSOwner As R2CoreStandardSMSOwnerStructure = Nothing

                Try
                    NSSSMSOwner = InstanceSMS.GetNSSSMSOwner(YourNSSSoftwareUser)
                Catch ex As SMSOwnerForSoftwareUserDoNotRegisteredYetException
                    RegisterAndActiveSMSOwner(YourNSSSoftwareUser, YourUserCreatorId)
                    Return
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try

                If NSSSMSOwner.Active Then
                    If DateDiff(DateInterval.Year, NSSSMSOwner.DateTimeMilladi, _DateTime.GetCurrentDateTimeMilladi) < InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.SmsSystemSetting, 6) Then
                        Throw New SMSOwnerHasCreditYetException
                    Else
                        RegisterAndActiveSMSOwner(YourNSSSoftwareUser, YourUserCreatorId)
                    End If
                Else
                    RegisterAndActiveSMSOwner(YourNSSSoftwareUser, YourUserCreatorId)
                End If
            Catch ex As SoftwareUserMoneyWalletNotFoundException
                Throw ex
            Catch ex As MoneyWalletCurrentChargeNotEnoughException
                Throw ex
            Catch ex As SMSOwnerHasCreditYetException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class
End Namespace
