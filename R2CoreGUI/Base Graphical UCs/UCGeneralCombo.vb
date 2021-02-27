
Imports System.Reflection

Imports R2Core
Imports R2Core.AudioVideoManagement
Imports R2Core.PublicProc
Imports R2Core.BaseStandardClass
Imports R2Core.AuthenticationManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.GUIManagement
Imports R2Core.InformationManagement
Imports R2Core.SoftwareUserManagement


Public MustInherit Class UCGeneralCombo
    Inherits UCGeneral

    Private FrmMessageDialog As New FrmcMessageDialog 
    Private myViewMaxFlag As Boolean = False
    Private myDropDownSimpleFlag As R2Enums.ComboViewState = R2Enums.ComboViewState.DropDown
    Private myHeight As Int32 = Me.Height
    Private myLisBoxKeyFlag As Boolean = False
    Protected MustOverride Sub UCRefreshGeneralL2()


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
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Public WithEvents Txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents PicDownFlesh As System.Windows.Forms.PictureBox
    Friend WithEvents PicRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents PnlCombo As System.Windows.Forms.Panel
    Public WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents PnlIcons As System.Windows.Forms.Panel
    Public WithEvents UcSortAlphabetic As UCSortAlphabetic
    Friend WithEvents CtxMnu As System.Windows.Forms.ContextMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCGeneralCombo))
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.PnlIcons = New System.Windows.Forms.Panel()
        Me.UcSortAlphabetic = New UCSortAlphabetic()
        Me.PicRefresh = New System.Windows.Forms.PictureBox()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.PicDownFlesh = New System.Windows.Forms.PictureBox()
        Me.PnlCombo = New System.Windows.Forms.Panel()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.CtxMnu = New System.Windows.Forms.ContextMenu()
        Me.PnlSearch.SuspendLayout()
        Me.PnlIcons.SuspendLayout()
        CType(Me.PicRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDownFlesh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCombo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.White
        Me.PnlSearch.Controls.Add(Me.PnlIcons)
        Me.PnlSearch.Controls.Add(Me.PicDownFlesh)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(328, 31)
        Me.PnlSearch.TabIndex = 1
        '
        'PnlIcons
        '
        Me.PnlIcons.Controls.Add(Me.UcSortAlphabetic)
        Me.PnlIcons.Controls.Add(Me.PicRefresh)
        Me.PnlIcons.Controls.Add(Me.Txtsearch)
        Me.PnlIcons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlIcons.Location = New System.Drawing.Point(27, 0)
        Me.PnlIcons.Name = "PnlIcons"
        Me.PnlIcons.Size = New System.Drawing.Size(301, 31)
        Me.PnlIcons.TabIndex = 7
        '
        'UcSortAlphabetic
        '
        Me.UcSortAlphabetic.BackColor = System.Drawing.Color.White
        Me.UcSortAlphabetic.Location = New System.Drawing.Point(34, 5)
        Me.UcSortAlphabetic.Name = "UcSortAlphabetic"
        Me.UcSortAlphabetic.Size = New System.Drawing.Size(49, 21)
        'Me.UcSortAlphabetic.SortOrder = atlasnoor.R2Enums.SortOrder.Code
        Me.UcSortAlphabetic.TabIndex = 8
        '
        'PicRefresh
        '
        Me.PicRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRefresh.Image = CType(resources.GetObject("PicRefresh.Image"), System.Drawing.Image)
        Me.PicRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PicRefresh.Location = New System.Drawing.Point(6, 5)
        Me.PicRefresh.Name = "PicRefresh"
        Me.PicRefresh.Size = New System.Drawing.Size(18, 19)
        Me.PicRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefresh.TabIndex = 6
        Me.PicRefresh.TabStop = False
        '
        'Txtsearch
        '
        Me.Txtsearch.BackColor = System.Drawing.Color.White
        Me.Txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txtsearch.Font = New System.Drawing.Font("Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtsearch.Location = New System.Drawing.Point(0, 0)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txtsearch.Size = New System.Drawing.Size(301, 31)
        Me.Txtsearch.TabIndex = 0
        '
        'PicDownFlesh
        '
        Me.PicDownFlesh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDownFlesh.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicDownFlesh.Image = CType(resources.GetObject("PicDownFlesh.Image"), System.Drawing.Image)
        Me.PicDownFlesh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PicDownFlesh.Location = New System.Drawing.Point(0, 0)
        Me.PicDownFlesh.Name = "PicDownFlesh"
        Me.PicDownFlesh.Size = New System.Drawing.Size(27, 31)
        Me.PicDownFlesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDownFlesh.TabIndex = 1
        Me.PicDownFlesh.TabStop = False
        '
        'PnlCombo
        '
        Me.PnlCombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCombo.Controls.Add(Me.ListBox)
        Me.PnlCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCombo.Location = New System.Drawing.Point(0, 31)
        Me.PnlCombo.Name = "PnlCombo"
        Me.PnlCombo.Size = New System.Drawing.Size(328, 0)
        Me.PnlCombo.TabIndex = 2
        '
        'ListBox
        '
        Me.ListBox.BackColor = System.Drawing.Color.White
        Me.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox.ContextMenu = Me.CtxMnu
        Me.ListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox.IntegralHeight = False
        Me.ListBox.ItemHeight = 21
        Me.ListBox.Location = New System.Drawing.Point(0, 0)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox.ScrollAlwaysVisible = True
        Me.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox.Size = New System.Drawing.Size(326, 0)
        Me.ListBox.TabIndex = 2
        Me.ListBox.UseTabStops = False
        '
        'UCGeneralCombo
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlCombo)
        Me.Controls.Add(Me.PnlSearch)
        Me.Name = "UCGeneralCombo"
        Me.Size = New System.Drawing.Size(328, 31)
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlIcons.ResumeLayout(False)
        Me.PnlIcons.PerformLayout()
        CType(Me.PicRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDownFlesh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCombo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region




#Region "Overrides Sub And Function"
    Protected  Sub UCRefreshGeneral()
        Try
            UCRefreshGeneralL2()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub
#End Region

#Region "Updating Management"
    Protected MustOverride Sub Refreshing()
    Protected MustOverride Sub Updating(ByVal StateDecision As R2Enums.UCComboStateDecision)
    Protected MustOverride Sub UpdatingListBox()
    Private Sub UcSortAlphabetic_SortOrderChanged(ByVal SortOrder As R2Enums.SortOrder) Handles UcSortAlphabetic.SortOrderChanged
        Try
            Updating(R2Enums.UCComboStateDecision.Sorting)
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub PicRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicRefresh.Click
        RefreshInformation()
    End Sub
    Public Sub RefreshInformation()
        Txtsearch.Clear()
        Refreshing()
    End Sub
    Private Sub Txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtsearch.KeyUp
        Try
            If e.KeyData = Keys.ControlKey Then UcSortAlphabetic.SwicthSortOrder()
            If e.KeyData = Keys.Delete Then Updating(R2Enums.UCComboStateDecision.SearchingStrSate)
            If (e.KeyCode <> Keys.Up) And (e.KeyCode <> Keys.Down) And (e.KeyCode <> Keys.Left) And (e.KeyCode <> Keys.Right) And (e.KeyCode <> Keys.Enter) Then Updating(R2Enums.UCComboStateDecision.SearchingStrSate)
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub listbox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox.KeyUp
        Try
            'If e.KeyData = Keys.ControlKey Then Updating(R2Enums.UCComboStateDecision.Sorting)
            If (e.KeyData = Keys.Up) And (myLisBoxKeyFlag = True) Then
                Txtsearch.Focus()
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub listbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox.SelectedIndexChanged
        Try
            Txtsearch.Text = ListBox.SelectedItem
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub listbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox.Click
        Try
            Txtsearch.Text = ListBox.SelectedItem
            ItemSelected()
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Public MustOverride Sub ViewValidData(ByVal OCode As String)
    Private Sub ListBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox.DoubleClick
        Txtsearch.Text = ListBox.SelectedItem
        ItemAccepted()
    End Sub
#End Region
#Region "MaxMin View Management"
    Private Sub ViewMax()
        Try
            If myDropDownSimpleFlag = R2Enums.ComboViewState.DropDown Then
                If myViewMaxFlag = False Then
                    Me.Size = New Size(Me.Width, Me.Height + 100)
                    myViewMaxFlag = True
                End If
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub ViewMin()
        Try
            If myDropDownSimpleFlag = R2Enums.ComboViewState.DropDown Then
                If myViewMaxFlag = True Then
                    Me.Size = New Size(Me.Width, myHeight)
                    myViewMaxFlag = False
                End If
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub PicDownFlesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicDownFlesh.Click
        Try
            If myViewMaxFlag = False Then
                ViewMax()
            Else
                ViewMin()
            End If
            Txtsearch.Focus()
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub Txtsearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtsearch.LostFocus
        Try
            If Me.ListBox.Focused = False Then ViewMin()
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub Txtsearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtsearch.GotFocus
        Try
            ListBox.SelectedIndex = -1
            R2coreMClassPublicProcedures.Setkeyboardlayout("Farsi")
            ViewMax()
            Txtsearch.Clear()
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub ListBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox.LostFocus
        Try
            If Me.Txtsearch.Focused = False Then ViewMin()
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub UCGeneralCombo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            myHeight = Me.Height
            Updating(R2Enums.UCComboStateDecision.Loading)
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Public WriteOnly Property ViewState() As R2Enums.ComboViewState
        Set(ByVal Value As R2Enums.ComboViewState)
            myDropDownSimpleFlag = Value
            If myDropDownSimpleFlag = R2Enums.ComboViewState.DropDown Then
                Me.PicDownFlesh.Visible = True
            ElseIf myDropDownSimpleFlag = R2Enums.ComboViewState.Simple Then
                Me.PicDownFlesh.Visible = False
            End If
        End Set
    End Property
#End Region
#Region "Events Management"
    Private Sub listbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListBox.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If IsYourDataValid() = True Then ItemAccepted()
            ElseIf Asc(e.KeyChar) = 27 Then
                Cancel()
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub listbox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox.KeyDown
        Try
            If ListBox.SelectedIndex = 0 Then
                myLisBoxKeyFlag = True
            Else
                myLisBoxKeyFlag = False
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Private Sub Txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtsearch.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                ListBox.SelectedIndex = 0
                ListBox.Focus()
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
    Protected Sub Txtsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtsearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If IsYourDataValid() = True Then ItemAccepted()
            ElseIf Asc(e.KeyChar) = 27 Then
                Cancel()
            Else
                'Updating(R2Enums.UCComboStateDecision.SearchingStrSate)
            End If
        Catch ex As Exception
            FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub
#End Region
#Region "Subs And Functions"
    Public MustOverride Function GetValidData() As R2StandardStructure
    Public MustOverride Function IsYourDataValid() As Boolean
    Protected MustOverride Sub ItemAccepted()
    Protected MustOverride Sub ItemSelected()
    Protected MustOverride Sub Cancel()
    Public Function GetOItem(ByVal Index As Int32) As R2StandardStructure
        Try
            If Index > ListBox.Items.Count - 1 Then
                Return New R2StandardStructure
                Exit Function
            End If
            Return GetOItemAtIndex(Index)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Function
    Protected MustOverride Function GetOItemAtIndex(ByVal index As Int32) As R2StandardStructure
    Public Sub SetSelectionMode(ByVal SelectionMode As SelectionMode)
        ListBox.SelectionMode = SelectionMode
    End Sub
#End Region








End Class
