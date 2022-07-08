Public Class mahasiswa
    Sub tampilkanmahasiswa()
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select*from mahasiswa", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "mahasiswa")
        dgv.DataSource = (DS.Tables("mahasiswa"))
    End Sub
    Sub hapustext()
        txtNPM.Text = ""
        txtNama_Mahasiswa.Text = ""
        txtNIK_Mahasiswa.Text = ""
        txtEmail_Mahasiswa.Text = ""
        txt_Agama_Mahasiswa.Text = ""
        txtTempat_LahirMahasiswa.Text = ""
        Tgl_LahirMahasiswa.Text = ""
        txtJenis_KelaminMahasiswa.Text = ""
        txtAlamat_Mahasiswa.Text = ""
        txtNo_HPMahasiswa.Text = ""
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        STR = " insert into mahasiswa (NPM, Nama_Mahasiswa, NIK_Mahasiswa, Email_Mahasiswa, Agama_Mahasiswa, Tempat_LahirMahasiswa,
Tgl_LahirMahasiswa, Jenis_KelaminMahasiswa, Alamat_Mahasiswa, No_HPMahasiswa) " &
          " values ('" & txtNPM.Text & "','" &
          txtNama_Mahasiswa.Text & "','" &
          txtNIK_Mahasiswa.Text & "','" &
       txtEmail_Mahasiswa.Text & "','" &
       txt_Agama_Mahasiswa.Text & "','" &
       txtTempat_LahirMahasiswa.Text & "','" &
       Tgl_LahirMahasiswa.Text & "','" &
       txtJenis_KelaminMahasiswa.Text & "','" &
       txtAlamat_Mahasiswa.Text & "','" &
          txtNo_HPMahasiswa.Text & "')"
        If txtNPM.Text = "" Or txtNPM.Text = "" Or txtNPM.Text = "" Then
            Exit Sub
        End If
        CMD = New MySql.Data.MySqlClient.MySqlCommand(STR, con)
        CMD.ExecuteNonQuery()
        Call tampilkanmahasiswa()
        btnedit.Visible = False
        btnsimpan.Visible = True
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Call sambung()
        Dim i As Integer
        i = dgv.CurrentRow.Index
        CMD = New MySql.Data.MySqlClient.MySqlCommand("select*from mahasiswa where NPM='" & dgv.Item(0, i).Value & "'", con)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            txtNPM.Focus()
        Else
            txtNPM.Text = DR.Item("Npm")
            txtNama_Mahasiswa.Text = DR.Item("Nama_Mahasiswa")
            txtNIK_Mahasiswa.Text = DR.Item("NIK_Mahasiswa")
            txtEmail_Mahasiswa.Text = DR.Item("Email_Mahasiswa")
            txt_Agama_Mahasiswa.Text = DR.Item("Agama_Mahasiswa")
            txtTempat_LahirMahasiswa.Text = DR.Item("Tempat_LahirMahasiswa")
            Tgl_LahirMahasiswa.Text = DR.Item("Tgl_LahirMahasiswa")
            txtJenis_KelaminMahasiswa.Text = DR.Item("Jenis_KelaminMahasiswa")
            txtAlamat_Mahasiswa.Text = DR.Item("Alamat_Mahasiswa")
            txtNo_HPMahasiswa.Text = DR.Item("No_HPMahasiswa")
            Npm.Focus()
        End If
    End Sub

    Private Sub mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call sambung()
        Call tampilkanmahasiswa()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtNPM.Text = "" Or txtNama_Mahasiswa.Text = "" Or txtNIK_Mahasiswa.Text = "" Or txtEmail_Mahasiswa.Text = "" Or
            txt_Agama_Mahasiswa.Text = "" Or txtTempat_LahirMahasiswa.Text = "" Or Tgl_LahirMahasiswa.Text = "" Or
            txtJenis_KelaminMahasiswa.Text = "" Or txtAlamat_Mahasiswa.Text = "" Or txtNo_HPMahasiswa.Text = "" Then
            MessageBox.Show("Data belum lengkap, Pastikan semua form terisi")
            Exit Sub
        Else
            Call sambung()
            Dim edit As String = "update mahasiswa set Nama_Mahasiswa ='" & txtNama_Mahasiswa.Text & "',
                NIK_Mahasiswa='" & txtNIK_Mahasiswa.Text & "',
                Email_Mahasiswa='" & txtEmail_Mahasiswa.Text & "',
                Agama_Mahasiswa='" & txt_Agama_Mahasiswa.Text & "',
                Tempat_LahirMahasiswa='" & txtTempat_LahirMahasiswa.Text & "',
                Tgl_LahirMahasiswa='" & Tgl_LahirMahasiswa.Text & "',
                Jenis_KelaminMahasiswa='" & txtJenis_KelaminMahasiswa.Text & "',
                Alamat_Mahasiswa='" & txtAlamat_Mahasiswa.Text & "',
                No_HPMahasiswa='" & txtNo_HPMahasiswa.Text & "' where Npm='" & txtNPM.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(edit, con)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil di Edit")
            Call tampilkanmahasiswa()
            btnedit.Visible = False
            btnsimpan.Visible = True
        End If
    End Sub
    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        txtNPM.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        txtNama_Mahasiswa.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        txtNIK_Mahasiswa.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        txtEmail_Mahasiswa.Text = dgv.Rows(e.RowIndex).Cells(3).Value
        txt_Agama_Mahasiswa.Text = dgv.Rows(e.RowIndex).Cells(4).Value
        txtTempat_LahirMahasiswa.Text = dgv.Rows(e.RowIndex).Cells(5).Value
        Tgl_LahirMahasiswa.Text = dgv.Rows(e.RowIndex).Cells(6).Value
        txtJenis_KelaminMahasiswa.Text = dgv.Rows(e.RowIndex).Cells(7).Value
        txtAlamat_Mahasiswa.Text = dgv.Rows(e.RowIndex).Cells(8).Value
        txtNo_HPMahasiswa.Text = dgv.Rows(e.RowIndex).Cells(9).Value
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            Call sambung()
            Dim str As String
            str = "delete from mahasiswa where NPM = '" & txtNPM.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, con)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data mahasiswa Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data mahasiswa Gagal Dihapus.")
        End Try
        Call tampilkanmahasiswa()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call hapustext()
        txtNPM.Focus()
        btnsimpan.Visible = False
        btnedit.Visible = True
    End Sub
End Class