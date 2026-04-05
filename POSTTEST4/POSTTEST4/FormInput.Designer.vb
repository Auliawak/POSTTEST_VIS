<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        TabControl1 = New TabControl()
        TabDataUtama = New TabPage()
        BtnTutup = New Button()
        CmbKomunitas = New ComboBox()
        BtnKeKontak = New Button()
        RbPerempuan = New RadioButton()
        RbLaki = New RadioButton()
        Label5 = New Label()
        DtpTanggalLahir = New DateTimePicker()
        TxtID = New TextBox()
        TxtNama = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TabKontak = New TabPage()
        BtnKembali1 = New Button()
        BtnKeProfil = New Button()
        MtbTelepon = New MaskedTextBox()
        TxtAlamat = New TextBox()
        TxtEmail = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tabProfil = New TabPage()
        LblNamaFoto = New Label()
        CbOlahraga = New CheckBox()
        CbMusik = New CheckBox()
        CbMemasak = New CheckBox()
        CbGaming = New CheckBox()
        CbMenulis = New CheckBox()
        CbDesain = New CheckBox()
        CbFotografi = New CheckBox()
        CbProgramming = New CheckBox()
        Label10 = New Label()
        Label3 = New Label()
        GbRole = New GroupBox()
        RbMid = New RadioButton()
        RbRoam = New RadioButton()
        RbExp = New RadioButton()
        RbGold = New RadioButton()
        RbJungle = New RadioButton()
        BtnSimpanCetak = New Button()
        BtnKembali2 = New Button()
        BtnBrowseFoto = New Button()
        PbFoto = New PictureBox()
        PanelHobi = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1.SuspendLayout()
        TabDataUtama.SuspendLayout()
        TabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        GbRole.SuspendLayout()
        CType(PbFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabDataUtama)
        TabControl1.Controls.Add(TabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(798, 408)
        TabControl1.TabIndex = 0
        ' 
        ' TabDataUtama
        ' 
        TabDataUtama.BackColor = Color.Transparent
        TabDataUtama.BackgroundImage = My.Resources.Resources.eposbg
        TabDataUtama.Controls.Add(BtnTutup)
        TabDataUtama.Controls.Add(CmbKomunitas)
        TabDataUtama.Controls.Add(BtnKeKontak)
        TabDataUtama.Controls.Add(RbPerempuan)
        TabDataUtama.Controls.Add(RbLaki)
        TabDataUtama.Controls.Add(Label5)
        TabDataUtama.Controls.Add(DtpTanggalLahir)
        TabDataUtama.Controls.Add(TxtID)
        TabDataUtama.Controls.Add(TxtNama)
        TabDataUtama.Controls.Add(Label6)
        TabDataUtama.Controls.Add(Label7)
        TabDataUtama.Controls.Add(Label8)
        TabDataUtama.Controls.Add(Label9)
        TabDataUtama.ForeColor = Color.Coral
        TabDataUtama.Location = New Point(4, 29)
        TabDataUtama.Name = "TabDataUtama"
        TabDataUtama.Padding = New Padding(3)
        TabDataUtama.Size = New Size(790, 375)
        TabDataUtama.TabIndex = 0
        TabDataUtama.Text = "Data Utama"
        ' 
        ' BtnTutup
        ' 
        BtnTutup.BackColor = Color.Crimson
        BtnTutup.ForeColor = Color.WhiteSmoke
        BtnTutup.Location = New Point(20, 329)
        BtnTutup.Name = "BtnTutup"
        BtnTutup.Size = New Size(94, 29)
        BtnTutup.TabIndex = 39
        BtnTutup.Text = "Tutup"
        BtnTutup.UseVisualStyleBackColor = False
        ' 
        ' CmbKomunitas
        ' 
        CmbKomunitas.FormattingEnabled = True
        CmbKomunitas.Location = New Point(86, 210)
        CmbKomunitas.Name = "CmbKomunitas"
        CmbKomunitas.Size = New Size(230, 28)
        CmbKomunitas.TabIndex = 38
        ' 
        ' BtnKeKontak
        ' 
        BtnKeKontak.BackColor = Color.MidnightBlue
        BtnKeKontak.ForeColor = Color.WhiteSmoke
        BtnKeKontak.Location = New Point(674, 329)
        BtnKeKontak.Name = "BtnKeKontak"
        BtnKeKontak.Size = New Size(94, 29)
        BtnKeKontak.TabIndex = 37
        BtnKeKontak.Text = "Lanjut"
        BtnKeKontak.UseVisualStyleBackColor = False
        ' 
        ' RbPerempuan
        ' 
        RbPerempuan.AutoSize = True
        RbPerempuan.ForeColor = Color.WhiteSmoke
        RbPerempuan.Location = New Point(476, 141)
        RbPerempuan.Name = "RbPerempuan"
        RbPerempuan.Size = New Size(104, 24)
        RbPerempuan.TabIndex = 36
        RbPerempuan.TabStop = True
        RbPerempuan.Text = "Perempuan"
        RbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RbLaki
        ' 
        RbLaki.AutoSize = True
        RbLaki.ForeColor = Color.WhiteSmoke
        RbLaki.Location = New Point(369, 141)
        RbLaki.Name = "RbLaki"
        RbLaki.Size = New Size(86, 24)
        RbLaki.TabIndex = 35
        RbLaki.TabStop = True
        RbLaki.Text = "Laki Laki"
        RbLaki.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(369, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 34
        Label5.Text = "Jenis Kelamin"
        ' 
        ' DtpTanggalLahir
        ' 
        DtpTanggalLahir.Location = New Point(86, 138)
        DtpTanggalLahir.Name = "DtpTanggalLahir"
        DtpTanggalLahir.Size = New Size(230, 27)
        DtpTanggalLahir.TabIndex = 33
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(369, 66)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(230, 27)
        TxtID.TabIndex = 32
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(86, 66)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(230, 27)
        TxtNama.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.WhiteSmoke
        Label6.Location = New Point(369, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 20)
        Label6.TabIndex = 29
        Label6.Text = "ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(86, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 28
        Label7.Text = "Tanggal Lahir"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.White
        Label8.Location = New Point(86, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 20)
        Label8.TabIndex = 27
        Label8.Text = "Divisi/Komunitas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(86, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 20)
        Label9.TabIndex = 26
        Label9.Text = "Nama"
        ' 
        ' TabKontak
        ' 
        TabKontak.AutoScroll = True
        TabKontak.BackColor = Color.DarkBlue
        TabKontak.BackgroundImage = My.Resources.Resources.eposbg
        TabKontak.Controls.Add(BtnKembali1)
        TabKontak.Controls.Add(BtnKeProfil)
        TabKontak.Controls.Add(MtbTelepon)
        TabKontak.Controls.Add(TxtAlamat)
        TabKontak.Controls.Add(TxtEmail)
        TabKontak.Controls.Add(Label4)
        TabKontak.Controls.Add(Label2)
        TabKontak.Controls.Add(Label1)
        TabKontak.Location = New Point(4, 29)
        TabKontak.Name = "TabKontak"
        TabKontak.Padding = New Padding(3)
        TabKontak.Size = New Size(790, 375)
        TabKontak.TabIndex = 1
        TabKontak.Text = "Kontak & Info"
        ' 
        ' BtnKembali1
        ' 
        BtnKembali1.BackColor = Color.MidnightBlue
        BtnKembali1.ForeColor = Color.WhiteSmoke
        BtnKembali1.Location = New Point(20, 326)
        BtnKembali1.Name = "BtnKembali1"
        BtnKembali1.Size = New Size(94, 29)
        BtnKembali1.TabIndex = 24
        BtnKembali1.Text = "Kembali"
        BtnKembali1.UseVisualStyleBackColor = False
        ' 
        ' BtnKeProfil
        ' 
        BtnKeProfil.BackColor = Color.MidnightBlue
        BtnKeProfil.ForeColor = Color.WhiteSmoke
        BtnKeProfil.Location = New Point(669, 326)
        BtnKeProfil.Name = "BtnKeProfil"
        BtnKeProfil.Size = New Size(94, 29)
        BtnKeProfil.TabIndex = 23
        BtnKeProfil.Text = "Lanjut"
        BtnKeProfil.UseVisualStyleBackColor = False
        ' 
        ' MtbTelepon
        ' 
        MtbTelepon.Location = New Point(20, 52)
        MtbTelepon.Mask = "0000-0000-0000"
        MtbTelepon.Name = "MtbTelepon"
        MtbTelepon.Size = New Size(208, 27)
        MtbTelepon.TabIndex = 22
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(20, 140)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(513, 78)
        TxtAlamat.TabIndex = 21
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(303, 52)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(230, 27)
        TxtEmail.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(303, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 18
        Label4.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 16
        Label2.Text = "Alamat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(20, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 15
        Label1.Text = "No. Hp"
        ' 
        ' tabProfil
        ' 
        tabProfil.BackgroundImage = CType(resources.GetObject("tabProfil.BackgroundImage"), Image)
        tabProfil.Controls.Add(LblNamaFoto)
        tabProfil.Controls.Add(CbOlahraga)
        tabProfil.Controls.Add(CbMusik)
        tabProfil.Controls.Add(CbMemasak)
        tabProfil.Controls.Add(CbGaming)
        tabProfil.Controls.Add(CbMenulis)
        tabProfil.Controls.Add(CbDesain)
        tabProfil.Controls.Add(CbFotografi)
        tabProfil.Controls.Add(CbProgramming)
        tabProfil.Controls.Add(Label10)
        tabProfil.Controls.Add(Label3)
        tabProfil.Controls.Add(GbRole)
        tabProfil.Controls.Add(BtnSimpanCetak)
        tabProfil.Controls.Add(BtnKembali2)
        tabProfil.Controls.Add(BtnBrowseFoto)
        tabProfil.Controls.Add(PbFoto)
        tabProfil.Controls.Add(PanelHobi)
        tabProfil.Location = New Point(4, 29)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(790, 375)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' LblNamaFoto
        ' 
        LblNamaFoto.AutoSize = True
        LblNamaFoto.ForeColor = Color.WhiteSmoke
        LblNamaFoto.Location = New Point(27, 268)
        LblNamaFoto.Name = "LblNamaFoto"
        LblNamaFoto.Size = New Size(64, 20)
        LblNamaFoto.TabIndex = 16
        LblNamaFoto.Text = "Foto.jpg"
        ' 
        ' CbOlahraga
        ' 
        CbOlahraga.AutoSize = True
        CbOlahraga.ForeColor = Color.WhiteSmoke
        CbOlahraga.Location = New Point(330, 151)
        CbOlahraga.Name = "CbOlahraga"
        CbOlahraga.Size = New Size(92, 24)
        CbOlahraga.TabIndex = 14
        CbOlahraga.Text = "Olahraga"
        CbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' CbMusik
        ' 
        CbMusik.AutoSize = True
        CbMusik.ForeColor = Color.WhiteSmoke
        CbMusik.Location = New Point(183, 242)
        CbMusik.Name = "CbMusik"
        CbMusik.Size = New Size(105, 24)
        CbMusik.TabIndex = 13
        CbMusik.Text = "Musik & Seni"
        CbMusik.UseVisualStyleBackColor = True
        ' 
        ' CbMemasak
        ' 
        CbMemasak.AutoSize = True
        CbMemasak.ForeColor = Color.WhiteSmoke
        CbMemasak.Location = New Point(330, 242)
        CbMemasak.Name = "CbMemasak"
        CbMemasak.Size = New Size(94, 24)
        CbMemasak.TabIndex = 12
        CbMemasak.Text = "Memasak"
        CbMemasak.TextAlign = ContentAlignment.BottomLeft
        CbMemasak.UseVisualStyleBackColor = True
        ' 
        ' CbGaming
        ' 
        CbGaming.AutoSize = True
        CbGaming.ForeColor = Color.WhiteSmoke
        CbGaming.Location = New Point(330, 212)
        CbGaming.Name = "CbGaming"
        CbGaming.Size = New Size(83, 24)
        CbGaming.TabIndex = 11
        CbGaming.Text = "Gaming"
        CbGaming.UseVisualStyleBackColor = True
        ' 
        ' CbMenulis
        ' 
        CbMenulis.AutoSize = True
        CbMenulis.ForeColor = Color.WhiteSmoke
        CbMenulis.Location = New Point(330, 181)
        CbMenulis.Name = "CbMenulis"
        CbMenulis.Size = New Size(82, 24)
        CbMenulis.TabIndex = 10
        CbMenulis.Text = "Menulis"
        CbMenulis.UseVisualStyleBackColor = True
        ' 
        ' CbDesain
        ' 
        CbDesain.AutoSize = True
        CbDesain.ForeColor = Color.WhiteSmoke
        CbDesain.Location = New Point(183, 181)
        CbDesain.Name = "CbDesain"
        CbDesain.Size = New Size(118, 24)
        CbDesain.TabIndex = 9
        CbDesain.Text = "Desain Grafis"
        CbDesain.UseVisualStyleBackColor = True
        ' 
        ' CbFotografi
        ' 
        CbFotografi.AutoSize = True
        CbFotografi.ForeColor = Color.WhiteSmoke
        CbFotografi.Location = New Point(184, 212)
        CbFotografi.Name = "CbFotografi"
        CbFotografi.Size = New Size(92, 24)
        CbFotografi.TabIndex = 8
        CbFotografi.Text = "Fotografi"
        CbFotografi.UseVisualStyleBackColor = True
        ' 
        ' CbProgramming
        ' 
        CbProgramming.AutoSize = True
        CbProgramming.ForeColor = Color.WhiteSmoke
        CbProgramming.Location = New Point(183, 151)
        CbProgramming.Name = "CbProgramming"
        CbProgramming.Size = New Size(122, 24)
        CbProgramming.TabIndex = 7
        CbProgramming.Text = "Programming"
        CbProgramming.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.WhiteSmoke
        Label10.Location = New Point(183, 128)
        Label10.Name = "Label10"
        Label10.Size = New Size(114, 20)
        Label10.TabIndex = 6
        Label10.Text = "Hobby/Aktifitas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(49, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 5
        Label3.Text = "Foto Profil"
        ' 
        ' GbRole
        ' 
        GbRole.Controls.Add(RbMid)
        GbRole.Controls.Add(RbRoam)
        GbRole.Controls.Add(RbExp)
        GbRole.Controls.Add(RbGold)
        GbRole.Controls.Add(RbJungle)
        GbRole.ForeColor = Color.WhiteSmoke
        GbRole.Location = New Point(183, 41)
        GbRole.Name = "GbRole"
        GbRole.Size = New Size(573, 73)
        GbRole.TabIndex = 4
        GbRole.TabStop = False
        GbRole.Text = "Role"
        ' 
        ' RbMid
        ' 
        RbMid.AutoSize = True
        RbMid.Location = New Point(360, 31)
        RbMid.Name = "RbMid"
        RbMid.Size = New Size(91, 24)
        RbMid.TabIndex = 4
        RbMid.TabStop = True
        RbMid.Text = "Mid Lane"
        RbMid.UseVisualStyleBackColor = True
        ' 
        ' RbRoam
        ' 
        RbRoam.AutoSize = True
        RbRoam.Location = New Point(286, 31)
        RbRoam.Name = "RbRoam"
        RbRoam.Size = New Size(69, 24)
        RbRoam.TabIndex = 3
        RbRoam.TabStop = True
        RbRoam.Text = "Roam"
        RbRoam.UseVisualStyleBackColor = True
        ' 
        ' RbExp
        ' 
        RbExp.AutoSize = True
        RbExp.Location = New Point(188, 30)
        RbExp.Name = "RbExp"
        RbExp.Size = New Size(90, 24)
        RbExp.TabIndex = 2
        RbExp.TabStop = True
        RbExp.Text = "EXP Lane"
        RbExp.UseVisualStyleBackColor = True
        ' 
        ' RbGold
        ' 
        RbGold.AutoSize = True
        RbGold.Location = New Point(86, 30)
        RbGold.Name = "RbGold"
        RbGold.Size = New Size(97, 24)
        RbGold.TabIndex = 1
        RbGold.TabStop = True
        RbGold.Text = "Gold Lane"
        RbGold.UseVisualStyleBackColor = True
        ' 
        ' RbJungle
        ' 
        RbJungle.AutoSize = True
        RbJungle.Location = New Point(10, 30)
        RbJungle.Name = "RbJungle"
        RbJungle.Size = New Size(72, 24)
        RbJungle.TabIndex = 0
        RbJungle.TabStop = True
        RbJungle.Text = "Jungle"
        RbJungle.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpanCetak
        ' 
        BtnSimpanCetak.BackColor = Color.Lime
        BtnSimpanCetak.ForeColor = Color.Black
        BtnSimpanCetak.Location = New Point(608, 333)
        BtnSimpanCetak.Name = "BtnSimpanCetak"
        BtnSimpanCetak.Size = New Size(148, 29)
        BtnSimpanCetak.TabIndex = 3
        BtnSimpanCetak.Text = "Simpan dan Cetak"
        BtnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' BtnKembali2
        ' 
        BtnKembali2.BackColor = Color.MidnightBlue
        BtnKembali2.ForeColor = Color.WhiteSmoke
        BtnKembali2.Location = New Point(27, 333)
        BtnKembali2.Name = "BtnKembali2"
        BtnKembali2.Size = New Size(94, 29)
        BtnKembali2.TabIndex = 2
        BtnKembali2.Text = "Kembali"
        BtnKembali2.UseVisualStyleBackColor = False
        ' 
        ' BtnBrowseFoto
        ' 
        BtnBrowseFoto.Location = New Point(27, 236)
        BtnBrowseFoto.Name = "BtnBrowseFoto"
        BtnBrowseFoto.Size = New Size(125, 29)
        BtnBrowseFoto.TabIndex = 1
        BtnBrowseFoto.Text = "Browse"
        BtnBrowseFoto.UseVisualStyleBackColor = True
        ' 
        ' PbFoto
        ' 
        PbFoto.BackColor = Color.DarkSlateBlue
        PbFoto.BackgroundImage = CType(resources.GetObject("PbFoto.BackgroundImage"), Image)
        PbFoto.BackgroundImageLayout = ImageLayout.Stretch
        PbFoto.Location = New Point(27, 64)
        PbFoto.Name = "PbFoto"
        PbFoto.Size = New Size(125, 166)
        PbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PbFoto.TabIndex = 0
        PbFoto.TabStop = False
        ' 
        ' PanelHobi
        ' 
        PanelHobi.Location = New Point(183, 128)
        PanelHobi.Name = "PanelHobi"
        PanelHobi.Size = New Size(255, 138)
        PanelHobi.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "Form2"
        TabControl1.ResumeLayout(False)
        TabDataUtama.ResumeLayout(False)
        TabDataUtama.PerformLayout()
        TabKontak.ResumeLayout(False)
        TabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        tabProfil.PerformLayout()
        GbRole.ResumeLayout(False)
        GbRole.PerformLayout()
        CType(PbFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabDataUtama As TabPage
    Friend WithEvents TabKontak As TabPage
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RbPerempuan As RadioButton
    Private RbLaki As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpTanggalLahir As DateTimePicker
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MtbTelepon As MaskedTextBox
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents BtnSimpanCetak As Button
    Friend WithEvents BtnKembali2 As Button
    Friend WithEvents BtnBrowseFoto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GbRole As GroupBox
    Friend WithEvents RbGold As RadioButton
    Friend WithEvents RbJungle As RadioButton
    Friend WithEvents RbMid As RadioButton
    Friend WithEvents RbRoam As RadioButton
    Friend WithEvents RbExp As RadioButton
    Friend WithEvents CbOlahraga As CheckBox
    Friend WithEvents CbMusik As CheckBox
    Friend WithEvents CbMemasak As CheckBox
    Friend WithEvents CbGaming As CheckBox
    Friend WithEvents CbMenulis As CheckBox
    Friend WithEvents CbDesain As CheckBox
    Friend WithEvents CbFotografi As CheckBox
    Friend WithEvents CbProgramming As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnKeKontak As Button
    Friend WithEvents CmbKomunitas As ComboBox
    Friend WithEvents BtnKembali1 As Button
    Friend WithEvents BtnKeProfil As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents PanelHobi As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LblNamaFoto As Label
End Class
