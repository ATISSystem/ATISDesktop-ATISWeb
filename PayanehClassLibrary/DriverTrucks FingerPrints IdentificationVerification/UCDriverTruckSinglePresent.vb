

Imports System.Drawing
Imports System.Reflection

Imports R2CoreGUI

Public Class UCDriverTruckSinglePresent
    Inherits UCGeneral


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal YourLPString As String, ByVal YourPersonFullName As String, ByVal YourShamsiDate As String, ByVal YourDateTimeMilladi As Date, ByVal YourPresentType As PayanehClassLibrary.DriverTruckPresentManagement.PresentType)
        MyBase.New()
        InitializeComponent()
        Try
            If YourPresentType = PayanehClassLibrary.DriverTruckPresentManagement.PresentType.Salon Then PnlMain.BackColor = Color.Yellow
            If YourPresentType = PayanehClassLibrary.DriverTruckPresentManagement.PresentType.EnterExit Then PnlMain.BackColor = Color.Red
            UcLabelLPString.UCValue = YourLPString
            UcLabelPersonFullName.UCValue = YourPersonFullName
            UcLabelDateShamsi.UCValue = YourShamsiDate
            UcLabelTime.UCValue = YourDateTimeMilladi.Hour.ToString + ":" + YourDateTimeMilladi.Minute.ToString + ":" + YourDateTimeMilladi.Second.ToString
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

End Class
