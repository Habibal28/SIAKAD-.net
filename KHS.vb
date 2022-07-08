Public Class KHS

    Sub tampilkhs(npm As Single, semester As Single)
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select mata_kuliah.Kode_MataKuliah, mata_kuliah.Nama_MataKuliah, 
dosen.Nama_Dosen, kelas.Nama_Kelas, mata_kuliah.SKS, nilai.nts, nilai.nas, round(((nilai.nas + nilai.nts)/2), 2) as total
FROM khs JOIN mata_kuliah ON 
khs.matakuliah_id = mata_kuliah.Kode_MataKuliah JOIN kelas ON mata_kuliah.kelas_id = kelas.Id_Kelas JOIN dosen ON 
khs.dosen_id = dosen.NIP JOIN nilai ON khs.nilai_id = nilai.id_nilai 
WHERE (nilai.mahasiswa_id = '" & npm & "' AND mata_kuliah.Semester ='" & semester & "') ", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "krs")
        tableKhs.DataSource = (DS.Tables("krs"))

    End Sub
    Private Sub KHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxSemester.DisplayMember = "Text"
        comboBoxSemester.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        tb.Rows.Add("Semester 1", 1)
        tb.Rows.Add("Semester 2", 2)
        tb.Rows.Add("Semester 3", 3)
        tb.Rows.Add("Semester 4", 4)
        tb.Rows.Add("Semester 5", 5)
        tb.Rows.Add("Semester 6", 6)
        tb.Rows.Add("Semester 7", 7)
        tb.Rows.Add("Semester 8", 8)
        comboBoxSemester.DataSource = tb
    End Sub

    Private Sub comboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSemester.SelectedIndexChanged
        Call tampilkhs(7221, comboBoxSemester.SelectedValue)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableKhs.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class