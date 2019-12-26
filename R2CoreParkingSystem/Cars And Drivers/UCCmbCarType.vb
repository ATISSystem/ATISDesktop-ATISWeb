

Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2Core.DatabaseManagement
Imports R2Core.ExceptionManagement
Imports R2CoreParkingSystem.CarType


Public Class UCCmbCarType
    Inherits UCGeneral


    Public Event UC13PressedEvent()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewinf()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        CmbCarType.Text = R2CoreParkingSystemMClassCarType.GetCarTypeNameFromsnCarType(R2CoreParkingSystemMClassCarType.TereiliKafiCode)
    End Sub

    Public Sub UCViewinf()
        Try
            CmbCarType.Items.Clear()
            Dim DataBox As DataSet = R2CoreParkingSystemMClassCarType.GetDSCarType()
            For Loopx As Int64 = 0 To DataBox.Tables(0).Rows.Count - 1
                CmbCarType.Items.Add(DataBox.Tables(0).Rows(Loopx).Item("StrCarName"))
            Next
            CmbCarType.Text = R2CoreParkingSystemMClassCarType.GetCarTypeNameFromsnCarType(R2CoreParkingSystemMClassCarType.TereiliKafiCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSetCarTypeName(YourCarType As String)
        Try
            CmbCarType.Text = R2CoreParkingSystemMClassCarType.GetCarTypeNameFromsnCarType(YourCarType)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetCurrentCarType() As String
        Try
            If CmbCarType.SelectedIndex >= 0 Then
                Return CmbCarType.SelectedItem
            Else
                Throw New DataEntryException
            End If
        Catch exx As DataEntryException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Private Sub UCCmbCarType_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        CmbCarType.Focus()
    End Sub

    Private Sub CmbCarType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCarType.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                RaiseEvent UC13PressedEvent
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub CmbCarType_GotFocus(sender As Object, e As EventArgs) Handles CmbCarType.GotFocus
        CmbCarType.DroppedDown=True
    End Sub


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
