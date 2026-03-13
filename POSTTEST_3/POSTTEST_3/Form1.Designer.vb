<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picProfil = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        gbJK = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        chkFotografi = New CheckBox()
        chkMemasak = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkMenulis = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMenari = New CheckBox()
        chkMemancing = New CheckBox()
        chkMembaca = New CheckBox()
        chkCoding = New CheckBox()
        chkTraveling = New CheckBox()
        chkMenggambar = New CheckBox()
        chkGaming = New CheckBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        dtpTglLahir = New DateTimePicker()
        txtNoTelp = New TextBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbJK.SuspendLayout()
        gbHobby.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.Image = CType(resources.GetObject("picProfil.Image"), Image)
        picProfil.Location = New Point(12, 34)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(225, 373)
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(243, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(243, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 3
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(243, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 4
        Label4.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(365, 31)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(230, 27)
        txtNama.TabIndex = 6
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(365, 64)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(230, 27)
        txtUmur.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(365, 130)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(230, 27)
        txtAlamat.TabIndex = 9
        ' 
        ' gbJK
        ' 
        gbJK.Controls.Add(rbPerempuan)
        gbJK.Controls.Add(rbLaki)
        gbJK.Location = New Point(243, 196)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(219, 211)
        gbJK.TabIndex = 10
        gbJK.TabStop = False
        gbJK.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(21, 74)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(22, 41)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.BackColor = Color.Transparent
        gbHobby.Controls.Add(chkFotografi)
        gbHobby.Controls.Add(chkMemasak)
        gbHobby.Controls.Add(chkMenyanyi)
        gbHobby.Controls.Add(chkMenulis)
        gbHobby.Controls.Add(chkOlahraga)
        gbHobby.Controls.Add(chkMenari)
        gbHobby.Controls.Add(chkMemancing)
        gbHobby.Controls.Add(chkMembaca)
        gbHobby.Controls.Add(chkCoding)
        gbHobby.Controls.Add(chkTraveling)
        gbHobby.Controls.Add(chkMenggambar)
        gbHobby.Controls.Add(chkGaming)
        gbHobby.Location = New Point(468, 196)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(310, 211)
        gbHobby.TabIndex = 11
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(163, 176)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(92, 24)
        chkFotografi.TabIndex = 20
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkMemasak
        ' 
        chkMemasak.AutoSize = True
        chkMemasak.Location = New Point(163, 146)
        chkMemasak.Name = "chkMemasak"
        chkMemasak.Size = New Size(94, 24)
        chkMemasak.TabIndex = 19
        chkMemasak.Text = "Memasak"
        chkMemasak.UseVisualStyleBackColor = True
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.AutoSize = True
        chkMenyanyi.Location = New Point(163, 116)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(94, 24)
        chkMenyanyi.TabIndex = 18
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(163, 86)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(82, 24)
        chkMenulis.TabIndex = 17
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(163, 56)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(92, 24)
        chkOlahraga.TabIndex = 16
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMenari
        ' 
        chkMenari.AutoSize = True
        chkMenari.Location = New Point(6, 176)
        chkMenari.Name = "chkMenari"
        chkMenari.Size = New Size(77, 24)
        chkMenari.TabIndex = 15
        chkMenari.Text = "Menari"
        chkMenari.UseVisualStyleBackColor = True
        ' 
        ' chkMemancing
        ' 
        chkMemancing.AutoSize = True
        chkMemancing.Location = New Point(163, 26)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(109, 24)
        chkMemancing.TabIndex = 4
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(6, 146)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(97, 24)
        chkMembaca.TabIndex = 3
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(6, 116)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(79, 24)
        chkCoding.TabIndex = 2
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Location = New Point(6, 86)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(91, 24)
        chkTraveling.TabIndex = 2
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Location = New Point(6, 56)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(121, 24)
        chkMenggambar.TabIndex = 1
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(6, 26)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(83, 24)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(12, 413)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(225, 29)
        btnBrowse.TabIndex = 12
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(243, 413)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(535, 29)
        btnCetak.TabIndex = 13
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Location = New Point(365, 97)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(230, 27)
        dtpTglLahir.TabIndex = 14
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(365, 163)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(413, 27)
        txtNoTelp.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(243, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 16
        Label5.Text = "No. Telp"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(586, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(217, 176)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(txtNoTelp)
        Controls.Add(dtpTglLahir)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(gbHobby)
        Controls.Add(gbJK)
        Controls.Add(txtAlamat)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picProfil)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents chkMemancing As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkMenari As CheckBox
    Friend WithEvents chkMenyanyi As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkMemasak As CheckBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
