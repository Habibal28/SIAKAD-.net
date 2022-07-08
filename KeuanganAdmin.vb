Imports MySql.Data.MySqlClient
Imports System.DateTime
Public Class KeuanganAdmin
    Dim npm
    Sub tampildata()
        DS = New DataSet
        STR = "select * from record_pembayaran"
        DA = New MySqlDataAdapter(STR, con)
        DA.Fill(DS)

        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub KeuanganAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sambung()
        tampildata()
    End Sub

    Private Sub input_keuangan_Click(sender As Object, e As EventArgs) Handles input_keuangan.Click
        CMD = New MySqlCommand
        CMD.Connection = con
        STR = "insert into record_pembayaran values ('""','" & npm_txt.Text & "','" & jenis_txt.Text & "','" & tgl_txt.Text & "','" & nominal_txt.Text & "')"
        CMD.CommandText = STR
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil Ditambahkan", "Notice")
        tampildata()
    End Sub

    Private Sub tgl_txt_ValueChanged(sender As Object, e As EventArgs) Handles tgl_txt.ValueChanged
        tgl_txt.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub nama_txt_TextChanged(sender As Object, e As EventArgs) Handles nama_txt.TextChanged

    End Sub

    Private Sub npm_txt_TextChanged(sender As Object, e As EventArgs) Handles npm_txt.TextChanged

    End Sub
End Class