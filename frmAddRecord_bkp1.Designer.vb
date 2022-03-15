<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddRecord_bkp1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PropertyxtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyxdbDataSet1 = New PropertyExplorer.propertyxdbDataSet()
        CType(Me.PropertyxtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyxdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertyxtblBindingSource, "Date", True))
        Me.TextBox1.Location = New System.Drawing.Point(21, 210)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 0
        '
        'PropertyxtblBindingSource
        '
        Me.PropertyxtblBindingSource.DataMember = "propertyxtbl"
        Me.PropertyxtblBindingSource.DataSource = Me.PropertyxdbDataSet1
        '
        'PropertyxdbDataSet1
        '
        Me.PropertyxdbDataSet1.DataSetName = "propertyxdbDataSet"
        Me.PropertyxdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmAddRecord
        '
        Me.ClientSize = New System.Drawing.Size(748, 452)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmAddRecord"
        CType(Me.PropertyxtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyxdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate As TextBox
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
    Friend WithEvents txtLocBrgy As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLocCity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVALSQM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents txtLocationFull As TextBox
    Friend WithEvents txtIPAI As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PropertyxdbDataSet1 As propertyxdbDataSet
    Friend WithEvents PropertyxtblBindingSource As BindingSource
End Class
