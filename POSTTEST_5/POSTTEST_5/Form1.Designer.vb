<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlSidebar = New Panel()
        lblVersi = New Label()
        btnNavKoleksi = New Button()
        btnNavKartu = New Button()
        lblNavMenu = New Label()
        pnlContent = New Panel()
        pnlChartBox = New Panel()

        lblChartTitle = New Label()
        pnlStatNilai = New Panel()
        lblStatNilaiVal = New Label()
        lblStatNilaiLabel = New Label()
        pnlStatRare = New Panel()
        lblStatRareVal = New Label()
        lblStatRareLabel = New Label()
        pnlStatKoleksi = New Panel()
        lblStatKoleksiVal = New Label()
        lblStatKoleksiLabel = New Label()
        pnlStatKartu = New Panel()
        lblStatKartuVal = New Label()
        lblStatKartuLabel = New Label()
        lblWelcomeSub = New Label()
        lblWelcome = New Label()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        ' pnlChartBox has no child controls (custom painted)
        pnlStatNilai.SuspendLayout()
        pnlStatRare.SuspendLayout()
        pnlStatKoleksi.SuspendLayout()
        pnlStatKartu.SuspendLayout()
        SuspendLayout()
        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(50))
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1239, 107)
        pnlHeader.TabIndex = 0
        '
        ' lblSubtitle
        '
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblSubtitle.Location = New Point(26, 67)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(309, 23)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Kelola koleksi kartu Pokémon favoritmu"
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(210), CByte(0))
        lblTitle.Location = New Point(23, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(475, 46)
        lblTitle.TabIndex = 0
        lblTitle.Text = "POKÉMON CARD MANAGER"
        '
        ' pnlSidebar
        '
        pnlSidebar.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(50))
        pnlSidebar.Controls.Add(lblVersi)
        pnlSidebar.Controls.Add(btnNavKoleksi)
        pnlSidebar.Controls.Add(btnNavKartu)
        pnlSidebar.Controls.Add(lblNavMenu)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 107)
        pnlSidebar.Margin = New Padding(3, 4, 3, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(229, 776)
        pnlSidebar.TabIndex = 1
        '
        ' lblVersi
        '
        lblVersi.AutoSize = True
        lblVersi.Font = New Font("Segoe UI", 8.0F)
        lblVersi.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblVersi.Location = New Point(11, 740)
        lblVersi.Name = "lblVersi"
        lblVersi.Size = New Size(123, 19)
        lblVersi.TabIndex = 3
        lblVersi.Text = "v1.0.0  |  .NET 10.0"
        '
        ' btnNavKoleksi
        '
        btnNavKoleksi.BackColor = Color.Transparent
        btnNavKoleksi.Cursor = Cursors.Hand
        btnNavKoleksi.FlatStyle = FlatStyle.Flat
        btnNavKoleksi.FlatAppearance.BorderSize = 0
        btnNavKoleksi.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnNavKoleksi.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavKoleksi.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        btnNavKoleksi.Location = New Point(6, 147)
        btnNavKoleksi.Margin = New Padding(3, 4, 3, 4)
        btnNavKoleksi.Name = "btnNavKoleksi"
        btnNavKoleksi.Padding = New Padding(10, 0, 0, 0)
        btnNavKoleksi.Size = New Size(217, 67)
        btnNavKoleksi.TabIndex = 2
        btnNavKoleksi.Text = "Manajemen Koleksi"
        btnNavKoleksi.TextAlign = ContentAlignment.MiddleLeft
        btnNavKoleksi.UseVisualStyleBackColor = False
        '
        ' btnNavKartu
        '
        btnNavKartu.BackColor = Color.Transparent
        btnNavKartu.Cursor = Cursors.Hand
        btnNavKartu.FlatStyle = FlatStyle.Flat
        btnNavKartu.FlatAppearance.BorderSize = 0
        btnNavKartu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(70))
        btnNavKartu.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavKartu.ForeColor = Color.FromArgb(CByte(50), CByte(130), CByte(220))
        btnNavKartu.Location = New Point(6, 67)
        btnNavKartu.Margin = New Padding(3, 4, 3, 4)
        btnNavKartu.Name = "btnNavKartu"
        btnNavKartu.Padding = New Padding(10, 0, 0, 0)
        btnNavKartu.Size = New Size(217, 67)
        btnNavKartu.TabIndex = 1
        btnNavKartu.Text = "Data Kartu"
        btnNavKartu.TextAlign = ContentAlignment.MiddleLeft
        btnNavKartu.UseVisualStyleBackColor = False
        '
        ' lblNavMenu
        '
        lblNavMenu.AutoSize = True
        lblNavMenu.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblNavMenu.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblNavMenu.Location = New Point(17, 27)
        lblNavMenu.Name = "lblNavMenu"
        lblNavMenu.Size = New Size(74, 19)
        lblNavMenu.TabIndex = 0
        lblNavMenu.Text = "NAVIGASI"
        '
        ' pnlContent
        '
        pnlContent.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        pnlContent.Controls.Add(pnlChartBox)
        pnlContent.Controls.Add(lblChartTitle)
        pnlContent.Controls.Add(pnlStatNilai)
        pnlContent.Controls.Add(pnlStatRare)
        pnlContent.Controls.Add(pnlStatKoleksi)
        pnlContent.Controls.Add(pnlStatKartu)
        pnlContent.Controls.Add(lblWelcomeSub)
        pnlContent.Controls.Add(lblWelcome)
        pnlContent.Location = New Point(229, 107)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1010, 776)
        pnlContent.TabIndex = 2
        '
        ' pnlChartBox
        '
        pnlChartBox.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(55))
        pnlChartBox.Location = New Point(23, 320)
        pnlChartBox.Margin = New Padding(3, 4, 3, 4)
        pnlChartBox.Name = "pnlChartBox"
        pnlChartBox.Size = New Size(960, 420)
        pnlChartBox.TabIndex = 7
        '
        ' lblChartTitle
        '
        lblChartTitle.AutoSize = True
        lblChartTitle.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        lblChartTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblChartTitle.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        lblChartTitle.Location = New Point(23, 280)
        lblChartTitle.Name = "lblChartTitle"
        lblChartTitle.Size = New Size(246, 28)
        lblChartTitle.TabIndex = 6
        lblChartTitle.Text = "Distribusi Kartu per Tipe"
        '
        ' pnlStatNilai
        '
        pnlStatNilai.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(65))
        pnlStatNilai.Controls.Add(lblStatNilaiVal)
        pnlStatNilai.Controls.Add(lblStatNilaiLabel)
        pnlStatNilai.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        pnlStatNilai.Location = New Point(674, 120)
        pnlStatNilai.Margin = New Padding(3, 4, 3, 4)
        pnlStatNilai.Name = "pnlStatNilai"
        pnlStatNilai.Size = New Size(309, 147)
        pnlStatNilai.TabIndex = 5
        '
        ' lblStatNilaiVal
        '
        lblStatNilaiVal.AutoSize = True
        lblStatNilaiVal.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblStatNilaiVal.ForeColor = Color.FromArgb(CByte(255), CByte(210), CByte(0))
        lblStatNilaiVal.Location = New Point(14, 56)
        lblStatNilaiVal.Name = "lblStatNilaiVal"
        lblStatNilaiVal.Size = New Size(92, 46)
        lblStatNilaiVal.TabIndex = 1
        lblStatNilaiVal.Text = "Rp 0"
        '
        ' lblStatNilaiLabel
        '
        lblStatNilaiLabel.AutoSize = True
        lblStatNilaiLabel.Font = New Font("Segoe UI", 9.0F)
        lblStatNilaiLabel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblStatNilaiLabel.Location = New Point(17, 20)
        lblStatNilaiLabel.Name = "lblStatNilaiLabel"
        lblStatNilaiLabel.Size = New Size(66, 20)
        lblStatNilaiLabel.TabIndex = 0
        lblStatNilaiLabel.Text = "Est. Nilai"
        '
        ' pnlStatRare
        '
        pnlStatRare.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(65))
        pnlStatRare.Controls.Add(lblStatRareVal)
        pnlStatRare.Controls.Add(lblStatRareLabel)
        pnlStatRare.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        pnlStatRare.Location = New Point(457, 120)
        pnlStatRare.Margin = New Padding(3, 4, 3, 4)
        pnlStatRare.Name = "pnlStatRare"
        pnlStatRare.Size = New Size(200, 147)
        pnlStatRare.TabIndex = 4
        '
        ' lblStatRareVal
        '
        lblStatRareVal.AutoSize = True
        lblStatRareVal.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblStatRareVal.ForeColor = Color.FromArgb(CByte(150), CByte(80), CByte(220))
        lblStatRareVal.Location = New Point(14, 56)
        lblStatRareVal.Name = "lblStatRareVal"
        lblStatRareVal.Size = New Size(43, 50)
        lblStatRareVal.TabIndex = 1
        lblStatRareVal.Text = "0"
        '
        ' lblStatRareLabel
        '
        lblStatRareLabel.AutoSize = True
        lblStatRareLabel.Font = New Font("Segoe UI", 9.0F)
        lblStatRareLabel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblStatRareLabel.Location = New Point(17, 20)
        lblStatRareLabel.Name = "lblStatRareLabel"
        lblStatRareLabel.Size = New Size(88, 20)
        lblStatRareLabel.TabIndex = 0
        lblStatRareLabel.Text = "Kartu Rare+"
        '
        ' pnlStatKoleksi
        '
        pnlStatKoleksi.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(65))
        pnlStatKoleksi.Controls.Add(lblStatKoleksiVal)
        pnlStatKoleksi.Controls.Add(lblStatKoleksiLabel)
        pnlStatKoleksi.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        pnlStatKoleksi.Location = New Point(240, 120)
        pnlStatKoleksi.Margin = New Padding(3, 4, 3, 4)
        pnlStatKoleksi.Name = "pnlStatKoleksi"
        pnlStatKoleksi.Size = New Size(200, 147)
        pnlStatKoleksi.TabIndex = 3
        '
        ' lblStatKoleksiVal
        '
        lblStatKoleksiVal.AutoSize = True
        lblStatKoleksiVal.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblStatKoleksiVal.ForeColor = Color.FromArgb(CByte(50), CByte(200), CByte(100))
        lblStatKoleksiVal.Location = New Point(14, 56)
        lblStatKoleksiVal.Name = "lblStatKoleksiVal"
        lblStatKoleksiVal.Size = New Size(43, 50)
        lblStatKoleksiVal.TabIndex = 1
        lblStatKoleksiVal.Text = "0"
        '
        ' lblStatKoleksiLabel
        '
        lblStatKoleksiLabel.AutoSize = True
        lblStatKoleksiLabel.Font = New Font("Segoe UI", 9.0F)
        lblStatKoleksiLabel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblStatKoleksiLabel.Location = New Point(17, 20)
        lblStatKoleksiLabel.Name = "lblStatKoleksiLabel"
        lblStatKoleksiLabel.Size = New Size(93, 20)
        lblStatKoleksiLabel.TabIndex = 0
        lblStatKoleksiLabel.Text = "Total Koleksi"
        '
        ' pnlStatKartu
        '
        pnlStatKartu.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(65))
        pnlStatKartu.Controls.Add(lblStatKartuVal)
        pnlStatKartu.Controls.Add(lblStatKartuLabel)
        pnlStatKartu.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        pnlStatKartu.Location = New Point(23, 120)
        pnlStatKartu.Margin = New Padding(3, 4, 3, 4)
        pnlStatKartu.Name = "pnlStatKartu"
        pnlStatKartu.Size = New Size(200, 147)
        pnlStatKartu.TabIndex = 2
        '
        ' lblStatKartuVal
        '
        lblStatKartuVal.AutoSize = True
        lblStatKartuVal.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblStatKartuVal.ForeColor = Color.FromArgb(CByte(50), CByte(130), CByte(220))
        lblStatKartuVal.Location = New Point(14, 56)
        lblStatKartuVal.Name = "lblStatKartuVal"
        lblStatKartuVal.Size = New Size(43, 50)
        lblStatKartuVal.TabIndex = 1
        lblStatKartuVal.Text = "0"
        '
        ' lblStatKartuLabel
        '
        lblStatKartuLabel.AutoSize = True
        lblStatKartuLabel.Font = New Font("Segoe UI", 9.0F)
        lblStatKartuLabel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblStatKartuLabel.Location = New Point(17, 20)
        lblStatKartuLabel.Name = "lblStatKartuLabel"
        lblStatKartuLabel.Size = New Size(81, 20)
        lblStatKartuLabel.TabIndex = 0
        lblStatKartuLabel.Text = "Total Kartu"
        '
        ' lblWelcomeSub
        '
        lblWelcomeSub.AutoSize = True
        lblWelcomeSub.Font = New Font("Segoe UI", 10.0F)
        lblWelcomeSub.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblWelcomeSub.Location = New Point(25, 67)
        lblWelcomeSub.Name = "lblWelcomeSub"
        lblWelcomeSub.Size = New Size(309, 23)
        lblWelcomeSub.TabIndex = 1
        lblWelcomeSub.Text = "Ringkasan koleksi kartu Pokémon kamu"
        '
        ' lblWelcome
        '
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(255))
        lblWelcome.Location = New Point(23, 27)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(157, 37)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Dashboard"
        '
        ' Form1
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(30))
        ClientSize = New Size(1239, 883)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pokémon Card Manager"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlStatNilai.ResumeLayout(False)
        pnlStatNilai.PerformLayout()
        pnlStatRare.ResumeLayout(False)
        pnlStatRare.PerformLayout()
        pnlStatKoleksi.ResumeLayout(False)
        pnlStatKoleksi.PerformLayout()
        pnlStatKartu.ResumeLayout(False)
        pnlStatKartu.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblVersi As System.Windows.Forms.Label
    Friend WithEvents btnNavKoleksi As System.Windows.Forms.Button
    Friend WithEvents btnNavKartu As System.Windows.Forms.Button
    Friend WithEvents lblNavMenu As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlChartBox As System.Windows.Forms.Panel
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatNilai As System.Windows.Forms.Panel
    Friend WithEvents lblStatNilaiVal As System.Windows.Forms.Label
    Friend WithEvents lblStatNilaiLabel As System.Windows.Forms.Label
    Friend WithEvents pnlStatRare As System.Windows.Forms.Panel
    Friend WithEvents lblStatRareVal As System.Windows.Forms.Label
    Friend WithEvents lblStatRareLabel As System.Windows.Forms.Label
    Friend WithEvents pnlStatKoleksi As System.Windows.Forms.Panel
    Friend WithEvents lblStatKoleksiVal As System.Windows.Forms.Label
    Friend WithEvents lblStatKoleksiLabel As System.Windows.Forms.Label
    Friend WithEvents pnlStatKartu As System.Windows.Forms.Panel
    Friend WithEvents lblStatKartuVal As System.Windows.Forms.Label
    Friend WithEvents lblStatKartuLabel As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeSub As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label

End Class