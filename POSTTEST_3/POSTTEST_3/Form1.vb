Public Class Form1

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Gambar"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picProfil.Image = Image.FromFile(openFileDialog.FileName)
            DataModule.FotoPath = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If picProfil.Image Is Nothing Then
            MessageBox.Show("Foto Profilnya Masih Kosong Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Namanya Masih Kosong Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtUmur.Text) Then
            MessageBox.Show("Umurnya Masih Kosong Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNoTelp.Text) Then
            MessageBox.Show("No. Telponnya Masih Kosong Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNoTelp.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Alamatnya Masih Kosong Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Jenis Kelaminnya Masih Kosong Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hobbyDipilih As New List(Of String)
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                If chk.Checked Then
                    hobbyDipilih.Add(chk.Text)
                End If
            End If
        Next

        If hobbyDipilih.Count = 0 Then
            MessageBox.Show("Hobby nya Dipilih Salah Satu Bang", "BENTAR BANG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataModule.Nama = txtNama.Text.Trim()
        DataModule.Umur = txtUmur.Text.Trim()
        DataModule.TglLahir = dtpTglLahir.Value.ToString("dd/MM/yyyy")
        DataModule.NoTelp = txtNoTelp.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()
        DataModule.JenisKelamin = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
        DataModule.Hobby = String.Join(", ", hobbyDipilih)
        DataModule.FotoImage = picProfil.Image

        Dim form2 As New Form2()
        form2.Show()
    End Sub

End Class