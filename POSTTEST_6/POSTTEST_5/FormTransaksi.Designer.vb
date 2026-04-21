<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Me.txtPembeli = New System.Windows.Forms.TextBox()
        Me.lblPembeli = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cmbKartu = New System.Windows.Forms.ComboBox()
        Me.lblKartu = New System.Windows.Forms.Label()
        Me.lblSelectedId = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFormInput.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSubHeader)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 65)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubHeader.Location = New System.Drawing.Point(17, 40)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(295, 15)
        Me.lblSubHeader.TabIndex = 1
        Me.lblSubHeader.Text = "Catat riwayat pembelian dan penjualan kartu Pokémon"
        '
        ' lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(15, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(310, 30)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "💰  Riwayat Transaksi Kartu"
        '
        ' pnlFormInput
        '
        Me.pnlFormInput.Controls.Add(Me.lblStatus)
        Me.pnlFormInput.Controls.Add(Me.btnBatal)
        Me.pnlFormInput.Controls.Add(Me.btnHapus)
        Me.pnlFormInput.Controls.Add(Me.btnUbah)
        Me.pnlFormInput.Controls.Add(Me.btnSimpan)
        Me.pnlFormInput.Controls.Add(Me.txtCatatan)
        Me.pnlFormInput.Controls.Add(Me.lblCatatan)
        Me.pnlFormInput.Controls.Add(Me.txtPembeli)
        Me.pnlFormInput.Controls.Add(Me.lblPembeli)
        Me.pnlFormInput.Controls.Add(Me.dtpTanggal)
        Me.pnlFormInput.Controls.Add(Me.lblTanggal)
        Me.pnlFormInput.Controls.Add(Me.txtHarga)
        Me.pnlFormInput.Controls.Add(Me.lblHarga)
        Me.pnlFormInput.Controls.Add(Me.cmbJenis)
        Me.pnlFormInput.Controls.Add(Me.lblJenis)
        Me.pnlFormInput.Controls.Add(Me.cmbKartu)
        Me.pnlFormInput.Controls.Add(Me.lblKartu)
        Me.pnlFormInput.Controls.Add(Me.lblSelectedId)
        Me.pnlFormInput.Controls.Add(Me.lblFormTitle)
        Me.pnlFormInput.Location = New System.Drawing.Point(0, 65)
        Me.pnlFormInput.Name = "pnlFormInput"
        Me.pnlFormInput.Size = New System.Drawing.Size(400, 686)
        Me.pnlFormInput.TabIndex = 1
        '
        ' lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(15, 565)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(370, 20)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = ""
        '
        ' btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.Location = New System.Drawing.Point(300, 525)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(85, 35)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.Text = "✖  Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        ' btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.Location = New System.Drawing.Point(205, 525)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 35)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "🗑  Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        ' btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnUbah.Location = New System.Drawing.Point(110, 525)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(85, 35)
        Me.btnUbah.TabIndex = 15
        Me.btnUbah.Text = "✏️  Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        ' btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.Location = New System.Drawing.Point(15, 525)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(85, 35)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "💾  Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        ' txtCatatan
        '
        Me.txtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCatatan.Location = New System.Drawing.Point(15, 460)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCatatan.Size = New System.Drawing.Size(365, 55)
        Me.txtCatatan.TabIndex = 13
        '
        ' lblCatatan
        '
        Me.lblCatatan.AutoSize = True
        Me.lblCatatan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCatatan.Location = New System.Drawing.Point(15, 440)
        Me.lblCatatan.Name = "lblCatatan"
        Me.lblCatatan.Size = New System.Drawing.Size(53, 15)
        Me.lblCatatan.TabIndex = 12
        Me.lblCatatan.Text = "Catatan"
        '
        ' txtPembeli
        '
        Me.txtPembeli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPembeli.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPembeli.Location = New System.Drawing.Point(15, 400)
        Me.txtPembeli.Name = "txtPembeli"
        Me.txtPembeli.PlaceholderText = "Nama pembeli atau penjual..."
        Me.txtPembeli.Size = New System.Drawing.Size(365, 18)
        Me.txtPembeli.TabIndex = 11
        '
        ' lblPembeli
        '
        Me.lblPembeli.AutoSize = True
        Me.lblPembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPembeli.Location = New System.Drawing.Point(15, 380)
        Me.lblPembeli.Name = "lblPembeli"
        Me.lblPembeli.Size = New System.Drawing.Size(88, 15)
        Me.lblPembeli.TabIndex = 10
        Me.lblPembeli.Text = "Nama Pembeli"
        '
        ' dtpTanggal
        '
        Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTanggal.Location = New System.Drawing.Point(15, 340)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(365, 24)
        Me.dtpTanggal.TabIndex = 9
        '
        ' lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTanggal.Location = New System.Drawing.Point(15, 320)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(60, 15)
        Me.lblTanggal.TabIndex = 8
        Me.lblTanggal.Text = "Tanggal *"
        '
        ' txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHarga.Location = New System.Drawing.Point(15, 280)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.PlaceholderText = "Contoh: 5000000"
        Me.txtHarga.Size = New System.Drawing.Size(365, 18)
        Me.txtHarga.TabIndex = 7
        '
        ' lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.Location = New System.Drawing.Point(15, 260)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(128, 15)
        Me.lblHarga.TabIndex = 6
        Me.lblHarga.Text = "Harga Transaksi (Rp) *"
        '
        ' cmbJenis
        '
        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbJenis.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbJenis.Items.AddRange(New Object() {"Beli", "Jual"})
        Me.cmbJenis.Location = New System.Drawing.Point(15, 220)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(365, 25)
        Me.cmbJenis.TabIndex = 5
        '
        ' lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblJenis.Location = New System.Drawing.Point(15, 200)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(95, 15)
        Me.lblJenis.TabIndex = 4
        Me.lblJenis.Text = "Jenis Transaksi *"
        '
        ' cmbKartu
        '
        Me.cmbKartu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKartu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbKartu.Location = New System.Drawing.Point(15, 160)
        Me.cmbKartu.Name = "cmbKartu"
        Me.cmbKartu.Size = New System.Drawing.Size(365, 25)
        Me.cmbKartu.TabIndex = 3
        '
        ' lblKartu
        '
        Me.lblKartu.AutoSize = True
        Me.lblKartu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKartu.Location = New System.Drawing.Point(15, 140)
        Me.lblKartu.Name = "lblKartu"
        Me.lblKartu.Size = New System.Drawing.Size(60, 15)
        Me.lblKartu.TabIndex = 2
        Me.lblKartu.Text = "Kartu *"
        '
        ' lblSelectedId
        '
        Me.lblSelectedId.AutoSize = True
        Me.lblSelectedId.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSelectedId.Location = New System.Drawing.Point(15, 115)
        Me.lblSelectedId.Name = "lblSelectedId"
        Me.lblSelectedId.Size = New System.Drawing.Size(110, 13)
        Me.lblSelectedId.TabIndex = 1
        Me.lblSelectedId.Text = "Mode: Tambah Baru"
        '
        ' lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.Location = New System.Drawing.Point(15, 90)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(170, 17)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "INPUT DATA TRANSAKSI"
        '
        ' pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.dgvTransaksi)
        Me.pnlGrid.Controls.Add(Me.txtSearch)
        Me.pnlGrid.Controls.Add(Me.lblSearch)
        Me.pnlGrid.Location = New System.Drawing.Point(400, 65)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(784, 686)
        Me.pnlGrid.TabIndex = 2
        '
        ' dgvTransaksi
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransaksi.EnableHeadersVisualStyles = False
        Me.dgvTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTransaksi.Location = New System.Drawing.Point(10, 50)
        Me.dgvTransaksi.MultiSelect = False
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.RowHeadersVisible = False
        Me.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaksi.Size = New System.Drawing.Size(764, 626)
        Me.dgvTransaksi.TabIndex = 2
        '
        ' txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(160, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Cari nama kartu, jenis, atau pembeli..."
        Me.txtSearch.Size = New System.Drawing.Size(580, 20)
        Me.txtSearch.TabIndex = 1
        '
        ' lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(15, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(140, 17)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "🔍  Cari Transaksi:"
        '
        ' FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 751)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlFormInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "💰 Riwayat Transaksi"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFormInput.ResumeLayout(False)
        Me.pnlFormInput.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPembeli As System.Windows.Forms.TextBox
    Friend WithEvents lblPembeli As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents cmbKartu As System.Windows.Forms.ComboBox
    Friend WithEvents lblKartu As System.Windows.Forms.Label
    Friend WithEvents lblSelectedId As System.Windows.Forms.Label
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label

End Class