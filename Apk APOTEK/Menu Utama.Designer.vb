<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MASTER = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGIN = New System.Windows.Forms.ToolStripMenuItem()
        Me.PETUGAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENJUALANOBAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMBELIANOBAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANPEMBELIAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANPENJUALAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTER, Me.TRANSAKSI, Me.LAPORAN})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTER
        '
        Me.MASTER.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGIN, Me.PETUGAS, Me.KELUAR})
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(104, 26)
        Me.MASTER.Text = "MASTER"
        '
        'LOGIN
        '
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(170, 26)
        Me.LOGIN.Text = "LOGIN"
        '
        'PETUGAS
        '
        Me.PETUGAS.Name = "PETUGAS"
        Me.PETUGAS.Size = New System.Drawing.Size(170, 26)
        Me.PETUGAS.Text = "PETUGAS"
        '
        'KELUAR
        '
        Me.KELUAR.Name = "KELUAR"
        Me.KELUAR.Size = New System.Drawing.Size(170, 26)
        Me.KELUAR.Text = "KELUAR"
        '
        'TRANSAKSI
        '
        Me.TRANSAKSI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENJUALANOBAT, Me.PEMBELIANOBAT})
        Me.TRANSAKSI.Name = "TRANSAKSI"
        Me.TRANSAKSI.Size = New System.Drawing.Size(132, 26)
        Me.TRANSAKSI.Text = "TRANSAKSI"
        '
        'PENJUALANOBAT
        '
        Me.PENJUALANOBAT.Name = "PENJUALANOBAT"
        Me.PENJUALANOBAT.Size = New System.Drawing.Size(253, 26)
        Me.PENJUALANOBAT.Text = "PENJUALAN OBAT"
        '
        'PEMBELIANOBAT
        '
        Me.PEMBELIANOBAT.Name = "PEMBELIANOBAT"
        Me.PEMBELIANOBAT.Size = New System.Drawing.Size(253, 26)
        Me.PEMBELIANOBAT.Text = "PEMBELIAN OBAT"
        '
        'LAPORAN
        '
        Me.LAPORAN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LAPORANPEMBELIAN, Me.LAPORANPENJUALAN})
        Me.LAPORAN.Name = "LAPORAN"
        Me.LAPORAN.Size = New System.Drawing.Size(115, 26)
        Me.LAPORAN.Text = "LAPORAN"
        '
        'LAPORANPEMBELIAN
        '
        Me.LAPORANPEMBELIAN.Name = "LAPORANPEMBELIAN"
        Me.LAPORANPEMBELIAN.Size = New System.Drawing.Size(293, 26)
        Me.LAPORANPEMBELIAN.Text = "LAPORAN PEMBELIAN"
        '
        'LAPORANPENJUALAN
        '
        Me.LAPORANPENJUALAN.Name = "LAPORANPENJUALAN"
        Me.LAPORANPENJUALAN.Size = New System.Drawing.Size(293, 26)
        Me.LAPORANPENJUALAN.Text = "LAPORAN PENJUALAN"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MASTER As ToolStripMenuItem
    Friend WithEvents LOGIN As ToolStripMenuItem
    Friend WithEvents PETUGAS As ToolStripMenuItem
    Friend WithEvents KELUAR As ToolStripMenuItem
    Friend WithEvents TRANSAKSI As ToolStripMenuItem
    Friend WithEvents PENJUALANOBAT As ToolStripMenuItem
    Friend WithEvents PEMBELIANOBAT As ToolStripMenuItem
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents LAPORANPEMBELIAN As ToolStripMenuItem
    Friend WithEvents LAPORANPENJUALAN As ToolStripMenuItem
End Class
