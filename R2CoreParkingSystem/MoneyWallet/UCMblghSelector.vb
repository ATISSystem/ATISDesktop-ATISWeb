
Imports R2Core.PublicProc
Imports R2CoreGUI

Public Class UCMblghSelector
    Inherits UCButton

    Public Event UCMblghSelected(Mblgh As Int64)

#Region "General Properties"

    Private _UCMblgh As Int64=0
    public Property UCMblgh() As Int64
    get
            Return _UCMblgh
    End Get
        Set(value As Int64)
            _UCMblgh=value
            UCValue=R2coreMClassPublicProcedures.ParseSignDigitToSignString(Int(value/10))+" "+UCViewString
        End Set
    End Property

    Private _UCDeleteOneZeroWhenView As Boolean =False
    public Property UCDeleteOneZeroWhenView() As Boolean
        get
            Return _UCDeleteOneZeroWhenView
        End Get
        Set(value As Boolean)
            _UCDeleteOneZeroWhenView=value
        End Set
    End Property

    Private _UCViewString As String=String.Empty
    public Property UCViewString() As String
        get
            Return _UCViewString
        End Get
        Set(value As String)
            _UCViewString=value
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

   

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private sub UCMblghSelector_UCClickedEvent() Handles Me.UCClickedEvent
        RaiseEvent UCMblghSelected(_UCMblgh)
    End sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
