Public Class matakuliah
    Dim idKelas

    Sub tampilkanmatakuliah()
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select*from mata_kuliah", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "mata_kuliah")
        dgv.DataSource = (DS.Tables("mata_kuliah"))
    End Sub
    Sub hapustext()
        txt_kode.Text = ""
        txt_namakelas.Text = ""
        txt_namamatakuliah.Text = ""
        txt_sks.Text = ""
        txt_semester.Text = ""
    End Sub


    Private Sub matakuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call sambung()
        Call tampilkanmatakuliah()
        STR = "select * from kelas"
        CMD = New MySql.Data.MySqlClient.MySqlCommand(STR, con)
        DR = CMD.ExecuteReader
        txt_namakelas.Items.Clear()
        Do While DR.Read()
            txt_namakelas.Items.Add(DR("Nama_kelas"))
        Loop
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call sambung()
        STR = "insert into mata_kuliah(Kode_Matakuliah,kelas_id,Nama_Matakuliah,SKS,Semester) 
VALUES ('" & txt_kode.Text & "','" & idKelas & "','" & txt_namamatakuliah.Text & "','" & txt_sks.Text & "','" & txt_semester.Text & "')"


        If txt_kode.Text = "" Or txt_kode.Text = "" Or txt_kode.Text = "" Then
            Exit Sub
        End If
        CMD = New MySql.Data.MySqlClient.MySqlCommand(STR, con)
        CMD.ExecuteNonQuery()
        Call tampilkanmatakuliah()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Call sambung()
        Dim i As Integer
        i = dgv.CurrentRow.Index
        CMD = New MySql.Data.MySqlClient.MySqlCommand("select*from mata_kuliah where Kode_Matakuliah='" & dgv.Item(0, i).Value & "'", con)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            txt_kode.Focus()
        Else
            txt_kode.Text = DR.Item("Kode_Matakuliah")
            txt_namakelas.Text = DR.Item("Id_Kelas")
            txt_namamatakuliah.Text = DR.Item("Nama_Matakuliah")
            txt_sks.Text = DR.Item("SKS")
            txt_semester.Text = DR.Item("Semester")
            txt_kode.Focus()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txt_kode.Text = "" Or txt_namakelas.Text = "" Or txt_namamatakuliah.Text = "" Or
            txt_sks.Text = "" Or txt_semester.Text = "" Then
            MessageBox.Show("Data belum lengkap, Pastikan semua form terisi")
            Exit Sub
        Else
            Call sambung()
            Dim edit As String = "update mata_kuliah set Nama_Matakuliah ='" & txt_namamatakuliah.Text &
                "',SKS='" & txt_sks.Text & "', semester ='" & txt_semester.Text &
                "' where Kode_Matakuliah='" & txt_kode.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(edit, con)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil di Edit")
            Call tampilkanmatakuliah()
        End If
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        txt_kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        txt_namakelas.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        txt_namamatakuliah.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        txt_sks.Text = dgv.Rows(e.RowIndex).Cells(3).Value
        txt_semester.Text = dgv.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            Call sambung()
            Dim str As String
            str = "delete from mata_kuliah where Kode_Matakuliah = '" & txt_kode.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, con)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data matakuliah Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data matakuliah Gagal Dihapus.")
        End Try
        Call tampilkanmatakuliah()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call hapustext()
        txt_kode.Focus()
    End Sub

    Private Sub txt_idkelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_namakelas.SelectedIndexChanged
        Call sambung()
        STR = "select Id_Kelas from kelas WHERE Nama_Kelas = '" & txt_namakelas.Text & "'"
        CMD = New MySql.Data.MySqlClient.MySqlCommand(STR, con)
        DR = CMD.ExecuteReader
        DR.Read()
        idKelas = DR("Id_Kelas")
    End Sub

    Private Sub txt_kode_TextChanged(sender As Object, e As EventArgs) Handles txt_kode.TextChanged

    End Sub
End Class