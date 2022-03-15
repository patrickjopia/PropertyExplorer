<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnViewProperty = New System.Windows.Forms.Button()
        Me.btnAddProperty = New System.Windows.Forms.Button()
        Me.btnPropertyManage = New System.Windows.Forms.Button()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.topNotifPanel = New System.Windows.Forms.Panel()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sidePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.topNotifPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.Controls.Add(Me.Panel1)
        Me.sidePanel.Controls.Add(Me.logoPanel)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(201, 731)
        Me.sidePanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnViewProperty)
        Me.Panel1.Controls.Add(Me.btnAddProperty)
        Me.Panel1.Controls.Add(Me.btnPropertyManage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 150)
        Me.Panel1.TabIndex = 2
        '
        'btnViewProperty
        '
        Me.btnViewProperty.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewProperty.Location = New System.Drawing.Point(0, 100)
        Me.btnViewProperty.Name = "btnViewProperty"
        Me.btnViewProperty.Size = New System.Drawing.Size(201, 50)
        Me.btnViewProperty.TabIndex = 4
        Me.btnViewProperty.Text = "View Properties"
        Me.btnViewProperty.UseVisualStyleBackColor = True
        '
        'btnAddProperty
        '
        Me.btnAddProperty.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddProperty.Location = New System.Drawing.Point(0, 50)
        Me.btnAddProperty.Name = "btnAddProperty"
        Me.btnAddProperty.Size = New System.Drawing.Size(201, 50)
        Me.btnAddProperty.TabIndex = 3
        Me.btnAddProperty.Text = "Add Property"
        Me.btnAddProperty.UseVisualStyleBackColor = True
        '
        'btnPropertyManage
        '
        Me.btnPropertyManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPropertyManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropertyManage.Location = New System.Drawing.Point(0, 0)
        Me.btnPropertyManage.Name = "btnPropertyManage"
        Me.btnPropertyManage.Size = New System.Drawing.Size(201, 50)
        Me.btnPropertyManage.TabIndex = 2
        Me.btnPropertyManage.Text = "Property Management"
        Me.btnPropertyManage.UseVisualStyleBackColor = True
        '
        'logoPanel
        '
        Me.logoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(201, 105)
        Me.logoPanel.TabIndex = 0
        '
        'topNotifPanel
        '
        Me.topNotifPanel.Controls.Add(Me.Label1)
        Me.topNotifPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topNotifPanel.Location = New System.Drawing.Point(201, 0)
        Me.topNotifPanel.Name = "topNotifPanel"
        Me.topNotifPanel.Size = New System.Drawing.Size(995, 105)
        Me.topNotifPanel.TabIndex = 1
        '
        'contentPanel
        '
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(201, 105)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(995, 626)
        Me.contentPanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 731)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.topNotifPanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.sidePanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.topNotifPanel.ResumeLayout(False)
        Me.topNotifPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnViewProperty As Button
    Friend WithEvents btnAddProperty As Button
    Friend WithEvents btnPropertyManage As Button
    Friend WithEvents logoPanel As Panel
    Friend WithEvents topNotifPanel As Panel
    Friend WithEvents contentPanel As Panel
    Friend WithEvents Label1 As Label
End Class
