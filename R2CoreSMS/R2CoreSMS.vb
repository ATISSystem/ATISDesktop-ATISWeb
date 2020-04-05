

Imports System.Configuration
Imports System.Reflection

Imports R2Core
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2CoreSMS.Exceptions
Imports R2CoreSMS.SMSSendAndRecieved
Imports R2CoreSMS.ConfigurationManagement


Namespace SMSSendAndRecieved

    Public Enum SmsSendReciveType
        None = 0
        ForSend = 1
        Recived = 2
    End Enum

    Public Class R2CoreSMSStandardSmsStructure

        Public Sub New()
            MyBase.New()
            SmsId = Int64.MinValue
            MobileNumber = String.Empty
            Message = String.Empty
            EndHours = Int16.MinValue
            DateTimeMilladi = Now.Date
            Active = Boolean.FalseString
            DateShamsi = String.Empty
            Time = String.Empty
        End Sub

        Public Sub New(ByVal YourSmsId As Int64, ByVal YourMobileNumber As String, ByVal YourMessage As String, ByVal YourEndHours As Int16, ByVal YourDateTimeMilladi As DateTime, ByVal YourActive As Boolean, ByVal YourDateShamsi As String, ByVal YourTime As String)
            SmsId = YourSmsId
            MobileNumber = YourMobileNumber
            Message = YourMessage
            EndHours = YourEndHours
            DateTimeMilladi = YourDateTimeMilladi
            Active = YourActive
            DateShamsi = YourDateShamsi
            Time = YourTime
        End Sub

        Public Property SmsId As Int64
        Public Property MobileNumber As String
        Public Property Message As String
        Public Property EndHours As Int16
        Public Property DateTimeMilladi As DateTime
        Public Property Active As Boolean
        Public Property DateShamsi As String
        Public Property Time As String
    End Class

    Public Class R2CoreSMSSendRecive

        Private _DateTime As New R2DateTime

        Public Sub New()
            MyBase.New()
            Try
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        Public Sub SendSms(ByVal YourNSS As R2CoreSMSStandardSmsStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                If YourNSS.MobileNumber.Trim.Length <> 11 Then Throw New MobileNumberInvallidException
                If YourNSS.Message.Trim = "" Then Throw New SmsMessageEmptyException
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblSMSWareHouse(MobileNumber,Message,EndHours,DateTimeMilladi,Active,DateShamsi,SmsType) values('" & YourNSS.MobileNumber & "','" & YourNSS.Message & "'," & YourNSS.EndHours & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "',1,'" & _DateTime.GetCurrentDateShamsiFull & "'," & SmsSendReciveType.ForSend & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
            End Try
        End Sub

        'Public Function RecivedSms() As R2StandardSmsRecivedStructure()
        '    Try
        '        DsSmsRecived.Tables.Clear()
        '        DaSmsRecived.Fill(DsSmsRecived)
        '        myNumberOfRecivedSms = DsSmsRecived.Tables(0).Rows.Count
        '        ReDim SmsArray(myNumberOfRecivedSms - 1)
        '        For loopx As Int32 = 0 To myNumberOfRecivedSms - 1
        '            SmsArray(loopx) = New R2StandardSmsRecivedStructure(DsSmsRecived.Tables(0).Rows(loopx).Item("SMSId"), DsSmsRecived.Tables(0).Rows(loopx).Item("Mobile").trim, DsSmsRecived.Tables(0).Rows(loopx).Item("Message").trim, DsSmsRecived.Tables(0).Rows(loopx).Item("EndHours"), DsSmsRecived.Tables(0).Rows(loopx).Item("SabtDateTimeMilladi"), DsSmsRecived.Tables(0).Rows(loopx).Item("Active"), DsSmsRecived.Tables(0).Rows(loopx).Item("SabtDateShamsi"), DsSmsRecived.Tables(0).Rows(loopx).Item("SabtTime"))
        '        Next
        '        Return SmsArray
        '    Catch ex As Exception
        '        Throw New Exception("Sms.RecivedSms()." + ex.Message.ToString)
        '    End Try
        'End Function

        'Public Sub RecivedSmsHandled(ByVal SmsId As Int64)
        '    Dim CmdSql As New SqlClient.SqlCommand
        '    CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
        '    Try
        '        CmdSqlSmsSystem.Connection.Open()
        '        CmdSqlSmsSystem.CommandText = "update TblSmsWareHouse Set Active=0 where SmsId=" & SmsId & ""
        '        CmdSqlSmsSystem.ExecuteNonQuery()
        '        CmdSqlSmsSystem.Connection.Close()
        '    Catch ex As Exception
        '        If CmdSqlSmsSystem.Connection.State <> ConnectionState.Closed Then CmdSqlSmsSystem.Connection.Close()
        '        Throw New Exception("SmsCore.Sms.RecivedSmsHandled()." + ex.Message.ToString)
        '    End Try
        'End Sub




    End Class

    Public MustInherit Class R2CoreSMSMClassSMSDomainManagement

        Private Shared _SepahanSMS As New net.sepahansms.smsSendWebServiceforPHP()
        Private Shared _DateTime As New R2DateTime

        Public Shared Sub SMSDomainSendRecieved()
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                'ارسالی            
                If R2CoreMClassConfigurationManagement.GetConfigBoolean(R2CoreConfigurations.SmsSystemSetting, 0) = True Then
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimarySMSSystem.dbo.TblSmsWareHouse where Active=1 and SmsType=" & SmsSendReciveType.ForSend & "", 0, DS)
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    For Loopx As Int32 = 0 To DS.Tables(0).Rows.Count - 1
                        Dim mySmsId As String = DS.Tables(0).Rows(Loopx).Item("SmsId")
                        If DateDiff(DateInterval.Hour, _DateTime.GetCurrentDateTimeMilladi, Convert.ToDateTime(DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"))) <= DS.Tables(0).Rows(Loopx).Item("EndHours") Then
                            Dim myMessage As String = DS.Tables(0).Rows(Loopx).Item("message").trim
                            Dim myMobilenumber As String = DS.Tables(0).Rows(Loopx).Item("mobilenumber").trim
                            Dim SmsId() As Long = _SepahanSMS.SendSms("Biinfo878", "3800000", "sepahansms", New String() {myMessage}, New String() {myMobilenumber}, "30006403868611",
                                                     net.sepahansms.SendType.DynamicText, net.sepahansms.SmsMode.SaveInPhone)
                            If SmsId(0) > 0 Then
                                CmdSql.CommandText = "Update  R2PrimarySMSSystem.dbo.TblSmsWareHouse Set Active=0 where SmsId=" & mySmsId & ""
                                CmdSql.ExecuteNonQuery()
                            End If
                        Else
                            CmdSql.CommandText = "Update  R2PrimarySMSSystem.dbo.TblSmsWareHouse Set Active=0 where SmsId=" & mySmsId & ""
                            CmdSql.ExecuteNonQuery()
                        End If
                    Next
                Else
                    Throw New SmsSystemIsDisabledException
                End If


                ''دریافتی
                'ReDim ReceiveSmsOneLine(10)
                'ReceiveSmsOneLine = SepahanSMS.GetReceiveSMSWithNumber(com.sepahansms.www.ReceiveType.UnRead, "30006016635245", Nothing, "", "")
                'If ReceiveSmsOneLine.Length = 0 Then
                '    EventLog.WriteEntry("SmsServiceSource", "ReceiveSmsOneLine.Length = 0", EventLogEntryType.Information)
                '    Exit Try
                'End If
                'CmdSqlSmsSystem.CommandText = "select top 1 smsid from TblSmsWareHouse order by smsid desc"
                'Dim mySmsIdStart As Int32 = CmdSqlSmsSystem.ExecuteScalar + 1
                'For loopx As Int32 = 0 To ReceiveSmsOneLine.Length - 1
                '    Dim SmsText As String = ReceiveSmsOneLine(loopx).SmsText
                '    If SmsText.Trim <> "" Then
                '        Dim myMobile As String = ReceiveSmsOneLine(loopx).FromNumber
                '        Dim myDate As String = ReceiveSmsOneLine(loopx).Date
                '        Dim myMessage As String = ReceiveSmsOneLine(loopx).SmsText
                '        If ((myMessage = "Biinfo878*03*0") Or (myMessage = "Biinfo878*03*1")) And (myMobile = SmsSystemConfiguration.GetSmsSystemGeneralNumber) Then
                '            If myMessage = "Biinfo878*03*0" Then mySendSmsStatus = False
                '            If myMessage = "Biinfo878*03*1" Then mySendSmsStatus = True
                '        Else
                '            CmdSqlSmsSystem.CommandText = "insert into TblSmsWareHouse(SmsId,Mobile,Message,EndHours,SabtDateTimeMilladi,Active,SabtDateShamsi,SabtTime,SmsType) values(" & mySmsIdStart & ",'" & myMobile & "','" & myMessage & "',0,'" & myR2DateTime.GetCurrentDateTimeMilladi.ToString("yyyy-MM-dd HH:mm:ss") & "',1,'" & myDate & "','" & myR2DateTime.GetCurrentTime & "'," & SmsSendReciveType.Recived & ")"
                '            CmdSqlSmsSystem.ExecuteNonQuery()
                '            mySmsIdStart += 1
                '        End If
                '    End If
                'Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As SmsSystemIsDisabledException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class


End Namespace

Namespace Exceptions

    Public Class MobileNumberInvallidException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "شماره موبایل نادرست است"
            End Get
        End Property
    End Class

    Public Class SmsSystemIsDisabledException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "سیستم اس ام اس از طریق جدول پیکربندی غیر فعال است"
            End Get
        End Property
    End Class


    Public Class SmsMessageEmptyException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "در پیام ارسالی متنی وجود ندارد"
            End Get
        End Property
    End Class



End Namespace

Namespace ConfigurationManagement
    Public MustInherit Class R2CoreSMSSystemConfigurations
        Inherits R2Core.ConfigurationManagement.R2CoreConfigurations


    End Class

End Namespace


