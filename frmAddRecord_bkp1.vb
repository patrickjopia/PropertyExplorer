


Imports MySql.Data.MySqlClient

Public Class frmAddRecord_bkp1

    Dim sDT As Date = Now


    Dim db As String = "propertyXdb"

    Dim myConnectionString As String = "server=127.0.0.1;" & "uid=root;" _
            & "pwd=1p@s4w0rd2o22;"


    ''& "database=" + db

    Dim conn As New MySqlConnection(myConnectionString)

    ''Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")




    Private Sub frmAddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyxdbDataSet.propertxtbl' table. You can move, or remove it, as needed.
        ''Me.PropertxtblTableAdapter.Fill(Me.PropertyxdbDataSet.propertxtbl)
        'TODO: This line of code loads data into the 'PropertyXDataSet.tabl_propertyRecords' table. You can move, or remove it, as needed.
        '' Me.Tabl_propertyRecordsTableAdapter.Fill(Me.PropertyXDataSet.tabl_propertyRecords)



    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click

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
        Dim tempStr As String = cmbPropertyType.Items(cmbPropertyType.SelectedIndex).ToString


        Label10.Text = tempStr
    End Sub

    Private Sub frmAddRecord_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyxdbDataSet1.properytxtbl' table. You can move, or remove it, as needed.
        ''Me.ProperytxtblTableAdapter.Fill(Me.PropertyxdbDataSet1.properytxtbl)

    End Sub
End Class
