
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2CoreFingerPrint.ConfigurationManagement
Imports R2CoreGUI

Public Class UCFingerPrintCapturerSuprema
    Inherits UCGeneral

    Private WithEvents UFScannerManager As Suprema.UFScannerManager = New Suprema.UFScannerManager(Me)
    Public WithEvents Scanner As Suprema.UFScanner
    Private ReadOnly Template As Byte() = New Byte(MAX_TEMPLATE_SIZE) {}
    Const MAX_TEMPLATE_SIZE As Integer = 1024
    Const TemplateType As Suprema.UFM_TEMPLATE_TYPE = Suprema.UFM_TEMPLATE_TYPE.UFM_TEMPLATE_TYPE_ISO19794_2
    Private UFSStatusError As Suprema.UFS_STATUS
    Private UFMStatusError As Suprema.UFM_STATUS
    Private TemplateSize As Integer
    Private EnrollQuality As Integer
    Private TemplateArray As Byte()()
    Private TemplateArraySize As Integer()
    Private TemplateArrayOutput As Byte()()
    Private TemplateArraySizeOutput As Integer()
    Private TemplateIndex As Integer
    Private G As Graphics
    Public Event CapturingStatusEvent()


#Region "General Properties"

    <Browsable(False)>
    Public ReadOnly Property CurrentTemplate As Byte()
        Get
            Return Template
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property FPImage As Bitmap
        Get
            Return PicFingerPrint.Image
        End Get
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
            PicFingerPrint.Image = Nothing
            Me.Enabled = R2CoreMClassConfigurationManagement.GetConfigBoolean(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.VerifyIdentifyFPUCEnable, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
            CmbTimeout.Text = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
            NUDBrightness.Value = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2)
            NUDSensitivity.Value = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
            ChkDetectCore.Checked = R2CoreMClassConfigurationManagement.GetConfigBoolean(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 4)
            ChkDetectFake.Checked = R2CoreMClassConfigurationManagement.GetConfigBoolean(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 5)
            CmbSecurityLevel.Text = CmbSecurityLevel.Items(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 6) - 1)
            CmbScanTemplateType.Text = CmbScanTemplateType.Items(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 7) - 2001)
            TxtEnrolQualitySet.Text = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreFingerPrint.ConfigurationManagement.R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 8)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private myCaptureState As Boolean
    Private myFingerCheked As Boolean
    Private Sub StartCapturingIdentification()
        Try
            SetScanner()
            AddHandler Scanner.CaptureEvent, AddressOf CaptureEventIdentification
            TemplateArray = New Byte(100)() {}
            TemplateArraySize = New Integer(100) {}
            For i As Integer = 0 To 100
                TemplateArray(i) = New Byte(MAX_TEMPLATE_SIZE) {}
                TemplateArraySize(i) = 0
            Next
            TemplateArrayOutput = New Byte(1)() {}
            TemplateArraySizeOutput = New Integer(1) {}
            For i As Integer = 0 To 1
                TemplateArrayOutput(i) = New Byte(MAX_TEMPLATE_SIZE) {}
                TemplateArraySizeOutput(i) = 0
            Next
            TemplateIndex = 0
            myCaptureState = True
            myFingerCheked = False
            UFSStatusError = Scanner.StartCapturing
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Throw New Exception(UFSStatusError.ToString)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function CaptureEventIdentification(ByVal sender As Object, ByVal e As Suprema.UFScannerCaptureEventArgs) As Integer
        Try
            If myCaptureState = False Then
                If e.FingerOn = False Then
                    ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Place Your Finger", Nothing, Nothing, UCUFSMDStatus.None)
                    myCaptureState = True
                Else
                    If myFingerCheked = False Then
                        ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Remove Your Finger", Nothing, Nothing, UCUFSMDStatus.None)
                        myFingerCheked = True
                    End If
                End If
                Return 1
            End If

            If e.FingerOn Then
                UFSStatusError = Scanner.ExtractEx(MAX_TEMPLATE_SIZE, Template, TemplateSize, EnrollQuality)
                If UFSStatusError <> 0 Then
                    ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                ElseIf EnrollQuality > TxtEnrolQualitySet.Text Then
                    myCaptureState = False
                    myFingerCheked = False
                    System.Array.Copy(Template, 0, TemplateArray(TemplateIndex), 0, TemplateSize)
                    TemplateArraySize(TemplateIndex) = TemplateSize
                    ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Your Finger:Index=" & TemplateIndex & "  Q=" & EnrollQuality, Nothing, Nothing, UCUFSMDStatus.None)
                    TemplateIndex += 1
                    If TemplateIndex = 2 Then
                        ViewCapturedImage(e.ImageFrame)
                        Return 0
                    End If
                    'RaiseEvent UCCapturingSuccessEvent(Template)
                    Return 1
                Else
                    ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Quality Low:" & EnrollQuality, Nothing, Nothing, UCUFSMDStatus.None)
                End If
            End If
            ViewCapturedImage(e.ImageFrame)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Delegate Sub _ViewCapturedImage(ByRef YourFingerPrintImage As Bitmap)
    Private Sub ViewCapturedImage(ByRef YourFingerPrintImage As Bitmap)
        Try
            If (PicFingerPrint.InvokeRequired) Then
                Dim myDelegate As _ViewCapturedImage = New _ViewCapturedImage(AddressOf ViewCapturedImage)
                Dim params() As Object = New Object() {YourFingerPrintImage}
                BeginInvoke(myDelegate, params)
            Else
                PicFingerPrint.Image = YourFingerPrintImage
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub CapturingStatus_Handler() Handles Me.CapturingStatusEvent
        Try
            AbortCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub AbortCapturing()
        Try
            UFSStatusError = Scanner.AbortCapturing
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            RemoveHandler Scanner.CaptureEvent, AddressOf CaptureEvent
            ''While (True)
            ''    If (Scanner.IsCapturing) Then
            ''        System.Threading.Thread.Sleep(10)
            ''    Else
            ''        Exit While
            ''    End If
            ''End While
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "AbortCapturing Complete", Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function CaptureEvent(ByVal sender As Object, ByVal e As Suprema.UFScannerCaptureEventArgs) As Integer
        Try
            'If myCaptureState = False Then
            '    If e.FingerOn = False Then
            '        ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Place Your Finger", Nothing, Nothing, UCUFSMDStatus.None)
            '        myCaptureState = True
            '    Else
            '        If myFingerCheked = False Then
            '            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Remove Your Finger", Nothing, Nothing, UCUFSMDStatus.None)
            '            myFingerCheked = True
            '        End If
            '    End If
            '    Return 1
            'End If

            If e.FingerOn Then
                UFSStatusError = Scanner.ExtractEx(MAX_TEMPLATE_SIZE, Template, TemplateSize, EnrollQuality)
                If UFSStatusError <> 0 Then
                    ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Else
                    If EnrollQuality > TxtEnrolQualitySet.Text Then
                        'Scanner.DrawFeatureBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), ChkDetectCore.Checked)
                        'myCaptureState = False
                        'myFingerCheked = False
                        'System.Array.Copy(Template, 0, TemplateArray(TemplateIndex), 0, myTemplateSize)
                        'TemplateArraySize(TemplateIndex) = myTemplateSize
                        'ViewMessage(ViewMessageEnum.ViewMessageOnly, "Your Finger:Index=" & TemplateIndex & "  Q=" & myEnrollQuality, Nothing, Nothing, UFSMDStatus.None)
                        'TemplateIndex += 1
                        'If TemplateIndex = 2 Then
                        '    ViewCapturedImage(e.ImageFrame)
                        '    Return 0
                        'End If
                        'RaiseEvent UCCapturingSuccessEvent(Template)
                        'AbortCapturing()
                        CapturingStatus = True
                        RaiseEvent CapturingStatusEvent()
                        'Scanner.AbortCapturing()
                        'Return 1
                    Else
                        ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Quality Low:" & EnrollQuality, Nothing, Nothing, UCUFSMDStatus.None)
                    End If
                End If
            End If
            ViewCapturedImage(e.ImageFrame)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function ExtractFeaturs() As Byte()
        Try
            UFSStatusError = Scanner.ExtractEx(MAX_TEMPLATE_SIZE, Template, TemplateSize, EnrollQuality)
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Function
            End If
            'Scanner.DrawCaptureImageBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), cbDetectCore.Checked)
            G = PicFingerPrint.CreateGraphics
            Scanner.DrawFeatureBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), ChkDetectCore.Checked)
            TxtTemplateSize.Text = TemplateSize
            TxtEnrollQuality.Text = EnrollQuality
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "ExtractEx Complete", Nothing, Nothing, UCUFSMDStatus.None)
            Return Template
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public CapturingStatus As Boolean
    Private Sub StartCapturing()
        Try
            SetScanner()
            UFSStatusError = Scanner.ClearCaptureImageBuffer()
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            'myStartCapturingTime = Now
            AddHandler Scanner.CaptureEvent, AddressOf CaptureEvent
            'myCaptureState = True
            'myFingerCheked = False
            G = PicFingerPrint.CreateGraphics
            CapturingStatus = False
            UFSStatusError = Scanner.StartCapturing
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub CaptureSingleImage()
        Try
            SetScanner()
            UFSStatusError = Scanner.ClearCaptureImageBuffer()
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            UFSStatusError = Scanner.CaptureSingleImage
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            'Scanner.DrawFeatureBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), ChkDetectCore.Checked)
            G = PicFingerPrint.CreateGraphics
            UFSStatusError = Scanner.DrawCaptureImageBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), False)
            G.Dispose()
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Try
            Else
                ViewMessage(UCViewMessageEnum.ViewMessageOnly, "CaptureSingleImage Compelete", Nothing, Nothing, UCUFSMDStatus.None)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UpdateScanner()
        Try
            UFSStatusError = UFScannerManager.Update
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            TxtNumberOfScanners.Text = UFScannerManager.Scanners.Count
            Scanner = UFScannerManager.Scanners(0)
            TxtScannerSerial.Text = Scanner.Serial
            TxtScannerID.Text = Scanner.ID
            If (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR200) Then
                TxtScannerType.Text = "SFR200"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR300) Then
                TxtScannerType.Text = "SFR300"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR300v2) Then
                TxtScannerType.Text = "SFR300v2"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR500) Then
                TxtScannerType.Text = "BioMini Plus"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR600) Then
                TxtScannerType.Text = "BioMini Slim"
            Else
                TxtScannerType.Text = "Error"
            End If
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Update Compelete", Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub SetScanner()
        Try
            Scanner.Brightness = NUDBrightness.Value
            Scanner.Sensitivity = NUDSensitivity.Value
            Scanner.DetectCore = ChkDetectCore.Checked
            Scanner.DetectFake = ChkDetectFake.Checked
            If CmbTimeout.Text.Trim = "" Then
                Scanner.Timeout = 10000
            Else
                Scanner.Timeout = Integer.Parse(CmbTimeout.Text) * 1000
            End If
            Select Case CmbScanTemplateType.SelectedIndex
                Case 0 : Scanner.nTemplateType = 2001
                Case 1 : Scanner.nTemplateType = 2002
                Case 2 : Scanner.nTemplateType = 2003
            End Select
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Enum UCViewMessageEnum
        None = 0
        ViewMessageOnly = 1
        ViewErrorOnly = 2
        ViewTwo = 3
    End Enum

    Private Enum UCUFSMDStatus
        None = 0
        UFS = 1
        UFM = 2
        UFD = 3
    End Enum

    Private Delegate Sub _ViewMessage(ByVal ViewMessage As UCViewMessageEnum, ByVal YourMessage As String, ByVal YourUFSStatusError As Suprema.UFS_STATUS, ByVal YourUFMStatusError As Suprema.UFM_STATUS, ByVal YourUFSMDStatus As UCUFSMDStatus)
    Private Sub ViewMessage(ByVal YourViewMessage As UCViewMessageEnum, ByVal YourMessage As String, ByVal YourUFSStatusError As Suprema.UFS_STATUS, ByVal YourUFMStatusError As Suprema.UFM_STATUS, ByVal YourUFSMDStatus As UCUFSMDStatus)
        Try
            Dim myErrorString As String
            If YourViewMessage = UCViewMessageEnum.ViewErrorOnly Or YourViewMessage = UCViewMessageEnum.ViewTwo Then
                If YourUFSMDStatus = UCUFSMDStatus.UFS Then
                    Suprema.UFScanner.GetErrorString(YourUFSStatusError, myErrorString)
                ElseIf YourUFSMDStatus = UCUFSMDStatus.UFM Then
                    Suprema.UFMatcher.GetErrorString(YourUFMStatusError, myErrorString)
                Else
                    Throw New Exception("ViewMessage" + vbCrLf + "Nothing")
                End If
            End If
            If (TxtReport.InvokeRequired) Then
                Dim myDelegate As _ViewMessage = New _ViewMessage(AddressOf ViewMessage)
                Dim params() As Object = New Object() {YourViewMessage, YourMessage, YourUFSStatusError, YourUFMStatusError, YourUFSMDStatus}
                BeginInvoke(myDelegate, params)
            Else
                If YourViewMessage = UCViewMessageEnum.ViewMessageOnly Then
                    TxtReport.AppendText(YourMessage + vbCrLf)
                End If
                If YourViewMessage = UCViewMessageEnum.ViewErrorOnly Then
                    If YourUFSMDStatus = UCUFSMDStatus.UFS Then
                        TxtReport.AppendText("UFSError:" + myErrorString + vbCrLf)
                    ElseIf YourUFSMDStatus = UCUFSMDStatus.UFM Then
                        TxtReport.AppendText("UFMError:" + myErrorString + vbCrLf)
                    End If
                End If
                If YourViewMessage = UCViewMessageEnum.ViewTwo Then
                    If YourUFSMDStatus = UCUFSMDStatus.UFS Then
                        TxtReport.AppendText("UFSError:" + myErrorString + vbCrLf + YourMessage + vbCrLf)
                    ElseIf YourUFSMDStatus = UCUFSMDStatus.UFM Then
                        TxtReport.AppendText("UFMError:" + myErrorString + vbCrLf + YourMessage + vbCrLf)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub InitialScanner()
        Try
            UFSStatusError = UFScannerManager.Uninit
            If UFSStatusError <> 0 Then
                If UFSStatusError <> Suprema.UFS_STATUS.ERR_NOT_INITIALIZED Then
                    Dim XString As String
                    Suprema.UFScanner.GetErrorString(UFSStatusError, XString)
                    ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                    Exit Sub
                End If
            End If

            UFSStatusError = UFScannerManager.Init
            If UFSStatusError <> 0 Then
                If UFSStatusError <> Suprema.UFS_STATUS.ERR_ALREADY_INITIALIZED Then
                    Dim XString As String
                    Suprema.UFScanner.GetErrorString(UFSStatusError, XString)
                    ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                    Exit Sub
                End If
            End If
            TxtNumberOfScanners.Text = UFScannerManager.Scanners.Count
            Scanner = UFScannerManager.Scanners(0)
            TxtScannerSerial.Text = Scanner.Serial
            TxtScannerID.Text = Scanner.ID
            If (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR200) Then
                TxtScannerType.Text = "SFR200"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR300) Then
                TxtScannerType.Text = "SFR300"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR300v2) Then
                TxtScannerType.Text = "SFR300v2"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR500) Then
                TxtScannerType.Text = "BioMini Plus"
            ElseIf (Scanner.ScannerType = Suprema.UFS_SCANNER_TYPE.SFR600) Then
                TxtScannerType.Text = "BioMini Slim"
            Else
                TxtScannerType.Text = "Error"
            End If
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Initialize Compelete", Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UnInitialScanner()
        Try
            UFSStatusError = UFScannerManager.Uninit
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            PicFingerPrint.Image = Nothing
            TxtScannerID.Clear()
            TxtScannerType.Clear()
            TxtScannerSerial.Clear()
            TxtNumberOfScanners.Clear()
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "UFSScannerManager Uninitialize Complete", Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewOtherMessage(ByVal YourMessage As String)
        ViewMessage(UCViewMessageEnum.ViewMessageOnly, YourMessage, Nothing, Nothing, UCUFSMDStatus.None)
    End Sub

    Public Sub UCUnInitial()
        Try
            UnInitialScanner()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCInitialize()
        Try
            'کنترل اتصال اسکنر
            If R2CoreMClassConfigurationManagement.GetConfigBoolean(R2CoreFingerPrintConfigurations.Suprema, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = False Then Exit Sub
            UCRefresh()
            InitialScanner()
            SetScanner()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCCaptureSingleFingerPrintTemplate() As Byte()
        Try
            CaptureSingleImage()
            Return ExtractFeaturs()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Sub UCStartCapturing()
        Try
            If Scanner IsNot Nothing Then
                If Scanner.IsCapturing = True Then Throw New Exception("Scanner Is Capturing Please Wait ...")
                PicFingerPrint.Image = Nothing
                StartCapturing()
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCAbortCapturing()
        Try
            AbortCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCDisposeResources()
        Try
            If Scanner Is Nothing Then Exit Sub
            AbortCapturing()
            UnInitialScanner()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UFScannerManager_ScannerEvent(ByVal sender As Object, ByVal e As Suprema.UFScannerManagerScannerEventArgs) Handles UFScannerManager.ScannerEvent
        Try
            If e.SensorOn = True Then
                ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Scanner Connected :" + e.ScannerID, Nothing, Nothing, UCUFSMDStatus.None)
            Else
                ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Scanner DisConnected :" + e.ScannerID, Nothing, Nothing, UCUFSMDStatus.None)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtReport.Clear()
    End Sub

    Private Sub TxtReport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReport.TextChanged
        If TxtReport.TextLength > 4000000 Then TxtReport.Clear()
    End Sub

    Private Sub BtnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInitialize.Click
        Try
            InitialScanner()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnUnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnInitialize.Click
        Try
            UnInitialScanner()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            UpdateScanner()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnSingleCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSingleCapture.Click
        Try
            CaptureSingleImage()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExtract.Click
        Try
            ExtractFeaturs()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnStartCapturing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStartCapturing.Click
        Try
            StartCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbort.Click
        Try
            AbortCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnAutoCapturing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAutoCapturing.Click
        Try
            AddHandler Scanner.CaptureEvent, AddressOf CaptureEvent
            UFSStatusError = Scanner.StartAutoCapture
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnViewBestTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewBestTemplate.Click
        Try
            UFSStatusError = Scanner.SelectTemplateEx(MAX_TEMPLATE_SIZE, TemplateArray, TemplateArraySize, 4, TemplateArrayOutput, TemplateArraySizeOutput, 2)
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "BestTemplate1:" + TemplateArrayOutput(0)(0).ToString + vbCrLf + "BestTemplate2:" + TemplateArrayOutput(1)(0).ToString, Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnSaveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveImage.Click
        Try
            Dim mySD As SaveFileDialog = New SaveFileDialog
            mySD.Filter = "Bitmap files (*.bmp)|*.bmp"
            If mySD.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            UFSStatusError = Scanner.SaveCaptureImageBufferToBMP(mySD.FileName)
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Image Saved to " + mySD.FileName, Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnVerification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerification.Click
        Try
            CaptureSingleImage()
            Dim myTemplate As Byte()
            Dim myTemplateSize As Integer
            Dim myEnrollQuality As Integer
            UFSStatusError = Scanner.ExtractEx(MAX_TEMPLATE_SIZE, myTemplate, myTemplateSize, myEnrollQuality)
            If UFSStatusError <> 0 Then
                ViewMessage(UCViewMessageEnum.ViewErrorOnly, "", UFSStatusError, Nothing, UCUFSMDStatus.UFS)
                Exit Sub
            End If
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "EnrollQuality=" + myEnrollQuality.ToString + vbCrLf + "TemplateSize=" + myTemplateSize.ToString, Nothing, Nothing, UCUFSMDStatus.None)
            'Scanner.DrawCaptureImageBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), cbDetectCore.Checked)
            G = PicFingerPrint.CreateGraphics
            Scanner.DrawFeatureBuffer(G, New Rectangle(0, 0, PicFingerPrint.Width, PicFingerPrint.Height), ChkDetectCore.Checked)
            If SupremaSystem.R2CoreFingerPrintMClassSupremaManagement.VerificationTwoTemplate(Template, TemplateSize, myTemplate, myTemplateSize, Mid(CmbSecurityLevel.Text, 1, 1), TemplateType, ChkMatcherFastMode.Checked) = True Then
                ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Verification Succeed", Nothing, Nothing, UCUFSMDStatus.None)
            Else
                ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Verification Failed", Nothing, Nothing, UCUFSMDStatus.None)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnStartCapturingIdentification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStartCapturingIdentification.Click
        Try
            StartCapturingIdentification()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub BtnIdentification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIdentification.Click
        Try
            ViewMessage(UCViewMessageEnum.ViewMessageOnly, "Verification Succeed.Index:" + SupremaSystem.R2CoreFingerPrintMClassSupremaManagement.Identification(Template, TemplateSize, TemplateArray, TemplateArraySize, TemplateArray.Count, Mid(CmbSecurityLevel.Text, 1, 1), TemplateType, ChkMatcherFastMode.Checked).ToString, Nothing, Nothing, UCUFSMDStatus.None)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
