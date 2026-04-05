Public Class FormInput

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TabDataUtama
        CmbKomunitas.Items.AddRange(New String() {"Teknologi & IT", "Desain Grafis", "Fotografi", "Musik & Seni", "Olahraga & Fitness", "Literasi & Menulis", "Bisnis & Kewirausahaan", "Lingkungan & Alam"})
        If ModulData.NamaAnggota <> "" Then MuatDataKeForm()
    End Sub

    Private Sub MuatDataKeForm()
        TxtNama.Text = ModulData.NamaAnggota
        TxtID.Text = ModulData.IDAnggota
        If ModulData.JenisKelamin = "Laki-laki" Then
            RbLaki.Checked = True
        ElseIf ModulData.JenisKelamin = "Perempuan" Then
            RbPerempuan.Checked = True
        End If
        Dim idx As Integer = CmbKomunitas.Items.IndexOf(ModulData.JenisKomunitas)
        If idx >= 0 Then CmbKomunitas.SelectedIndex = idx
        MtbTelepon.Text = ModulData.NomorTelepon
        TxtEmail.Text = ModulData.Email
        TxtAlamat.Text = ModulData.Alamat
        If ModulData.FotoProfil <> "" Then
            Try
                PbFoto.Image = Image.FromFile(ModulData.FotoProfil)
            Catch
            End Try
        End If
        For Each ctrl As Control In GbRole.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = CType(ctrl, RadioButton)
                If rb.Text = ModulData.Peran Then rb.Checked = True
            End If
        Next
        Dim hobiArr() As String = ModulData.HobiList.Split(","c)
        For Each ctrl As Control In PanelHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                For Each h As String In hobiArr
                    If h.Trim() = cb.Text.Trim() Then cb.Checked = True
                Next
            End If
        Next
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles TxtEmail.Leave
        If TxtEmail.Text.Trim() <> "" AndAlso Not TxtEmail.Text.Contains("@") Then
            ErrorProvider1.SetError(TxtEmail, "Format email tidak valid (harus mengandung @)")
        Else
            ErrorProvider1.SetError(TxtEmail, "")
        End If
    End Sub

    Private Sub MtbTelepon_Leave(sender As Object, e As EventArgs) Handles MtbTelepon.Leave
        If MtbTelepon.Text.Trim() <> "" AndAlso Not MtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(MtbTelepon, "Nomor telepon harus lengkap, format: 0812-3456-7890")
        Else
            ErrorProvider1.SetError(MtbTelepon, "")
        End If
    End Sub

    Private Sub BtnKeKontak_Click(sender As Object, e As EventArgs) Handles BtnKeKontak.Click
        If ValidasiTab1() Then TabControl1.SelectedTab = TabKontak
    End Sub

    Private Sub BtnKeProfil_Click(sender As Object, e As EventArgs) Handles BtnKeProfil.Click
        If ValidasiTab2() Then TabControl1.SelectedTab = tabProfil
    End Sub

    Private Sub BtnKembali1_Click(sender As Object, e As EventArgs) Handles BtnKembali1.Click
        TabControl1.SelectedTab = TabDataUtama
    End Sub

    Private Sub BtnKembali2_Click(sender As Object, e As EventArgs) Handles BtnKembali2.Click
        TabControl1.SelectedTab = TabKontak
    End Sub

    Private Sub BtnBrowseFoto_Click(sender As Object, e As EventArgs) Handles BtnBrowseFoto.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                PbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
                ModulData.FotoProfil = OpenFileDialog1.FileName
                LblNamaFoto.Text = IO.Path.GetFileName(OpenFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function ValidasiTab1() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True
        If TxtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(TxtNama, "Inputan tidak boleh kosong")
            valid = False
        End If
        If TxtID.Text.Trim() = "" Then
            ErrorProvider1.SetError(TxtID, "Inputan tidak boleh kosong")
            valid = False
        End If
        If Not RbLaki.Checked AndAlso Not RbPerempuan.Checked Then
            ErrorProvider1.SetError(RbPerempuan, "Inputan tidak boleh kosong")
            valid = False
        End If
        If CmbKomunitas.SelectedIndex = -1 Then
            ErrorProvider1.SetError(CmbKomunitas, "Inputan tidak boleh kosong")
            valid = False
        End If
        If Not valid Then
            MessageBox.Show("Harap lengkapi semua field pada Tab Data Utama.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return valid
    End Function

    Private Function ValidasiTab2() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True
        If MtbTelepon.Text.Trim() = "" OrElse Not MtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(MtbTelepon, "Inputan tidak boleh kosong atau format salah")
            valid = False
        End If
        If TxtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(TxtEmail, "Inputan tidak boleh kosong")
            valid = False
        ElseIf Not TxtEmail.Text.Contains("@") Then
            ErrorProvider1.SetError(TxtEmail, "Format email tidak valid")
            valid = False
        End If
        If TxtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(TxtAlamat, "Inputan tidak boleh kosong")
            valid = False
        End If
        If Not valid Then
            MessageBox.Show("Harap lengkapi semua field pada Tab Kontak & Info.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return valid
    End Function

    Private Function ValidasiTab3() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True
        Dim adaPeran As Boolean = False
        For Each ctrl As Control In GbRole.Controls
            If TypeOf ctrl Is RadioButton Then
                If CType(ctrl, RadioButton).Checked Then adaPeran = True
            End If
        Next
        If Not adaPeran Then
            ErrorProvider1.SetError(GbRole, "Inputan tidak boleh kosong")
            valid = False
        End If
        Dim adaHobi As Boolean = False
        For Each ctrl As Control In PanelHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then adaHobi = True
            End If
        Next
        If Not adaHobi Then
            ErrorProvider1.SetError(PanelHobi, "Inputan tidak boleh kosong")
            valid = False
        End If
        If Not valid Then
            MessageBox.Show("Harap pilih Peran dan minimal 1 Hobi/Aktivitas.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return valid
    End Function

    Private Sub BtnSimpanCetak_Click(sender As Object, e As EventArgs) Handles BtnSimpanCetak.Click
        If Not ValidasiTab1() Then
            TabControl1.SelectedTab = TabDataUtama
            Return
        End If
        If Not ValidasiTab2() Then
            TabControl1.SelectedTab = TabKontak
            Return
        End If
        If Not ValidasiTab3() Then Return

        Dim hasil As DialogResult = MessageBox.Show("Konfirmasi cetak kartu anggota?", "Konfirmasi Cetak", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            SimpanKeModul()
            MessageBox.Show("Data berhasil disimpan! Kartu siap ditampilkan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frmKartu As New FormKartu()
            frmKartu.ShowDialog()
            Me.Close()
        ElseIf hasil = DialogResult.No Then
            SimpanKeModul()
            MessageBox.Show("Data disimpan tanpa mencetak kartu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SimpanKeModul()
        ModulData.NamaAnggota = TxtNama.Text.Trim()
        ModulData.IDAnggota = TxtID.Text.Trim()
        ModulData.TanggalLahir = DtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        If RbLaki.Checked Then ModulData.JenisKelamin = "Laki-laki" Else ModulData.JenisKelamin = "Perempuan"
        ModulData.JenisKomunitas = CmbKomunitas.SelectedItem.ToString()
        ModulData.NomorTelepon = MtbTelepon.Text.Trim()
        ModulData.Email = TxtEmail.Text.Trim()
        ModulData.Alamat = TxtAlamat.Text.Trim()
        For Each ctrl As Control In GbRole.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = CType(ctrl, RadioButton)
                If rb.Checked Then ModulData.Peran = rb.Text
            End If
        Next
        Dim hobiList As New List(Of String)
        For Each ctrl As Control In PanelHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then hobiList.Add(cb.Text)
            End If
        Next
        ModulData.HobiList = String.Join(", ", hobiList)
    End Sub

End Class