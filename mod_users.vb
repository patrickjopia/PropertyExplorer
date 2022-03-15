Imports MySql.Data.MySqlClient

Module mod_users




    Dim connectionUsers As New MySqlConnection("server=localhost;user id=root;password=1p@s4w0rd2o22;persistsecurityinfo=True;database=propertyxdb")







    ' Return the hashed password.
    ' Note that this is just a simple example that shifts
    ' the password's characters. In a real program, you should
    ' do something stronger such as using the Crypto namespace.
    Function HashPassword(ByVal password As String) As _
    String
        Dim hash As String = ""
        Dim i As Integer
        For i = 0 To password.Length - 1
            hash &= Chr(Asc(password.Substring(i, 1)) + 1)
        Next i
        Return hash
    End Function




















End Module
