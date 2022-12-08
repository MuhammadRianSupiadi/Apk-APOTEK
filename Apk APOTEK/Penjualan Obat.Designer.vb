<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan_Obat
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AlamatPembeli = New System.Windows.Forms.TextBox()
        Me.NamaPembeli = New System.Windows.Forms.TextBox()
        Me.KodePembeli = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TotalHarga = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.KodePetugas = New System.Windows.Forms.Label()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Dgpenjualan = New System.Windows.Forms.DataGridView()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Bayar = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.DtPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.Tglpenjualan = New System.Windows.Forms.Label()
        Me.HargaObat = New System.Windows.Forms.Label()
        Me.JenisObat = New System.Windows.Forms.Label()
        Me.KodeObat = New System.Windows.Forms.Label()
        Me.NoPenjualan = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.JumlahObat = New System.Windows.Forms.TextBox()
        Me.CbNamaObat = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Cetak = New System.Windows.Forms.Button()
        Me.dt_tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(397, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(260, 31)
        Me.Label21.TabIndex = 122
        Me.Label21.Text = "PENJUALAN OBAT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.AlamatPembeli)
        Me.GroupBox1.Controls.Add(Me.NamaPembeli)
        Me.GroupBox1.Controls.Add(Me.KodePembeli)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(587, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 182)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PEMBELI"
        '
        'AlamatPembeli
        '
        Me.AlamatPembeli.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatPembeli.Location = New System.Drawing.Point(245, 126)
        Me.AlamatPembeli.Name = "AlamatPembeli"
        Me.AlamatPembeli.Size = New System.Drawing.Size(136, 26)
        Me.AlamatPembeli.TabIndex = 38
        '
        'NamaPembeli
        '
        Me.NamaPembeli.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaPembeli.Location = New System.Drawing.Point(245, 82)
        Me.NamaPembeli.Name = "NamaPembeli"
        Me.NamaPembeli.Size = New System.Drawing.Size(136, 26)
        Me.NamaPembeli.TabIndex = 37
        '
        'KodePembeli
        '
        Me.KodePembeli.AutoSize = True
        Me.KodePembeli.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePembeli.Location = New System.Drawing.Point(241, 37)
        Me.KodePembeli.Name = "KodePembeli"
        Me.KodePembeli.Size = New System.Drawing.Size(102, 19)
        Me.KodePembeli.TabIndex = 33
        Me.KodePembeli.Text = "Kode Pembeli"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(195, 129)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 19)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(195, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 19)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(195, 38)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 19)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(59, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 19)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Kode Pembeli"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(59, 85)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(106, 19)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Nama Pembeli"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(59, 129)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 19)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Alamat Pembeli"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(128, 297)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 19)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = ":"
        '
        'TotalHarga
        '
        Me.TotalHarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHarga.Location = New System.Drawing.Point(151, 295)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.Size = New System.Drawing.Size(393, 26)
        Me.TotalHarga.TabIndex = 110
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 298)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 19)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "Total Harga"
        '
        'KodePetugas
        '
        Me.KodePetugas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KodePetugas.AutoSize = True
        Me.KodePetugas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePetugas.Location = New System.Drawing.Point(877, 105)
        Me.KodePetugas.Name = "KodePetugas"
        Me.KodePetugas.Size = New System.Drawing.Size(102, 19)
        Me.KodePetugas.TabIndex = 108
        Me.KodePetugas.Text = "Kode Petugas"
        '
        'btn_keluar
        '
        Me.btn_keluar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_keluar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_keluar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(400, 327)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 39)
        Me.btn_keluar.TabIndex = 121
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_simpan.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(308, 327)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 39)
        Me.btn_simpan.TabIndex = 120
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Dgpenjualan
        '
        Me.Dgpenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgpenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgpenjualan.Location = New System.Drawing.Point(27, 372)
        Me.Dgpenjualan.Name = "Dgpenjualan"
        Me.Dgpenjualan.Size = New System.Drawing.Size(1002, 191)
        Me.Dgpenjualan.TabIndex = 119
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(895, 336)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 19)
        Me.Label32.TabIndex = 118
        Me.Label32.Text = ":"
        '
        'Kembalian
        '
        Me.Kembalian.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Kembalian.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kembalian.Location = New System.Drawing.Point(915, 320)
        Me.Kembalian.Multiline = True
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(114, 46)
        Me.Kembalian.TabIndex = 117
        Me.Kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(818, 336)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 19)
        Me.Label33.TabIndex = 116
        Me.Label33.Text = "Kembalian"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(629, 336)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 19)
        Me.Label30.TabIndex = 115
        Me.Label30.Text = ":"
        '
        'Bayar
        '
        Me.Bayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bayar.Cursor = System.Windows.Forms.Cursors.Help
        Me.Bayar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bayar.Location = New System.Drawing.Point(653, 320)
        Me.Bayar.Multiline = True
        Me.Bayar.Name = "Bayar"
        Me.Bayar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bayar.Size = New System.Drawing.Size(152, 45)
        Me.Bayar.TabIndex = 114
        Me.Bayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(583, 336)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 19)
        Me.Label31.TabIndex = 113
        Me.Label31.Text = "Bayar"
        '
        'DtPenjualan
        '
        Me.DtPenjualan.CustomFormat = "dd/MM/yyyy"
        Me.DtPenjualan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPenjualan.Location = New System.Drawing.Point(151, 170)
        Me.DtPenjualan.Name = "DtPenjualan"
        Me.DtPenjualan.Size = New System.Drawing.Size(98, 26)
        Me.DtPenjualan.TabIndex = 123
        '
        'Tglpenjualan
        '
        Me.Tglpenjualan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tglpenjualan.AutoSize = True
        Me.Tglpenjualan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tglpenjualan.Location = New System.Drawing.Point(877, 74)
        Me.Tglpenjualan.Name = "Tglpenjualan"
        Me.Tglpenjualan.Size = New System.Drawing.Size(100, 19)
        Me.Tglpenjualan.TabIndex = 107
        Me.Tglpenjualan.Text = "Tgl Penjualan"
        '
        'HargaObat
        '
        Me.HargaObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HargaObat.AutoSize = True
        Me.HargaObat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaObat.Location = New System.Drawing.Point(151, 203)
        Me.HargaObat.Name = "HargaObat"
        Me.HargaObat.Size = New System.Drawing.Size(88, 19)
        Me.HargaObat.TabIndex = 106
        Me.HargaObat.Text = "Harga Obat"
        '
        'JenisObat
        '
        Me.JenisObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JenisObat.AutoSize = True
        Me.JenisObat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisObat.Location = New System.Drawing.Point(151, 236)
        Me.JenisObat.Name = "JenisObat"
        Me.JenisObat.Size = New System.Drawing.Size(81, 19)
        Me.JenisObat.TabIndex = 105
        Me.JenisObat.Text = "Jenis Obat"
        '
        'KodeObat
        '
        Me.KodeObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KodeObat.AutoSize = True
        Me.KodeObat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeObat.Location = New System.Drawing.Point(151, 106)
        Me.KodeObat.Name = "KodeObat"
        Me.KodeObat.Size = New System.Drawing.Size(82, 19)
        Me.KodeObat.TabIndex = 104
        Me.KodeObat.Text = "Kode Obat"
        '
        'NoPenjualan
        '
        Me.NoPenjualan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoPenjualan.AutoSize = True
        Me.NoPenjualan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPenjualan.Location = New System.Drawing.Point(151, 74)
        Me.NoPenjualan.Name = "NoPenjualan"
        Me.NoPenjualan.Size = New System.Drawing.Size(98, 19)
        Me.NoPenjualan.TabIndex = 103
        Me.NoPenjualan.Text = "No Penjualan"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(818, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 19)
        Me.Label18.TabIndex = 102
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(818, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 19)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(128, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 19)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(128, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 19)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(128, 233)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 19)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(128, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 19)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(128, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 19)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(128, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 19)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = ":"
        '
        'JumlahObat
        '
        Me.JumlahObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JumlahObat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahObat.Location = New System.Drawing.Point(151, 263)
        Me.JumlahObat.Name = "JumlahObat"
        Me.JumlahObat.Size = New System.Drawing.Size(393, 26)
        Me.JumlahObat.TabIndex = 94
        '
        'CbNamaObat
        '
        Me.CbNamaObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbNamaObat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNamaObat.FormattingEnabled = True
        Me.CbNamaObat.Location = New System.Drawing.Point(151, 138)
        Me.CbNamaObat.Name = "CbNamaObat"
        Me.CbNamaObat.Size = New System.Drawing.Size(393, 27)
        Me.CbNamaObat.TabIndex = 93
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(128, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 19)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(670, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Tgl Penjualan"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(670, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Kode Petugas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Jumlah Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 19)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Exp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Harga Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Jenis Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Nama Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Kode Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "No Penjualan"
        '
        'btn_Cetak
        '
        Me.btn_Cetak.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Cetak.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_Cetak.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cetak.Location = New System.Drawing.Point(492, 327)
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.Size = New System.Drawing.Size(75, 39)
        Me.btn_Cetak.TabIndex = 124
        Me.btn_Cetak.Text = "Cetak"
        Me.btn_Cetak.UseVisualStyleBackColor = False
        '
        'dt_tgl
        '
        Me.dt_tgl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_tgl.CustomFormat = "dd/MM/yyyy"
        Me.dt_tgl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_tgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_tgl.Location = New System.Drawing.Point(299, 170)
        Me.dt_tgl.Name = "dt_tgl"
        Me.dt_tgl.Size = New System.Drawing.Size(149, 26)
        Me.dt_tgl.TabIndex = 125
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(254, 176)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 19)
        Me.Label22.TabIndex = 126
        Me.Label22.Text = "S/d"
        '
        'Penjualan_Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1055, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dt_tgl)
        Me.Controls.Add(Me.btn_Cetak)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TotalHarga)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.KodePetugas)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Dgpenjualan)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Bayar)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.DtPenjualan)
        Me.Controls.Add(Me.Tglpenjualan)
        Me.Controls.Add(Me.HargaObat)
        Me.Controls.Add(Me.JenisObat)
        Me.Controls.Add(Me.KodeObat)
        Me.Controls.Add(Me.NoPenjualan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.JumlahObat)
        Me.Controls.Add(Me.CbNamaObat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Penjualan_Obat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AlamatPembeli As TextBox
    Friend WithEvents NamaPembeli As TextBox
    Friend WithEvents KodePembeli As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TotalHarga As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents KodePetugas As Label
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Dgpenjualan As DataGridView
    Friend WithEvents Label32 As Label
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Bayar As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents DtPenjualan As DateTimePicker
    Friend WithEvents Tglpenjualan As Label
    Friend WithEvents HargaObat As Label
    Friend WithEvents JenisObat As Label
    Friend WithEvents KodeObat As Label
    Friend WithEvents NoPenjualan As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents JumlahObat As TextBox
    Friend WithEvents CbNamaObat As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Cetak As Button
    Friend WithEvents dt_tgl As DateTimePicker
    Friend WithEvents Label22 As Label
End Class
