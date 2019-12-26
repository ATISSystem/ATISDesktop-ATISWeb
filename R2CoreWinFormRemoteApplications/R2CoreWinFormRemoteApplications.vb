

Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.Win32

Imports R2CoreWinFormRemoteApplications.ConfigurationManagement
Imports R2CoreWinFormRemoteApplications.ReportsManagement


NAMESPACE BaseStandardClasses

    Public Structure DataStruct
        Dim Data1 As String
        Dim Data2 As String
        Dim Data3 As String
        Dim Data4 As String
        Dim Data5 As String
    End Structure

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


End Namespace

Namespace R2CoreWinFormRemoteApplicationsEnums

    Public Enum OnlyDigit
        None = 0
        OnlyDigit = 1
        OnlyChar = 2
        Any = 3
    End Enum
    Public Enum R2CoreWinFormRemoteApplicationsColor
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

End Namespace

Namespace ConfigurationManagement

    Public NotInheritable Class R2CoreWinFormRemoteApplicationsMClassConfigurationManagement
        Public Shared Function GetAppConfigValue(ByVal YourKeyName As String, ByVal YourValueName As String) As String
            Return Registry.GetValue("HKEY_CURRENT_USER\RemoteApplications\" + YourKeyName, YourValueName, "")
        End Function

        Public Shared Function GetFrmcDialogMessageConfigValue(YourIndex As Int64) As Object
            Try
                Return Split(GetAppConfigValue("FrmcDialogMessage", "FrmcDialogMessage"), ";")(YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetDateTimeConfigValue(YourIndex As Int64) As Object
            Try
                Return Split(GetAppConfigValue("DateTime", "DateTime"), ";")(YourIndex)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class
End Namespace

Namespace DateTimeManagement

    Public Class R2CoreWinFormRemoteApplicationsStandardDateAndTimeStructure
        Private myDateTimeMilladi As DateTime
        Private myDateShamsiFull As String
        Private myTime As String

        Public Sub New()
            MyBase.New()
            myDateTimeMilladi = Date.Now : myDateShamsiFull = "" : myTime = ""
        End Sub

        Public Sub New(ByVal DateTimeMilladii As DateTime, ByVal DateShamsiFulll As String, ByVal Timee As String)
            myDateTimeMilladi = DateTimeMilladii
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
        Public ReadOnly Property GetConcatString() As String
            Get
                Return DateShamsiFull.Replace("/", "") + Time.Replace(":", "")
            End Get
        End Property


    End Class

    Public Class R2DateTime
        Private Shared R2PWS As R2PrimaryWS.R2PrimaryWebService = New R2PrimaryWS.R2PrimaryWebService()

        'Dim mycurrenttime As String = Trim(Mid(DateAndTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 8))
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
        Public Function GetMilladiDateTimeFromDateShamsiFull(ByVal YourShamsiDateFull As String, YourTime As String) As Date
            Try
                Return PC.ToDateTime(Mid(YourShamsiDateFull, 1, 4), Mid(YourShamsiDateFull, 6, 2), Mid(YourShamsiDateFull, 9, 2), Mid(YourTime, 1, 2), Mid(YourTime, 4, 2), Mid(YourTime, 7, 2), 0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function
        Private Function GetSqlServerCurrentDate() As DateTime
            Try
                Return R2PWS.WebMethodGetCurrentDateTimeMilladi()
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
        Public Function GetCurrentTime() As String
            Try
                Return Trim(Mid(GetSqlServerCurrentDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), 12, 8))
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
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetDateTimeConfigValue(0))) Then Return False
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
                    If Not ((Val(myrooz) >= 1) And (Val(myrooz) <= R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetDateTimeConfigValue(0))) Then Return False
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
                If (CInt(mahcode) - 9 = 12) Then Return R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetDateTimeConfigValue(0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function


    End Class

End Namespace

Namespace PublicProc

    Public NotInheritable Class R2CoreWinFormRemoteApplicationsMclassPublicProcManagement
        Public Shared Function GetInvertColor(YourColor As Color) As Color
            Return Color.FromArgb(YourColor.ToArgb() Xor &HFFFFFF)
        End Function

        'روتين تغيير زبان صفحه کليد با استفاده از API
        Public Shared Function Setkeyboardlayout(ByVal YourInputLanguageType As R2CoreWinFormRemoteApplicationsEnums.InputLanguageType) As Boolean
            Try
                Return SetKeybLayout(YourInputLanguageType)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Public Shared Function Setkeyboardlayout(ByVal layout As String) As Boolean
            Try
                Return SetKeybLayout(IIf(layout = "English", R2CoreWinFormRemoteApplicationsEnums.InputLanguageType.English, R2CoreWinFormRemoteApplicationsEnums.InputLanguageType.Persian))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function

        Private Declare Function LoadKeyboardLayout Lib "user32" Alias "LoadKeyboardLayoutA" (ByVal pwszKLID As String, ByVal flags As Integer) As Integer
        Private Shared Function SetKeybLayout(YourInputLanguageType As R2CoreWinFormRemoteApplicationsEnums.InputLanguageType) As Boolean
            Try
                Dim mypwszKLID As String = IIf(YourInputLanguageType = R2CoreWinFormRemoteApplicationsEnums.InputLanguageType.English, "00000409", "00000429")
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

        Private Shared Function R2MakeCamaYourDigit(ByVal xdig As UInt64) As String
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

        Public Shared Function ParseSignDigitToTashString(ByVal YourDig As Int64) As String
            Try
                If YourDig < 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "  بدهكار  "
                If YourDig > 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "  بستانكار  "
                If YourDig = 0 Then Return R2MakeCamaYourDigit(Math.Abs(YourDig)) + "  تسويه  "
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Function


    End Class

End Namespace

Namespace InformationManagement
    Public NotInheritable Class R2CoreWinFormRemoteApplicationsMClassInformationManagement
        Public Shared Sub PrintReport(YourReportFullName As String)
            Try
                Dim FrmPrint As FrmcPrint = New FrmcPrint()
                FrmPrint.Show()
                FrmPrint.ViewChopRdl(R2CoreWinFormRemoteApplicationsMClassReportsManagement.ReportServerPath, YourReportFullName, R2CoreWinFormRemoteApplicationsMClassReportsManagement.ReportServerUrl, R2CoreWinFormRemoteApplicationsMClassReportsManagement.UserName, R2CoreWinFormRemoteApplicationsMClassReportsManagement.UserPassword)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class
End Namespace

Namespace ReportsManagement

    Public NotInheritable Class R2CoreWinFormRemoteApplicationsMClassReportsManagement
        Public Shared ReportServerPath As String = "/PayanehReports/"
        Public Shared ReportServerUrl As String = "http://LocalHost:1352/ReportServer"
        Public Shared UserName As String = "admin"
        Public Shared UserPassword As String = "Biinfo878aB"
    End Class

End Namespace

namespace ExceptionManagement

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
        Public Overrides ReadOnly Property Message As String
            Get
                Return "اطلاعات وارد شده صحیح نیست"
            End Get
        End Property
    End Class



End Namespace