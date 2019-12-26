
Imports System.ComponentModel


Public Class UCActiveForm


    Private WithEvents _FormRefrence As FrmcGeneral = Nothing
    Public Event UCUnSetActiveFormEvent(ByVal UC As UCActiveForm)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private _UCBackColor As Color = Color.Red
    <Browsable(False)>
    Private Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            CButton.ColorFillSolid = value
        End Set
    End Property

    Public Property UCBackColorActive() As Color = Color.Red
    Public Property UCBackColorUnActive() As Color = Color.DarkGray

    <Browsable(False)>
    Public ReadOnly Property UCFormRefrence() As FrmcGeneral
        Get
            Return _FormRefrence
        End Get
    End Property

    Private _UCDefaultFormName As String = String.Empty
    <DefaultValue("")>
    Public Property UCDefaultFormName As String
        Get
            Return _UCDefaultFormName
        End Get
        Set(ByVal value As String)
            _UCDefaultFormName = value
            CButton.Text = value
        End Set
    End Property

    Public Sub UCSetActiveForm(ByVal YourFormName As String, ByVal YourFormRefrence As FrmcGeneral)
        Try
            CButton.Text = YourFormName.Trim
            _FormRefrence = YourFormRefrence
            Me.Size = New Size(TextRenderer.MeasureText(YourFormName.Trim, CButton.Font).Width + 20, Me.Height)
            UCBackColor = UCBackColorActive
            YourFormRefrence.Show()
        Catch ex As Exception
            Throw New Exception("UCActiveForm.UCSetActiveForm" + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCUnSetActiveForm(ByVal YourFormRefrence As FrmcGeneral)
        Try
            If _FormRefrence Is YourFormRefrence Then
                _FormRefrence.DisposeResources()
                _FormRefrence.Close()
                RaiseEvent UCUnSetActiveFormEvent(Me)
            End If
        Catch ex As Exception
            Throw New Exception("UCActiveForm.UCUnSetActiveForm" + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCActivateRefrence()
        UCBackColor = UCBackColorActive
        _FormRefrence.Activate()
        _FormRefrence.Show()
        _FormRefrence.StartReading()
        _FormRefrence.Focus()
    End Sub

    Private Sub _FormRefrence_DeactivateHandler() Handles _FormRefrence.Deactivate
        Try
            UCBackColor = UCBackColorUnActive
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        UCActivateRefrence()
    End Sub

End Class
