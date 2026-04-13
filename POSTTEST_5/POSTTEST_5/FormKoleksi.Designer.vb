<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKoleksi
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
        pnlInfoNote = New Panel()
        lblInfoNote = New Label()
        lblStatus = New Label()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        txtDeskripsi = New TextBox()
        lblDeskripsi = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        lblSelectedId = New Label()
        lblFormTitle = New Label()
        pnlGrid = New Panel()
        dgvKoleksi = New DataGridView()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlHeader.SuspendLayout()
        pnlFormInput.SuspendLayout()
        pnlInfoNote.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvKoleksi, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Size = New Size(1067, 87)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.0F)
        lblSubHeader.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblSubHeader.Location = New Point(19, 53)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(302, 20)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Kelola set dan seri kartu Pokémon koleksimu"
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        lblHeader.Location = New Point(17, 13)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(424, 35)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Manajemen Set / Koleksi Pokémon"
        ' 
        ' pnlFormInput
        ' 
        pnlFormInput.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(50))
        pnlFormInput.Controls.Add(pnlInfoNote)
        pnlFormInput.Controls.Add(lblStatus)
        pnlFormInput.Controls.Add(btnBatal)
        pnlFormInput.Controls.Add(btnHapus)
        pnlFormInput.Controls.Add(btnUbah)
        pnlFormInput.Controls.Add(btnSimpan)
        pnlFormInput.Controls.Add(txtDeskripsi)
        pnlFormInput.Controls.Add(lblDeskripsi)
        pnlFormInput.Controls.Add(txtNama)
        pnlFormInput.Controls.Add(lblNama)
        pnlFormInput.Controls.Add(lblSelectedId)
        pnlFormInput.Controls.Add(lblFormTitle)
        pnlFormInput.Location = New Point(0, 87)
        pnlFormInput.Margin = New Padding(3, 4, 3, 4)
        pnlFormInput.Name = "pnlFormInput"
        pnlFormInput.Size = New Size(400, 781)
        pnlFormInput.TabIndex = 1
        ' 
        ' pnlInfoNote
        ' 
        pnlInfoNote.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(60))
        pnlInfoNote.Controls.Add(lblInfoNote)
        pnlInfoNote.Location = New Point(17, 507)
        pnlInfoNote.Margin = New Padding(3, 4, 3, 4)
        pnlInfoNote.Name = "pnlInfoNote"
        pnlInfoNote.Size = New Size(360, 133)
        pnlInfoNote.TabIndex = 11
        ' 
        ' lblInfoNote
        ' 
        lblInfoNote.Font = New Font("Segoe UI", 8.0F)
        lblInfoNote.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblInfoNote.Location = New Point(11, 13)
        lblInfoNote.Name = "lblInfoNote"
        lblInfoNote.Size = New Size(337, 107)
        lblInfoNote.TabIndex = 0
        lblInfoNote.Text = "Catatan:" & vbCrLf & "• Koleksi yang masih memiliki" & vbCrLf & "  kartu tidak dapat dihapus." & vbCrLf & "• Pindahkan kartu ke koleksi" & vbCrLf & "  lain terlebih dahulu."
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 9.0F)
        lblStatus.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        lblStatus.Location = New Point(17, 460)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(360, 27)
        lblStatus.TabIndex = 10
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("STXinwei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        btnBatal.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        btnBatal.Location = New Point(326, 400)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(46, 47)
        btnBatal.TabIndex = 9
        btnBatal.Text = "X"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.FromArgb(CByte(220), CByte(60), CByte(60))
        btnHapus.Location = New Point(223, 400)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 47)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.FromArgb(CByte(50), CByte(130), CByte(220))
        btnUbah.Location = New Point(120, 400)
        btnUbah.Margin = New Padding(3, 4, 3, 4)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 47)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        btnSimpan.Location = New Point(17, 400)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 47)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtDeskripsi.BorderStyle = BorderStyle.None
        txtDeskripsi.Font = New Font("Segoe UI", 10.0F)
        txtDeskripsi.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtDeskripsi.Location = New Point(17, 213)
        txtDeskripsi.Margin = New Padding(3, 4, 3, 4)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.PlaceholderText = "Deskripsi singkat tentang set ini..."
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(360, 160)
        txtDeskripsi.TabIndex = 5
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.Font = New Font("Segoe UI", 9.0F)
        lblDeskripsi.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblDeskripsi.Location = New Point(17, 187)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(69, 20)
        lblDeskripsi.TabIndex = 4
        lblDeskripsi.Text = "Deskripsi"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtNama.BorderStyle = BorderStyle.None
        txtNama.Font = New Font("Segoe UI", 11.0F)
        txtNama.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtNama.Location = New Point(17, 133)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Contoh: Base Set, Sword & Shield..."
        txtNama.Size = New Size(360, 25)
        txtNama.TabIndex = 3
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F)
        lblNama.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblNama.Location = New Point(17, 107)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(145, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama Set / Koleksi *"
        ' 
        ' lblSelectedId
        ' 
        lblSelectedId.AutoSize = True
        lblSelectedId.Font = New Font("Segoe UI", 8.0F)
        lblSelectedId.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        lblSelectedId.Location = New Point(17, 73)
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
        lblFormTitle.Location = New Point(17, 40)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(183, 23)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "INPUT DATA KOLEKSI"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        pnlGrid.Controls.Add(dgvKoleksi)
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(lblSearch)
        pnlGrid.Location = New Point(400, 87)
        pnlGrid.Margin = New Padding(3, 4, 3, 4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(667, 781)
        pnlGrid.TabIndex = 2
        ' 
        ' dgvKoleksi
        ' 
        dgvKoleksi.AllowUserToAddRows = False
        dgvKoleksi.AllowUserToDeleteRows = False
        dgvKoleksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKoleksi.BackgroundColor = Color.FromArgb(CByte(35), CByte(35), CByte(65))
        dgvKoleksi.BorderStyle = BorderStyle.None
        dgvKoleksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvKoleksi.ColumnHeadersHeight = 29
        dgvKoleksi.EnableHeadersVisualStyles = False
        dgvKoleksi.Font = New Font("Segoe UI", 9.0F)
        dgvKoleksi.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(80))
        dgvKoleksi.Location = New Point(11, 67)
        dgvKoleksi.Margin = New Padding(3, 4, 3, 4)
        dgvKoleksi.MultiSelect = False
        dgvKoleksi.Name = "dgvKoleksi"
        dgvKoleksi.ReadOnly = True
        dgvKoleksi.RowHeadersVisible = False
        dgvKoleksi.RowHeadersWidth = 51
        dgvKoleksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKoleksi.Size = New Size(645, 701)
        dgvKoleksi.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(80))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI", 11.0F)
        txtSearch.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        txtSearch.Location = New Point(91, 17)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari nama atau deskripsi koleksi..."
        txtSearch.Size = New Size(549, 25)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        lblSearch.Location = New Point(17, 20)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(47, 23)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Cari:"
        ' 
        ' FormKoleksi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        ClientSize = New Size(1067, 868)
        Controls.Add(pnlGrid)
        Controls.Add(pnlFormInput)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormKoleksi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Koleksi / Set"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFormInput.ResumeLayout(False)
        pnlFormInput.PerformLayout()
        pnlInfoNote.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvKoleksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubHeader As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlFormInput As System.Windows.Forms.Panel
    Friend WithEvents pnlInfoNote As System.Windows.Forms.Panel
    Friend WithEvents lblInfoNote As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents lblDeskripsi As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblSelectedId As System.Windows.Forms.Label
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvKoleksi As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label

End Class