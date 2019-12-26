
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement

Public NotInheritable Class R2CoreGUIMClassGUIManagement

    Public Shared WithEvents FrmMainMenu As New FrmcMainMenu()
    Public Shared GrdEnterLeaveCellFlag As Boolean

    Public Shared Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try
            If objectName.LastIndexOf(".", StringComparison.Ordinal) = -1 Then
                objectName = Assembly.GetEntryAssembly.GetName.Name & "." & objectName
            End If
            obj = [Assembly].GetEntryAssembly.CreateInstance(objectName)
        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj
    End Function


    'روتين فارسي سازي ستونهاي عددي گرايدها
    Public Shared Sub MakeGrdColsDgFarsi(ByRef grd As AxMSFlexGridLib.AxMSFlexGrid, ByVal startrow As Integer, ByVal endrow As Integer, Optional ByVal c0 As Integer = -1, Optional ByVal c1 As Integer = -1, Optional ByVal c2 As Integer = -1, Optional ByVal c3 As Integer = -1, Optional ByVal c4 As Integer = -1, Optional ByVal c5 As Integer = -1, Optional ByVal c6 As Integer = -1, Optional ByVal c7 As Integer = -1, Optional ByVal c8 As Integer = -1, Optional ByVal c9 As Integer = -1)
        Dim mycol, myrow As Int16
        Try
            GrdEnterLeaveCellFlag = True
            'grd.begininit()
            mycol = grd.Col : myrow = grd.Row
            For loopx As Int16 = startrow To endrow
                If grd.get_MergeRow(loopx) <> True Then
                    grd.Row = loopx
                    If c0 <> -1 Then
                        grd.Col = c0 : grd.CellFontName =  R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c1 <> -1 Then
                        grd.Col = c1 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c2 <> -1 Then
                        grd.Col = c2 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c3 <> -1 Then
                        grd.Col = c3 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c4 <> -1 Then
                        grd.Col = c4 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c5 <> -1 Then
                        grd.Col = c5 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c6 <> -1 Then
                        grd.Col = c6 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c7 <> -1 Then
                        grd.Col = c7 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c8 <> -1 Then
                        grd.Col = c8 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                    If c9 <> -1 Then
                        grd.Col = c9 : grd.CellFontName = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,0) : grd.CellFontSize = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.DigitsFontInformation,1)
                    End If
                End If
            Next
            grd.Col = mycol : grd.Row = myrow
            'grd.endinit()
            GrdEnterLeaveCellFlag = False
        Catch ex As Exception
        End Try
    End Sub
    'روتين آماده سازي گرايد
    Public Shared Function GrdRefresh(ByRef grd As AxMSFlexGridLib.AxMSFlexGrid, ByVal noofrowsforrefresh As Int16, Optional ByVal t9 As String = "", Optional ByVal t8 As String = "", Optional ByVal t7 As String = "", Optional ByVal t6 As String = "", Optional ByVal t5 As String = "", Optional ByVal t4 As String = "", Optional ByVal t3 As String = "", Optional ByVal t2 As String = "", Optional ByVal t1 As String = "", Optional ByVal t0 As String = "", Optional ByVal cw9 As Int16 = 0, Optional ByVal cw8 As Int16 = 0, Optional ByVal cw7 As Int16 = 0, Optional ByVal cw6 As Int16 = 0, Optional ByVal cw5 As Int16 = 0, Optional ByVal cw4 As Int16 = 0, Optional ByVal cw3 As Int16 = 0, Optional ByVal cw2 As Int16 = 0, Optional ByVal cw1 As Int16 = 0, Optional ByVal cw0 As Int16 = 0)
        Try
            With grd
                '.BeginInit()
                .FixedRows = 0
                .Rows = 0
                .AddItem("")
                If t0 <> "" Then
                    .set_TextMatrix(0, 0, t0)
                    .set_ColAlignment(0, 3)
                    .set_ColWidth(0, cw0)
                End If
                If t1 <> "" Then
                    .set_TextMatrix(0, 1, t1)
                    .set_ColAlignment(1, 3)
                    .set_ColWidth(1, cw1)
                End If

                If t2 <> "" Then
                    .set_TextMatrix(0, 2, t2)
                    .set_ColAlignment(2, 3)
                    .set_ColWidth(2, cw2)
                End If

                If t3 <> "" Then
                    .set_TextMatrix(0, 3, t3)
                    .set_ColAlignment(3, 3)
                    .set_ColWidth(3, cw3)
                End If

                If t4 <> "" Then
                    .set_TextMatrix(0, 4, t4)
                    .set_ColAlignment(4, 3)
                    .set_ColWidth(4, cw4)
                End If

                If t5 <> "" Then
                    .set_TextMatrix(0, 5, t5)
                    .set_ColAlignment(5, 3)
                    .set_ColWidth(5, cw5)
                End If

                If t6 <> "" Then
                    .set_TextMatrix(0, 6, t6)
                    .set_ColAlignment(6, 3)
                    .set_ColWidth(6, cw6)
                End If

                If t7 <> "" Then
                    .set_TextMatrix(0, 7, t7)
                    .set_ColAlignment(7, 3)
                    .set_ColWidth(7, cw7)
                End If

                If t8 <> "" Then
                    .set_TextMatrix(0, 8, t8)
                    .set_ColAlignment(8, 3)
                    .set_ColWidth(8, cw8)
                End If

                If t9 <> "" Then
                    .set_TextMatrix(0, 9, t9)
                    .set_ColAlignment(9, 3)
                    .set_ColWidth(9, cw9)
                End If
                .Rows = noofrowsforrefresh
                .FixedRows = 1
                '.EndInit()
            End With
        Catch ex As Exception
            Throw New Exception("Modulepublicsub.prgrdrefresh()." + ex.Message.ToString)
        End Try
    End Function




End Class
