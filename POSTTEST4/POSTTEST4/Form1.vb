Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnInputData_Click(sender As Object, e As EventArgs) Handles BtnInputData.Click
        Dim frmInput As New FormInput()
        frmInput.ShowDialog()
    End Sub

    Private Sub BtnLihatKartu_Click(sender As Object, e As EventArgs) Handles BtnLihatKartu.Click
        If ModulData.NamaAnggota = "" Then
            MessageBox.Show("Belum ada data anggota. Silakan input data terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frmKartu As New FormKartu()
            frmKartu.ShowDialog()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        Dim frmInput As New FormInput()
        frmInput.ShowDialog()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If ModulData.NamaAnggota = "" Then
            MessageBox.Show("Belum ada data anggota. Silakan input data terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frmKartu As New FormKartu()
            frmKartu.ShowDialog()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If ModulData.NamaAnggota = "" Then
            MessageBox.Show("Belum ada data untuk disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi Simpan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            SaveFileDialog1.Title = "Simpan Data Anggota"
            SaveFileDialog1.FileName = "DataAnggota_" & ModulData.IDAnggota
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim isi As String = "=== DATA KARTU KOMUNITAS ===" & vbCrLf
                isi &= "Nama         : " & ModulData.NamaAnggota & vbCrLf
                isi &= "ID Anggota   : " & ModulData.IDAnggota & vbCrLf
                isi &= "Tgl Lahir    : " & ModulData.TanggalLahir & vbCrLf
                isi &= "Jenis Kelamin: " & ModulData.JenisKelamin & vbCrLf
                isi &= "Komunitas    : " & ModulData.JenisKomunitas & vbCrLf
                isi &= "Telepon      : " & ModulData.NomorTelepon & vbCrLf
                isi &= "Email        : " & ModulData.Email & vbCrLf
                isi &= "Alamat       : " & ModulData.Alamat & vbCrLf
                isi &= "Peran        : " & ModulData.Peran & vbCrLf
                isi &= "Hobi/Aktivitas: " & ModulData.HobiList & vbCrLf
                IO.File.WriteAllText(SaveFileDialog1.FileName, isi)
                MessageBox.Show("Data berhasil disimpan ke:" & vbCrLf & SaveFileDialog1.FileName, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Buka Data Anggota"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isi, "Data Anggota - " & IO.Path.GetFileName(OpenFileDialog1.FileName), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class