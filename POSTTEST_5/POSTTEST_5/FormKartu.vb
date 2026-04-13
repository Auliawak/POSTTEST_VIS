Public Class FormKartu

    Private selectedId As Integer = -1

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKoleksiCombo()
        TampilData()
        KosongkanForm()
        AddHandler txtHarga.KeyPress, Sub(s, ev) HanyaAngkaDesimal(ev, txtHarga.Text)
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged
        AddHandler dgvKartu.CellClick, AddressOf dgvKartu_CellClick
        AddHandler btnSimpan.Click, AddressOf btnSimpan_Click
        AddHandler btnUbah.Click, AddressOf btnUbah_Click
        AddHandler btnHapus.Click, AddressOf btnHapus_Click
        AddHandler btnBatal.Click, AddressOf btnBatal_Click
    End Sub

    Private Sub LoadKoleksiCombo()
        cmbKoleksi.Items.Clear()
        cmbKoleksi.Items.Add(New ComboItem("(Tanpa Koleksi)", 0))
        Dim dt = GetAllKoleksi()
        For Each row As DataRow In dt.Rows
            cmbKoleksi.Items.Add(New ComboItem(row("nama_koleksi").ToString(), Convert.ToInt32(row("id_koleksi"))))
        Next
        If cmbKoleksi.Items.Count > 0 Then cmbKoleksi.SelectedIndex = 0
    End Sub

    Private Sub TampilData()
        dgvKartu.DataSource = GetAllKartu()
        AturKolom()
    End Sub

    Private Sub AturKolom()
        If dgvKartu.Columns.Count = 0 Then Return
        If dgvKartu.Columns.Contains("id_kartu") Then
            dgvKartu.Columns("id_kartu").Visible = False
        End If
        If dgvKartu.Columns.Contains("id_koleksi") Then
            dgvKartu.Columns("id_koleksi").Visible = False
        End If
        If dgvKartu.Columns.Contains("catatan") Then
            dgvKartu.Columns("catatan").Visible = False
        End If
        Dim renames As New Dictionary(Of String, String) From {
            {"nama_kartu", "Nama Kartu"}, {"no_pokedex", "#Pokédex"},
            {"tipe", "Tipe"}, {"rarity", "Rarity"}, {"kondisi", "Kondisi"},
            {"tahun_rilis", "Tahun"}, {"harga_estimasi", "Harga Est. (Rp)"},
            {"nama_koleksi", "Set/Koleksi"}
        }
        For Each kv In renames
            If dgvKartu.Columns.Contains(kv.Key) Then
                dgvKartu.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next
    End Sub

    Private Sub KosongkanForm()
        selectedId = -1
        txtNama.Clear()
        txtPokedex.Clear()
        cmbTipe.SelectedIndex = -1
        cmbRarity.SelectedIndex = -1
        cmbKondisi.SelectedIndex = -1
        numTahun.Value = 2024
        txtHarga.Clear()
        txtCatatan.Clear()
        If cmbKoleksi.Items.Count > 0 Then cmbKoleksi.SelectedIndex = 0
        lblSelectedId.Text = "Mode: Tambah Baru"
        lblSelectedId.ForeColor = Color.FromArgb(50, 200, 100)
        lblStatus.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub IsiForm(row As DataRow)
        txtNama.Text = row("nama_kartu").ToString()
        txtPokedex.Text = row("no_pokedex").ToString()
        cmbTipe.Text = row("tipe").ToString()
        cmbRarity.Text = row("rarity").ToString()
        cmbKondisi.Text = row("kondisi").ToString()
        If Not IsDBNull(row("tahun_rilis")) Then numTahun.Value = Convert.ToInt32(row("tahun_rilis"))
        If Not IsDBNull(row("harga_estimasi")) Then txtHarga.Text = Convert.ToDecimal(row("harga_estimasi")).ToString("0")
        txtCatatan.Text = If(IsDBNull(row("catatan")), "", row("catatan").ToString())

        Dim idKol As Integer = If(IsDBNull(row("id_koleksi")), 0, Convert.ToInt32(row("id_koleksi")))
        For Each item In cmbKoleksi.Items
            Dim ci = CType(item, ComboItem)
            If ci.Value = idKol Then
                cmbKoleksi.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    Private Function ValidasiInput() As Boolean
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama kartu tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return False
        End If
        If cmbTipe.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tipe elemen kartu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTipe.Focus()
            Return False
        End If
        If cmbRarity.SelectedIndex = -1 Then
            MessageBox.Show("Pilih rarity kartu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRarity.Focus()
            Return False
        End If
        If cmbKondisi.SelectedIndex = -1 Then
            MessageBox.Show("Pilih kondisi kartu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKondisi.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function GetIdKoleksiTerpilih() As Integer
        If cmbKoleksi.SelectedItem IsNot Nothing Then
            Return CType(cmbKoleksi.SelectedItem, ComboItem).Value
        End If
        Return 0
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs)
        If Not ValidasiInput() Then Return
        Dim harga As Decimal = If(txtHarga.Text.Trim() = "", 0, Convert.ToDecimal(txtHarga.Text))
        Dim idKol As Integer = GetIdKoleksiTerpilih()

        If SimpanKartu(txtNama.Text.Trim(), txtPokedex.Text.Trim(), cmbTipe.Text,
                       cmbRarity.Text, cmbKondisi.Text, CInt(numTahun.Value),
                       harga, txtCatatan.Text.Trim(), idKol) Then
            lblStatus.Text = "Data berhasil disimpan!"
            lblStatus.ForeColor = Color.FromArgb(50, 200, 100)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs)
        If selectedId = -1 Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not ValidasiInput() Then Return
        Dim harga As Decimal = If(txtHarga.Text.Trim() = "", 0, Convert.ToDecimal(txtHarga.Text))
        Dim idKol As Integer = GetIdKoleksiTerpilih()

        If UbahKartu(selectedId, txtNama.Text.Trim(), txtPokedex.Text.Trim(), cmbTipe.Text,
                     cmbRarity.Text, cmbKondisi.Text, CInt(numTahun.Value),
                     harga, txtCatatan.Text.Trim(), idKol) Then
            lblStatus.Text = "Data berhasil diubah!"
            lblStatus.ForeColor = Color.FromArgb(50, 130, 220)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)
        If selectedId = -1 Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim namaKartu = txtNama.Text
        Dim hasil = MessageBox.Show($"Hapus kartu '{namaKartu}'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusKartu(selectedId) Then
                lblStatus.Text = "Data berhasil dihapus!"
                lblStatus.ForeColor = Color.FromArgb(220, 60, 60)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs)
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub dgvKartu_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return
        Try
            Dim row = dgvKartu.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id_kartu").Value)
            Dim dt = GetKartuById(selectedId)
            If dt.Rows.Count > 0 Then
                IsiForm(dt.Rows(0))
                lblSelectedId.Text = $"Mode: Edit | ID: {selectedId}"
                lblSelectedId.ForeColor = Color.FromArgb(255, 210, 0)
            End If
        Catch ex As Exception
            ' Ignore
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvKartu.DataSource = SearchKartu(txtSearch.Text.Trim())
            AturKolom()
        End If
    End Sub

End Class

Public Class ComboItem
    Public Property DisplayText As String
    Public Property Value As Integer

    Public Sub New(display As String, val As Integer)
        DisplayText = display
        Value = val
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class