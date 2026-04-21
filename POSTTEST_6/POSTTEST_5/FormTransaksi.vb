Public Class FormTransaksi

    Private ReadOnly CLR_BG As Color = Color.FromArgb(15, 15, 30)
    Private ReadOnly CLR_PANEL As Color = Color.FromArgb(25, 25, 50)
    Private ReadOnly CLR_CARD As Color = Color.FromArgb(35, 35, 65)
    Private ReadOnly CLR_INPUT As Color = Color.FromArgb(45, 45, 80)
    Private ReadOnly CLR_YELLOW As Color = Color.FromArgb(255, 210, 0)
    Private ReadOnly CLR_BLUE As Color = Color.FromArgb(50, 130, 220)
    Private ReadOnly CLR_GREEN As Color = Color.FromArgb(50, 200, 100)
    Private ReadOnly CLR_RED As Color = Color.FromArgb(220, 60, 60)
    Private ReadOnly CLR_ORANGE As Color = Color.FromArgb(240, 140, 30)
    Private ReadOnly CLR_WHITE As Color = Color.FromArgb(240, 240, 255)
    Private ReadOnly CLR_GRAY As Color = Color.FromArgb(120, 120, 150)

    Private selectedId As Integer = -1

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = CLR_BG
        Me.Text = "💰 Riwayat Transaksi"
        Me.Font = New Font("Segoe UI", 9)

        AturWarna()
        LoadKartuCombo()
        TampilData()
        KosongkanForm()
    End Sub

    Private Sub AturWarna()
        pnlHeader.BackColor = CLR_PANEL
        pnlFormInput.BackColor = CLR_PANEL
        pnlGrid.BackColor = CLR_BG

        lblHeader.ForeColor = CLR_ORANGE
        lblSubHeader.ForeColor = CLR_GRAY
        lblFormTitle.ForeColor = CLR_WHITE
        lblSelectedId.ForeColor = CLR_GREEN
        lblStatus.ForeColor = CLR_GREEN

        lblKartu.ForeColor = CLR_GRAY
        lblJenis.ForeColor = CLR_GRAY
        lblHarga.ForeColor = CLR_GRAY
        lblTanggal.ForeColor = CLR_GRAY
        lblPembeli.ForeColor = CLR_GRAY
        lblCatatan.ForeColor = CLR_GRAY
        lblSearch.ForeColor = CLR_WHITE

        cmbKartu.BackColor = CLR_INPUT
        cmbKartu.ForeColor = CLR_WHITE
        cmbJenis.BackColor = CLR_INPUT
        cmbJenis.ForeColor = CLR_WHITE
        txtHarga.BackColor = CLR_INPUT
        txtHarga.ForeColor = CLR_WHITE
        dtpTanggal.CalendarMonthBackground = CLR_CARD
        txtPembeli.BackColor = CLR_INPUT
        txtPembeli.ForeColor = CLR_WHITE
        txtCatatan.BackColor = CLR_INPUT
        txtCatatan.ForeColor = CLR_WHITE
        txtSearch.BackColor = CLR_INPUT
        txtSearch.ForeColor = CLR_WHITE

        AturTombol(btnSimpan, CLR_GREEN)
        AturTombol(btnUbah, CLR_BLUE)
        AturTombol(btnHapus, CLR_RED)
        AturTombol(btnBatal, CLR_GRAY)

        With dgvTransaksi
            .BackgroundColor = CLR_CARD
            .DefaultCellStyle.BackColor = CLR_CARD
            .DefaultCellStyle.ForeColor = CLR_WHITE
            .DefaultCellStyle.SelectionBackColor = CLR_ORANGE
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

    Private Sub LoadKartuCombo()
        cmbKartu.Items.Clear()
        cmbKartu.Items.Add(New ComboItem("-- Pilih Kartu --", 0))
        Dim dt = GetAllKartu()
        For Each row As DataRow In dt.Rows
            Dim label = $"[{row("no_pokedex")}] {row("nama_kartu")} — {row("tipe")}"
            cmbKartu.Items.Add(New ComboItem(label, Convert.ToInt32(row("id_kartu"))))
        Next
        If cmbKartu.Items.Count > 0 Then cmbKartu.SelectedIndex = 0
    End Sub

    Private Sub TampilData()
        dgvTransaksi.DataSource = GetAllTransaksi()
        AturKolom()
    End Sub

    Private Sub AturKolom()
        If dgvTransaksi.Columns.Count = 0 Then Return
        Dim hide = {"id_transaksi", "id_kartu"}
        For Each h In hide
            If dgvTransaksi.Columns.Contains(h) Then
                dgvTransaksi.Columns(h).Visible = False
            End If
        Next
        Dim rename As New Dictionary(Of String, String) From {
            {"nama_kartu", "Nama Kartu"},
            {"jenis", "Jenis"},
            {"harga", "Harga (Rp)"},
            {"tanggal", "Tanggal"},
            {"nama_pembeli", "Pembeli / Penjual"},
            {"catatan", "Catatan"}
        }
        For Each kv In rename
            If dgvTransaksi.Columns.Contains(kv.Key) Then
                dgvTransaksi.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next
    End Sub

    Private Sub KosongkanForm()
        selectedId = -1
        If cmbKartu.Items.Count > 0 Then cmbKartu.SelectedIndex = 0
        cmbJenis.SelectedIndex = 0
        txtHarga.Clear()
        dtpTanggal.Value = DateTime.Today
        txtPembeli.Clear()
        txtCatatan.Clear()
        lblSelectedId.Text = "Mode: Tambah Baru"
        lblSelectedId.ForeColor = CLR_GREEN
        lblStatus.Text = ""
        cmbKartu.Focus()
    End Sub

    Private Sub IsiForm(row As DataRow)
        Dim idKartu = Convert.ToInt32(row("id_kartu"))
        For Each item As Object In cmbKartu.Items
            Dim ci = CType(item, ComboItem)
            If ci.Value = idKartu Then
                cmbKartu.SelectedItem = item
                Exit For
            End If
        Next
        cmbJenis.Text = row("jenis").ToString()
        txtHarga.Text = Convert.ToDecimal(row("harga")).ToString("0")
        dtpTanggal.Value = Convert.ToDateTime(row("tanggal"))
        txtPembeli.Text = If(IsDBNull(row("nama_pembeli")), "", row("nama_pembeli").ToString())
        txtCatatan.Text = If(IsDBNull(row("catatan")), "", row("catatan").ToString())
    End Sub

    Private Function ValidasiInput() As Boolean
        If cmbKartu.SelectedIndex <= 0 Then
            MessageBox.Show("Pilih kartu terlebih dahulu!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKartu.Focus()
            Return False
        End If
        If cmbJenis.SelectedIndex = -1 Then
            MessageBox.Show("Pilih jenis transaksi!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbJenis.Focus()
            Return False
        End If
        If txtHarga.Text.Trim() = "" OrElse Convert.ToDecimal(txtHarga.Text) <= 0 Then
            MessageBox.Show("Harga transaksi harus diisi dan lebih dari 0!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function GetIdKartuTerpilih() As Integer
        If cmbKartu.SelectedItem IsNot Nothing Then
            Return CType(cmbKartu.SelectedItem, ComboItem).Value
        End If
        Return 0
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Return
        Dim harga As Decimal = Convert.ToDecimal(txtHarga.Text)

        If SimpanTransaksi(GetIdKartuTerpilih(), cmbJenis.Text, harga,
                           dtpTanggal.Value.Date, txtPembeli.Text.Trim(),
                           txtCatatan.Text.Trim()) Then
            lblStatus.Text = "✓ Transaksi berhasil disimpan!"
            lblStatus.ForeColor = CLR_GREEN
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih transaksi dari tabel terlebih dahulu!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not ValidasiInput() Then Return
        Dim harga As Decimal = Convert.ToDecimal(txtHarga.Text)

        If UbahTransaksi(selectedId, GetIdKartuTerpilih(), cmbJenis.Text, harga,
                         dtpTanggal.Value.Date, txtPembeli.Text.Trim(),
                         txtCatatan.Text.Trim()) Then
            lblStatus.Text = "✓ Transaksi berhasil diubah!"
            lblStatus.ForeColor = CLR_BLUE
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih transaksi dari tabel terlebih dahulu!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim konfirmasi = MessageBox.Show("Hapus transaksi ini?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            If HapusTransaksi(selectedId) Then
                lblStatus.Text = "✓ Transaksi berhasil dihapus!"
                lblStatus.ForeColor = CLR_RED
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick
        If e.RowIndex < 0 Then Return
        Try
            selectedId = Convert.ToInt32(dgvTransaksi.Rows(e.RowIndex).Cells("id_transaksi").Value)
            Dim dt = GetTransaksiById(selectedId)
            If dt.Rows.Count > 0 Then
                IsiForm(dt.Rows(0))
                lblSelectedId.Text = $"Mode: Edit | ID: {selectedId}"
                lblSelectedId.ForeColor = CLR_YELLOW
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvTransaksi.DataSource = SearchTransaksi(txtSearch.Text.Trim())
            AturKolom()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngkaDesimal(e, txtHarga.Text)
    End Sub

    Private Sub cmbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedIndexChanged
        If cmbJenis.Text = "Beli" Then
            lblPembeli.Text = "Nama Penjual"
        Else
            lblPembeli.Text = "Nama Pembeli"
        End If
    End Sub

End Class