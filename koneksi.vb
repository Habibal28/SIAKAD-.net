Imports MySql.Data.MySqlClient
Module koneksi
    Public con As MySqlConnection
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String

    Sub sambung()
        Try
            Dim STR As String
            STR = "SERVER=localhost; user id=root; password=; database=testing_datamaster; Convert Zero Datetime=true"
            con = New MySqlConnection(STR)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
