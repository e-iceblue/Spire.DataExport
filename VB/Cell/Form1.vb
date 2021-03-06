Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Spire.DataExport.TXT
Imports Spire.DataExport.XLS

Namespace Spire.DataExport.CellSample
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private WithEvents cellExport1 As Spire.DataExport.XLS.CellExport
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private txtCommandText As System.Windows.Forms.TextBox
        Private txtConnectString As System.Windows.Forms.TextBox
        Private dgDetail As System.Windows.Forms.DataGrid
        Private WithEvents btnRun As System.Windows.Forms.Button
        Private WithEvents btnAbout As System.Windows.Forms.Button
        Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Private oleDbCommand1 As System.Data.OleDb.OleDbCommand

        Private WithEvents button2 As System.Windows.Forms.Button
        Private label3 As System.Windows.Forms.Label
        Private oleDbCommand2 As System.Data.OleDb.OleDbCommand
        Private txtCommandTxt1 As System.Windows.Forms.TextBox
        Private WithEvents button1 As System.Windows.Forms.Button
        Private cellExport2 As Spire.DataExport.XLS.CellExport
        Private WithEvents button3 As System.Windows.Forms.Button
        Private label4 As System.Windows.Forms.Label
        Private WithEvents button4 As System.Windows.Forms.Button
        Private WithEvents button5 As System.Windows.Forms.Button
        Private WithEvents cellExport3 As Spire.DataExport.XLS.CellExport
        Private cellExport4 As Spire.DataExport.XLS.CellExport
        Private cellExport5 As Spire.DataExport.XLS.CellExport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim WorkSheet1 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim StripStyle1 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle2 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet2 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim StripStyle3 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle4 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet3 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim Chart1 As Spire.DataExport.XLS.Chart = New Spire.DataExport.XLS.Chart
            Dim ChartSeries1 As Spire.DataExport.XLS.ChartSeries = New Spire.DataExport.XLS.ChartSeries
            Dim StripStyle5 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle6 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet4 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim Chart2 As Spire.DataExport.XLS.Chart = New Spire.DataExport.XLS.Chart
            Dim ChartSeries2 As Spire.DataExport.XLS.ChartSeries = New Spire.DataExport.XLS.ChartSeries
            Dim WorkSheet5 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim StripStyle7 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle8 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet6 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim ColumnFormat1 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat2 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat3 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat4 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat5 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Me.oleDbCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbCommand2 = New System.Data.OleDb.OleDbCommand
            Me.cellExport1 = New Spire.DataExport.XLS.CellExport
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.txtCommandTxt1 = New System.Windows.Forms.TextBox
            Me.label3 = New System.Windows.Forms.Label
            Me.button2 = New System.Windows.Forms.Button
            Me.txtCommandText = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.txtConnectString = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.dgDetail = New System.Windows.Forms.DataGrid
            Me.btnRun = New System.Windows.Forms.Button
            Me.btnAbout = New System.Windows.Forms.Button
            Me.button1 = New System.Windows.Forms.Button
            Me.cellExport2 = New Spire.DataExport.XLS.CellExport
            Me.button3 = New System.Windows.Forms.Button
            Me.label4 = New System.Windows.Forms.Label
            Me.button4 = New System.Windows.Forms.Button
            Me.cellExport4 = New Spire.DataExport.XLS.CellExport
            Me.button5 = New System.Windows.Forms.Button
            Me.cellExport5 = New Spire.DataExport.XLS.CellExport
            Me.cellExport3 = New Spire.DataExport.XLS.CellExport
            Me.groupBox1.SuspendLayout()
            CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'oleDbCommand1
            '
            Me.oleDbCommand1.CommandText = "select * from parts"
            Me.oleDbCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
            "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""..\database\demo.mdb"";Je" & _
            "t OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.J" & _
            "et.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties" & _
            "=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System " & _
            "Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Wi" & _
            "thout Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
            '
            'oleDbCommand2
            '
            Me.oleDbCommand2.CommandText = "select * from country"
            Me.oleDbCommand2.Connection = Me.oleDbConnection1
            '
            'cellExport1
            '
            Me.cellExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport1.AutoFitColWidth = True
            Me.cellExport1.AutoFormula = True
            Me.cellExport1.DataFormats.CultureName = "zh-CN"
            Me.cellExport1.DataFormats.Currency = "$#,###,##0.00"
            Me.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport1.DataFormats.Float = "#,###,##0.00"
            Me.cellExport1.DataFormats.Integer = "#,###,##0"
            Me.cellExport1.DataFormats.Time = "H:mm"
            Me.cellExport1.FileName = "Sheets.xls"
            Me.cellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport1.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport1.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport1.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial"
            WorkSheet1.AutoFitColWidth = True
            WorkSheet1.CustomFormats.AddRange(New Object() {"OnHand=#,##0", "OnOrder=#,##0", "Cost=#,##0.0000;-#,##0.0000"})
            WorkSheet1.FormatsExport.CultureName = "zh-CN"
            WorkSheet1.FormatsExport.Currency = "￥#,###,##0.00"
            WorkSheet1.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet1.FormatsExport.Float = "#,###,##0.00"
            WorkSheet1.FormatsExport.Integer = "#,###,##0"
            WorkSheet1.FormatsExport.Time = "H:mm"
            StripStyle1.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle1.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle1.Font.Name = "Arial"
            StripStyle2.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle2.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle2.Font.Name = "Arial"
            WorkSheet1.ItemStyles.Add(StripStyle1)
            WorkSheet1.ItemStyles.Add(StripStyle2)
            WorkSheet1.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet1.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet1.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet1.Options.DefaultFont.Name = "Arial"
            WorkSheet1.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet1.Options.HeaderFormat.Font.Bold = True
            WorkSheet1.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet1.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet1.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet1.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet1.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet1.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet1.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet1.Options.NoteFormat.Font.Bold = True
            WorkSheet1.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet1.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet1.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet1.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet1.Options.TitlesFormat.Font.Bold = True
            WorkSheet1.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet1.SheetName = "parts"
            WorkSheet1.SQLCommand = Me.oleDbCommand1
            WorkSheet1.StartDataCol = CType(0, Byte)
            WorkSheet2.AutoFitColWidth = True
            WorkSheet2.CustomFormats.AddRange(New Object() {"Area=#,##0", "Population=#,##0"})
            WorkSheet2.FormatsExport.CultureName = "zh-CN"
            WorkSheet2.FormatsExport.Currency = "￥#,###,##0.00"
            WorkSheet2.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet2.FormatsExport.Float = "#,###,##0.00"
            WorkSheet2.FormatsExport.Integer = "#,###,##0"
            WorkSheet2.FormatsExport.Time = "H:mm"
            StripStyle3.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle3.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle3.Font.Name = "Arial"
            StripStyle4.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle4.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.White
            StripStyle4.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle4.Font.Name = "Arial"
            WorkSheet2.ItemStyles.Add(StripStyle3)
            WorkSheet2.ItemStyles.Add(StripStyle4)
            WorkSheet2.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet2.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet2.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet2.Options.DefaultFont.Name = "Arial"
            WorkSheet2.Options.FooterFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet2.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet2.Options.HeaderFormat.Font.Bold = True
            WorkSheet2.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet2.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet2.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet2.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet2.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet2.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet2.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet2.Options.NoteFormat.Font.Bold = True
            WorkSheet2.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet2.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet2.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet2.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet2.Options.TitlesFormat.Font.Bold = True
            WorkSheet2.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet2.SheetName = "country"
            WorkSheet2.SQLCommand = Me.oleDbCommand2
            WorkSheet2.StartDataCol = CType(0, Byte)
            Me.cellExport1.Sheets.Add(WorkSheet1)
            Me.cellExport1.Sheets.Add(WorkSheet2)
            Me.cellExport1.SQLCommand = Me.oleDbCommand1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.txtCommandTxt1)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.txtCommandText)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.txtConnectString)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(16, 13)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(312, 203)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = " Data source "
            '
            'txtCommandTxt1
            '
            Me.txtCommandTxt1.Location = New System.Drawing.Point(17, 144)
            Me.txtCommandTxt1.Name = "txtCommandTxt1"
            Me.txtCommandTxt1.Size = New System.Drawing.Size(279, 21)
            Me.txtCommandTxt1.TabIndex = 7
            Me.txtCommandTxt1.Text = "select * from country"
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(16, 120)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(256, 23)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Command text for the second work sheet:"
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(232, 173)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(64, 23)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Load"
            '
            'txtCommandText
            '
            Me.txtCommandText.Location = New System.Drawing.Point(17, 95)
            Me.txtCommandText.Name = "txtCommandText"
            Me.txtCommandText.Size = New System.Drawing.Size(279, 21)
            Me.txtCommandText.TabIndex = 3
            Me.txtCommandText.Text = "select * from parts"
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(16, 75)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(240, 23)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Command text for the first work sheet:"
            '
            'txtConnectString
            '
            Me.txtConnectString.Location = New System.Drawing.Point(16, 43)
            Me.txtConnectString.Name = "txtConnectString"
            Me.txtConnectString.Size = New System.Drawing.Size(280, 21)
            Me.txtConnectString.TabIndex = 1
            Me.txtConnectString.Text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\..\\database\\demo.mdb"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(15, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(121, 16)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Connection string:"
            '
            'dgDetail
            '
            Me.dgDetail.DataMember = ""
            Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgDetail.Location = New System.Drawing.Point(16, 224)
            Me.dgDetail.Name = "dgDetail"
            Me.dgDetail.Size = New System.Drawing.Size(584, 128)
            Me.dgDetail.TabIndex = 0
            '
            'btnRun
            '
            Me.btnRun.Location = New System.Drawing.Point(368, 24)
            Me.btnRun.Name = "btnRun"
            Me.btnRun.Size = New System.Drawing.Size(96, 23)
            Me.btnRun.TabIndex = 2
            Me.btnRun.Text = "Multi-Sheets"
            '
            'btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(528, 368)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.TabIndex = 3
            Me.btnAbout.Text = "Close"
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(368, 56)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(96, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Chart1"
            '
            'cellExport2
            '
            Me.cellExport2.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport2.AutoFitColWidth = True
            Me.cellExport2.DataFormats.CultureName = "zh-CN"
            Me.cellExport2.DataFormats.Currency = "￥#,###,##0.00"
            Me.cellExport2.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport2.DataFormats.Float = "#,###,##0.00"
            Me.cellExport2.DataFormats.Integer = "#,###,##0"
            Me.cellExport2.DataFormats.Time = "H:mm"
            Me.cellExport2.FileName = "chart1.xls"
            Me.cellExport2.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport2.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport2.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport2.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport2.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport2.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport2.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport2.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport2.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport2.SheetOptions.TitlesFormat.Font.Name = "Arial"
            WorkSheet3.AutoFitColWidth = True
            Chart1.CategoryLabels.ColX = CType(1, Byte)
            Chart1.CategoryLabels.ColY = CType(1, Byte)
            Chart1.CategoryLabels.RowX = 1
            Chart1.CategoryLabels.RowY = 9
            Chart1.CategoryLabelsColumn = "Name"
            Chart1.DataRangeSheet = "charts"
            Chart1.Position.AutoPosition.Height = 12
            Chart1.Position.AutoPosition.Top = 1
            Chart1.Position.AutoPosition.Width = 6
            ChartSeries1.DataColumn = "Population"
            ChartSeries1.DataRangeSheet = "charts"
            ChartSeries1.Title = "Population"
            Chart1.Series.Add(ChartSeries1)
            Chart1.Style = Spire.DataExport.XLS.ChartStyle.Pie3d
            Chart1.Title = "Chart demo"
            WorkSheet3.Charts.Add(Chart1)
            WorkSheet3.FormatsExport.CultureName = "zh-CN"
            WorkSheet3.FormatsExport.Currency = "￥#,###,##0.00"
            WorkSheet3.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet3.FormatsExport.Float = "#,###,##0.00"
            WorkSheet3.FormatsExport.Integer = "#,###,##0"
            WorkSheet3.FormatsExport.Time = "H:mm"
            StripStyle5.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle5.Font.Name = "Arial"
            StripStyle6.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle6.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle6.Font.Name = "Arial"
            WorkSheet3.ItemStyles.Add(StripStyle5)
            WorkSheet3.ItemStyles.Add(StripStyle6)
            WorkSheet3.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet3.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet3.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet3.Options.DefaultFont.Name = "Arial"
            WorkSheet3.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet3.Options.HeaderFormat.Font.Bold = True
            WorkSheet3.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet3.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet3.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet3.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet3.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet3.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet3.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet3.Options.NoteFormat.Font.Bold = True
            WorkSheet3.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet3.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet3.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet3.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet3.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet3.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet3.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet3.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet3.Options.TitlesFormat.Font.Bold = True
            WorkSheet3.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet3.SheetName = "charts"
            WorkSheet3.SQLCommand = Me.oleDbCommand2
            WorkSheet3.StartDataCol = CType(0, Byte)
            Me.cellExport2.Sheets.Add(WorkSheet3)
            Me.cellExport2.SQLCommand = Me.oleDbCommand1
            '
            'button3
            '
            Me.button3.Location = New System.Drawing.Point(368, 88)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(96, 23)
            Me.button3.TabIndex = 2
            Me.button3.Text = "Misc"
            '
            'label4
            '
            Me.label4.ForeColor = System.Drawing.Color.Blue
            Me.label4.Location = New System.Drawing.Point(352, 136)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(240, 64)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Notes : Not needing to have Microsoft Excel installed on the machine, The Spire.D" & _
            "ataExport can create Excel spreadsheet. "
            '
            'button4
            '
            Me.button4.Location = New System.Drawing.Point(488, 56)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(88, 23)
            Me.button4.TabIndex = 2
            Me.button4.Text = "Chart2"
            '
            'cellExport4
            '
            Me.cellExport4.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport4.AutoFitColWidth = True
            Me.cellExport4.DataFormats.CultureName = "zh-CN"
            Me.cellExport4.DataFormats.Currency = "￥#,###,##0.00"
            Me.cellExport4.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport4.DataFormats.Float = "#,###,##0.00"
            Me.cellExport4.DataFormats.Integer = "#,###,##0"
            Me.cellExport4.DataFormats.Time = "H:mm"
            Me.cellExport4.FileName = "chart2.xls"
            Me.cellExport4.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport4.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport4.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport4.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport4.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport4.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport4.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport4.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport4.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport4.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport4.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport4.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport4.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport4.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport4.SheetOptions.TitlesFormat.Font.Name = "Arial"
            Chart2.AutoColor = False
            Chart2.CategoryLabels.ColX = CType(1, Byte)
            Chart2.CategoryLabels.ColY = CType(1, Byte)
            Chart2.CategoryLabels.RowX = 1
            Chart2.CategoryLabels.RowY = 9
            Chart2.CategoryLabelsColumn = "Name"
            Chart2.DataRangeSheet = "Sheet 2"
            Chart2.Position.AutoPosition.Height = 23
            Chart2.Position.AutoPosition.Left = 1
            Chart2.Position.AutoPosition.Top = 1
            Chart2.Position.AutoPosition.Width = 11
            Chart2.Position.CustomPosition.X1 = CType(1, Byte)
            Chart2.Position.CustomPosition.X2 = CType(15, Byte)
            Chart2.Position.CustomPosition.Y1 = 1
            Chart2.Position.CustomPosition.Y2 = 30
            ChartSeries2.Color = Spire.DataExport.XLS.CellColor.Tan
            ChartSeries2.DataColumn = "Area"
            ChartSeries2.DataRangeSheet = "Sheet 2"
            ChartSeries2.Title = "Population"
            Chart2.Series.Add(ChartSeries2)
            Chart2.Style = Spire.DataExport.XLS.ChartStyle.Bar
            Chart2.Title = "Chart demo"
            WorkSheet4.Charts.Add(Chart2)
            WorkSheet4.DataExported = False
            WorkSheet4.FormatsExport.CultureName = "zh-CN"
            WorkSheet4.FormatsExport.Currency = "￥#,###,##0.00"
            WorkSheet4.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet4.FormatsExport.Float = "#,###,##0.00"
            WorkSheet4.FormatsExport.Integer = "#,###,##0"
            WorkSheet4.FormatsExport.Time = "H:mm"
            WorkSheet4.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet4.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet4.Options.DefaultFont.Name = "Arial"
            WorkSheet4.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet4.Options.HeaderFormat.Font.Bold = True
            WorkSheet4.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet4.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet4.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet4.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet4.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet4.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet4.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet4.Options.NoteFormat.Font.Bold = True
            WorkSheet4.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet4.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet4.Options.TitlesFormat.Font.Bold = True
            WorkSheet4.Options.TitlesFormat.Font.Name = "Times New Roman"
            WorkSheet4.Options.TitlesFormat.Font.Size = 13.0!
            WorkSheet4.SheetName = "charts"
            WorkSheet4.StartDataCol = CType(0, Byte)
            WorkSheet5.AutoFitColWidth = True
            WorkSheet5.FormatsExport.CultureName = "zh-CN"
            WorkSheet5.FormatsExport.Currency = "￥#,###,##0.00"
            WorkSheet5.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet5.FormatsExport.Float = "#,###,##0.00"
            WorkSheet5.FormatsExport.Integer = "#,###,##0"
            WorkSheet5.FormatsExport.Time = "H:mm"
            StripStyle7.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle7.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle7.Font.Name = "Arial"
            StripStyle8.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle8.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle8.Font.Name = "Arial"
            WorkSheet5.ItemStyles.Add(StripStyle7)
            WorkSheet5.ItemStyles.Add(StripStyle8)
            WorkSheet5.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet5.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet5.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet5.Options.DefaultFont.Name = "Arial"
            WorkSheet5.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet5.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet5.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet5.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet5.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet5.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet5.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet5.Options.NoteFormat.Font.Bold = True
            WorkSheet5.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet5.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet5.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet5.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet5.Options.TitlesFormat.Font.Bold = True
            WorkSheet5.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet5.SheetName = "Sheet 2"
            WorkSheet5.SQLCommand = Me.oleDbCommand2
            WorkSheet5.StartDataCol = CType(0, Byte)
            Me.cellExport4.Sheets.Add(WorkSheet4)
            Me.cellExport4.Sheets.Add(WorkSheet5)
            Me.cellExport4.SQLCommand = Me.oleDbCommand1
            '
            'button5
            '
            Me.button5.Location = New System.Drawing.Point(488, 24)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(88, 23)
            Me.button5.TabIndex = 5
            Me.button5.Text = "Formula"
            '
            'cellExport5
            '
            Me.cellExport5.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport5.ColumnsWidth.AddRange(New Object() {"100", "200"})
            Me.cellExport5.DataExported = False
            Me.cellExport5.DataFormats.CultureName = "zh-CN"
            Me.cellExport5.DataFormats.Currency = "￥#,###,##0.00"
            Me.cellExport5.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport5.DataFormats.Float = "#,###,##0.00"
            Me.cellExport5.DataFormats.Integer = "#,###,##0"
            Me.cellExport5.DataFormats.Time = "H:mm"
            Me.cellExport5.FileName = "formula.xls"
            Me.cellExport5.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport5.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport5.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport5.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport5.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport5.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport5.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport5.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport5.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport5.SheetOptions.TitlesFormat.Font.Name = "Arial"
            Me.cellExport5.SQLCommand = Me.oleDbCommand1
            '
            'cellExport3
            '
            Me.cellExport3.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport3.DataFormats.CultureName = "zh-CN"
            Me.cellExport3.DataFormats.Currency = "￥#,###,##0.00"
            Me.cellExport3.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport3.DataFormats.Float = "#,###,##0.00"
            Me.cellExport3.DataFormats.Integer = "#,###,##0"
            Me.cellExport3.DataFormats.Time = "H:mm"
            Me.cellExport3.FileName = "misc.xls"
            Me.cellExport3.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport3.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport3.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport3.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport3.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport3.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport3.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport3.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport3.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent
            Me.cellExport3.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport3.SheetOptions.TitlesFormat.Font.Name = "Arial"
            ColumnFormat1.FieldName = "PartNo"
            ColumnFormat1.Font.Bold = True
            ColumnFormat1.Font.Name = "Arial"
            ColumnFormat2.FieldName = "VendorNo"
            ColumnFormat2.Font.Color = Spire.DataExport.XLS.CellColor.Color1
            ColumnFormat2.Font.Italic = True
            ColumnFormat2.Font.Name = "Arial"
            ColumnFormat3.FieldName = "Description"
            ColumnFormat3.Font.Name = "Arial"
            ColumnFormat3.Font.Strikeout = True
            ColumnFormat3.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.DoubleAccounting
            ColumnFormat4.FieldName = "OnHand"
            ColumnFormat4.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            ColumnFormat4.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.Pink
            ColumnFormat4.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinGorizontal
            ColumnFormat4.Font.Name = "Arial"
            ColumnFormat5.FieldName = "ListPrice"
            ColumnFormat5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            ColumnFormat5.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.SkyBlue
            ColumnFormat5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinVertical
            ColumnFormat5.Font.Name = "Arial"
            WorkSheet6.ColumnFormats.Add(ColumnFormat1)
            WorkSheet6.ColumnFormats.Add(ColumnFormat2)
            WorkSheet6.ColumnFormats.Add(ColumnFormat3)
            WorkSheet6.ColumnFormats.Add(ColumnFormat4)
            WorkSheet6.ColumnFormats.Add(ColumnFormat5)
            WorkSheet6.FormatsExport.CultureName = "zh-CN"
            WorkSheet6.FormatsExport.Currency = "￥#,###,##0.00"
            WorkSheet6.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet6.FormatsExport.Float = "#,###,##0.00"
            WorkSheet6.FormatsExport.Integer = "#,###,##0"
            WorkSheet6.FormatsExport.Time = "H:mm"
            WorkSheet6.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet6.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet6.Options.DefaultFont.Name = "Arial"
            WorkSheet6.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet6.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet6.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet6.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet6.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet6.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet6.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet6.Options.NoteFormat.Font.Bold = True
            WorkSheet6.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet6.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet6.Options.TitlesFormat.Font.Bold = True
            WorkSheet6.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet6.SheetName = "Sheet 1"
            WorkSheet6.SQLCommand = Me.oleDbCommand1
            WorkSheet6.StartDataCol = CType(0, Byte)
            Me.cellExport3.Sheets.Add(WorkSheet6)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.ClientSize = New System.Drawing.Size(616, 398)
            Me.Controls.Add(Me.button5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.btnAbout)
            Me.Controls.Add(Me.btnRun)
            Me.Controls.Add(Me.dgDetail)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Cell demo"
            Me.groupBox1.ResumeLayout(False)
            CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1)
        End Sub

        Private Sub LoadData()
            oleDbConnection1.ConnectionString = txtConnectString.Text
            oleDbCommand1.CommandText = txtCommandText.Text
            Me.oleDbCommand2.CommandText = txtCommandTxt1.Text
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand1)
            Try
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgDetail.DataSource = dt
            Finally
                CType(da, IDisposable).Dispose()
            End Try
        End Sub

        Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
            oleDbConnection1.Open()
            Try
                cellExport1.SaveToFile()
            Finally
                Me.oleDbConnection1.Close()
            End Try
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            LoadData()
        End Sub

        Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
            Close()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            oleDbConnection1.Open()
            Try
                cellExport2.SaveToFile()
            Finally
                Me.oleDbConnection1.Close()
            End Try
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
            oleDbConnection1.Open()
            Try
                cellExport3.SaveToFile()
            Finally
                Me.oleDbConnection1.Close()
            End Try

        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
            oleDbConnection1.Open()
            Try
                cellExport4.SaveToFile()
            Finally
                Me.oleDbConnection1.Close()
            End Try

        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
            Dim currentRow As Integer = 1
            Dim firstCol As UInt16 = Convert.ToUInt16(1)
            Dim secondCol As UInt16 = Convert.ToUInt16(2)
            Dim currentFormula As String = String.Empty

            Dim cell As cell = Nothing

            cellExport5.Cells.Clear()
            cellExport5.SetColumnWidth(System.Convert.ToUInt16(1), System.Convert.ToUInt16(32))
            cellExport5.SetColumnWidth(System.Convert.ToUInt16(2), System.Convert.ToUInt16(16))
            cellExport5.SetColumnWidth(System.Convert.ToUInt16(3), System.Convert.ToUInt16(16))

            cell = cellExport5.AddString(System.Convert.ToUInt16(1), System.Convert.ToUInt16(currentRow), "Examples of formulas :")
            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            cell = cellExport5.AddString(System.Convert.ToUInt16(1), System.Convert.ToUInt16(currentRow), "Test data:")
            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            'test data
            cellExport5.AddNumeric(System.Convert.ToUInt16(2), System.Convert.ToUInt16(currentRow), 7.3)
            cellExport5.AddNumeric(System.Convert.ToUInt16(3), System.Convert.ToUInt16(currentRow), 5)
            cellExport5.AddNumeric(System.Convert.ToUInt16(4), System.Convert.ToUInt16(currentRow), 8.2)
            cellExport5.AddNumeric(System.Convert.ToUInt16(5), System.Convert.ToUInt16(currentRow), 4)
            cellExport5.AddNumeric(System.Convert.ToUInt16(6), System.Convert.ToUInt16(currentRow), 3)
            cellExport5.AddNumeric(System.Convert.ToUInt16(7), System.Convert.ToUInt16(currentRow), 11.3)
            currentRow += 1
            currentRow += 1


            cell = cellExport5.AddString(Convert.ToUInt16(1), Convert.ToUInt16(currentRow), "Formulas")
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            cell = cellExport5.AddString(secondCol, Convert.ToUInt16(currentRow), "Results")
            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            'str.
            currentFormula = "=""hello"""
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), "=""hello""")
            cellExport5.AddFormula(Convert.ToUInt16(3), Convert.ToUInt16(currentRow), "=""" & ChrW(20320) & ChrW(22909) + """")
            currentRow += 1



            'int.
            currentFormula = "=300"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' float
            currentFormula = "=3389.639421"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1


            'bool.
            currentFormula = "=false"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=1+2+3+4+5-6-7+8-9"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=33*3/4-2+10"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' sheet reference
            currentFormula = "=Sheet1!$B$3"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' sheet area reference
            currentFormula = "=AVERAGE(Sheet1!$D$3:G$3)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' Functions
            currentFormula = "=Count(3,5,8,10,2,34)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1


            currentFormula = "=NOW()"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SECOND(11)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MINUTE(12)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MONTH(9)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=DAY(10)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=TIME(4,5,7)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=DATE(6,4,2)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=RAND()"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=HOUR(12)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=TEXT(""world"", ""$d"")"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MOD(5,3)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=WEEKDAY(3)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=YEAR(23)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=NOT(true)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=OR(true)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=AND(TRUE)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=VALUE(30)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=LEN(""world"")"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MID(""world"",4,2)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=ROUND(7,3)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SIGN(4)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=INT(200)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=ABS(-1.21)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=LN(15)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=EXP(20)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SQRT(40)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=PI()"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=COS(9)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SIN(45)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MAX(10,30)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MIN(5,7)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=AVERAGE(12,45)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SUM(18,29)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=IF(4,2,2)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SUBTOTAL(3,Sheet1!B2:E3)"
            cellExport5.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport5.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1
            Me.cellExport5.SaveToFile()
        End Sub

        Private Sub cellExport1_GetDataParams(ByVal sender As Object, ByVal e As Spire.DataExport.EventArgs.DataParamsEventArgs) Handles cellExport1.GetDataParams, cellExport3.GetDataParams
            If (e.Sheet = 0) AndAlso (e.Col = 6) Then
                e.FormatText = cellExport1.DataFormats.Currency
            End If
        End Sub

    End Class
End Namespace
