Public Class frmAddRecord
    Private Sub btnAddProperty_Click(sender As Object, e As EventArgs) Handles btnAddProperty.Click

        If (txtDate.Text = "") Or (txtIPAI.Text = "") Or (txtRequesting.Text = "") Or (txtAccount.Text = "") Then
            labelStatus.Text = "text file is empty"
        Else


            ''My.Settings.lastIncrement = My.Settings.lastIncrement + 1
            ''My.Settings.Save()

            Call connDBOpen()
            Call propertyAdd()

            ''logging and debugging
            '' Call logRestoAdd("SUCCESS")
            ''  Call writeToLogFile("Restaurant", "SUCCESS", "8/3/2022", strRestoFrmValue)


            ''Call propertyConnClose()


            Me.Refresh()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
<<<<<<< HEAD


        If cmbPropertyType.Text = "" Then
            labelProperty.Text = ""
        Else
            Dim tempStr As String = cmbPropertyType.Items(cmbPropertyType.SelectedIndex).ToString
            labelProperty.Text = tempStr
        End If
=======
        Dim tempStr As String = cmbPropertyType.Items(cmbPropertyType.SelectedIndex).ToString
        labelProperty.Text = tempStr
>>>>>>> f54819e443c85e5ff52398d5c81defd02cc2ea52


    End Sub

    Private Sub frmAddRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyxdbDataSet.propertyxtbl' table. You can move, or remove it, as needed.
<<<<<<< HEAD
        ''Me.PropertyxtblTableAdapter.Fill(Me.PropertyxdbDataSet.propertyxtbl)


        txtAccount.Text = ""
        txtDate.Text = ""
        txtIPAI.Text = ""
        txtRequesting.Text = ""
        ''cmbPropertyType.Text = "Agricultural"
        txtAccount.Text = ""
        txtLocCity.Text = ""
        txtLocBSC.Text = ""
        txtLocStreet.Text = ""
        txtVALSQM.Text = ""

=======
        Me.PropertyxtblTableAdapter.Fill(Me.PropertyxdbDataSet.propertyxtbl)
>>>>>>> f54819e443c85e5ff52398d5c81defd02cc2ea52

    End Sub
End Class