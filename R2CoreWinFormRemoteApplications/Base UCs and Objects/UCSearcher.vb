
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports R2CoreWinFormRemoteApplications.BaseStandardClasses

Public Class UCSearcher
    Inherits UCGeneral

    Protected Event UCSearchRequestEvent(SearchString As String)
    Public Event UC13PressedEvent()
    Public Event UC27PressedEvent()
    Public Event UCIconClicked()
    Private _UCFirstTimeFlag As Boolean = True


#Region "General Properties"

    Private _UCSelectedItem As Object = Nothing
    Public Property UCSelectedItem() As Object
        Get
            Return _UCSelectedItem
        End Get
        Set(value As Object)
            _UCSelectedItem = value
        End Set
    End Property

    Private _UCMaximizeHight As Int64 = 120
    Public Property UCMaximizeHight() As Int64
        Get
            Return _UCMaximizeHight
        End Get
        Set(value As Int64)
            _UCMaximizeHight = value
        End Set
    End Property

    Private _UCMinimizeHight As Int64 = 33
    Public Property UCMinimizeHight() As Int64
        Get
            Return _UCMinimizeHight
        End Get
        Set(value As Int64)
            _UCMinimizeHight = value
        End Set
    End Property

    Public Enum UCModeType As Int16
        None = 0
        DropDown = 1
        Simple = 2
    End Enum

    Private _UCMode As UCModeType = UCMode.Simple
    Public Property UCMode As UCModeType
        Get
            Return _UCMode
        End Get
        Set(value As UCModeType)
            _UCMode = value
        End Set
    End Property

    Private _UCIcon As Image = Nothing
    Public Property UCIcon() As Image
        Get
            Return _UCIcon
        End Get
        Set(value As Image)
            _UCIcon = value
            PictureBox.Image = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.White
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            PnlTop.BackColor = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            UcPersianTextBox.UCForeColor = value
            ListBox.ForeColor = value
        End Set
    End Property

    Private _UCFontSearch As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFontSearch() As Font
        Get
            Return _UCFontSearch
        End Get
        Set(value As Font)
            _UCFontSearch = value
            UcPersianTextBox.UCFont = value
        End Set
    End Property

    Private _UCFontList As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFontList() As Font
        Get
            Return _UCFontList
        End Get
        Set(value As Font)
            _UCFontList = value
            ListBox.Font = value
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub UCFillFirstTime()
        Try
            If _UCFirstTimeFlag = False Then Exit Sub
            _UCFirstTimeFlag = False
            RaiseEvent UCSearchRequestEvent("")
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2StandardStructure)
        Try
            UCSelectedItem = YourNSS.OCode + "  -  " + YourNSS.OName
            UcPersianTextBox.UCValue = YourNSS.OName
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetSelectedNSS() As R2StandardStructure
        Try
            If UCSelectedItem = Nothing Then
                Throw New Exception("اطلاعات مورد نظر انتخاب نشده است")
            End If
            Return New R2StandardStructure(Split(UCSelectedItem, "-")(0), Split(UCSelectedItem, "-")(1))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Protected Sub UCFillListBox(YourInf As List(Of R2StandardStructure))
        Try
            ListBox.Items.Clear()
            For Loopx As Int64 = 0 To YourInf.Count - 1
                ListBox.Items.Add(YourInf(Loopx).OCode + "  -  " + YourInf(Loopx).OName)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCMaximize()
        Try
            Me.Size = New Size(Me.Size.Width, UCMaximizeHight)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCMinimize()
        Try
            Me.Size = New Size(Me.Width, UCMinimizeHight)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersianTextBox_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox.UC13PressedEvent
        Try
            RaiseEvent UCSearchRequestEvent(UcPersianTextBox.UCValue)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UC27PressedEvent() Handles UcPersianTextBox.UC27PressedEvent
        Try
            If UCMode = UCModeType.DropDown Then
                UCMinimize()
                RaiseEvent UC27PressedEvent()
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub ListBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If UCMode = UCModeType.DropDown Then
                    UCMinimize()
                End If
                UcPersianTextBox.UCValue = Split(ListBox.SelectedItem, "-")(1)
                UCSelectedItem = ListBox.SelectedItem
                RaiseEvent UC13PressedEvent()
            End If
            If Asc(e.KeyChar) = 27 Then
                If UCMode = UCModeType.DropDown Then
                    UCMinimize()
                End If
                RaiseEvent UC27PressedEvent()
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub ListBox_DoubleClick(sender As Object, e As EventArgs) Handles ListBox.DoubleClick
        Try
            If UCMode = UCModeType.DropDown Then
                UCMinimize()
            End If
            UcPersianTextBox.UCValue = Split(ListBox.SelectedItem, "-")(1)
            UCSelectedItem = ListBox.SelectedItem
            RaiseEvent UC13PressedEvent()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCGotFocusEvent() Handles UcPersianTextBox.UCGotFocusEvent
        Try
            UCFillFirstTime()
            If UCMode = UCModeType.DropDown Then
                Me.BringToFront()
                UCMaximize()
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCDownArrowKeyPressedEvent() Handles UcPersianTextBox.UCDownArrowKeyPressedEvent
        Try
            ListBox.Focus()
            ListBox.SelectedIndex = 0
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub ListBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ListBox.KeyUp
        Try
            If e.KeyData = Keys.Up And ListBox.SelectedIndex = 0 Then
                ListBox.SelectedIndex = -1
                UcPersianTextBox.Focus()
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UCSearcher_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        Try
            UCFillFirstTime()
            Me.BringToFront()
            If UCMode = UCModeType.DropDown Then
                UCMaximize()
            End If
            UcPersianTextBox.Focus()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        Try
            UCMinimize()
            RaiseEvent UCIconClicked()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class



