
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection

Imports Futronic.SDKHelper

Imports R2CoreGUI

Public Class UCFingerPrintCapturerFutronic
    Inherits UCGeneral



    Private G As Graphics
    Const MAX_TEMPLATE_SIZE As Integer = 1024
    Private Template As Byte() = New Byte(MAX_TEMPLATE_SIZE) {}
    Private FrmViewMessage As R2CoreGUI.FrmcMessageDialog = New R2CoreGUI.FrmcMessageDialog

    Public Event FakeFingerDetected()
    Public Event UCEnrollmentCompleted()
    Public Event UCVerificationCompletedSuccess()
    Public Event UCVerificationCompletedNotSuccess()
    Public Event UCIdentificationCompleted()
    Public Event UCOnPutOnRaised()
    Public Event UCOnTakeOffRaised()
    Private m_Operation As FutronicSdkBase


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Dim Dummy As FutronicEnrollment = New FutronicEnrollment
            TxtIdentLimit.Text = Dummy.IdentificationsLeft
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.New" + vbCrLf + ex.Message)
        End Try
    End Sub

#Region "Top Objects"

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtReport.Clear()
    End Sub

    Private Sub TxtReport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtReport.TextLength > 4000000 Then TxtReport.Clear()
    End Sub

    Private Sub BtnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnUnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnEnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnroll.Click
        Try
            Enrollment()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub BtnEnrollStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnrollStop.Click
        Try
            StopProcess()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub BtnSaveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveImage.Click
        Try
            Dim mySD As SaveFileDialog = New SaveFileDialog
            mySD.Filter = "Bitmap files (*.bmp)|*.bmp"
            If mySD.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            PicFingerPrint.Image.Save(mySD.FileName)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub BtnVerification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerification.Click
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnIdentification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIdentification.Click

    End Sub

    Private Sub BtnVIStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVIStop.Click
        Try
            StopProcess()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub



#End Region

#Region "Properties"
    Public ReadOnly Property CurrentTemplate As Byte()
        Get
            Return Template
        End Get
    End Property

    Public ReadOnly Property FPImage As Bitmap
        Get
            Return PicFingerPrint.Image
        End Get
    End Property
#End Region

