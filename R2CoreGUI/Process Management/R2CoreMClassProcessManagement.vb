
Imports System.Reflection

Imports R2Core.AuthenticationManagement
Imports R2Core.ComputersManagement
Imports R2Core.ProcessesManagement
Imports R2Core.UserManagement


Namespace ProcessesManagement

    Public Class R2CoreGUIMClassProcessesManagement

        Public Shared Function OpenProccess(YourNSSProcess As R2StandardProcessStructure,YourUserNSS As R2CoreStandardUserStructure) As Form
            Try
                If R2MClassAuthenticationManagement.UserHaveProcessPermission(YourUserNSS, YourNSSProcess) = False Then
                    Throw New AuthenticationUserHasProcessPermissionException
                ElseIf R2MClassAuthenticationManagement.ComputerHaveProcessPermission(R2CoreMClassComputersManagement.GetNSSCurrentComputer(), YourNSSProcess) = False Then
                    Throw New AuthenticationComputerHasProcessPermissionException
                Else
                    Dim PathDll As String = Application.StartupPath + "\" + YourNSSProcess.PAssemblyDll
                    Dim Assembly_ As Assembly = Assembly.LoadFrom(PathDll)
                    Dim ProjAndForm As String = YourNSSProcess.PAssemblyPath.Trim()
                    Dim FormInstanceType = Assembly_.GetType(ProjAndForm)
                    Dim objForm = CType(Activator.CreateInstance(FormInstanceType), Form)
                    R2CoreGUIMClassGUIManagement.FrmMainMenu.UcCollectionofUCActiveForm.UCAddActiveForm(YourNSSProcess.PDisplayTitle, objForm)
                    Return objForm
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class


End Namespace


