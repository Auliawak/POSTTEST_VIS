Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        LblNamaAnggota.Text = ModulData.NamaAnggota
        LblIDAnggota.Text = "ID: " & ModulData.IDAnggota
        LblDivisi.Text = ModulData.JenisKomunitas
        LblRole.Text = ModulData.Peran
        LblTelepon.Text = "Telepon  : " & ModulData.NomorTelepon
        LblEmail.Text = "Email       : " & ModulData.Email
        LblTglLahir.Text = "Tgl Lahir : " & ModulData.TanggalLahir
        LblJK.Text = "Jenis Kel  : " & ModulData.JenisKelamin
        LblAlamat.Text = "Alamat    : " & ModulData.Alamat
        LblHobi.Text = ModulData.HobiList
        If ModulData.FotoProfil <> "" Then
            Try
                PbFotoKartu.Image = Image.FromFile(ModulData.FotoProfil)
            Catch
            End Try
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpanKartu_Click(sender As Object, e As EventArgs) Handles BtnSimpanKartu.Click
        Dim hasil As DialogResult = MessageBox.Show("Simpan data kartu ke file?", "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt"
            SaveFileDialog1.Title = "Simpan Kartu Anggota"
            SaveFileDialog1.FileName = "Kartu_" & ModulData.IDAnggota
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim isi As String = "==============================" & vbCrLf
                isi &= "     KARTU ANGGOTA KOMUNITAS  " & vbCrLf
                isi &= "==============================" & vbCrLf
                isi &= "Nama       : " & ModulData.NamaAnggota & vbCrLf
                isi &= "ID Anggota : " & ModulData.IDAnggota & vbCrLf
                isi &= "Komunitas  : " & ModulData.JenisKomunitas & vbCrLf
                isi &= "Peran      : " & ModulData.Peran & vbCrLf
                isi &= "Tgl Lahir  : " & ModulData.TanggalLahir & vbCrLf
                isi &= "Jenis Kel  : " & ModulData.JenisKelamin & vbCrLf
                isi &= "Telepon    : " & ModulData.NomorTelepon & vbCrLf
                isi &= "Email      : " & ModulData.Email & vbCrLf
                isi &= "Alamat     : " & ModulData.Alamat & vbCrLf
                isi &= "Hobi       : " & ModulData.HobiList & vbCrLf
                isi &= "==============================" & vbCrLf
                IO.File.WriteAllText(SaveFileDialog1.FileName, isi)
                MessageBox.Show("Kartu berhasil disimpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class