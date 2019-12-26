
Imports System.Reflection
Imports R2Core.HumanResourcesManagement.Personnel

Public Class UCListBoxPersonnelEnterExit
    Inherits UCListBox


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCTitle="سوابق تردد پرسنل"
    End Sub



    public sub UCViewPersonnelEnterExit(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
        Try
            UCRefresh()
            Dim Lst as List(Of String)=R2CorePersonnelMClassManagement.GetPersonnelEnterExit(YourNSSPersonnel)
            for Loopx As Int64=0 to Lst.Count-1
                Me.UCAddToList(Lst.Item(Loopx))
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End sub

    
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
