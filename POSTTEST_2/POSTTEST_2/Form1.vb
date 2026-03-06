Public Class Form1

    Private Sub RefreshListBox()
        lstDaftarBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstDaftarBuku.Items.Add(FormatBuku(daftarBuku(i, 0), daftarBuku(i, 1)))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshListBox()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtTambahJudul.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Judulnya masih kosong bang!", "BANG SALAH BANG!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If genre = "" Then
            MessageBox.Show("Genrenya masih kosong bang!", "BANG SALAH BANG!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If BukuSudahAda(judul) Then
            MessageBox.Show("Itu sudah ada bang!", "GIMANA SIH!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        TambahBuku(judul, genre)
        RefreshListBox()
        txtTambahJudul.Clear()
        txtGenre.Clear()
        txtTambahJudul.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapusJudul.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Apa yang mau dihapus bang?", "BANG SALAH BANG!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim berhasil As Boolean = False
        HapusBuku(judul, berhasil)

        If berhasil Then
            RefreshListBox()
            MessageBox.Show("Buku telah dihapus!", "PUFFF",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Buku yang judulnya '" & judul & "' ngga ada bang!", "INPO BANG",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtHapusJudul.Clear()
        txtHapusJudul.Focus()
    End Sub

End Class