
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement

Public NotInheritable Class R2CoreGUIMClassInformationManagement

    public Shared sub PrintReport(YourReportId As Int64)
        Try
            Dim FrmPrint As FrmcPrint=new FrmcPrint()
            FrmPrint.Show
            FrmPrint.ViewChopRdl(YourReportId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End sub




End Class
