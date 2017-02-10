<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RETR = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.logdata = New System.Windows.Forms.SplitContainer()
        Me.logView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exportData = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.userSearch = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.logdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logdata.Panel1.SuspendLayout()
        Me.logdata.Panel2.SuspendLayout()
        Me.logdata.SuspendLayout()
        CType(Me.logView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(511, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RETR
        '
        Me.RETR.AutoSize = True
        Me.RETR.Location = New System.Drawing.Point(3, 31)
        Me.RETR.Name = "RETR"
        Me.RETR.Size = New System.Drawing.Size(96, 17)
        Me.RETR.TabIndex = 3
        Me.RETR.Text = "Retrieved Only"
        Me.RETR.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.userSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RETR)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.logdata)
        Me.SplitContainer1.Panel2MinSize = 50
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 561)
        Me.SplitContainer1.SplitterDistance = 55
        Me.SplitContainer1.TabIndex = 5
        '
        'logdata
        '
        Me.logdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logdata.Location = New System.Drawing.Point(0, 0)
        Me.logdata.Name = "logdata"
        Me.logdata.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'logdata.Panel1
        '
        Me.logdata.Panel1.Controls.Add(Me.logView)
        '
        'logdata.Panel2
        '
        Me.logdata.Panel2.Controls.Add(Me.exportData)
        Me.logdata.Size = New System.Drawing.Size(784, 502)
        Me.logdata.SplitterDistance = 445
        Me.logdata.TabIndex = 1
        '
        'logView
        '
        Me.logView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.logView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.logView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.logView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logView.Location = New System.Drawing.Point(0, 0)
        Me.logView.Name = "logView"
        Me.logView.Size = New System.Drawing.Size(784, 445)
        Me.logView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.FillWeight = 20.0!
        Me.Column1.HeaderText = "uid"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.FillWeight = 20.0!
        Me.Column2.HeaderText = "date"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.FillWeight = 20.0!
        Me.Column3.HeaderText = "user"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.FillWeight = 20.0!
        Me.Column4.HeaderText = "ip"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.FillWeight = 80.0!
        Me.Column5.HeaderText = "message"
        Me.Column5.Name = "Column5"
        '
        'exportData
        '
        Me.exportData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exportData.Location = New System.Drawing.Point(0, 0)
        Me.exportData.Name = "exportData"
        Me.exportData.Size = New System.Drawing.Size(784, 53)
        Me.exportData.TabIndex = 0
        Me.exportData.Text = "Export Selected"
        Me.exportData.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(258, 31)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(32, 13)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "User:"
        '
        'userSearch
        '
        Me.userSearch.Location = New System.Drawing.Point(296, 29)
        Me.userSearch.Name = "userSearch"
        Me.userSearch.Size = New System.Drawing.Size(131, 20)
        Me.userSearch.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Choose Log File"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.logdata.Panel1.ResumeLayout(False)
        Me.logdata.Panel2.ResumeLayout(False)
        CType(Me.logdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logdata.ResumeLayout(False)
        CType(Me.logView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RETR As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents logdata As SplitContainer
    Friend WithEvents logView As DataGridView
    Friend WithEvents exportData As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents userSearch As TextBox
    Friend WithEvents lblUser As Label
End Class
