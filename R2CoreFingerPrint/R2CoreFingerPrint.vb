


Imports System.Reflection
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2CoreFingerPrint.ConfigurationManagement


Namespace PublicProc
    Public MustInherit Class R2CoreFingerPrintMClassManagement
    End Class

End Namespace

Namespace ConfigurationManagement

    Public MustInherit Class R2CoreFingerPrintConfigurations
        Inherits R2Core.ConfigurationManagement.R2CoreConfigurations

        Public Shared ReadOnly Property Suprema As Int64 = 24
        Public Shared ReadOnly Property Dermalog As Int64 = 25
        Public Shared ReadOnly Property VerifyIdentifyFPUCEnable As Int64 = 27
        Public Shared ReadOnly Property SaveFingerPrintsPath As Int64 = 32






    End Class


End Namespace

Namespace SupremaSystem

    Public MustInherit Class R2CoreFingerPrintMClassSupremaManagement
        Private Shared Matcher As Suprema.UFMatcher = New Suprema.UFMatcher
        Private Shared UFMStatusError As Suprema.UFM_STATUS
        Private Shared Sub SetMatcher(ByVal YourSecurityLevel As Integer, ByVal YourTemplateType As Integer, ByVal YourFastMode As Boolean)
            Try
                If (YourSecurityLevel < 1) Or (YourSecurityLevel > 7) Then Throw New Exception("عدد مورد نظر برای سطح امنیتی تایید یا تشخیص هویت صحیح نیست")
                Matcher.SecurityLevel = YourSecurityLevel
                If (YourTemplateType < 2001) Or (YourSecurityLevel > 2003) Then Throw New Exception("استاندارد مورد نظر برای ایجاد تمپلت و یا تایید و تشخیص هویت صحیح نیست")
                Matcher.nTemplateType = YourTemplateType
                Matcher.FastMode = YourFastMode
                UFMStatusError = Matcher.InitResult
                If UFMStatusError <> 0 Then
                    Throw New Exception(UFMStatusError.ToString)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function VerificationTwoTemplate(ByVal YourTemplate1 As Byte(), ByVal YourTemplate1Size As Integer, ByVal YourTemplate2 As Byte(), ByVal YourTemplate2Size As Integer, ByVal YourSecurityLevel As Integer, ByVal YourTemplateType As Integer, ByVal YourFastMode As Boolean) As Boolean
            Try

                SetMatcher(YourSecurityLevel, YourTemplateType, YourFastMode)
                Dim Success As Boolean = False
                UFMStatusError = Matcher.Verify(YourTemplate1, YourTemplate1Size, YourTemplate2, YourTemplate2Size, Success)
                If UFMStatusError <> 0 Then
                    Throw New Exception(UFMStatusError.ToString)
                End If
                If Success = True Then
                    Return True
                ElseIf Success = False Then
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function VerificationOneTemplateByArray(ByVal YourTemplate As Byte(), ByVal YourTemplateSize As Integer, ByVal YourTemplateArray As Byte()(), ByVal YourTemplateArraySize As Integer(), ByVal YourTemplateArrayNum As Integer, ByVal YourSecurityLevel As Integer, ByVal YourTemplateType As Integer, ByVal YourFastMode As Boolean, ByRef YourIndex As Integer) As Boolean
            Try
                SetMatcher(YourSecurityLevel, YourTemplateType, YourFastMode)
                Dim TemplateIndex As Integer
                UFMStatusError = Matcher.IdentifyMT(YourTemplate, YourTemplateSize, YourTemplateArray, YourTemplateArraySize, YourTemplateArrayNum, 5000, TemplateIndex)
                If UFMStatusError <> 0 Then
                    Throw New Exception(UFMStatusError.ToString)
                End If
                YourIndex = TemplateIndex
                If TemplateIndex = -1 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function Identification(ByVal YourTemplate As Byte(), ByVal YourTemplateSize As Integer, ByVal YourTemplateArray As Byte()(), ByVal YourTemplateArraySize As Integer(), ByVal YourTemplateArrayNum As Integer, ByVal YourSecurityLevel As Integer, ByVal YourTemplateType As Integer, ByVal YourFastMode As Boolean) As Integer
            Try
                SetMatcher(YourSecurityLevel, YourTemplateType, YourFastMode)
                Dim TemplateIndex As Integer
                UFMStatusError = Matcher.IdentifyMT(YourTemplate, YourTemplateSize, YourTemplateArray, YourTemplateArraySize, YourTemplateArrayNum, 5000, TemplateIndex)
                If UFMStatusError <> 0 Then
                    Throw New Exception(UFMStatusError.ToString)
                End If
                Return TemplateIndex '-1 Failed
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class

End Namespace

