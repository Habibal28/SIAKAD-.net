Public Class KRS

    Sub tampilKrs()
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("Select mahasiswa.NPM, mahasiswa.Nama_Mahasiswa, mata_kuliah.Kode_MataKuliah, mata_kuliah.Nama_MataKuliah, mata_kuliah.SKS, kelas.Nama_Kelas, kelas.Jadwal, kelas.Jam FROM krs JOIN mahasiswa ON krs.mahasiswa_id = mahasiswa.NPM JOIN mata_kuliah 
On krs.matakuliah_id = mata_kuliah.Kode_MataKuliah JOIN kelas 
On mata_kuliah.kelas_id = kelas.Id_Kelas WHERE mahasiswa.NPM = 7167 ", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "krs")
        tablekrs.DataSource = (DS.Tables("krs"))


    End Sub
    Sub tampilAllKrs()
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select mata_kuliah.Kode_Matakuliah,mata_kuliah.Nama_MataKuliah,mata_kuliah.SKS,
kelas.Nama_Kelas,kelas.Jadwal,kelas.Jam FROM mata_kuliah JOIN kelas ON mata_kuliah.kelas_id = kelas.Id_Kelas", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "mata_kuliah")

        Dim ChkBox As New DataGridViewCheckBoxColumn
        ChkBox.HeaderText = "pilih"
        ChkBox.Name = "btnCheck"

        daftarMataKuliah.DataSource = (DS.Tables("mata_kuliah"))
        daftarMataKuliah.Columns.Add(ChkBox)
        daftarMataKuliah.Columns(6).Width = 35

    End Sub
    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ChkBox As New DataGridViewCheckBoxColumn

        If (daftarMataKuliah.Visible = True) Then
            daftarMataKuliah.Visible = False
            tablekrs.Visible = True
            btnSubmit.Visible = False
            btnCetak.Visible = True

        Else
            daftarMataKuliah.Visible = True
            tablekrs.Visible = False
            btnSubmit.Visible = True
            btnCetak.Visible = False
        End If

        Call tampilAllKrs()



    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles daftarMataKuliah.CellContentClick




    End Sub

    Private Sub KRS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilKrs()
        daftarMataKuliah.Visible = False
        btnSubmit.Visible = False
        btnCetak.Visible = True



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles tablekrs.CellContentClick

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        btnSubmit.Visible = False
        btnCetak.Visible = True

        For i As Integer = 0 To daftarMataKuliah.Rows.Count - 1
            If CBool(DirectCast(daftarMataKuliah.Rows(i).Cells("btnCheck"), DataGridViewCheckBoxCell).Value) = True Then
                Dim npm = 7167
                Dim matakuliah_id = daftarMataKuliah.Rows(i).Cells("Kode_MataKuliah").Value
                Dim STR = "INSERT INTO krs (mahasiswa_id,matakuliah_id) VALUES ('" & npm & "','" & matakuliah_id & "') "
                CMD = New MySql.Data.MySqlClient.MySqlCommand(STR, con)
                CMD.ExecuteNonQuery()
                Call tampilKrs()
            End If
        Next
        daftarMataKuliah.Visible = False
        tablekrs.Visible = True
    End Sub
End Class