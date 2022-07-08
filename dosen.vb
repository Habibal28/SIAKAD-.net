Public Class dosen
    Sub tampilkandosen()
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select*from dosen", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dosen")
        dgv.DataSource = (DS.Tables("dosen"))
    End Sub
    Sub hapustext()
        txtNIP.Text = ""
        txtNama_Dosen.Text = ""
        txtNIK_Dosen.Text = ""
        txtEmail_Dosen.Text = ""
        txt_Agama_Dosen.Text = ""
        txtTempat_LahirDosen.Text = ""
        Tgl_LahirDosen.Text = ""
        txtJenis_KelaminDosen.Text = ""
        txtAlamat_Dosen.Text = ""
        txtNo_HPDosen.Text = ""
    End Sub
    Private Sub dosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call sambung()
        Call tampilkandosen()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        STR = " insert into dosen (NIP, Nama_Dosen, NIK_Dosen, Email_Dosen, Agama_Dosen, Tempat_LahirDosen,
Tgl_LahirDosen, Jenis_KelaminDosen, Alamat_Dosen, No_HPDosen) " &
         " values ('" & txtNIP.Text & "','" &
         txtNama_Dosen.Text & "','" &
         txtNIK_Dosen.Text & "','" &
      txtEmail_Dosen.Text & "','" &
      txt_Agama_Dosen.Text & "','" &
      txtTempat_LahirDosen.Text & "','" &
      Tgl_LahirDosen.Text & "','" &
      txtJenis_KelaminDosen.Text & "','" &
      txtAlamat_Dosen.Text & "','" &
         txtNo_HPDosen.Text & "')"
        If txtNIP.Text = "" Or txtNIP.Text = "" Or txtNIP.Text = "" Then
            Exit Sub
        End If
        CMD = New MySql.Data.MySqlClient.MySqlCommand(STR, con)
        CMD.ExecuteNonQuery()
        Call tampilkandosen()
        btnedit.Visible = False
        btnsimpan.Visible = True
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Call sambung()
        Dim i As Integer
        i = dgv.CurrentRow.Index
        CMD = New MySql.Data.MySqlClient.MySqlCommand("select*from dosen where NIP='" & dgv.Item(0, i).Value & "'", con)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            txtNIP.Focus()
        Else
            txtNIP.Text = DR.Item("NIP")
            txtNama_Dosen.Text = DR.Item("Nama_Dosen")
            txtNIK_Dosen.Text = DR.Item("NIK_Dosena")
            txtEmail_Dosen.Text = DR.Item("Email_Dosen")
            txt_Agama_Dosen.Text = DR.Item("Agama_Dosen")
            txtTempat_LahirDosen.Text = DR.Item("Tempat_LahirDosen")
            Tgl_LahirDosen.Text = DR.Item("Tgl_LahirDosen")
            txtJenis_KelaminDosen.Text = DR.Item("Jenis_KelaminMahasiswa")
            txtAlamat_Dosen.Text = DR.Item("Alamat_Dosen")
            txtNo_HPDosen.Text = DR.Item("No_HPDosen")
            txtNIP.Focus()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtNIP.Text = "" Or txtNama_Dosen.Text = "" Or txtNIK_Dosen.Text = "" Or txtEmail_Dosen.Text = "" Or
            txt_Agama_Dosen.Text = "" Or txtTempat_LahirDosen.Text = "" Or Tgl_LahirDosen.Text = "" Or
            txtJenis_KelaminDosen.Text = "" Or txtAlamat_Dosen.Text = "" Or txtNo_HPDosen.Text = "" Then
            MessageBox.Show("Data belum lengkap, Pastikan semua form terisi")
            Exit Sub
        Else
            Call sambung()
            Dim edit As String = "update dosen set Nama_Dosen ='" & txtNama_Dosen.Text & "',
                NIK_Dosen='" & txtNIK_Dosen.Text & "',
                Email_Dosen='" & txtEmail_Dosen.Text & "',
                Agama_Dosen='" & txt_Agama_Dosen.Text & "',
                Tempat_LahirDosen='" & txtTempat_LahirDosen.Text & "',
                Tgl_LahirDosen='" & Tgl_LahirDosen.Text & "',
                Jenis_KelaminDosen='" & txtJenis_KelaminDosen.Text & "',
                Alamat_Dosen='" & txtAlamat_Dosen.Text & "',
                No_HPDosen='" & txtNo_HPDosen.Text & "'
                where NIP='" & txtNIP.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(edit, con)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil di Edit")
            Call tampilkandosen()
            btnedit.Visible = False
            btnsimpan.Visible = True
        End If
    End Sub
    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        txtNIP.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        txtNama_Dosen.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        txtNIK_Dosen.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        txtEmail_Dosen.Text = dgv.Rows(e.RowIndex).Cells(3).Value
        txt_Agama_Dosen.Text = dgv.Rows(e.RowIndex).Cells(4).Value
        txtTempat_LahirDosen.Text = dgv.Rows(e.RowIndex).Cells(5).Value
        Tgl_LahirDosen.Text = dgv.Rows(e.RowIndex).Cells(6).Value
        txtJenis_KelaminDosen.Text = dgv.Rows(e.RowIndex).Cells(7).Value
        txtAlamat_Dosen.Text = dgv.Rows(e.RowIndex).Cells(8).Value
        txtNo_HPDosen.Text = dgv.Rows(e.RowIndex).Cells(9).Value
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            Call sambung()
            Dim str As String
            str = "delete from dosen where NIP = '" & txtNIP.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, con)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data dosen Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data dosen Gagal Dihapus.")
        End Try
        Call tampilkandosen()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call hapustext()
        txtNIP.Focus()
        btnsimpan.Visible = False
        btnedit.Visible = True
    End Sub
End Class