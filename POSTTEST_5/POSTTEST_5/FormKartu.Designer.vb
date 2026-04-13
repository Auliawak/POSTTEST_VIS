<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblSubHeader = New Label()
        lblHeader = New Label()
        pnlFormInput = New Panel()
        lblStatus = New Label()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        txtCatatan = New TextBox()
        lblCatatan = New Label()
        cmbKoleksi = New ComboBox()
        lblKoleksi = New Label()
        txtHarga = New TextBox()
        lblHarga = New Label()
        numTahun = New NumericUpDown()
        lblTahun = New Label()
        cmbKondisi = New ComboBox()
        lblKondisi = New Label()
        cmbRarity = New ComboBox()
        lblRarity = New Label()
        cmbTipe = New ComboBox()
        lblTipe = New Label()
        txtPokedex = New TextBox()
        lblPokedex = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        lblSelectedId = New Label()
        lblFormTitle = New Label()
        pnlGrid = New Panel()
        dgvKartu = New DataGridView()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlHeader.SuspendLayout()
        pnlFormInput.SuspendLayout()
        CType(numTahun, ComponentModel.ISupportInitialize).BeginInit()
        pnlGrid.SuspendLayout()
        CType(dgvKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(50))
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeader)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1353, 87)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.0F)
        lblSubHeader.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblSubHeader.Location = New Point(19, 53)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(348, 20)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Tambah, ubah, hapus, dan cari data kartu koleksimu"
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(255), CByte(210), CByte(0))
        lblHeader.Location = New Point(17, 13)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(375, 37)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Manajemen Kartu Pokémon"
        ' 
        ' pnlFormInput
        ' 
        pnlFormInput.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(50))
        pnlFormInput.Controls.Add(lblStatus)
        pnlFormInput.Controls.Add(btnBatal)
        pnlFormInput.Controls.Add(btnHapus)
        pnlFormInput.Controls.Add(btnUbah)
        pnlFormInput.Controls.Add(btnSimpan)
        pnlFormInput.Controls.Add(txtCatatan)
        pnlFormInput.Controls.Add(lblCatatan)
        pnlFormInput.Controls.Add(cmbKoleksi)
        pnlFormInput.Controls.Add(lblKoleksi)
        pnlFormInput.Controls.Add(txtHarga)
        pnlFormInput.Controls.Add(lblHarga)
        pnlFormInput.Controls.Add(numTahun)
        pnlFormInput.Controls.Add(lblTahun)
        pnlFormInput.Controls.Add(cmbKondisi)
        pnlFormInput.Controls.Add(lblKondisi)
        pnlFormInput.Controls.Add(cmbRarity)
        pnlFormInput.Controls.Add(lblRarity)
        pnlFormInput.Controls.Add(cmbTipe)
        pnlFormInput.Controls.Add(lblTipe)
        pnlFormInput.Controls.Add(txtPokedex)
        pnlFormInput.Controls.Add(lblPokedex)
        pnlFormInput.Controls.Add(txtNama)
        pnlFormInput.Controls.Add(lblNama)
        pnlFormInput.Controls.Add(lblSelectedId)
        pnlFormInput.Controls.Add(lblFormTitle)
        pnlFormInput.Location = New Point(0, 87)
        pnlFormInput.Margin = New Padding(3, 4, 3, 4)
        pnlFormInput.Name = "pnlFormInput"
        pnlFormInput.Size = New Size(457, 915)
        pnlFormInput.TabIndex = 1
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 9.0F)
        lblStatus.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        lblStatus.Location = New Point(17, 873)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(423, 27)
        lblStatus.TabIndex = 24
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        btnBatal.Location = New Point(343, 813)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(97, 47)
        btnBatal.TabIndex = 23
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.FromArgb(CByte(220), CByte(60), CByte(60))
        btnHapus.Location = New Point(234, 813)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(97, 47)
        btnHapus.TabIndex = 22
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.FromArgb(CByte(50), CByte(130), CByte(220))
        btnUbah.Location = New Point(126, 813)
        btnUbah.Margin = New Padding(3, 4, 3, 4)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(97, 47)
        btnUbah.TabIndex = 21
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        btnSimpan.Location = New Point(17, 813)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(97, 47)
        btnSimpan.TabIndex = 20
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtCatatan
        ' 
        txtCatatan.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtCatatan.BorderStyle = BorderStyle.None
        txtCatatan.Font = New Font("Segoe UI", 10.0F)
        txtCatatan.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtCatatan.Location = New Point(17, 713)
        txtCatatan.Margin = New Padding(3, 4, 3, 4)
        txtCatatan.Multiline = True
        txtCatatan.Name = "txtCatatan"
        txtCatatan.ScrollBars = ScrollBars.Vertical
        txtCatatan.Size = New Size(417, 87)
        txtCatatan.TabIndex = 19
        ' 
        ' lblCatatan
        ' 
        lblCatatan.AutoSize = True
        lblCatatan.Font = New Font("Segoe UI", 9.0F)
        lblCatatan.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblCatatan.Location = New Point(17, 687)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(60, 20)
        lblCatatan.TabIndex = 18
        lblCatatan.Text = "Catatan"
        ' 
        ' cmbKoleksi
        ' 
        cmbKoleksi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        cmbKoleksi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKoleksi.FlatStyle = FlatStyle.Flat
        cmbKoleksi.Font = New Font("Segoe UI", 10.0F)
        cmbKoleksi.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        cmbKoleksi.Location = New Point(17, 633)
        cmbKoleksi.Margin = New Padding(3, 4, 3, 4)
        cmbKoleksi.Name = "cmbKoleksi"
        cmbKoleksi.Size = New Size(417, 31)
        cmbKoleksi.TabIndex = 17
        ' 
        ' lblKoleksi
        ' 
        lblKoleksi.AutoSize = True
        lblKoleksi.Font = New Font("Segoe UI", 9.0F)
        lblKoleksi.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblKoleksi.Location = New Point(17, 607)
        lblKoleksi.Name = "lblKoleksi"
        lblKoleksi.Size = New Size(91, 20)
        lblKoleksi.TabIndex = 16
        lblKoleksi.Text = "Set / Koleksi"
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtHarga.BorderStyle = BorderStyle.None
        txtHarga.Font = New Font("Segoe UI", 10.0F)
        txtHarga.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtHarga.Location = New Point(17, 553)
        txtHarga.Margin = New Padding(3, 4, 3, 4)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(417, 23)
        txtHarga.TabIndex = 15
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9.0F)
        lblHarga.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblHarga.Location = New Point(17, 527)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(140, 20)
        lblHarga.TabIndex = 14
        lblHarga.Text = "Estimasi Harga (Rp)"
        ' 
        ' numTahun
        ' 
        numTahun.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        numTahun.BorderStyle = BorderStyle.None
        numTahun.Font = New Font("Segoe UI", 10.0F)
        numTahun.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        numTahun.Location = New Point(234, 473)
        numTahun.Margin = New Padding(3, 4, 3, 4)
        numTahun.Maximum = New Decimal(New Integer() {2030, 0, 0, 0})
        numTahun.Minimum = New Decimal(New Integer() {1996, 0, 0, 0})
        numTahun.Name = "numTahun"
        numTahun.Size = New Size(200, 26)
        numTahun.TabIndex = 13
        numTahun.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Font = New Font("Segoe UI", 9.0F)
        lblTahun.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblTahun.Location = New Point(234, 447)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(78, 20)
        lblTahun.TabIndex = 12
        lblTahun.Text = "Tahun Rilis"
        ' 
        ' cmbKondisi
        ' 
        cmbKondisi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        cmbKondisi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKondisi.FlatStyle = FlatStyle.Flat
        cmbKondisi.Font = New Font("Segoe UI", 10.0F)
        cmbKondisi.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        cmbKondisi.Items.AddRange(New Object() {"Mint", "Near Mint", "Excellent", "Good", "Light Played", "Played", "Poor"})
        cmbKondisi.Location = New Point(17, 473)
        cmbKondisi.Margin = New Padding(3, 4, 3, 4)
        cmbKondisi.Name = "cmbKondisi"
        cmbKondisi.Size = New Size(199, 31)
        cmbKondisi.TabIndex = 11
        ' 
        ' lblKondisi
        ' 
        lblKondisi.AutoSize = True
        lblKondisi.Font = New Font("Segoe UI", 9.0F)
        lblKondisi.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblKondisi.Location = New Point(17, 447)
        lblKondisi.Name = "lblKondisi"
        lblKondisi.Size = New Size(68, 20)
        lblKondisi.TabIndex = 10
        lblKondisi.Text = "Kondisi *"
        ' 
        ' cmbRarity
        ' 
        cmbRarity.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        cmbRarity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRarity.FlatStyle = FlatStyle.Flat
        cmbRarity.Font = New Font("Segoe UI", 10.0F)
        cmbRarity.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        cmbRarity.Items.AddRange(New Object() {"Common", "Uncommon", "Rare", "Rare Holo", "Double Rare", "Ultra Rare", "Illustration Rare", "Special Illustration Rare", "Hyper Rare"})
        cmbRarity.Location = New Point(17, 393)
        cmbRarity.Margin = New Padding(3, 4, 3, 4)
        cmbRarity.Name = "cmbRarity"
        cmbRarity.Size = New Size(417, 31)
        cmbRarity.TabIndex = 9
        ' 
        ' lblRarity
        ' 
        lblRarity.AutoSize = True
        lblRarity.Font = New Font("Segoe UI", 9.0F)
        lblRarity.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblRarity.Location = New Point(17, 367)
        lblRarity.Name = "lblRarity"
        lblRarity.Size = New Size(57, 20)
        lblRarity.TabIndex = 8
        lblRarity.Text = "Rarity *"
        ' 
        ' cmbTipe
        ' 
        cmbTipe.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipe.FlatStyle = FlatStyle.Flat
        cmbTipe.Font = New Font("Segoe UI", 10.0F)
        cmbTipe.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        cmbTipe.Items.AddRange(New Object() {"Fire", "Water", "Grass", "Lightning", "Psychic", "Fighting", "Dark", "Metal", "Fairy", "Dragon", "Colorless"})
        cmbTipe.Location = New Point(17, 313)
        cmbTipe.Margin = New Padding(3, 4, 3, 4)
        cmbTipe.Name = "cmbTipe"
        cmbTipe.Size = New Size(417, 31)
        cmbTipe.TabIndex = 7
        ' 
        ' lblTipe
        ' 
        lblTipe.AutoSize = True
        lblTipe.Font = New Font("Segoe UI", 9.0F)
        lblTipe.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblTipe.Location = New Point(17, 287)
        lblTipe.Name = "lblTipe"
        lblTipe.Size = New Size(101, 20)
        lblTipe.TabIndex = 6
        lblTipe.Text = "Tipe Elemen *"
        ' 
        ' txtPokedex
        ' 
        txtPokedex.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtPokedex.BorderStyle = BorderStyle.None
        txtPokedex.Font = New Font("Segoe UI", 10.0F)
        txtPokedex.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtPokedex.Location = New Point(17, 260)
        txtPokedex.Margin = New Padding(3, 4, 3, 4)
        txtPokedex.Name = "txtPokedex"
        txtPokedex.PlaceholderText = "#001, #025, ..."
        txtPokedex.Size = New Size(417, 23)
        txtPokedex.TabIndex = 5
        ' 
        ' lblPokedex
        ' 
        lblPokedex.AutoSize = True
        lblPokedex.Font = New Font("Segoe UI", 9.0F)
        lblPokedex.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblPokedex.Location = New Point(17, 233)
        lblPokedex.Name = "lblPokedex"
        lblPokedex.Size = New Size(100, 20)
        lblPokedex.TabIndex = 4
        lblPokedex.Text = "#No. Pokédex"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtNama.BorderStyle = BorderStyle.None
        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtNama.Location = New Point(17, 180)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama kartu Pokémon..."
        txtNama.Size = New Size(417, 23)
        txtNama.TabIndex = 3
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F)
        lblNama.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblNama.Location = New Point(17, 153)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(98, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama Kartu *"
        ' 
        ' lblSelectedId
        ' 
        lblSelectedId.AutoSize = True
        lblSelectedId.Font = New Font("Segoe UI", 8.0F)
        lblSelectedId.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        lblSelectedId.Location = New Point(17, 120)
        lblSelectedId.Name = "lblSelectedId"
        lblSelectedId.Size = New Size(131, 19)
        lblSelectedId.TabIndex = 1
        lblSelectedId.Text = "Mode: Tambah Baru"
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        lblFormTitle.Location = New Point(17, 87)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(171, 23)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "INPUT DATA KARTU"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        pnlGrid.Controls.Add(dgvKartu)
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(lblSearch)
        pnlGrid.Location = New Point(457, 87)
        pnlGrid.Margin = New Padding(3, 4, 3, 4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(896, 915)
        pnlGrid.TabIndex = 2
        ' 
        ' dgvKartu
        ' 
        dgvKartu.AllowUserToAddRows = False
        dgvKartu.AllowUserToDeleteRows = False
        dgvKartu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKartu.BackgroundColor = Color.FromArgb(CByte(35), CByte(35), CByte(65))
        dgvKartu.BorderStyle = BorderStyle.None
        dgvKartu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvKartu.ColumnHeadersHeight = 29
        dgvKartu.EnableHeadersVisualStyles = False
        dgvKartu.Font = New Font("Segoe UI", 9.0F)
        dgvKartu.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(80))
        dgvKartu.Location = New Point(11, 67)
        dgvKartu.Margin = New Padding(3, 4, 3, 4)
        dgvKartu.MultiSelect = False
        dgvKartu.Name = "dgvKartu"
        dgvKartu.ReadOnly = True
        dgvKartu.RowHeadersVisible = False
        dgvKartu.RowHeadersWidth = 51
        dgvKartu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKartu.Size = New Size(873, 835)
        dgvKartu.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI", 11.0F)
        txtSearch.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtSearch.Location = New Point(149, 17)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari nama, tipe, rarity, koleksi..."
        txtSearch.Size = New Size(686, 25)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        lblSearch.Location = New Point(17, 20)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(96, 23)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Cari Kartu:"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        ClientSize = New Size(1353, 1001)
        Controls.Add(pnlGrid)
        Controls.Add(pnlFormInput)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Kartu Pokémon"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFormInput.ResumeLayout(False)
        pnlFormInput.PerformLayout()
        CType(numTahun, ComponentModel.ISupportInitialize).EndInit()
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubHeader As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlFormInput As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents lblCatatan As System.Windows.Forms.Label
    Friend WithEvents cmbKoleksi As System.Windows.Forms.ComboBox
    Friend WithEvents lblKoleksi As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents numTahun As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTahun As System.Windows.Forms.Label
    Friend WithEvents cmbKondisi As System.Windows.Forms.ComboBox
    Friend WithEvents lblKondisi As System.Windows.Forms.Label
    Friend WithEvents cmbRarity As System.Windows.Forms.ComboBox
    Friend WithEvents lblRarity As System.Windows.Forms.Label
    Friend WithEvents cmbTipe As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipe As System.Windows.Forms.Label
    Friend WithEvents txtPokedex As System.Windows.Forms.TextBox
    Friend WithEvents lblPokedex As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblSelectedId As System.Windows.Forms.Label
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvKartu As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label

End Class