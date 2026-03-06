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
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtTambahJudul = New TextBox()
        txtGenre = New TextBox()
        Panel1 = New Panel()
        btnTambah = New Button()
        lstDaftarBuku = New ListBox()
        Panel2 = New Panel()
        btnHapus = New Button()
        txtHapusJudul = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(111, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 3
        Label4.Text = "Tambah Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(449, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 4
        Label5.Text = "Hapus Buku"
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.Location = New Point(93, 30)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(184, 27)
        txtTambahJudul.TabIndex = 6
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(93, 81)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(184, 27)
        txtGenre.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(txtTambahJudul)
        Panel1.Controls.Add(txtGenre)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(89, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(298, 182)
        Panel1.TabIndex = 9
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.ForestGreen
        btnTambah.Location = New Point(183, 135)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lstDaftarBuku
        ' 
        lstDaftarBuku.BackColor = SystemColors.ControlDarkDark
        lstDaftarBuku.FormattingEnabled = True
        lstDaftarBuku.Location = New Point(241, 254)
        lstDaftarBuku.Name = "lstDaftarBuku"
        lstDaftarBuku.Size = New Size(336, 184)
        lstDaftarBuku.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(txtHapusJudul)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(427, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(298, 182)
        Panel2.TabIndex = 12
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Location = New Point(183, 135)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.Location = New Point(93, 30)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(184, 27)
        txtHapusJudul.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 0
        Label3.Text = "Judul"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(lstDaftarBuku)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents lstDaftarBuku As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents Label3 As Label

End Class
