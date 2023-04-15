
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Reflection
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Text

Imports R2Core.AuthenticationManagement
Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.FileShareRawGroupsManagement
Imports R2Core.NetworkInternetManagement.Exceptions
Imports R2Core.DesktopProcessesManagement
Imports R2Core.PublicProc
Imports R2Core.R2PrimaryFileSharingWS
Imports R2Core.SoftwareUserManagement
Imports R2Core.SoftwareUserManagement.Exceptions
Imports R2Core.SecurityAlgorithmsManagement.Hashing
Imports R2Core.LoggingManagement.ExceptionManagemen
Imports R2Core.SecurityAlgorithmsManagement.AESAlgorithms
Imports R2Core.SecurityAlgorithmsManagement.Captcha
Imports R2Core.SecurityAlgorithmsManagement.ExpressionValidationAlgorithms
Imports R2Core.PredefinedMessagesManagement
Imports R2Core.SecurityAlgorithmsManagement.ExpressionValidationAlgorithms.Exceptions
Imports R2Core.SecurityAlgorithmsManagement
Imports R2Core.SecurityAlgorithmsManagement.PasswordStrength
Imports R2Core.LoggingManagement
Imports R2Core.SecurityAlgorithmsManagement.SQLInjectionPrevention
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2Core.RFIDCardsManagement.Exceptions
Imports R2Core.SMS

Public Class R2Enums

    Public Enum OnlyDigit
        None = 0
        OnlyDigit = 1
        OnlyChar = 2
        Any = 3
    End Enum
    Public Enum R2CoreColor
        None = 0
        Black = 1
        Red = 2
        Green = 3
        White = 4
    End Enum
    Public Enum EditLevel
        LowLevel = 1
        HighLevel = 2
    End Enum
    Public Enum RaiseEventFlag
        RaiseEventFlagFalse = 0
        RaiseEventFlagTrue = 1
    End Enum
    Public Enum FrmcDisplayState
        None = 0
        Hide = 1
        Show = 2
    End Enum
    Public Enum SortOrder
        Code = 1
        Name = 2
    End Enum
    Public Enum ComboViewState
        Simple = 1
        DropDown = 2
    End Enum
    Public Enum AscDescSorting
        Asc = 1
        Desc = 2
    End Enum
    Public Enum UCComboStateDecision
        SearchingStrSate = 1
        OptionalState1 = 2
        Sorting = 3
        OptionalState2 = 4
        Refreshing = 5
        Loading = 6
    End Enum

    Public Enum InputLanguageType
        None = 0
        Persian = 1
        English = 2
    End Enum

    Public Enum MaxMin
        None = 0
        Max = 1
        Min = 2
    End Enum

    Public Enum MessageDialogType
        None = 0
        ErrorType = 1
        ErrorInDataEntry = 2
        Warning = 3
        SuccessProccess = 4
        Information = 5
    End Enum


End Class

Namespace NetworkInternetManagement

    Public NotInheritable Class R2CoreMClassComputerMessagesManagement

        Public Shared Function IsInternetAvailable() As Boolean
            Try
                If My.Computer.Network.Ping("8.8.8.8") Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As PingException
                Throw New ConnectionIsNotAvailableException
            Catch ex As InvalidOperationException
                Throw New ConnectionIsNotAvailableException
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsThisSiteAvailable(YourSiteURLorIP As String) As Boolean
            Try
                If My.Computer.Network.Ping(YourSiteURLorIP) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As PingException
                Throw ex
            Catch ex As InvalidOperationException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Namespace Exceptions

        Public Class InternetIsnotAvailableException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اتصال به اینترنت امکان پذیر نیست.اتصالات شبکه و اینترنت را بررسی نمایید"
                End Get
            End Property
        End Class

        Public Class ConnectionIsNotAvailableException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اتصال به شبکه امکان پذیر نیست.اتصالات شبکه را بررسی نمایید"
                End Get
            End Property
        End Class


    End Namespace




End Namespace

