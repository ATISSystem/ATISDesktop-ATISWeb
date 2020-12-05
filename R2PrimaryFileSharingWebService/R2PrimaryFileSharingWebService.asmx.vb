
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.FileShareRawGroupsManagement
Imports R2Core.SecurityAlgorithmsManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2Core.UserManagement
Imports R2Core.UserManagement.Exceptions

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class R2PrimaryFileSharingWebService
    Inherits System.Web.Services.WebService

    Private Shared _ExchangeKeyManager As New ExchangeKeyManager


    <WebMethod()>
    Public Function WebMethodLogin(YourUserShenaseh As String, YourUserPassword As String) As Int64
        Try
            Return _ExchangeKeyManager.Login(YourUserShenaseh, YourUserPassword)
        Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodSaveFile(YourRawGroupId As Int64, YourFileName As String, YourFile As Byte(), YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName), YourFile)
            RGFileHolder.SaveFile()
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodGetFile(YourRawGroupId As Int64, YourFileName As String, YourExchangeKey As Int64) As Byte()
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName))
            Dim FileByteArray As Byte() = Nothing
            RGFileHolder.GetFile(FileByteArray)
            Return FileByteArray
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodIOFileExist(YourRawGroupId As Int64, YourFileName As String, YourExchangeKey As Int64) As Boolean
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName))
            Return RGFileHolder.ExistIOFile()
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodDeleteFile(YourRawGroupId As Int64, YourFileName As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName))
            RGFileHolder.DeleteFile()
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


End Class