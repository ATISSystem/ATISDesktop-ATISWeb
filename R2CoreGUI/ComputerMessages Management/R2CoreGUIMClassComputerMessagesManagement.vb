
Imports System.Reflection

Imports R2Core.ComputerMessagesManagement


Public NotInheritable Class R2CoreGUIMClassComputerMessagesManagement

    Public Shared Function CreateUCComputerMessage(YourNSS As R2StandardComputerMessageStructure) As UCComputerMessage
        Try
            Dim NSS As R2StandardComputerMessageTypeStructure = R2CoreMClassComputerMessagesManagement.GetNSSComputerMessageType(YourNSS.CMType)
            Dim Assembly_ As Assembly = Assembly.LoadFrom(NSS.AssemblyDll)
            Dim ObjectInstanceType = Assembly_.GetType(NSS.AssemblyPath)
            Dim objUC As UCComputerMessage= CType(Activator.CreateInstance(ObjectInstanceType), UCComputerMessage)
            objUC.UCViewNSS(YourNSS)
            Return objUC
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function







End Class