Namespace DermalogSystem

    Public MustInherit Class R2CoreFingerPrintMClassDermalogManagemet

        Private Shared DDevice As Dermalog.Imaging.Capturing.Device
        Public Shared Function DermalogInitializeScanner(ByRef YourMessage As String) As Dermalog.Imaging.Capturing.Device
            Try
                If Not (DDevice Is Nothing) Then
                    YourMessage = "Dermalog Device Initialized At Few Moments Ago."
                    Return DDevice
                End If
                Dim I As Dermalog.Imaging.Capturing.DeviceIdentity() = Dermalog.Imaging.Capturing.DeviceManager.GetAvailableDevices
                DDevice = Dermalog.Imaging.Capturing.DeviceManager.GetDevice(I(0))
                YourMessage = DDevice.DeviceID.ToString
                Dermalog.Imaging.Capturing.DeviceManager.SetActiveDevice(0, DDevice)
                YourMessage += vbCrLf + "FG_BEEP:" + DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_BEEP).ToString
                YourMessage += vbCrLf + "FG_AUTO_CAPTURE_BEEP:" + DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_AUTO_CAPTURE_BEEP).ToString
                YourMessage += vbCrLf + "FG_FAKE_DETECT:" + DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_FAKE_DETECT).ToString
                YourMessage += vbCrLf + "FG_LEDS:" + DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_LEDS).ToString
                YourMessage += vbCrLf + "FG_MAX_CHANNEL:" + DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_MAX_CHANNEL).ToString
                YourMessage += vbCrLf + "FG_ROTATE_AND_CROP_ROLLED_IMAGE:" + DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_ROTATE_AND_CROP_ROLLED_IMAGE).ToString
                YourMessage += vbCrLf + "DeviceID:" + DDevice.DeviceID.ToString
                YourMessage += vbCrLf + "ColorMode:" + DDevice.ColorMode.ToString
                YourMessage += vbCrLf + "CaptureMode:" + DDevice.CaptureMode.ToString
                YourMessage += vbCrLf + "CameraType:" + DDevice.CameraType.ToString
                DDevice.CaptureMode = Dermalog.Imaging.Capturing.CaptureMode.PREVIEW_IMAGE_AUTO_DETECT
                DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_BEEP) = 1
                DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_FAKE_DETECT) = 1
                DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_LEDS) = 1
                DDevice.Property.Item(Dermalog.Imaging.Capturing.PropertyType.FG_AUTO_CAPTURE_BEEP) = 1
                Dim CM As Dermalog.Imaging.Capturing.ColorMode() = DDevice.ColorModes
                For LOOPX As UInt16 = 0 To CM.Length - 1
                    YourMessage += vbCrLf + "ColorMode:" + CM(LOOPX).ToString
                Next
                'Dim CA As Dermalog.Imaging.Capturing.CaptureMode() = DDevice.CaptureModes
                'For LOOPX As UInt16 = 0 To CA.Length - 1
                '    ViewMessage("CaptureMode:" + CA(LOOPX).ToString)
                'Next
                'DDevice.ColorMode = Dermalog.Imaging.Capturing.ColorMode.RGB_32
                Return DDevice
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Matcher As Dermalog.AFIS.FingerCode3.Matcher = New Dermalog.AFIS.FingerCode3.Matcher
        Private Shared EnCoder As Dermalog.AFIS.FingerCode3.Encoder = New Dermalog.AFIS.FingerCode3.Encoder
        Public Shared Function Verification(ByVal YourListOfFPs As Generic.List(Of Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint), ByVal YourTemplateArray As Byte()(), ByVal YourTemplateNumbers As Integer, ByRef YourScore As Double) As Boolean
            Try
                EnCoder.Format = Dermalog.AFIS.FingerCode3.Enums.TemplateFormat.ISO19794_2_2005
                For Loopx As UInt16 = 0 To YourListOfFPs.Count - 1
                    Dim myQuery As Dermalog.AFIS.FingerCode3.Template
                    myQuery = EnCoder.Encode(YourListOfFPs(Loopx).Image)
                    For LoopY As UInt16 = 0 To YourTemplateNumbers - 1
                        Dim myTarget As Dermalog.AFIS.FingerCode3.Template = New Dermalog.AFIS.FingerCode3.Template
                        myTarget.SetData(YourTemplateArray(LoopY), Dermalog.AFIS.FingerCode3.Enums.TemplateFormat.ISO19794_2_2005)
                        YourScore = Matcher.Match(myTarget, myQuery)
                        If YourScore >= R2CoreMClassConfigurationManagement.GetConfigByte(R2CoreFingerPrintConfigurations.Dermalog, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2) Then
                            Return True
                        End If
                    Next
                Next
                Return False
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

End Namespace


