
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Windows.Forms

Imports Dermalog.AFIS.FingerCode3
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.FingerPrintsManagement.DermalogSystem
Imports R2CoreGUI


Public Class UCFingerPrintCapturerDermalog
    Inherits UCGeneral

    Private WithEvents DDevice As Dermalog.Imaging.Capturing.Device
    Private lISTfPS As New Generic.List(Of Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint)
    Dim QualityChecker As Dermalog.AFIS.NFIQ.NistQualityCheck
    Private EnCoder As Dermalog.AFIS.FingerCode3.Encoder

    Public Event UCDetectError(ErrorMessage As String)

#Region "General Properties"

    Public ReadOnly Property GetlISTfPS As Generic.List(Of Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint)
        Get
            Return lISTfPS
        End Get
    End Property

    <Browsable(True)>
    Private _DDevice_OnDetectChekFlag As Boolean = True
    Public Property UCDDevice_OnDetectChekFlag() As Boolean
        Get
            Return _DDevice_OnDetectChekFlag
        End Get
        Set(value As Boolean)
            _DDevice_OnDetectChekFlag = value
        End Set
    End Property

    <Browsable(False)>
    Private _LifenessScore As Int64 = 0
    Public Property UCLifenessScore() As Int64
        Get
            Return _LifenessScore
        End Get
        Set(value As Int64)
            _LifenessScore = value
        End Set
    End Property

    Public ReadOnly Property UCFingerPrintDetected As Boolean
        Get
            Return DDevice_OnDetectCompletedFlag
        End Get
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.Enabled = R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreConfigurations.VerifyIdentifyFPUCEnable, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
            QualityChecker = New Dermalog.AFIS.NFIQ.NistQualityCheck
            EnCoder = New Dermalog.AFIS.FingerCode3.Encoder
            PicFingerPrint.Image = Nothing
            ClearPnlFPs()
            lISTfPS.Clear()
            LblFPCount.Text = "0"
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Delegate Sub _UCViewMessage(ByVal Message As String)
    Public Sub UCViewMessage(ByVal Message As String)
        Try
            If (TxtReport.InvokeRequired) Then
                Dim myDelegate As _UCViewMessage = New _UCViewMessage(AddressOf UCViewMessage)
                Dim params() As Object = New Object() {Message}
                BeginInvoke(myDelegate, params)
            Else
                TxtReport.AppendText(Message + vbCrLf)
            End If
        Catch ex As Exception
            RaiseEvent UCDetectError(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDermalogStopCapturing()
        Try
            If DDevice IsNot Nothing Then
                DDevice.Stop()
                While (True)
                    If (DDevice.IsCapturing) Then
                        System.Threading.Thread.Sleep(10)
                    Else
                        Exit While
                    End If
                End While
                UCViewMessage("Stop Scanner Completed...")
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDermalogStartCapturing()
        Try
            DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_GREEN_LED) = 1
            DDevice_OnDetectCompletedFlag = False
            DDevice.Start()
            UCViewMessage("Start Scanner Completed...")
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCDermalogInitializeScanner()
        Try
            Dim DMessage As String = ""
            DDevice = R2CoreFingerPrintMClassDermalogManagemet.DermalogInitializeScanner(DMessage)
            UCViewMessage(DMessage)
            EnCoder.Format = Dermalog.AFIS.FingerCode3.Enums.TemplateFormat.ISO19794_2_2005
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Function UCDermalogImageQuality() As Integer
        Try
            Return QualityChecker.GetQuality(PicFingerPrint.Image)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Private Sub UCDermalogShowDialog()
        Try
            Dim Di As Dermalog.Imaging.Capturing.DialogType() = DDevice.AvailableDialogs
            If Di IsNot Nothing Then
                DDevice.ShowDialog(Dermalog.Imaging.Capturing.DialogType.VIDEO_FORMAT_DLG)
            Else
                UCViewMessage("No Dialog")
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCDermalogCapturingFreez()
        Try
            If DDevice.IsFreezed = False Then DDevice.Freeze(True)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDermalogCapturingUnFreez()
        Try
            If DDevice.IsFreezed Then DDevice.Freeze(False)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDermalogDeviceInformation()
        Try
            Dim DD As Dermalog.Imaging.Capturing.DeviceInformations() = DDevice.GetDeviceInformations
            For LOOPX As UInt16 = 0 To DD.Length - 1
                UCViewMessage("Index:" + DD(LOOPX).index.ToString + "   Name:" + DD(LOOPX).name + "   Version:" + DD(LOOPX).version)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCDermalogViewProperties()
        Try
            UCViewMessage(DDevice.CameraType.ToString)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDermalogDeviceId()
        Try
            UCViewMessage(DDevice.DeviceID.ToString)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Delegate Sub _UCDermalogSegmentation()
    Private Sub UCDermalogSegmentation()
        Try
            If (PnlFPs.InvokeRequired) Then
                Dim myDelegate As _UCDermalogSegmentation = New _UCDermalogSegmentation(AddressOf UCDermalogSegmentation)
                Dim params() As Object = New Object() {}
                BeginInvoke(myDelegate, params)
            Else
                Dim s As Dermalog.AFIS.FourprintSegmentation.FourprintSegmenation = New Dermalog.AFIS.FourprintSegmentation.FourprintSegmenation
                Dim x As UInt16 = s.GetSegmentationCount(PicFingerPrint.Image)
                If x = 0 Then Exit Sub
                For loopx As UInt16 = 0 To x - 1
                    Dim seg As Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint
                    Try
                        seg = s.GetSegmentedFingerprint(loopx)
                    Catch ex As Exception
                        UCViewMessage("DermalogSegmentation:" + ex.Message)
                    End Try
                    If seg IsNot Nothing Then
                        If seg.Image IsNot Nothing Then
                            Dim FlagError As Boolean = False
                            Try
                                EnCoder.Encode(seg.Image)
                            Catch ex As Exception
                                UCViewMessage("DermalogSegmentation:" + ex.Message)
                                FlagError = True
                            End Try
                            If FlagError = False Then
                                Dim myUCFP As UCFP = New UCFP
                                myUCFP.UCFPSegment = seg
                                myUCFP.Dock = DockStyle.Top
                                PnlFPs.Controls.Add(myUCFP)
                                AddHandler myUCFP.UCPicFPClicked, AddressOf UCFPs_UCPicFPClickedHandler
                                lISTfPS.Add(seg)
                            End If
                        End If
                    End If
                Next
                LblFPCount.Text = CUInt(LblFPCount.Text) + x
                UCViewMessage("FingerPrints Added To List.")
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            'Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ClearPnlFPs()
        Do While PnlFPs.Controls.Count <> 0
            For Each C As Control In PnlFPs.Controls
                PnlFPs.Controls.Remove(C)
                C.Dispose()
            Next
        Loop
    End Sub

    Public Sub UCDisposeResources()
        Try
            UCDermalogStopCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCStartCapturing()
        Try
            UCRefresh()
            CapturingStatus = False 'شروع کپچر پایان هنگام دیتکت اثر انگشت
            UCDermalogStartCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCStopCapturing()
        Try
            UCDermalogStopCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCInitialize()
        Try
            UCDermalogInitializeScanner()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewOtherMessage(ByVal YourMessage As String)
        Try
            UCViewMessage(YourMessage)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCFPs_UCPicFPClickedHandler(ByVal YourPicture As Bitmap)
        Try
            Dim FrmPicViewer As New FrmcShowFinger
            FrmPicViewer.PicFP.Image = YourPicture
            FrmPicViewer.ShowDialog()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        Try
            UCDermalogStopCapturing()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInitialize.Click
        Try
            UCDermalogInitializeScanner()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        Try
            UCDermalogStartCapturing()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnShowDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowDialog.Click
        Try
            UCDermalogShowDialog()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnFreez_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFreez.Click
        Try
            UCDermalogCapturingFreez()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnUnfreez_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnfreez.Click
        Try
            UCDermalogCapturingUnFreez()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnDeviceInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeviceInformation.Click
        Try
            UCDermalogDeviceInformation()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnViewProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewProperties.Click
        Try
            UCDermalogViewProperties()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnDeviceID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeviceID.Click
        Try
            UCDermalogDeviceId()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnLoadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadImage.Click
        Try
            Dim FD As OpenFileDialog = New OpenFileDialog
            FD.Filter = "(*.BMP)|*.BMP"
            If FD.ShowDialog = DialogResult.OK Then
                PicFingerPrint.Image = Image.FromFile(FD.FileName)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnNistQuality_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNistQuality.Click
        Try
            UCViewMessage("NISTQuality:" + UCDermalogImageQuality.ToString)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnSegmentation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSegmentation.Click
        Try
            UCDermalogSegmentation()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnSaveFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveFP.Click
        Try
            Dim mySD As SaveFileDialog = New SaveFileDialog
            mySD.Filter = "Bitmap files (*.bmp)|*.bmp"
            If mySD.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            PicFingerPrint.Image.Save(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.SaveFingerPrintsPath, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) + "FingerPrint" + mySD.FileName)
            'PicFingerPrint.Image.Save(R2CoreFingerPrint.Configuration.R2CoreFingerPrintMClassConfigurationManagement.GetSaveFPPath + "\" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) + ".bmp")
            UCViewMessage("FingerPrint Bitmap Saved.")
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnTxtReportClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTxtReportClear.Click
        TxtReport.Clear()
    End Sub

    Private Sub BtnAddFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddFP.Click
        Try
            UCDermalogSegmentation()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Public CapturingStatus As Boolean
    Private DDevice_OnDetectCompletedFlag As Boolean = False
    Private Sub DDevice_OnDetect(ByVal sender As Object, ByVal e As Dermalog.Imaging.Capturing.DetectEventArgs) Handles DDevice.OnDetect
        Try
            PicFingerPrint.Image = e.Image
            UCViewMessage("LifnessInfo(Score):" + DDevice.GetCurrentFrameInfo(Dermalog.Imaging.Capturing.FrameInfoTypes.E_LIFENESS_INFO_1).score.ToString)
            UCViewMessage("LifnessInfo(State):" + DDevice.GetCurrentFrameInfo(Dermalog.Imaging.Capturing.FrameInfoTypes.E_LIFENESS_INFO_1).state.ToString)
            UCViewMessage("Contamination:" + DDevice.Contamination.ToString)  'ÂáæÏí ÏÓÊÇå ÞÏÑ ÇÓÊ
            'Dim myQ As Double = DermalogImageQuality()
            'ViewMessage("NISTQuality:" + myQ.ToString)  'آلودگی دستگاه چقدر است
            'R2CoreMClassConfigurationManagement.GetConfigByte(R2CoreFingerPrintConfigurations.Dermalog, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0))
            If (CDbl(DDevice.GetCurrentFrameInfo(Dermalog.Imaging.Capturing.FrameInfoTypes.E_LIFENESS_INFO_1).score) >= UCLifenessScore) Then
                If UCDDevice_OnDetectChekFlag = True Then
                    If DDevice_OnDetectCompletedFlag = True Then
                        Exit Sub
                    Else
                        DDevice_OnDetectCompletedFlag = True
                    End If
                End If
                UCDermalogSegmentation()
                'If lISTfPS.Count > 0 Then CapturingStatus = True
                CapturingStatus = True
            End If
        Catch ex As Exception
            UCViewMessage("DDevice_OnDetect" + vbCrLf + ex.Message.ToString)
        End Try
    End Sub

    Private Sub DDevice_OnDeviceEvent(ByVal sender As Object, ByVal e As Dermalog.Imaging.Capturing.DeviceEventArgs) Handles DDevice.OnDeviceEvent
        UCViewMessage("Channel:" + e.Channel.ToString + vbCrLf + "Data:" + e.Data.ToString + vbCrLf + "Identity:" + e.Identity.ToString)
    End Sub

    Private Sub DDevice_OnError(ByVal sender As Object, ByVal e As Dermalog.Imaging.Capturing.ErrorEventArgs) Handles DDevice.OnError
        UCViewMessage("DDevice_OnError:" + e.Error)
    End Sub

    Private Sub DDevice_OnImage(ByVal sender As Object, ByVal e As Dermalog.Imaging.Capturing.ImageEventArgs) Handles DDevice.OnImage
        'PicFingerPrint.Image = e.Image
    End Sub

    Private Sub DDevice_OnWarning(ByVal sender As Object, ByVal e As Dermalog.Imaging.Capturing.WarningEventArgs) Handles DDevice.OnWarning
        UCViewMessage("DDevice_OnWarning" + vbCrLf + e.Warning)
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
