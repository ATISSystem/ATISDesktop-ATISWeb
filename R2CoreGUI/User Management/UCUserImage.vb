
Imports System.Reflection

Imports R2Core.UserManagement

Public Class UCUserImage
    Inherits UCGeneral


#Region "General Properties"

    Private _UCCurrentNSS As R2CoreStandardUserStructure = Nothing
    Public ReadOnly Property UCCurrentNSS As R2CoreStandardUserStructure
        Get
            Return _UCCurrentNSS
        End Get
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        PicUserImage.Image = Nothing
    End Sub

    Public Sub UCSetUserImage(YourNSSUser As R2CoreStandardUserStructure)
        Try
            _UCCurrentNSS = YourNSSUser
            PicUserImage.Image = R2CoreMClassLoginManagement.GetUserImage(YourNSSUser,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS).GetImage()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
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
