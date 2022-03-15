<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRecord
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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.PropertyxtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyxdbDataSet = New PropertyExplorer.propertyxdbDataSet()
        Me.txtIPAI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRequesting = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPropertyType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLocStreet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLocBSC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocCity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVALSQM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddProperty = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtLocFull = New System.Windows.Forms.RichTextBox()
        Me.labelProperty = New System.Windows.Forms.Label()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PropertyxtblTableAdapter = New PropertyExplorer.propertyxdbDataSetTableAdapters.propertyxtblTableAdapter()
        CType(Me.PropertyxtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "Date", True))
<<<<<<< HEAD
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PropertyxtblBindingSource, "Date", True))
=======
>>>>>>> f54819e443c85e5ff52398d5c81defd02cc2ea52
        Me.txtDate.Location = New System.Drawing.Point(182, 55)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(178, 20)
        Me.txtDate.TabIndex = 1
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
        'txtIPAI
        '
        Me.txtIPAI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "IPAI", True))
        Me.txtIPAI.Location = New System.Drawing.Point(182, 92)
        Me.txtIPAI.Name = "txtIPAI"
        Me.txtIPAI.Size = New System.Drawing.Size(178, 20)
        Me.txtIPAI.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IPAI File No"
        '
        'txtRequesting
        '
        Me.txtRequesting.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "RequestingUnit", True))
        Me.txtRequesting.Location = New System.Drawing.Point(182, 135)
        Me.txtRequesting.Name = "txtRequesting"
        Me.txtRequesting.Size = New System.Drawing.Size(178, 20)
        Me.txtRequesting.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Requesting Unit"
        '
        'txtAccount
        '
        Me.txtAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "AccountName", True))
        Me.txtAccount.Location = New System.Drawing.Point(182, 176)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(178, 20)
        Me.txtAccount.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Account Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Type of Property"
        '
        'cmbPropertyType
        '
        Me.cmbPropertyType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "TypeProperty", True))
        Me.cmbPropertyType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PropertyxtblBindingSource, "TypeProperty", True))
        Me.cmbPropertyType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PropertyxtblBindingSource, "TypeProperty", True))
        Me.cmbPropertyType.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PropertyxtblBindingSource, "TypeProperty", True))
        Me.cmbPropertyType.FormattingEnabled = True
        Me.cmbPropertyType.Items.AddRange(New Object() {"Agricultural", "Commercial", "Condominium", "Residential"})
        Me.cmbPropertyType.Location = New System.Drawing.Point(182, 214)
        Me.cmbPropertyType.Name = "cmbPropertyType"
        Me.cmbPropertyType.Size = New System.Drawing.Size(178, 21)
        Me.cmbPropertyType.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLocStreet)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtLocBSC)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLocCity)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 153)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'txtLocStreet
        '
        Me.txtLocStreet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "LocStreet", True))
        Me.txtLocStreet.Location = New System.Drawing.Point(181, 115)
        Me.txtLocStreet.Name = "txtLocStreet"
        Me.txtLocStreet.Size = New System.Drawing.Size(136, 20)
        Me.txtLocStreet.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Street Name"
        '
        'txtLocBSC
        '
        Me.txtLocBSC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "LocBSC", True))
        Me.txtLocBSC.Location = New System.Drawing.Point(181, 77)
        Me.txtLocBSC.Name = "txtLocBSC"
        Me.txtLocBSC.Size = New System.Drawing.Size(136, 20)
        Me.txtLocBSC.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Brgy / Subdivision / Condo Project"
        '
        'txtLocCity
        '
        Me.txtLocCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "LocCity", True))
        Me.txtLocCity.Location = New System.Drawing.Point(181, 35)
        Me.txtLocCity.Name = "txtLocCity"
        Me.txtLocCity.Size = New System.Drawing.Size(136, 20)
        Me.txtLocCity.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "City / Municipality"
        '
        'txtVALSQM
        '
        Me.txtVALSQM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "ValPerSQM", True))
        Me.txtVALSQM.Location = New System.Drawing.Point(182, 441)
        Me.txtVALSQM.Name = "txtVALSQM"
        Me.txtVALSQM.Size = New System.Drawing.Size(178, 20)
        Me.txtVALSQM.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Value per Square Meter"
        '
        'btnAddProperty
        '
        Me.btnAddProperty.Location = New System.Drawing.Point(46, 492)
        Me.btnAddProperty.Name = "btnAddProperty"
        Me.btnAddProperty.Size = New System.Drawing.Size(82, 35)
        Me.btnAddProperty.TabIndex = 13
        Me.btnAddProperty.Text = "Add Property"
        Me.btnAddProperty.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtLocFull)
        Me.GroupBox2.Controls.Add(Me.labelProperty)
        Me.GroupBox2.Controls.Add(Me.labelStatus)
        Me.GroupBox2.Location = New System.Drawing.Point(458, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 302)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'rtLocFull
        '
        Me.rtLocFull.Location = New System.Drawing.Point(28, 153)
        Me.rtLocFull.Name = "rtLocFull"
        Me.rtLocFull.Size = New System.Drawing.Size(178, 77)
        Me.rtLocFull.TabIndex = 2
        Me.rtLocFull.Text = ""
        '
        'labelProperty
        '
        Me.labelProperty.AutoSize = True
        Me.labelProperty.Location = New System.Drawing.Point(19, 120)
        Me.labelProperty.Name = "labelProperty"
        Me.labelProperty.Size = New System.Drawing.Size(45, 13)
        Me.labelProperty.TabIndex = 1
        Me.labelProperty.Text = "Label10"
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(20, 81)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(45, 13)
        Me.labelStatus.TabIndex = 0
        Me.labelStatus.Text = "Label10"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PropertyxtblTableAdapter
        '
        Me.PropertyxtblTableAdapter.ClearBeforeFill = True
        '
        'frmAddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAddProperty)
        Me.Controls.Add(Me.txtVALSQM)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbPropertyType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRequesting)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIPAI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Property Records"
        CType(Me.PropertyxtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtIPAI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRequesting As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbPropertyType As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLocStreet As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLocBSC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLocCity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVALSQM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddProperty As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labelProperty As Label
    Friend WithEvents labelStatus As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents rtLocFull As RichTextBox
    Friend WithEvents PropertyxdbDataSet As propertyxdbDataSet
    Friend WithEvents PropertyxtblBindingSource As BindingSource
    Friend WithEvents PropertyxtblTableAdapter As propertyxdbDataSetTableAdapters.propertyxtblTableAdapter
End Class
