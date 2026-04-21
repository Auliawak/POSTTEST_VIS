Public Class Form1

    Private ReadOnly CLR_BG As Color = Color.FromArgb(15, 15, 30)
    Private ReadOnly CLR_PANEL As Color = Color.FromArgb(25, 25, 50)
    Private ReadOnly CLR_CARD As Color = Color.FromArgb(35, 35, 65)
    Private ReadOnly CLR_YELLOW As Color = Color.FromArgb(255, 210, 0)
    Private ReadOnly CLR_BLUE As Color = Color.FromArgb(50, 130, 220)
    Private ReadOnly CLR_GREEN As Color = Color.FromArgb(50, 200, 100)
    Private ReadOnly CLR_ORANGE As Color = Color.FromArgb(240, 140, 30)
    Private ReadOnly CLR_ACCENT As Color = Color.FromArgb(150, 80, 220)
    Private ReadOnly CLR_WHITE As Color = Color.FromArgb(240, 240, 255)
    Private ReadOnly CLR_GRAY As Color = Color.FromArgb(120, 120, 150)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Me.BackColor = CLR_BG
        Me.Text = "Pokemon Card Manager"
        Me.Font = New Font("Segoe UI", 9)

        GayaTombolNav(btnNavKartu, CLR_BLUE)
        GayaTombolNav(btnNavKoleksi, CLR_GREEN)
        GayaTombolNav(btnNavTransaksi, CLR_ORANGE)

        GayaStatCard(pnlStatKartu, CLR_BLUE)
        GayaStatCard(pnlStatKoleksi, CLR_GREEN)
        GayaStatCard(pnlStatRare, CLR_ACCENT)
        GayaStatCard(pnlStatNilai, CLR_YELLOW)
        GayaStatCard(pnlStatTransaksi, CLR_ORANGE)

        pnlHeader.BackColor = CLR_PANEL
        pnlSidebar.BackColor = CLR_PANEL
        pnlContent.BackColor = CLR_BG
        pnlStatKartu.BackColor = CLR_CARD
        pnlStatKoleksi.BackColor = CLR_CARD
        pnlStatRare.BackColor = CLR_CARD
        pnlStatNilai.BackColor = CLR_CARD
        pnlStatTransaksi.BackColor = CLR_CARD
        pnlChartBox.BackColor = CLR_CARD

        lblTitle.ForeColor = CLR_YELLOW
        lblSubtitle.ForeColor = CLR_GRAY
        lblNavMenu.ForeColor = CLR_GRAY
        lblWelcome.ForeColor = CLR_WHITE
        lblWelcomeSub.ForeColor = CLR_GRAY
        lblStatKartuLabel.ForeColor = CLR_GRAY
        lblStatKoleksiLabel.ForeColor = CLR_GRAY
        lblStatRareLabel.ForeColor = CLR_GRAY
        lblStatNilaiLabel.ForeColor = CLR_GRAY
        lblStatTransaksiLabel.ForeColor = CLR_GRAY
        lblStatKartuVal.ForeColor = CLR_BLUE
        lblStatKoleksiVal.ForeColor = CLR_GREEN
        lblStatRareVal.ForeColor = CLR_ACCENT
        lblStatNilaiVal.ForeColor = CLR_YELLOW
        lblStatTransaksiVal.ForeColor = CLR_ORANGE
        lblChartTitle.ForeColor = CLR_WHITE
        lblVersi.ForeColor = CLR_GRAY
        lstChart.BackColor = CLR_CARD
        lstChart.ForeColor = CLR_WHITE

        AddHandler pnlHeader.Paint, AddressOf PaintHeaderGaris

        Dim lebarCard = 160
        Dim gap = 10
        Dim startX = 20
        pnlStatKartu.Location = New Point(startX, 90)
        pnlStatKartu.Width = lebarCard
        pnlStatKoleksi.Location = New Point(startX + (lebarCard + gap), 90)
        pnlStatKoleksi.Width = lebarCard
        pnlStatRare.Location = New Point(startX + (lebarCard + gap) * 2, 90)
        pnlStatRare.Width = lebarCard
        pnlStatNilai.Location = New Point(startX + (lebarCard + gap) * 3, 90)
        pnlStatNilai.Width = lebarCard
        pnlStatTransaksi.Location = New Point(startX + (lebarCard + gap) * 4, 90)
        pnlStatTransaksi.Width = lebarCard

        LoadStatistik()
    End Sub

    Private Sub GayaTombolNav(btn As Button, warna As Color)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 70)
        btn.BackColor = Color.Transparent
        btn.ForeColor = warna
        btn.Cursor = Cursors.Hand
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(10, 0, 0, 0)
    End Sub

    Private Sub GayaStatCard(pnl As Panel, warna As Color)
        AddHandler pnl.Paint, Sub(s, ev)
                                  Using pen As New Pen(warna, 3)
                                      ev.Graphics.DrawLine(pen, 0, 0, 0, pnl.Height)
                                  End Using
                              End Sub
    End Sub

    Private Sub PaintHeaderGaris(sender As Object, e As PaintEventArgs)
        Using pen As New Pen(CLR_YELLOW, 2)
            e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 2, pnlHeader.Width, pnlHeader.Height - 2)
        End Using
    End Sub

    Private Sub LoadStatistik()
        If Not TestConnection() Then
            MessageBox.Show("Tidak dapat terhubung ke database!" & vbNewLine &
            "Pastikan MySQL/XAMPP sudah berjalan.",
            "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dt = GetStatistik()
        If dt.Rows.Count > 0 Then
            Dim r = dt.Rows(0)
            lblStatKartuVal.Text = r("total_kartu").ToString()
            lblStatKoleksiVal.Text = r("total_koleksi").ToString()
            Dim rare = Convert.ToInt32(r("kartu_rare")) + Convert.ToInt32(r("kartu_ultra"))
            lblStatRareVal.Text = rare.ToString()
            Dim nilai = Convert.ToDecimal(r("total_nilai"))
            lblStatNilaiVal.Text = FormatRupiah(nilai)
            lblStatTransaksiVal.Text = r("total_transaksi").ToString()
        End If

        lstChart.Items.Clear()
        Dim dtTipe = GetKartuPerTipe()
        Dim tipeEmoji As New Dictionary(Of String, String) From {
        {"Fire", "Fire"}, {"Water", "Water"}, {"Grass", "Grass"},
        {"Lightning", "Lightning"}, {"Psychic", "Psychic"},
        {"Fighting", "Fighting"}, {"Colorless", "Colorless"},
        {"Fairy", "Fairy"}, {"Dragon", "Dragon"},
        {"Dark", "Dark"}, {"Metal", "Metal"}
    }

        Dim maxJml As Integer = 1
        If dtTipe.Rows.Count > 0 Then maxJml = Convert.ToInt32(dtTipe.Rows(0)("jumlah"))

        For Each row As DataRow In dtTipe.Rows
            Dim tipe = row("tipe").ToString()
            Dim jml = Convert.ToInt32(row("jumlah"))
            Dim bar = New String(Chr(9608), CInt(Math.Round(jml / maxJml * 28)))
            lstChart.Items.Add(String.Format("  {0,-15} {1,-30} {2} kartu", tipe, bar, jml))
        Next
    End Sub

    Private Sub btnNavKartu_Click(sender As Object, e As EventArgs) Handles btnNavKartu.Click
        Dim frm As New FormKartu()
        frm.ShowDialog()
        LoadStatistik()
    End Sub

    Private Sub btnNavKoleksi_Click(sender As Object, e As EventArgs) Handles btnNavKoleksi.Click
        Dim frm As New FormKoleksi()
        frm.ShowDialog()
        LoadStatistik()
    End Sub

    Private Sub btnNavTransaksi_Click(sender As Object, e As EventArgs) Handles btnNavTransaksi.Click
        Dim frm As New FormTransaksi()
        frm.ShowDialog()
        LoadStatistik()
    End Sub

End Class