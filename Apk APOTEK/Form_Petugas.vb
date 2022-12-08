Imports MySql.Data.MySqlClient
Public Class Form_Petugas
    Sub Tampil()
        'Memanggil Koneksi pada Modul koneksi
        Call OpenConn()
        'Untuk Menampilkan tabel petugas kedalam datagridview
        Da = New MySqlDataAdapter("select * from petugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "petugas")
        Dg_Petugas.DataSource = Ds.Tables("petugas")
        'Untuk mengganti warna kolom pada datagridview
        Dg_Petugas.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
        'Untuk Mengosongkan textbox pada form petugas
        txt_kdpetugas.Text = ""
        txt_namapetugas.Text = ""
        txt_password.Text = ""
        txt_nohp.Text = ""

        'Untuk mengunci textbox pada form petugas
        txt_kdpetugas.Enabled = False
        txt_namapetugas.Enabled = False
        txt_password.Enabled = False
        txt_nohp.Enabled = False

        'Mengubah tulisan dan membuka button pada form petugas
        btn_tambah.Enabled = True
        btn_tambah.Text = "Tambah"
        btn_ubah.Enabled = True
        btn_ubah.Text = "Ubah"
        btn_hapus.Enabled = True
        btn_hapus.Text = "Hapus"
        btn_keluar.Text = "Keluar"
    End Sub

    'Untuk membuka textbox pada form petugas
    Sub Hidup()
        txt_kdpetugas.Enabled = True
        txt_namapetugas.Enabled = True
        txt_password.Enabled = True
        txt_nohp.Enabled = True
    End Sub
    Private Sub Form_Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Memamnggil fungsi tampil ketika form petugas load
        Call Tampil()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        'Jika button tambah diklik
        If btn_tambah.Text = "Tambah" Then
            'Maka tulisan pada button tambah berubah menjadi simpan
            btn_tambah.Text = "Simpan"
            'Button ubah terkunci
            btn_ubah.Enabled = False
            'Button hapus terkunci
            btn_hapus.Enabled = False
            'Button keluar diubah menjadi batal
            btn_keluar.Text = "&Batal"
            'Berfungsi untuk memanggil fungsi hidup
            Call Hidup()
            'Berfungsi untuk memfokuskan pada texbox kode petugas
            txt_kdpetugas.Focus()
            'Jika tidak
        Else
            'Jika textbox pada form petugas kosong
            If txt_kdpetugas.Text = "" Or txt_namapetugas.Text = "" Or txt_password.Text = "" Or txt_nohp.Text = "" Then
                MsgBox("Pastikan Semua Data Terisi")
                'Jika tidak
            Else
                'Maka lakukan simpan
                Dim Simpan = New Petugas With {
                    .kd_petugas = txt_kdpetugas.Text,
                    .nama_petugas = txt_namapetugas.Text,
                    .password = txt_password.Text,
                    .no_hp = txt_nohp.Text
                }
                Dim tambah = Simpan.Tambah()
                If (tambah) Then
                    MsgBox("Data Berhasil Ditambakan", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal Disimpan....Periksa Koneksi Terlebih Dahulu!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End If
            End If
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If btn_ubah.Text = "Ubah" Then
            btn_ubah.Text = "Simpan"
            btn_tambah.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "&Batal"
            Call Hidup()
            txt_kdpetugas.Focus()
        Else
            If txt_kdpetugas.Text = "" Or txt_namapetugas.Text = "" Or txt_nohp.Text = "" Or txt_password.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                txt_kdpetugas.Focus()
            Else
                Dim petugas = New Petugas With {
                    .kd_petugas = txt_kdpetugas.Text,
                    .nama_petugas = txt_namapetugas.Text,
                    .password = txt_password.Text,
                    .no_hp = txt_nohp.Text
                }
                Dim Ubah = petugas.Update()
                If (Ubah) Then
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If btn_hapus.Text = "Hapus" Then
            btn_hapus.Text = "Delete"
            btn_tambah.Enabled = False
            btn_ubah.Enabled = False
            btn_keluar.Text = "&Batal"
            Call Hidup()
            txt_kdpetugas.Focus()
        Else
            If txt_kdpetugas.Text = "" Or txt_namapetugas.Text = "" Or txt_password.Text = "" Or txt_nohp.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                txt_kdpetugas.Focus()
            Else
                Dim petugas = New Petugas With {
                    .kd_petugas = txt_kdpetugas.Text
                }
                Dim Simpan = petugas.Hapus()
                If (Simpan) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call Tampil()
        End If
    End Sub

    Private Sub txt_kdpetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kdpetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Petugas.Carikode(txt_kdpetugas.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada", MsgBoxStyle.Critical, "WARNING!!!")
            Else
                txt_namapetugas.Text = hasil.nama_petugas
                txt_password.Text = hasil.password
                txt_nohp.Text = hasil.no_hp
            End If
        End If
    End Sub

    Private Sub txt_kdpetugas_TextChanged(sender As Object, e As EventArgs) Handles txt_kdpetugas.TextChanged

    End Sub
End Class
