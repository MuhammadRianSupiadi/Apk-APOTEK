Imports MySql.Data.MySqlClient
Public Class Form_Login
    'Berfungsi untuk mengunci dan membuka menustrip pada menu utama
    Sub Terbuka()
        Menu_Utama.LOGIN.Enabled = False
        Menu_Utama.KELUAR.Enabled = True
        Menu_Utama.PETUGAS.Enabled = True
        Menu_Utama.Master.Enabled = True
        Menu_Utama.TRANSAKSI.Enabled = True
        Menu_Utama.LAPORAN.Enabled = True
    End Sub
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        'Berfungsi untuk keluar dari form login
        Me.Close()
    End Sub
    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        'Jikan textbox passwordcharnya true,ketika diklik
        If CheckPassword.Checked = True Then
            'maka passwordcharnya false
            txt_password.PasswordChar = ""
            'Jika tidak maka passwordcharnya true
        Else
            txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Berfungsi untuk membuka koneksi pada modul koneksi
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from petugas where kd_petugas = '" & txt_petugas.Text & "'and password='" & txt_password.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call Terbuka()
        End If
    End Sub
End Class