Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Public Class Penjualan_Obat
    Sub Mati()
        Call NoOtomatis()
        JumlahObat.Enabled = False
        TotalHarga.Enabled = False
        Bayar.Enabled = False
        Kembalian.Enabled = False
        NamaPembeli.Enabled = False
        AlamatPembeli.Enabled = False

        KodeObat.Text = ""
        DtPenjualan.ResetText()
        HargaObat.Text = ""
        JenisObat.Text = ""
        JumlahObat.Text = ""
        TotalHarga.Text = ""
        Bayar.Text = ""
        Kembalian.Text = ""
        NamaPembeli.Text = ""
        AlamatPembeli.Text = ""
    End Sub
    Sub Isi()
        JumlahObat.Enabled = True
        TotalHarga.Enabled = True
        Bayar.Enabled = True
        Kembalian.Enabled = True
        NamaPembeli.Enabled = True
        AlamatPembeli.Enabled = True
    End Sub
    Sub NoOtomatis()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from penjualan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "penjualan")
        Dgpenjualan.DataSource = Ds.Tables("penjualan")
        Dgpenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond

        Call OpenConn()
        Cmd = New MySqlCommand("select no_penjualan from penjualan order by no_penjualan desc", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows = True Then
            NoPenjualan.Text = "PJ" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("no_penjualan"), 3, 6) = Format(Today, "yyMMdd") Then
                NoPenjualan.Text = "PJ" + Format(Microsoft.VisualBasic.Right(Rd.Item("no_penjualan"), 8) + 1, "00")
            Else
                NoPenjualan.Text = "PJ" + Format(Today, "yyMMdd") + "01"
            End If
        End If

        Call OpenConn()
        Cmd = New MySqlCommand("select kd_pembeli from pembeli order by kd_pembeli desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            KodePembeli.Text = "PMB" + "0001"
        Else
            KodePembeli.Text = Val(Microsoft.VisualBasic.Mid(Rd.Item("kd_pembeli").ToString, 5, 4)) + 1
            If Len(KodePembeli.Text) = 1 Then
                KodePembeli.Text = "PMB000" & KodePembeli.Text & ""
            ElseIf Len(KodePembeli.Text) = 2 Then
                KodePembeli.Text = "PMB00" & KodePembeli.Text & ""
            ElseIf Len(Bayar.Text) = 3 Then
                KodePembeli.Text = "PMB0" & KodePembeli.Text & ""
            End If
        End If
    End Sub
    Sub MunculNamaObat()
        Call OpenConn()
        CbNamaObat.Items.Clear()
        Cmd = New MySqlCommand("select * from pembelian_obat", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            CbNamaObat.Items.Add(Rd.Item(1))
        Loop
    End Sub

    Private Sub Penjualan_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Mati()
        Call NoOtomatis()
        Call MunculNamaObat()
        Tglpenjualan.Text = Today
        KodePetugas.Text = Form_Login.txt_petugas.Text
    End Sub

    Private Sub CbNamaObat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaObat.SelectedIndexChanged
        Dim Hasil = Pembelian.Daftar_Obat(CbNamaObat.Text)
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            KodeObat.Text = Hasil.kd_obat
            JenisObat.Text = Hasil.jenis_obat
            HargaObat.Text = Hasil.Harga
            DtPenjualan.Text = Hasil.exp
            Call Isi()
        End If
    End Sub

    Private Sub JumlahObat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JumlahObat.KeyPress
        If e.KeyChar = Chr(13) Then
            TotalHarga.Text = Val(JumlahObat.Text) * Val(HargaObat.Text)
            TotalHarga.Text = TotalHarga.Text
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Bayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(Bayar.Text) < Val(TotalHarga.Text) Then
                MsgBox("Pembayaran Kurang")
                Bayar.Focus()
            ElseIf Val(Bayar.Text) = Val(TotalHarga.Text) Then
                Kembalian.Text = 0
            Else
                Kembalian.Text = Val(Bayar.Text) - Val(TotalHarga.Text)
                Kembalian.Text = Kembalian.Text
            End If
        End If
    End Sub

    Private Sub Btnsimpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            Call OpenConn()
            Dim penjualan = New Penjualan()
            penjualan.no_penjualan = NoPenjualan.Text
            penjualan.tgl_penjualan = Format(Today, "yyyy-MM-dd")
            penjualan.kode_obat = KodeObat.Text
            penjualan.nama_obat = CbNamaObat.Text
            penjualan.exp = Format(DtPenjualan.Value, "yyyy-MM-dd")
            penjualan.harga_obat = HargaObat.Text
            penjualan.jenis_obat = JenisObat.Text
            penjualan.total_penjualan = JumlahObat.Text
            penjualan.kd_petugas = KodePetugas.Text

            penjualan.Simpan()

            Pembeli.InputPembeli(KodePembeli.Text, NamaPembeli.Text, AlamatPembeli.Text)

            Pembeli.InputDetailPenjualan(NoPenjualan.Text, KodeObat.Text, JumlahObat.Text, TotalHarga.Text, KodePembeli.Text)

            Pembeli.Kurangi_Jumlah_Obat(JumlahObat.Text, KodeObat.Text)
            MsgBox("Data Berhasil di Simpan !!!")
            Call Mati()
        Catch ex As Exception
            MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
        End Try

    End Sub

    Private Sub Btnkeluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        Dim Lap As New ReportDocument
        Lap.Load("..\..\CRV_Penjualan.rpt")
        Lap.SetParameterValue("tanggal1", DtPenjualan.Text)
        Lap.SetParameterValue("tanggal2", dt_tgl.Text)
        LPR_Penjualan.CrystalReportViewer1.ReportSource = Lap
        LPR_Penjualan.ShowDialog()
    End Sub
End Class