Public Class frmViewRecords_bkp
    Private Sub frmViewRecords_Load(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the 'PropertyxdbDataSet.propertxtbl' table. You can move, or remove it, as needed.
        ''Me.PropertxtblTableAdapter.Fill(Me.PropertyxdbDataSet.propertxtbl)

        DataGridView1.DataSource = PopulateDataGridViewRecords()
        ''ComboBox1.Text = "Search By Name"

        labelStatus.Text = "export"

    End Sub


    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs)

        DataGridView1.DataSource = PopulateDataGridViewRecords()
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs)
        TextBox1.Text = cmbSearch.SelectedItem.ToString

        DataGridView1.DataSource = PopulateDataGridViewRecords()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        DataGridView1.Refresh()

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        SavePDFDialog()

    End Sub

    Private Sub frmViewRecords_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyxdbDataSet1.properytxtbl' table. You can move, or remove it, as needed.
        ''Me.ProperytxtblTableAdapter.Fill(Me.PropertyxdbDataSet1.properytxtbl)

    End Sub
End Class