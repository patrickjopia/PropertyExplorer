<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRecords
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PropertyIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPAIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestingUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypePropertyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocBSCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocStreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocFullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValPerSQMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyxtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyxdbDataSet = New PropertyExplorer.propertyxdbDataSet()
        Me.PropertyxtblTableAdapter = New PropertyExplorer.propertyxdbDataSetTableAdapters.propertyxtblTableAdapter()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PropertyIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.IPAIDataGridViewTextBoxColumn, Me.RequestingUnitDataGridViewTextBoxColumn, Me.AccountNameDataGridViewTextBoxColumn, Me.TypePropertyDataGridViewTextBoxColumn, Me.LocCityDataGridViewTextBoxColumn, Me.LocBSCDataGridViewTextBoxColumn, Me.LocStreetDataGridViewTextBoxColumn, Me.LocFullDataGridViewTextBoxColumn, Me.ValPerSQMDataGridViewTextBoxColumn, Me.RegdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PropertyxtblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(747, 435)
        Me.DataGridView1.TabIndex = 0
        '
        'PropertyIDDataGridViewTextBoxColumn
        '
        Me.PropertyIDDataGridViewTextBoxColumn.DataPropertyName = "propertyID"
        Me.PropertyIDDataGridViewTextBoxColumn.HeaderText = "propertyID"
        Me.PropertyIDDataGridViewTextBoxColumn.Name = "PropertyIDDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'IPAIDataGridViewTextBoxColumn
        '
        Me.IPAIDataGridViewTextBoxColumn.DataPropertyName = "IPAI"
        Me.IPAIDataGridViewTextBoxColumn.HeaderText = "IPAI"
        Me.IPAIDataGridViewTextBoxColumn.Name = "IPAIDataGridViewTextBoxColumn"
        '
        'RequestingUnitDataGridViewTextBoxColumn
        '
        Me.RequestingUnitDataGridViewTextBoxColumn.DataPropertyName = "RequestingUnit"
        Me.RequestingUnitDataGridViewTextBoxColumn.HeaderText = "RequestingUnit"
        Me.RequestingUnitDataGridViewTextBoxColumn.Name = "RequestingUnitDataGridViewTextBoxColumn"
        '
        'AccountNameDataGridViewTextBoxColumn
        '
        Me.AccountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName"
        Me.AccountNameDataGridViewTextBoxColumn.HeaderText = "AccountName"
        Me.AccountNameDataGridViewTextBoxColumn.Name = "AccountNameDataGridViewTextBoxColumn"
        '
        'TypePropertyDataGridViewTextBoxColumn
        '
        Me.TypePropertyDataGridViewTextBoxColumn.DataPropertyName = "TypeProperty"
        Me.TypePropertyDataGridViewTextBoxColumn.HeaderText = "TypeProperty"
        Me.TypePropertyDataGridViewTextBoxColumn.Name = "TypePropertyDataGridViewTextBoxColumn"
        '
        'LocCityDataGridViewTextBoxColumn
        '
        Me.LocCityDataGridViewTextBoxColumn.DataPropertyName = "LocCity"
        Me.LocCityDataGridViewTextBoxColumn.HeaderText = "LocCity"
        Me.LocCityDataGridViewTextBoxColumn.Name = "LocCityDataGridViewTextBoxColumn"
        '
        'LocBSCDataGridViewTextBoxColumn
        '
        Me.LocBSCDataGridViewTextBoxColumn.DataPropertyName = "LocBSC"
        Me.LocBSCDataGridViewTextBoxColumn.HeaderText = "LocBSC"
        Me.LocBSCDataGridViewTextBoxColumn.Name = "LocBSCDataGridViewTextBoxColumn"
        '
        'LocStreetDataGridViewTextBoxColumn
        '
        Me.LocStreetDataGridViewTextBoxColumn.DataPropertyName = "LocStreet"
        Me.LocStreetDataGridViewTextBoxColumn.HeaderText = "LocStreet"
        Me.LocStreetDataGridViewTextBoxColumn.Name = "LocStreetDataGridViewTextBoxColumn"
        '
        'LocFullDataGridViewTextBoxColumn
        '
        Me.LocFullDataGridViewTextBoxColumn.DataPropertyName = "LocFull"
        Me.LocFullDataGridViewTextBoxColumn.HeaderText = "LocFull"
        Me.LocFullDataGridViewTextBoxColumn.Name = "LocFullDataGridViewTextBoxColumn"
        '
        'ValPerSQMDataGridViewTextBoxColumn
        '
        Me.ValPerSQMDataGridViewTextBoxColumn.DataPropertyName = "ValPerSQM"
        Me.ValPerSQMDataGridViewTextBoxColumn.HeaderText = "ValPerSQM"
        Me.ValPerSQMDataGridViewTextBoxColumn.Name = "ValPerSQMDataGridViewTextBoxColumn"
        '
        'RegdateDataGridViewTextBoxColumn
        '
        Me.RegdateDataGridViewTextBoxColumn.DataPropertyName = "reg_date"
        Me.RegdateDataGridViewTextBoxColumn.HeaderText = "reg_date"
        Me.RegdateDataGridViewTextBoxColumn.Name = "RegdateDataGridViewTextBoxColumn"
        '
        'PropertyxtblBindingSource
        '
        Me.PropertyxtblBindingSource.DataMember = "propertyxtbl"
        Me.PropertyxtblBindingSource.DataSource = Me.PropertyxdbDataSet
        '
        'PropertyxdbDataSet
        '
        Me.PropertyxdbDataSet.DataSetName = "propertyxdbDataSet"
        Me.PropertyxdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertyxtblTableAdapter
        '
        Me.PropertyxtblTableAdapter.ClearBeforeFill = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(333, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(139, 20)
        Me.txtSearch.TabIndex = 1
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Agricultural", "Commercial", "Condominium", "Residential"})
        Me.cmbSearch.Location = New System.Drawing.Point(512, 20)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(138, 21)
        Me.cmbSearch.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(111, 15)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(95, 25)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(512, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 4
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(15, 72)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(39, 13)
        Me.labelStatus.TabIndex = 5
        Me.labelStatus.Text = "Label1"
        '
        'frmViewRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmViewRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmViewRecord"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PropertyxdbDataSet As propertyxdbDataSet
    Friend WithEvents PropertyxtblBindingSource As BindingSource
    Friend WithEvents PropertyxtblTableAdapter As propertyxdbDataSetTableAdapters.propertyxtblTableAdapter
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
    Friend WithEvents ValPerSQMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
