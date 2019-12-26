
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports R2Core.BaseStandardClass

Imports R2Core.DateAndTimeManagement
Imports R2Core.FileShareRawGroupsManagement
Imports R2Core.UserManagement

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class R2PrimaryFileSharingWebService
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Sub WebMethodSaveFile(YourRawGroupId As Int64, YourFileName As String, YourFile As Byte())
        Try
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName), YourFile)
            RGFileHolder.SaveFile()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodGetFile(YourRawGroupId As Int64, YourFileName As String) As Byte()
        Try
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName))
            Dim FileByteArray As Byte() = Nothing
            RGFileHolder.GetFile(FileByteArray)
            Return FileByteArray
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodIOFileExist(YourRawGroupId As Int64, YourFileName As String) As Boolean
        Try
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName))
            Return RGFileHolder.ExistIOFile()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodDeleteFile(YourRawGroupId As Int64, YourFileName As String)
        Try
            Dim RGFileHolder = New R2CoreRawGroupFileHolder(YourRawGroupId, New R2CoreFile(YourFileName))
            RGFileHolder.DeleteFile()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


End Class