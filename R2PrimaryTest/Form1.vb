
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Reflection
Imports System.Resources
Imports FreeControls
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.TurnRegisterRequest
Imports R2Core.DatabaseManagement

Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadPermission
Imports R2CoreTransportationAndLoadNotification.LoadPermission.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadPermission.LoadPermissionPrinting
Imports R2CoreTransportationAndLoadNotification.TruckDriver
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.TurnAttendance
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions

Public Class Form1

    Dim WithEvents PersianMC As New FrmcPersianDateTimePicker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim pd As New PrintDocument
        Try
            Dim AP As New Text.StringBuilder
            pd.PrinterSettings.PrinterName = UcPersianTextBoxPelak.UCValue
            For Each x As PaperSource In pd.PrinterSettings.PaperSources
                AP.Append(x.ToString)
                AP.AppendLine()
            Next
            ListBox1.Items.Clear()
            ListBox1.Items.Add(AP.ToString)
            UcPersianTextBox2.UCValue = AP.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim pd As New PrintDocument
            Try
                Dim AP As New Text.StringBuilder
                pd.PrinterSettings.PrinterName = UcPersianTextBoxPelak.UCValue
                For Each x As PaperSize In pd.PrinterSettings.PaperSizes
                    AP.Append(x.ToString)
                    AP.AppendLine()
                Next
                ListBox1.Items.Clear()
                ListBox1.Items.Add(AP.ToString)
                UcPersianTextBox2.UCValue = AP.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            R2Core.UserManagement.R2CoreMClassLoginManagement.SetCurrentUserByPinCode(R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser())
            R2CoreParkingSystem.ReportsManagement.R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderBlackListReport(New R2StandardDateAndTimeStructure(Nothing, "1397/01/01", Nothing), New R2StandardDateAndTimeStructure(Nothing, "1398/04/18", Nothing), R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.ActiveBlackLists)
            'PayanehClassLibrary.CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetNobat(R2CoreParkingSystem.TrafficCardsManagement.R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(2725),Nothing)
            'R2CoreParkingSystem.ReportsManagement.R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderTerraficCardsIdentityReport(new R2StandardDateAndTimeStructure(Nothing,"1398/01/01",Nothing),New R2StandardDateAndTimeStructure(Nothing,"1398/04/15",Nothing))
            'R2CoreTransportationAndLoadNotification.LoadAllocation.FailedLoadAllocationPrinting.R2CoreTransportationAndLoadNotificationMClassFailedLoadAllocationAnnouncePrintingManagement.PrintFailedLoadAllocation(4965)
            'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationsLoadPermissionRegistering()
            'Dim NSSTerraficCard As R2CoreParkingSystem.TrafficCardsManagement.R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystem.TrafficCardsManagement.R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(16063)
            'PayanehClassLibrary.CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetNobat(NSSTerraficCard,Nothing)
            'Dim NSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(965190)
            ''کنترل لیست سیاه
            'Dim BlackList As List(Of R2StandardBlackListStructure) = R2CoreParkingSystemMClassBlackList.GetBlackList(New R2StandardCarStructure(NSSTruck.NSSCar.nIdCar, NSSTruck.NSSCar.snCarType, NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo, NSSTruck.NSSCar.nIdCity), R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.ActiveBlackLists)
            'If BlackList.Count <> 0 Then Throw New LoadPermisionRegisteringFailedBecauseBlackListException(BlackList(0).StrDesc)

            'MessageBox.Show(R2CoreTransportationAndLoadNotificationMClassTurnAttendanceManagement.GetTotalNumberOfNeededPresent(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(2),965190))
            'MessageBox.Show(PrinterSettings.InstalledPrinters(TextBox1.Text))
            '_PrintDocumentPermission=New PrintDocument()
            '_PrintDocumentPermission.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters(TextBox1.Text)
            '_PrintDocumentPermission.Print()

            'R2CoreTransportationAndLoadNotification.LoadPermission.LoadPermissionPrinting.R2CoreTransportationAndLoadNotificationMClassLoadPermissionPrintingManagement.PrintLoadPermission(650)
            ''R2CoreTransportationAndLoadNotification.Turns.R2CoreTransportationAndLoadNotificationMClassTurnPrintingManagement.TurnPrint(943512)
            'R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation.R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadEditing(R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad.R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(462009))
            ''R2CoreTransportationAndLoadNotification.LoadSedimentation.R2CoreTransportationAndLoadNotificationMClassLoadSedimentationManagement.SedimentingProcess()
            'MessageBox.Show(   PayanehClassLibrary.CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetCarTravellength(TextBox1.Text ))
            ''PayanehClassLibrary.LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.TransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(21187, 462122, 3037803, 2993926)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'R2CoreTransportationAndLoadNotificationMClassLoadPermissionPrintingManagement.PrintLoadPermission(503)
        'Me.PersianMonthCalendar.Value = CType(resources.GetObject("PersianMonthCalendar.Value"),FreeControls.PersianDate)

        'PersianMC.ShowDialog()
    End Sub

    Private Sub PersianMC_PersianDateTimeChangedEvent(DateTime As R2StandardDateAndTimeStructure) Handles PersianMC.PersianDateTimeChangedEvent
        MessageBox.Show(DateTime.DateShamsiFull)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim Cmdsql As New SqlCommand
        Cmdsql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
        Try
            Dim Pelak As String = UcPersianTextBoxPelak.UCValue
            Dim Serial As String = UcPersianTextBoxSerial.UCValue
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New SqlCommand("Select Top 1 * from R2PrimaryParkingSystem.dbo.TblEntryExit as EnterExit
                                               Where EnterExit.PelakEnter='" & Pelak & "' and EnterExit.SerialEnter='" & Serial & "' and DateShamsiEnter<='1397/12/29' 
                                               Order By EnterExit.DateTimeMilladiEnter Desc")
            Da.SelectCommand.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
            Ds.Tables.Clear()
            If Da.Fill(Ds) = 0 Then
                MessageBox.Show("No Data Found ...") : Exit Sub
            End If
            Dim DateTimeMilladiEnter As DateTime = Ds.Tables(0).Rows(0).Item("DateTimeMilladiEnter")
            Dim Date13971229 As DateTime = "2019-03-20 23:59:59"
            Dim DateShamsiEnter As String = Ds.Tables(0).Rows(0).Item("DateShamsiEnter")
            Dim TavaghofHoursFromEnter As Int64 = DateDiff(DateInterval.Hour, DateTimeMilladiEnter, Date13971229)
            Dim TavaghofHoursAfter72Hours As Int64 = TavaghofHoursFromEnter - 72
            Dim HazinehOfTavaghofHoursAfter72Hours As Int64 = IIf(TavaghofHoursAfter72Hours <= 0, 0, ((TavaghofHoursAfter72Hours \ 24) + 1) * 21800)
            If MessageBox.Show("Pelak=" + Pelak & vbCrLf & "Serial=" + Serial & vbCrLf & "DateTimeMilladiEnter=" + DateTimeMilladiEnter.ToString & vbCrLf & "DateShamsiEnter=" + DateShamsiEnter & vbCrLf & "TavaghofHoursFromEnter=" + TavaghofHoursFromEnter.ToString & vbCrLf & "TavaghofHoursAfter72Hours=" + TavaghofHoursAfter72Hours.ToString & vbCrLf & "HazinehOfTavaghofHoursAfter72Hours=" + HazinehOfTavaghofHoursAfter72Hours.ToString, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "Insert Into ParkingSystemChop.dbo.TrucksInParkingUpTo13971229(Pelak,Serial,DateTimeMilladiEnter,DateShamsiEnter,TavaghofHoursFromEnter,TavaghofHoursAfter72Hours,HazinehOfTavaghofHoursAfter72Hours) Values('" & Pelak & "','" & Serial & "','" & DateTimeMilladiEnter.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & DateShamsiEnter & "'," & TavaghofHoursFromEnter & "," & TavaghofHoursAfter72Hours & "," & HazinehOfTavaghofHoursAfter72Hours & ")"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
                MessageBox.Show("Information Saved ...")
                UcPersianTextBoxSerial.UCRefresh()
                UcPersianTextBoxPelak.UCRefresh()
                UcPersianTextBoxPelak.UCFocus()
            End If
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UcPersianTextBoxPelak_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxPelak.UC13PressedEvent
        UcPersianTextBoxSerial.UCFocus()
    End Sub

    Private Sub UcPersianTextBoxSerial_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxSerial.UC13PressedEvent
        Button13.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try

            R2Core.UserManagement.R2CoreMClassLoginManagement.SetCurrentUserByPinCode(R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser())
            ''R2CoreTransportationAndLoadNotificationMClassLoadPermissionPrintingManagement.PrintLoadPermission(220)
            '''MessageBox.Show(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, 2, 0))



            Dim x As R2CoreParkingSystem.UCMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge
            x.Location = New Point(0, 0)
            Me.Controls.Add(x)
            x.BringToFront()





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private WithEvents _PrintDocumentPermission As PrintDocument
    Private Sub _PrintDocumentPermission_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.BeginPrint
    End Sub

    Private Sub _PrintDocumentPermission_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.EndPrint
    End Sub

    Private Sub _PrintDocumentPermission_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
        Try
            E.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), X, Y, 700, 400)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub _PrintDocumentPermission_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentPermission.PrintPage
        Try

            _PrintDocumentPermission_PrintPage_Printing(100, 100, e)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        For loopx As Int64 = 0 To PrinterSettings.InstalledPrinters.Count - 1
            ListBox1.Items.Add(loopx.ToString + "  " + PrinterSettings.InstalledPrinters(loopx))
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        R2Core.UserManagement.R2CoreMClassLoginManagement.SetCurrentUserByPinCode(R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser())
        Dim _NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(36862)
        Dim _NSSTruck = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(122120)

        Try
            Dim TurnId As Int64 = Int64.MinValue
            Dim TurnRegisterRequestId = PayanehClassLibraryMClassTurnRegisterRequestManagement.RealTimeTurnRegisterRequest(_NSSTruck, False, True, TurnId)
            MessageBox.Show("نوبت صادر شد" & vbCrLf & "شماره درخواست : " + TurnRegisterRequestId.ToString & vbCrLf & "شماره نوبت :" + TurnId.ToString)
        Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException OrElse TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException
            MessageBox.Show(ex.Message)
        Catch ex As Exception When TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return
        Try
            If (UcTurnRegisterRequestConfirmation.UCChkTruckNobat = True) And R2CoreTransportationAndLoadNotificationMClassTurnsManagement.IsTerraficCardTypeforTurnRegisteringActive(_NSSTrafficCard) Then
                Dim TurnId As Int64 = Int64.MinValue
                Dim TurnRegisterRequestId = PayanehClassLibraryMClassTurnRegisterRequestManagement.RealTimeTurnRegisterRequest(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(_NSSTrafficCard.CardId)), False, False, TurnId)
                MessageBox.Show("نوبت صادر شد")
            End If
            UcTurnRegisterRequestConfirmation.UCChkTruckNobat = True

            'R2CoreTransportationAndLoadNotification.LoadAllocation.R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationLoadPermissionRegistering(653)
            'R2CoreTransportationAndLoadNotification.LoadAllocation.FailedLoadAllocationPrinting.R2CoreTransportationAndLoadNotificationMClassFailedLoadAllocationAnnouncePrintingManagement.PrintFailedLoadAllocation(653)
            'R2CoreTransportationAndLoadNotification.LoadPermission.LoadPermissionPrinting.R2CoreTransportationAndLoadNotificationMClassLoadPermissionPrintingManagement.PrintLoadPermission(653)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            Dim x As New FrmcMessageDialog
            x.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "نوبت صادر شد" & vbCrLf & "شماره درخواست : " + "1125" & vbCrLf & "شماره نوبت :" + "965235", String.Empty, FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,false )

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UcMonetarySupply1_UCMonetarySupplySuccessEvent(TransactionId As Long) 
        MessageBox.Show(TransactionId)
    End Sub
End Class