Namespace PublicProc
    Public Class R2CoreInstancePublicProceduresManager
        Private _R2PrimaryFSWS = New R2PrimaryFileSharingWebService()

        Public Sub SaveFile(YourRawGroupId As Int64, YourFileName As String, YourFile As Byte(), YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Try
                _R2PrimaryFSWS.WebMethodSaveFile(YourRawGroupId, YourFileName, YourFile, _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Function IsExistFile(YourRawGroupId As Int64, YourFileName As String, YourNSSUser As R2CoreStandardSoftwareUserStructure) As Boolean
            Try
                Return _R2PrimaryFSWS.WebMethodIOFileExist(YourRawGroupId, YourFileName, _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Function GetFile(YourRawGroupId As Int64, YourFileName As String, YourNSSUser As R2CoreStandardSoftwareUserStructure) As Byte()
            Try
                Return _R2PrimaryFSWS.WebMethodGetFile(YourRawGroupId, YourFileName, _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Function ParseSignDigitToSignString(ByVal YourDig As Int64) As String
            Try
                If YourDig < 0 Then
                    Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "-"
                ElseIf YourDig > 0 Then
                    Return R2MakeCamaYourDigit(Math.Abs(YourDig))
                ElseIf YourDig = 0 Then
                    Return R2MakeCamaYourDigit(Math.Abs(YourDig))
                Else
                    Throw New ArgumentException
                End If
            Catch ex As ArgumentException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Function R2MakeCamaYourDigit(ByVal xdig As UInt64) As String
            Dim myDigit As String
            Dim yourDigit As String
            Try
                myDigit = xdig
                If Len(myDigit) <= 3 Then Return xdig
                yourDigit = ""
                For loopx As Int16 = 1 To Math.Ceiling(Len(myDigit) / 3)
                    If loopx <> Math.Ceiling(Len(myDigit) / 3) Then
                        yourDigit = "," + Mid(myDigit, (Len(myDigit) - 3 * loopx) + 1, 3) + yourDigit
                    Else
                        yourDigit = Mid(myDigit, 1, Len(myDigit) - (Math.Ceiling(Len(myDigit) / 3) - 1) * 3) + yourDigit
                    End If
                Next
                Return yourDigit
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        'رنگ سیه و سفید مناسب یک پس زمینه
        Public Function IdealBlackWhiteTextColor(YourBackGroundColor As Color) As Color
            Dim nThreshold As Int64 = 105
            Dim bgDelta As Int64 = Convert.ToInt32((YourBackGroundColor.R * 0.299) + (YourBackGroundColor.G * 0.587) + (YourBackGroundColor.B * 0.114))
            Dim foreColor As Color = IIf(255 - bgDelta < nThreshold, Color.Black, Color.White)
            Return foreColor
        End Function

        Private DaDiff As New SqlClient.SqlDataAdapter
        Private DsDiff As New DataSet
        Public Function GetDateDiff(YourDateInterval As Microsoft.VisualBasic.DateInterval, ByVal YourMilladiDate1 As Date, ByVal YourMilladiDate2 As Date) As Long
            Try
                If YourDateInterval = DateInterval.Day Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Day ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                ElseIf YourDateInterval = DateInterval.Minute Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Minute ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                ElseIf YourDateInterval = DateInterval.Hour Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Hour ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                ElseIf YourDateInterval = DateInterval.Second Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Second ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                End If
                DaDiff.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                DsDiff.Tables.Clear()
                DaDiff.Fill(DsDiff)
                Return DsDiff.Tables(0).Rows(0).Item("DD")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function RepeatStr(ByVal Str As String, ByVal Counts As Int16) As String
            Dim myStr As String = ""
            Try
                For loopx As Int16 = 1 To Counts
                    myStr += Str
                Next
                Return myStr
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function


    End Class

    Public Class R2CoreMClassPublicProcedures
        'رنگ سیه و سفید مناسب یک پس زمینه
        Public Shared Function IdealBlackWhiteTextColor(YourBackGroundColor As Color) As Color
            Dim nThreshold As Int64 = 105
            Dim bgDelta As Int64 = Convert.ToInt32((YourBackGroundColor.R * 0.299) + (YourBackGroundColor.G * 0.587) + (YourBackGroundColor.B * 0.114))
            Dim foreColor As Color = IIf(255 - bgDelta < nThreshold, Color.Black, Color.White)
            Return foreColor
        End Function

        'توليد تاريخ بعدي از يك تاريخ شمسي
        Public Shared Function GetNextShamsiDate(ByVal YourShamsiDate As String) As String
            Try
                Dim myTempDate As String = YourShamsiDate  'Example 1394/02/31
                Dim myD As Int16 = Mid(myTempDate, 9, 2)
                Dim myM As Int16 = Mid(myTempDate, 6, 2)
                Dim myY As Int16 = Mid(myTempDate, 1, 4)
                If myM >= 1 And myM <= 6 Then
                    If myD < 31 Then
                        myD += 1
                    Else
                        myD = 1
                        myM += 1
                    End If
                ElseIf myM >= 7 And myM <= 11 Then
                    If myD < 30 Then
                        myD += 1
                    Else
                        myD = 1
                        myM += 1
                    End If
                ElseIf myM = 12 Then
                    If myD < R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.EsfandRooz, 0) Then
                        myD += 1
                    Else
                        myD = 1
                        myM = 1
                        myY += 1
                    End If
                End If
                Dim myDS As String = R2CoreMClassPublicProcedures.RepeatStr("0", 2 - Len(myD.ToString.Trim)) + myD.ToString.Trim
                Dim myMS As String = R2CoreMClassPublicProcedures.RepeatStr("0", 2 - Len(myM.ToString.Trim)) + myM.ToString.Trim
                Return myY.ToString.Trim + "/" + myMS.Trim + "/" + myDS.Trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'تبديل يک عدد به حروف
        Public Shared Function R2MakeHoroof(ByVal yournum As String) As String
            Try
                Dim mynum As String = Trim(yournum).Replace(",", "")
                Dim makan As Int16
                Dim dig As String
                Dim varhichy As String
                Dim finalstr As String = ""
                For loopx As Int16 = 1 To Len(mynum)
                    makan = Len(mynum) - (loopx - 1)
                    dig = Mid(mynum, loopx, 1)
                    If makan = 12 Then
                        If dig = "9" Then finalstr = " نهصد "
                        If dig = "8" Then finalstr = " هشتصد "
                        If dig = "7" Then finalstr = " هفتصد "
                        If dig = "6" Then finalstr = " ششصد "
                        If dig = "5" Then finalstr = " پانصد "
                        If dig = "4" Then finalstr = " چهارصد "
                        If dig = "3" Then finalstr = " سيصد "
                        If dig = "2" Then finalstr = " دويست "
                        If dig = "1" Then finalstr = " يکصد "
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 11 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نود "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتاد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتاد "
                        If dig = "6" Then finalstr = finalstr + "و" + " شصت "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنجاه "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهل "
                        If dig = "3" Then finalstr = finalstr + "و" + " سي "
                        If dig = "2" Then finalstr = finalstr + "و" + " بيست "
                        If dig = "1" Then
                            Dim my10makandig As String = Mid(mynum, 3, 1)
                            If my10makandig = "9" Then finalstr = finalstr + "و" + " نوزده " + " ميليارد "
                            If my10makandig = "8" Then finalstr = finalstr + "و" + " هجده " + " ميليارد "
                            If my10makandig = "7" Then finalstr = finalstr + "و" + " هفده " + " ميليارد "
                            If my10makandig = "6" Then finalstr = finalstr + "و" + " شانزده " + " ميليارد "
                            If my10makandig = "5" Then finalstr = finalstr + "و" + " پانزده " + " ميليارد "
                            If my10makandig = "4" Then finalstr = finalstr + "و" + " چهارده " + " ميليارد "
                            If my10makandig = "3" Then finalstr = finalstr + "و" + " سيزده " + " ميليارد "
                            If my10makandig = "2" Then finalstr = finalstr + "و" + " دوازده " + " ميليارد "
                            If my10makandig = "1" Then finalstr = finalstr + "و" + " يازده " + " ميليارد "
                            If my10makandig = "0" Then finalstr = finalstr + "و" + " ده " + " ميليارد "
                            loopx += 1
                        End If
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 10 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نه " + " ميليارد "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشت " + " ميليارد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفت " + " ميليارد "
                        If dig = "6" Then finalstr = finalstr + "و" + " شش " + " ميليارد "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنج " + " ميليارد "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهار " + " ميليارد "
                        If dig = "3" Then finalstr = finalstr + "و" + " سه " + " ميليارد "
                        If dig = "2" Then finalstr = finalstr + "و" + " دو " + " ميليارد "
                        If dig = "1" Then finalstr = finalstr + "و" + " يک " + " ميليارد "
                        If dig = "0" Then
                            Try
                                If Mid(mynum, loopx - 2, 3) <> 0 Then
                                    finalstr = finalstr + " ميليارد "
                                End If
                            Catch ex As Exception
                                finalstr = finalstr + " ميليارد "
                            End Try
                        End If
                    End If
                    If makan = 9 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نهصد "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتصد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتصد "
                        If dig = "6" Then finalstr = finalstr + "و" + " ششصد "
                        If dig = "5" Then finalstr = finalstr + "و" + " پانصد "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهارصد "
                        If dig = "3" Then finalstr = finalstr + "و" + " سيصد "
                        If dig = "2" Then finalstr = finalstr + "و" + " دويست "
                        If dig = "1" Then finalstr = finalstr + "و" + " يکصد "
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 8 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نود "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتاد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتاد "
                        If dig = "6" Then finalstr = finalstr + "و" + " شصت "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنجاه "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهل "
                        If dig = "3" Then finalstr = finalstr + "و" + " سي "
                        If dig = "2" Then finalstr = finalstr + "و" + " بيست "
                        If dig = "1" Then
                            Dim my7makandig As String = Mid(mynum, Len(mynum) - 6, 1)
                            If my7makandig = "9" Then finalstr = finalstr + "و" + " نوزده " + " ميليون "
                            If my7makandig = "8" Then finalstr = finalstr + "و" + " هجده " + " ميليون "
                            If my7makandig = "7" Then finalstr = finalstr + "و" + " هفده " + " ميليون "
                            If my7makandig = "6" Then finalstr = finalstr + "و" + " شانزده " + " ميليون "
                            If my7makandig = "5" Then finalstr = finalstr + "و" + " پانزده " + " ميليون "
                            If my7makandig = "4" Then finalstr = finalstr + "و" + " چهارده " + " ميليون "
                            If my7makandig = "3" Then finalstr = finalstr + "و" + " سيزده " + " ميليون "
                            If my7makandig = "2" Then finalstr = finalstr + "و" + " دوازده " + " ميليون "
                            If my7makandig = "1" Then finalstr = finalstr + "و" + " يازده " + " ميليون "
                            If my7makandig = "0" Then finalstr = finalstr + "و" + " ده " + " ميليون "
                            loopx += 1
                        End If
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 7 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نه " + " ميليون "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشت " + " ميليون "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفت " + " ميليون "
                        If dig = "6" Then finalstr = finalstr + "و" + " شش " + " ميليون "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنج " + " ميليون "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهار " + " ميليون "
                        If dig = "3" Then finalstr = finalstr + "و" + " سه " + " ميليون "
                        If dig = "2" Then finalstr = finalstr + "و" + " دو " + " ميليون "
                        If dig = "1" Then finalstr = finalstr + "و" + " يک " + " ميليون "
                        If dig = "0" Then
                            Try
                                If Mid(mynum, loopx - 2, 3) <> 0 Then
                                    finalstr = finalstr + " ميليون "
                                End If
                            Catch ex As Exception
                                finalstr = finalstr + " ميليون "
                            End Try
                        End If
                    End If
                    If makan = 6 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نهصد "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتصد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتصد "
                        If dig = "6" Then finalstr = finalstr + "و" + " ششصد "
                        If dig = "5" Then finalstr = finalstr + "و" + " پانصد "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهارصد "
                        If dig = "3" Then finalstr = finalstr + "و" + " سيصد "
                        If dig = "2" Then finalstr = finalstr + "و" + " دويست "
                        If dig = "1" Then finalstr = finalstr + "و" + " يکصد "
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 5 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نود "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتاد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتاد "
                        If dig = "6" Then finalstr = finalstr + "و" + " شصت "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنجاه "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهل "
                        If dig = "3" Then finalstr = finalstr + "و" + " سي "
                        If dig = "2" Then finalstr = finalstr + "و" + " بيست "
                        If dig = "1" Then
                            Dim my4makandig As String = Mid(mynum, Len(mynum) - 3, 1)
                            If my4makandig = "9" Then finalstr = finalstr + "و" + " نوزده " + " هزار "
                            If my4makandig = "8" Then finalstr = finalstr + "و" + " هجده " + " هزار "
                            If my4makandig = "7" Then finalstr = finalstr + "و" + " هفده " + " هزار "
                            If my4makandig = "6" Then finalstr = finalstr + "و" + " شانزده " + " هزار "
                            If my4makandig = "5" Then finalstr = finalstr + "و" + " پانزده " + " هزار "
                            If my4makandig = "4" Then finalstr = finalstr + "و" + " چهارده " + " هزار "
                            If my4makandig = "3" Then finalstr = finalstr + "و" + " سيزده " + " هزار "
                            If my4makandig = "2" Then finalstr = finalstr + "و" + " دوازده " + " هزار "
                            If my4makandig = "1" Then finalstr = finalstr + "و" + " يازده " + " هزار "
                            If my4makandig = "0" Then finalstr = finalstr + "و" + " ده " + " هزار "
                            loopx += 1
                        End If
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 4 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نه " + " هزار "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشت " + " هزار "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفت " + " هزار "
                        If dig = "6" Then finalstr = finalstr + "و" + " شش " + " هزار "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنج " + " هزار "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهار " + " هزار "
                        If dig = "3" Then finalstr = finalstr + "و" + " سه " + " هزار "
                        If dig = "2" Then finalstr = finalstr + "و" + " دو " + " هزار "
                        If dig = "1" Then finalstr = finalstr + "و" + " يک " + " هزار "
                        If dig = "0" Then
                            Try
                                If Mid(mynum, loopx - 2, 3) <> 0 Then
                                    finalstr = finalstr + " هزار "
                                End If
                            Catch ex As Exception
                                finalstr = finalstr + " هزار "
                            End Try

                        End If
                    End If

                    If makan = 3 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نهصد "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتصد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتصد "
                        If dig = "6" Then finalstr = finalstr + "و" + " ششصد "
                        If dig = "5" Then finalstr = finalstr + "و" + " پانصد "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهارصد "
                        If dig = "3" Then finalstr = finalstr + "و" + " سيصد "
                        If dig = "2" Then finalstr = finalstr + "و" + " دويست "
                        If dig = "1" Then finalstr = finalstr + "و" + " يکصد"
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 2 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نود "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشتاد "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفتاد "
                        If dig = "6" Then finalstr = finalstr + "و" + " شصت "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنجاه "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهل "
                        If dig = "3" Then finalstr = finalstr + "و" + " سي "
                        If dig = "2" Then finalstr = finalstr + "و" + " بيست "
                        If dig = "1" Then
                            Dim my1makandig As String = Mid(mynum, Len(mynum), 1)
                            If my1makandig = "9" Then finalstr = finalstr + "و" + " نوزده "
                            If my1makandig = "8" Then finalstr = finalstr + "و" + " هجده "
                            If my1makandig = "7" Then finalstr = finalstr + "و" + " هفده "
                            If my1makandig = "6" Then finalstr = finalstr + "و" + " شانزده "
                            If my1makandig = "5" Then finalstr = finalstr + "و" + " پانزده "
                            If my1makandig = "4" Then finalstr = finalstr + "و" + " چهارده "
                            If my1makandig = "3" Then finalstr = finalstr + "و" + " سيزده "
                            If my1makandig = "2" Then finalstr = finalstr + "و" + " دوازده "
                            If my1makandig = "1" Then finalstr = finalstr + "و" + " يازده "
                            If my1makandig = "0" Then finalstr = finalstr + "و" + " ده "
                            loopx += 1
                        End If
                        If dig = "0" Then varhichy = ""
                    End If
                    If makan = 1 Then
                        If dig = "9" Then finalstr = finalstr + "و" + " نه "
                        If dig = "8" Then finalstr = finalstr + "و" + " هشت "
                        If dig = "7" Then finalstr = finalstr + "و" + " هفت "
                        If dig = "6" Then finalstr = finalstr + "و" + " شش "
                        If dig = "5" Then finalstr = finalstr + "و" + " پنج "
                        If dig = "4" Then finalstr = finalstr + "و" + " چهار "
                        If dig = "3" Then finalstr = finalstr + "و" + " سه "
                        If dig = "2" Then finalstr = finalstr + "و" + " دو "
                        If dig = "1" Then finalstr = finalstr + "و" + " يک "
                        If dig = "0" Then varhichy = ""
                    End If
                Next
                If Mid(finalstr, 1, 1) = "و" Then
                    finalstr = Mid(finalstr, 2, Len(finalstr))
                End If
                Return finalstr
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'تابع تکرار کردن يک کاراکتر يا رشته
        Public Shared Function RepeatStr(ByVal Str As String, ByVal Counts As Int16) As String
            Dim myStr As String = ""
            Try
                For loopx As Int16 = 1 To Counts
                    myStr += Str
                Next
                Return myStr
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'تابع برعکس کردن يک رشته
        Public Shared Function RevertStr(ByVal strr As String) As String
            Dim mystr As String
            Try
                For loopx As Int16 = strr.Length To 1 Step -1
                    mystr = mystr + Mid(strr, loopx, 1)
                Next
                Return mystr
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'روتين برگرداندن وضعيت کليد کپس لوک با استفاده از API
        Private Declare Function GetKeyState Lib "user32.dll" (ByVal nVirtKey As Long) As Int16
        Public Shared Function Getcapslockvz() As Boolean
            Try
                If (GetKeyState(&H14) And &H1) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'روتين تغيير زبان صفحه کليد با استفاده از API
        Public Shared Function Setkeyboardlayout(ByVal YourInputLanguageType As R2Enums.InputLanguageType) As Boolean
            Try
                Return SetKeybLayout(YourInputLanguageType)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function Setkeyboardlayout(ByVal layout As String) As Boolean
            Try
                Return SetKeybLayout(IIf(layout = "English", R2Enums.InputLanguageType.English, R2Enums.InputLanguageType.Persian))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Private Declare Function LoadKeyboardLayout Lib "user32" Alias "LoadKeyboardLayoutA" (ByVal pwszKLID As String, ByVal flags As Integer) As Integer
        Private Shared Function SetKeybLayout(YourInputLanguageType As R2Enums.InputLanguageType) As Boolean
            Try
                Dim mypwszKLID As String = IIf(YourInputLanguageType = R2Enums.InputLanguageType.English, "00000409", "00000429")
                Dim myload As String = LoadKeyboardLayout(mypwszKLID, &H1)
                If myload = "" Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        'حذف نقطه از مقادير عددي که بعد از نقطه 0 است
        Public Shared Function R2ErasePoint(ByVal mypointdg As Double) As String
            Dim mydg As String = Trim(Str(mypointdg))
            If InStr(".", mydg) <= 0 Then Return mydg
            If Len(mydg < 3) Then Return mydg
            If (Mid(mydg, Len(mydg) - 1, 1) = ".") And (Mid(mydg, Len(mydg), 1) = "0") Then
                Return Mid(mydg, 1, Len(mydg) - 2)
            Else
                Return mydg
            End If
        End Function
        'تابع کامادار کردن يک رشته عددي
        Public Shared Function R2MakeCamaYourDigit(ByVal xdig As UInt64) As String
            Dim myDigit As String
            Dim yourDigit As String
            Try
                myDigit = xdig
                If Len(myDigit) <= 3 Then Return xdig
                yourDigit = ""
                For loopx As Int16 = 1 To Math.Ceiling(Len(myDigit) / 3)
                    If loopx <> Math.Ceiling(Len(myDigit) / 3) Then
                        yourDigit = "," + Mid(myDigit, (Len(myDigit) - 3 * loopx) + 1, 3) + yourDigit
                    Else
                        yourDigit = Mid(myDigit, 1, Len(myDigit) - (Math.Ceiling(Len(myDigit) / 3) - 1) * 3) + yourDigit
                    End If
                Next
                Return yourDigit
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'تفسير منفي يا مثبت بودن يك مبلغ
        Public Shared Function ParseSignDigitToTashString(ByVal YourDig As Int64) As String
            Try
                If YourDig < 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "  بدهكار  "
                If YourDig > 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "  بستانكار  "
                If YourDig = 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "  تسويه  "
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        'تفسير منفي يا مثبت بودن يك مبلغ
        Public Shared Function ParseSignDigitToSignString(ByVal YourDig As Int64) As String
            Try
                If YourDig < 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "-"
                If YourDig > 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig))
                If YourDig = 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function GetInvertColor(YourColor As Color) As Color
            Return Color.FromArgb(YourColor.ToArgb() Xor &HFFFFFF)
        End Function

        Private Shared DaDiff As New SqlClient.SqlDataAdapter
        Private Shared DsDiff As New DataSet
        Public Shared Function GetDateDiff(YourDateInterval As Microsoft.VisualBasic.DateInterval, ByVal YourMilladiDate1 As Date, ByVal YourMilladiDate2 As Date) As Long
            Try
                If YourDateInterval = DateInterval.Day Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Day ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                ElseIf YourDateInterval = DateInterval.Minute Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Minute ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                ElseIf YourDateInterval = DateInterval.Hour Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Hour ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                ElseIf YourDateInterval = DateInterval.Second Then
                    DaDiff.SelectCommand = New SqlClient.SqlCommand("select DateDiff(Second ,'" & YourMilladiDate1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ,'" & YourMilladiDate2.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "' ) AS DD")
                End If
                DaDiff.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                DsDiff.Tables.Clear()
                DaDiff.Fill(DsDiff)
                Return DsDiff.Tables(0).Rows(0).Item("DD")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class
End Namespace

Namespace BaseStandardClass
    Public Class R2StandardStructure


        Private myOCode As String
        Private myOName As String

        Public Sub New()
        End Sub
        Public Sub New(ByVal OCodee As String, ByVal ONamee As String)
            Try
                OCode = OCodee
                OName = ONamee
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub
        Public Property OCode() As String
            Get
                Return Trim(myOCode)
            End Get
            Set(ByVal Value As String)
                myOCode = Value
            End Set
        End Property
        Public Property OName() As String
            Get
                Return Trim(myOName)
            End Get
            Set(ByVal Value As String)
                myOName = Value
            End Set
        End Property
    End Class

    Public MustInherit Class R2QueryGeneral

        Private myteadad As Int64

        Public Sub New()
        End Sub

        Public ReadOnly Property Teadad() As Int64
            Get
                Return myteadad
            End Get
        End Property
        Protected WriteOnly Property TeadadSet() As Int64
            Set(ByVal Value As Int64)
                myteadad = Value
            End Set
        End Property

        Public MustOverride Sub Preparing(ByVal PrepareCode As Int16, ByVal SortOrder As R2Enums.SortOrder, Optional ByVal SearchStr As Object = "", Optional ByVal Param1 As Object = Nothing, Optional ByVal Param2 As Object = Nothing, Optional ByVal Param3 As Object = Nothing, Optional ByVal Param4 As Object = Nothing, Optional ByVal Param5 As Object = Nothing, Optional ByVal Param6 As Object = Nothing)
        Public MustOverride Function IsValidOCode(ByVal OCodee As String) As Boolean
        Public MustOverride Function IsValidOName(ByVal ONamee As String) As Boolean
        Public MustOverride Function IsValidOItem(ByVal OItem As String) As Boolean
        Public MustOverride Function GetValidOCodeFromOitem(ByVal OItem As String) As String
        Public MustOverride Function GetValidONameFromOitem(ByVal OItem As String) As String
        Public MustOverride Function GetValidONameFromOCode(ByVal OCodee As String) As String
        Public MustOverride Function GetValidOCodeFromOName(ByVal ONamee As String) As String
        Public MustOverride Function Getindex(ByVal OCode As String) As Int64
        Public MustOverride Function GetIndexBySearchStrInStartCharacters(ByVal SearchStr As String) As Int32
        Public MustOverride Function ExistInQueryOCode(ByVal Ocode As String) As Boolean
        Public MustOverride Function ExistInQueryOName(ByVal OName As String) As Boolean
    End Class

    Public Class MessageStruct
        Public Sub New(YourErrorCode As Boolean, YourMessage1 As String, YourMessage2 As String, YourMessage3 As String)
            ErrorCode = YourErrorCode
            Message1 = YourMessage1
            Message2 = YourMessage2
            Message3 = YourMessage3
        End Sub

        Public ErrorCode As Boolean
        Public Message1 As String
        Public Message2 As String
        Public Message3 As String
    End Class

    Public Structure DataStruct
        Dim Data1 As String
        Dim Data2 As String
        Dim Data3 As String
        Dim Data4 As String
        Dim Data5 As String
    End Structure

    Public Class R2CoreImage

        Private Property CurrentImage() As Image = Nothing

        Private Function ConvertByteArrayToImage(YourByteArray As Byte()) As Image
            Try
                If Not YourByteArray Is Nothing Then
                    Using MS As New MemoryStream(YourByteArray, 0, YourByteArray.Length)
                        MS.Write(YourByteArray, 0, YourByteArray.Length)
                        Return New Bitmap(Image.FromStream(MS))
                    End Using
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function ConvertImageToByteArray(YourImage As Image) As Byte()
            Try
                Dim MS As New MemoryStream()
                Dim Photo As Bitmap = New Bitmap(YourImage, New Size(YourImage.Width, YourImage.Height))
                Photo.Save(MS, ImageFormat.Jpeg)
                Return MS.GetBuffer()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub New(YourImage As Image)
            Try
                CurrentImage = YourImage
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub New(YourByteArray As Byte())
            Try
                CurrentImage = ConvertByteArrayToImage(YourByteArray)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetImage() As Image
            Try
                Return CurrentImage
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetImageByte() As Byte()
            Try
                Return ConvertImageToByteArray(CurrentImage)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function



    End Class

    Public Class R2CoreFile

        Public Sub New()
            FileName = String.Empty
        End Sub

        Public Sub New(YourFileName As String)
            FileName = YourFileName
        End Sub

        Public Property FileName() As String

    End Class



End Namespace

Namespace ComputerMessagesManagement

    Public MustInherit Class R2CoreComputerMessageTypes
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly GeneralMessage As Int64 = 1
    End Class

    Public Class R2StandardComputerMessageTypeStructure
        Private myCMTypeName As String
        Private myCMTypeTitle As String
        Private myAssemblyDll As String
        Private myAssemblyPath As String
        Private myDescription As String
        Private myWorkingGroup As Int64


#Region "Constructing Management"

        Public Sub New()
            MyBase.New()
            CMTypeId = 0
            myCMTypeName = ""
            myCMTypeTitle = ""
            myAssemblyDll = ""
            myAssemblyPath = ""
            SpecialColor = Color.Black
            Automation = False
            myDescription = ""
            myWorkingGroup = 0
        End Sub

        Public Sub New(ByVal YourCMTypeId As Int64, ByVal YourCMTypeName As String, ByVal YourCMTypeTitle As String, ByVal YourAssemblyDll As String, YourAssemblyPath As String, ByVal YourSpecialColor As Color, ByVal YourAutomation As Boolean, YourDescription As String, YourWorkingGroup As Int64)
            CMTypeId = YourCMTypeId
            myCMTypeName = YourCMTypeName
            myCMTypeTitle = YourCMTypeTitle
            myAssemblyDll = YourAssemblyDll
            myAssemblyPath = YourAssemblyPath
            SpecialColor = YourSpecialColor
            Automation = YourAutomation
            myDescription = YourDescription
            myWorkingGroup = YourWorkingGroup
        End Sub

#End Region

#Region "Properting Management"

        Public Property CMTypeId As Int64

        Public Property CMTypeName() As String
            Get
                Return myCMTypeName.Trim
            End Get
            Set(ByVal Value As String)
                myCMTypeName = Value
            End Set
        End Property

        Public Property CMTypeTiltle() As String
            Get
                Return myCMTypeTitle.Trim()
            End Get
            Set(ByVal Value As String)
                myCMTypeTitle = Value
            End Set
        End Property

        Public Property AssemblyDll() As String
            Get
                Return myAssemblyDll.Trim()
            End Get
            Set(ByVal Value As String)
                myAssemblyDll = Value
            End Set
        End Property

        Public Property AssemblyPath() As String
            Get
                Return myAssemblyPath.Trim()
            End Get
            Set(ByVal Value As String)
                myAssemblyPath = Value
            End Set
        End Property

        Public Property SpecialColor As Color
        Public Property Automation As Boolean

        Public Property Description() As String
            Get
                Return myDescription.Trim()
            End Get
            Set(ByVal Value As String)
                myDescription = Value
            End Set
        End Property

        Public Property WorkingGroup() As Int64
            Get
                Return myWorkingGroup
            End Get
            Set(ByVal Value As Int64)
                myWorkingGroup = Value
            End Set
        End Property

#End Region
    End Class

    Public Class R2StandardComputerMessageStructure

        Private myPrimaryId As Int64
        Private myCMNote As String
        Private myCMType As Int64
        Private myCMActive As Boolean
        Private myCMAccessed As Boolean
        Private myComputerId As Int64
        Private myUserId As Int64
        Private myDateTimeMilladi As String
        Private myDateShamsi As String
        Private myTime As String
        Private myDataStruct As DataStruct


#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            myPrimaryId = 0 : myCMNote = "" : myCMType = 0 : myCMActive = False : myCMAccessed = False : myComputerId = 0 : myUserId = 0 : myDateTimeMilladi = Nothing : myDateShamsi = "" : myTime = "" : myDataStruct = Nothing
        End Sub
        Public Sub New(ByVal YourPrimaryId As Int64, ByVal YourCMNote As String, ByVal YourCMType As Int64, ByVal YourCMActive As Boolean, YourCMAccessed As Boolean, ByVal YourComputerId As Int64, ByVal YourUserId As Int64, YourDateTimeMilladi As String, YourDateShamsi As String, YourTime As String, YourDataStruct As DataStruct)
            myPrimaryId = YourPrimaryId
            myCMNote = YourCMNote
            myCMType = YourCMType
            myCMActive = YourCMActive
            myCMAccessed = YourCMAccessed
            myComputerId = YourComputerId
            myUserId = YourUserId
            myDateTimeMilladi = YourDateTimeMilladi
            myDateShamsi = YourDateShamsi
            myTime = YourTime
            myDataStruct = YourDataStruct
        End Sub
#End Region
#Region "Properting Management"
        Public Property PrimaryId() As Int64
            Get
                Return myPrimaryId
            End Get
            Set(ByVal Value As Int64)
                myPrimaryId = Value
            End Set
        End Property
        Public Property CMNote() As String
            Get
                Return myCMNote.Trim
            End Get
            Set(ByVal Value As String)
                myCMNote = Value
            End Set
        End Property
        Public Property CMType() As Int64
            Get
                Return myCMType
            End Get
            Set(ByVal Value As Int64)
                myCMType = Value
            End Set
        End Property
        Public Property CMActive() As Boolean
            Get
                Return myCMActive
            End Get
            Set(ByVal Value As Boolean)
                myCMActive = Value
            End Set
        End Property
        Public Property CMAccessed() As Boolean
            Get
                Return myCMAccessed
            End Get
            Set(ByVal Value As Boolean)
                myCMAccessed = Value
            End Set
        End Property
        Public Property ComputerId() As Int64
            Get
                Return myComputerId
            End Get
            Set(ByVal Value As Int64)
                myComputerId = Value
            End Set
        End Property
        Public Property UserId() As Int64
            Get
                Return myUserId
            End Get
            Set(ByVal Value As Int64)
                myUserId = Value
            End Set
        End Property
        Public Property DateTimeMilladi() As String
            Get
                Return myDateTimeMilladi
            End Get
            Set(ByVal Value As String)
                myDateTimeMilladi = Value
            End Set
        End Property
        Public Property DateShamsi() As String
            Get
                Return myDateShamsi
            End Get
            Set(ByVal Value As String)
                myDateShamsi = Value
            End Set
        End Property
        Public Property Time() As String
            Get
                Return myTime
            End Get
            Set(ByVal Value As String)
                myTime = Value
            End Set
        End Property
        Public Property DataStruct() As DataStruct
            Get
                Return myDataStruct
            End Get
            Set(ByVal Value As DataStruct)
                myDataStruct = Value
            End Set
        End Property

#End Region


    End Class

    Public Class R2CoreMClassComputerMessagesManager
        Private _DateTime As R2DateTime = New R2DateTime()

        Public Sub SendComputerMessage(YourComputerMessage As R2StandardComputerMessageStructure)
            Try
                Dim InstanceComputers = New R2CoreMClassComputersManager
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                SabtComputerMessage(New R2StandardComputerMessageStructure(0, YourComputerMessage.CMNote, YourComputerMessage.CMType, True, False, InstanceComputers.GetNSSCurrentComputer.MId, InstanceSoftwareUsers.GetNSSSystemUser.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), YourComputerMessage.DataStruct))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Sub SabtComputerMessage(YourComputerMessage As R2StandardComputerMessageStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblComputerMessages(CMNote,CMType,CMActive,CMAccessed,ComputerId,UserId,DateTimeMilladi,DateShamsi,Time,Data1,Data2,Data3,Data4,Data5) values('" & YourComputerMessage.CMNote & "'," & YourComputerMessage.CMType & "," & IIf(YourComputerMessage.CMActive = True, 1, 0) & "," & IIf(YourComputerMessage.CMAccessed = True, 1, 0) & "," & YourComputerMessage.ComputerId & "," & YourComputerMessage.UserId & ",'" & YourComputerMessage.DateTimeMilladi & "','" & YourComputerMessage.DateShamsi & "','" & YourComputerMessage.Time & "','" & YourComputerMessage.DataStruct.Data1 & "','" & YourComputerMessage.DataStruct.Data2 & "','" & YourComputerMessage.DataStruct.Data3 & "','" & YourComputerMessage.DataStruct.Data4 & "','" & YourComputerMessage.DataStruct.Data5 & "')"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

    Public NotInheritable Class R2CoreMClassComputerMessagesManagement

        Private Shared _DateTime As R2DateTime = New R2DateTime()

        Public Shared Function GetNSSComputerMessageType(YourCMTypeId As Int64) As R2StandardComputerMessageTypeStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputerMessageTypes Where CMTypeId=" & YourCMTypeId & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2StandardComputerMessageTypeStructure(Ds.Tables(0).Rows(0).Item("CMTypeId"), Ds.Tables(0).Rows(0).Item("CMTypeName").trim, Ds.Tables(0).Rows(0).Item("CMTypeTitle").trim, Ds.Tables(0).Rows(0).Item("AssemblyDll").trim, Ds.Tables(0).Rows(0).Item("AssemblyPath").trim, Color.FromName(Ds.Tables(0).Rows(0).Item("SpecialColor").trim), Ds.Tables(0).Rows(0).Item("Automation"), Ds.Tables(0).Rows(0).Item("Description").trim, Ds.Tables(0).Rows(0).Item("WorkingGroup"))
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Sub SabtComputerMessage(YourComputerMessage As R2StandardComputerMessageStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblComputerMessages(CMNote,CMType,CMActive,CMAccessed,ComputerId,UserId,DateTimeMilladi,DateShamsi,Time,Data1,Data2,Data3,Data4,Data5) values('" & YourComputerMessage.CMNote & "'," & YourComputerMessage.CMType & "," & IIf(YourComputerMessage.CMActive = True, 1, 0) & "," & IIf(YourComputerMessage.CMAccessed = True, 1, 0) & "," & YourComputerMessage.ComputerId & "," & YourComputerMessage.UserId & ",'" & YourComputerMessage.DateTimeMilladi & "','" & YourComputerMessage.DateShamsi & "','" & YourComputerMessage.Time & "','" & YourComputerMessage.DataStruct.Data1 & "','" & YourComputerMessage.DataStruct.Data2 & "','" & YourComputerMessage.DataStruct.Data3 & "','" & YourComputerMessage.DataStruct.Data4 & "','" & YourComputerMessage.DataStruct.Data5 & "')"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub SendComputerMessage(YourComputerMessage As R2StandardComputerMessageStructure)
            Try
                SabtComputerMessage(New R2StandardComputerMessageStructure(0, YourComputerMessage.CMNote, YourComputerMessage.CMType, True, False, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), YourComputerMessage.DataStruct))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeactiveComputerMessage(YourNSS As R2StandardComputerMessageStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblComputerMessages Set CMActive=0 Where PrimaryId= " & YourNSS.PrimaryId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
    End Class

End Namespace

Namespace SoftwareUserManagement

    Public Enum R2CoreSoftwareUsersOrderingOptions
        None = 0
        UserName = 1
        MobileNumber = 2
    End Enum

    Public MustInherit Class R2CoreSoftwareUserTypes
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property General As Int64 = 1
        Public Shared ReadOnly Property SysAdmin As Int64 = 2

    End Class

    Public Class R2CoreStandardSoftwareUserTypeStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            UTId = Int64.MinValue
            UTName = String.Empty
            UTTitle = String.Empty
            UTColor = Color.White
            UserId = Int64.MinValue
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Active = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourUTId As Int64, YourUTName As String, YourUTTitle As String, YourUTColor As Color, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourUTId, YourUTName)
            UTId = YourUTId
            UTName = YourUTName
            UTTitle = YourUTTitle
            UTColor = YourUTColor
            UserId = YourUserId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Active = YourActive
            Deleted = YourDeleted
        End Sub

        Public Property UTId As Int64
        Public Property UTName As String
        Public Property UTTitle As String
        Public Property UTColor As Color
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean
    End Class

    Public Class R2CoreStandardSoftwareUserStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            UserId = Int64.MinValue
            ApiKey = String.Empty
            APIKeyExpiration = String.Empty
            UserName = String.Empty
            UserShenaseh = String.Empty
            UserPassword = String.Empty
            UserPasswordExpiration = String.Empty
            UserPinCode = String.Empty
            UserCanCharge = Boolean.FalseString
            UserActive = Boolean.FalseString
            UserTypeId = Int64.MinValue
            MobileNumber = String.Empty
            UserStatus = String.Empty
            VerificationCode = String.Empty
            VerificationCodeTimeStamp = String.Empty
            VerificationCodeCount = Int64.MaxValue
            Nonce = String.Empty
            NonceTimeStamp = DateTime.Now
            NonceCount = Int64.MaxValue
            PersonalNonce = String.Empty
            PersonalNonceTimeStamp = DateTime.Now
            Captcha = String.Empty
            CaptchaValid = Boolean.FalseString
            UserCreatorId = Int64.MinValue
            DateTimeMilladi = DateTime.Now
            DateShamsi = String.Empty
            ViewFlag = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourUserId As Int64, YourApiKey As String, YourAPIKeyExpiration As String,
                       ByVal YourUserName As String, ByVal YourUserShenaseh As String, ByVal YourUserPassword As String,
                       YourUserPasswordExpiration As String, YourUserPinCode As String, ByVal YourUserCanCharge As Boolean,
                       ByVal YourUserActive As Boolean, YourUserTypeId As Int64, YourMobileNumber As String, YourUserStatus As String,
                       YourVerificationCode As String, YourVerificationCodeTimeStamp As DateTime, YourVerificationCodeCount As Int64, YourNonce As String,
                       YourNonceTimeStamp As DateTime, YourNonceCount As Int64, YourPersonalNonce As String, YourPersonalNonceTimeStamp As DateTime,
                       YourCaptcha As String, YourCaptchaValid As Boolean, YourUserCreatorId As Int64,
                       YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourDeleted As Boolean)
            MyBase.New(YourUserId, YourUserName)
            UserId = YourUserId
            ApiKey = YourApiKey
            APIKeyExpiration = YourAPIKeyExpiration
            UserName = YourUserName
            UserShenaseh = YourUserShenaseh
            UserPassword = YourUserPassword
            UserPasswordExpiration = YourUserPasswordExpiration
            UserPinCode = YourUserPinCode
            UserCanCharge = YourUserCanCharge
            UserActive = YourUserActive
            UserTypeId = YourUserTypeId
            MobileNumber = YourMobileNumber
            UserStatus = YourUserStatus
            VerificationCode = YourVerificationCode
            VerificationCodeTimeStamp = YourVerificationCodeTimeStamp
            VerificationCodeCount = YourVerificationCodeCount
            Nonce = YourNonce
            NonceTimeStamp = YourNonceTimeStamp
            NonceCount = YourNonceCount
            PersonalNonce = YourPersonalNonce
            PersonalNonceTimeStamp = YourPersonalNonceTimeStamp
            Captcha = YourCaptcha
            CaptchaValid = YourCaptchaValid
            UserCreatorId = YourUserCreatorId
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            ViewFlag = YourViewFlag
            Deleted = YourDeleted
        End Sub

        Public Property UserId As Int64
        Public Property ApiKey As String
        Public Property APIKeyExpiration As String
        Public Property UserName As String
        Public Property UserShenaseh As String
        Public Property UserPassword As String
        Public Property UserPasswordExpiration As String
        Public Property UserPinCode() As String
        Public Property UserCanCharge() As Boolean
        Public Property UserActive() As Boolean
        Public Property UserTypeId() As Int64
        Public Property MobileNumber As String
        Public Property UserStatus As String
        Public Property VerificationCode As String
        Public Property VerificationCodeTimeStamp As DateTime
        Public Property VerificationCodeCount As Int64
        Public Property Nonce As String
        Public Property NonceTimeStamp As DateTime
        Public Property NonceCount As Int64
        Public Property PersonalNonce As String
        Public Property PersonalNonceTimeStamp As DateTime
        Public Property Captcha As String
        Public Property CaptchaValid As Boolean
        Public Property UserCreatorId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Deleted As Boolean
    End Class

    Public Class R2CoreSoftwareUserMobile
        Public Sub New(YourMobileNumber)
            SoftwareUserMobileNumber = YourMobileNumber
        End Sub

        Private _SoftwareUserMobileNumber = String.Empty
        Public Property SoftwareUserMobileNumber As String
            Get
                Return _SoftwareUserMobileNumber
            End Get
            Set(value As String)
                _SoftwareUserMobileNumber = value
            End Set
        End Property
    End Class

    Public Class R2CoreInstanseSoftwareUsersManager
        Private _DateTime As New R2DateTime

        Public Function GetNSSUser(YourApiKey As String) As R2CoreStandardSoftwareUserStructure
            Try
                Dim Instanse = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If Instanse.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where ApiKey='" & YourApiKey & "'", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New UserNotExistByApiKeyException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode"), Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce"), Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce"), Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha"), Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As UserNotExistByApiKeyException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSUserChangeableData(YourSoftWareUserMobile As R2CoreSoftwareUserMobile) As R2CoreStandardSoftwareUserStructure
            Try
                Dim InstanceEVA = New ExpressionValidationAlgorithmsManager
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                InstanceEVA.ValidationMobileNumber(YourSoftWareUserMobile.SoftwareUserMobileNumber)
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                       "Select Top 1 UserId,ApiKey,APIKeyExpiration,UserShenaseh,UserPassword,UserPasswordExpiration,UserTypeId,MobileNumber,UserStatus,VerificationCode,VerificationCodeTimeStamp,VerificationCodeCount,Nonce,NonceTimeStamp,NonceCount,PersonalNonce,PersonalNonceTimeStamp,Captcha,CaptchaValid
                        from R2Primary.dbo.TblSoftwareUsers Where MobileNumber='" & YourSoftWareUserMobile.SoftwareUserMobileNumber & "' Order By UserId Desc", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New UserNotExistByMobileNumberException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration").trim, Nothing, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration").trim, Nothing, Nothing, Nothing, Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce").trim, Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce").trim, Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha").trim, Ds.Tables(0).Rows(0).Item("CaptchaValid"), Nothing, Nothing, Nothing, Nothing, Nothing)
            Catch exx As UserNotExistByMobileNumberException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSUserUnChangeable(YourSoftWareUserMobile As R2CoreSoftwareUserMobile) As R2CoreStandardSoftwareUserStructure
            Try
                Dim InstanceEVA = New ExpressionValidationAlgorithmsManager
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                InstanceEVA.ValidationMobileNumber(YourSoftWareUserMobile.SoftwareUserMobileNumber)
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 * from R2Primary.dbo.TblSoftwareUsers Where MobileNumber='" & YourSoftWareUserMobile.SoftwareUserMobileNumber & "' Order By UserId Desc", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New UserNotExistByMobileNumberException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode").trim, Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce").trim, Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce").trim, Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha").trim, Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As UserNotExistByMobileNumberException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSUser(YourUserId As Int64) As R2CoreStandardSoftwareUserStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where UserId=" & YourUserId & "", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New UserIdNotExistException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode"), Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce"), Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce"), Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha"), Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As UserIdNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetSystemUserId() As Int64
            Try
                Return 1
            Catch ex As UserIdNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSSystemUser() As R2CoreStandardSoftwareUserStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select UserId from R2Primary.dbo.TblSoftwareUsers Where UserId=1", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New UserIdNotExistException
                End If
                Return GetNSSUser(System.Convert.ToInt64(Ds.Tables(0).Rows(0).Item("UserId")))
            Catch ex As UserIdNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function RegisteringMobileNumber(YourMobileNumber As String) As R2CoreStandardSoftwareUserStructure
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                'SqlInjectionPrevention
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourMobileNumber)

                Dim InstanceAESAlgorithms As New AESAlgorithmsManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager()
                Dim VerificationCode As String = InstanceAESAlgorithms.GenerateVerificationCode(InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 9))
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceSoftwareUser = New R2CoreInstanseSoftwareUsersManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                   "Select Top 1 SoftwareUsers.UserId,SoftwareUsers.MobileNumber from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers 
                    Where SoftwareUsers.MobileNumber='" & YourMobileNumber & "' and UserActive=1 
                    Order By SoftwareUsers.UserId Desc", 0, Ds).GetRecordsCount <> 0 Then
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers 
                                          Set VerificationCode='" & VerificationCode & "',VerificationCodeTimeStamp='" & _DateTime.GetCurrentDateTimeMilladiFormated & "',VerificationCodeCount=" & InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 4) & " 
                                          Where UserId=" & Ds.Tables(0).Rows(0).Item("UserId") & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                    Dim SMSSender As New R2CoreSMSSendRecive
                    SMSSender.SendSms(New R2CoreStandardSMSStructure(Nothing, Ds.Tables(0).Rows(0).Item("MobileNumber"), VerificationCode, 1, Nothing, 1, Nothing, Nothing))
                    Return InstanceSoftwareUser.GetNSSUser(Ds.Tables(0).Rows(0).Item("UserId"))
                Else
                    Throw New MobileNumberNotFoundException
                End If
            Catch ex As MobileNumberNotFoundException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub LogoutSoftwareUser(YourUserId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set UserStatus='logout' Where UserId=" & YourUserId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub LoginSoftwareUser(YourMobileNumber As String)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                'SqlInjectionPrevention
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourMobileNumber)

                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager()
                Dim APIKeyExpiration As String = _DateTime.GetNextShamsiMonth(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime), InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 1)).DateShamsiFull
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set UserStatus='login',APIKeyExpiration='" & APIKeyExpiration & "' Where MobileNumber='" & YourMobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub AuthenticationUserByMobileNumber(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstanseSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim DS As DataSet
                If InstanseSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                         "Select UserActive from R2Primary.dbo.TblSoftwareUsers where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'", 3600, DS).GetRecordsCount = 0 Then
                    Throw New UserNotExistException
                Else
                    If DS.Tables(0).Rows(0).Item("UserActive") = False Then Throw New UserIsNotActiveException
                End If
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNonceforSoftwareUser(YourSoftwareUserMobile As R2CoreSoftwareUserMobile) As String
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceAESAlgorithms = New AESAlgorithmsManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim Nonce = InstanceAESAlgorithms.GetNonce(InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.PublicSecurityConfiguration, 0))
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set Nonce='" & Nonce & "',NonceCount=" & InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.PublicSecurityConfiguration, 1) & ",NonceTimeStamp='" & _DateTime.GetCurrentDateTimeMilladiFormated & "' Where MobileNumber='" & YourSoftwareUserMobile.SoftwareUserMobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                Return Nonce
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub DecreaseNonceCountforSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                AuthenticationUserByMobileNumber(YourNSSSoftwareUser)
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set NonceCount=NonceCount-1 Where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub DecreaseVerificationCodeCountforSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                AuthenticationUserByMobileNumber(YourNSSSoftwareUser)
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set VerificationCodeCount=VerificationCodeCount-1 Where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetPersonalNonceforSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As String
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceAESAlgorithms = New AESAlgorithmsManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim PersonalNonce = InstanceAESAlgorithms.GetNonce(InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 3))
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set PersonalNonce='" & PersonalNonce & "',PersonalNonceTimeStamp='" & _DateTime.GetCurrentDateTimeMilladiFormated & "' Where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                Return PersonalNonce
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetCaptchaforSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As String
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceCaptcha = New R2CoreInstanceCaptchaManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim Captcha = InstanceCaptcha.GenerateFakeWord(InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 6))
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set Captcha='" & Captcha & "',CaptchaValid=1 Where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                Return Captcha
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetCaptchaNumericforSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As String
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceCaptcha = New R2CoreInstanceCaptchaManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim Captcha = InstanceCaptcha.GenerateFakeWordNumeric(InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 6))
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set Captcha='" & Captcha & "',CaptchaValid=1 Where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                Return Captcha
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub CaptchaInvalidateforSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                AuthenticationUserByMobileNumber(YourNSSSoftwareUser)
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set Captcha='',CaptchaValid=0 Where MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub SoftwareUserVerificationCodeInjection(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers 
                                      Set VerificationCode='" & InstanceConfiguration.GetConfigString(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 12) & "',VerificationCodeTimeStamp='" & _DateTime.GetCurrentDateTimeMilladiFormated & "',VerificationCodeCount=" & InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 4) & " 
                                      Where UserId=" & YourNSSSoftwareUser.UserId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetSoftwareUserTypes(YourSearchString As String) As List(Of R2StandardStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSearchString)

                Dim Ds As DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUserTypes Where Active=1 and ViewFlag=1 and UTTitle Like  '%" & YourSearchString & "%' Order By UTId", 3600, Ds)
                Dim Lst As New List(Of R2StandardStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardSoftwareUserTypeStructure(Ds.Tables(0).Rows(Loopx).Item("UTId"), Ds.Tables(0).Rows(Loopx).Item("UTTitle").trim, Ds.Tables(0).Rows(Loopx).Item("UTTitle").trim, Color.FromName(Ds.Tables(0).Rows(Loopx).Item("UTColor").trim), Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted")))
                Next
                Return Lst
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Function GetNSSSoftwareUserType(YourSoftwareUserType As String) As R2CoreStandardSoftwareUserStructure
        '    Try
        '        Dim Instanse = New R2CoreInstanseSqlDataBOXManager
        '        Dim Ds As DataSet
        '        If Instanse.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where ApiKey='" & YourApiKey & "'", 0, Ds).GetRecordsCount() = 0 Then
        '            Throw New UserNotExistByApiKeyException
        '        End If
        '        Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode"), Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce"), Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce"), Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha"), Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
        '    Catch exx As UserNotExistByApiKeyException
        '        Throw exx
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Function

        Public Function GetSoftwareUsers_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreStandardSoftwareUserStructure)
            Try
                Dim Lst As New List(Of R2CoreStandardSoftwareUserStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2Primary.dbo.TblSoftwareUsers Where Left(UserName," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and UserActive=1 Order By UserName", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardSoftwareUserStructure(DS.Tables(0).Rows(Loopx).Item("UserId"), DS.Tables(0).Rows(Loopx).Item("ApiKey").trim, DS.Tables(0).Rows(Loopx).Item("APIKeyExpiration"), DS.Tables(0).Rows(Loopx).Item("UserName").trim, DS.Tables(0).Rows(Loopx).Item("UserShenaseh").trim, DS.Tables(0).Rows(Loopx).Item("UserPassword").trim, DS.Tables(0).Rows(Loopx).Item("UserPasswordExpiration"), DS.Tables(0).Rows(Loopx).Item("UserPinCode"), DS.Tables(0).Rows(Loopx).Item("UserCanCharge"), DS.Tables(0).Rows(Loopx).Item("UserActive"), DS.Tables(0).Rows(Loopx).Item("UserTypeId"), DS.Tables(0).Rows(Loopx).Item("MobileNumber").trim, DS.Tables(0).Rows(Loopx).Item("UserStatus").trim, DS.Tables(0).Rows(Loopx).Item("VerificationCode").trim, DS.Tables(0).Rows(Loopx).Item("VerificationCodeTimeStamp"), DS.Tables(0).Rows(Loopx).Item("VerificationCodeCount"), DS.Tables(0).Rows(Loopx).Item("Nonce"), DS.Tables(0).Rows(Loopx).Item("NonceTimeStamp"), DS.Tables(0).Rows(Loopx).Item("NonceCount"), DS.Tables(0).Rows(Loopx).Item("PersonalNonce"), DS.Tables(0).Rows(Loopx).Item("PersonalNonceTimeStamp"), DS.Tables(0).Rows(Loopx).Item("Captcha"), DS.Tables(0).Rows(Loopx).Item("CaptchaValid"), DS.Tables(0).Rows(Loopx).Item("UserCreatorId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetSoftwareUsers_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreStandardSoftwareUserStructure)
            Try
                Dim Lst As New List(Of R2CoreStandardSoftwareUserStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2Primary.dbo.TblSoftwareUsers Where UserName Like '%" & YourSearchString & "%' and Deleted=0 and UserActive=1 Order By UserName", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardSoftwareUserStructure(DS.Tables(0).Rows(Loopx).Item("UserId"), DS.Tables(0).Rows(Loopx).Item("ApiKey").trim, DS.Tables(0).Rows(Loopx).Item("APIKeyExpiration"), DS.Tables(0).Rows(Loopx).Item("UserName").trim, DS.Tables(0).Rows(Loopx).Item("UserShenaseh").trim, DS.Tables(0).Rows(Loopx).Item("UserPassword").trim, DS.Tables(0).Rows(Loopx).Item("UserPasswordExpiration"), DS.Tables(0).Rows(Loopx).Item("UserPinCode"), DS.Tables(0).Rows(Loopx).Item("UserCanCharge"), DS.Tables(0).Rows(Loopx).Item("UserActive"), DS.Tables(0).Rows(Loopx).Item("UserTypeId"), DS.Tables(0).Rows(Loopx).Item("MobileNumber").trim, DS.Tables(0).Rows(Loopx).Item("UserStatus").trim, DS.Tables(0).Rows(Loopx).Item("VerificationCode").trim, DS.Tables(0).Rows(Loopx).Item("VerificationCodeTimeStamp"), DS.Tables(0).Rows(Loopx).Item("VerificationCodeCount"), DS.Tables(0).Rows(Loopx).Item("Nonce"), DS.Tables(0).Rows(Loopx).Item("NonceTimeStamp"), DS.Tables(0).Rows(Loopx).Item("NonceCount"), DS.Tables(0).Rows(Loopx).Item("PersonalNonce"), DS.Tables(0).Rows(Loopx).Item("PersonalNonceTimeStamp"), DS.Tables(0).Rows(Loopx).Item("Captcha"), DS.Tables(0).Rows(Loopx).Item("CaptchaValid"), DS.Tables(0).Rows(Loopx).Item("UserCreatorId"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSVirtualChargingSoftwareUser() As R2CoreStandardSoftwareUserStructure
            Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
            Dim InstanceSoftwareUser As New R2CoreInstanseSoftwareUsersManager
            Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Top 1 SoftwareUsers.UserId from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                          Where SoftwareUsers.UserId=" & InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 13) & " and SoftwareUsers.Deleted=0", 3600, Ds).GetRecordsCount = 0 Then Throw New UserIdNotExistException
                Return InstanceSoftwareUser.GetNSSUser(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("UserId")))
            Catch ex As UserIdNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreMClassSoftwareUsersManagement

        Private Shared _DateTime As New R2DateTime
        Private Shared R2PrimaryFSWS As R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()

        Public Shared Property GetNoneUserId As Int64 = 0

        Public Shared Function RegisteringSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Dim AES As New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
            Dim Hasher = New R2Core.SecurityAlgorithmsManagement.Hashing.SHAHasher
            Try
                If YourNSSSoftwareUser.MobileNumber.Trim = String.Empty Then Throw New SoftwareUserMobileNumberNeedforRegisteringException
                Dim InstanceConfiguration As New R2CoreInstanceConfigurationManager
                Dim APIKeyExpiration As String = _DateTime.GetNextShamsiMonth(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime), InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 1)).DateShamsiFull
                Dim UserPasswordExpiration As String = _DateTime.GetNextShamsiMonth(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime), InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 2)).DateShamsiFull
                Dim myShenaseh As String = AES.GetRandomNumericCode(10000, 99999)
                Dim myPassword As String = AES.GetRandomNumericCode(10000000, 99999999)
                Dim UIdSalt As String = AES.GetSalt(InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 0))
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Select Top 1 UserId from R2Primary.dbo.TblSoftwareUsers with (tablockx) order by UserId desc"
                CmdSql.ExecuteNonQuery()
                Dim myUserId As Int64 = CmdSql.ExecuteScalar + 1
                Dim APIKey = Hasher.GenerateSHA256String(myUserId.ToString + UIdSalt)

                CmdSql.CommandText = "Insert Into R2Primary.dbo.TblSoftwareUsers(UserId,ApiKey,APIKeyExpiration,UserName,UserShenaseh,UserPassword,UserPasswordExpiration,UserPinCode,UserCanCharge,UserActive,UserTypeId,MobileNumber,UserStatus,VerificationCode,VerificationCodeTimeStamp,VerificationCodeCount,Nonce,NonceTimeStamp,NonceCount,PersonalNonce,PersonalNonceTimeStamp,Captcha,CaptchaValid,UserCreatorId,DateTimeMilladi,DateShamsi,ViewFlag,Deleted)
                                      Values(" & myUserId & ",'" & APIKey & "','" & APIKeyExpiration & "','" & YourNSSSoftwareUser.UserName & "','" & myShenaseh & "','" & myPassword & "','" & UserPasswordExpiration & "','" & YourNSSSoftwareUser.UserPinCode & "'," & IIf(YourNSSSoftwareUser.UserCanCharge, 1, 0) & "," & IIf(YourNSSSoftwareUser.UserActive, 1, 0) & "," & YourNSSSoftwareUser.UserTypeId & ",'" & YourNSSSoftwareUser.MobileNumber & "','logout','','" & _DateTime.GetCurrentDateTimeMilladiFormated & "',0,'','" & _DateTime.GetCurrentDateTimeMilladiFormated & "','','" & _DateTime.GetCurrentDateTimeMilladiFormated & "',0,'',0," & YourNSSUser.UserId & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull & "'," & IIf(YourNSSSoftwareUser.ViewFlag, 1, 0) & ",0)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Return myUserId
            Catch ex As SoftwareUserMobileNumberNeedforRegisteringException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub EditingSoftwareUser(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                If YourNSSSoftwareUser.MobileNumber.Trim = String.Empty Then Throw New SoftwareUserMobileNumberNeedforRegisteringException
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers 
                        Set UserName='" & YourNSSSoftwareUser.UserName & "',UserPinCode='" & YourNSSSoftwareUser.UserPinCode & "',UserCanCharge=" & IIf(YourNSSSoftwareUser.UserCanCharge, 1, 0) & ",UserActive=" & IIf(YourNSSSoftwareUser.UserActive, 1, 0) & ",UserTypeId=" & YourNSSSoftwareUser.UserTypeId & ",MobileNumber='" & YourNSSSoftwareUser.MobileNumber & "',UserCreatorId=" & YourNSSUser.UserId & " 
                        Where UserId=" & YourNSSSoftwareUser.UserId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As SoftwareUserMobileNumberNeedforRegisteringException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function IsUserRegistered(YourUserNSS As R2CoreStandardSoftwareUserStructure) As Boolean
            Try
                AuthenticationUserbyShenasehPassword(YourUserNSS)
                Return True
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As UserNotExistException
                Return False
            Catch ex As UserIsNotActiveException
                Return False
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub AuthenticationUserbyShenasehPassword(YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourUserNSS.UserShenaseh)
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourUserNSS.UserPassword)

                Dim DS As DataSet
                If DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers where ltrim(rtrim(UserShenaseh))='" & YourUserNSS.UserShenaseh & "' and ltrim(rtrim(UserPassword))='" & YourUserNSS.UserPassword & "'", 0, DS).GetRecordsCount = 0 Then
                    Throw New UserNotExistException
                Else
                    If DS.Tables(0).Rows(0).Item("UserActive") = False Then Throw New UserIsNotActiveException
                End If
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub AuthenticationUserByPinCode(YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim DS As DataSet
                If DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers where UserPinCode='" & YourUserNSS.UserPinCode & "'", 0, DS).GetRecordsCount = 0 Then
                    Throw New UserNotExistException
                Else
                    If DS.Tables(0).Rows(0).Item("UserActive") = False Then Throw New UserIsNotActiveException
                End If
            Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetNSSSystemUser() As R2CoreStandardSoftwareUserStructure
            Try
                Return GetNSSUser(1)
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSUser(YourUserId As Int64) As R2CoreStandardSoftwareUserStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where UserId=" & YourUserId & "", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New UserIdNotExistException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode"), Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce"), Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce"), Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha"), Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As UserIdNotExistException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSUser(YourUserShenaseh As String, YourUserPassword As String) As R2CoreStandardSoftwareUserStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where UserShenaseh='" & YourUserShenaseh.Trim() & "' and UserPassword='" & YourUserPassword.Trim() & "'", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode"), Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce"), Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce"), Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha"), Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSUser(YourPinCode As String) As R2CoreStandardSoftwareUserStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where UserPinCode='" & YourPinCode.Trim() & "'", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Return New R2CoreStandardSoftwareUserStructure(Ds.Tables(0).Rows(0).Item("UserId"), Ds.Tables(0).Rows(0).Item("ApiKey").trim, Ds.Tables(0).Rows(0).Item("APIKeyExpiration"), Ds.Tables(0).Rows(0).Item("UserName").trim, Ds.Tables(0).Rows(0).Item("UserShenaseh").trim, Ds.Tables(0).Rows(0).Item("UserPassword").trim, Ds.Tables(0).Rows(0).Item("UserPasswordExpiration"), Ds.Tables(0).Rows(0).Item("UserPinCode"), Ds.Tables(0).Rows(0).Item("UserCanCharge"), Ds.Tables(0).Rows(0).Item("UserActive"), Ds.Tables(0).Rows(0).Item("UserTypeId"), Ds.Tables(0).Rows(0).Item("MobileNumber").trim, Ds.Tables(0).Rows(0).Item("UserStatus").trim, Ds.Tables(0).Rows(0).Item("VerificationCode").trim, Ds.Tables(0).Rows(0).Item("VerificationCodeTimeStamp"), Ds.Tables(0).Rows(0).Item("VerificationCodeCount"), Ds.Tables(0).Rows(0).Item("Nonce"), Ds.Tables(0).Rows(0).Item("NonceTimeStamp"), Ds.Tables(0).Rows(0).Item("NonceCount"), Ds.Tables(0).Rows(0).Item("PersonalNonce"), Ds.Tables(0).Rows(0).Item("PersonalNonceTimeStamp"), Ds.Tables(0).Rows(0).Item("Captcha"), Ds.Tables(0).Rows(0).Item("CaptchaValid"), Ds.Tables(0).Rows(0).Item("UserCreatorId"), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetUserImage(YourNSSUserRequest As R2CoreStandardSoftwareUserStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
            Try
                Return New R2CoreImage(R2PrimaryFSWS.WebMethodGetFile(R2Core.FileShareRawGroupsManagement.R2CoreRawGroups.UserImages, YourNSSUserRequest.UserId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 0), R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword)))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ChangeUserPassword(YourNSS As R2CoreStandardSoftwareUserStructure)
            Dim cmdsql As New SqlClient.SqlCommand
            cmdsql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
            Try
                'SqlInjectionPrevention
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourNSS.UserPassword)

                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim PS As PasswordStrength = New PasswordStrength
                PS.SetPassword(YourNSS.UserPassword)
                If (PS.GetPasswordStrength() = "Strong") Or (PS.GetPasswordStrength() = "Very Strong") Then
                    Dim UserPasswordExpiration As String = _DateTime.GetNextShamsiMonth(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime), InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 2)).DateShamsiFull
                    cmdsql.Connection.Open()
                    cmdsql.CommandText = "update R2Primary.dbo.TblSoftwareUsers Set UserPassword='" & YourNSS.UserPassword & "',UserPasswordExpiration='" & UserPasswordExpiration & "' Where UserId=" & YourNSS.UserId & ""
                    cmdsql.ExecuteNonQuery()
                    cmdsql.Connection.Close()
                Else
                    Throw New PasswordStrengthRejectedException
                End If
            Catch ex As PasswordStrengthRejectedException
                Throw ex
            Catch ex As Exception
                If cmdsql.Connection.State <> ConnectionState.Closed Then cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Namespace Exceptions
        Public Class SoftwareUserPasswordExpiredException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زمان اعتبار رمز عبور کاربر منقضی شده است"
                End Get
            End Property
        End Class


        Public Class SoftwareUserMobileNumberNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربر با شماره موبایل مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class SoftwareUserMobileNumberNeedforRegisteringException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ورود شماره موبایل برای ثبت کاربر الزامی است"
                End Get
            End Property
        End Class

        Public Class MobileNumberNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شماره موبایل در بانک اطلاعات یافت نشد"
                End Get
            End Property
        End Class

        Public Class SoftwareUserNotMatchException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کد تبادل نادرست است"
                End Get
            End Property
        End Class

        Public Class UserNotExistByApiKeyException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربری با کلید خصوصی ارسالی یافت نشد"
                End Get
            End Property
        End Class

        Public Class UserNotExistByMobileNumberException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربری با شماره موبایل مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class UserNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربری با مشخصات ارسالی یافت نشد"
                End Get
            End Property
        End Class

        Public Class UserLast5DigitNotMatchingException
            Inherits ApplicationException
            'رمز شخصی همان پسوورد کاربری است
            'به دلیل جلوگیری از هکر و امنیت کاربر ، رمز شخصی توسط خود کاربر ارسال می گردد 
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "خطای امنیتی کد : 39 رمز شخصی به درستی وارد نشده است"
                End Get
            End Property
        End Class

        Public Class UserIsNotActiveException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حساب کاربر مورد نظر در حال حاضر غیر فعال است"
                End Get
            End Property
        End Class

        Public Class UserIdNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربری با کد ارسالی در سیستم وجود ندارد"
                End Get
            End Property
        End Class

        Public Class PasswordStrengthRejectedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "رمز عبور کاربر می بایست حداقل 8 حرف و شامل حروف کوچک و بزرگ و اعداد باشد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace AudioVideoManagement
    Public Class R2MClassAudioVideoManagement
        Private Shared myDefualtMessagingMusic As String = Nothing
        Public Shared Sub SavePathForDefualtMessagingMusic(ByVal Path As String)
            Try
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey("CurentMessageMusicPath")
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("CurentMessageMusicPath", True)
                Microsoft.Win32.Registry.CurrentUser.SetValue("CurentMessageMusicPath", Path)
            Catch ex As Exception
                Throw New Exception("MClassAudioVideoManagement.SavePathForDefualtMessagingMusic()." + ex.Message.ToString)
            End Try
        End Sub
        Public Shared Function GetPathForDefualtMessagingMusic() As String
            Try
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("CurentMessageMusicPath")
                Return Microsoft.Win32.Registry.CurrentUser.GetValue("CurentMessageMusicPath")
            Catch ex As Exception
                Throw New Exception("MClassAudioVideoManagement.GetPathForDefualtMessagingMusic()." + ex.Message.ToString)
            End Try
        End Function
    End Class
