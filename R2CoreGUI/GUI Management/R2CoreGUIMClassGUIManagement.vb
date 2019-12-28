
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement

Public NotInheritable Class R2CoreGUIMClassGUIManagement

    Public Shared WithEvents FrmMainMenu As New FrmcMainMenu()
    Public Shared GrdEnterLeaveCellFlag As Boolean

    Public Shared Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try
            If objectName.LastIndexOf(".", StringComparison.Ordinal) = -1 Then
                objectName = Assembly.GetEntryAssembly.GetName.Name & "." & objectName
            End If
            obj = [Assembly].GetEntryAssembly.CreateInstance(objectName)
        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj
    End Function






End Class
