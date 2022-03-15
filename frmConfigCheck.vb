Public Class frmConfigCheck
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connDBOpen()

    End Sub


    Private Sub frmConfigCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyxdbDataSet.propertxtbl' table. You can move, or remove it, as needed.
        Me.PropertxtblTableAdapter.Fill(Me.PropertyxdbDataSet.propertxtbl)


    End Sub





End Class