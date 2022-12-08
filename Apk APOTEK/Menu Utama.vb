Public Class Menu_Utama
    Sub Terkunci()
        LOGIN.Enabled = True
        KELUAR.Enabled = True
        PETUGAS.Enabled = False
        TRANSAKSI.Enabled = False
        LAPORAN.Enabled = False
    End Sub

    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click
        Form_Login.ShowDialog()
    End Sub

    Private Sub PETUGAS_Click(sender As Object, e As EventArgs) Handles PETUGAS.Click
        Form_Petugas.ShowDialog()
    End Sub

    Private Sub KELUAR_Click(sender As Object, e As EventArgs) Handles KELUAR.Click
        End
    End Sub

    Private Sub PENJUALANOBAT_Click(sender As Object, e As EventArgs) Handles PENJUALANOBAT.Click
        Penjualan_Obat.ShowDialog()
    End Sub

    Private Sub PEMBELIANOBAT_Click(sender As Object, e As EventArgs) Handles PEMBELIANOBAT.Click
        Form_Pembelian.ShowDialog()
    End Sub

    Private Sub LAPORANPEMBELIAN_Click(sender As Object, e As EventArgs) Handles LAPORANPEMBELIAN.Click
        LPR_Pembelian.ShowDialog()
    End Sub

    Private Sub LAPORANPENJUALAN_Click(sender As Object, e As EventArgs) Handles LAPORANPENJUALAN.Click
        LPR_Penjualan.ShowDialog()
    End Sub

    Private Sub Menu_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class