End Namespace

Namespace AuthenticationManagement
    Public MustInherit Class R2MClassAuthenticationManagement
        Public Shared Function UserHaveProcessPermission(YourUserNSS As R2CoreStandardSoftwareUserStructure, YourProcessNSS As R2StandardDesktopProcessStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsersRelationProcesses Where UserId='" & YourUserNSS.UserId & "' and PId='" & YourProcessNSS.PId & "'", 3600, DS).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function UserHaveComputerPermission(YourUserNSS As R2CoreStandardSoftwareUserStructure, YourComputerNSS As R2CoreStandardComputerStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsersRelationComputers Where UserId='" & YourUserNSS.UserId & "' and MId='" & YourComputerNSS.MId & "'", 3600, DS).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ComputerHaveProcessPermission(YourComputerNSS As R2CoreStandardComputerStructure, YourProcessNSS As R2StandardDesktopProcessStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputersRelationProcesses Where CId=" & YourComputerNSS.MId & " and PId=" & YourProcessNSS.PId & "", 3600, DS).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public Class AuthenticationUserHasProcessPermissionException
        Inherits ApplicationException

        Public Overrides ReadOnly Property Message As String
            Get
                Return "کاربر مجوز دسترسی به فرآیند را ندارد"
            End Get
        End Property
    End Class

    Public Class AuthenticationComputerHasProcessPermissionException
        Inherits ApplicationException

        Public Overrides ReadOnly Property Message As String
            Get
                Return "فرآیند مورد نظر در این کامپیوتر قابل دسترس نیست"
            End Get
        End Property
    End Class

End Namespace

Namespace DatabaseManagement

    Public Enum R2OpenCloseConnectionStatus
        OpenCloseYes = 0
        OpenCloseNo = 1
    End Enum

    Public MustInherit Class R2ClassSqlConnection

        Protected DefaultConnectionString As String = R2CoreMClassConfigurationManagement.GetDefaultConnectionString
        Protected SubscriptionDBConnectionString As String = R2CoreMClassConfigurationManagement.GetSubscriptionDBConnectionString
        Protected _Connection As SqlClient.SqlConnection = Nothing

        Public Sub New()
            Try
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Function GetConnection() As System.Data.SqlClient.SqlConnection
            Try
                Return _Connection
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2PrimarySqlConnection
        Inherits R2ClassSqlConnection

        Public Sub New()
            MyBase.New()
            Try
                _Connection = New SqlClient.SqlConnection(DefaultConnectionString.Replace("@IC", R2CoreMClassConfigurationManagement.GetMainDatabaseName))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

    End Class

    Public Class R2PrimarySubscriptionDBSqlConnection
        Inherits R2ClassSqlConnection

        Public Sub New()
            MyBase.New()
            Try
                _Connection = New SqlClient.SqlConnection(SubscriptionDBConnectionString.Replace("@IC", R2CoreMClassConfigurationManagement.GetMainDatabaseName))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

    End Class

    Public Class R2PrimaryReportsSqlConnection
        Inherits R2ClassSqlConnection

        Public Sub New()
            MyBase.New()
            Try
                _Connection = New SqlClient.SqlConnection(DefaultConnectionString.Replace("@IC", R2CoreMClassConfigurationManagement.GetMainDatabaseName + "Reports"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

    End Class

    Public Class R2ClassSqlDataBOX
        Dim myR2ClassSqlConnection As R2ClassSqlConnection
        Dim myDisposeCounter As Int16
        Dim myStartTime As DateTime
        Dim mySqlString As String
        Dim myDS As New DataSet
        Dim myRecordsCount As Int64
        Public Sub New()
        End Sub
        Public Sub New(ByVal Sqlcnn As R2ClassSqlConnection, ByVal DisposeCounterr As Int16, ByVal SqlStringg As String)
            Try
                myR2ClassSqlConnection = Sqlcnn
                myDisposeCounter = DisposeCounterr
                myStartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                mySqlString = SqlStringg
                'پركردن ديتاست
                Dim da As New SqlClient.SqlDataAdapter
                da.SelectCommand = New SqlClient.SqlCommand(mySqlString)
                da.SelectCommand.Connection = myR2ClassSqlConnection.GetConnection()
                'da.SelectCommand.Connection = R2MClassDatabaseManagement.GetOpenConnection()
                myDS.Tables.Clear()
                myRecordsCount = da.Fill(myDS)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Sub RenewData()
            Try
                myStartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                Dim da As New SqlClient.SqlDataAdapter
                da.SelectCommand = New SqlClient.SqlCommand(mySqlString)
                da.SelectCommand.Connection = myR2ClassSqlConnection.GetConnection
                myDS.Tables.Clear()
                myRecordsCount = da.Fill(myDS)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Function GetRecordsCount() As Int64
            Return myRecordsCount
        End Function

        Public Function GetDS() As DataSet
            Return myDS
        End Function

        Public Function DisposeCounter() As Int16
            Return myDisposeCounter
        End Function

        Public Function StartTime() As DateTime
            Return myStartTime
        End Function

        Public Function SqlString() As String
            Return mySqlString
        End Function

        Public Function SqlConnection() As SqlClient.SqlConnection
            Return myR2ClassSqlConnection.GetConnection
        End Function

    End Class

    Public Class R2CoreInstanseSqlDataBOXManager
        Private yourSqlcnn As R2ClassSqlConnection = Nothing
        Private yourSqlString As String = Nothing
        Private yourDisposeCounter As Int16 = Nothing

        Public Function GetDataBOX(ByVal Sqlcnn As R2ClassSqlConnection, ByVal SqlString As String, ByVal DisposeCounter As Int16, ByRef DS As DataSet) As R2ClassSqlDataBOX
            Try
                yourSqlcnn = Sqlcnn
                yourSqlString = SqlString : yourDisposeCounter = DisposeCounter
                Dim myIndex As Int32 = R2ClassSqlDataBOXManagement.myList.FindIndex(AddressOf FindDataBox)
                Dim myR2ClassSqlDataBOX As R2ClassSqlDataBOX
                If yourDisposeCounter > 0 Then
                    If myIndex >= 0 Then
                        Dim myCurrentDateTime As DateTime = Date.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                        If (R2ClassSqlDataBOXManagement.myList.Item(myIndex).DisposeCounter <> 0) And (DateAndTime.DateDiff(DateInterval.Second, R2ClassSqlDataBOXManagement.myList.Item(myIndex).StartTime, myCurrentDateTime) >= R2ClassSqlDataBOXManagement.myList.Item(myIndex).DisposeCounter) Then
                            R2ClassSqlDataBOXManagement.myList.Item(myIndex).RenewData()
                        End If
                        DS = R2ClassSqlDataBOXManagement.myList.Item(myIndex).GetDS
                        Return R2ClassSqlDataBOXManagement.myList.Item(myIndex)
                    Else
                        myR2ClassSqlDataBOX = New R2ClassSqlDataBOX(Sqlcnn, DisposeCounter, SqlString)
                        R2ClassSqlDataBOXManagement.myList.Add(myR2ClassSqlDataBOX)
                        DS = myR2ClassSqlDataBOX.GetDS
                        Return myR2ClassSqlDataBOX
                    End If
                ElseIf yourDisposeCounter = 0 Then
                    myR2ClassSqlDataBOX = New R2ClassSqlDataBOX(Sqlcnn, DisposeCounter, SqlString)
                    If myIndex >= 0 Then
                        R2ClassSqlDataBOXManagement.myList.Item(myIndex) = Nothing
                        R2ClassSqlDataBOXManagement.myList.Item(myIndex) = myR2ClassSqlDataBOX
                        DS = myR2ClassSqlDataBOX.GetDS
                        Return R2ClassSqlDataBOXManagement.myList.Item(myIndex)
                    Else
                        R2ClassSqlDataBOXManagement.myList.Add(myR2ClassSqlDataBOX)
                        DS = myR2ClassSqlDataBOX.GetDS
                        Return myR2ClassSqlDataBOX
                    End If
                ElseIf yourDisposeCounter < 0 Then
                    Throw New Exception("Error:yourDisposeCounter < 0")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Private Function FindDataBox(ByVal DataBox As R2ClassSqlDataBOX) As Boolean
            Try
                If DataBox.SqlString = yourSqlString And DataBox.SqlConnection.ConnectionString = yourSqlcnn.GetConnection().ConnectionString Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class R2ClassSqlDataBOXManagement
        Public Shared myList As New Generic.List(Of R2ClassSqlDataBOX)
        Private Shared yourSqlcnn As R2ClassSqlConnection = Nothing
        Private Shared yourSqlString As String = Nothing
        Private Shared yourDisposeCounter As Int16 = Nothing

        Public Shared Function GetDataBOX(ByVal Sqlcnn As R2ClassSqlConnection, ByVal SqlString As String, ByVal DisposeCounter As Int32, ByRef DS As DataSet) As R2ClassSqlDataBOX
            Try
                yourSqlcnn = Sqlcnn
                yourSqlString = SqlString : yourDisposeCounter = DisposeCounter
                Dim myIndex As Int32 = myList.FindIndex(AddressOf FindDataBox)
                Dim myR2ClassSqlDataBOX As R2ClassSqlDataBOX
                If yourDisposeCounter > 0 Then
                    If myIndex >= 0 Then
                        Dim myCurrentDateTime As DateTime = Date.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                        If (myList.Item(myIndex).DisposeCounter <> 0) And (DateAndTime.DateDiff(DateInterval.Second, myList.Item(myIndex).StartTime, myCurrentDateTime) >= myList.Item(myIndex).DisposeCounter) Then
                            myList.Item(myIndex).RenewData()
                        End If
                        DS = myList.Item(myIndex).GetDS
                        Return myList.Item(myIndex)
                    Else
                        myR2ClassSqlDataBOX = New R2ClassSqlDataBOX(Sqlcnn, DisposeCounter, SqlString)
                        myList.Add(myR2ClassSqlDataBOX)
                        DS = myR2ClassSqlDataBOX.GetDS
                        Return myR2ClassSqlDataBOX
                    End If
                ElseIf yourDisposeCounter = 0 Then
                    myR2ClassSqlDataBOX = New R2ClassSqlDataBOX(Sqlcnn, DisposeCounter, SqlString)
                    If myIndex >= 0 Then
                        myList.Item(myIndex) = Nothing
                        myList.Item(myIndex) = myR2ClassSqlDataBOX
                        DS = myR2ClassSqlDataBOX.GetDS
                        Return myList.Item(myIndex)
                    Else
                        myList.Add(myR2ClassSqlDataBOX)
                        DS = myR2ClassSqlDataBOX.GetDS
                        Return myR2ClassSqlDataBOX
                    End If
                ElseIf yourDisposeCounter < 0 Then
                    Throw New Exception("Error:yourDisposeCounter < 0")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Private Shared Function FindDataBox(ByVal DataBox As R2ClassSqlDataBOX) As Boolean
            Try
                If DataBox.SqlString = yourSqlString And DataBox.SqlConnection.ConnectionString = yourSqlcnn.GetConnection().ConnectionString Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreMClassDatabaseManagement
        Public Shared Function GetOLEDbConnectionString(ByVal FileName As String) As String
            Dim Builder As New OleDb.OleDbConnectionStringBuilder
            If IO.Path.GetExtension(FileName).ToUpper = ".XLS" Then
                Builder.Provider = "Microsoft.Jet.OLEDB.4.0"
                Builder.Add("Extended Properties", "Excel 8.0;IMEX=1;HDR=No;")
            Else
                Builder.Provider = "Microsoft.ACE.OLEDB.12.0"
                Builder.Add("Extended Properties", "Excel 12.0;")
                'Builder.Add("Extended Properties", "Excel 12.0;IMEX=1;HDR=No;")
            End If
            Builder.DataSource = FileName
            Return Builder.ConnectionString
        End Function

        Public Shared Function GetOLEDbConnectionString(ByVal FileName As String, ByVal Header As String) As String
            Dim Builder As New OleDb.OleDbConnectionStringBuilder
            If IO.Path.GetExtension(FileName).ToUpper = ".XLS" Then
                Builder.Provider = "Microsoft.Jet.OLEDB.4.0"
                Builder.Add("Extended Properties", String.Format("Excel 8.0;IMEX=1;HDR={0};", Header))
            Else
                Builder.Provider = "Microsoft.ACE.OLEDB.12.0"
                Builder.Add("Extended Properties", String.Format("Excel 12.0;IMEX=1;HDR={0};", Header))
            End If
            Builder.DataSource = FileName
            Return Builder.ConnectionString
        End Function

        Public Shared Function DocPaths() As String
            Try
                Return R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.DocumentsPath, 0) + "\pic common"
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function RptPaths() As String
            Try
                Return R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.DocumentsPath, 0) + "\rpt"
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function IconsPath() As String
            Try
                Return R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.DocumentsPath, 0) + "\atlas icons"
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function EmzaPaths() As String
            Try
                Return R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.DocumentsPath, 0) + "\emza secret"
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function PersonelPicPath() As String
            Try
                Return R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.DocumentsPath, 0) + "\personelpic"
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        'Private Shared _OpenConnection As SqlClient.SqlConnection = (New R2PrimarySqlConnection).GetConnection
        'Private Shared WithEvents ConnectionTimer As New System.Timers.Timer(60000)

        'Public Sub ForceConnectionToOpen(YourTimerInterval As Int64)
        '    Try
        '        _OpenConnection.Close()
        '        _OpenConnection.Open()
        '        ConnectionTimer.Interval = YourTimerInterval
        '        ConnectionTimer.Enabled = True
        '        ConnectionTimer.Start()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End Sub

        'Public Shared Function GetOpenConnection() As SqlConnection
        '    Try
        '        If _OpenConnection.State <> ConnectionState.Closed Then Return _OpenConnection
        '        _OpenConnection.Open()
        '        ConnectionTimer.Enabled = True
        '        ConnectionTimer.Start()
        '        Return _OpenConnection
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End Function

        'Private Shared Sub ConnectionTimerHandler() Handles ConnectionTimer.Elapsed
        '    Try
        '        ConnectionTimer.Enabled = False
        '        ConnectionTimer.Stop()
        '        _OpenConnection.Close()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End Sub

    End Class

