Public Class FormKoleksi

    Private selectedId As Integer = -1

    Private Sub FormKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        KosongkanForm()
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged
        AddHandler dgvKoleksi.CellClick, AddressOf dgvKoleksi_CellClick
        AddHandler btnSimpan.Click, AddressOf btnSimpan_Click
        AddHandler btnUbah.Click, AddressOf btnUbah_Click
        AddHandler btnHapus.Click, AddressOf btnHapus_Click
        AddHandler btnBatal.Click, AddressOf btnBatal_Click
    End Sub

    Private Sub TampilData()
        dgvKoleksi.DataSource = GetAllKoleksi()
        If dgvKoleksi.Columns.Contains("id_koleksi") Then
            dgvKoleksi.Columns("id_koleksi").Visible = False
        End If
        Dim rename As New Dictionary(Of String, String) From {
            {"nama_koleksi", "Nama Set / Koleksi"}, {"deskripsi", "Deskripsi"},
            {"created_at", "Tanggal Ditambahkan"}
        }
        For Each kv In rename
            If dgvKoleksi.Columns.Contains(kv.Key) Then
                dgvKoleksi.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next
    End Sub

    Private Sub KosongkanForm()
        selectedId = -1
        txtNama.Clear()
        txtDeskripsi.Clear()
        lblSelectedId.Text = "Mode: Tambah Baru"
        lblSelectedId.ForeColor = Color.FromArgb(50, 200, 100)
        lblStatus.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs)
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama koleksi tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If
        If SimpanKoleksi(txtNama.Text.Trim(), txtDeskripsi.Text.Trim()) Then
            lblStatus.Text = "Koleksi berhasil disimpan!"
            lblStatus.ForeColor = Color.FromArgb(50, 200, 100)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs)
        If selectedId = -1 Then
            MessageBox.Show("Pilih koleksi dari tabel terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama koleksi tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If
        If UbahKoleksi(selectedId, txtNama.Text.Trim(), txtDeskripsi.Text.Trim()) Then
            lblStatus.Text = "Koleksi berhasil diubah!"
            lblStatus.ForeColor = Color.FromArgb(50, 130, 220)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)
        If selectedId = -1 Then
            MessageBox.Show("Pilih koleksi dari tabel terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim hasil = MessageBox.Show($"Hapus koleksi '{txtNama.Text}'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusKoleksi(selectedId) Then
                lblStatus.Text = "Koleksi berhasil dihapus!"
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

    Private Sub dgvKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return
        Try
            Dim row = dgvKoleksi.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id_koleksi").Value)
            txtNama.Text = row.Cells("nama_koleksi").Value.ToString()
            Dim desk = row.Cells("deskripsi").Value
            txtDeskripsi.Text = If(IsDBNull(desk), "", desk.ToString())
            lblSelectedId.Text = $"Mode: Edit | ID: {selectedId}"
            lblSelectedId.ForeColor = Color.FromArgb(255, 210, 0)
        Catch ex As Exception
            ' Ignore
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvKoleksi.DataSource = SearchKoleksi(txtSearch.Text.Trim())
            If dgvKoleksi.Columns.Contains("id_koleksi") Then
                dgvKoleksi.Columns("id_koleksi").Visible = False
            End If
        End If
    End Sub

End Class