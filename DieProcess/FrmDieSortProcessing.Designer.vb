Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDieSortProcessing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip = New MenuStrip()
        File = New ToolStripMenuItem()
        OpenMenuItem = New ToolStripMenuItem()
        ExitMenuItem = New ToolStripMenuItem()
        Show = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Counter0 = New Label()
        Counter5 = New Label()
        Counter6 = New Label()
        Counter2 = New Label()
        Counter1 = New Label()
        twoGridView = New DataGridView()
        twoRow = New DataGridViewTextBoxColumn()
        twoColumn = New DataGridViewTextBoxColumn()
        oneGridView = New DataGridView()
        oneRow = New DataGridViewTextBoxColumn()
        oneColumn = New DataGridViewTextBoxColumn()
        sixGridView = New DataGridView()
        sixRow = New DataGridViewTextBoxColumn()
        sixColumn = New DataGridViewTextBoxColumn()
        Bin6 = New Label()
        Bin2 = New Label()
        Bin1 = New Label()
        MenuStrip.SuspendLayout()
        CType(twoGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(oneGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(sixGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.GripStyle = ToolStripGripStyle.Visible
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {File, Show})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(6, 4, 0, 4)
        MenuStrip.RenderMode = ToolStripRenderMode.System
        MenuStrip.Size = New Size(1575, 49)
        MenuStrip.TabIndex = 0
        MenuStrip.Text = "File"
        ' 
        ' File
        ' 
        File.DropDownItems.AddRange(New ToolStripItem() {OpenMenuItem, ExitMenuItem})
        File.Name = "File"
        File.Size = New Size(80, 41)
        File.Text = "File"
        ' 
        ' OpenMenuItem
        ' 
        OpenMenuItem.Name = "OpenMenuItem"
        OpenMenuItem.Size = New Size(232, 48)
        OpenMenuItem.Text = "Open"
        ' 
        ' ExitMenuItem
        ' 
        ExitMenuItem.Name = "ExitMenuItem"
        ExitMenuItem.Size = New Size(232, 48)
        ExitMenuItem.Text = "Exit"
        ' 
        ' Show
        ' 
        Show.Name = "Show"
        Show.Size = New Size(104, 41)
        Show.Text = "Show"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 115)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 37)
        Label1.TabIndex = 1
        Label1.Text = "Number of 0:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 174)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 37)
        Label2.TabIndex = 2
        Label2.Text = "Number of 5:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 235)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 37)
        Label3.TabIndex = 3
        Label3.Text = "Number of 6:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 294)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 37)
        Label4.TabIndex = 4
        Label4.Text = "Number of 2:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 359)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 37)
        Label5.TabIndex = 5
        Label5.Text = "Number of 1:"
        ' 
        ' Counter0
        ' 
        Counter0.AutoSize = True
        Counter0.Location = New Point(216, 115)
        Counter0.Margin = New Padding(6, 0, 6, 0)
        Counter0.Name = "Counter0"
        Counter0.Size = New Size(32, 37)
        Counter0.TabIndex = 6
        Counter0.Text = "0"
        ' 
        ' Counter5
        ' 
        Counter5.AutoSize = True
        Counter5.Location = New Point(214, 174)
        Counter5.Margin = New Padding(6, 0, 6, 0)
        Counter5.Name = "Counter5"
        Counter5.Size = New Size(32, 37)
        Counter5.TabIndex = 7
        Counter5.Text = "0"
        ' 
        ' Counter6
        ' 
        Counter6.AutoSize = True
        Counter6.Location = New Point(214, 235)
        Counter6.Margin = New Padding(6, 0, 6, 0)
        Counter6.Name = "Counter6"
        Counter6.Size = New Size(32, 37)
        Counter6.TabIndex = 8
        Counter6.Text = "0"
        ' 
        ' Counter2
        ' 
        Counter2.AutoSize = True
        Counter2.Location = New Point(216, 294)
        Counter2.Margin = New Padding(6, 0, 6, 0)
        Counter2.Name = "Counter2"
        Counter2.Size = New Size(32, 37)
        Counter2.TabIndex = 9
        Counter2.Text = "0"
        ' 
        ' Counter1
        ' 
        Counter1.AutoSize = True
        Counter1.Location = New Point(214, 359)
        Counter1.Margin = New Padding(6, 0, 6, 0)
        Counter1.Name = "Counter1"
        Counter1.Size = New Size(32, 37)
        Counter1.TabIndex = 10
        Counter1.Text = "0"
        ' 
        ' twoGridView
        ' 
        twoGridView.AllowUserToAddRows = False
        twoGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        twoGridView.Columns.AddRange(New DataGridViewColumn() {twoRow, twoColumn})
        twoGridView.Location = New Point(538, 501)
        twoGridView.Margin = New Padding(6, 6, 6, 6)
        twoGridView.Name = "twoGridView"
        twoGridView.ReadOnly = True
        twoGridView.RowHeadersWidth = 51
        twoGridView.RowTemplate.Height = 29
        twoGridView.Size = New Size(488, 457)
        twoGridView.TabIndex = 15
        ' 
        ' twoRow
        ' 
        twoRow.HeaderText = "Row"
        twoRow.MinimumWidth = 6
        twoRow.Name = "twoRow"
        twoRow.ReadOnly = True
        twoRow.Width = 125
        ' 
        ' twoColumn
        ' 
        twoColumn.HeaderText = "Column"
        twoColumn.MinimumWidth = 6
        twoColumn.Name = "twoColumn"
        twoColumn.ReadOnly = True
        twoColumn.Width = 125
        ' 
        ' oneGridView
        ' 
        oneGridView.AllowUserToAddRows = False
        oneGridView.AllowUserToDeleteRows = False
        oneGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        oneGridView.Columns.AddRange(New DataGridViewColumn() {oneRow, oneColumn})
        oneGridView.Location = New Point(1061, 501)
        oneGridView.Margin = New Padding(6, 6, 6, 6)
        oneGridView.Name = "oneGridView"
        oneGridView.ReadOnly = True
        oneGridView.RowHeadersWidth = 51
        oneGridView.RowTemplate.Height = 29
        oneGridView.Size = New Size(469, 457)
        oneGridView.TabIndex = 16
        ' 
        ' oneRow
        ' 
        oneRow.HeaderText = "Row"
        oneRow.MinimumWidth = 6
        oneRow.Name = "oneRow"
        oneRow.ReadOnly = True
        oneRow.Width = 125
        ' 
        ' oneColumn
        ' 
        oneColumn.HeaderText = "Column"
        oneColumn.MinimumWidth = 6
        oneColumn.Name = "oneColumn"
        oneColumn.ReadOnly = True
        oneColumn.Width = 125
        ' 
        ' sixGridView
        ' 
        sixGridView.AllowUserToAddRows = False
        sixGridView.AllowUserToDeleteRows = False
        sixGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sixGridView.Columns.AddRange(New DataGridViewColumn() {sixRow, sixColumn})
        sixGridView.Location = New Point(22, 501)
        sixGridView.Margin = New Padding(6, 6, 6, 6)
        sixGridView.Name = "sixGridView"
        sixGridView.ReadOnly = True
        sixGridView.RowHeadersWidth = 51
        sixGridView.RowTemplate.Height = 29
        sixGridView.Size = New Size(476, 457)
        sixGridView.TabIndex = 17
        ' 
        ' sixRow
        ' 
        sixRow.HeaderText = "Row"
        sixRow.MinimumWidth = 6
        sixRow.Name = "sixRow"
        sixRow.ReadOnly = True
        sixRow.Width = 125
        ' 
        ' sixColumn
        ' 
        sixColumn.HeaderText = "Column"
        sixColumn.MinimumWidth = 6
        sixColumn.Name = "sixColumn"
        sixColumn.ReadOnly = True
        sixColumn.Width = 125
        ' 
        ' Bin6
        ' 
        Bin6.AutoSize = True
        Bin6.Location = New Point(103, 444)
        Bin6.Margin = New Padding(6, 0, 6, 0)
        Bin6.Name = "Bin6"
        Bin6.Size = New Size(291, 37)
        Bin6.TabIndex = 18
        Bin6.Text = "Bin 6 Row-Column Info"
        ' 
        ' Bin2
        ' 
        Bin2.AutoSize = True
        Bin2.Location = New Point(628, 444)
        Bin2.Margin = New Padding(6, 0, 6, 0)
        Bin2.Name = "Bin2"
        Bin2.Size = New Size(291, 37)
        Bin2.TabIndex = 19
        Bin2.Text = "Bin 2 Row-Column Info"
        ' 
        ' Bin1
        ' 
        Bin1.AutoSize = True
        Bin1.Location = New Point(1148, 444)
        Bin1.Margin = New Padding(6, 0, 6, 0)
        Bin1.Name = "Bin1"
        Bin1.Size = New Size(291, 37)
        Bin1.TabIndex = 20
        Bin1.Text = "Bin 1 Row-Column Info"
        ' 
        ' FrmDieSortProcessing
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1575, 1003)
        Controls.Add(Bin1)
        Controls.Add(Bin2)
        Controls.Add(Bin6)
        Controls.Add(sixGridView)
        Controls.Add(oneGridView)
        Controls.Add(twoGridView)
        Controls.Add(Counter1)
        Controls.Add(Counter2)
        Controls.Add(Counter6)
        Controls.Add(Counter5)
        Controls.Add(Counter0)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip)
        MainMenuStrip = MenuStrip
        Margin = New Padding(6, 6, 6, 6)
        Name = "FrmDieSortProcessing"
        Text = "Die Sort Process"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(twoGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(oneGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(sixGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub sixGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles sixGridView.RowPostPaint
        Using b As SolidBrush = New SolidBrush(sixGridView.RowHeadersDefaultCellStyle.ForeColor)
            Dim rowIndex As Int16 = e.RowIndex + 1
            e.Graphics.DrawString(rowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture),
            sixGridView.DefaultCellStyle.Font,
            b,
            e.RowBounds.Location.X + 20,
            e.RowBounds.Location.Y + 4)

        End Using
    End Sub

    Private Sub twoGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles twoGridView.RowPostPaint
        Using b As SolidBrush = New SolidBrush(twoGridView.RowHeadersDefaultCellStyle.ForeColor)
            Dim rowIndex As Int16 = e.RowIndex + 1
            e.Graphics.DrawString(rowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture),
            twoGridView.DefaultCellStyle.Font,
            b,
            e.RowBounds.Location.X + 20,
            e.RowBounds.Location.Y + 4)

        End Using
    End Sub

    Private Sub oneGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles oneGridView.RowPostPaint
        Using b As SolidBrush = New SolidBrush(oneGridView.RowHeadersDefaultCellStyle.ForeColor)
            Dim rowIndex As Int16 = e.RowIndex + 1
            e.Graphics.DrawString(rowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture),
            oneGridView.DefaultCellStyle.Font,
            b,
            e.RowBounds.Location.X + 20,
            e.RowBounds.Location.Y + 4)

        End Using
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents Open As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Counter0 As Label
    Friend WithEvents Counter5 As Label
    Friend WithEvents Counter6 As Label
    Friend WithEvents Counter2 As Label
    Friend WithEvents Counter1 As Label
    Friend WithEvents twoGridView As DataGridView
    Friend WithEvents oneGridView As DataGridView
    Friend WithEvents sixGridView As DataGridView
    Friend WithEvents twoRow As DataGridViewTextBoxColumn
    Friend WithEvents twoColumn As DataGridViewTextBoxColumn
    Friend WithEvents oneRow As DataGridViewTextBoxColumn
    Friend WithEvents oneColumn As DataGridViewTextBoxColumn
    Friend WithEvents sixRow As DataGridViewTextBoxColumn
    Friend WithEvents sixColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bin6 As Label
    Friend WithEvents Bin2 As Label
    Friend WithEvents Bin1 As Label
    Friend WithEvents OpenMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents Show As ToolStripMenuItem
End Class

