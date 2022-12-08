Imports MySql.Data.MySqlClient
Public Class Penjualan
    Public no_penjualan As String
    Public tgl_penjualan As String
    Public kode_obat As String
    Public nama_obat As String
    Public exp As Date
    Public harga_obat As String
    Public jenis_obat As String
    Public total_penjualan As String
    Public kd_petugas As String

    Sub Simpan()
        Call OpenConn()
        Dim InputPenjualan As String = "insert into penjualan values ('" & no_penjualan & "','" & tgl_penjualan & "','" & kode_obat & "', '" & nama_obat & "','" & Format(exp, "yyyy-MM-dd") & "', '" & harga_obat & "', '" & jenis_obat & "','" & total_penjualan & "','" & kd_petugas & "')"
        Cmd = New MySqlCommand(InputPenjualan, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
