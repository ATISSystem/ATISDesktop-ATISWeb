
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DatabaseManagement
Imports R2Core.ExceptionManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCListBoxCitys
    Inherits UCListBox



#Region "General Properties"

    Public ReadOnly Property UCGetSelectedValuenCityCode As Int64
        Get
            Return Split(UCGetSelectedValue, ";")(0).Trim()
        End Get
    End Property

    Public ReadOnly Property UCGetSelectedValueStrCityName As String
        Get
            Return Split(UCGetSelectedValue, ";")(1).Trim()
        End Get
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCTitle = "لیست شهرها"
    End Sub

    Public Sub UCViewInf(YourSearchString As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim Lst As List(Of R2CoreParkingSystemMClassCitys.R2StandardCityStructure) = R2CoreParkingSystemMClassCitys.GetListOfCitys_SearchIntroCharacters(YourSearchString)
            UCRefresh()
            For Loopx As Int16 = 0 To Lst.Count - 1
                UCAddToList(Lst.Item(Loopx).nCityCode.ToString() + "   ;   " + Lst.Item(Loopx).StrCityName)
            Next
        Catch ex As SqlInjectionException
            Throw ex
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub PictureBoxZeroDistance_Click(sender As Object, e As EventArgs) Handles PictureBoxZeroDistance.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim Lst As List(Of R2CoreParkingSystemMClassCitys.R2StandardCityStructure) = R2CoreParkingSystemMClassCitys.GetListOfCitysWhichDistanceIsZero()
            UCRefresh()
            For Loopx As Int16 = 0 To Lst.Count - 1
                UCAddToList(Lst.Item(Loopx).nCityCode.ToString() + "   ;   " + Lst.Item(Loopx).StrCityName)
            Next
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "اطلاعاتی در این خصوص وجود ندارد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
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
