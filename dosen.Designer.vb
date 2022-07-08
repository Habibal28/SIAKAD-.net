<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dosen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtJenis_KelaminDosen = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Tgl_LahirDosen = New System.Windows.Forms.DateTimePicker()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.txtNo_HPDosen = New System.Windows.Forms.TextBox()
        Me.txtAlamat_Dosen = New System.Windows.Forms.TextBox()
        Me.txtTempat_LahirDosen = New System.Windows.Forms.TextBox()
        Me.txt_Agama_Dosen = New System.Windows.Forms.TextBox()
        Me.txtEmail_Dosen = New System.Windows.Forms.TextBox()
        Me.txtNIK_Dosen = New System.Windows.Forms.TextBox()
        Me.txtNama_Dosen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Npm = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJenis_KelaminDosen
        '
        Me.txtJenis_KelaminDosen.FormattingEnabled = True
        Me.txtJenis_KelaminDosen.Items.AddRange(New Object() {"Perempuan", "Laki-Laki"})
        Me.txtJenis_KelaminDosen.Location = New System.Drawing.Point(807, 174)
        Me.txtJenis_KelaminDosen.Name = "txtJenis_KelaminDosen"
        Me.txtJenis_KelaminDosen.Size = New System.Drawing.Size(200, 23)
        Me.txtJenis_KelaminDosen.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(224, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 95)
        Me.Panel1.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(46, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 32)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Dosen"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(221, 45)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Kelas"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(222, 45)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Mahasiswa"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 45)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Mata Kuliah"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(222, 45)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Dosen"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DataMaster.My.Resources.Resources.Logo_ITATS
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 45)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 536)
        Me.Panel2.TabIndex = 53
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(249, 365)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.Size = New System.Drawing.Size(976, 155)
        Me.dgv.TabIndex = 52
        '
        'Tgl_LahirDosen
        '
        Me.Tgl_LahirDosen.Location = New System.Drawing.Point(807, 148)
        Me.Tgl_LahirDosen.Name = "Tgl_LahirDosen"
        Me.Tgl_LahirDosen.Size = New System.Drawing.Size(200, 23)
        Me.Tgl_LahirDosen.TabIndex = 51
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(772, 306)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 50
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(684, 306)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 49
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(579, 306)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 48
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'txtNo_HPDosen
        '
        Me.txtNo_HPDosen.Location = New System.Drawing.Point(807, 232)
        Me.txtNo_HPDosen.Name = "txtNo_HPDosen"
        Me.txtNo_HPDosen.Size = New System.Drawing.Size(200, 23)
        Me.txtNo_HPDosen.TabIndex = 47
        '
        'txtAlamat_Dosen
        '
        Me.txtAlamat_Dosen.Location = New System.Drawing.Point(807, 202)
        Me.txtAlamat_Dosen.Name = "txtAlamat_Dosen"
        Me.txtAlamat_Dosen.Size = New System.Drawing.Size(200, 23)
        Me.txtAlamat_Dosen.TabIndex = 46
        '
        'txtTempat_LahirDosen
        '
        Me.txtTempat_LahirDosen.Location = New System.Drawing.Point(807, 119)
        Me.txtTempat_LahirDosen.Name = "txtTempat_LahirDosen"
        Me.txtTempat_LahirDosen.Size = New System.Drawing.Size(200, 23)
        Me.txtTempat_LahirDosen.TabIndex = 45
        '
        'txt_Agama_Dosen
        '
        Me.txt_Agama_Dosen.Location = New System.Drawing.Point(461, 248)
        Me.txt_Agama_Dosen.Name = "txt_Agama_Dosen"
        Me.txt_Agama_Dosen.Size = New System.Drawing.Size(190, 23)
        Me.txt_Agama_Dosen.TabIndex = 44
        '
        'txtEmail_Dosen
        '
        Me.txtEmail_Dosen.Location = New System.Drawing.Point(461, 214)
        Me.txtEmail_Dosen.Name = "txtEmail_Dosen"
        Me.txtEmail_Dosen.Size = New System.Drawing.Size(190, 23)
        Me.txtEmail_Dosen.TabIndex = 43
        '
        'txtNIK_Dosen
        '
        Me.txtNIK_Dosen.Location = New System.Drawing.Point(461, 178)
        Me.txtNIK_Dosen.Name = "txtNIK_Dosen"
        Me.txtNIK_Dosen.Size = New System.Drawing.Size(190, 23)
        Me.txtNIK_Dosen.TabIndex = 42
        '
        'txtNama_Dosen
        '
        Me.txtNama_Dosen.Location = New System.Drawing.Point(461, 148)
        Me.txtNama_Dosen.Name = "txtNama_Dosen"
        Me.txtNama_Dosen.Size = New System.Drawing.Size(190, 23)
        Me.txtNama_Dosen.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(700, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "No Hp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "NIK Dosen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Agama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(697, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(697, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tgl Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(697, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(697, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nama_Dosen"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(473, 306)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 31
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(461, 116)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(190, 23)
        Me.txtNIP.TabIndex = 30
        '
        'Npm
        '
        Me.Npm.AutoSize = True
        Me.Npm.Location = New System.Drawing.Point(281, 124)
        Me.Npm.Name = "Npm"
        Me.Npm.Size = New System.Drawing.Size(26, 15)
        Me.Npm.TabIndex = 29
        Me.Npm.Text = "NIP"
        '
        'dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 532)
        Me.Controls.Add(Me.txtJenis_KelaminDosen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Tgl_LahirDosen)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.txtNo_HPDosen)
        Me.Controls.Add(Me.txtAlamat_Dosen)
        Me.Controls.Add(Me.txtTempat_LahirDosen)
        Me.Controls.Add(Me.txt_Agama_Dosen)
        Me.Controls.Add(Me.txtEmail_Dosen)
        Me.Controls.Add(Me.txtNIK_Dosen)
        Me.Controls.Add(Me.txtNama_Dosen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Npm)
        Me.Name = "dosen"
        Me.Text = "dosen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJenis_KelaminDosen As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Tgl_LahirDosen As DateTimePicker
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents txtNo_HPDosen As TextBox
    Friend WithEvents txtAlamat_Dosen As TextBox
    Friend WithEvents txtTempat_LahirDosen As TextBox
    Friend WithEvents txt_Agama_Dosen As TextBox
    Friend WithEvents txtEmail_Dosen As TextBox
    Friend WithEvents txtNIK_Dosen As TextBox
    Friend WithEvents txtNama_Dosen As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Npm As Label
End Class
