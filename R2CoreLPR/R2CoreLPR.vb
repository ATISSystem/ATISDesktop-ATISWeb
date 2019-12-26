

Imports System.Drawing
Imports System.Reflection
Imports Microsoft.Win32
Imports System.Windows.Forms

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2CoreLPR.ConfigurationManagement
Imports R2CoreLPR.LicensePlateManagement


Namespace LicensePlateManagement
    Public Enum R2PelakType
        None = 0
        Savari = 1
        Teraili = 2
        Otagdar = 3
        SavariPelakWhite = 4
        SavariPelakRed = 5
        SavariPelakYellow = 6
    End Enum
    Public Class R2StandardLicensePlateStructure
        Private myPelak As String
        Private mySerial As String
        Private myCity As String
        Private myPelakType As R2PelakType

        Public Sub New()
            MyBase.New()
            myPelak = "" : mySerial = "" : myCity = "" : myPelakType = R2PelakType.None
        End Sub
        Public Sub New(ByVal Pelakk As String, ByVal Seriall As String, ByVal Cityy As String, ByVal PelakTypee As R2PelakType)
            myPelak = Pelakk
            mySerial = Seriall
            myCity = Cityy
            myPelakType = PelakTypee
        End Sub
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
        Public Property City() As String
            Get
                Return myCity.Trim()
            End Get
            Set(ByVal Value As String)
                myCity = Value
            End Set
        End Property
        Public Property PelakType() As R2PelakType
            Get
                Return myPelakType
            End Get
            Set(ByVal Value As R2PelakType)
                myPelakType = Value
            End Set
        End Property
        Public Function GetLPString() As String
            Return Pelak.Trim & "-" & Serial.Trim
        End Function

    End Class
    Public Class R2CoreLPRMClassLicensePlateManagement
        Public Shared Function GetPelakTypeName(ByVal YourPelakType As R2PelakType) As String
            Select Case YourPelakType
                Case 0 : Return "نامعلوم"
                Case 1 : Return "سواری"
                Case 2 : Return "تریلی"
                Case 3 : Return "اتاقدار"
                Case 4 : Return "سواری پلاک سفید"
                Case 5 : Return "سواری پلاک قرمز"
                Case 6 : Return "سواری پلاک زرد"
            End Select
        End Function
    End Class

End Namespace

