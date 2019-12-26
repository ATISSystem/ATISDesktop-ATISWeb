
Imports System.Reflection

Public Class TWSMClassAuthenticationManagement

    Public Shared Function AuthenticationId() As String
        Try
            Return "Biinfo878"
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

End Class
