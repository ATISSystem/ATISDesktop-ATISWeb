
Imports System.Reflection

Imports R2Core
Imports R2CoreGUI.My.Resources

Public Class UCSortAlphabetic
    Inherits UCGeneral

    Public Event SortOrderChanged(ByVal SortOrder As R2Enums.SortOrder)


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
    Friend WithEvents PicSort As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSortAlphabetic))
        Me.PicSort = New System.Windows.Forms.PictureBox()
        CType(Me.PicSort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicSort
        '
        Me.PicSort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicSort.Image = CType(resources.GetObject("PicSort.Image"), System.Drawing.Image)
        Me.PicSort.Location = New System.Drawing.Point(0, 0)
        Me.PicSort.Name = "PicSort"
        Me.PicSort.Size = New System.Drawing.Size(27, 17)
        Me.PicSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSort.TabIndex = 5
        Me.PicSort.TabStop = False
        '
        'UCSortAlphabetic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PicSort)
        Me.Name = "UCSortAlphabetic"
        Me.Size = New System.Drawing.Size(27, 17)
        CType(Me.PicSort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "General Properties"

    Private _UCSortOrder As R2Enums.SortOrder = R2Enums.SortOrder.Code
    Public Property UCSortOrder As R2Enums.SortOrder
        Get
            Return _UCSortOrder
        End Get
        Set(value As R2Enums.SortOrder)
            _UCSortOrder = value
            If value = R2Enums.SortOrder.Code Then
                PicSort.Image = My.Resources.Sort_Code
            Else
                PicSort.Image = My.Resources.Sort_Name
            End If
            RaiseEvent SortOrderChanged(value)
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub SwicthSortOrder()
        If UCSortOrder = R2Enums.SortOrder.Code Then
            UCSortOrder = R2Enums.SortOrder.Name
        Else
            UCSortOrder = R2Enums.SortOrder.Code
        End If
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicSort_Click(sender As Object, e As EventArgs) Handles PicSort.Click
        Try
            SwicthSortOrder()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
