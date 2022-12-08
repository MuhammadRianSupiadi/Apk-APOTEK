Imports MySql.Data.MySqlClient
Public Class Pembeli
    'Public kd_pembeli As String
    'Public nama_pembeli As String
    'Public alamat_pembeli As String

    Public Shared Sub InputPembeli(ByVal kd_pembeli As String, ByVal nama_pembeli As String, ByVal alamat_pembeli As String)
        Call OpenConn()
        Dim InputPembeli As String = "insert into pembeli values ('" & kd_pembeli & "','" & nama_pembeli & "','" & alamat_pembeli & "')"
        Cmd = New MySqlCommand(InputPembeli, Conn)
        Cmd.ExecuteNonQuery()
    End Sub

    Public Shared Sub InputDetailPenjualan(ByVal No_Penjualan As String, ByVal kode_obat As String, ByVal jumlah_obat As Integer, ByVal total_harga As Decimal, ByVal kd_pembeli As String)
        Call OpenConn()
        Dim InputDetailPenjualan As String = "insert into detail_penjualan values ('" & No_Penjualan & "','" & kode_obat & "','" & jumlah_obat & "','" & total_harga & "','" & kd_pembeli & "')"
        Cmd = New MySqlCommand(InputDetailPenjualan, Conn)
        Cmd.ExecuteNonQuery()
    End Sub

    Public Shared Sub Kurangi_Jumlah_Obat(ByVal JumlahObat As String, ByVal Kode_obat As String)
        Call OpenConn()
        Dim KurangiJumlahObat As String = "Update pembelian_obat set jumlah_obat= '" & Rd.Item("jumlah_obat") - JumlahObat & "' Where kd_obat = '" & Kode_obat & "'"
        Cmd = New MySqlCommand(KurangiJumlahObat, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
