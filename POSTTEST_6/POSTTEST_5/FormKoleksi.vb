Public Class FormKoleksi

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
    Private Sub FormKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturWarna()
        TampilData()
        KosongkanForm()
    End Sub
    Private Sub AturWarna()
        Me.BackColor = CLR_BG
        pnlHeader.BackColor = CLR_PANEL
        pnlFormInput.BackColor = CLR_PANEL
        pnlGrid.BackColor = CLR_BG

        lblHeader.ForeColor = CLR_GREEN
        lblSubHeader.ForeColor = CLR_GRAY
        lblFormTitle.ForeColor = CLR_WHITE
        lblSelectedId.ForeColor = CLR_GREEN
        lblStatus.ForeColor = CLR_GREEN

        lblNama.ForeColor = CLR_GRAY
        lblDeskripsi.ForeColor = CLR_GRAY
        lblInfoNote.ForeColor = CLR_GRAY
        lblSearch.ForeColor = CLR_WHITE

        txtNama.BackColor = CLR_INPUT
        txtNama.ForeColor = CLR_WHITE
        txtDeskripsi.BackColor = CLR_INPUT
        txtDeskripsi.ForeColor = CLR_WHITE
        txtSearch.BackColor = CLR_INPUT
        txtSearch.ForeColor = CLR_WHITE
        pnlInfoNote.BackColor = Color.FromArgb(30, 30, 60)

        AturTombol(btnSimpan, CLR_GREEN)
        AturTombol(btnUbah, CLR_BLUE)
        AturTombol(btnHapus, CLR_RED)
        AturTombol(btnBatal, CLR_GRAY)

        With dgvKoleksi
            .BackgroundColor = CLR_CARD
            .DefaultCellStyle.BackColor = CLR_CARD
            .DefaultCellStyle.ForeColor = CLR_WHITE
            .DefaultCellStyle.SelectionBackColor = CLR_GREEN
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
    Private Sub TampilData()
        dgvKoleksi.DataSource = GetAllKoleksi()
        AturKolom()
    End Sub

    Private Sub AturKolom()
        If dgvKoleksi.Columns.Count = 0 Then Return
        If dgvKoleksi.Columns.Contains("id_koleksi") Then
            dgvKoleksi.Columns("id_koleksi").Visible = False
        End If
        Dim rename As New Dictionary(Of String, String) From {
            {"nama_koleksi", "Nama Set / Koleksi"},
            {"deskripsi", "Deskripsi"},
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
        lblSelectedId.ForeColor = CLR_GREEN
        lblStatus.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama koleksi tidak boleh kosong!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Return
        End If
        If SimpanKoleksi(txtNama.Text.Trim(), txtDeskripsi.Text.Trim()) Then
            lblStatus.Text = "Koleksi berhasil disimpan!"
            lblStatus.ForeColor = CLR_GREEN
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih koleksi dari tabel terlebih dahulu!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information) : Return
        End If
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama koleksi tidak boleh kosong!", "Validasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Return
        End If
        If UbahKoleksi(selectedId, txtNama.Text.Trim(), txtDeskripsi.Text.Trim()) Then
            lblStatus.Text = "Koleksi berhasil diubah!"
            lblStatus.ForeColor = CLR_BLUE
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih koleksi dari tabel terlebih dahulu!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information) : Return
        End If
        Dim hasil = MessageBox.Show($"Hapus koleksi '{txtNama.Text}'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusKoleksi(selectedId) Then
                lblStatus.Text = "Koleksi berhasil dihapus!"
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

    Private Sub dgvKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKoleksi.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim row = dgvKoleksi.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id_koleksi").Value)
            txtNama.Text = row.Cells("nama_koleksi").Value.ToString()
            Dim desk = row.Cells("deskripsi").Value
            txtDeskripsi.Text = If(IsDBNull(desk), "", desk.ToString())
            lblSelectedId.Text = $"Mode: Edit | ID: {selectedId}"
            lblSelectedId.ForeColor = CLR_YELLOW
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvKoleksi.DataSource = SearchKoleksi(txtSearch.Text.Trim())
            AturKolom()
        End If
    End Sub

End Class