#Region "Sub And Function"
    Public Sub UCViewOtherMessage(ByVal YourMessage As String)
        ViewMessage(YourMessage)
    End Sub

    Private Delegate Sub _ViewMessage(ByVal YourMessage As String)
    Private Sub ViewMessage(ByVal YourMessage As String)
        Try
            If (TxtReport.InvokeRequired) Then
                Dim myDelegate As _ViewMessage = New _ViewMessage(AddressOf ViewMessage)
                Dim params() As Object = New Object() {YourMessage}
                BeginInvoke(myDelegate, params)
            Else
                TxtReport.AppendText(YourMessage + vbCrLf)
            End If
        Catch ex As Exception
            MessageBox.Show("UCFingerPrintCapturerFutronic.ViewMessage" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub Enrollment()
        Try
            If Not m_Operation Is Nothing Then
                m_Operation.Dispose()
                m_Operation = Nothing
            End If
            m_Operation = New FutronicEnrollment()
            m_Operation.FakeDetection = ChkDetectFake.Checked
            m_Operation.FFDControl = True
            m_Operation.FARN = NUDFARLevel.Value
            m_Operation.Version = VersionCompatible.ftr_version_current
            m_Operation.FastMode = ChkFastMode.Checked
            CType(m_Operation, FutronicEnrollment).MIOTControlOff = ChkMIOT.Checked
            CType(m_Operation, FutronicEnrollment).MaxModels = NUDMaxFrames.Value
            AddHandler m_Operation.OnPutOn, AddressOf OnPutOn
            AddHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
            AddHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
            AddHandler m_Operation.OnFakeSource, AddressOf OnFakeSource
            AddHandler (CType(m_Operation, FutronicEnrollment)).OnEnrollmentComplete, AddressOf OnEnrollmentComplete
            CType(m_Operation, FutronicEnrollment).Enrollment()
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.Enrollment" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub OnPutOn(ByVal Progress As FTR_PROGRESS)
        ViewMessage("Put finger into device, please ...")
        RaiseEvent UCOnPutOnRaised()
    End Sub

    Private Sub OnTakeOff(ByVal Progress As FTR_PROGRESS)
        ViewMessage("Take off finger from device, please ...")
        RaiseEvent UCOnTakeOffRaised()
    End Sub

    Private Delegate Sub SetImageCallback(ByVal hBitmap As Bitmap)
    Private AFilter As AForge.Imaging.Filters.Invert = New AForge.Imaging.Filters.Invert
    Private Sub UpdateScreenImage(ByVal hBitmap As Bitmap)
        If PicFingerPrint.InvokeRequired Then
            Dim d As SetImageCallback = New SetImageCallback(AddressOf Me.UpdateScreenImage)
            Me.Invoke(d, New Object() {hBitmap})
        Else
            Dim B As Bitmap = AFilter.Apply(hBitmap)
            PicFingerPrint.Image = B
        End If
    End Sub

    Private Function OnFakeSource(ByVal Progress As FTR_PROGRESS) As Boolean
        Try
            RaiseEvent FakeFingerDetected()
            Return False
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Function

    Private Sub OnEnrollmentComplete(ByVal bSuccess As Boolean, ByVal nRetCode As Integer)
        Try
            If bSuccess Then
                ViewMessage("Enroll Complete:Q=" + (CType(m_Operation, FutronicEnrollment)).Quality.ToString())
                Template = (CType(m_Operation, FutronicEnrollment)).Template
            Else
                Template = Nothing
                ViewMessage("Enroll Error:" + FutronicSdkBase.SdkRetCode2Message(nRetCode))
            End If
            RemoveHandler m_Operation.OnPutOn, AddressOf OnPutOn
            RemoveHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
            RemoveHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
            RemoveHandler m_Operation.OnFakeSource, AddressOf OnFakeSource
            RemoveHandler (CType(m_Operation, FutronicEnrollment)).OnEnrollmentComplete, AddressOf OnEnrollmentComplete
            If bSuccess = True Then RaiseEvent UCEnrollmentCompleted()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub RefreshToZero()
        Try
            PicFingerPrint.Image = Nothing
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.RefreshToZero" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub Verification(ByVal yourTemplate As Byte())
        Try
            If Not m_Operation Is Nothing Then
                m_Operation.Dispose()
                m_Operation = Nothing
            End If
            m_Operation = New FutronicVerification(yourTemplate)
            m_Operation.FakeDetection = ChkDetectFake.Checked
            m_Operation.FFDControl = True
            m_Operation.FARN = NUDFARLevel.Value
            m_Operation.Version = VersionCompatible.ftr_version_current
            m_Operation.FastMode = ChkFastMode.Checked
            AddHandler m_Operation.OnPutOn, AddressOf OnPutOn
            AddHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
            AddHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
            AddHandler m_Operation.OnFakeSource, AddressOf OnFakeSource
            AddHandler (CType(m_Operation, FutronicVerification)).OnVerificationComplete, AddressOf OnVerificationComplete
            CType(m_Operation, FutronicVerification).Verification()
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.Verification" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub OnVerificationComplete(ByVal bSuccess As Boolean, ByVal nRetCode As Integer, ByVal bVerificationSuccess As Boolean)
        Try
            If bSuccess Then
                If bVerificationSuccess Then
                    ViewMessage("Verification Succeded")
                    RaiseEvent UCVerificationCompletedSuccess()
                Else
                    ViewMessage("Verification Not Succeded")
                    RaiseEvent UCVerificationCompletedNotSuccess()
                End If
            Else
                ViewMessage("Verification Error:" + FutronicSdkBase.SdkRetCode2Message(nRetCode))
                RaiseEvent UCVerificationCompletedNotSuccess()
            End If
            RemoveHandler m_Operation.OnPutOn, AddressOf OnPutOn
            RemoveHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
            RemoveHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
            RemoveHandler m_Operation.OnFakeSource, AddressOf OnFakeSource
            RemoveHandler (CType(m_Operation, FutronicVerification)).OnVerificationComplete, AddressOf OnVerificationComplete
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub Identification(ByVal yourTemplates As List(Of Byte()))
        Try
            If (yourTemplates Is Nothing) Or (yourTemplates.Count < 1) Then Exit Sub
            If Not m_Operation Is Nothing Then
                m_Operation.Dispose()
                m_Operation = Nothing
            End If
            m_Operation = New FutronicIdentification()
            m_Operation.FakeDetection = ChkDetectFake.Checked
            m_Operation.FFDControl = True
            m_Operation.FARN = NUDFARLevel.Value
            m_Operation.Version = VersionCompatible.ftr_version_current
            m_Operation.FastMode = ChkFastMode.Checked
            AddHandler m_Operation.OnPutOn, AddressOf OnPutOn
            AddHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
            AddHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
            AddHandler m_Operation.OnFakeSource, AddressOf OnFakeSource
            AddHandler (CType(m_Operation, FutronicIdentification)).OnGetBaseTemplateComplete, AddressOf OnGetBaseTemplateComplete
            CType(m_Operation, FutronicIdentification).GetBaseTemplate()
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.Identification" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub OnGetBaseTemplateComplete(ByVal bSuccess As Boolean, ByVal nRetCode As Integer)
        'If bSuccess Then
        '    Dim Users As List(Of DbRecord) = CType(m_OperationObj, List(Of DbRecord))
        '    Dim iRecords As Integer = 0
        '    Dim nResult As Integer
        '    Dim rgRecords As FtrIdentifyRecord() = New FtrIdentifyRecord(Users.Count - 1) {}
        '    For Each item As DbRecord In Users
        '        rgRecords(iRecords) = item.
        '        iRecords += 1
        '    Next item
        '    nResult = (CType(m_Operation, FutronicIdentification)).Identification(rgRecords, iRecords)
        '    If nResult = FutronicSdkBase.RETCODE_OK Then
        '        szMessage.Append("Identification process complete. User: ")
        '        If iRecords <> -1 Then
        '            szMessage.Append(Users(iRecords).UserName)
        '        Else
        '            szMessage.Append("not found")
        '        End If
        '    Else
        '        szMessage.Append("Identification failed.")
        '        szMessage.Append(FutronicSdkBase.SdkRetCode2Message(nResult))
        '    End If
        '    Me.SetIdentificationLimit(m_Operation.IdentificationsLeft)
        'Else
        '    szMessage.Append("Can not retrieve base template.")
        '    szMessage.Append("Error description: ")
        '    szMessage.Append(FutronicSdkBase.SdkRetCode2Message(nRetCode))
        'End If
        'Me.SetStatusText(szMessage.ToString())

        '' unregister events
        'RemoveHandler m_Operation.OnPutOn, AddressOf OnPutOn
        'RemoveHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
        'RemoveHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
        'RemoveHandler m_Operation.OnFakeSource, AddressOf OnFakeSource
        'RemoveHandler (CType(m_Operation, FutronicIdentification)).OnGetBaseTemplateComplete, AddressOf OnGetBaseTemplateComplete

        'm_OperationObj = Nothing
        'EnableControls(True)
    End Sub

    Public Sub StopProcess()
        Try
            If m_Operation IsNot Nothing Then m_Operation.OnCalcel()
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.StopProcess" + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCDisposeResources()
        Try
            If m_Operation IsNot Nothing Then m_Operation.Dispose()
            m_Operation = Nothing
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.UCDisposeResources" + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCEnrollment()
        Try
            RefreshToZero()
            Enrollment()
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.UCEnrollment" + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCVerification(ByVal yourTemplate As Byte())
        Try
            Verification(yourTemplate)
        Catch ex As Exception
            Throw New Exception("UCFingerPrintCapturerFutronic.UCVerification" + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCIdentification(ByVal yourTemplates As List(Of Byte()))

    End Sub


#End Region



  
   
End Class
