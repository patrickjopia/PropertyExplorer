<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewRecords_bkp
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ProperytxtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyxdbDataSet1 = New PropertyExplorer.propertyxdbDataSet()
        CType(Me.ProperytxtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProperytxtblBindingSource, "Date", True))
        Me.TextBox2.Location = New System.Drawing.Point(36, 237)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 0
        '
        'ProperytxtblBindingSource
        '
        Me.ProperytxtblBindingSource.DataMember = "properytxtbl"
        Me.ProperytxtblBindingSource.DataSource = Me.PropertyxdbDataSet1
        '
        'PropertyxdbDataSet1
        '
        Me.PropertyxdbDataSet1.DataSetName = "propertyxdbDataSet"
        Me.PropertyxdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmViewRecords_bkp
        '
        Me.ClientSize = New System.Drawing.Size(836, 475)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "frmViewRecords_bkp"
        CType(Me.ProperytxtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PropertyxdbDataSet As propertyxdbDataSet
    Friend WithEvents PropertxtblBindingSource As BindingSource
    Friend WithEvents PropertxtblTableAdapter As propertyxdbDataSetTableAdapters.propertyxtblTableAdapter
    Friend WithEvents PropertyIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPAIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequestingUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypePropertyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocCityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocBSCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocStreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocFullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValPerSQMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnExport As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PropertyxdbDataSet1 As propertyxdbDataSet
    Friend WithEvents ProperytxtblBindingSource As BindingSource
End Class