End Namespace

Namespace ConfigurationManagement

    Public MustInherit Class R2CoreConfigurations
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property DigitsFontInformation As Int64 = 1
        Public Shared ReadOnly Property GrdsCellColor As Int64 = 2
        Public Shared ReadOnly Property JPGBitmap As Int64 = 3
        Public Shared ReadOnly Property EsfandRooz As Int64 = 4
        Public Shared ReadOnly Property DocumentsPath As Int64 = 5
        Public Shared ReadOnly Property RFIDCardReadersType As Int64 = 6
        Public Shared ReadOnly Property RFIDCardReaderSetting As Int64 = 7
        Public Shared ReadOnly Property RFIDCardNotConfirmMessage As Int64 = 8
        Public Shared ReadOnly Property FrmcDialogMessage As Int64 = 9
        Public Shared ReadOnly Property RFIDCardDefultBuffer As Int64 = 10
        Public Shared ReadOnly Property SmsSystemSetting As Int64 = 11
        Public Shared ReadOnly Property ProgrammerDebugFlag As Int64 = 21
        Public Shared ReadOnly Property Suprema As Int64 = 24
        Public Shared ReadOnly Property Dermalog As Int64 = 25
        Public Shared ReadOnly Property VerifyIdentifyFPUCEnable As Int64 = 27
        Public Shared ReadOnly Property SaveFingerPrintsPath As Int64 = 32
        Public Shared ReadOnly Property FirstPageColor As Int64 = 42
        Public Shared ReadOnly Property ApplicationDomainDisplayTitle As Int64 = 43
        Public Shared ReadOnly Property SystemDisplayTitle As Int64 = 44
        Public Shared ReadOnly Property UCProcessGroup As Int64 = 45
        Public Shared ReadOnly Property UCProcessColor As Int64 = 46
        Public Shared ReadOnly Property PersonnelAttendanceSystem As Int64 = 47
        Public Shared ReadOnly Property InvalidRFIDCards As Int64 = 49
        Public Shared ReadOnly Property UCUCComputerMessageCollection As Int64 = 50
        Public Shared ReadOnly Property GovernmentVat As Int64 = 60
        Public Shared ReadOnly Property MonetaryCreditSupplySources As Int64 = 65
        Public Shared ReadOnly Property MonetarySettingTools As Int64 = 66
        Public Shared ReadOnly Property AttachedPoses As Int64 = 67
        Public Shared ReadOnly Property R2PrimaryAutomatedJobsSetting As Int64 = 70
        Public Shared ReadOnly Property SoftwareUserTypesAccessMobileProcesses As Int64 = 72
        Public Shared ReadOnly Property SoftwareUserTypesRelationMobileProcessGroups As Int64 = 73
        Public Shared ReadOnly Property PublicMessagesforSoftWareUsers As Int64 = 74
        Public Shared ReadOnly Property DefaultConfigurationOfSoftwareUserSecurity As Int64 = 76
        Public Shared ReadOnly Property PublicSecurityConfiguration As Int64 = 77
        Public Shared ReadOnly Property SqlInjectionPrevention As Int64 = 78
        Public Shared ReadOnly Property ZarrinPalPaymentGate As Int64 = 79
        Public Shared ReadOnly Property SoftwareUserTypesAccessWebProcesses As Int64 = 80
        Public Shared ReadOnly Property SoftwareUserTypesRelationWebProcessGroups As Int64 = 81
        Public Shared ReadOnly Property EmailSystem As Int64 = 83
        Public Shared ReadOnly Property ShepaPaymentGate As Int64 = 84

    End Class

    Public Class R2CoreStandardConfigurationStructure
        Inherits BaseStandardClass.R2StandardStructure

        Public Sub New()
            MyBase.New()
            CId = 0
            CName = String.Empty
            CValue = String.Empty
            Orientation = String.Empty
            Description = String.Empty
        End Sub

        Public Sub New(ByVal YourCId As Int64, ByVal YourCNamee As String, ByVal YourCValue As String, ByVal YourOrientation As String, YourDescription As String)
            MyBase.New(YourCId, YourCNamee)
            CId = YourCId
            CName = YourCNamee
            CValue = YourCValue
            Orientation = YourOrientation
            Description = YourDescription
        End Sub

        Public Property CId As Int64

        Public Property CName As String

        Public Property CValue As String

        Public Property Orientation As String

        Public Property Description As String

    End Class

    Public Class R2CoreInstanceConfigurationManager
        Public Function GetConfigInt64(YourCId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfig(YourCId As Int64, YourIndex As Int64) As Object
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2Primary.dbo.TblConfigurations Where CId=" & YourCId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfig(YourCId As Int64) As Object
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2Primary.dbo.TblConfigurations Where CId=" & YourCId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Ds.Tables(0).Rows(0).Item("CValue")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigBoolean(YourCId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigString(YourCId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourIndex).trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigString(YourCId As Int64) As String
            Try
                Return GetConfig(YourCId).trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public MustInherit Class R2CoreMClassConfigurationManagement

        Public Shared Function GetConfigOnLine(YourCId As Int64) As Object
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2Primary.dbo.TblConfigurations Where CId=" & YourCId & "")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                If Da.Fill(Ds) = 0 Then Throw New GetDataException
                Return Ds.Tables(0).Rows(0).Item("CValue").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfig(YourCId As Int64, YourIndex As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 CValue from R2Primary.dbo.TblConfigurations Where CId=" & YourCId & "", 2000, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfig(YourCId As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 CValue from R2Primary.dbo.TblConfigurations Where CId=" & YourCId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Ds.Tables(0).Rows(0).Item("CValue")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigRealTime(YourCId As Int64, YourIndex As Int64) As Object
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2Primary.dbo.TblConfigurations Where CId=" & YourCId & "")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Throw New GetDataException
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigBoolean(YourCId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourIndex).trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64) As String
            Try
                Return GetConfig(YourCId).trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt32(YourCId As Int64, YourIndex As Int64) As Int32
            Try
                Return GetConfig(YourCId, YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt64(YourCId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared myMainDatabaseName As String = Nothing
        Private Shared myDefaultConnectionString As String = Nothing
        Private Shared mySubscriptionDBConnectionString As String = Nothing
        Private Shared myComputerCode As String


        Public Shared Sub FillPublicVariables()
            Try
                Dim fs As New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\Timciens.txt", IO.FileMode.Open, IO.FileAccess.Read)
                Dim sr As New System.IO.StreamReader(fs)
                sr.BaseStream.Seek(0, IO.SeekOrigin.Begin)
                Dim FirstLine = sr.ReadLine
                myComputerCode = Convert.ToInt64(Mid(FirstLine, 3, 3))
                Dim DSSubscriptionDB = Split(Mid(FirstLine, 8, 20), "$")(0)
                Dim PasswordSubscriptionDB = Split(Mid(FirstLine, 26, 100), "$")(0)
                myMainDatabaseName = Split(Mid(sr.ReadLine, 31, 100), "$")(0)
                Dim DSTemp = Split(Mid(sr.ReadLine, 15, 100), "$")(0)
                Dim PasswordTemp = Split(Mid(sr.ReadLine, 4, 100), "$")(0)
                myDefaultConnectionString = "Data Source=@DS;Initial Catalog=@IC;Persist Security Info=True;User ID=sa;Password=@Password".Replace("@DS", DSTemp).Replace("@Password", PasswordTemp)
                mySubscriptionDBConnectionString = "Data Source=@DS;Initial Catalog=@IC;Persist Security Info=True;User ID=sa;Password=@Password".Replace("@DS", DSSubscriptionDB).Replace("@Password", PasswordSubscriptionDB)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Shared Function GetMainDatabaseName() As String
            Try
                If myMainDatabaseName = Nothing Then FillPublicVariables()
                '    myMainDatabaseName = GetAppConfigValue(ApplicationRegistryType.Publiq, "MainDatabaseName", "R2PrimaryMainDataBaseName")
                '    If myMainDatabaseName Is Nothing Then
                '        Throw New Exception("اشکال در محتوای رجیستری")
                '    End If
                'End If
                Return myMainDatabaseName
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function GetDefaultConnectionString() As String
            Try
                If myDefaultConnectionString = Nothing Then FillPublicVariables()
                '    myDefaultConnectionString = GetAppConfigValue(ApplicationRegistryType.Publiq, "DefaultConnectionString", "DefaultConnectionString")
                '    If myDefaultConnectionString Is Nothing Then
                '        Throw New Exception("اشکال در محتوای رجیستری")
                '    End If
                'End If
                Return myDefaultConnectionString
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function GetSubscriptionDBConnectionString() As String
            Try
                If mySubscriptionDBConnectionString = Nothing Then FillPublicVariables()
                Return mySubscriptionDBConnectionString
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function GetComputerCode() As String
            Try
                If myComputerCode = Nothing Then FillPublicVariables()
                '    myComputerCode = R2CoreMClassConfigurationManagement.GetAppConfigValue(ApplicationRegistryType.Publiq, "ComputerCode", "ComputerCode")
                '    If myComputerCode Is Nothing Then
                '        Throw New Exception("اشکال در محتوای رجیستری")
                '    End If
                'End If
                Return myComputerCode
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigurations() As List(Of R2CoreStandardConfigurationStructure)
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblConfigurations Order by CId", 1, Ds)
                Dim Lst As List(Of R2CoreStandardConfigurationStructure) = New List(Of R2CoreStandardConfigurationStructure)
                For Loopx As Int64 = Ds.Tables(0).Rows.Count - 1 To 0 Step -1
                    Lst.Add(New R2CoreStandardConfigurationStructure(Ds.Tables(0).Rows(Loopx).Item("CId"), Ds.Tables(0).Rows(Loopx).Item("CName").trim, Ds.Tables(0).Rows(Loopx).Item("CValue").trim, Ds.Tables(0).Rows(Loopx).Item("Orientation").trim, Ds.Tables(0).Rows(Loopx).Item("Description").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub SetConfiguration(YourNSS As R2CoreStandardConfigurationStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblConfigurations Set CValue = '" & YourNSS.CValue & "' Where CId=" & YourNSS.CId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub SetConfiguration(YourCId As Int64, YourIndex As Int64, YourCValue As String)
            Try
                Dim CurrentConfigValue As String = GetConfigOnLine(YourCId)
                Dim CurrentConfigValueSplitted As String() = Split(CurrentConfigValue, ";")
                Dim SB As New StringBuilder
                For Loopx As Int64 = 0 To CurrentConfigValueSplitted.Length - 1
                    If Loopx = YourIndex Then
                        SB.Append(YourCValue)
                    Else
                        SB.Append(CurrentConfigValueSplitted(Loopx))
                    End If
                    If Loopx < CurrentConfigValueSplitted.Length - 1 Then SB.Append(";")
                Next
                SetConfiguration(New R2CoreStandardConfigurationStructure(YourCId, Nothing, SB.ToString(), Nothing, Nothing))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

End Namespace

Namespace DateAndTimeManagement

    Public NotInheritable Class R2CoreMclassDateAndTimeManagement
        Public Shared Function GetPersianDaysDiffDate(YourDate1 As String, YourDate2 As String) As Int64
            Try
                Dim year1 As Int64 = Convert.ToInt64(YourDate1.Substring(0, 4))
                Dim month1 As Int64 = Convert.ToInt64(YourDate1.Substring(5, 2))
                Dim day1 As Int64 = Convert.ToInt64(YourDate1.Substring(8, 2))

                Dim year2 As Int64 = Convert.ToInt64(YourDate2.Substring(0, 4))
                Dim month2 As Int64 = Convert.ToInt64(YourDate2.Substring(5, 2))
                Dim day2 As Int64 = Convert.ToInt64(YourDate2.Substring(8, 2))

                Dim Calendar As System.Globalization.PersianCalendar = New System.Globalization.PersianCalendar()
                Dim dt1 As DateTime = Calendar.ToDateTime(year1, month1, day1, 0, 0, 0, 0)
                Dim dt2 As DateTime = Calendar.ToDateTime(year2, month2, day2, 0, 0, 0, 0)
                Dim ts As TimeSpan = dt2.Subtract(dt1)
                Return ts.Days
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class

    Public Class R2StandardDateAndTimeStructure

        Private myDateTimeMilladi As DateTime
        Private myDateTimeMilladiFormated As String
        Private myDateShamsiFull As String
        Private myTime As String

        Public Sub New()
            MyBase.New()
            myDateTimeMilladi = Date.Now : myDateTimeMilladiFormated = String.Empty : myDateShamsiFull = "" : myTime = ""
        End Sub

        Public Sub New(ByVal DateTimeMilladii As DateTime, ByVal DateShamsiFulll As String, ByVal Timee As String)
            myDateTimeMilladi = DateTimeMilladii
            myDateTimeMilladiFormated = myDateTimeMilladi.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
            myDateShamsiFull = DateShamsiFulll
            myTime = Timee
        End Sub

        Public Property DateTimeMilladi() As DateTime
            Get
                Return myDateTimeMilladi
            End Get
            Set(ByVal Value As DateTime)
                myDateTimeMilladi = Value
            End Set
        End Property

        Public ReadOnly Property DateTimeMilladiFormated() As String
            Get
                Return myDateTimeMilladiFormated
            End Get
        End Property


        Public Property DateShamsiFull() As String
            Get
                Return myDateShamsiFull
            End Get
            Set(ByVal Value As String)
                myDateShamsiFull = Value
            End Set
        End Property

        Public Property Time() As String
            Get
                Return myTime
            End Get
            Set(ByVal Value As String)
                myTime = Value
            End Set
        End Property

        Public ReadOnly Property GetShamsiYear() As String
            Get
                Return Mid(DateShamsiFull, 1, 4)
            End Get
        End Property

        Public ReadOnly Property GetShamsiMonth() As String
            Get
                Return Mid(DateShamsiFull, 6, 2)
            End Get
        End Property

        Public ReadOnly Property GetShamsiDay() As String
            Get
                Return Mid(DateShamsiFull, 9, 2)
            End Get
        End Property

        Public ReadOnly Property GetHour() As String
            Get
                Return Mid(Time, 1, 2)
            End Get
        End Property

        Public ReadOnly Property GetMinute() As String
            Get
                Return Mid(Time, 4, 2)
            End Get
        End Property

        Public ReadOnly Property GetSecond() As String
            Get
                Return Mid(Time, 7, 2)
            End Get
        End Property

        Public ReadOnly Property GetConcatString() As String
            Get
                Return DateShamsiFull.Replace("/", "") + Time.Replace(":", "")
            End Get
        End Property



    End Class
    Public Class R2DateTime
        'Dim mycurrenttime As String = Trim(Mid(DateAndTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 8))
        Private myOpenConnection As R2PrimarySubscriptionDBSqlConnection = New R2PrimarySubscriptionDBSqlConnection
        Private PC As New System.Globalization.PersianCalendar()
        Private HC As New System.Globalization.HijriCalendar()

        Public Sub New()
            'myOpenConnection.GetConnection.Open()
        End Sub
        Protected Overrides Sub Finalize()
            'If myOpenConnection.GetConnection.State <> ConnectionState.Closed Then myOpenConnection.GetConnection.Close()
        End Sub
        Public Function GetTimeOfDate(ByVal YouDateTime As DateTime) As String
            Try
                Dim mycurrenttime As String = Trim(Mid(YouDateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 8))
                Return mycurrenttime
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentTickofTime() As TimeSpan
            Try
                Return Date.ParseExact(GetCurrentDateTimeMilladiFormated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetMilladiDateTimeFromDateShamsiFull(ByVal YourShamsiDateFull As String, YourTime As String) As Date
            Try
                Return PC.ToDateTime(Mid(YourShamsiDateFull, 1, 4), Mid(YourShamsiDateFull, 6, 2), Mid(YourShamsiDateFull, 9, 2), Mid(YourTime, 1, 2), Mid(YourTime, 4, 2), Mid(YourTime, 7, 2), 0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetMilladiDateTimeFromDateShamsiFullFormated(ByVal YourShamsiDateFull As String, YourTime As String) As String
            Try
                Return PC.ToDateTime(Mid(YourShamsiDateFull, 1, 4), Mid(YourShamsiDateFull, 6, 2), Mid(YourShamsiDateFull, 9, 2), Mid(YourTime, 1, 2), Mid(YourTime, 4, 2), Mid(YourTime, 7, 2), 0).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetYesterdayShamsiDate() As String
            Try
                Return ConvertToShamsiDateFull(DateTime.Now.AddDays(-1))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetNextShamsiMonth(YourShamsiDate As R2StandardDateAndTimeStructure, YourNextMonth As Int16) As R2StandardDateAndTimeStructure
            Try
                Dim MilladiTemp As DateTime = GetMilladiDateTimeFromDateShamsiFull(YourShamsiDate.DateShamsiFull, YourShamsiDate.Time)
                MilladiTemp = MilladiTemp.AddMonths(YourNextMonth)
                Return New R2StandardDateAndTimeStructure(Nothing, ConvertToShamsiDateFull(MilladiTemp), Nothing)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Private Function GetSqlServerCurrentDate() As DateTime
            Try
                Dim CmdsqlDateTime As SqlClient.SqlCommand = New SqlClient.SqlCommand("Select Getdate()")
                CmdsqlDateTime.Connection = myOpenConnection.GetConnection
                CmdsqlDateTime.Connection.Open()
                Dim myDateTime As DateTime = CmdsqlDateTime.ExecuteScalar
                CmdsqlDateTime.Connection.Close()
                Return myDateTime
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentTimeSecond() As String
            Try
                Return Trim(Mid(GetSqlServerCurrentDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 8))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentTimeMinute() As String
            Try
                Return Trim(Mid(GetSqlServerCurrentDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 5))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetNextDateShamsi() As DateTime
            Try
                Return ConvertToShamsiDateFull(GetCurrentDateTimeMilladi().Today.AddDays(1))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Function GetNextDateShamsiWithoutSlashes() As String
            Try
                Return ConvertToShamsiDateFull(GetCurrentDateTimeMilladi().Today.AddDays(1)).Replace("/", "")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Function GetCurrentTime() As String
            Try
                Return Trim(Mid(GetSqlServerCurrentDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 8))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentDateTime() As R2StandardDateAndTimeStructure
            Try
                Return New R2StandardDateAndTimeStructure(GetCurrentDateTimeMilladiFormated, GetCurrentDateShamsiFull, GetCurrentTime)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentDateShamsiFull() As String
            Try
                Return ConvertToShamsiDateFull(GetSqlServerCurrentDate())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentDateShamsiFullWithoutSlashes() As String
            Try
                Return GetCurrentDateShamsiFull.Replace("/", "")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentDateShamsi() As String
            Try
                Return Mid(Trim(GetCurrentDateShamsiFull), 3, 20)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function ConvertToShamsiDateFull(ByVal MilladiDate As DateTime) As String
            Try
                Dim MM(12) As Byte
                Dim yy, y, D, M, sum, a As Int16
                Dim m1, d1, y1 As String
                MM(1) = 31
                MM(2) = 28
                MM(3) = 31
                MM(4) = 30
                MM(5) = 31
                MM(6) = 30
                MM(7) = 31
                MM(8) = 31
                MM(9) = 30
                MM(10) = 31
                MM(11) = 30
                MM(12) = 31
                D = Microsoft.VisualBasic.DateAndTime.Day(MilladiDate)
                M = Month(MilladiDate)
                y = Year(MilladiDate)
                yy = y - 1980
                yy = yy - Int(yy / 4) * 4
                If yy = 0 Then
                    MM(2) = 29
                Else
                    MM(2) = 28
                End If
                sum = 0
                If M <> 1 Then
                    For I As Int16 = 1 To M - 1
                        sum = sum + MM(I)
                    Next
                End If
                sum = sum + D
                If yy = 1 Then
                    sum = sum + 287
                Else
                    sum = sum + 286
                End If
                If yy = 1 Then
                    a = 366
                Else
                    a = 365
                End If
                If sum > a Then
                    sum = sum - a
                    y = y + 1
                End If
                If sum > 186 Then
                    sum = sum - 186
                    M = 7 + Int(sum / 30)
                    D = sum - (Int(sum / 30) * 30)
                    If D = 0 Then
                        D = 30
                        M = M - 1
                    End If
                Else
                    M = 1 + Int(sum / 31)
                    D = sum - (Int(sum / 31) * 31)
                    If D = 0 Then
                        M = M - 1
                        D = 31
                    End If
                End If
                y = y - 622
                If M < 10 Then
                    m1 = "0" + Trim(Str(M))
                Else
                    m1 = Trim(Str(M))
                End If
                If D < 10 Then
                    d1 = "0" + Trim(Str(D))
                Else
                    d1 = Trim(Str(D))
                End If
                y1 = Trim(Str(y))
                Return (y1 + "/" + m1 + "/" + d1)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentDateTimeMilladi() As DateTime
            Try
                Return GetSqlServerCurrentDate()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentDateTimeMilladiFormated() As String
            Try
                Return GetSqlServerCurrentDate().ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentSalShamsi() As String
            Try
                Return Mid(GetCurrentSalShamsiFull, 1, 2)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function GetCurrentSalShamsiFull() As String
            Try
                Return Mid(GetCurrentDateShamsiFull, 1, 4)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function ChekDateShamsiFullSyntax(ByVal Datex As String) As Boolean
            Try
                Dim mydate As String = Trim(Datex)
                Dim mysal As String = Mid(mydate, 1, 4)
                Dim mymah As String = Mid(mydate, 6, 2)
                Dim myrooz As String = Mid(mydate, 9, 2)
                If Len(mydate) <> 10 Then Return False
                If Mid(mydate, 5, 1) <> "/" Then Return False
                If Mid(mydate, 8, 1) <> "/" Then Return False
                If Not ((Val(mymah) >= 1) And (Val(mymah) <= 12)) Then Return False
                If ((Val(mymah) >= 1) And (Val(mymah) <= 6)) Then
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= 31)) Then Return False
                ElseIf ((Val(mymah) >= 7) And (Val(mymah) <= 11)) Then
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= 30)) Then Return False
                ElseIf (Val(mymah) = 12) Then
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.EsfandRooz, 0))) Then Return False
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Public Function ChekDateShamsiSyntax(ByVal Datex As String) As Boolean
            Try
                Dim mydate As String = Trim(Datex)
                Dim mysal As String = Mid(mydate, 1, 2)
                Dim mymah As String = Mid(mydate, 4, 2)
                Dim myrooz As String = Mid(mydate, 7, 2)
                If Len(mydate) <> 8 Then Return False
                If Mid(mydate, 3, 1) <> "/" Then Return False
                If Mid(mydate, 6, 1) <> "/" Then Return False
                If Not ((Val(mymah) >= 1) And (Val(mymah) <= 12)) Then Return False
                If ((Val(mymah) >= 1) And (Val(mymah) <= 6)) Then
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= 31)) Then Return False
                ElseIf ((Val(mymah) >= 7) And (Val(mymah) <= 11)) Then
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= 30)) Then Return False
                ElseIf (Val(mymah) = 12) Then
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.EsfandRooz, 0))) Then Return False
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Function ChekTimeSyntax(ByVal zaman As String) As Boolean
            Try
                Dim mytime As String = Trim(zaman)
                If Len(mytime) <> 8 Then
                    Return False : Exit Function
                End If
                If Mid(mytime, 3, 1) <> ":" Then
                    Return False : Exit Function
                End If
                If Mid(mytime, 6, 1) <> ":" Then
                    Return False : Exit Function
                End If
                If Not ((CInt(Mid(mytime, 1, 2)) >= 0) And (CInt(Mid(mytime, 1, 2)) <= 23)) Then
                    Return False : Exit Function
                End If
                If Not ((CInt(Mid(mytime, 4, 2)) >= 0) And (CInt(Mid(mytime, 4, 2)) <= 59)) Then
                    Return False : Exit Function
                End If
                If Not ((CInt(Mid(mytime, 7, 2)) >= 0) And (CInt(Mid(mytime, 4, 2)) <= 59)) Then
                    Return False : Exit Function
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Function GetPersianMonthName(ByVal YourDateShamsi As String) As String
            Dim Mah As String = Mid(YourDateShamsi, 6, 2)
            If Mah = "01" Then Return "فروردین ماه"
            If Mah = "02" Then Return "اردیبهشت  ماه"
            If Mah = "03" Then Return "خرداد  ماه"
            If Mah = "04" Then Return "تیر  ماه"
            If Mah = "05" Then Return "مرداد  ماه"
            If Mah = "06" Then Return "شهریور  ماه"
            If Mah = "07" Then Return "مهر  ماه"
            If Mah = "08" Then Return "آبان  ماه"
            If Mah = "09" Then Return "آذر  ماه"
            If Mah = "10" Then Return "دی  ماه"
            If Mah = "11" Then Return "بهمن  ماه"
            If Mah = "12" Then Return "اسفند  ماه"
        End Function

        Public Function GetDelimetedTime(YourUnDelimetedTime As String) As String
            Dim InstancePublicProcedures As New R2Core.PublicProc.R2CoreInstancePublicProceduresManager
            If YourUnDelimetedTime.Length < 8 Then YourUnDelimetedTime = YourUnDelimetedTime + InstancePublicProcedures.RepeatStr("0", 8 - YourUnDelimetedTime.Length)
            Return Mid(YourUnDelimetedTime, 1, 2) + ":" + Mid(YourUnDelimetedTime, 3, 2) + ":" + Mid(YourUnDelimetedTime, 5, 2)
        End Function

    End Class
    Public Class HafteMahManagement
        'روتين پر کردن کمبو هفته 
        Public Shared Sub CmbHafteRefresh(ByVal cmbhafte As ComboBox)
            Try
                cmbhafte.Items.Clear()
                For loopx As Int16 = 10 To 16
                    cmbhafte.Items.Add(Trim(Str(loopx)) + "    " + Trim(GetHafteRoozNameFromCode(loopx)))
                Next
                cmbhafte.Text = cmbhafte.Items(0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub
        'روتين پر کردن کمبو ماه 
        Public Shared Sub CmbMahRefresh(ByVal cmbmah As ComboBox)
            Try
                cmbmah.Items.Clear()
                For loopx As Int16 = 10 To 21
                    cmbmah.Items.Add(Trim(Str(loopx)) + "    " + Trim(GetMahNameFromMahCode(loopx)))
                Next
                cmbmah.Text = cmbmah.Items(0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub
        Public Shared Function GetMahNameFromMahCode(ByVal MahCode As String) As String
            If MahCode.Trim = "10" Then
                Return "فروردين"
            ElseIf MahCode.Trim = "11" Then
                Return "ارديبهشت"
            ElseIf MahCode.Trim = "12" Then
                Return "خرداد"
            ElseIf MahCode.Trim = "13" Then
                Return "تير"
            ElseIf MahCode.Trim = "14" Then
                Return "مرداد"
            ElseIf MahCode.Trim = "15" Then
                Return "شهريور"
            ElseIf MahCode.Trim = "16" Then
                Return "مهر"
            ElseIf MahCode.Trim = "17" Then
                Return "آبان"
            ElseIf MahCode.Trim = "18" Then
                Return "آذر"
            ElseIf MahCode.Trim = "19" Then
                Return "دي"
            ElseIf MahCode.Trim = "20" Then
                Return "بهمن"
            ElseIf MahCode.Trim = "21" Then
                Return "اسفند"
            End If
        End Function
        Public Shared Function GetHafteRoozNameFromCode(ByVal RoozCode As String) As String
            If RoozCode.Trim = "10" Then
                Return "شنبه"
            ElseIf RoozCode.Trim = "11" Then
                Return "يکشنبه"
            ElseIf RoozCode.Trim = "12" Then
                Return "دوشنبه"
            ElseIf RoozCode.Trim = "13" Then
                Return "سه شنبه"
            ElseIf RoozCode.Trim = "14" Then
                Return "چهارشنبه"
            ElseIf RoozCode.Trim = "15" Then
                Return "پنجشنبه"
            ElseIf RoozCode.Trim = "16" Then
                Return "جمعه"
            End If
        End Function
        'روتين برگرداندن تعداد روزهاي يک ماه شمسي
        Public Shared Function GetDaysOfMah(ByVal mahcode As String) As Int16
            'کد ماه بين 10 تا 21 است يعني فروردين تا اسفند
            Try
                Dim mymahcode As String = Trim(mahcode)
                If (Len(Trim(mahcode)) <> 2) Or (CInt(mahcode) - 9 < 1) Or (CInt(mahcode) - 9 > 12) Then
                    Throw New Exception("کد ماه شمسي بايد بين اعداد 10 تا 21 باشد")
                End If
                If (CInt(mahcode) - 9 >= 1) And (CInt(mahcode) - 9 <= 6) Then
                    Return 31 : Exit Function
                End If
                If (CInt(mahcode) - 9 >= 7) And (CInt(mahcode) - 9 <= 11) Then
                    Return 30 : Exit Function
                End If
                If (CInt(mahcode) - 9 = 12) Then Return R2CoreMClassConfigurationManagement.GetConfig(R2CoreConfigurations.EsfandRooz, 0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function


    End Class

    Namespace CalendarManagement

        Namespace PersianCalendar
            Public Enum PersianCalendarType
                None = 0
                Holiday = 1
            End Enum

            Public Class R2CoreInstanceDateAndTimePersianCalendarManager
                Private _DateTime = New R2DateTime

                Public Function GetHoliDayNumber(ByVal YourShamsiDate1 As String, ByVal YourShamsiDate2 As String) As UInteger
                    Try
                        Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                        Dim Ds As DataSet
                        InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) AS Counting from R2Primary.dbo.TblPersianCalendar where (dateshamsi>'" & YourShamsiDate1 & "') and (dateshamsi<'" & YourShamsiDate2 & "')  and PCType=1", 1, Ds)
                        Return Ds.Tables(0).Rows(0).Item("Counting")
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

                Public Function GetFirstDateShamsiInRangeWithoutHoliday(YourTopBaseDateShamsi As String, YourTotalDay As Int64) As String
                    Try
                        If Not _DateTime.ChekDateShamsiFullSyntax(YourTopBaseDateShamsi) Then Throw New ShamsiDateSyntaxNotValidException
                        Dim InstanceSqlDataBox As New R2CoreInstanseSqlDataBOXManager
                        Dim Ds As DataSet = Nothing
                        Dim Count = R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                 Where DateShamsi<
                                       (Select Top 1 * from 
                                           (Select Top " & YourTotalDay & " DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                            Where PCType=0 and DateShamsi<='" & YourTopBaseDateShamsi & "' Order By DateShamsi desc) as DataBox
                                        Order By DateShamsi)
                                 Order By DateShamsi Desc", 3600, Ds).GetRecordsCount()
                        If Count <> YourTotalDay Then Throw New FirstDateShamsiInRangeWithoutHolidayException
                        Return Ds.Tables(0).Rows(Count - 1).Item("DateShamsi")
                    Catch ex As ShamsiDateSyntaxNotValidException
                        Throw ex
                    Catch ex As FirstDateShamsiInRangeWithoutHolidayException
                        Throw ex
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
                    End Try
                End Function

            End Class

            Public NotInheritable Class R2CoreDateAndTimePersianCalendarManagement
                Public Shared Function GetHoliDayNumber(ByVal YourShamsiDate1 As String, ByVal YourShamsiDate2 As String) As UInteger
                    Try
                        Dim Ds As DataSet
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) AS Counting from R2Primary.dbo.TblPersianCalendar where (dateshamsi>'" & YourShamsiDate1 & "') and (dateshamsi<'" & YourShamsiDate2 & "')  and PCType=1", 1, Ds)
                        Return Ds.Tables(0).Rows(0).Item("Counting")
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function

                Public Shared Function GetLastNonHoliday(YourNSSDateTime As R2StandardDateAndTimeStructure) As R2StandardDateAndTimeStructure
                    Try
                        Dim Ds As DataSet
                        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblPersianCalendar Order By DateShamsi Desc", 3600, Ds)
                        Dim Record As DataRow
                        Record = Ds.Tables(0).Select("DateShamsi < '" & YourNSSDateTime.DateShamsiFull & "' and PCType=0", "DateShamsi Desc")(0)
                        Return New R2StandardDateAndTimeStructure(Nothing, Record.Item("DateShamsi"), Nothing)
                    Catch ex As Exception
                        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                    End Try
                End Function



            End Class

        End Namespace


    End Namespace

    Public Class ShamsiDateSyntaxNotValidException
        Inherits ApplicationException

        Public Overrides ReadOnly Property Message As String
            Get
                Return "تاریخ شمسی نادرست است"
            End Get
        End Property
    End Class

    Public Class TimeSyntaxNotValidException
        Inherits ApplicationException

        Public Overrides ReadOnly Property Message As String
            Get
                Return "فرمت ساعت نادرست است"
            End Get
        End Property
    End Class

    Public Class FirstDateShamsiInRangeWithoutHolidayException
        Inherits ApplicationException

        Public Overrides ReadOnly Property Message As String
            Get
                Return "یافتن اولین تاریخ در محدوده درخواستی برای روزهای بدون تعطیل با خطای اساسی مواجه شد"
            End Get
        End Property
    End Class

End Namespace

Namespace LoggingManagement

    Public MustInherit Class R2CoreLogType
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Note As Int64 = 1
        Public Shared ReadOnly Property Warn As Int64 = 2
        Public Shared ReadOnly Property Fail As Int64 = 3
        Public Shared ReadOnly Property Info As Int64 = 4
        Public Shared ReadOnly Property SuccessfulUserLogin As Int64 = 5
        Public Shared ReadOnly Property Print As Int64 = 6
        Public Shared ReadOnly Property RegisterRecords As Int64 = 7
        Public Shared ReadOnly Property Delete As Int64 = 8
        Public Shared ReadOnly Property Update As Int64 = 9
        Public Shared ReadOnly Property CameraError As Int64 = 10
        Public Shared ReadOnly Property TimeStamp As Int64 = 11
    End Class

    Public Class R2CoreStandardLogTypeStructure

        Public Sub New()
            _LogId = Int64.MinValue
            _LogName = String.Empty
            _LogTitle = String.Empty
            _LogColor = Color.White
            _Core = String.Empty
            _AssemblyDll = String.Empty
            _AssemblyPath = String.Empty
            _DateTimeMilladi = Now
            _DateShamsi = String.Empty
            _Time = String.Empty
            _Active = False
            _Deleted = False
        End Sub

        Public Sub New(ByVal YourLogId As Int64, YourLogName As String, YourLogTitle As String, YourLogColor As Color, YourCore As String, YourAssemblyDll As String, YourAssemblyPath As String, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourActive As Boolean, YourDeleted As Boolean)
            _LogId = YourLogId
            _LogName = YourLogName
            _LogTitle = YourLogTitle
            _LogColor = YourLogColor
            _Core = YourCore
            _AssemblyDll = YourAssemblyDll
            _AssemblyPath = YourAssemblyPath
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Time = YourTime
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Property LogId As Int64
        Public Property LogName As String
        Public Property LogTitle As String
        Public Property LogColor As Color
        Public Property Core As String
        Public Property AssemblyDll As String
        Public Property AssemblyPath As String
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public Class R2CoreStandardLoggingStructure

        Public Sub New()
            MyBase.New()
            _LogId = Int64.MinValue
            _LogType = R2CoreLogType.None
            _Sharh = String.Empty
            _Optional1 = String.Empty
            _Optional2 = String.Empty
            _Optional3 = String.Empty
            _Optional4 = String.Empty
            _Optional5 = String.Empty
            _UserId = Int64.MinValue
            _DateTimeMilladi = Now
            _DateShamsi = String.Empty
        End Sub

        Public Sub New(ByVal YourLogId As Int64, ByVal YourLogType As Int64, ByVal YourSharh As String, YourOptional1 As String, YourOptional2 As String, YourOptional3 As String, YourOptional4 As String, YourOptional5 As String, ByVal YourUserId As Int64, ByVal YourDateTimeMilladi As DateTime, ByVal YourDateShamsi As String)
            _LogId = YourLogId
            _LogType = YourLogType
            _Sharh = YourSharh
            _Optional1 = YourOptional1
            _Optional2 = YourOptional2
            _Optional3 = YourOptional3
            _Optional4 = YourOptional4
            _Optional5 = YourOptional5
            _UserId = YourUserId
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
        End Sub



        Public Property LogId() As Int64
        Public Property LogType() As Int64
        Public Property Sharh() As String
        Public Property Optional1() As String
        Public Property Optional2() As String
        Public Property Optional3() As String
        Public Property Optional4() As String
        Public Property Optional5() As String
        Public Property UserId() As Int64
        Public Property DateShamsi() As String
        Public Property DateTimeMilladi() As DateTime




    End Class

    Public Class R2CoreStandardLoggingExtendedStructure
        Inherits R2CoreStandardLoggingStructure
        Public Sub New()
            MyBase.New()
            _UserName = String.Empty
            _LogTypeColor = Color.Empty
        End Sub

        Public Sub New(ByVal YourNSSLog As R2CoreStandardLoggingStructure, ByVal YourUserName As String, ByVal YourLogTypeColor As Color)
            MyBase.New(YourNSSLog.LogId, YourNSSLog.LogType, YourNSSLog.Sharh, YourNSSLog.Optional1, YourNSSLog.Optional2, YourNSSLog.Optional3, YourNSSLog.Optional4, YourNSSLog.Optional5, YourNSSLog.UserId, YourNSSLog.DateTimeMilladi, YourNSSLog.DateShamsi)
            _UserName = YourUserName
            _LogTypeColor = YourLogTypeColor
        End Sub

        Public Property UserName As String
        Public Property LogTypeColor As Color

    End Class

    Public Class R2CoreInstanceLoggingManager
        Private _DateTime As New R2DateTime
        Public Sub LogRegister(ByVal YourLog As R2CoreStandardLoggingStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.CommandText = "insert into R2PrimaryLogging.dbo.TblLogging(logtype,sharh,Optional1,Optional2,Optional3,Optional4,Optional5,userid,dateshamsi,datetimemilladi) values(" & YourLog.LogType & ",'" & YourLog.Sharh & "','" & YourLog.Optional1 & "','" & YourLog.Optional2 & "','" & YourLog.Optional3 & "','" & YourLog.Optional4 & "','" & YourLog.Optional5 & "'," & YourLog.UserId & ",'" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "')"
                CmdSql.Connection.Open()
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSLogType(YourTypeId As Int64) As R2CoreStandardLogTypeStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim DS As DataSet = Nothing
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select * from R2PrimaryLogging.dbo.TblLoggingTypes Where LogId=" & YourTypeId & "", 3600, DS).GetRecordsCount = 0 Then Throw New LoggingTypeNotFoundException
                Return New R2CoreStandardLogTypeStructure(DS.Tables(0).Rows(0).Item("LogId"), DS.Tables(0).Rows(0).Item("LogName").trim, DS.Tables(0).Rows(0).Item("LogTitle").trim, Color.FromName(DS.Tables(0).Rows(0).Item("LogColor").trim), DS.Tables(0).Rows(0).Item("Core").trim, DS.Tables(0).Rows(0).Item("AssemblyDll").trim, DS.Tables(0).Rows(0).Item("AssemblyPath").trim, DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("Time"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As LoggingTypeNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Function
    End Class

    Public Class R2CoreMClassLoggingManagement

        Private Shared _DateTime As New R2DateTime

        Public Shared Sub LogRegister(ByVal YourLog As R2CoreStandardLoggingStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.CommandText = "insert into R2PrimaryLogging.dbo.TblLogging(logtype,sharh,Optional1,Optional2,Optional3,Optional4,Optional5,userid,dateshamsi,datetimemilladi) values(" & YourLog.LogType & ",'" & YourLog.Sharh & "','" & YourLog.Optional1 & "','" & YourLog.Optional2 & "','" & YourLog.Optional3 & "','" & YourLog.Optional4 & "','" & YourLog.Optional5 & "'," & YourLog.UserId & ",'" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "')"
                CmdSql.Connection.Open()
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Class R2CoreLogTypeNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع لاگ با مشخصات مورد نظر وجود ندارد"
                End Get
            End Property
        End Class



    End Class

    Namespace ExceptionManagemen
        Public Class LoggingTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع لاگ با شاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace DesktopProcessesManagement

    Public MustInherit Class R2CoreDesktopProcesses
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly XXX As Int64 = 1
        Public Shared ReadOnly FrmcUserPasswordEdit As Int64 = 2
        Public Shared ReadOnly FrmcComputerMessageBox As Int64 = 30
        Public Shared ReadOnly FrmcPersonnelInf As Int64 = 35
        Public Shared ReadOnly FrmcPersonnelAttendance As Int64 = 36
        Public Shared ReadOnly FrmcPersonnelEnterExitReport As Int64 = 37
        Public Shared ReadOnly FrmcPersonnelEnterExits As Int64 = 38
    End Class

    Public Class R2StandardDesktopProcessStructure
        Inherits R2StandardStructure

        Public Property PId As String = Int64.MinValue
        Public Property PName As String = String.Empty
        Public Property PDisplayTitle As String = String.Empty
        Public Property PAssemblyDll As String = String.Empty
        Public Property PAssemblyPath As String = String.Empty
        Public Property MenusTitle As String = String.Empty
        Public Property MenusPanel As String = String.Empty



        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal YourPId As String, ByVal YourPName As String, ByVal YourPDisplayTitle As String, ByVal YourPAssemblyDll As String, ByVal YourPAssemblyPath As String, YourMenusTitle As String, YourMenusPanel As String)
            MyBase.New(YourPId, YourPName.Trim())
            _PId = YourPId
            _PName = YourPName.Trim()
            _PDisplayTitle = YourPDisplayTitle.Trim()
            _PAssemblyDll = YourPAssemblyDll.Trim()
            _PAssemblyPath = YourPAssemblyPath.Trim()
            _MenusTitle = YourMenusTitle.Trim()
            _MenusPanel = YourMenusPanel.Trim()
        End Sub


    End Class

    Public Class R2StandardDesktopProcessGroupStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _PGId = Int64.MinValue
            _PGName = String.Empty
            _PGDisplayTitle = String.Empty
            _PGForeColor = Color.Black
            _PGBackColor = Color.White
        End Sub

        Public Sub New(ByVal YourPGId As Int64, ByVal YourPGName As String, ByVal YourPGDisplayTitle As String, YourPGForeColor As Color, YourPGBackColor As Color)
            MyBase.New(YourPGId, YourPGName)
            _PGId = YourPGId
            _PGName = YourPGName
            _PGDisplayTitle = YourPGDisplayTitle
            _PGForeColor = YourPGForeColor
            _PGBackColor = YourPGBackColor
        End Sub


        Public Property PGId As Int64
        Public Property PGName As String
        Public Property PGDisplayTitle As String
        Public Property PGForeColor As Color
        Public Property PGBackColor As Color

    End Class

    Public Structure R2StandardMenuStructure
        Dim MenuTitle As String
        Dim MenuPanel As String
    End Structure

    Public MustInherit Class R2CoreMClassDesktopProcessesManagement

        Public Shared Function GetNSSProcess(YourPId As Int64) As R2StandardDesktopProcessStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblDesktopProcesses Where PId=" & YourPId & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetDataException
                End If
                Dim NSS As R2StandardDesktopProcessStructure = New R2StandardDesktopProcessStructure
                NSS.PAssemblyDll = Ds.Tables(0).Rows(0).Item("PAssemblyDll").Trim()
                NSS.PDisplayTitle = Ds.Tables(0).Rows(0).Item("PDisplayTitle").Trim()
                NSS.PName = Ds.Tables(0).Rows(0).Item("PName").Trim()
                NSS.PAssemblyPath = Ds.Tables(0).Rows(0).Item("PAssemblyPath").Trim()
                NSS.PId = Ds.Tables(0).Rows(0).Item("PId")
                NSS.MenusTitle = Ds.Tables(0).Rows(0).Item("MenusTitle").Trim()
                NSS.MenusPanel = Ds.Tables(0).Rows(0).Item("MenusPanel").Trim()
                Return NSS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSProcessGroup(YourPGId As Int64) As R2StandardDesktopProcessGroupStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblDesktopProcessGroups Where PGId=" & YourPGId & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetDataException
                End If
                Dim NSS As R2StandardDesktopProcessGroupStructure = New R2StandardDesktopProcessGroupStructure
                NSS.PGId = Ds.Tables(0).Rows(0).Item("PGId")
                NSS.PGName = Ds.Tables(0).Rows(0).Item("PName")
                NSS.PGDisplayTitle = Ds.Tables(0).Rows(0).Item("PGDisplayTitle")
                NSS.PGForeColor = Ds.Tables(0).Rows(0).Item("PGForeColor")
                NSS.PGBackColor = Ds.Tables(0).Rows(0).Item("PGBackColor")
                Return NSS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetListOfProcessGroupsHaveUser(YourNSSUser As R2CoreStandardSoftwareUserStructure) As List(Of R2StandardDesktopProcessGroupStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2Primary.dbo.TblDesktopProcessGroups Where PGID In (Select PGID From R2Primary.dbo.TblSoftwareUsersRelationProcessGroups Where UserId=" & YourNSSUser.UserId & ") Order By PGId", 3600, Ds).GetRecordsCount <> 0 Then
                    Dim Lst As New List(Of R2StandardDesktopProcessGroupStructure)
                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        Dim NSS As New R2StandardDesktopProcessGroupStructure
                        NSS.PGDisplayTitle = Ds.Tables(0).Rows(Loopx).Item("PGDisplayTitle").trim
                        NSS.PGId = Ds.Tables(0).Rows(Loopx).Item("PGId")
                        NSS.PGName = Ds.Tables(0).Rows(Loopx).Item("PGName").trim
                        NSS.PGForeColor = Color.FromName(Ds.Tables(0).Rows(Loopx).Item("PGForeColor").trim)
                        NSS.PGBackColor = Color.FromName(Ds.Tables(0).Rows(Loopx).Item("PGBackColor").trim)
                        Lst.Add(NSS)
                    Next
                    Return Lst
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

    Public Class R2CoreMenuReflectedPanelNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "پنل مرتبط با منوی مورد نظر موجود نیست"
            End Get
        End Property
    End Class


End Namespace

Namespace ExceptionManagement

    Public MustInherit Class R2CoreMClassExceptionsManagement
        Public Shared Function GetSqlExceptionMessage(YourSqlExceptionId As Int64) As String
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 Message from R2Primary.dbo.TblSqlExceptions Where SEId=" & YourSqlExceptionId & " Order By SEId Asc", 3600, Ds).GetRecordsCount() = 0 Then Throw New SqlExceptionNotFoundException
                Return Ds.Tables(0).Rows(0).Item("Message")
            Catch ex As SqlExceptionNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class SqlExceptionNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "اس کیو ال اکسپشن با کد شاخص مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class InvalidEntryAmountException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "مقدار وارد شده نادرست است"
            End Get
        End Property
    End Class

    Public Class InvalidEntryNumberException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "تعداد وارد شده نادرست است"
            End Get
        End Property
    End Class

    Public Class GetNSSException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "اطلاعات مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class GetDataException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "اطلاعات مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class DataEntryException
        Inherits ApplicationException

        Private _Message = String.Empty

        Public Sub New()
            _Message = "اطلاعات وارد شده صحیح نیست،کلیه اطلاعات وارد شده را بررسی کنید"
        End Sub

        Public Sub New(YourMessage As String)
            _Message = YourMessage
        End Sub

        Public Overrides ReadOnly Property Message As String
            Get
                Return _Message
            End Get
        End Property
    End Class

    Public Class FileNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "فایل موجود نیست"
            End Get
        End Property
    End Class

    Public Class UserNotAllowedRunThisProccessException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "کاربر مجوز دسترسی ندارد"
            End Get
        End Property
    End Class



End Namespace

Namespace RFIDCardsManagement

    Public Class R2CoreStandardRFIDCardStructure
        Inherits BaseStandardClass.R2StandardStructure

        Private _CardId As String
        Private _CardNo As String
        Private _Active As Boolean
        Private _DateTimeMilladiSabt As DateTime
        Private _DateTimeMilladiEdit As DateTime
        Private _DateShamsiSabt As String
        Private _DateShamsiEdit As String



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            _CardId = "" : _CardNo = "" : _Active = False : _DateTimeMilladiSabt = "" : _DateTimeMilladiEdit = "" : _DateShamsiSabt = "" : _DateShamsiEdit = ""
        End Sub
        Public Sub New(ByVal CardIdd As String, ByVal CardNoo As String, ByVal Activee As Boolean, ByVal DateTimeMilladiSabtt As DateTime, ByVal DateTimeMilladiEditt As DateTime, ByVal DateShamsiSabtt As String, ByVal DateShamsiEditt As String)
            MyBase.New(CardIdd, CardNoo)
            _CardId = CardIdd
            _CardNo = CardNoo
            _Active = Activee
            _DateTimeMilladiSabt = DateTimeMilladiSabtt
            _DateTimeMilladiEdit = DateTimeMilladiEditt
            _DateShamsiSabt = DateShamsiSabtt
            _DateShamsiEdit = DateShamsiEditt
        End Sub
#End Region
#Region "Properting Management"
        Public Property CardId() As String
            Get
                Return _CardId
            End Get
            Set(ByVal Value As String)
                _CardId = Value
            End Set
        End Property
        Public Property CardNo() As String
            Get
                Return _CardNo
            End Get
            Set(ByVal Value As String)
                _CardNo = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return _Active
            End Get
            Set(ByVal Value As Boolean)
                _Active = Value
            End Set
        End Property
        Public Property DateTimeMilladiSabt() As DateTime
            Get
                Return _DateTimeMilladiSabt
            End Get
            Set(ByVal Value As DateTime)
                _DateTimeMilladiSabt = Value
            End Set
        End Property
        Public Property DateTimeMilladiEdit() As DateTime
            Get
                Return _DateTimeMilladiEdit
            End Get
            Set(ByVal Value As DateTime)
                _DateTimeMilladiEdit = Value
            End Set
        End Property
        Public Property DateShamsiSabt() As String
            Get
                Return _DateShamsiSabt
            End Get
            Set(ByVal Value As String)
                _DateShamsiSabt = Value
            End Set
        End Property
        Public Property DateShamsiEdit() As String
            Get
                Return _DateShamsiEdit
            End Get
            Set(ByVal Value As String)
                _DateShamsiEdit = Value
            End Set
        End Property
#End Region


    End Class

    Public Class R2CoreRFIDCardReader
        Public Declare Function MF_GetDLL_Ver Lib "MF_API.dll" (ByRef rVER As Byte) As Short
        Public Declare Function MF_InitComm Lib "MF_API.dll" (ByVal portname As String, ByVal baud As Integer) As Integer
        Public Declare Function MF_ControlBuzzer Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef BeepTime As Short) As Integer
        Public Declare Function MF_DeviceReset Lib "MF_API.dll" (ByVal DeviceAddr As Short) As Integer
        Public Declare Function MF_ExitComm Lib "MF_API.dll" () As Integer
        Public Declare Function MF_GetDevice_Ver Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef ver As Byte) As Integer
        Public Declare Function MF_SetDeviceBaud Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal baud As Integer) As Integer
        Public Declare Function MF_SetDeviceAddr Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal addr As Short) As Integer
        Public Declare Function MF_ControlLED Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal LED1 As Short, ByVal LED2 As Short) As Integer
        Public Declare Function MF_GetDeviceAddr Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef addr As Byte) As Integer
        Public Declare Function MF_SetDeviceSNR Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal snr As String) As Integer
        Public Declare Function MF_GetDeviceSNR Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef snr As Byte) As Integer
        Public Declare Function MF_SetRF_ON Lib "MF_API.dll" (ByVal DeviceAddr As Short) As Integer
        Public Declare Function MF_SetRF_OFF Lib "MF_API.dll" (ByVal DeviceAddr As Short) As Integer
        Public Declare Function MF_SetWiegandMode Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal mode As Short, ByVal alarm As Short) As Integer
        '''''''''''''''''''''''''''''''''''card reading functions''''''''''''''''''''''''''''''''''''''''''
        Public Declare Function MF_Request Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal mode As Short, ByRef CardType As Byte) As Integer
        Public Declare Function MF_Anticoll Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef snr As Byte) As Integer
        Public Declare Function MF_Halt Lib "MF_API.dll" (ByVal DeviceAddr As Short) As Integer
        Public Declare Function MF_Select Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef snr As Byte) As Integer
        Public Declare Function MF_LoadKey Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByRef key As Byte) As Integer

        Public Declare Function MF_LoadKeyFromEE Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal KeyType As Short, ByVal KeyNum As Short) As Integer
        Public Declare Function MF_StoreKeyToEE Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal KeyAB As Short, ByVal KeyAdd As Short, ByRef key As Byte) As Integer
        Public Declare Function MF_Authentication Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal AuthType As Short, ByVal block As Short, ByRef snr As Byte) As Integer
        Public Declare Function MF_Read Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal block As Short, ByVal numbers As Short, ByRef databuff As Byte) As Integer
        Public Declare Function MF_Write Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal block As Short, ByVal numbers As Short, ByRef databuff As Byte) As Integer
        Public Declare Function MF_Value Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal valoption As Short, ByRef value As Byte) As Integer
        Public Declare Function MF_transfer Lib "MF_API.dll" (ByVal DeviceAddr As Short, ByVal block As Short) As Integer

        Public DLL_version(32) As Byte
        Public portN(3) As Byte
        Public Dver(32) As Byte
        Public Daddress As Byte
        Public Dsn(7) As Byte
        Public cardT(2) As Byte
        Public cardSN(3) As Byte
        Public Ckey(5) As Byte
        Public databuffer(16) As Byte
        Public value(3) As Byte
        Public Dbuffer(63) As Byte
        Public Function hex2dec(ByVal inpt As String) As Short
            'On Error Resume Next
            If Len(inpt) = 1 Then inpt = "0" & inpt
            Select Case (Mid(inpt, 1, 1))
                Case "A" : hex2dec = hex2dec + 10 * 16
                Case "a" : hex2dec = hex2dec + 10 * 16
                Case "B" : hex2dec = hex2dec + 11 * 16
                Case "b" : hex2dec = hex2dec + 11 * 16
                Case "C" : hex2dec = hex2dec + 12 * 16
                Case "c" : hex2dec = hex2dec + 12 * 16
                Case "D" : hex2dec = hex2dec + 13 * 16
                Case "d" : hex2dec = hex2dec + 13 * 16
                Case "E" : hex2dec = hex2dec + 14 * 16
                Case "e" : hex2dec = hex2dec + 14 * 16
                Case "F" : hex2dec = hex2dec + 15 * 16
                Case "f" : hex2dec = hex2dec + 15 * 16
                Case Else : hex2dec = hex2dec + CDbl(Mid(inpt, 1, 1)) * 16
            End Select
            Select Case (Mid(inpt, 2, 1))
                Case "A" : hex2dec = hex2dec + 10
                Case "a" : hex2dec = hex2dec + 10
                Case "B" : hex2dec = hex2dec + 11
                Case "b" : hex2dec = hex2dec + 11
                Case "C" : hex2dec = hex2dec + 12
                Case "c" : hex2dec = hex2dec + 12
                Case "D" : hex2dec = hex2dec + 13
                Case "d" : hex2dec = hex2dec + 13
                Case "E" : hex2dec = hex2dec + 14
                Case "e" : hex2dec = hex2dec + 14
                Case "F" : hex2dec = hex2dec + 15
                Case "f" : hex2dec = hex2dec + 15
                Case Else : hex2dec = hex2dec + CDbl(Mid(inpt, 2, 1))
            End Select
        End Function
        '  Declare Function MF_InitComm1 Lib "MF_API.dll" Alias "MF_InitComm" (ByVal portname As String, ByVal baud As Long) As Long
        ' Public Declare Function MF_InitComm Lib "MF_API.dll" (ByVal portname As String, ByVal baud As Integer) As Integer
        'Declare Function MF_ExitComm Lib "MF_API.dll" Alias "MF_ExitComm" () As Long
        ' Declare Function MF_InitComm Lib "MF_API.dll" Alias "MF_InitComm" (ByVal portname As String, ByVal baud As Long) As Long
        ''Private Enum RFIDCardReaderOpenClosePort
        ''    Open = 1
        ''    Close = 2
        ''End Enum

        Public Shared Function ControlLeds(ByVal YourLed1 As Short, ByVal YourLed2 As Short) As Integer
            Return MF_ControlLED(0, YourLed1, YourLed2)
        End Function

        Private Function ControlBuzzer(ByRef BeepTime As Short) As Integer
            Return MF_ControlBuzzer(0, BeepTime)
        End Function

        Public Enum RFType
            None = 0
            RFType1 = 1
            RFType2 = 2
        End Enum
        ''Private Function Open_Close_Port(ByVal OC As RFIDCardReaderOpenClosePort) As Integer
        Private Function Open_Close_Port(ByVal YourRFType As RFType) As Integer
            Dim PortName As String
            MF_ExitComm()
            If YourRFType = RFType.RFType1 Then
                PortName = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReadersType, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
                If (PortName.Trim()).ToUpper() <> "NONE" Then
                    Return MF_InitComm(PortName, 9600)
                End If
            End If
            If YourRFType = RFType.RFType2 Then
                PortName = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReadersType, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1)
                If (PortName.Trim()).ToUpper() <> "NONE" Then
                    Return MF_InitComm(PortName, 9600)
                End If
            End If
        End Function
        Private Function Request(ByRef CardType As String) As Integer
            Dim myState As Integer = MF_Request(0, 0, cardT(0))
            If myState <> 0 Then
                Return myState
            Else
                CardType = cardT(0) & cardT(1)
                Return 0
            End If
        End Function
        Private Function Anticol(ByRef CardNo As String) As Integer
            Dim myState As Integer = MF_Anticoll(0, cardSN(0))
            If myState = 0 Then
                CardNo = Hex(cardSN(0)) & Hex(cardSN(1)) & Hex(cardSN(2)) & Hex(cardSN(3))
                Return 0
            Else
                Return myState
            End If
        End Function
        Private Function Select_Card() As Integer
            Return MF_Select(0, cardSN(0))
        End Function
        Private Function Load_Key() As Integer
            Ckey(0) = 255 : Ckey(1) = 255 : Ckey(2) = 255 : Ckey(3) = 255 : Ckey(4) = 255 : Ckey(5) = 255
            Return MF_LoadKey(0, Ckey(0))
        End Function
        Private Function Authentication() As Integer
            Return MF_Authentication(0, 0, 0, cardSN(0))
        End Function
        Private Function Read_Block(ByRef BufferBlock As String) As Integer
            Dim myState As Integer = MF_Read(0, 0, 1, databuffer(0))
            If myState = 0 Then
                BufferBlock = Hex(databuffer(0)) & " " & Hex(databuffer(1)) & " " & Hex(databuffer(2)) & " " & Hex(databuffer(3)) & " " & Hex(databuffer(4)) & " " & Hex(databuffer(5)) & " " & Hex(databuffer(6)) & " " & Hex(databuffer(7)) & " " & Hex(databuffer(8)) & " " & Hex(databuffer(9)) & " " & Hex(databuffer(10)) & " " & Hex(databuffer(11)) & " " & Hex(databuffer(12)) & " " & Hex(databuffer(13)) & " " & Hex(databuffer(14)) & " " & Hex(databuffer(15))
                Return 0
            Else
                Return myState
            End If
        End Function
        Private Function Write_Block(ByRef Buf As Byte()) As Integer
            Return MF_Write(0, 0, 1, Buf(0))
        End Function

        Private myRFType As RFType = RFType.None
        Public ReadOnly Property GetRFType As RFType
            Get
                Return myRFType
            End Get
        End Property
        Public Function StartAnticol(ByRef CardNo As String) As Integer
            Dim Status As Integer
            Try
                ''Open_Close_Port(RFIDCardReaderOpenClosePort.Open)
                If Open_Close_Port(RFType.RFType1) = 0 Then
                    myRFType = RFType.RFType1
                    Request(New String("A"))
                    Status = Anticol(CardNo)
                    If Status = 0 Then Return Status
                End If
                ''If Open_Close_Port(RFType.RFType2) = 0 Then
                ''    myRFType = RFType.RFType2
                ''    Request(New String("A"))
                ''    Status = Anticol(CardNo)
                ''    Return Status
                ''End If
                Return -1  'هیچ دستگاهی وجود ندارد یا کارتی خوانده نشد
            Catch ex As Exception
                Throw New Exception("R2RFIDCardReader.StartAnticol()." + ex.Message.ToString)
            End Try
        End Function
        Public Function StartReadBuffer(ByRef myBuffer As String) As Integer
            Try
                ''Open_Close_Port(RFIDCardReaderOpenClosePort.Open)
                Open_Close_Port(RFType.RFType1)
                Request(New String("A"))
                Select_Card()
                Load_Key()
                Authentication()
                Return Read_Block(myBuffer)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Function StartWriteBuffer(ByRef Buffer As Byte()) As Integer
            Try
                ''Open_Close_Port(RFIDCardReaderOpenClosePort.Open)
                Open_Close_Port(RFType.RFType1)
                Request(New String("A"))
                Select_Card()
                Load_Key()
                Authentication()
                Return Write_Block(Buffer)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Function ControlBuzzerOFReader(ByRef BeepTime As Short) As Integer
            Try
                Return ControlBuzzer(BeepTime)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class

    Public Interface R2CoreRFIDCardRequester
        Sub R2RFIDCardReaderStartToRead()
        Sub R2RFIDCardReaded(CardNo As String)
        Sub R2RFIDCardReaderWarning(MessageWarning As String)
    End Interface

    Public MustInherit Class R2CoreRFIDCardReaderInterface

        Public Enum InterfaceMode
            TestForRFIDCardConfirm = 0
            NoTestForRFIDCardConfirm = 1
        End Enum
        Private Shared _Requester As R2CoreRFIDCardRequester = Nothing
        Private Shared WithEvents ReaderTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer
        Private Shared RFIDCardReader As R2CoreRFIDCardReader = New R2CoreRFIDCardReader
        Private Shared _CurrentCardNo As String = Nothing
        Private Shared _InterfaceMode As InterfaceMode

        Public Shared Sub DisposeResources()
            ReaderTimer.Stop()
            ReaderTimer.Enabled = False
        End Sub

        Public Shared Sub StartReading(YourRequester As R2CoreRFIDCardRequester, YourInterfaceMode As InterfaceMode)
            Try
                'ذخیره رفرنس درخواست کننده
                _Requester = YourRequester
                _InterfaceMode = YourInterfaceMode
                'اطلاع رسانی به درخواست کننده
                YourRequester.R2RFIDCardReaderStartToRead()
                'شروع تایمر
                ReaderTimer.Enabled = True
                ReaderTimer.Interval = 1000
                ReaderTimer.Start()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub StopReading()
            Try
                ReaderTimer.Enabled = False
                ReaderTimer.Stop()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function StartReadBuffer(ByVal YourBuffer As String) As Integer
            Return RFIDCardReader.StartReadBuffer(YourBuffer)
        End Function

        Public Shared Function StartWriteBuffer(ByVal YourBuffer As String) As Integer
            RFIDCardReader.StartWriteBuffer(System.Text.Encoding.Unicode.GetBytes(YourBuffer))
        End Function

        Public Shared Sub BeepRFIDCardReader(ByVal BeepTime As Short)
            Try
                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreConfigurations.RFIDCardReaderSetting, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2) = True Then RFIDCardReader.ControlBuzzerOFReader(BeepTime)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared Sub ReaderTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReaderTimer.Tick
            Try
                'شبیه سازی خواندن کارت آراف
                Dim SimulNo As String = R2CoreMClassConfigurationOfComputersManagement.GetConfig(R2CoreConfigurations.RFIDCardReaderSetting, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0).Trim
                If SimulNo <> "" Then
                    ReaderTimer.Stop()
                    _Requester.R2RFIDCardReaded(SimulNo)
                    Exit Sub
                End If

                If RFIDCardReader.StartAnticol(_CurrentCardNo) = 0 Then
                    ReaderTimer.Stop()

                    Dim InavidRFIDCards As String() = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.InvalidRFIDCards, 0).Split("-")
                    If InavidRFIDCards.Contains(_CurrentCardNo) Then
                        MessageBox.Show("کابل دستگاه کارت خوان را جدا نموده و مجددا متصل کنید")
                        ReaderTimer.Start()
                    End If

                    If _InterfaceMode = InterfaceMode.TestForRFIDCardConfirm Then
                        If R2CoreMClassRFIDCardManagement.IsRFIDCardNoConfirm(_CurrentCardNo) = True Then
                            _Requester.R2RFIDCardReaded(_CurrentCardNo)
                            Exit Sub
                        Else
                            ReaderTimer.Start()
                            _Requester.R2RFIDCardReaderWarning(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.RFIDCardNotConfirmMessage, 0))
                        End If
                    Else
                        _Requester.R2RFIDCardReaded(_CurrentCardNo)
                        Exit Sub
                    End If
                Else
                End If
            Catch ex As Exception
                ReaderTimer.Stop()
                MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message.ToString)
            End Try
        End Sub

        Public Shared Function GetRFType() As R2CoreRFIDCardReader.RFType
            Return RFIDCardReader.GetRFType
        End Function

        Public Shared ReadOnly Property CurrentCardNo As String
            Get
                Return _CurrentCardNo
            End Get
        End Property

        Public Shared Function ControlLeds(ByVal YourLed1 As Short, ByVal YourLed2 As Short) As Integer
            Return RFIDCardReader.ControlLeds(YourLed1, YourLed2)
        End Function


    End Class

    Public Class R2CoreMClassRFIDCardManagement
        Private Shared _DateTime As R2DateTime = New R2DateTime()

        Public Shared Function IsRFIDCardNoConfirm(ByVal CardNo As String) As Boolean
            Try
                Dim Ds As DataSet = New DataSet() : Dim Da As New SqlDataAdapter
                Da.SelectCommand = New SqlCommand("select Top 1 CardId from R2Primary.dbo.TblRfidCards Where ltrim(rtrim(CardNo))='" & CardNo.Trim() & "' order by Cardid Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Sub RFIDCardInitialRegister(YourCardNo As String, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection
            Try
                If IsRFIDCardNoConfirm(YourCardNo) = True Then
                    Throw New Exception("کارت مورد نظر قبلا ثبت شده است")
                End If
                Dim Ds As DataSet = New DataSet() : Dim Da As New SqlDataAdapter
                Da.SelectCommand = New SqlCommand("select Top 1 CardId from R2Primary.dbo.TblRfidCards order by Cast(Cardid as int) Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Dim myCardID As String
                If Da.Fill(Ds) <> 0 Then
                    myCardID = Ds.Tables(0).Rows(0).Item("CardId") + 1
                Else
                    myCardID = "1"
                End If
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "insert into R2Primary.dbo.tblrfidcards(CardId,CardNo,Charge,UserIdSabt,UserIdEdit,PelakType,Pelak,Serial,NoMoney,Active,CompanyName,NameFamily,Mobile,Address,Tel,Tahvilg,DateTimeMilladiSabt,DateTimeMilladiEdit,DateShamsiSabt,DateShamsiEdit,CardType,TempCardType) values(" & myCardID & ",'" & YourCardNo & "',0," & YourUserNSS.UserId & "," & YourUserNSS.UserId & ",0,'','',0,1,'','','','','','','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "',0,0)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub
        Public Shared Function GetNSSRFIDCard(ByVal YourCardNo As String) As R2CoreStandardRFIDCardStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblRFIDCards Where ltrim(rtrim(CardNo))='" & YourCardNo & "' Order By CardId Desc", 1, Ds).GetRecordsCount = 0 Then Throw New RFIdCardNotFoundException
                Return New R2CoreStandardRFIDCardStructure(Ds.Tables(0).Rows(0).Item("CardId"), Ds.Tables(0).Rows(0).Item("CardNo"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiSabt"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiEdit"), Ds.Tables(0).Rows(0).Item("DateShamsiSabt"), Ds.Tables(0).Rows(0).Item("DateShamsiEdit"))
            Catch ex As RFIdCardNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetNSSRFIDCard(ByVal YourCardId As Int64) As R2CoreStandardRFIDCardStructure
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblRFIDCards Where ltrim(rtrim(CardId))=" & YourCardId & "", 1, Ds)
                Return New R2CoreStandardRFIDCardStructure(Ds.Tables(0).Rows(0).Item("CardId"), Ds.Tables(0).Rows(0).Item("CardNo"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiSabt"), Ds.Tables(0).Rows(0).Item("DateTimeMilladiEdit"), Ds.Tables(0).Rows(0).Item("DateShamsiSabt"), Ds.Tables(0).Rows(0).Item("DateShamsiEdit"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
        Public Shared Function GetRFIDCardsTeadadReal() As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("SELECT COUNT(*) FROM R2Primary.dbo.TblRFIDCards GROUP BY CardNo")
                Da.SelectCommand.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Return Da.Fill(Ds)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class RFIdCardNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات وارد شده نادرست است"
                End Get
            End Property
        End Class

    End Namespace
End Namespace

Namespace ComputersManagement
    Public Class R2CoreStandardComputerStructure
        Inherits BaseStandardClass.R2StandardStructure



        Public Sub New()
            MyBase.New()
            MId = Int64.MinValue
            MName = String.Empty
            MDisplayTitle = String.Empty
            MLocation = String.Empty
            ViewFlag = Boolean.FalseString
            OActive = Boolean.FalseString
            Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourMId As Int64, ByVal YourMName As String, ByVal YourMDisplayTitle As String, ByVal YourMLocation As String, YourViewFlag As Boolean, YourOActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourMId, YourMName)
            MId = YourMId
            MName = YourMName
            MDisplayTitle = YourMDisplayTitle
            MLocation = YourMLocation
            OActive = YourOActive
            ViewFlag = YourViewFlag
            Deleted = YourDeleted
        End Sub



        Public Property MId As Int64
        Public Property MName As String
        Public Property MDisplayTitle As String
        Public Property MLocation As String
        Public Property ViewFlag As Boolean
        Public Property OActive As Boolean
        Public Property Deleted As Boolean


    End Class

    Public Class R2CoreMClassComputersManager
        Public Function GetNSSComputer(YourMId As String) As R2CoreStandardComputerStructure
            Try
                Dim Ds As DataSet
                Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputers Where MId='" & YourMId & "'", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardComputerStructure(Ds.Tables(0).Rows(0).Item("MId"), Ds.Tables(0).Rows(0).Item("MName").trim, Ds.Tables(0).Rows(0).Item("MDisplayTitle").trim, Ds.Tables(0).Rows(0).Item("MLocation").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("OActive"), Ds.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSCurrentComputer() As R2CoreStandardComputerStructure
            Try
                Dim Ds As DataSet
                Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputers Where MId=" & R2CoreMClassConfigurationManagement.GetComputerCode() & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardComputerStructure(Ds.Tables(0).Rows(0).Item("MId"), Ds.Tables(0).Rows(0).Item("MName").trim, Ds.Tables(0).Rows(0).Item("MDisplayTitle").trim, Ds.Tables(0).Rows(0).Item("MLocation").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("OActive"), Ds.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetComputers(YourSearchString As String) As List(Of R2StandardStructure)
            Try
                Dim Ds As DataSet
                Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
                InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputers Where OActive=1 and ViewFlag=1 and MDisplayTitle Like  '%" & YourSearchString & "%' Order By MId", 3600, Ds)
                Dim Lst As New List(Of R2StandardStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardComputerStructure(Ds.Tables(0).Rows(Loopx).Item("MId"), Ds.Tables(0).Rows(Loopx).Item("MName").trim, Ds.Tables(0).Rows(Loopx).Item("MDisplayTitle").trim, Ds.Tables(0).Rows(Loopx).Item("MLocation").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("OActive"), Ds.Tables(0).Rows(0).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreMClassComputersManagement
        Public Shared Function GetNSSComputer(YourMId As String) As R2CoreStandardComputerStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputers Where MId='" & YourMId & "'", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardComputerStructure(Ds.Tables(0).Rows(0).Item("MId"), Ds.Tables(0).Rows(0).Item("MName").trim, Ds.Tables(0).Rows(0).Item("MDisplayTitle").trim, Ds.Tables(0).Rows(0).Item("MLocation").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("OActive"), Ds.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSCurrentComputer() As R2CoreStandardComputerStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputers Where MId=" & R2CoreMClassConfigurationManagement.GetComputerCode() & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardComputerStructure(Ds.Tables(0).Rows(0).Item("MId"), Ds.Tables(0).Rows(0).Item("MName").trim, Ds.Tables(0).Rows(0).Item("MDisplayTitle").trim, Ds.Tables(0).Rows(0).Item("MLocation").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("OActive"), Ds.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetComputers(YourSearchString As String) As List(Of R2StandardStructure)
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblComputers Where OActive=1 and ViewFlag=1 and MDisplayTitle Like  '%" & YourSearchString & "%' Order By MId", 3600, Ds)
                Dim Lst As New List(Of R2StandardStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreStandardComputerStructure(Ds.Tables(0).Rows(Loopx).Item("MId"), Ds.Tables(0).Rows(Loopx).Item("MName").trim, Ds.Tables(0).Rows(Loopx).Item("MDisplayTitle").trim, Ds.Tables(0).Rows(Loopx).Item("MLocation").trim, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("OActive"), Ds.Tables(0).Rows(0).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreStandardConfigurationOfComputerStructure
        Inherits R2CoreStandardConfigurationStructure

        Public Sub New()
            MyBase.New()
            ComId = 0
            CValue = String.Empty
        End Sub

        Public Sub New(YourNSSConfiguration As R2CoreStandardConfigurationStructure, ByVal YourComId As Int64, ByVal YourCValue As String)
            MyBase.New(YourNSSConfiguration.CId, YourNSSConfiguration.CName, YourNSSConfiguration.CValue, YourNSSConfiguration.Orientation, YourNSSConfiguration.Description)
            ComId = YourComId
            CValue = YourCValue
        End Sub

        Public Property ComId As Int64

        Public Property CValue As String

    End Class

    Public Class R2CoreMClassConfigurationOfComputersManager

        Public Function GetConfigOnLine(YourCId As Int64, YourMId As Int64) As Object
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2Primary.dbo.TblConfigurationsOfComputers Where CId=" & YourCId & " and MId=" & YourMId & "")
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                If Da.Fill(Ds) = 0 Then Throw New GetDataException
                Return Ds.Tables(0).Rows(0).Item("CValue").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Function GetConfigRealTime(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Object
        '    Try
        '        Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
        '        Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2Primary.dbo.TblConfigurationsOfComputers Where CId=" & YourCId & " and MId=" & YourMId & "")
        '        Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
        '        Ds.Tables.Clear()
        '        If Da.Fill(Ds) = 0 Then Throw New GetDataException
        '        Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Function

        Public Function GetConfig(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Object
            Try
                Dim Ds As DataSet
                Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2Primary.dbo.TblConfigurationsOfComputers Where CId=" & YourCId & " and MId=" & YourMId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigString(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourMId, YourIndex).trim
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigInt32(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Int32
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigBoolean(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigInt64(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigDouble(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Double
            Try
                Dim xRong As Double = GetConfig(YourCId, YourMId, YourIndex)
                Return xRong
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigByte(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Byte
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch ex As GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Function GetConfigurationOfComputer(YourMId As Int64) As List(Of R2CoreStandardConfigurationOfComputerStructure)
        '    Try
        '        Dim Ds As DataSet
        '        Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
        '        InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
        '            "Select Configs.CId,Configs.CName,Configs.Description,Configs.Orientation,ConfigOfComps.CValue,ConfigOfComps.MId from R2Primary.dbo.TblConfigurations as Configs 
        '               Inner Join R2Primary.dbo.TblConfigurationsOfComputers as ConfigOfComps On Configs.CId=ConfigOfComps.CId
        '             Where ConfigOfComps.MId=" & YourMId & " Order By CId", 1, Ds)
        '        Dim Lst As New List(Of R2CoreStandardConfigurationOfComputerStructure)
        '        For Loopx As Int64 = Ds.Tables(0).Rows.Count - 1 To 0 Step -1
        '            Lst.Add(New R2CoreStandardConfigurationOfComputerStructure(New R2CoreStandardConfigurationStructure(Ds.Tables(0).Rows(Loopx).Item("CId"), Ds.Tables(0).Rows(Loopx).Item("CName").trim, Ds.Tables(0).Rows(Loopx).Item("CValue").trim, Ds.Tables(0).Rows(Loopx).Item("Orientation").trim, Ds.Tables(0).Rows(Loopx).Item("Description").trim), YourMId, Ds.Tables(0).Rows(Loopx).Item("CValue").trim))
        '        Next
        '        Return Lst
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Function

        Public Sub SetConfigurationOfComputer(YourNSS As R2CoreStandardConfigurationOfComputerStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblConfigurationsOfComputers Set CValue = '" & YourNSS.CValue & "' Where CId=" & YourNSS.CId & " and MId=" & YourNSS.ComId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub SetConfigurationOfComputer(YourCId As Int64, YourMId As Int64, YourIndex As Int64, YourCValue As String)
            Try
                Dim CurrentConfigValue As String = GetConfigOnLine(YourCId, YourMId)
                Dim CurrentConfigValueSplitted As String() = Split(CurrentConfigValue, ";")
                Dim SB As New StringBuilder
                For Loopx As Int64 = 0 To CurrentConfigValueSplitted.Length - 1
                    If Loopx = YourIndex Then
                        SB.Append(YourCValue)
                    Else
                        SB.Append(CurrentConfigValueSplitted(Loopx))
                    End If
                    If Loopx < CurrentConfigValueSplitted.Length - 1 Then SB.Append(";")
                Next
                SetConfigurationOfComputer(New R2CoreStandardConfigurationOfComputerStructure(New R2CoreStandardConfigurationStructure(YourCId, String.Empty, Nothing, String.Empty, String.Empty), YourMId, SB.ToString()))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

    Public NotInheritable Class R2CoreMClassConfigurationOfComputersManagement
        'Inherits R2CoreMClassConfigurationManagement

        Public Shared Function GetConfigOnLine(YourCId As Int64, YourMId As Int64) As Object
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2Primary.dbo.TblConfigurationsOfComputers Where CId=" & YourCId & " and MId=" & YourMId & "")
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                If Da.Fill(Ds) = 0 Then Throw New GetDataException
                Return Ds.Tables(0).Rows(0).Item("CValue").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Shared Function GetConfigRealTime(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Object
        '    Try
        '        Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
        '        Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2Primary.dbo.TblConfigurationsOfComputers Where CId=" & YourCId & " and MId=" & YourMId & "")
        '        Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
        '        Ds.Tables.Clear()
        '        If Da.Fill(Ds) = 0 Then Throw New GetDataException
        '        Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Function

        Public Shared Function GetConfig(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2Primary.dbo.TblConfigurationsOfComputers Where CId=" & YourCId & " and MId=" & YourMId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourMId, YourIndex).trim
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt32(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Int32
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigBoolean(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt64(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigDouble(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Double
            Try
                Dim xRong As Double = GetConfig(YourCId, YourMId, YourIndex)
                Return xRong
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigByte(YourCId As Int64, YourMId As Int64, YourIndex As Int64) As Byte
            Try
                Return GetConfig(YourCId, YourMId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigurationOfComputer(YourMId As Int64) As List(Of R2CoreStandardConfigurationOfComputerStructure)
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                    "Select Configs.CId,Configs.CName,Configs.Description,Configs.Orientation,ConfigOfComps.CValue,ConfigOfComps.MId from R2Primary.dbo.TblConfigurations as Configs 
                       Inner Join R2Primary.dbo.TblConfigurationsOfComputers as ConfigOfComps On Configs.CId=ConfigOfComps.CId
                     Where ConfigOfComps.MId=" & YourMId & " Order By CId", 3600, Ds)
                Dim Lst As New List(Of R2CoreStandardConfigurationOfComputerStructure)
                For Loopx As Int64 = Ds.Tables(0).Rows.Count - 1 To 0 Step -1
                    Lst.Add(New R2CoreStandardConfigurationOfComputerStructure(New R2CoreStandardConfigurationStructure(Ds.Tables(0).Rows(Loopx).Item("CId"), Ds.Tables(0).Rows(Loopx).Item("CName").trim, Ds.Tables(0).Rows(Loopx).Item("CValue").trim, Ds.Tables(0).Rows(Loopx).Item("Orientation").trim, Ds.Tables(0).Rows(Loopx).Item("Description").trim), YourMId, Ds.Tables(0).Rows(Loopx).Item("CValue").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub SetConfigurationOfComputer(YourNSS As R2CoreStandardConfigurationOfComputerStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblConfigurationsOfComputers Set CValue = '" & YourNSS.CValue & "' Where CId=" & YourNSS.CId & " and MId=" & YourNSS.ComId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub SetConfigurationOfComputer(YourCId As Int64, YourMId As Int64, YourIndex As Int64, YourCValue As String)
            Try
                Dim CurrentConfigValue As String = GetConfigOnLine(YourCId, YourMId)
                Dim CurrentConfigValueSplitted As String() = Split(CurrentConfigValue, ";")
                Dim SB As New StringBuilder
                For Loopx As Int64 = 0 To CurrentConfigValueSplitted.Length - 1
                    If Loopx = YourIndex Then
                        SB.Append(YourCValue)
                    Else
                        SB.Append(CurrentConfigValueSplitted(Loopx))
                    End If
                    If Loopx < CurrentConfigValueSplitted.Length - 1 Then SB.Append(";")
                Next
                SetConfigurationOfComputer(New R2CoreStandardConfigurationOfComputerStructure(New R2CoreStandardConfigurationStructure(YourCId, String.Empty, Nothing, String.Empty, String.Empty), YourMId, SB.ToString()))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class



End Namespace

Namespace ReportsManagement
    Public MustInherit Class R2CoreReports
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly UsersChargeReport As Int64 = 1
        Public Shared ReadOnly PersonnelEnterExitReport As Int64 = 5

    End Class

    Public Class R2StandardReportStructure
        Inherits BaseStandardClass.R2StandardStructure

        Private myRId As Int64
        Private myRName As String
        Private myRFullName As String
        Private myAssemblyFullPath As String
        Private myReportServerURL As String
        Private myReportServerPath As String
        Private myReportServerCredential As String
        Private myDescription As String

#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            myRId = 0 : myRName = "" : myRFullName = "" : myAssemblyFullPath = "" : myReportServerURL = "" : myReportServerPath = "" : myReportServerCredential = "" : myDescription = ""
        End Sub
        Public Sub New(ByVal YourRId As Int64, ByVal YourRName As String, ByVal YourRFullName As String, ByVal YourAssemblyFullPath As String, YourReportServerURL As String, YourReportServerPath As String, YourReportServerCredential As String, YourDescription As String)
            MyBase.New(YourRId, YourRName)
            myRId = YourRId
            myRName = YourRName
            myRFullName = YourRFullName
            myAssemblyFullPath = YourAssemblyFullPath
            myReportServerURL = YourReportServerURL
            myReportServerPath = YourReportServerPath
            myReportServerCredential = YourReportServerCredential
            myDescription = YourDescription
        End Sub
#End Region

#Region "Properting Management"
        Public Property RId() As Int64
            Get
                Return myRId
            End Get
            Set(ByVal Value As Int64)
                myRId = Value
            End Set
        End Property

        Public Property RName() As String
            Get
                Return myRName
            End Get
            Set(ByVal Value As String)
                myRName = Value
            End Set
        End Property

        Public Property RFullName() As String
            Get
                Return myRFullName
            End Get
            Set(ByVal Value As String)
                myRFullName = Value
            End Set
        End Property

        Public Property AssemblyFullPath() As String
            Get
                Return myAssemblyFullPath
            End Get
            Set(ByVal Value As String)
                myAssemblyFullPath = Value
            End Set
        End Property

        Public Property ReportServerURL() As String
            Get
                Return myReportServerURL
            End Get
            Set(ByVal Value As String)
                myReportServerURL = Value
            End Set
        End Property

        Public Property ReportServerPath() As String
            Get
                Return myReportServerPath
            End Get
            Set(ByVal Value As String)
                myReportServerPath = Value
            End Set
        End Property

        Public Property ReportServerCredential() As String
            Get
                Return myReportServerCredential
            End Get
            Set(ByVal Value As String)
                myReportServerCredential = Value
            End Set
        End Property

#End Region


    End Class

    Public NotInheritable Class R2CoreMClassReportsManagement
        Public Shared Function GetNSSReport(YourRId As String) As R2StandardReportStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblReports Where RId='" & YourRId & "'", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2StandardReportStructure(Ds.Tables(0).Rows(0).Item("RId"), Ds.Tables(0).Rows(0).Item("RName").trim, Ds.Tables(0).Rows(0).Item("RFullName").trim, Ds.Tables(0).Rows(0).Item("AssemblyFullPath").trim, Ds.Tables(0).Rows(0).Item("ReportServerURL").trim, Ds.Tables(0).Rows(0).Item("ReportServerPath").trim, Ds.Tables(0).Rows(0).Item("ReportServerCredential").trim, Ds.Tables(0).Rows(0).Item("Description").trim)
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class



End Namespace

Namespace FileShareRawGroupsManagement

    Public Enum R2CoreRawGroupsAccessType
        None = 0
        FileShare = 1
        FTP = 2
    End Enum

    Public Class R2CoreStandardRawGroupsStructure
        Inherits BaseStandardClass.R2StandardStructure

        Private _RGId As Int64
        Private _RGName As String
        Private _RGFullPath As String
        Private _AccessType As R2CoreRawGroupsAccessType
        Private _CoreName As String
        Private _DateTimeMilladi As DateTime
        Private _DateShamsi As String
        Private _Description As String
        Private _UserId As Int64



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            _RGId = 0 : _RGName = String.Empty : _RGFullPath = String.Empty : _AccessType = R2CoreRawGroupsAccessType.None : _CoreName = String.Empty : _DateTimeMilladi = Now : _DateShamsi = String.Empty : _Description = String.Empty : _UserId = R2CoreMClassSoftwareUsersManagement.GetNoneUserId
        End Sub
        Public Sub New(ByVal YourRGId As Int64, ByVal YourRGName As String, ByVal YourRGFullPath As String, ByVal YourAccessType As R2CoreRawGroupsAccessType, ByVal YourCoreName As String, ByVal YourDateTimeMilladi As DateTime, ByVal YourDateShamsi As String, YourDescription As String, YourUserId As Int64)
            MyBase.New(YourRGId, YourRGName)
            _RGId = YourRGId
            _RGName = YourRGName
            _RGFullPath = YourRGFullPath
            _AccessType = YourAccessType
            _CoreName = YourCoreName
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Description = YourDescription
            _UserId = YourUserId
        End Sub
#End Region
#Region "Properting Management"
        Public Property RGId() As Int64
            Get
                Return _RGId
            End Get
            Set(ByVal Value As Int64)
                _RGId = Value
            End Set
        End Property
        Public Property RGName() As String
            Get
                Return _RGName
            End Get
            Set(ByVal Value As String)
                _RGName = Value
            End Set
        End Property
        Public Property RGFullPath() As String
            Get
                Return _RGFullPath
            End Get
            Set(ByVal Value As String)
                _RGFullPath = Value
            End Set
        End Property
        Public Property AccessType() As R2CoreRawGroupsAccessType
            Get
                Return _AccessType
            End Get
            Set(ByVal Value As R2CoreRawGroupsAccessType)
                _AccessType = Value
            End Set
        End Property
        Public Property CoreName() As String
            Get
                Return _CoreName
            End Get
            Set(ByVal Value As String)
                _CoreName = Value
            End Set
        End Property
        Public Property DateTimeMilladi() As DateTime
            Get
                Return _DateTimeMilladi
            End Get
            Set(ByVal Value As DateTime)
                _DateTimeMilladi = Value
            End Set
        End Property
        Public Property DateShamsi() As String
            Get
                Return _DateShamsi
            End Get
            Set(ByVal Value As String)
                _DateShamsi = Value
            End Set
        End Property
        Public Property Discription() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property
        Public Property UserId() As Int64
            Get
                Return _UserId
            End Get
            Set(ByVal Value As Int64)
                _UserId = Value
            End Set
        End Property

#End Region


    End Class

    Public MustInherit Class R2CoreRawGroups
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly UserImages As Int64 = 1
        Public Shared ReadOnly PersonnelImages As Int64 = 4
        Public Shared ReadOnly UploadedFiles As Int64 = 6

    End Class

    Public Class R2CoreRawGroupFileHolder

        Protected Property RawGroupId As Int64 = R2CoreRawGroups.None
        Protected Property RawGroupFile As R2CoreFile = Nothing
        Protected Property RawGroupByteArray As Byte() = Nothing

        Public Sub New(YourRawGroupId As Int64, YourFile As R2CoreFile, YourByteArray As Byte())
            Try
                RawGroupId = YourRawGroupId
                RawGroupFile = YourFile
                RawGroupByteArray = YourByteArray
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub New(YourRawGroupId As Int64, YourFile As R2CoreFile)
            Try
                RawGroupId = YourRawGroupId
                RawGroupFile = YourFile
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Function GetFullPath(YourRawGroupId As Int64, YourFile As R2CoreFile) As String
            Try
                Dim _NSSCurrentRawGroup As R2CoreStandardRawGroupsStructure = R2CoreFileShareRawGroupsMClassManagement.GetNSSRawGroup(YourRawGroupId)
                Return _NSSCurrentRawGroup.RGFullPath + "\" + YourFile.FileName
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub SaveFile()
            Try
                Using FS As FileStream = New FileStream(GetFullPath(RawGroupId, RawGroupFile), FileMode.Create, FileAccess.Write)
                    FS.Write(RawGroupByteArray, 0, RawGroupByteArray.Length)
                End Using
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub GetFile(ByRef YourByteArray As Byte())
            Try
                Using FS As FileStream = New FileStream(GetFullPath(RawGroupId, RawGroupFile), FileMode.Open, FileAccess.Read)
                    YourByteArray = New Byte(FS.Length) {}
                    FS.Read(YourByteArray, 0, FS.Length)
                End Using
            Catch exx As IO.FileNotFoundException
                Throw New R2CoreFileNotFoundInRawGroupsException
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function ExistIOFile() As Boolean
            Try
                Return IO.File.Exists(GetFullPath(RawGroupId, RawGroupFile))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub DeleteFile()
            Try
                IO.File.Delete(GetFullPath(RawGroupId, RawGroupFile))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub DeleteFileButKeepDeleted()
            Try
                IO.File.Move(GetFullPath(RawGroupId, RawGroupFile), GetFullPath(RawGroupId, New R2CoreFile(RawGroupFile.FileName + ".del")))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub



    End Class

    Public MustInherit Class R2CoreFileShareRawGroupsMClassManagement

        Public Shared Function GetNSSRawGroup(YourRawGroupId As Int64) As R2CoreStandardRawGroupsStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblRawGroups Where RGId=" & YourRawGroupId & "", 3600, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                Else
                    Return New R2CoreStandardRawGroupsStructure(Ds.Tables(0).Rows(0).Item("RGId"), Ds.Tables(0).Rows(0).Item("RGName").trim, Ds.Tables(0).Rows(0).Item("RGFullPath").trim, Ds.Tables(0).Rows(0).Item("AccessType"), Ds.Tables(0).Rows(0).Item("CoreName").trim, Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi").trim, Ds.Tables(0).Rows(0).Item("Description").trim, Ds.Tables(0).Rows(0).Item("UserId"))
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class R2CoreFileNotFoundInRawGroupsException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "فایل مورد نظر موجود نیست"
            End Get
        End Property
    End Class




End Namespace

Namespace HumanResourcesManagement

    Namespace Personnel

        Public Enum R2CorePersonnelWhichFingerPrint
            FP1 = 1
            FP2 = 2
            FP3 = 3
            FP4 = 4
        End Enum

        Public Class R2CoreStandardPersonnelStructure
            Inherits BaseStandardClass.R2StandardStructure

            Private _PId As Int64
            Private _PIdOther As String
            Private _PNameFamily As String
            Private _PFatherName As String
            Private _NationalCode As String
            Private _Active As Boolean
            Private _Tel As String
            Private _Address As String
            Private _DateTimeMilladiSabt As DateTime
            Private _DateTimeMilladiEdit As DateTime
            Private _DateShamsiSabt As String
            Private _DateShamsiEdit As String
            Private _UserIdSabt As Byte
            Private _UserIdEdit As Byte
            Private _FingerPrint1 As Byte()
            Private _FingerPrint2 As Byte()
            Private _FingerPrint3 As Byte()
            Private _FingerPrint4 As Byte()

#Region "Constructing Management"
            Public Sub New()
                MyBase.New()
                _PId = 0 : _PIdOther = String.Empty : _PNameFamily = String.Empty : _PFatherName = String.Empty : _NationalCode = String.Empty : _Active = False : _Tel = String.Empty : _Address = String.Empty
                _UserIdSabt = 0 : _UserIdEdit = 0 : _DateTimeMilladiSabt = Nothing : _DateTimeMilladiEdit = Nothing : _DateShamsiSabt = String.Empty : _DateShamsiEdit = String.Empty
                _FingerPrint1 = Nothing : _FingerPrint2 = Nothing : _FingerPrint3 = Nothing : _FingerPrint4 = Nothing
            End Sub
            Public Sub New(ByVal YourPId As Int64, ByVal YourPIdOther As String, ByVal YourPNameFamily As String, ByVal YourPFatherName As String, ByVal YourNationCode As String, ByVal YourActive As Boolean, YourTel As String, YourAddress As String, ByVal YourUserIdSabt As Int64, ByVal YourUserIdEdit As Int64, ByVal YourDateTimeMilladiSabt As DateTime, ByVal YourDateTimeMilladiEdit As DateTime, ByVal YourDateShamsiSabt As String, ByVal YourDateShamsiEdit As String, ByVal YourFingerPrint1 As Byte(), ByVal YourFingerPrint2 As Byte(), ByVal YourFingerPrint3 As Byte(), ByVal YourFingerPrint4 As Byte())
                MyBase.New(YourPId, YourPNameFamily)
                _PId = YourPId
                _PIdOther = YourPIdOther
                _PNameFamily = YourPNameFamily
                _PFatherName = YourPFatherName
                _NationalCode = YourNationCode
                _Active = YourActive
                _Tel = YourTel
                _Address = YourAddress
                _UserIdSabt = YourUserIdSabt
                _UserIdEdit = YourUserIdEdit
                _DateTimeMilladiSabt = YourDateTimeMilladiSabt
                _DateTimeMilladiEdit = YourDateTimeMilladiEdit
                _DateShamsiSabt = YourDateShamsiSabt
                _DateShamsiEdit = YourDateShamsiEdit
                _FingerPrint1 = YourFingerPrint1
                _FingerPrint2 = YourFingerPrint2
                _FingerPrint3 = YourFingerPrint3
                _FingerPrint4 = YourFingerPrint4
            End Sub
#End Region
#Region "Properting Management"
            Public Property PId() As Int64
                Get
                    Return _PId
                End Get
                Set(ByVal Value As Int64)
                    _PId = Value
                End Set
            End Property
            Public Property PIdOther() As String
                Get
                    Return _PIdOther
                End Get
                Set(ByVal Value As String)
                    _PIdOther = Value
                End Set
            End Property
            Public Property PNameFamily() As String
                Get
                    Return _PNameFamily
                End Get
                Set(ByVal Value As String)
                    _PNameFamily = Value
                End Set
            End Property
            Public Property PFatherName() As String
                Get
                    Return _PFatherName
                End Get
                Set(ByVal Value As String)
                    _PFatherName = Value
                End Set
            End Property
            Public Property NationalCode() As String
                Get
                    Return _NationalCode
                End Get
                Set(ByVal Value As String)
                    _NationalCode = Value
                End Set
            End Property
            Public Property Active() As Boolean
                Get
                    Return _Active
                End Get
                Set(ByVal Value As Boolean)
                    _Active = Value
                End Set
            End Property
            Public Property Tel() As String
                Get
                    Return _Tel
                End Get
                Set(ByVal Value As String)
                    _Tel = Value
                End Set
            End Property
            Public Property Address() As String
                Get
                    Return _Address
                End Get
                Set(ByVal Value As String)
                    _Address = Value
                End Set
            End Property
            Public Property UserIdSabt() As Int64
                Get
                    Return _UserIdSabt
                End Get
                Set(ByVal Value As Int64)
                    _UserIdSabt = Value
                End Set
            End Property
            Public Property UserIdEdit() As Int64
                Get
                    Return _UserIdEdit
                End Get
                Set(ByVal Value As Int64)
                    _UserIdEdit = Value
                End Set
            End Property
            Public Property DateTimeMilladiSabt() As DateTime
                Get
                    Return _DateTimeMilladiSabt
                End Get
                Set(ByVal Value As DateTime)
                    _DateTimeMilladiSabt = Value
                End Set
            End Property
            Public Property DateTimeMilladiEdit() As DateTime
                Get
                    Return _DateTimeMilladiEdit
                End Get
                Set(ByVal Value As DateTime)
                    _DateTimeMilladiEdit = Value
                End Set
            End Property
            Public Property DateShamsiSabt() As String
                Get
                    Return _DateShamsiSabt
                End Get
                Set(ByVal Value As String)
                    _DateShamsiSabt = Value
                End Set
            End Property
            Public Property DateShamsiEdit() As String
                Get
                    Return _DateShamsiEdit
                End Get
                Set(ByVal Value As String)
                    _DateShamsiEdit = Value
                End Set
            End Property
            Public Property FingerPrint1() As Byte()
                Get
                    Return _FingerPrint1
                End Get
                Set(ByVal Value As Byte())
                    _FingerPrint1 = Value
                End Set
            End Property
            Public Property FingerPrint2() As Byte()
                Get
                    Return _FingerPrint2
                End Get
                Set(ByVal Value As Byte())
                    _FingerPrint2 = Value
                End Set
            End Property
            Public Property FingerPrint3() As Byte()
                Get
                    Return _FingerPrint3
                End Get
                Set(ByVal Value As Byte())
                    _FingerPrint3 = Value
                End Set
            End Property
            Public Property FingerPrint4() As Byte()
                Get
                    Return _FingerPrint4
                End Get
                Set(ByVal Value As Byte())
                    _FingerPrint4 = Value
                End Set
            End Property


#End Region


        End Class

        Public MustInherit Class R2CorePersonnelMClassManagement

            Private Shared _DateTime As R2DateTime = New R2DateTime()
            Private Shared _R2PrimaryFSWS As R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()


            Public Shared Function GetNSSPersonnel(YourPId As Int64) As R2CoreStandardPersonnelStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblPersonelInf Where PId=" & YourPId & "", 1, DS).GetRecordsCount() = 0 Then
                        Throw New GetNSSException
                    End If
                    Dim NSS As New R2CoreStandardPersonnelStructure
                    NSS.Active = DS.Tables(0).Rows(0).Item("Active")
                    NSS.DateShamsiEdit = DS.Tables(0).Rows(0).Item("DateShamsiEdit")
                    NSS.DateShamsiSabt = DS.Tables(0).Rows(0).Item("DateShamsiSabt")
                    NSS.DateTimeMilladiEdit = DS.Tables(0).Rows(0).Item("DateTimeMilladiEdit")
                    NSS.DateTimeMilladiSabt = DS.Tables(0).Rows(0).Item("DateTimeMilladiSabt")
                    NSS.FingerPrint1 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint"), Byte())
                    NSS.FingerPrint2 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint2"), Byte())
                    NSS.FingerPrint3 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint3"), Byte())
                    NSS.FingerPrint4 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint4"), Byte())
                    NSS.NationalCode = DS.Tables(0).Rows(0).Item("NationalCode")
                    NSS.PFatherName = DS.Tables(0).Rows(0).Item("PFatherName")
                    NSS.PId = DS.Tables(0).Rows(0).Item("PId")
                    NSS.PIdOther = DS.Tables(0).Rows(0).Item("PIdOther")
                    NSS.UserIdEdit = DS.Tables(0).Rows(0).Item("UserIdEdit")
                    NSS.UserIdSabt = DS.Tables(0).Rows(0).Item("UserIdSabt")
                    NSS.PNameFamily = DS.Tables(0).Rows(0).Item("PNameFamily")
                    NSS.Tel = DS.Tables(0).Rows(0).Item("Tel")
                    NSS.Address = DS.Tables(0).Rows(0).Item("Address")
                    Return NSS
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSPersonnel(YourPinCode As String) As R2CoreStandardPersonnelStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2Primary.dbo.TblPersonelInf Where Ltrim(Rtrim(PinCode))='" & YourPinCode & "'", 1, DS).GetRecordsCount() = 0 Then
                        Throw New GetNSSException
                    End If
                    Dim NSS As New R2CoreStandardPersonnelStructure
                    NSS.Active = DS.Tables(0).Rows(0).Item("Active")
                    NSS.DateShamsiEdit = DS.Tables(0).Rows(0).Item("DateShamsiEdit")
                    NSS.DateShamsiSabt = DS.Tables(0).Rows(0).Item("DateShamsiSabt")
                    NSS.DateTimeMilladiEdit = DS.Tables(0).Rows(0).Item("DateTimeMilladiEdit")
                    NSS.DateTimeMilladiSabt = DS.Tables(0).Rows(0).Item("DateTimeMilladiSabt")
                    NSS.FingerPrint1 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint"), Byte())
                    NSS.FingerPrint2 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint2"), Byte())
                    NSS.FingerPrint3 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint3"), Byte())
                    NSS.FingerPrint4 = DirectCast(DS.Tables(0).Rows(0).Item("FingerPrint4"), Byte())
                    NSS.NationalCode = DS.Tables(0).Rows(0).Item("NationalCode")
                    NSS.PFatherName = DS.Tables(0).Rows(0).Item("PFatherName")
                    NSS.PId = DS.Tables(0).Rows(0).Item("PId")
                    NSS.PIdOther = DS.Tables(0).Rows(0).Item("PIdOther")
                    NSS.UserIdEdit = DS.Tables(0).Rows(0).Item("UserIdEdit")
                    NSS.UserIdSabt = DS.Tables(0).Rows(0).Item("UserIdSabt")
                    NSS.PNameFamily = DS.Tables(0).Rows(0).Item("PNameFamily")
                    NSS.Tel = DS.Tables(0).Rows(0).Item("Tel")
                    NSS.Address = DS.Tables(0).Rows(0).Item("Address")
                    Return NSS
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IsExistPersonnel(YourNSS As R2CoreStandardPersonnelStructure) As Boolean
                Try
                    Dim DS As New DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New DatabaseManagement.R2PrimarySqlConnection, "Select PNameFamily from R2Primary.dbo.TblPersonelInf Where NationalCode='" & YourNSS.NationalCode & "'", 1, DS).GetRecordsCount <> 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function InsertPersonnel(YourNSS As R2CoreStandardPersonnelStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
                Dim CmdSql As SqlCommand = New SqlCommand
                CmdSql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection()
                Try
                    If IsExistPersonnel(YourNSS) = True Then Throw New Exception("پرسنل با مشخصات مورد نظر قبلا ثبت شده است")
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Select top 1 PId from R2Primary.dbo.TblPersonelInf with (tablockx) Order by PId Desc "
                    Dim PId As Int64 = CmdSql.ExecuteScalar + 1
                    CmdSql.CommandText = "Insert Into R2Primary.dbo.TblPersonelInf(PId,PIdOther,PNameFamily,PFatherName,NationalCode,Tel,Address,Active,DateTimeMilladiSabt,DateTimeMilladiEdit,DateShamsiSabt,DateShamsiEdit,UserIdSabt,UserIdEdit,FingerPrint,FingerPrint2,FingerPrint3,FingerPrint4) Values(" & PId & ",'" & YourNSS.PIdOther & "','" & YourNSS.PNameFamily & "','" & YourNSS.PFatherName & "','" & YourNSS.NationalCode & "','" & YourNSS.Tel & "','" & YourNSS.Address & "'," & IIf(YourNSS.Active, 1, 0) & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "'," & YourUserNSS.UserId & "," & YourUserNSS.UserId & ",0,0,0,0)"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                    Return PId
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub UpdatePersonnel(YourNSS As R2CoreStandardPersonnelStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure)
                Dim CmdSql As SqlCommand = New SqlCommand
                CmdSql.Connection = (New DatabaseManagement.R2PrimarySqlConnection).GetConnection()
                Try
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Update R2Primary.dbo.TblPersonelInf Set PIdOther='" & YourNSS.PIdOther & "',PNameFamily='" & YourNSS.PNameFamily & "',PFatherName='" & YourNSS.PFatherName & "',NationalCode='" & YourNSS.NationalCode & "',Tel='" & YourNSS.Tel & "',Address='" & YourNSS.Address & "',Active=" & IIf(YourNSS.Active, 1, 0) & ",DateTimeMilladiEdit='" & _DateTime.GetCurrentDateTimeMilladiFormated() & "',DateShamsiEdit='" & _DateTime.GetCurrentDateShamsiFull() & "',UserIdEdit=" & YourUserNSS.UserId & " Where PId=" & YourNSS.PId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function GetPersonnelImage(YourNSSPersonnel As R2CoreStandardPersonnelStructure, YourNSSUser As R2CoreStandardSoftwareUserStructure) As R2CoreImage
                Try
                    Return New R2CoreImage(_R2PrimaryFSWS.WebMethodGetFile(R2CoreRawGroups.PersonnelImages, YourNSSPersonnel.PId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 3), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword)))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub SavePersonnelImage(YourNSSPersonnel As R2CoreStandardPersonnelStructure, YourPersonnelImage As R2CoreImage, YourNSSUser As R2CoreStandardSoftwareUserStructure)
                Try
                    _R2PrimaryFSWS.WebMethodSaveFile(R2CoreRawGroups.PersonnelImages, YourNSSPersonnel.PId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 3), YourPersonnelImage.GetImageByte(), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function CreateListOfPersonnel(YourActiveStatus As Boolean) As List(Of R2CoreStandardPersonnelStructure)
                Try
                    Dim DS As DataSet
                    If YourActiveStatus = True Then R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblPersonelInf Where Active=1 Order By PNameFamily", 1, DS)
                    If YourActiveStatus = False Then R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblPersonelInf Order By PNameFamily", 1, DS)
                    Dim ListOfNSS As List(Of R2CoreStandardPersonnelStructure) = New List(Of R2CoreStandardPersonnelStructure)()
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        ListOfNSS.Add(New R2CoreStandardPersonnelStructure(DS.Tables(0).Rows(Loopx).Item("PId"), DS.Tables(0).Rows(Loopx).Item("PIdOther"), DS.Tables(0).Rows(Loopx).Item("PNameFamily"), DS.Tables(0).Rows(Loopx).Item("PFatherName"), DS.Tables(0).Rows(Loopx).Item("NationalCode"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Tel"), DS.Tables(0).Rows(Loopx).Item("Address"), DS.Tables(0).Rows(Loopx).Item("UserIdSabt"), DS.Tables(0).Rows(Loopx).Item("UserIdEdit"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladiSabt"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladiEdit"), DS.Tables(0).Rows(Loopx).Item("DateShamsiSabt"), DS.Tables(0).Rows(Loopx).Item("DateShamsiEdit"), DS.Tables(0).Rows(Loopx).Item("FingerPrint"), DS.Tables(0).Rows(Loopx).Item("FingerPrint2"), DS.Tables(0).Rows(Loopx).Item("FingerPrint3"), DS.Tables(0).Rows(Loopx).Item("FingerPrint4")))
                    Next
                    Return ListOfNSS
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub SavePersonnelFingerPrints(YourNSSPersonnel As R2CoreStandardPersonnelStructure, YourWFP As R2CorePersonnelWhichFingerPrint, YourTemplate As Byte())
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
                Try
                    Dim P As SqlClient.SqlParameter = New SqlClient.SqlParameter("@FPTemplate", SqlDbType.VarBinary)
                    P.Value = YourTemplate
                    CmdSql.Parameters.Add(P)
                    CmdSql.Connection.Open()
                    If YourWFP = R2CorePersonnelWhichFingerPrint.FP1 Then
                        CmdSql.CommandText = "Update R2Primary.dbo.TblPersonelInf Set FingerPrint=@FPTemplate where PId=" & YourNSSPersonnel.PId & ""
                    ElseIf YourWFP = R2CorePersonnelWhichFingerPrint.FP2 Then
                        CmdSql.CommandText = "Update R2Primary.dbo.TblPersonelInf Set FingerPrint2=@FPTemplate where PId=" & YourNSSPersonnel.PId & ""
                    ElseIf YourWFP = R2CorePersonnelWhichFingerPrint.FP3 Then
                        CmdSql.CommandText = "Update R2Primary.dbo.TblPersonelInf Set FingerPrint3=@FPTemplate where PId=" & YourNSSPersonnel.PId & ""
                    ElseIf YourWFP = R2CorePersonnelWhichFingerPrint.FP4 Then
                        CmdSql.CommandText = "Update R2Primary.dbo.TblPersonelInf Set FingerPrint4=@FPTemplate where PId=" & YourNSSPersonnel.PId & ""
                    End If
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function GetNumberOfEnterExitAtThisDay(ByVal YourNSSPersonnel As R2CoreStandardPersonnelStructure) As Int64
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "SELECT COUNT(*) AS CCount FROM R2Primary.dbo.TblPersonelAttendance WHERE (PId=" & YourNSSPersonnel.PId & ")  AND (DateShamsi ='" & _DateTime.GetCurrentDateShamsiFull & "')", 1, DS)
                    Return DS.Tables(0).Rows(0).Item("ccount")
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalNumberOfPersonnelRegistered(YourActiveStatus As Boolean) As Int64
                Try
                    Dim DS As DataSet
                    If YourActiveStatus = True Then R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) as CCount from R2Primary.dbo.TblPersonelInf Where Active=1", 1, DS)
                    If YourActiveStatus = False Then R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) as CCount from R2Primary.dbo.TblPersonelInf", 1, DS)
                    Return DS.Tables(0).Rows(0).Item("CCount")
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IdentificationPersonnel(YourTemplate As Byte(), YourSecurityLevel As Decimal, YourTemplateType As Int64) As R2CoreStandardPersonnelStructure
                Try
                    'ایجاد آرایه کلیه اثر انگشت های پرسنل
                    Dim LstNSSPersonnel As List(Of R2CoreStandardPersonnelStructure) = CreateListOfPersonnel(True)
                    Dim TemplateArray As Byte()() = New Byte(LstNSSPersonnel.Count * 4)() {}
                    Dim TemplateArraySize As Integer() = New Integer(LstNSSPersonnel.Count * 4) {}
                    Dim TemplateNumber As Integer = 0
                    Dim CCounter As Integer = 0
                    For Loopx As Int32 = 0 To LstNSSPersonnel.Count - 1
                        TemplateArray(CCounter) = LstNSSPersonnel(Loopx).FingerPrint1
                        TemplateArraySize(CCounter) = TemplateArray(CCounter).Length
                        TemplateNumber += 1
                        TemplateArray(CCounter + 1) = LstNSSPersonnel(Loopx).FingerPrint2
                        TemplateArraySize(CCounter + 1) = TemplateArray(CCounter + 1).Length
                        TemplateNumber += 1
                        TemplateArray(CCounter + 2) = LstNSSPersonnel(Loopx).FingerPrint3
                        TemplateArraySize(CCounter + 2) = TemplateArray(CCounter + 2).Length
                        TemplateNumber += 1
                        TemplateArray(CCounter + 3) = LstNSSPersonnel(Loopx).FingerPrint4
                        TemplateArraySize(CCounter + 3) = TemplateArray(CCounter + 3).Length
                        TemplateNumber += 1
                        CCounter += 4
                    Next
                    'تشخیص هویت
                    Dim myIndex4 As Integer
                    If R2Core.FingerPrintsManagement.SupremaSystem.R2CoreFingerPrintMClassSupremaManagement.VerificationOneTemplateByArray(YourTemplate, YourTemplate.Length, TemplateArray, TemplateArraySize, TemplateNumber, YourSecurityLevel, YourTemplateType, True, myIndex4) = True Then
                        Dim myIndex As Integer = Int(myIndex4 / 4)
                        Return LstNSSPersonnel(myIndex)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub InsertPersonnelPrecent(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
                Try
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Insert Into R2Primary.dbo.TblPersonelAttendance(PId,DateTimeMilladi,DateShamsi,Time,Flag) values(" & YourNSSPersonnel.PId & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "',1)"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub InsertPersonnelPrecentAtThisDateTime(YourNSSPersonnel As R2CoreStandardPersonnelStructure, YourDateTime As R2StandardDateAndTimeStructure)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
                Try
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Insert Into R2Primary.dbo.TblPersonelAttendance(PId,DateTimeMilladi,DateShamsi,Time,Flag) values(" & YourNSSPersonnel.PId & ",'" & YourDateTime.DateTimeMilladi.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & YourDateTime.DateShamsiFull & "','" & YourDateTime.Time & "',1)"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function GetPersonnelEnterExit(YourNSSPersonnel As R2CoreStandardPersonnelStructure) As List(Of String)
                Try
                    Dim Lst As New List(Of String)
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select DateShamsi,Time from R2Primary.dbo.TblPersonelAttendance Where PId=" & YourNSSPersonnel.PId & "order by DateTimeMilladi Desc", 1, DS)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(DS.Tables(0).Rows(Loopx).Item("DateShamsi").trim + "    " + DS.Tables(0).Rows(Loopx).Item("Time").trim)
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub ReportingInformationProviderPersonnelEnterExitReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection
                Try
                    Dim _Concat1 As String = YourDateTime1.GetConcatString
                    Dim _Concat2 As String = YourDateTime2.GetConcatString
                    Dim DS As New DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select PA.PId,PA.DateShamsi,PA.Time,P.PNameFamily from R2Primary.dbo.TblPersonelAttendance as PA inner join R2Primary.dbo.TblPersonelInf as P on PA.PId=P.PId where (Replace(PA.DateShamsi,'/','')+Replace(PA.Time,':','')>='" & _Concat1 & "') and (Replace(PA.DateShamsi,'/','')+Replace(PA.Time,':','')<='" & _Concat2 & "')", 1, DS)
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblPersonnelEnterExit" : CmdSql.ExecuteNonQuery()
                    For loopx As Int16 = 0 To DS.Tables(0).Rows.Count - 1
                        Dim PId As Int64 = DS.Tables(0).Rows(loopx).Item("PId")
                        Dim PNameFamily As String = DS.Tables(0).Rows(loopx).Item("PNameFamily")
                        Dim DateShamsi As String = DS.Tables(0).Rows(loopx).Item("DateShamsi")
                        Dim Time As String = DS.Tables(0).Rows(loopx).Item("Time")
                        CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblPersonnelEnterExit(PId,PNameFamily,DateShamsi,Time) values(" & PId & ",'" & PNameFamily & "','" & DateShamsi & "','" & Time & "')"
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

        End Class

        Public Class R2CorePersonnelNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "پرسنل با کد پرسنلی مورد نظر ثبت نشده است"
                End Get
            End Property
        End Class

        Public Class R2CorePersonnelImageCaptureException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "تصویر پرسنل آماده نیست"
                End Get
            End Property
        End Class

        Public Class R2CorePersonnelImageNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "تصویر پرسنل وجود ندارد"
                End Get
            End Property
        End Class



    End Namespace

End Namespace

Namespace FingerPrintsManagement

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
                            If YourScore >= R2CoreMClassConfigurationOfComputersManagement.GetConfigByte(R2CoreConfigurations.Dermalog, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 2) Then
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


End Namespace

Namespace SoftwareUserWorkingGroupsManagement

    Public MustInherit Class SoftwareUserWorkingGroups
        Public Shared ReadOnly None As Int64 = 0
        Public Shared ReadOnly General As Int64 = 1
    End Class
End Namespace




