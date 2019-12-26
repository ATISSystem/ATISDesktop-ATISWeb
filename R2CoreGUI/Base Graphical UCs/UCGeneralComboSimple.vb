

Imports System.Reflection 

Imports R2Core

Public MustInherit Class UCGeneralComboSimple
    Inherits UCGeneralCombo

    Protected MustOverride Sub UCRefreshGeneralL3()

#Region "Overrides Sub And Function"
    Protected Overrides Sub UCRefreshGeneralL2()
        Try
            UCRefreshGeneralL3()
        Catch ex As Exception
            Throw New Exception("UCRefreshGeneralL2()." + ex.Message.ToString)
        End Try
    End Sub
#End Region



#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region


#Region "Updating Management"
    Protected Overrides Sub Refreshing()
        Try
            Updating(R2Enums.UCComboStateDecision.Refreshing)
        Catch ex As Exception
                            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub
#End Region





End Class
