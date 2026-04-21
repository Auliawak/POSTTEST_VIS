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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlFormInput = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.lblCatatan = New System.Windows.Forms.Label()
        Me.cmbKoleksi = New System.Windows.Forms.ComboBox()
        Me.lblKoleksi = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.numTahun = New System.Windows.Forms.NumericUpDown()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.cmbKondisi = New System.Windows.Forms.ComboBox()
        Me.lblKondisi = New System.Windows.Forms.Label()
        Me.cmbRarity = New System.Windows.Forms.ComboBox()
        Me.lblRarity = New System.Windows.Forms.Label()
        Me.cmbTipe = New System.Windows.Forms.ComboBox()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.txtPokedex = New System.Windows.Forms.TextBox()
        Me.lblPokedex = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblSelectedId = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvKartu = New System.Windows.Forms.DataGridView()
        Me.cmbFilterTipe = New System.Windows.Forms.ComboBox()
        Me.lblFilterTipe = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFormInput.SuspendLayout()
        CType(Me.numTahun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' pnlHeader
        Me.pnlHeader.Controls.Add(Me.lblSubHeader)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 65)
        Me.pnlHeader.TabIndex = 0
        ' lblSubHeader
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubHeader.Location = New System.Drawing.Point(17, 40)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.TabIndex = 1
        Me.lblSubHeader.Text = "Tambah, ubah, hapus, cari, dan filter data kartu koleksimu"
        ' lblHeader
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(15, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Manajemen Kartu Pokemon"
        ' pnlFormInput
        Me.pnlFormInput.Controls.Add(Me.lblStatus)
        Me.pnlFormInput.Controls.Add(Me.btnBatal)
        Me.pnlFormInput.Controls.Add(Me.btnHapus)
        Me.pnlFormInput.Controls.Add(Me.btnUbah)
        Me.pnlFormInput.Controls.Add(Me.btnSimpan)
        Me.pnlFormInput.Controls.Add(Me.txtCatatan)
        Me.pnlFormInput.Controls.Add(Me.lblCatatan)
        Me.pnlFormInput.Controls.Add(Me.cmbKoleksi)
        Me.pnlFormInput.Controls.Add(Me.lblKoleksi)
        Me.pnlFormInput.Controls.Add(Me.txtHarga)
        Me.pnlFormInput.Controls.Add(Me.lblHarga)
        Me.pnlFormInput.Controls.Add(Me.numTahun)
        Me.pnlFormInput.Controls.Add(Me.lblTahun)
        Me.pnlFormInput.Controls.Add(Me.cmbKondisi)
        Me.pnlFormInput.Controls.Add(Me.lblKondisi)
        Me.pnlFormInput.Controls.Add(Me.cmbRarity)
        Me.pnlFormInput.Controls.Add(Me.lblRarity)
        Me.pnlFormInput.Controls.Add(Me.cmbTipe)
        Me.pnlFormInput.Controls.Add(Me.lblTipe)
        Me.pnlFormInput.Controls.Add(Me.txtPokedex)
        Me.pnlFormInput.Controls.Add(Me.lblPokedex)
        Me.pnlFormInput.Controls.Add(Me.txtNama)
        Me.pnlFormInput.Controls.Add(Me.lblNama)
        Me.pnlFormInput.Controls.Add(Me.lblSelectedId)
        Me.pnlFormInput.Controls.Add(Me.lblFormTitle)
        Me.pnlFormInput.Location = New System.Drawing.Point(0, 65)
        Me.pnlFormInput.Name = "pnlFormInput"
        Me.pnlFormInput.Size = New System.Drawing.Size(400, 686)
        Me.pnlFormInput.TabIndex = 1
        ' lblStatus
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(15, 655)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(370, 20)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Text = ""
        ' btnBatal
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.Location = New System.Drawing.Point(300, 610)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(85, 35)
        Me.btnBatal.TabIndex = 23
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        ' btnHapus
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.Location = New System.Drawing.Point(205, 610)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 35)
        Me.btnHapus.TabIndex = 22
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        ' btnUbah
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnUbah.Location = New System.Drawing.Point(110, 610)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(85, 35)
        Me.btnUbah.TabIndex = 21
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        ' btnSimpan
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.Location = New System.Drawing.Point(15, 610)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(85, 35)
        Me.btnSimpan.TabIndex = 20
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        ' txtCatatan
        Me.txtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCatatan.Location = New System.Drawing.Point(15, 535)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCatatan.Size = New System.Drawing.Size(365, 65)
        Me.txtCatatan.TabIndex = 19
        ' lblCatatan
        Me.lblCatatan.AutoSize = True
        Me.lblCatatan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCatatan.Location = New System.Drawing.Point(15, 515)
        Me.lblCatatan.Name = "lblCatatan"
        Me.lblCatatan.TabIndex = 18
        Me.lblCatatan.Text = "Catatan"
        ' cmbKoleksi
        Me.cmbKoleksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKoleksi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbKoleksi.Location = New System.Drawing.Point(15, 475)
        Me.cmbKoleksi.Name = "cmbKoleksi"
        Me.cmbKoleksi.Size = New System.Drawing.Size(365, 25)
        Me.cmbKoleksi.TabIndex = 17
        ' lblKoleksi
        Me.lblKoleksi.AutoSize = True
        Me.lblKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKoleksi.Location = New System.Drawing.Point(15, 455)
        Me.lblKoleksi.Name = "lblKoleksi"
        Me.lblKoleksi.TabIndex = 16
        Me.lblKoleksi.Text = "Set / Koleksi"
        ' txtHarga
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHarga.Location = New System.Drawing.Point(15, 415)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.PlaceholderText = "0"
        Me.txtHarga.Size = New System.Drawing.Size(365, 18)
        Me.txtHarga.TabIndex = 15
        ' lblHarga
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.Location = New System.Drawing.Point(15, 395)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.TabIndex = 14
        Me.lblHarga.Text = "Estimasi Harga (Rp)"
        ' numTahun
        Me.numTahun.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numTahun.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.numTahun.Location = New System.Drawing.Point(205, 355)
        Me.numTahun.Maximum = New Decimal(New Integer() {2030, 0, 0, 0})
        Me.numTahun.Minimum = New Decimal(New Integer() {1996, 0, 0, 0})
        Me.numTahun.Name = "numTahun"
        Me.numTahun.Size = New System.Drawing.Size(175, 18)
        Me.numTahun.TabIndex = 13
        Me.numTahun.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' lblTahun
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTahun.Location = New System.Drawing.Point(205, 335)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.TabIndex = 12
        Me.lblTahun.Text = "Tahun Rilis"
        ' cmbKondisi
        Me.cmbKondisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKondisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKondisi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbKondisi.Items.AddRange(New Object() {
            "Mint", "Near Mint", "Excellent", "Good", "Light Played", "Played", "Poor"})
        Me.cmbKondisi.Location = New System.Drawing.Point(15, 355)
        Me.cmbKondisi.Name = "cmbKondisi"
        Me.cmbKondisi.Size = New System.Drawing.Size(175, 25)
        Me.cmbKondisi.TabIndex = 11
        ' lblKondisi
        Me.lblKondisi.AutoSize = True
        Me.lblKondisi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKondisi.Location = New System.Drawing.Point(15, 335)
        Me.lblKondisi.Name = "lblKondisi"
        Me.lblKondisi.TabIndex = 10
        Me.lblKondisi.Text = "Kondisi *"
        ' cmbRarity
        Me.cmbRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRarity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRarity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRarity.Items.AddRange(New Object() {
            "Common", "Uncommon", "Rare", "Rare Holo", "Double Rare",
            "Ultra Rare", "Illustration Rare", "Special Illustration Rare", "Hyper Rare"})
        Me.cmbRarity.Location = New System.Drawing.Point(15, 295)
        Me.cmbRarity.Name = "cmbRarity"
        Me.cmbRarity.Size = New System.Drawing.Size(365, 25)
        Me.cmbRarity.TabIndex = 9
        ' lblRarity
        Me.lblRarity.AutoSize = True
        Me.lblRarity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRarity.Location = New System.Drawing.Point(15, 275)
        Me.lblRarity.Name = "lblRarity"
        Me.lblRarity.TabIndex = 8
        Me.lblRarity.Text = "Rarity *"
        ' cmbTipe (untuk input)
        Me.cmbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipe.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTipe.Items.AddRange(New Object() {
            "Fire", "Water", "Grass", "Lightning", "Psychic",
            "Fighting", "Dark", "Metal", "Fairy", "Dragon", "Colorless"})
        Me.cmbTipe.Location = New System.Drawing.Point(15, 235)
        Me.cmbTipe.Name = "cmbTipe"
        Me.cmbTipe.Size = New System.Drawing.Size(365, 25)
        Me.cmbTipe.TabIndex = 7
        ' lblTipe
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipe.Location = New System.Drawing.Point(15, 215)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.TabIndex = 6
        Me.lblTipe.Text = "Tipe Elemen *"
        ' txtPokedex
        Me.txtPokedex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPokedex.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPokedex.Location = New System.Drawing.Point(15, 195)
        Me.txtPokedex.Name = "txtPokedex"
        Me.txtPokedex.PlaceholderText = "#001, #025, ..."
        Me.txtPokedex.Size = New System.Drawing.Size(365, 18)
        Me.txtPokedex.TabIndex = 5
        ' lblPokedex
        Me.lblPokedex.AutoSize = True
        Me.lblPokedex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPokedex.Location = New System.Drawing.Point(15, 175)
        Me.lblPokedex.Name = "lblPokedex"
        Me.lblPokedex.TabIndex = 4
        Me.lblPokedex.Text = "#No. Pokedex"
        ' txtNama
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNama.Location = New System.Drawing.Point(15, 135)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PlaceholderText = "Nama kartu Pokemon..."
        Me.txtNama.Size = New System.Drawing.Size(365, 18)
        Me.txtNama.TabIndex = 3
        ' lblNama
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.Location = New System.Drawing.Point(15, 115)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama Kartu *"
        ' lblSelectedId
        Me.lblSelectedId.AutoSize = True
        Me.lblSelectedId.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSelectedId.Location = New System.Drawing.Point(15, 90)
        Me.lblSelectedId.Name = "lblSelectedId"
        Me.lblSelectedId.TabIndex = 1
        Me.lblSelectedId.Text = "Mode: Tambah Baru"
        ' lblFormTitle
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.Location = New System.Drawing.Point(15, 65)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "INPUT DATA KARTU"
        ' pnlGrid
        Me.pnlGrid.Controls.Add(Me.dgvKartu)
        Me.pnlGrid.Controls.Add(Me.cmbFilterTipe)
        Me.pnlGrid.Controls.Add(Me.lblFilterTipe)
        Me.pnlGrid.Controls.Add(Me.txtSearch)
        Me.pnlGrid.Controls.Add(Me.lblSearch)
        Me.pnlGrid.Location = New System.Drawing.Point(400, 65)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(784, 686)
        Me.pnlGrid.TabIndex = 2
        ' dgvKartu
        Me.dgvKartu.AllowUserToAddRows = False
        Me.dgvKartu.AllowUserToDeleteRows = False
        Me.dgvKartu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKartu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKartu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvKartu.EnableHeadersVisualStyles = False
        Me.dgvKartu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKartu.Location = New System.Drawing.Point(10, 55)
        Me.dgvKartu.MultiSelect = False
        Me.dgvKartu.Name = "dgvKartu"
        Me.dgvKartu.ReadOnly = True
        Me.dgvKartu.RowHeadersVisible = False
        Me.dgvKartu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKartu.Size = New System.Drawing.Size(764, 621)
        Me.dgvKartu.TabIndex = 4
        ' cmbFilterTipe — filter berdasarkan tipe elemen (FITUR BARU)
        Me.cmbFilterTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFilterTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbFilterTipe.Items.AddRange(New Object() {
            "Semua Tipe",
            "Fire", "Water", "Grass", "Lightning", "Psychic",
            "Fighting", "Dark", "Metal", "Fairy", "Dragon", "Colorless"})
        Me.cmbFilterTipe.Location = New System.Drawing.Point(530, 13)
        Me.cmbFilterTipe.Name = "cmbFilterTipe"
        Me.cmbFilterTipe.Size = New System.Drawing.Size(140, 23)
        Me.cmbFilterTipe.TabIndex = 3
        Me.cmbFilterTipe.SelectedIndex = 0
        ' lblFilterTipe
        Me.lblFilterTipe.AutoSize = True
        Me.lblFilterTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilterTipe.Location = New System.Drawing.Point(445, 16)
        Me.lblFilterTipe.Name = "lblFilterTipe"
        Me.lblFilterTipe.TabIndex = 2
        Me.lblFilterTipe.Text = "Filter Tipe:"
        ' txtSearch
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(130, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Cari nama, tipe, rarity, koleksi..."
        Me.txtSearch.Size = New System.Drawing.Size(300, 20)
        Me.txtSearch.TabIndex = 1
        ' lblSearch
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(15, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Cari Kartu:"
        ' FormKartu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 751)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlFormInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormKartu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Kartu Pokemon"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFormInput.ResumeLayout(False)
        Me.pnlFormInput.PerformLayout()
        CType(Me.numTahun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.dgvKartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
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
    Friend WithEvents cmbFilterTipe As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilterTipe As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label

End Class