
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.TransportTarrifsParameters
Imports R2CoreTransportationAndLoadNotification.TransportTarrifsParameters.Exceptions

Public Class UCTransportTarrifsParameters
    Inherits UCGeneralExtended

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UcRefreshInformation()
        Try
            PnlParams.Controls.Clear()
            LblLoaderType.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
        End Try
    End Sub

    Public Sub UcViewInformation(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
        Try
            PnlParams.Controls.Clear()
            Dim InstanceAnnouncementHalls = New R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager
            LblLoaderType.Text = InstanceAnnouncementHalls.GetNSSAnnouncementHallSubGroup(YourNSS.AHSGId).AHSGTitle
            Dim InstanceTransportTarrifsParameters = New R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsParametersManager
            Dim Lst = InstanceTransportTarrifsParameters.GetListofTransportTarrifsParams(YourNSS.TPTParams)
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim ChkParam As System.Windows.Forms.CheckBox = New System.Windows.Forms.CheckBox
                ChkParam.Text = Lst(Loopx).TPTPDId.ToString + " # " + Lst(Loopx).TPTPTitle + " - " + Lst(Loopx).Mblgh.ToString()
                ChkParam.Checked = Lst(Loopx).Checked
                ChkParam.Dock = Windows.Forms.DockStyle.Top
                'ChkParam.Size = New Size(TextRenderer.MeasureText(ChkParam.Text, ChkParam.Font).Width + 20, ChkParam.Height)
                PnlParams.Controls.Add(ChkParam)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
        End Try
    End Sub

    Public Sub UcViewInformation(YourNSS As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
        Try
            LblLoaderType.Text = YourNSS.AHSGTitle.Trim
            PnlParams.Controls.Clear()
            Dim InstanceTransportTarrifsParameters = New R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsParametersManager
            Dim Lst = InstanceTransportTarrifsParameters.GetListofTransportTarrifsParams(YourNSS)
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim ChkParam As System.Windows.Forms.CheckBox = New System.Windows.Forms.CheckBox
                ChkParam.Text = Lst(Loopx).TPTPDId.ToString + " # " + Lst(Loopx).TPTPTitle + " - " + Lst(Loopx).Mblgh.ToString()
                ChkParam.Checked = Lst(Loopx).Checked
                ChkParam.Dock = Windows.Forms.DockStyle.Top
                'ChkParam.Size = New Size(TextRenderer.MeasureText(ChkParam.Text, ChkParam.Font).Width + 20, ChkParam.Height)
                PnlParams.Controls.Add(ChkParam)
            Next
        Catch ex As TransportPriceTarrifParameterDetailsforAHSGNotFoundException
            'No Param to view
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
        End Try
    End Sub

    Public Function UCGetTPTParams() As String
        Dim TPTParamsDetails = String.Empty
        For Each Li As System.Windows.Forms.CheckBox In PnlParams.Controls
            TPTParamsDetails += Li.Text.Split("#")(0).Trim + ":" + IIf(Li.Checked, "1", "0") + ";"
        Next

        If TPTParamsDetails = String.Empty Then Return String.Empty
        Return TPTParamsDetails.Substring(0, TPTParamsDetails.Length - 1)
    End Function

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
