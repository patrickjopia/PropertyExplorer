<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigCheck
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PropertyxdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyxdbDataSet = New PropertyExplorer.propertyxdbDataSet()
        Me.PropertxtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertxtblTableAdapter = New PropertyExplorer.propertyxdbDataSetTableAdapters.propertxtblTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertxtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MySQL"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(186, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "MySQL Connection"
        '
        'TextBox2
        '
        Me.TextBox2.ForeColor = System.Drawing.Color.Gray
        Me.TextBox2.Location = New System.Drawing.Point(186, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "propertyXDb"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database Name"
        '
        'TextBox3
        '
        Me.TextBox3.ForeColor = System.Drawing.Color.Gray
        Me.TextBox3.Location = New System.Drawing.Point(186, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(152, 20)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "propertyXTbl"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Table Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Connect to MySQL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Create Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(40, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 37)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Create Table"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PropertxtblBindingSource, "propertyID", True))
        Me.DataGridView1.DataSource = Me.PropertyxdbDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(362, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(426, 285)
        Me.DataGridView1.TabIndex = 9
        '
        'PropertyxdbDataSetBindingSource
        '
        Me.PropertyxdbDataSetBindingSource.DataSource = Me.PropertyxdbDataSet
        Me.PropertyxdbDataSetBindingSource.Position = 0
        '
        'PropertyxdbDataSet
        '
        Me.PropertyxdbDataSet.DataSetName = "propertyxdbDataSet"
        Me.PropertyxdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertxtblBindingSource
        '
        Me.PropertxtblBindingSource.DataMember = "propertxtbl"
        Me.PropertxtblBindingSource.DataSource = Me.PropertyxdbDataSet
        '
        'PropertxtblTableAdapter
        '
        Me.PropertxtblTableAdapter.ClearBeforeFill = True
        '
        'frmConfigCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConfigCheck"
        Me.Text = "Configuration Check"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertxtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PropertyxdbDataSetBindingSource As BindingSource
    Friend WithEvents PropertyxdbDataSet As propertyxdbDataSet
    Friend WithEvents PropertxtblBindingSource As BindingSource
    Friend WithEvents PropertxtblTableAdapter As propertyxdbDataSetTableAdapters.propertxtblTableAdapter
End Class
