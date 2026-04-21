Public Class FormKartu

    Private ReadOnly CLR_BG As Color = Color.FromArgb(15, 15, 30)
    Private ReadOnly CLR_PANEL As Color = Color.FromArgb(25, 25, 50)
    Private ReadOnly CLR_CARD As Color = Color.FromArgb(35, 35, 65)
    Private ReadOnly CLR_INPUT As Color = Color.FromArgb(45, 45, 80)
    Private ReadOnly CLR_YELLOW As Color = Color.FromArgb(255, 210, 0)
    Private ReadOnly CLR_BLUE As Color = Color.FromArgb(50, 130, 220)
    Private ReadOnly CLR_GREEN As Color = Color.FromArgb(50, 200, 100)
    Private ReadOnly CLR_RED As Color = Color.FromArgb(220, 60, 60)
    Private ReadOnly CLR_WHITE As Color = Color.FromArgb(240, 240, 255)
    Private ReadOnly CLR_GRAY As Color = Color.FromArgb(120, 120, 150)

    Private selectedId As Integer = -1

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturWarna()
        LoadKoleksiCombo()
        TampilData()
        KosongkanForm()
    End Sub

    Private Sub AturWarna()
        Me.BackColor = CLR_BG
        pnlHeader.BackColor = CLR_PANEL
        pnlFormInput.BackColor = CLR_PANEL
        pnlGrid.BackColor = CLR_BG

        lblHeader.ForeColor = CLR_YELLOW
        lblSubHeader.ForeColor = CLR_GRAY
        lblFormTitle.ForeColor = CLR_WHITE
        lblSelectedId.ForeColor = CLR_GREEN
        lblStatus.ForeColor = CLR_GREEN

        lblNama.ForeColor = CLR_GRAY
        lblPokedex.ForeColor = CLR_GRAY
        lblTipe.ForeColor = CLR_GRAY
        lblRarity.ForeColor = CLR_GRAY
        lblKondisi.ForeColor = CLR_GRAY
        lblTahun.ForeColor = CLR_GRAY
        lblHarga.ForeColor = CLR_GRAY
        lblKoleksi.ForeColor = CLR_GRAY
        lblCatatan.ForeColor = CLR_GRAY
        lblSearch.ForeColor = CLR_WHITE
        lblFilterTipe.ForeColor = CLR_WHITE

        txtNama.BackColor = CLR_INPUT
        txtNama.ForeColor = CLR_WHITE
        txtPokedex.BackColor = CLR_INPUT
        txtPokedex.ForeColor = CLR_WHITE
        txtHarga.BackColor = CLR_INPUT
        txtHarga.ForeColor = CLR_WHITE
        txtCatatan.BackColor = CLR_INPUT
        txtCatatan.ForeColor = CLR_WHITE
        txtSearch.BackColor = CLR_INPUT
        txtSearch.ForeColor = CLR_WHITE

        cmbTipe.BackColor = CLR_INPUT
        cmbTipe.ForeColor = CLR_WHITE
        cmbRarity.BackColor = CLR_INPUT
        cmbRarity.ForeColor = CLR_WHITE
        cmbKondisi.BackColor = CLR_INPUT
        cmbKondisi.ForeColor = CLR_WHITE
        cmbKoleksi.BackColor = CLR_INPUT
        cmbKoleksi.ForeColor = CLR_WHITE
        cmbFilterTipe.BackColor = CLR_INPUT
        cmbFilterTipe.ForeColor = CLR_WHITE

        numTahun.BackColor = CLR_INPUT
        numTahun.ForeColor = CLR_WHITE

        AturTombol(btnSimpan, CLR_GREEN)
        AturTombol(btnUbah, CLR_BLUE)
        AturTombol(btnHapus, CLR_RED)
        AturTombol(btnBatal, CLR_GRAY)

        With dgvKartu
            .BackgroundColor = CLR_CARD
            .DefaultCellStyle.BackColor = CLR_CARD
            .DefaultCellStyle.ForeColor = CLR_WHITE
            .DefaultCellStyle.SelectionBackColor = CLR_BLUE
            .DefaultCellStyle.SelectionForeColor = CLR_WHITE
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 70)
            .ColumnHeadersDefaultCellStyle.BackColor = CLR_PANEL
            .ColumnHeadersDefaultCellStyle.ForeColor = CLR_YELLOW
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .GridColor = Color.FromArgb(50, 50, 80)
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        End With
    End Sub

    Private Sub AturTombol(btn As Button, warna As Color)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderColor = warna
        btn.FlatAppearance.BorderSize = 1
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 70)
        btn.BackColor = Color.FromArgb(40, 40, 70)
        btn.ForeColor = warna
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub LoadKoleksiCombo()
        cmbKoleksi.Items.Clear()
        cmbKoleksi.Items.Add(New ComboItem("(Tanpa Koleksi)", 0))
        Dim dt = GetAllKoleksi()
        For Each row As DataRow In dt.Rows
            cmbKoleksi.Items.Add(New ComboItem(row("nama_koleksi").ToString(),
                                               Convert.ToInt32(row("id_koleksi"))))
        Next
        If cmbKoleksi.Items.Count > 0 Then cmbKoleksi.SelectedIndex = 0
    End Sub

    Private Sub TampilData()
        dgvKartu.DataSource = GetAllKartu()
        AturKolom()
    End Sub

    Private Sub AturKolom()
        If dgvKartu.Columns.Count = 0 Then Return
        Dim sembunyikan = {"id_kartu", "id_koleksi", "catatan"}
        For Each h In sembunyikan
            If dgvKartu.Columns.Contains(h) Then dgvKartu.Columns(h).Visible = False
        Next
        Dim rename As New Dictionary(Of String, String) From {
            {"nama_kartu", "Nama Kartu"},
            {"no_pokedex", "#Pokédex"},
            {"tipe", "Tipe"},
            {"rarity", "Rarity"},
            {"kondisi", "Kondisi"},
            {"tahun_rilis", "Tahun"},
            {"harga_estimasi", "Harga Est. (Rp)"},
            {"nama_koleksi", "Set/Koleksi"}
        }
        For Each kv In rename
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
        lblSelectedId.ForeColor = CLR_GREEN
        lblStatus.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub IsiForm(row As DataRow)
        txtNama.Text = row("nama_kartu").ToString()
        txtPokedex.Text = row("no_pokedex").ToString()
        cmbTipe.Text = row("tipe").ToString()
        cmbRarity.Text = row("rarity").ToString()
        cmbKondisi.Text = row("kondisi").ToString()
        If Not IsDBNull(row("tahun_rilis")) Then
            numTahun.Value = Convert.ToInt32(row("tahun_rilis"))
        End If
        If Not IsDBNull(row("harga_estimasi")) Then
            txtHarga.Text = Convert.ToDecimal(row("harga_estimasi")).ToString("0")
        End If
        txtCatatan.Text = If(IsDBNull(row("catatan")), "", row("catatan").ToString())

        Dim idKol As Integer = If(IsDBNull(row("id_koleksi")), 0, Convert.ToInt32(row("id_koleksi")))
        For Each item As Object In cmbKoleksi.Items
            Dim ci = CType(item, ComboItem)
            If ci.Value = idKol Then
                cmbKoleksi.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    Private Function ValidasiInput() As Boolean
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama kartu tidak boleh kosong!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Return False
        End If
        If cmbTipe.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tipe elemen kartu!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTipe.Focus() : Return False
        End If
        If cmbRarity.SelectedIndex = -1 Then
            MessageBox.Show("Pilih rarity kartu!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRarity.Focus() : Return False
        End If
        If cmbKondisi.SelectedIndex = -1 Then
            MessageBox.Show("Pilih kondisi kartu!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKondisi.Focus() : Return False
        End If
        Return True
    End Function

    Private Function GetIdKoleksiTerpilih() As Integer
        If cmbKoleksi.SelectedItem IsNot Nothing Then
            Return CType(cmbKoleksi.SelectedItem, ComboItem).Value
        End If
        Return 0
    End Function

    Private Sub TerapkanFilter()
        Dim keyword = txtSearch.Text.Trim()
        Dim tipe = If(cmbFilterTipe.SelectedIndex <= 0, "", cmbFilterTipe.Text)

        If keyword = "" AndAlso tipe = "" Then
            TampilData()
        ElseIf keyword <> "" AndAlso tipe = "" Then
            dgvKartu.DataSource = SearchKartu(keyword)
            AturKolom()
        ElseIf keyword = "" AndAlso tipe <> "" Then
            dgvKartu.DataSource = FilterKartuByTipe(tipe)
            AturKolom()
        Else
            dgvKartu.DataSource = FilterKartuByTipeAndKeyword(tipe, keyword)
            AturKolom()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Return
        Dim harga As Decimal = If(txtHarga.Text.Trim() = "", 0D,
                                  Convert.ToDecimal(txtHarga.Text))
        Dim idKol = GetIdKoleksiTerpilih()

        If SimpanKartu(txtNama.Text.Trim(), txtPokedex.Text.Trim(),
                       cmbTipe.Text, cmbRarity.Text, cmbKondisi.Text,
                       CInt(numTahun.Value), harga,
                       txtCatatan.Text.Trim(), idKol) Then
            lblStatus.Text = "Data berhasil disimpan!"
            lblStatus.ForeColor = CLR_GREEN
            TerapkanFilter()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information) : Return
        End If
        If Not ValidasiInput() Then Return
        Dim harga As Decimal = If(txtHarga.Text.Trim() = "", 0D,
                                  Convert.ToDecimal(txtHarga.Text))
        Dim idKol = GetIdKoleksiTerpilih()

        If UbahKartu(selectedId, txtNama.Text.Trim(), txtPokedex.Text.Trim(),
                     cmbTipe.Text, cmbRarity.Text, cmbKondisi.Text,
                     CInt(numTahun.Value), harga,
                     txtCatatan.Text.Trim(), idKol) Then
            lblStatus.Text = "Data berhasil diubah!"
            lblStatus.ForeColor = CLR_BLUE
            TerapkanFilter()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information) : Return
        End If
        Dim hasil = MessageBox.Show($"Hapus kartu '{txtNama.Text}'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusKartu(selectedId) Then
                lblStatus.Text = "Data berhasil dihapus!"
                lblStatus.ForeColor = CLR_RED
                TerapkanFilter()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
        cmbFilterTipe.SelectedIndex = 0
        txtSearch.Clear()
    End Sub

    Private Sub dgvKartu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKartu.CellClick
        If e.RowIndex < 0 Then Return
        Try
            selectedId = Convert.ToInt32(dgvKartu.Rows(e.RowIndex).Cells("id_kartu").Value)
            Dim dt = GetKartuById(selectedId)
            If dt.Rows.Count > 0 Then
                IsiForm(dt.Rows(0))
                lblSelectedId.Text = $"Mode: Edit | ID: {selectedId}"
                lblSelectedId.ForeColor = CLR_YELLOW
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TerapkanFilter()
    End Sub

    Private Sub cmbFilterTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterTipe.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngkaDesimal(e, txtHarga.Text)
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