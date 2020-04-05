<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TxtReport = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT       Sheet1.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Sheet1"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sheet1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Field1", "Field1"), New System.Data.Common.DataColumnMapping("Field2", "Field2"), New System.Data.Common.DataColumnMapping("Field3", "Field3"), New System.Data.Common.DataColumnMapping("Field4", "Field4"), New System.Data.Common.DataColumnMapping("Field5", "Field5"), New System.Data.Common.DataColumnMapping("Field6", "Field6"), New System.Data.Common.DataColumnMapping("Field7", "Field7"), New System.Data.Common.DataColumnMapping("Field8", "Field8"), New System.Data.Common.DataColumnMapping("Field9", "Field9"), New System.Data.Common.DataColumnMapping("Field10", "Field10"), New System.Data.Common.DataColumnMapping("Field11", "Field11"), New System.Data.Common.DataColumnMapping("Field12", "Field12"), New System.Data.Common.DataColumnMapping("Field13", "Field13"), New System.Data.Common.DataColumnMapping("Field14", "Field14"), New System.Data.Common.DataColumnMapping("Field15", "Field15"), New System.Data.Common.DataColumnMapping("Field16", "Field16"), New System.Data.Common.DataColumnMapping("Field17", "Field17"), New System.Data.Common.DataColumnMapping("Field18", "Field18"), New System.Data.Common.DataColumnMapping("Field19", "Field19"), New System.Data.Common.DataColumnMapping("Field20", "Field20"), New System.Data.Common.DataColumnMapping("Field21", "Field21"), New System.Data.Common.DataColumnMapping("Field22", "Field22"), New System.Data.Common.DataColumnMapping("Field23", "Field23"), New System.Data.Common.DataColumnMapping("Field24", "Field24"), New System.Data.Common.DataColumnMapping("Field25", "Field25"), New System.Data.Common.DataColumnMapping("Field26", "Field26"), New System.Data.Common.DataColumnMapping("Field27", "Field27"), New System.Data.Common.DataColumnMapping("Field28", "Field28"), New System.Data.Common.DataColumnMapping("Field29", "Field29"), New System.Data.Common.DataColumnMapping("Field30", "Field30"), New System.Data.Common.DataColumnMapping("Field31", "Field31"), New System.Data.Common.DataColumnMapping("Field32", "Field32"), New System.Data.Common.DataColumnMapping("Field33", "Field33"), New System.Data.Common.DataColumnMapping("Field34", "Field34"), New System.Data.Common.DataColumnMapping("Field35", "Field35"), New System.Data.Common.DataColumnMapping("Field36", "Field36"), New System.Data.Common.DataColumnMapping("Field37", "Field37"), New System.Data.Common.DataColumnMapping("Field38", "Field38"), New System.Data.Common.DataColumnMapping("Field39", "Field39"), New System.Data.Common.DataColumnMapping("Field40", "Field40")})})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DataBox32.mdb"
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT       Sheet1.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Sheet1"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sheet1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Field1", "Field1"), New System.Data.Common.DataColumnMapping("Field2", "Field2"), New System.Data.Common.DataColumnMapping("Field3", "Field3"), New System.Data.Common.DataColumnMapping("Field4", "Field4"), New System.Data.Common.DataColumnMapping("Field5", "Field5"), New System.Data.Common.DataColumnMapping("Field6", "Field6"), New System.Data.Common.DataColumnMapping("Field7", "Field7"), New System.Data.Common.DataColumnMapping("Field8", "Field8"), New System.Data.Common.DataColumnMapping("Field9", "Field9"), New System.Data.Common.DataColumnMapping("Field10", "Field10"), New System.Data.Common.DataColumnMapping("Field11", "Field11"), New System.Data.Common.DataColumnMapping("Field12", "Field12"), New System.Data.Common.DataColumnMapping("Field13", "Field13"), New System.Data.Common.DataColumnMapping("Field14", "Field14"), New System.Data.Common.DataColumnMapping("Field15", "Field15"), New System.Data.Common.DataColumnMapping("Field16", "Field16"), New System.Data.Common.DataColumnMapping("Field17", "Field17"), New System.Data.Common.DataColumnMapping("Field18", "Field18"), New System.Data.Common.DataColumnMapping("Field19", "Field19"), New System.Data.Common.DataColumnMapping("Field20", "Field20"), New System.Data.Common.DataColumnMapping("Field21", "Field21"), New System.Data.Common.DataColumnMapping("Field22", "Field22"), New System.Data.Common.DataColumnMapping("Field23", "Field23"), New System.Data.Common.DataColumnMapping("Field24", "Field24"), New System.Data.Common.DataColumnMapping("Field25", "Field25"), New System.Data.Common.DataColumnMapping("Field26", "Field26"), New System.Data.Common.DataColumnMapping("Field27", "Field27"), New System.Data.Common.DataColumnMapping("Field28", "Field28"), New System.Data.Common.DataColumnMapping("Field29", "Field29"), New System.Data.Common.DataColumnMapping("Field30", "Field30"), New System.Data.Common.DataColumnMapping("Field31", "Field31"), New System.Data.Common.DataColumnMapping("Field32", "Field32"), New System.Data.Common.DataColumnMapping("Field33", "Field33"), New System.Data.Common.DataColumnMapping("Field34", "Field34"), New System.Data.Common.DataColumnMapping("Field35", "Field35"), New System.Data.Common.DataColumnMapping("Field36", "Field36"), New System.Data.Common.DataColumnMapping("Field37", "Field37"), New System.Data.Common.DataColumnMapping("Field38", "Field38"), New System.Data.Common.DataColumnMapping("Field39", "Field39"), New System.Data.Common.DataColumnMapping("Field40", "Field40")})})
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.Location = New System.Drawing.Point(121, 12)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(148, 401)
        Me.ListBox1.TabIndex = 1
        '
        'TxtReport
        '
        Me.TxtReport.Location = New System.Drawing.Point(275, 12)
        Me.TxtReport.Multiline = True
        Me.TxtReport.Name = "TxtReport"
        Me.TxtReport.Size = New System.Drawing.Size(250, 401)
        Me.TxtReport.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 422)
        Me.Controls.Add(Me.TxtReport)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As OleDb.OleDbDataAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TxtReport As TextBox
End Class
