Imports MySql.Data.MySqlClient
Public Class Keuangan
    Sub tampildata()
        DS = New DataSet
        STR = "select * from record_pembayaran"
        DA = New MySqlDataAdapter(STR, con)
        DA.Fill(DS)

        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub Keuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sambung()
        tampildata()
    End Sub
End Class