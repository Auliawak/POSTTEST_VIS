Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataModule.FotoImage IsNot Nothing Then
            picProfil.Image = DataModule.FotoImage
        End If
        lblNamaVal.Text = DataModule.Nama
        lblUmurVal.Text = DataModule.Umur
        lblTglVal.Text = DataModule.TglLahir
        lblJKVal.Text = DataModule.JenisKelamin
        lblTelpVal.Text = DataModule.NoTelp
        lblHobbyVal.Text = DataModule.Hobby
        lblAlamatVal.Text = DataModule.Alamat
    End Sub


End Class