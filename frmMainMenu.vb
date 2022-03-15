Public Class frmMainMenu
    Private Sub btnViewProperty_Click(sender As Object, e As EventArgs) Handles btnViewProperty.Click
        With frmViewRecords

            .TopLevel = False
            contentPanel.Controls.Add(frmViewRecords)
            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub btnAddProperty_Click(sender As Object, e As EventArgs) Handles btnAddProperty.Click
        With frmAddRecord

            .TopLevel = False
            contentPanel.Controls.Add(frmAddRecord)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub contentPanel_Paint(sender As Object, e As PaintEventArgs) Handles contentPanel.Paint

    End Sub
End Class