Namespace LicensePlateRecognizer
    Public Enum LPRecognizerStatus
        None = 0
        LPNotFound = 1
        LPFound = 2
    End Enum

    Public Class R2CoreLPRPixelManagement
        Public Function IsBluePixelInBlueRegion(ByVal YourHSL As AForge.Imaging.HSL) As Boolean
            Try
                If YourHSL.Saturation >= 0.2 And YourHSL.Luminance >= 0.1 And YourHSL.Hue >= 200 And YourHSL.Hue <= 270 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsBluePixelInLPMainRegion(ByVal YourHSL As AForge.Imaging.HSL) As Boolean
            Try
                If YourHSL.Saturation >= 0.2 And YourHSL.Luminance >= 0.1 And YourHSL.Hue >= 210 And YourHSL.Hue <= 270 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsRedPixel(ByVal YourHSL As AForge.Imaging.HSL) As Boolean
            Try
                If YourHSL.Saturation >= 0.1 And YourHSL.Luminance >= 0.1 And ((YourHSL.Hue >= 0 And YourHSL.Hue <= 30) Or (YourHSL.Hue >= 290 And YourHSL.Hue <= 360)) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsGreenPixel(ByVal YourHSL As AForge.Imaging.HSL) As Boolean
            Try
                If YourHSL.Saturation >= 0.2 And YourHSL.Luminance >= 0.1 And (YourHSL.Hue >= 100 And YourHSL.Hue <= 190) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsWhitePixel(ByVal YourHSL As AForge.Imaging.HSL) As Boolean
            Try
                If YourHSL.Saturation < 0.1 And YourHSL.Luminance >= 0.5 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public Class R2CoreLPRPerceptron
        Private vDigit(,) As Double
        Private vCharacter(,) As Double
        Private wDigit(,) As Double
        Private wCharacter(,) As Double
        Private N As UInt32 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
        Private PDigit As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
        Private MDigit As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2)
        Private MCharacter As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
        Private PCharacter As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 4)
        Private XTInputWieghtPathS As String = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 5)
        'Private XTInputWieghtPathS As String = Application.StartupPath
        Private BiSigFunctionAlpha As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 6)

        Private BiSigFunction As AForge.Neuro.BipolarSigmoidFunction = New AForge.Neuro.BipolarSigmoidFunction(BiSigFunctionAlpha)
        Private BiosString As String = "+1"
        Private SRvWieght As IO.StreamReader
        Private SRwWieght As IO.StreamReader
        Private WieghtArraysFillStatus As Boolean = False

        Public Sub New()
            Try
                FillClassVariables()
                FillWieghtArrays()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub FillClassVariables()
            Try
                ReDim vDigit(N, PDigit - 1)
                ReDim vCharacter(N, PCharacter - 1)
                ReDim wDigit(PDigit, MDigit - 1)
                ReDim wCharacter(PCharacter, MCharacter - 1)

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub FillWieghtArrays()
            Try
                SRvWieght = New IO.StreamReader(XTInputWieghtPathS + "\vWieghtDigit.txt")
                SRwWieght = New IO.StreamReader(XTInputWieghtPathS + "\wWieghtDigit.txt")
                Dim vWieghtString() As Double
                Dim wWieghtString() As Double
                For Loopj As UInt32 = 0 To PDigit - 1
                    vWieghtString = Array.ConvertAll(SRvWieght.ReadLine.Split(";"), New Converter(Of String, Double)(AddressOf Double.Parse))
                    For Loopi As UInt32 = 0 To N
                        vDigit(Loopi, Loopj) = vWieghtString(Loopi)
                    Next
                Next
                For Loopk As UInt32 = 0 To MDigit - 1
                    wWieghtString = Array.ConvertAll(SRwWieght.ReadLine.Split(";"), New Converter(Of String, Double)(AddressOf Double.Parse))
                    For Loopj As UInt32 = 0 To PDigit
                        wDigit(Loopj, Loopk) = wWieghtString(Loopj)
                    Next
                Next
                SRvWieght = New IO.StreamReader(XTInputWieghtPathS + "\vWieghtCharacter.txt")
                SRwWieght = New IO.StreamReader(XTInputWieghtPathS + "\wWieghtCharacter.txt")
                For Loopj As UInt32 = 0 To PCharacter - 1
                    vWieghtString = Array.ConvertAll(SRvWieght.ReadLine.Split(";"), New Converter(Of String, Double)(AddressOf Double.Parse))
                    For Loopi As UInt32 = 0 To N
                        vCharacter(Loopi, Loopj) = vWieghtString(Loopi)
                    Next
                Next
                For Loopk As UInt32 = 0 To MCharacter - 1
                    wWieghtString = Array.ConvertAll(SRwWieght.ReadLine.Split(";"), New Converter(Of String, Double)(AddressOf Double.Parse))
                    For Loopj As UInt32 = 0 To PCharacter
                        wCharacter(Loopj, Loopk) = wWieghtString(Loopj)
                    Next
                Next
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Function GetCharacterByOCTypeAndIndex(ByVal YourOCRType As OCRType, ByVal YourIndex As Byte) As Char
            Try
                If YourOCRType = OCRType.OCRDigit Then
                    If YourIndex = 0 Then
                        Return "1"
                    ElseIf YourIndex = 1 Then
                        Return "2"
                    ElseIf YourIndex = 2 Then
                        Return "3"
                    ElseIf YourIndex = 3 Then
                        Return "4"
                    ElseIf YourIndex = 4 Then
                        Return "5"
                    ElseIf YourIndex = 5 Then
                        Return "6"
                    ElseIf YourIndex = 6 Then
                        Return "7"
                    ElseIf YourIndex = 7 Then
                        Return "8"
                    ElseIf YourIndex = 8 Then
                        Return "9"
                    End If
                ElseIf YourOCRType = OCRType.OCRCharacter Then
                    If YourIndex = 0 Then
                        Return "ب"
                    ElseIf YourIndex = 1 Then
                        Return "ج"
                    ElseIf YourIndex = 2 Then
                        Return "د"
                    ElseIf YourIndex = 3 Then
                        Return "س"
                    ElseIf YourIndex = 4 Then
                        Return "ص"
                    ElseIf YourIndex = 5 Then
                        Return "ط"
                    ElseIf YourIndex = 6 Then
                        Return "ق"
                    ElseIf YourIndex = 7 Then
                        Return "ل"
                    ElseIf YourIndex = 8 Then
                        Return "م"
                    ElseIf YourIndex = 9 Then
                        Return "ن"
                    ElseIf YourIndex = 10 Then
                        Return "و"
                    ElseIf YourIndex = 11 Then
                        Return "ه"
                    ElseIf YourIndex = 12 Then
                        Return "ی"
                    ElseIf YourIndex = 13 Then
                        Return "ع"
                    ElseIf YourIndex = 14 Then
                        Return "ر"
                    ElseIf YourIndex = 15 Then
                        Return "ت"
                    ElseIf YourIndex = 16 Then
                        Return "ا"
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function PerceptronIdentifiedOC(ByRef YourOC As Drawing.Bitmap, ByVal YourOCRType As OCRType, Optional ByRef YourAnalyze As String = "") As Char
            Dim P As UInt32
            Dim M As UInt32
            Dim v(,) As Double
            Dim w(,) As Double
            Dim z() As Double
            Dim z_in() As Double
            Dim y() As Double
            Dim y_in() As Double

            Try
                'If WieghtArraysFillStatus = False Then
                '    FillWieghtArrays()
                '    WieghtArraysFillStatus = True
                'End If
                If YourOCRType = OCRType.OCRDigit Then
                    ReDim z(PDigit)
                    ReDim z_in(PDigit - 1)
                    ReDim y(MDigit - 1)
                    ReDim y_in(MDigit - 1)
                    P = PDigit
                    M = MDigit
                    v = vDigit
                    w = wDigit
                Else
                    ReDim z(PCharacter)
                    ReDim z_in(PCharacter - 1)
                    ReDim y(MCharacter - 1)
                    ReDim y_in(MCharacter - 1)
                    P = PCharacter
                    M = MCharacter
                    v = vCharacter
                    w = wCharacter
                End If

                'تولید رشته الگوی ورودی از تصوير کاراکتر
                Dim XInputString As String = ""
                For LoopY As UInt32 = 0 To YourOC.Height - 1
                    For loopX As Int32 = 0 To YourOC.Width - 1
                        Dim myC As Drawing.Color = YourOC.GetPixel(loopX, LoopY)
                        If myC.ToArgb = Drawing.Color.White.ToArgb Then
                            If (LoopY = YourOC.Height - 1) And (loopX = YourOC.Width - 1) Then
                                XInputString += "+1"
                            Else
                                XInputString += "+1;"
                            End If
                        ElseIf myC.ToArgb = Drawing.Color.Black.ToArgb Then
                            If (LoopY = YourOC.Height - 1) And (loopX = YourOC.Width - 1) Then
                                XInputString += "-1"
                            Else
                                XInputString += "-1;"
                            End If
                        Else
                            Throw New Exception("LicensePlateRecognizer.R2CoreLPRPerceptron.PerceptronIdentifiedOC()." + "پيکسل های تصوير باينری نيستند")
                        End If
                    Next
                Next
                XInputString = BiosString + ";" + XInputString

                'الگوی ورودی از جعبه متن ورودی
                Dim x() As Double = Array.ConvertAll(XInputString.Split(";"), New Converter(Of String, Double)(AddressOf Double.Parse))
                'اجرای الگوريتم پيش خور پرسپترون
                'z
                For Loopj As UInt32 = 0 To P - 1
                    Dim Sumxv As Double = 0
                    For Loopi As UInt32 = 0 To N
                        Sumxv += x(Loopi) * v(Loopi, Loopj)
                    Next
                    z_in(Loopj) = Sumxv
                    z(Loopj + 1) = BiSigFunction.Function(Sumxv)
                Next
                z(0) = 1
                'y
                For Loopk As UInt32 = 0 To M - 1
                    Dim Sumzw As Double = 0
                    For Loopj As UInt32 = 0 To P
                        Sumzw += z(Loopj) * w(Loopj, Loopk)
                    Next
                    y_in(Loopk) = Sumzw
                    y(Loopk) = BiSigFunction.Function(Sumzw)
                Next

                'ايجاد رشته خروجی
                Dim yOutputString As String
                For Loopk As UInt32 = 0 To M - 1
                    If Loopk = M - 1 Then
                        yOutputString += y(Loopk).ToString
                    Else
                        yOutputString += y(Loopk).ToString + ";"
                    End If
                Next

                'نمايش رشته خروجی
                Dim O() As Double = Array.ConvertAll(yOutputString.Split(";"), New Converter(Of String, Double)(AddressOf Double.Parse))
                YourAnalyze = ""
                For LoopO As Byte = 0 To M - 1
                    YourAnalyze += "    " + GetCharacterByOCTypeAndIndex(YourOCRType, LoopO) + "   " + O(LoopO).ToString + vbCrLf
                Next
                Dim PerfectOC As Double = -999
                Dim myChar As Char = "X"
                For LoopO As Byte = 0 To M - 1
                    If O(LoopO) > PerfectOC Then
                        PerfectOC = O(LoopO)
                        myChar = GetCharacterByOCTypeAndIndex(YourOCRType, LoopO)
                    End If
                Next
                Return myChar
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class

    Public Class R2CoreLicensePlateRecognizer
        Private myOriginalImage As Drawing.Bitmap  'تصویر اصلی بارگذاری شده و برش داده شده از محدوده پلاک در تصوير
        Private ImageCropDividW As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
        Private ImageCropDividH As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
        Private ImageCropDividX As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2)
        Private ImageCropDividY As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
        Private ImageCropDividWidht As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 4)
        Private ImageCropDividHight As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 5)
        Private MaxHoleHeight As UInt32 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 6)
        Private MaxHoleWidth As UInt32 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte2, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 7)
        Private CandidateLPAreaMax As UInt32 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
        Private CandidateLPAreaMin As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
        Private CandidateLPRatioMin As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2)
        Private CandidateLPRatioMax As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
        Private AverageLuminance300 As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 4)
        Private OtsuALPDif As Byte = R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 5)
        Private OtsuALPGammaCorrection As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte3, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 6)
        Private RWGRegionTool As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
        Private RWGRegionArz As UInt32 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
        Private AreaOfRWGRegion As UInt32 = RWGRegionTool * RWGRegionArz
        Private RWGRegionArea1D3 As UInt16 = RWGRegionArz / 3
        Private RedHueCounter As UInt32 = 0
        Private GreenHueCounter As UInt32 = 0
        Private BlueHueCounter As UInt32 = 0
        Private RedHuePercent As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2)
        Private BlueHuePercent As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
        Private OCWidthMin As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 4)
        Private OCWidthMax As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 5)
        Private OCHeightMin As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 6)
        Private OCHeightMax As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 7)
        Private OCAreaMin As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 8)
        Private OCAreaMax As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 9)
        Private OCRatioMin As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 10)
        Private OCRatioMax As Double = R2CoreMClassConfigurationOfComputersManagement.GetConfigDouble(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 11)
        Private OCyDifFromLPHalf As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 12)
        Private OCWidth As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 13)
        Private OCHeight As UInt16 = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreLPRConfigurations.LicensePalte4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 14)

        Private B, R, G As Byte : Private HSL As AForge.Imaging.HSL
        Private LoopYTemp As UInt32 : Private LoopXTemp As UInt32
        Private LPXStarted As UInt32 : Private HalfOfLicensePlate As UInt32

        Private myBC As AForge.Imaging.BlobCounter = New AForge.Imaging.BlobCounter 'مرتبط با تصویر اصلی پس از باینری کردن
        Private myBlobsArray() As AForge.Imaging.Blob 'مرتبط با تصویر اصلی پس از باینری کردن
        Private myBCX As AForge.Imaging.BlobCounter = New AForge.Imaging.BlobCounter
        Private myBlobsArrayX() As AForge.Imaging.Blob



        Public Sub New()
        End Sub

        Private Sub InitializeParameters()
            Try
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub ViewCarImage(ByRef YourCarImage As Drawing.Bitmap, ByVal YourMessage As String)
            Dim F As New FrmcViewCarImage(YourCarImage, YourMessage)
            F.ShowDialog()
        End Sub

        Public Function LicensePlateRecognitionProccess(ByRef YourCarImage As Drawing.Image, ByRef LPRecognizerReport As String, ByRef LicensePlateBlob As AForge.Imaging.Blob) As R2StandardLicensePlateStructure
            Try
                'Image Processing to Get Candidate LicensePlates
                'Crop Image
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(YourCarImage, "First Car Image")
                myOriginalImage = YourCarImage
                Dim myODividW As Double = myOriginalImage.Width / ImageCropDividW
                Dim myODividH As Double = myOriginalImage.Height / ImageCropDividH
                myOriginalImage = (New AForge.Imaging.Filters.Crop(New Drawing.Rectangle(ImageCropDividX * myODividW, ImageCropDividY * myODividH, ImageCropDividWidht * myODividW, ImageCropDividHight * myODividH))).Apply(myOriginalImage)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myOriginalImage, "OriginalImage After Crop By ImageDivide")
                'Gray image
                Dim myGrayImage As Drawing.Bitmap = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.RMY.Apply(myOriginalImage)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myGrayImage, "GrayImage")
                'Sobel Image
                Dim mySobelImage As Drawing.Bitmap = (New AForge.Imaging.Filters.SobelEdgeDetector).Apply(myGrayImage)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(mySobelImage, "SobelImage")
                'Threshold Image
                Dim Otsu As OtsuDll.Otsu = New OtsuDll.Otsu
                Dim myThresholdImage As Drawing.Bitmap = (New AForge.Imaging.Filters.Threshold(Otsu.getOtsuThreshold(mySobelImage))).Apply(mySobelImage)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myThresholdImage, "ThresholdImage")
                'FillHols
                Dim myFillHolesFilter As AForge.Imaging.Filters.FillHoles = New AForge.Imaging.Filters.FillHoles
                myFillHolesFilter.MaxHoleHeight = MaxHoleHeight
                myFillHolesFilter.MaxHoleWidth = MaxHoleWidth
                Dim myFillHolsImage As Drawing.Bitmap = myFillHolesFilter.Apply(myThresholdImage)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myFillHolsImage, "FillHoleImageImage")
                'Erosion Image
                Dim se(,) As Short = New Short(,) {{1, 1, 1, 1, 1}, {1, 1, 1, 1, 1}, {1, 1, 1, 1, 1}, {1, 1, 1, 1, 1}, {1, 1, 1, 1, 1}}
                Dim myErosionImage As Drawing.Bitmap = (New AForge.Imaging.Filters.Erosion(se)).Apply(myFillHolsImage)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myErosionImage, "ErosionImage")
                'BlobCountering ErosionImage
                myBC.BackgroundThreshold = Drawing.Color.Black
                myBC.ObjectsOrder = AForge.Imaging.ObjectsOrder.Size
                myBC.ProcessImage(myErosionImage)
                ReDim myBlobsArray(myBC.ObjectsCount)
                myBlobsArray = myBC.GetObjectsInformation
                'بررسي تك تك كانديدهاي پلاك
                Dim LPRReport As String
                For LoopB As Int16 = myBlobsArray.Count - 1 To 0 Step -1
                    Dim B As AForge.Imaging.Blob = myBlobsArray(LoopB)
                    Dim Rect As Drawing.Rectangle = myBlobsArray(LoopB).Rectangle
                    If B.Area < CandidateLPAreaMax And B.Area > CandidateLPAreaMin Then
                        If ((B.Rectangle.Height / B.Rectangle.Width) >= CandidateLPRatioMin) And ((B.Rectangle.Height / B.Rectangle.Width) <= CandidateLPRatioMax) Then
                            If GetCandidateLPBlobsCount((New AForge.Imaging.Filters.Crop(Rect)).Apply(myOriginalImage)) >= 8 Then
                                'بررسي محتواي هر كانديد
                                LPRReport = ""
                                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreConfigurations.ProgrammerDebugFlag, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then ViewCarImage((New AForge.Imaging.Filters.Crop(myBlobsArray(LoopB).Rectangle)).Apply(myOriginalImage), "Candidate Blobe")
                                'Dim LPFound As LicensePlate.R2StandardLicensePlateStructure = GetLPFromCandidate((New AForge.Imaging.Filters.Crop(myBlobsArray(LoopB).Rectangle)).Apply(myOriginalImage), LPRReport)
                                'Test 1395/04/24
                                Dim LPFound As LicensePlateManagement.R2StandardLicensePlateStructure = GetLPFromCandidateNew((New AForge.Imaging.Filters.Crop(myBlobsArray(LoopB).Rectangle)).Apply(myOriginalImage), LPRReport)
                                LPRecognizerReport += "CandidatePelak:" + LoopB.ToString + vbCrLf + LPRReport + vbCrLf
                                If LPFound IsNot Nothing Then
                                    LicensePlateBlob = B
                                    If LPFound.Pelak.Trim <> "" And LPFound.Serial.Trim <> "" Then Return LPFound
                                End If
                            End If
                        End If
                    End If
                Next
                LPRecognizerReport += "LPNotFound"
                Return Nothing
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function GetCandidateLPBlobsCount(ByRef YourCLP As Drawing.Bitmap) As UInt16
            Try
                Dim myGrayLP As Drawing.Bitmap = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.RMY.Apply(YourCLP)
                Dim Otsu As OtsuDll.Otsu = New OtsuDll.Otsu
                Dim OtsuT As Integer = Otsu.getOtsuThreshold(myGrayLP)
                Dim myALP As Single = GetThresholdLevel(myGrayLP)
                If Math.Abs(OtsuT - myALP) > OtsuALPDif Then
                    myGrayLP = (New AForge.Imaging.Filters.GammaCorrection(OtsuALPGammaCorrection)).Apply(myGrayLP)
                    OtsuT = Otsu.getOtsuThreshold(myGrayLP)
                End If
                Dim myThresholdLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Threshold(OtsuT)).Apply(myGrayLP)
                Dim myInvertLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Invert).Apply(myThresholdLP)
                Dim se(,) As Short = New Short(,) {{0, 1, 0}, {1, 1, 1}, {0, 1, 0}}
                Dim myOpenningLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Opening(se)).Apply(myInvertLP)
                myBCX.BackgroundThreshold = Drawing.Color.Black
                myBCX.ProcessImage(myOpenningLP)
                Return myBCX.ObjectsCount
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function GetThresholdLevel(ByRef YourImage As Drawing.Bitmap) As Single
            Dim myBMP As Drawing.Bitmap = Nothing
            Dim rect As Drawing.Rectangle
            Dim bmpData As System.Drawing.Imaging.BitmapData
            Dim ptr As IntPtr
            Dim bytes As Int64
            Dim rgbValues() As Byte
            Dim W As Int32
            Try
                myBMP = YourImage
                rect = New Drawing.Rectangle(0, 0, myBMP.Width, myBMP.Height)
                W = myBMP.Width
                bmpData = myBMP.LockBits(rect, Drawing.Imaging.ImageLockMode.ReadWrite, Drawing.Imaging.PixelFormat.Format24bppRgb)
                ptr = bmpData.Scan0
                bytes = Math.Abs(bmpData.Stride) * myBMP.Height
                ReDim rgbValues(bytes)
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)
                Dim SumLuminance As Single = 0
                For loopY As Int32 = 0 To myBMP.Height - 1
                    For loopX As Int32 = 0 To myBMP.Width - 1
                        If (loopX <> 0) And (loopX <> (myBMP.Width - 1)) And (loopY <> 0) And (loopY <> (myBMP.Height - 1)) Then
                            Dim B As Byte = rgbValues((loopX * 3) + (loopY * W * 3))
                            Dim G As Byte = rgbValues((loopX * 3) + (loopY * W * 3) + 1)
                            Dim R As Byte = rgbValues((loopX * 3) + (loopY * W * 3) + 2)
                            Dim HSL As AForge.Imaging.HSL = AForge.Imaging.HSL.FromRGB(New AForge.Imaging.RGB(R, G, B))
                            SumLuminance += HSL.Luminance
                        End If
                    Next
                Next
                Dim AverageLuminance As Single = SumLuminance / (myBMP.Width * myBMP.Height)
                myBMP.UnlockBits(bmpData)
                Return AverageLuminance * AverageLuminance300
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function GetLPFromCandidate(ByRef YourCandidate As Drawing.Bitmap, ByRef LPRecognizerReport As String) As LicensePlateManagement.R2StandardLicensePlateStructure
            Dim Perceptron As R2CoreLPRPerceptron = New R2CoreLPRPerceptron
            Dim PixelManagement As R2CoreLPRPixelManagement = New R2CoreLPRPixelManagement
            Dim myBMP As Drawing.Bitmap = Nothing
            Dim Rect As Drawing.Rectangle
            Dim bmpData As System.Drawing.Imaging.BitmapData
            Dim ptr As IntPtr
            Dim bytes As Int64
            Dim rgbValues() As Byte
            Dim W As Int32

            myBMP = YourCandidate

            Try
                Rect = New Drawing.Rectangle(0, 0, myBMP.Width, myBMP.Height)
                bmpData = myBMP.LockBits(Rect, Drawing.Imaging.ImageLockMode.ReadWrite, Drawing.Imaging.PixelFormat.Format24bppRgb)
                W = bmpData.Stride
                ptr = bmpData.Scan0
                bytes = Math.Abs(bmpData.Stride) * myBMP.Height
                ReDim rgbValues(bytes)
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

                'جستجو در کل ستون های تصوير برای يافتن منطقه آبی
                Dim Taeed As Boolean = False
                For LoopX As UInt32 = 0 To myBMP.Width - RWGRegionTool - 5
                    For LoopY As UInt32 = 0 To myBMP.Height - RWGRegionArz - 5
                        'يافتن مستطيل قرمز سفيد سبز
                        RedHueCounter = 0 : GreenHueCounter = 0 : BlueHueCounter = 0
                        For LoopTool As UInt32 = LoopX To LoopX + RWGRegionTool
                            For LoopArz As UInt32 = LoopY To LoopY + RWGRegionArz
                                B = rgbValues(LoopTool * 3 + LoopArz * W)
                                G = rgbValues(LoopTool * 3 + LoopArz * W + 1)
                                R = rgbValues(LoopTool * 3 + LoopArz * W + 2)
                                HSL = AForge.Imaging.HSL.FromRGB(New AForge.Imaging.RGB(R, G, B))
                                If PixelManagement.IsRedPixel(HSL) = True Then
                                    RedHueCounter += 1
                                End If
                                If PixelManagement.IsGreenPixel(HSL) = True Then
                                    GreenHueCounter += 1
                                End If
                                If PixelManagement.IsBluePixelInBlueRegion(HSL) = True Then
                                    BlueHueCounter += 1
                                End If
                            Next
                        Next
                        If (RedHueCounter >= AreaOfRWGRegion * RedHuePercent) And (BlueHueCounter >= AreaOfRWGRegion * BlueHuePercent) Then
                            Taeed = True
                            LoopYTemp = LoopY : LoopXTemp = LoopX
                            HalfOfLicensePlate = LoopYTemp + (4 * RWGRegionArea1D3)
                            Exit For
                        End If
                    Next
                    If Taeed = True Then Exit For
                Next
                If HalfOfLicensePlate > myBMP.Height Then
                    myBMP.UnlockBits(bmpData)
                    LPRecognizerReport = "HalfOfLicensePlateOverBMPHeight"
                    Return Nothing
                End If

                If Taeed = False Then
                    LPRecognizerReport = "BlueRegionNotFound"
                    myBMP.UnlockBits(bmpData)
                    Return Nothing
                End If

                'حرکت به سمت منطقه اصلی پلاک
                Taeed = False
                Dim LPMainRegionHue As UInt32
                For loopHorizony As UInt32 = LoopXTemp + Convert.ToInt32(RWGRegionTool / 2) To myBMP.Width - RWGRegionTool - 5
                    Dim OtherBlueColorHueCount As UInt32 = 0
                    LPMainRegionHue = 0
                    For LoopX As UInt32 = loopHorizony To loopHorizony + Convert.ToInt32(RWGRegionTool / 2)
                        For LoopY As UInt16 = HalfOfLicensePlate To HalfOfLicensePlate + RWGRegionArea1D3
                            B = rgbValues(LoopX * 3 + LoopY * W)
                            G = rgbValues(LoopX * 3 + LoopY * W + 1)
                            R = rgbValues(LoopX * 3 + LoopY * W + 2)
                            HSL = AForge.Imaging.HSL.FromRGB(New AForge.Imaging.RGB(R, G, B))
                            If PixelManagement.IsBluePixelInLPMainRegion(HSL) = False Then
                                OtherBlueColorHueCount += 1
                                LPMainRegionHue += HSL.Hue 'رنگ منطقه اصلی
                            End If
                        Next
                    Next
                    If OtherBlueColorHueCount >= (Convert.ToInt32(RWGRegionTool / 2) * RWGRegionArea1D3) * 50 / 100 Then
                        'LPMainRegionHue = LPMainRegionHue / (RedRegionTool * RedRegionArz) 'رنگ منطقه اصلی
                        Taeed = True
                        LPXStarted = loopHorizony
                        Exit For
                    End If
                Next

                myBMP.UnlockBits(bmpData)
                If Taeed = False Then
                    LPRecognizerReport = "LPXStarted Not Found"
                    Return Nothing
                End If

                'Gray LP
                Dim myGrayLP As Drawing.Bitmap = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.RMY.Apply(YourCandidate)
                Dim Otsu As OtsuDll.Otsu = New OtsuDll.Otsu
                Dim OtsuT As Integer = Otsu.getOtsuThreshold(myGrayLP)
                Dim myALP As Single = GetThresholdLevel(myGrayLP)
                If Math.Abs(OtsuT - myALP) > OtsuALPDif Then
                    myGrayLP = (New AForge.Imaging.Filters.GammaCorrection(OtsuALPGammaCorrection)).Apply(myGrayLP)
                    OtsuT = Otsu.getOtsuThreshold(myGrayLP)
                End If
                'ThresholdLP
                Dim myThresholdLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Threshold(OtsuT)).Apply(myGrayLP)
                'InvertLP
                Dim myInvertLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Invert).Apply(myThresholdLP)
                'OpenningLP
                Dim se(,) As Short = New Short(,) {{0, 1, 0}, {1, 1, 1}, {0, 1, 0}}
                Dim myOpenningLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Opening(se)).Apply(myInvertLP)
                'BlobCountering OpenningLp
                myBCX.BackgroundThreshold = Drawing.Color.Black
                myBCX.ObjectsOrder = AForge.Imaging.ObjectsOrder.XY
                myBCX.ProcessImage(myOpenningLP)
                ReDim myBlobsArrayX(myBCX.ObjectsCount)
                myBlobsArrayX = myBCX.GetObjectsInformation
                'Dim myTargetImageSize As UInt64 = myBinaryPelak.Width * myBinaryPelak.Height
                Dim myOCArray(myBlobsArrayX.Count - 1) As OCStracture
                Dim IdentifiedOCCount As UInt16 = 0
                For LoopOC As UInt16 = 0 To myBCX.ObjectsCount - 1
                    Dim myCBlob As AForge.Imaging.Blob = myBlobsArrayX(LoopOC)
                    myOCArray(LoopOC) = New OCStracture
                    myOCArray(LoopOC).Status = True
                    'کنترل طول و عرض بلوب
                    If myCBlob.Rectangle.Width >= OCWidthMin And myCBlob.Rectangle.Width <= OCWidthMax And myCBlob.Rectangle.Height >= OCHeightMin And myCBlob.Rectangle.Height <= OCHeightMax Then
                        'کنترل مساحت
                        If (myCBlob.Area >= OCAreaMin) And (myCBlob.Area <= OCAreaMax) Then
                            'کنترل نسبت اضلاع
                            If (myCBlob.Rectangle.Width / myCBlob.Rectangle.Height >= OCRatioMin) And (myCBlob.Rectangle.Width / myCBlob.Rectangle.Height <= OCRatioMax) Then
                                'کنترل در خط استوا بودن بلوب کاراکتر
                                If (myBlobsArrayX(LoopOC).Rectangle.Left >= LPXStarted - 5) And (Math.Abs(myBlobsArrayX(LoopOC).Rectangle.Top - HalfOfLicensePlate) <= OCyDifFromLPHalf) Then
                                    IdentifiedOCCount += 1
                                    myOCArray(LoopOC).Status = False
                                End If
                            End If
                        End If
                    End If
                Next
                If IdentifiedOCCount < 8 Then
                    LPRecognizerReport = "IdentifiedOCCount < 8"
                    Return Nothing
                End If
                'مرتب کردن کاراکترها
                Dim BlobSIndex As Byte = 0
                Dim BlobSCount As Byte = 0
                Dim OCIndex As Byte = 0
                Dim SevenOCRectangle As Drawing.Rectangle
                Dim OCCharIdentified As Char
                Dim SecondOCRectangle As Drawing.Rectangle
                Dim ThirdOCRectangle As Drawing.Rectangle
                Dim myAnalyze As String
                Dim myRecognizedLPPelakFirst As String = ""
                Dim myRecognizedLPPelakCharacter As String = ""
                Dim myRecognizedLPPelakSecond As String = ""
                Dim myRecognizedLPSerial As String = ""
                Do
                    Dim myMinX As UInt32 = myOpenningLP.Width
                    For LoopMin As UInt16 = 0 To myBCX.ObjectsCount - 1
                        If (myBlobsArrayX(LoopMin).Rectangle.Left < myMinX) And (myOCArray(LoopMin).Status = False) Then
                            myMinX = myBlobsArrayX(LoopMin).Rectangle.Left
                            BlobSIndex = LoopMin
                        End If
                    Next
                    If myMinX < myOpenningLP.Width Then
                        myOCArray(BlobSIndex).Status = True
                        Dim OCTaeed As Boolean
                        If OCIndex <> 7 Then
                            OCTaeed = True
                        End If
                        If (OCIndex = 7) Then
                            If (myBlobsArrayX(BlobSIndex).Rectangle.Left >= SevenOCRectangle.Right - 3) And (Math.Abs(myBlobsArrayX(BlobSIndex).Rectangle.Top - SevenOCRectangle.Top) <= 5) Then
                                OCTaeed = True
                            Else
                                OCTaeed = False
                            End If
                        End If

                        If OCTaeed = True Then
                            If OCIndex = 1 Then SecondOCRectangle = myBlobsArrayX(BlobSIndex).Rectangle
                            If OCIndex = 6 Then SevenOCRectangle = myBlobsArrayX(BlobSIndex).Rectangle
                            If OCIndex = 2 Then
                                ThirdOCRectangle = New Drawing.Rectangle(myBlobsArrayX(BlobSIndex).Rectangle.X, SecondOCRectangle.Y, myBlobsArrayX(BlobSIndex).Rectangle.Width, SecondOCRectangle.Height + 5)
                                Dim myOC As Drawing.Bitmap = (New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(ThirdOCRectangle)).Apply(myOpenningLP))
                                OCCharIdentified = Perceptron.PerceptronIdentifiedOC(myOC, OCRType.OCRCharacter, myAnalyze)
                                LPRecognizerReport += "OCIndex:" + OCIndex.ToString + "  OCChar:" + OCCharIdentified + vbCrLf + myAnalyze + vbCrLf
                            Else
                                Dim myOC As Drawing.Bitmap = (New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(myBlobsArrayX(BlobSIndex).Rectangle)).Apply(myOpenningLP))
                                OCCharIdentified = Perceptron.PerceptronIdentifiedOC(myOC, OCRType.OCRDigit, myAnalyze)
                                LPRecognizerReport += "OCIndex:" + OCIndex.ToString + "  OCChar:" + OCCharIdentified + vbCrLf + myAnalyze + vbCrLf
                            End If
                            If OCIndex = 0 Or OCIndex = 1 Then myRecognizedLPPelakFirst = myRecognizedLPPelakFirst & OCCharIdentified
                            If OCIndex = 2 Then myRecognizedLPPelakCharacter = OCCharIdentified
                            If OCIndex = 3 Or OCIndex = 4 Or OCIndex = 5 Then myRecognizedLPPelakSecond = myRecognizedLPPelakSecond & OCCharIdentified
                            If OCIndex >= 6 Then myRecognizedLPSerial += OCCharIdentified
                            OCIndex += 1
                            If OCIndex > 7 Then Exit Do
                        End If
                    End If
                    BlobSCount += 1
                Loop Until BlobSCount > myBCX.ObjectsCount
                Return New LicensePlateManagement.R2StandardLicensePlateStructure(myRecognizedLPPelakSecond & myRecognizedLPPelakCharacter & myRecognizedLPPelakFirst, myRecognizedLPSerial, "ايران", LicensePlateManagement.R2PelakType.Savari)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function IsBlobBlue(ByVal YourBlob As AForge.Imaging.Blob) As Boolean
            Dim PixelManagement As R2CoreLPRPixelManagement = New R2CoreLPRPixelManagement
            Dim myBMP As Drawing.Bitmap = Nothing
            Dim Rect As Drawing.Rectangle
            Dim bmpData As System.Drawing.Imaging.BitmapData
            Dim ptr As IntPtr
            Dim bytes As Int64
            Dim rgbValues() As Byte
            Dim W As Int32

            ''Dim BlobImage As Drawing.Bitmap = Nothing
            ''myBCX.ExtractBlobsImage(BlobImage, YourBlob, True)
            ''If YourBlob.Image Is Nothing Then Return True
            myBMP = YourBlob.Image.ToManagedImage

            Try
                Rect = New Drawing.Rectangle(0, 0, myBMP.Width, myBMP.Height)
                bmpData = myBMP.LockBits(Rect, Drawing.Imaging.ImageLockMode.ReadWrite, Drawing.Imaging.PixelFormat.Format24bppRgb)
                W = bmpData.Stride
                ptr = bmpData.Scan0
                bytes = Math.Abs(bmpData.Stride) * myBMP.Height
                ReDim rgbValues(bytes)
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

                Dim Taeed As Boolean = False
                For LoopX As UInt32 = 0 To myBMP.Width - 5
                    For LoopY As UInt32 = 0 To myBMP.Height - 5
                        RedHueCounter = 0 : GreenHueCounter = 0 : BlueHueCounter = 0
                        B = rgbValues(LoopX * 3 + LoopY * W)
                        G = rgbValues(LoopX * 3 + LoopY * W + 1)
                        R = rgbValues(LoopX * 3 + LoopY * W + 2)
                        HSL = AForge.Imaging.HSL.FromRGB(New AForge.Imaging.RGB(R, G, B))
                        If PixelManagement.IsBluePixelInBlueRegion(HSL) = True Then
                            BlueHueCounter += 1
                        End If
                        If (BlueHueCounter >= 10) Then
                            Taeed = True
                            Exit For
                        End If
                    Next
                    If Taeed = True Then Exit For
                Next
                myBMP.UnlockBits(bmpData)
                If Taeed = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function GetLPFromCandidateNew(ByRef YourCandidate As Drawing.Bitmap, ByRef LPRecognizerReport As String) As LicensePlateManagement.R2StandardLicensePlateStructure
            Dim Perceptron As R2CoreLPRPerceptron = New R2CoreLPRPerceptron
            Try
                'Gray LP
                Dim myGrayLP As Drawing.Bitmap = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.RMY.Apply(YourCandidate)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myGrayLP, "Gray LP")
                Dim Otsu As OtsuDll.Otsu = New OtsuDll.Otsu
                Dim OtsuT As Integer = Otsu.getOtsuThreshold(myGrayLP)
                Dim myALP As Single = GetThresholdLevel(myGrayLP)
                If Math.Abs(OtsuT - myALP) > OtsuALPDif Then
                    myGrayLP = (New AForge.Imaging.Filters.GammaCorrection(OtsuALPGammaCorrection)).Apply(myGrayLP)
                    ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myGrayLP, "Gray LP GamaCorrection")
                    OtsuT = Otsu.getOtsuThreshold(myGrayLP)
                End If
                'ThresholdLP
                Dim myThresholdLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Threshold(OtsuT)).Apply(myGrayLP)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myThresholdLP, "ThresholdLP")
                'InvertLP
                Dim myInvertLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Invert).Apply(myThresholdLP)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myInvertLP, "InvertLP")
                'OpenningLP
                Dim se(,) As Short = New Short(,) {{0, 1, 0}, {1, 1, 1}, {0, 1, 0}}
                Dim myOpenningLP As Drawing.Bitmap = (New AForge.Imaging.Filters.Opening(se)).Apply(myInvertLP)
                ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage(myOpenningLP, "OpenningLP")
                'BlobCountering OpenningLp
                myBCX.BackgroundThreshold = Drawing.Color.Black
                myBCX.ObjectsOrder = AForge.Imaging.ObjectsOrder.XY
                myBCX.ProcessImage(myOpenningLP)
                ReDim myBlobsArrayX(myBCX.ObjectsCount)
                myBlobsArrayX = myBCX.GetObjectsInformation
                Dim myOCArray(myBlobsArrayX.Count - 1) As OCStracture
                For LoopFillOCArray As UInt64 = 0 To myBlobsArrayX.Count - 1
                    myBCX.ExtractBlobsImage(myOpenningLP, myBlobsArrayX(LoopFillOCArray), True)
                    myOCArray(LoopFillOCArray) = New OCStracture
                Next
                Dim IdentifiedOCCount As UInt16 = 0
                Dim IdentifiedFlag As Boolean = False
                Dim LineAngle As Double = 0
                For LoopOC As Int16 = myBCX.ObjectsCount - 1 To 0 Step -1
                    Dim myCBlob As AForge.Imaging.Blob = myBlobsArrayX(LoopOC)
                    ''If IsBlobBlue(myCBlob) = False Then
                    'کنترل طول و عرض بلوب
                    If myCBlob.Rectangle.Width >= OCWidthMin And myCBlob.Rectangle.Width <= OCWidthMax And myCBlob.Rectangle.Height >= OCHeightMin And myCBlob.Rectangle.Height <= OCHeightMax Then
                        ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage((New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(myCBlob.Rectangle)).Apply(YourCandidate)), "First CandidateOC")
                        'کنترل مساحت
                        If (myCBlob.Area >= OCAreaMin) And (myCBlob.Area <= OCAreaMax) Then
                            ''If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage((New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(myCBlob.Rectangle)).Apply(YourCandidate)), "First CandidateOC")
                            'کنترل نسبت اضلاع
                            If (myCBlob.Rectangle.Width / myCBlob.Rectangle.Height >= OCRatioMin) And (myCBlob.Rectangle.Width / myCBlob.Rectangle.Height <= OCRatioMax) Then
                                ''MessageBox.Show("First Blob Area:" + myCBlob.Area.ToString)
                                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreConfigurations.ProgrammerDebugFlag, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then ViewCarImage((New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(myCBlob.Rectangle)).Apply(YourCandidate)), "First CandidateOC")
                                IdentifiedOCCount = 1
                                For LoopClearOCArray As Integer = 0 To myBCX.ObjectsCount - 1
                                    myOCArray(LoopClearOCArray).Status = True
                                Next
                                myOCArray(LoopOC).Status = False
                                For LoopOCSecond As UInt16 = 0 To myBCX.ObjectsCount - 1
                                    Dim myCBlobNew As AForge.Imaging.Blob = myBlobsArrayX(LoopOCSecond)
                                    ''If IsBlobBlue(myCBlobNew) = False Then
                                    'کنترل طول و عرض بلوب
                                    If myCBlobNew.Rectangle.Width >= OCWidthMin And myCBlobNew.Rectangle.Width <= OCWidthMax And myCBlobNew.Rectangle.Height >= OCHeightMin And myCBlobNew.Rectangle.Height <= OCHeightMax Then
                                        'کنترل مساحت
                                        If (myCBlobNew.Area >= OCAreaMin) And (myCBlobNew.Area <= OCAreaMax) Then
                                            'کنترل نسبت اضلاع
                                            If (myCBlobNew.Rectangle.Width / myCBlobNew.Rectangle.Height >= OCRatioMin) And (myCBlobNew.Rectangle.Width / myCBlobNew.Rectangle.Height <= OCRatioMax) Then
                                                'کنترل در یک خط بودن بلوب کاراکتر با بلوب اصلی یافت شده
                                                Try
                                                    'ممکن است پلاک کاملا افقی باشد
                                                    LineAngle = Math.Atan(Math.Abs(myBlobsArrayX(LoopOCSecond).Rectangle.Y - myBlobsArrayX(LoopOC).Rectangle.Y) / (Math.Abs(myBlobsArrayX(LoopOCSecond).Rectangle.X - myBlobsArrayX(LoopOC).Rectangle.X)))
                                                Catch ex As Exception
                                                End Try
                                                If (myBlobsArrayX(LoopOC).Rectangle.Left < myBlobsArrayX(LoopOCSecond).Rectangle.Left) And (Math.Abs(myBlobsArrayX(LoopOC).Rectangle.Top - myBlobsArrayX(LoopOCSecond).Rectangle.Top) < 20) And (LineAngle <= OCyDifFromLPHalf) Then
                                                    'If R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ProgrammerDebugFlag", "ProgrammerDebugFlag") = True Then ViewCarImage((New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(myCBlobNew.Rectangle)).Apply(YourCandidate)), "Other CandidateOC" + vbCrLf + "IdentifiedOCCount=" + IdentifiedOCCount.ToString)
                                                    'MessageBox.Show(LineAngle)
                                                    IdentifiedOCCount += 1
                                                    myOCArray(LoopOCSecond).Status = False
                                                End If
                                            End If
                                        End If
                                    End If
                                    ''End If
                                Next
                                If IdentifiedOCCount >= 8 Then
                                    IdentifiedFlag = True
                                    Exit For
                                End If
                            End If
                        End If
                    End If
                    ''End If
                Next

                If IdentifiedFlag = False Then
                    LPRecognizerReport = "IdentifiedOCCount < 8"
                    Return Nothing
                End If

                'مرتب کردن کاراکترها
                Dim BlobSIndex As Byte = 0
                Dim BlobSCount As Byte = 0
                Dim OCIndex As Byte = 0
                Dim SevenOCRectangle As Drawing.Rectangle
                Dim OCCharIdentified As Char
                Dim SecondOCRectangle As Drawing.Rectangle
                Dim ThirdOCRectangle As Drawing.Rectangle
                Dim myAnalyze As String
                Dim myRecognizedLPPelakFirst As String = ""
                Dim myRecognizedLPPelakCharacter As String = ""
                Dim myRecognizedLPPelakSecond As String = ""
                Dim myRecognizedLPSerial As String = ""
                Do
                    Dim myMinX As UInt32 = myOpenningLP.Width
                    For LoopMin As UInt16 = 0 To myBCX.ObjectsCount - 1
                        If (myBlobsArrayX(LoopMin).Rectangle.Left < myMinX) And (myOCArray(LoopMin).Status = False) Then
                            myMinX = myBlobsArrayX(LoopMin).Rectangle.Left
                            BlobSIndex = LoopMin
                        End If
                    Next
                    If myMinX < myOpenningLP.Width Then
                        myOCArray(BlobSIndex).Status = True
                        Dim OCTaeed As Boolean
                        If OCIndex <> 7 Then
                            OCTaeed = True
                        End If
                        If (OCIndex = 7) Then
                            If (myBlobsArrayX(BlobSIndex).Rectangle.Left >= SevenOCRectangle.Right - 3) And (Math.Abs(myBlobsArrayX(BlobSIndex).Rectangle.Top - SevenOCRectangle.Top) <= 5) Then
                                OCTaeed = True
                            Else
                                OCTaeed = False
                            End If
                        End If

                        If OCTaeed = True Then
                            If OCIndex = 1 Then SecondOCRectangle = myBlobsArrayX(BlobSIndex).Rectangle
                            If OCIndex = 6 Then SevenOCRectangle = myBlobsArrayX(BlobSIndex).Rectangle
                            If OCIndex = 2 Then
                                ThirdOCRectangle = New Drawing.Rectangle(myBlobsArrayX(BlobSIndex).Rectangle.X, SecondOCRectangle.Y, myBlobsArrayX(BlobSIndex).Rectangle.Width, SecondOCRectangle.Height + 5)
                                Dim myOC As Drawing.Bitmap = (New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(ThirdOCRectangle)).Apply(myOpenningLP))
                                OCCharIdentified = Perceptron.PerceptronIdentifiedOC(myOC, OCRType.OCRCharacter, myAnalyze)
                                LPRecognizerReport += "OCIndex:" + OCIndex.ToString + "  OCChar:" + OCCharIdentified + vbCrLf + myAnalyze + vbCrLf
                            Else
                                Dim myOC As Drawing.Bitmap = (New AForge.Imaging.Filters.ResizeNearestNeighbor(OCWidth, OCHeight)).Apply((New AForge.Imaging.Filters.Crop(myBlobsArrayX(BlobSIndex).Rectangle)).Apply(myOpenningLP))
                                OCCharIdentified = Perceptron.PerceptronIdentifiedOC(myOC, OCRType.OCRDigit, myAnalyze)
                                LPRecognizerReport += "OCIndex:" + OCIndex.ToString + "  OCChar:" + OCCharIdentified + vbCrLf + myAnalyze + vbCrLf
                            End If
                            If OCIndex = 0 Or OCIndex = 1 Then myRecognizedLPPelakFirst = myRecognizedLPPelakFirst & OCCharIdentified
                            If OCIndex = 2 Then myRecognizedLPPelakCharacter = OCCharIdentified
                            If OCIndex = 3 Or OCIndex = 4 Or OCIndex = 5 Then myRecognizedLPPelakSecond = myRecognizedLPPelakSecond & OCCharIdentified
                            If OCIndex >= 6 Then myRecognizedLPSerial += OCCharIdentified
                            OCIndex += 1
                            If OCIndex > 7 Then Exit Do
                        End If
                    End If
                    BlobSCount += 1
                Loop Until BlobSCount > myBCX.ObjectsCount
                Return New LicensePlateManagement.R2StandardLicensePlateStructure(myRecognizedLPPelakSecond & myRecognizedLPPelakCharacter & myRecognizedLPPelakFirst, myRecognizedLPSerial, "ايران", LicensePlateManagement.R2PelakType.Savari)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class OCStracture
        Private myC As Char
        Private myStatus As Boolean
        Public Property C As Char
            Get
                Return myC
            End Get
            Set(ByVal value As Char)
                myC = value
            End Set
        End Property
        Public Property Status As Boolean
            Get
                Return myStatus
            End Get
            Set(ByVal value As Boolean)
                myStatus = value
            End Set
        End Property
    End Class

    Public Enum OCRType
        OCRDigit = 1
        OCRCharacter = 2
    End Enum

    Public Class R2CoreLPRMClassLicensePlateRecognizer

    End Class

End Namespace

Namespace ConfigurationManagement

    Public MustInherit Class R2CoreLPRConfigurations
        Inherits R2CoreConfigurations

        Public Shared ReadOnly Property LicensePalte1 As Int64 = 35
        Public Shared ReadOnly Property LicensePalte2 As Int64 = 36
        Public Shared ReadOnly Property LicensePalte3 As Int64 = 37
        Public Shared ReadOnly Property LicensePalte4 As Int64 = 38

    End Class

    Public NotInheritable Class R2CoreLPRMClassConfigurationManagement
    End Class

End Namespace