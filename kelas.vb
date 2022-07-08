
Public Class kelas
    Sub tampilkankelas()
        Call sambung()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select*from kelas", con)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "kelas")
        dgv.DataSource = (DS.Tables("kelas"))
    End Sub
    Sub hapustext()
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_jadwal.Text = ""
        txt_jam.Text = ""
    End Sub
    Sub addcode()

    End Sub
    Private Sub kelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call sambung()
        Call tampilkankelas()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If btnsimpan.Text = "INPUT" Then
            btnsimpan.Text = "SIMPAN"
            Call sambung()
            CMD = New MySql.Data.MySqlClient.MySqlCommand("select * from kelas where Id_Kelas in (select max(Id_Kelas) from kelas)", con)
            Dim kode As String
            Dim hitung As Long
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                kode = "k" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                kode = "k" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            txt_id.Text = kode
            txt_nama.Focus()
        Else
            If txt_id.Text = "" Or txt_nama.Text = "" Or txt_jadwal.Text = "" Or txt_jam.Text = "" Then
                MessageBox.Show("Data belum lengkap, Pastikan semua form terisi")
            Else
                Call sambung()
                Dim simpan As String = " insert into kelas(Id_Kelas,Nama_Kelas,Jadwal,Jam) " &
          "values ('" & txt_id.Text & " ',' " &
          txt_nama.Text & " ',' " &
          txt_jadwal.Text & "',' " &
          txt_jam.Text & " ')"
                CMD = New MySql.Data.MySqlClient.MySqlCommand(simpan, con)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil di simpan")
                Call tampilkankelas()
                Call hapustext()
                btnsimpan.Text = "INPUT"
            End If
        End If
        btnedit.Visible = False
        btnsimpan.Visible = True
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or txt_jadwal.Text = "" Or txt_jam.Text = "" Then
            MessageBox.Show("Data belum lengkap, Pastikan semua form terisi")
            Exit Sub
        Else
            Call sambung()
            Dim edit As String = "update kelas set Nama_Kelas ='" & txt_nama.Text &
                "',Jadwal='" & txt_jadwal.Text & "', Jam='" & txt_jam.Text & "'where Id_Kelas='" & txt_id.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(edit, con)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil di Edit")
            Call tampilkankelas()
            Call hapustext()
        End If
        btnedit.Visible = False
        btnsimpan.Visible = True
    End Sub
    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        txt_id.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        txt_jadwal.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        txt_jam.Text = dgv.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            Call sambung()
            Dim str As String
            str = "delete from kelas where Id_Kelas = '" & txt_id.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, con)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data kelas Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data kelas Gagal Dihapus.")
        End Try
        Call tampilkankelas()
        Call hapustext()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call hapustext()
        txt_id.Focus()
        btnsimpan.Visible = False
        btnedit.Visible = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Call sambung()
        Dim i As Integer
        i = dgv.CurrentRow.Index
        CMD = New MySql.Data.MySqlClient.MySqlCommand("select*from kelas where Id_Kelas='" & dgv.Item(0, i).Value & "'", con)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            txt_id.Focus()
        Else
            txt_id.Text = DR.Item("Id_Kelas")
            txt_nama.Text = DR.Item("Nama_Kelas")
            txt_jadwal.Text = DR.Item("Jadwal")
            txt_jam.Text = DR.Item("Jam")
            txt_id.Focus()
        End If
    End Sub
End Class