
Imports System.ComponentModel
Imports System.Reflection

Public Class UCListBox
    Inherits UCGeneral

    Public Event UCSelectedIndexChanged()

#Region "General Properties"

    <Browsable(False)>
    Public ReadOnly Property UCGetSelectedValue As String
        Get
            If ListBox.SelectedIndex < 0 Then
                Throw New Exception("هیچ آیتمی از لیست انتخاب نشده است")
            End If
            Return ListBox.Items(ListBox.SelectedIndex)
        End Get
    End Property

    Private _UCTitle As String = String.Empty
    <Browsable(True)>
    Public Property UCTitle() As String
        Get
            Return _UCTitle
        End Get
        Set(value As String)
            _UCTitle = value
            UcLabelTitle.UCValue = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            ListBox.Font = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.White
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            ListBox.BackColor = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            ListBox.ForeColor = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        ListBox.Items.Clear()
    End Sub

    Public Sub UCAddToList(YourItem As String)
        Try
            ListBox.Items.Add(YourItem)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        Try
            RaiseEvent UCSelectedIndexChanged()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCListBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ListBox.Focus()
    End Sub
#End Region

#Region "Override Methods"



#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
