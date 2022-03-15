
Imports MySql.Data.MySqlClient

Module mod_property


    ''Dim db As String = frmConfigCheck.TextBox1.Text

    Dim connectionProperty As String = "server=localhost;user id=root;password=1p@s4w0rd2o22;persistsecurityinfo=True;database=propertyxdb"

    ''& "database=" & db & ";"

    Dim conn As New MySqlConnection(connectionProperty)

    Dim cmd As MySqlCommand




    Dim da As New MySqlDataAdapter
    Public total As Integer
    Dim publictable As New DataTable

    Sub connDBOpen()

        Try
            conn.ConnectionString = connectionProperty
            conn.Open()

            ''Status printing section
            ''labelStatus.Text = "MySQL Connected"
            frmConfigCheck.TextBox1.Text = "MySQL Connected"

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub connDBClose()

        Try
            conn.ConnectionString = connectionProperty
            conn.Open()

            ''Status printing section
            ''labelStatus.Text = "MySQL Connected"
            frmConfigCheck.TextBox1.Text = "MySQL Disconnected"

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub propertyAdd()

        Dim cmdAdd As New MySqlCommand("insert into propertyxtbl (Date, IPAI, RequestingUnit, AccountName, TypeProperty, LocCity, LocBSC, LocStreet,LocFull, ValPerSQM) values(@Date, @IPAI, @RequestingUnit, @AccountName, @TypeProperty, @LocCity, @LocBSC, @LocStreet, @LocFull, @ValPerSQM)", conn)


        cmdAdd.Parameters.Clear()

        cmdAdd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = frmAddRecord.txtDate.Text
        cmdAdd.Parameters.Add("@IPAI", MySqlDbType.VarChar).Value = frmAddRecord.txtIPAI.Text
        cmdAdd.Parameters.Add("@RequestingUnit", MySqlDbType.VarChar).Value = frmAddRecord.txtRequesting.Text
        cmdAdd.Parameters.Add("@AccountName", MySqlDbType.VarChar).Value = frmAddRecord.txtAccount.Text
        cmdAdd.Parameters.Add("@TypeProperty", MySqlDbType.VarChar).Value = frmAddRecord.labelProperty.Text

        cmdAdd.Parameters.Add("@LocCity", MySqlDbType.VarChar).Value = frmAddRecord.txtLocCity.Text
        cmdAdd.Parameters.Add("@LocBSC", MySqlDbType.VarChar).Value = frmAddRecord.txtLocBSC.Text
        cmdAdd.Parameters.Add("@LocStreet", MySqlDbType.VarChar).Value = frmAddRecord.txtLocStreet.Text
        cmdAdd.Parameters.Add("@LocFull", MySqlDbType.VarChar).Value = frmAddRecord.rtLocFull.Text
        cmdAdd.Parameters.Add("@ValPerSQM", MySqlDbType.VarChar).Value = frmAddRecord.txtVALSQM.Text


        If cmdAdd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Property Added", "PropertyXplorer")
        Else
            MessageBox.Show("Property Not Added", "PropertyXplorer")
        End If

    End Sub


    Function PopulateDataGridViewRecords() As DataTable


        ''Dim query As String = "Select * FROM propertyxtbl"
        ''query &= " WHERE LocCity LIKE @LocCity "
        '' query &= " OR @LocCity = ''"
        ''query &= " AND TypeProperty LIKE @TypeProperty"
        ''query &= " OR @TypeProperty = ''"


        Dim query As String = "Select * FROM propertyxtbl"
        query &= " WHERE TypeProperty LIKE @TypeProperty"
        query &= " OR @TypeProperty = ''"
        query &= " AND LocCity LIKE @LocCity "
        query &= " Or @TypeProperty = ''"

        Dim constr As String = "server=localhost;user id=root;password=1p@s4w0rd2o22;persistsecurityinfo=True;database=propertyxdb"
        Using con As MySqlConnection = New MySqlConnection(constr)
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@LocCity", frmViewRecords.txtSearch.Text + "%'")
                ''cmd.Parameters.AddWithValue("@LocCity", frmViewRecords.txtSearch.Text)
                cmd.Parameters.AddWithValue("@TypeProperty", frmViewRecords.cmbSearch.Text.ToString)
                Using sda As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable()
                    sda.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using


    End Function










End Module
