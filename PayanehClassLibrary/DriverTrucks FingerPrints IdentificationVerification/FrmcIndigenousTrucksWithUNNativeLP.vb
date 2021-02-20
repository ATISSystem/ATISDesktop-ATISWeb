
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.DriverTruckPresentManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.DesktopProcessesManagement
Imports R2Core.PublicProc
Imports R2CoreGUI
Imports PayanehClassLibrary.ProcessesManagement


Public Class FrmcIndigenousTrucksWithUNNativeLP
    Inherits FrmcGeneral




#Region " Windows Form Designer generated code "

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LstTrucks As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPelakAdd As System.Windows.Forms.TextBox
    Friend WithEvents BtnSabt As System.Windows.Forms.Button
    Friend WithEvents TxtSerialAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents TxtSerialDel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPelakDel As System.Windows.Forms.TextBox
    Friend WithEvents PnlBoomiExceptTrucks As System.Windows.Forms.Panel
    Friend WithEvents UcPanel1 As UCPanel
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcPanelNewTruck As UCPanel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcPersianShamsiDate As UCPersianShamsiDate
    Friend WithEvents ChkExpirationShamsiDate As CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LstTrucks = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPelakAdd = New System.Windows.Forms.TextBox()
        Me.BtnSabt = New System.Windows.Forms.Button()
        Me.TxtSerialAdd = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.TxtSerialDel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPelakDel = New System.Windows.Forms.TextBox()
        Me.PnlBoomiExceptTrucks = New System.Windows.Forms.Panel()
        Me.UcPanel1 = New R2CoreGUI.UCPanel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcPanelNewTruck = New R2CoreGUI.UCPanel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.ChkExpirationShamsiDate = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PnlBoomiExceptTrucks.SuspendLayout()
        Me.UcPanel1.SuspendLayout()
        Me.UcPanelNewTruck.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(-1, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 46)
        Me.Panel1.TabIndex = 305
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 23)
        Me.Label19.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 23)
        Me.Label20.TabIndex = 1
        '
        'LstTrucks
        '
        Me.LstTrucks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstTrucks.BackColor = System.Drawing.Color.White
        Me.LstTrucks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstTrucks.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LstTrucks.FormattingEnabled = True
        Me.LstTrucks.IntegralHeight = False
        Me.LstTrucks.ItemHeight = 24
        Me.LstTrucks.Location = New System.Drawing.Point(6, 35)
        Me.LstTrucks.Name = "LstTrucks"
        Me.LstTrucks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LstTrucks.ScrollAlwaysVisible = True
        Me.LstTrucks.Size = New System.Drawing.Size(193, 410)
        Me.LstTrucks.TabIndex = 188
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("IRMehr", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(142, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(58, 37)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "پلاک"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("IRMehr", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(142, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(68, 37)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "سریال"
        '
        'TxtPelakAdd
        '
        Me.TxtPelakAdd.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPelakAdd.Location = New System.Drawing.Point(13, 51)
        Me.TxtPelakAdd.Name = "TxtPelakAdd"
        Me.TxtPelakAdd.Size = New System.Drawing.Size(100, 31)
        Me.TxtPelakAdd.TabIndex = 191
        Me.TxtPelakAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSabt
        '
        Me.BtnSabt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSabt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSabt.Font = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabt.ForeColor = System.Drawing.Color.Black
        Me.BtnSabt.Location = New System.Drawing.Point(13, 192)
        Me.BtnSabt.Name = "BtnSabt"
        Me.BtnSabt.Size = New System.Drawing.Size(100, 45)
        Me.BtnSabt.TabIndex = 195
        Me.BtnSabt.Text = "ثبت"
        Me.BtnSabt.UseVisualStyleBackColor = False
        '
        'TxtSerialAdd
        '
        Me.TxtSerialAdd.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSerialAdd.Location = New System.Drawing.Point(13, 86)
        Me.TxtSerialAdd.Name = "TxtSerialAdd"
        Me.TxtSerialAdd.Size = New System.Drawing.Size(100, 31)
        Me.TxtSerialAdd.TabIndex = 196
        Me.TxtSerialAdd.Text = " "
        Me.TxtSerialAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.LstTrucks)
        Me.GroupBox2.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(539, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(205, 451)
        Me.GroupBox2.TabIndex = 198
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "لیست ناوگان"
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("IRMehr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.Black
        Me.BtnDel.Location = New System.Drawing.Point(13, 124)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(100, 61)
        Me.BtnDel.TabIndex = 195
        Me.BtnDel.Text = "حذف"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'TxtSerialDel
        '
        Me.TxtSerialDel.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSerialDel.Location = New System.Drawing.Point(13, 87)
        Me.TxtSerialDel.Name = "TxtSerialDel"
        Me.TxtSerialDel.ReadOnly = True
        Me.TxtSerialDel.Size = New System.Drawing.Size(100, 31)
        Me.TxtSerialDel.TabIndex = 196
        Me.TxtSerialDel.Text = " "
        Me.TxtSerialDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("IRMehr", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(116, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(58, 37)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "پلاک"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("IRMehr", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(116, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(68, 37)
        Me.Label5.TabIndex = 190
        Me.Label5.Text = "سریال"
        '
        'TxtPelakDel
        '
        Me.TxtPelakDel.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPelakDel.Location = New System.Drawing.Point(13, 51)
        Me.TxtPelakDel.Name = "TxtPelakDel"
        Me.TxtPelakDel.ReadOnly = True
        Me.TxtPelakDel.Size = New System.Drawing.Size(100, 31)
        Me.TxtPelakDel.TabIndex = 191
        Me.TxtPelakDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlBoomiExceptTrucks
        '
        Me.PnlBoomiExceptTrucks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBoomiExceptTrucks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBoomiExceptTrucks.Controls.Add(Me.UcPanel1)
        Me.PnlBoomiExceptTrucks.Controls.Add(Me.UcPanelNewTruck)
        Me.PnlBoomiExceptTrucks.Controls.Add(Me.GroupBox2)
        Me.PnlBoomiExceptTrucks.Location = New System.Drawing.Point(5, 50)
        Me.PnlBoomiExceptTrucks.Name = "PnlBoomiExceptTrucks"
        Me.PnlBoomiExceptTrucks.Size = New System.Drawing.Size(995, 512)
        Me.PnlBoomiExceptTrucks.TabIndex = 205
        '
        'UcPanel1
        '
        Me.UcPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPanel1.BackColor = System.Drawing.Color.Transparent
        Me.UcPanel1.Controls.Add(Me.UcLabel2)
        Me.UcPanel1.Controls.Add(Me.BtnDel)
        Me.UcPanel1.Controls.Add(Me.TxtPelakDel)
        Me.UcPanel1.Controls.Add(Me.TxtSerialDel)
        Me.UcPanel1.Controls.Add(Me.Label5)
        Me.UcPanel1.Controls.Add(Me.Label3)
        Me.UcPanel1.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.UcPanel1.Location = New System.Drawing.Point(249, 279)
        Me.UcPanel1.MouseReflection = True
        Me.UcPanel1.Name = "UcPanel1"
        Me.UcPanel1.Opacity = 25
        Me.UcPanel1.Radius = 5.0!
        Me.UcPanel1.Size = New System.Drawing.Size(252, 204)
        Me.UcPanel1.TabIndex = 202
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel2.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(252, 40)
        Me.UcLabel2.TabIndex = 202
        Me.UcLabel2.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.White
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "حذف ناوگان"
        '
        'UcPanelNewTruck
        '
        Me.UcPanelNewTruck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPanelNewTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcPanelNewTruck.Controls.Add(Me.ChkExpirationShamsiDate)
        Me.UcPanelNewTruck.Controls.Add(Me.UcLabel1)
        Me.UcPanelNewTruck.Controls.Add(Me.UcPersianShamsiDate)
        Me.UcPanelNewTruck.Controls.Add(Me.TxtPelakAdd)
        Me.UcPanelNewTruck.Controls.Add(Me.BtnSabt)
        Me.UcPanelNewTruck.Controls.Add(Me.Label2)
        Me.UcPanelNewTruck.Controls.Add(Me.TxtSerialAdd)
        Me.UcPanelNewTruck.Controls.Add(Me.Label1)
        Me.UcPanelNewTruck.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.UcPanelNewTruck.Location = New System.Drawing.Point(249, 21)
        Me.UcPanelNewTruck.MouseReflection = True
        Me.UcPanelNewTruck.Name = "UcPanelNewTruck"
        Me.UcPanelNewTruck.Opacity = 25
        Me.UcPanelNewTruck.Radius = 5.0!
        Me.UcPanelNewTruck.Size = New System.Drawing.Size(252, 249)
        Me.UcPanelNewTruck.TabIndex = 201
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(252, 40)
        Me.UcLabel1.TabIndex = 201
        Me.UcLabel1.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "ناوگان جدید"
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianShamsiDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate.Enabled = False
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(63, 159)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(126, 25)
        Me.UcPersianShamsiDate.TabIndex = 200
        Me.UcPersianShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'ChkExpirationShamsiDate
        '
        Me.ChkExpirationShamsiDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkExpirationShamsiDate.AutoSize = True
        Me.ChkExpirationShamsiDate.Font = New System.Drawing.Font("IRMehr", 15.75!)
        Me.ChkExpirationShamsiDate.Location = New System.Drawing.Point(64, 122)
        Me.ChkExpirationShamsiDate.Name = "ChkExpirationShamsiDate"
        Me.ChkExpirationShamsiDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkExpirationShamsiDate.Size = New System.Drawing.Size(125, 41)
        Me.ChkExpirationShamsiDate.TabIndex = 202
        Me.ChkExpirationShamsiDate.Text = "تاریخ انقضاء"
        Me.ChkExpirationShamsiDate.UseVisualStyleBackColor = True
        '
        'FrmcIndigenousTrucksWithUNNativeLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlBoomiExceptTrucks)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcIndigenousTrucksWithUNNativeLP"
        Me.Text = "frmcdaemresidmoavagh"
        Me.Controls.SetChildIndex(Me.PnlBoomiExceptTrucks, 0)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.PnlBoomiExceptTrucks.ResumeLayout(False)
        Me.UcPanel1.ResumeLayout(False)
        Me.UcPanel1.PerformLayout()
        Me.UcPanelNewTruck.ResumeLayout(False)
        Me.UcPanelNewTruck.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private _DateTime As R2DateTime = New R2DateTime


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Try
            InitializeSpecial()
            RefreshToZero()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcBoomiExceptTruck))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FillList()
        Try
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New SqlClient.SqlCommand("Select BId,Pelak,Serial From R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP Order By Pelak")
            Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
            Ds.Tables.Clear()
            If Da.Fill(Ds) = 0 Then Exit Sub
            LstTrucks.Items.Clear()
            For Loopx As UInt16 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim LPString As String = Ds.Tables(0).Rows(Loopx).Item("Pelak").trim + "-" + Ds.Tables(0).Rows(Loopx).Item("Serial").trim
                Dim BId As String = StrDup(5 - Ds.Tables(0).Rows(Loopx).Item("Bid").ToString.Trim.Length, "0") + Ds.Tables(0).Rows(Loopx).Item("Bid").ToString.Trim
                LstTrucks.Items.Add(BId + "    " + LPString)
            Next
        Catch ex As Exception
            Throw New Exception("FrmcBoomiExceptTruck.FillList" + ex.Message.ToString)
        End Try
    End Sub

    Private Sub RefreshToZero()
        Try
            FillList()
            TxtPelakAdd.Clear()
            TxtPelakDel.Clear()
            TxtSerialAdd.Clear()
            TxtSerialDel.Clear()
        Catch ex As Exception
            Throw New Exception("FrmcBoomiExceptTruck.RefreshToZero" + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub BtnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
        Try
            If TxtPelakDel.Text.Trim = "" Or TxtSerialDel.Text.Trim = "" Then
                MessageBox.Show("پلاک یا سریال وارد شده نادرست است")
                Exit Sub
            End If
            If MessageBox.Show("آیا تصمیم دارید ناوگان مورد نظر را از لیست حذف کنید", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) = DialogResult.Yes Then
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Delete R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP Where Pelak='" & TxtPelakDel.Text & "' And Serial='" & TxtSerialDel.Text & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                FillList()
                'MessageBox.Show("ناوگان مورد نظر حذف گردید")
            End If
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            MessageBox.Show("BtnDel_Click" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub BtnSabt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSabt.Click
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            If TxtPelakAdd.Text.Trim = "" Or TxtSerialAdd.Text.Trim = "" Then
                MessageBox.Show("پلاک یا سریال وارد شده نادرست است")
                Exit Sub
            End If
            If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.ExistIndigenousTrucksWithUNNativeLP(TxtPelakAdd.Text, TxtSerialAdd.Text) = True Then
                MessageBox.Show("پلاک و سریال وارد شده قبلا ثبت شده است")
                Exit Sub
            End If
            If MessageBox.Show("آیا تصمیم دارید ناوگان مورد نظر را به لیست اضافه کنید", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) = DialogResult.Yes Then
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP(Pelak,Serial,DateTimeMilladi,DateShamsi,UserId,EnghezaDate) values('" & TxtPelakAdd.Text & "','" & TxtSerialAdd.Text & "','" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "'," & R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId & ",'" & IIf(ChkExpirationShamsiDate.Checked, UcPersianShamsiDate.UCGetDate.DateShamsiFull, String.Empty) & "')"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                FillList()
                'MessageBox.Show("ناوگان مورد نظر ثبت گردید")
            End If
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            MessageBox.Show("BtnSabt_Click" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub LstTrucks_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstTrucks.SelectedValueChanged
        Try
            If LstTrucks.SelectedIndex < 0 Then Exit Sub
            Dim BId As UInt64 = Mid(LstTrucks.Items(LstTrucks.SelectedIndex), 1, 5)
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New SqlClient.SqlCommand("Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP Where BId=" & BId & "")
            Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
            Ds.Tables.Clear()
            If Da.Fill(Ds) <> 0 Then
                TxtPelakDel.Text = Ds.Tables(0).Rows(0).Item("Pelak").trim
                TxtSerialDel.Text = Ds.Tables(0).Rows(0).Item("Serial").trim
                TxtPelakAdd.Text = Ds.Tables(0).Rows(0).Item("Pelak").trim
                TxtSerialAdd.Text = Ds.Tables(0).Rows(0).Item("Serial").trim
                If Ds.Tables(0).Rows(0).Item("EnghezaDate").trim = String.Empty Then
                    ChkExpirationShamsiDate.Checked = False
                Else
                    ChkExpirationShamsiDate.Checked = True
                End If
                UcPersianShamsiDate.UCSetDate(New R2StandardDateAndTimeStructure(Nothing, Ds.Tables(0).Rows(0).Item("EnghezaDate").trim, Nothing))
            End If
        Catch ex As Exception
            MessageBox.Show("LstTrucks_SelectedValueChanged" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ChkExpirationShamsiDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkExpirationShamsiDate.CheckedChanged
        If ChkExpirationShamsiDate.Checked = True Then
            UcPersianShamsiDate.Enabled = True
        Else
            UcPersianShamsiDate.Enabled = False
        End If
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region







End Class
