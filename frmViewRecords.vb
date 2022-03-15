Public Class frmViewRecords
    Private Sub frmViewRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyxdbDataSet.propertyxtbl' table. You can move, or remove it, as needed.
        ''Me.PropertyxtblTableAdapter.Fill(Me.PropertyxdbDataSet.propertyxtbl)

        DataGridView1.DataSource = PopulateDataGridViewRecords()
        ''ComboBox1.Text = "Search By Name"

        labelStatus.Text = "export"
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged

        TextBox1.Text = cmbSearch.SelectedItem.ToString

        DataGridView1.DataSource = PopulateDataGridViewRecords()
    End Sub

<<<<<<< HEAD

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp

=======
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp

        DataGridView1.DataSource = PopulateDataGridViewRecords()
>>>>>>> f54819e443c85e5ff52398d5c81defd02cc2ea52
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        SavePDFDialog()
    End Sub
<<<<<<< HEAD

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = PopulateDataGridViewRecords()
        DataGridView1.Refresh()
    End Sub
=======
>>>>>>> f54819e443c85e5ff52398d5c81defd02cc2ea52
End Class