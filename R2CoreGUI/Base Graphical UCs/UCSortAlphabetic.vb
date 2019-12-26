
Imports System.Reflection 

Imports R2Core

Public Class UCSortAlphabetic
    Inherits UCGeneral


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Try
            UCRefreshGeneral()
        Catch ex As Exception
                            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try

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
    Friend WithEvents PicCode As System.Windows.Forms.PictureBox
    Friend WithEvents PicName As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UCSortAlphabetic))
        Me.PicCode = New System.Windows.Forms.PictureBox
        Me.PicName = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'PicCode
        '
        Me.PicCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCode.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicCode.Image = CType(resources.GetObject("PicCode.Image"), System.Drawing.Image)
        Me.PicCode.Location = New System.Drawing.Point(0, 0)
        Me.PicCode.Name = "PicCode"
        Me.PicCode.Size = New System.Drawing.Size(24, 16)
        Me.PicCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCode.TabIndex = 5
        Me.PicCode.TabStop = False
        '
        'PicName
        '
        Me.PicName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicName.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicName.Image = CType(resources.GetObject("PicName.Image"), System.Drawing.Image)
        Me.PicName.Location = New System.Drawing.Point(24, 0)
        Me.PicName.Name = "PicName"
        Me.PicName.Size = New System.Drawing.Size(21, 16)
        Me.PicName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicName.TabIndex = 8
        Me.PicName.TabStop = False
        '
        'UCSortAlphabetic
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PicName)
        Me.Controls.Add(Me.PicCode)
        Me.Name = "UCSortAlphabetic"
        Me.Size = New System.Drawing.Size(46, 16)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mySortOrder As R2Enums.SortOrder = R2Enums.SortOrder.Code
    Public Event SortOrderChanged(ByVal SortOrder As R2Enums.SortOrder)

#Region "Overrides Sub And Function"
    Protected  Sub UCRefreshGeneral()

    End Sub
    Public  Sub DisposeResources()

    End Sub

#End Region

#Region "Engine"
#Region "Events Management"
    Private Sub PicCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicCode.Click
        SortOrder = R2Enums.SortOrder.Code
    End Sub
    Private Sub PicName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicName.Click
        SortOrder = R2Enums.SortOrder.Name
    End Sub
#End Region
#Region "Propertis Management"
    Public Property SortOrder() As R2Enums.SortOrder
        Get
            Return mySortOrder
        End Get
        Set(ByVal Value As R2Enums.SortOrder)
            mySortOrder = Value
            RaiseEvent SortOrderChanged(Value)
        End Set
    End Property
#End Region
#Region "Subs And Funcs"
    Public Sub SwicthSortOrder()
        If SortOrder = R2Enums.SortOrder.Code Then
            SortOrder = R2Enums.SortOrder.Name
        Else
            SortOrder = R2Enums.SortOrder.Code
        End If
    End Sub
#End Region
#End Region


End Class
