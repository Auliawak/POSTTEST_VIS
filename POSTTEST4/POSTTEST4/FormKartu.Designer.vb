<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        Panel2 = New Panel()
        LblEmail = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        LblAlamat = New Label()
        LblHobi = New Label()
        LblTglLahir = New Label()
        LblTelepon = New Label()
        LblJK = New Label()
        LblNamaAnggota = New Label()
        LblIDAnggota = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        PbFotoKartu = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        LblRole = New Label()
        LblDivisi = New Label()
        BtnTutup = New Button()
        BtnSimpanKartu = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel2.Controls.Add(LblEmail)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(LblAlamat)
        Panel2.Controls.Add(LblHobi)
        Panel2.Controls.Add(LblTglLahir)
        Panel2.Controls.Add(LblTelepon)
        Panel2.Controls.Add(LblJK)
        Panel2.Location = New Point(304, 164)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(792, 373)
        Panel2.TabIndex = 14
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.ForeColor = SystemColors.ControlLightLight
        LblEmail.Location = New Point(146, 69)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(53, 20)
        LblEmail.TabIndex = 24
        LblEmail.Text = "Label1"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.ForeColor = Color.White
        Label14.Location = New Point(128, 69)
        Label14.Name = "Label14"
        Label14.Size = New Size(12, 20)
        Label14.TabIndex = 22
        Label14.Text = ":"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(128, 20)
        Label13.Name = "Label13"
        Label13.Size = New Size(12, 20)
        Label13.TabIndex = 21
        Label13.Text = ":"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(128, 124)
        Label12.Name = "Label12"
        Label12.Size = New Size(12, 20)
        Label12.TabIndex = 20
        Label12.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(128, 232)
        Label10.Name = "Label10"
        Label10.Size = New Size(12, 20)
        Label10.TabIndex = 18
        Label10.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(128, 180)
        Label9.Name = "Label9"
        Label9.Size = New Size(12, 20)
        Label9.TabIndex = 17
        Label9.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(23, 180)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 20)
        Label8.TabIndex = 16
        Label8.Text = "Jenis Kelamin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(24, 285)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 20)
        Label7.TabIndex = 15
        Label7.Text = "Hobi dan Aktivitas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(24, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 14
        Label6.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(24, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 13
        Label5.Text = "Umur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(24, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 12
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(24, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 11
        Label3.Text = "No. Telp"
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.ForeColor = Color.White
        LblAlamat.Location = New Point(146, 232)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(53, 20)
        LblAlamat.TabIndex = 9
        LblAlamat.Text = "Label2"
        ' 
        ' LblHobi
        ' 
        LblHobi.AutoSize = True
        LblHobi.ForeColor = Color.White
        LblHobi.Location = New Point(23, 328)
        LblHobi.Name = "LblHobi"
        LblHobi.Size = New Size(53, 20)
        LblHobi.TabIndex = 8
        LblHobi.Text = "Label2"
        ' 
        ' LblTglLahir
        ' 
        LblTglLahir.AutoSize = True
        LblTglLahir.ForeColor = Color.White
        LblTglLahir.Location = New Point(146, 20)
        LblTglLahir.Name = "LblTglLahir"
        LblTglLahir.Size = New Size(53, 20)
        LblTglLahir.TabIndex = 5
        LblTglLahir.Text = "Label2"
        ' 
        ' LblTelepon
        ' 
        LblTelepon.AutoSize = True
        LblTelepon.ForeColor = Color.White
        LblTelepon.Location = New Point(146, 124)
        LblTelepon.Name = "LblTelepon"
        LblTelepon.Size = New Size(53, 20)
        LblTelepon.TabIndex = 7
        LblTelepon.Text = "Label3"
        ' 
        ' LblJK
        ' 
        LblJK.AutoSize = True
        LblJK.ForeColor = Color.White
        LblJK.Location = New Point(146, 180)
        LblJK.Name = "LblJK"
        LblJK.Size = New Size(53, 20)
        LblJK.TabIndex = 6
        LblJK.Text = "Label2"
        ' 
        ' LblNamaAnggota
        ' 
        LblNamaAnggota.AutoSize = True
        LblNamaAnggota.BackColor = Color.Transparent
        LblNamaAnggota.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblNamaAnggota.ForeColor = Color.White
        LblNamaAnggota.Location = New Point(109, 267)
        LblNamaAnggota.Name = "LblNamaAnggota"
        LblNamaAnggota.Size = New Size(59, 18)
        LblNamaAnggota.TabIndex = 3
        LblNamaAnggota.Text = "Label2"
        ' 
        ' LblIDAnggota
        ' 
        LblIDAnggota.AutoSize = True
        LblIDAnggota.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblIDAnggota.ForeColor = Color.White
        LblIDAnggota.Location = New Point(108, 288)
        LblIDAnggota.Name = "LblIDAnggota"
        LblIDAnggota.Size = New Size(55, 20)
        LblIDAnggota.TabIndex = 4
        LblIDAnggota.Text = "Label2"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1130, 77)
        Panel1.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(354, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(446, 43)
        Label1.TabIndex = 0
        Label1.Text = "EVOS ACADEMY STUDENT"
        ' 
        ' PbFotoKartu
        ' 
        PbFotoKartu.BackgroundImage = CType(resources.GetObject("PbFotoKartu.BackgroundImage"), Image)
        PbFotoKartu.BackgroundImageLayout = ImageLayout.Stretch
        PbFotoKartu.Location = New Point(38, 3)
        PbFotoKartu.Name = "PbFotoKartu"
        PbFotoKartu.Size = New Size(192, 249)
        PbFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        PbFotoKartu.TabIndex = 12
        PbFotoKartu.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1130, 667)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel3.Controls.Add(LblRole)
        Panel3.Controls.Add(LblDivisi)
        Panel3.Controls.Add(PbFotoKartu)
        Panel3.Controls.Add(LblNamaAnggota)
        Panel3.Controls.Add(LblIDAnggota)
        Panel3.Location = New Point(18, 164)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(270, 373)
        Panel3.TabIndex = 15
        ' 
        ' LblRole
        ' 
        LblRole.AutoSize = True
        LblRole.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblRole.ForeColor = SystemColors.ControlLightLight
        LblRole.Location = New Point(107, 339)
        LblRole.Name = "LblRole"
        LblRole.Size = New Size(57, 18)
        LblRole.TabIndex = 14
        LblRole.Text = "Label"
        ' 
        ' LblDivisi
        ' 
        LblDivisi.AutoSize = True
        LblDivisi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDivisi.ForeColor = SystemColors.ControlLightLight
        LblDivisi.Location = New Point(104, 311)
        LblDivisi.Name = "LblDivisi"
        LblDivisi.Size = New Size(64, 20)
        LblDivisi.TabIndex = 13
        LblDivisi.Text = "Label16"
        ' 
        ' BtnTutup
        ' 
        BtnTutup.BackColor = Color.Red
        BtnTutup.Location = New Point(1002, 595)
        BtnTutup.Name = "BtnTutup"
        BtnTutup.Size = New Size(94, 29)
        BtnTutup.TabIndex = 16
        BtnTutup.Text = "Tutup"
        BtnTutup.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpanKartu
        ' 
        BtnSimpanKartu.BackColor = Color.Lime
        BtnSimpanKartu.Location = New Point(874, 595)
        BtnSimpanKartu.Name = "BtnSimpanKartu"
        BtnSimpanKartu.Size = New Size(105, 29)
        BtnSimpanKartu.TabIndex = 17
        BtnSimpanKartu.Text = "Simpan FIle"
        BtnSimpanKartu.UseVisualStyleBackColor = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1131, 660)
        Controls.Add(BtnSimpanKartu)
        Controls.Add(BtnTutup)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "FormKartu"
        Text = "FormKartu"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNamaAnggota As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblIDAnggota As Label
    Friend WithEvents LblHobi As Label
    Friend WithEvents LblTglLahir As Label
    Friend WithEvents LblTelepon As Label
    Friend WithEvents LblJK As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PbFotoKartu As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblDivisi As Label
    Friend WithEvents LblRole As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnSimpanKartu As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
