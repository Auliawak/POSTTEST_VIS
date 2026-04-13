Public Class Form1

    Private chartData As New List(Of (Tipe As String, Jumlah As Integer, Warna As Color))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlChartBox.Height = 420
        AddHandler pnlChartBox.Paint, AddressOf PaintBarChart
        LoadStatistik()
    End Sub

    Private Sub LoadStatistik()
        Try
            If Not TestConnection() Then
                MessageBox.Show("Tidak dapat terhubung ke database!" & vbCrLf &
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
                If lblStatNilaiVal.Text.Length > 14 Then
                    lblStatNilaiVal.Font = New Font("Segoe UI", 13, FontStyle.Bold)
                End If
            End If

            Dim tipeWarna As New Dictionary(Of String, Color) From {
                {"Fire", Color.FromArgb(230, 80, 50)},
                {"Water", Color.FromArgb(50, 140, 220)},
                {"Grass", Color.FromArgb(60, 190, 80)},
                {"Lightning", Color.FromArgb(255, 210, 0)},
                {"Psychic", Color.FromArgb(200, 80, 200)},
                {"Fighting", Color.FromArgb(200, 100, 50)},
                {"Dark", Color.FromArgb(80, 70, 130)},
                {"Metal", Color.FromArgb(140, 160, 180)},
                {"Fairy", Color.FromArgb(230, 130, 190)},
                {"Dragon", Color.FromArgb(80, 100, 210)},
                {"Colorless", Color.FromArgb(160, 160, 170)}
            }

            chartData.Clear()
            Dim dtTipe = GetKartuPerTipe()
            For Each row As DataRow In dtTipe.Rows
                Dim tipe = row("tipe").ToString()
                Dim jml = Convert.ToInt32(row("jumlah"))
                Dim warna = If(tipeWarna.ContainsKey(tipe), tipeWarna(tipe), Color.FromArgb(120, 120, 150))
                chartData.Add((tipe, jml, warna))
            Next

            pnlChartBox.Invalidate()

        Catch ex As Exception
            lblStatKartuVal.Text = "N/A"
            lblStatKoleksiVal.Text = "N/A"
            lblStatRareVal.Text = "N/A"
            lblStatNilaiVal.Text = "N/A"
        End Try
    End Sub

    Private Sub PaintBarChart(sender As Object, e As PaintEventArgs)
        Dim g = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim pnl = CType(sender, Panel)
        Dim w = pnl.Width
        Dim h = pnl.Height

        g.Clear(Color.FromArgb(28, 28, 55))

        If chartData.Count = 0 Then
            Dim msgFont = New Font("Segoe UI", 12, FontStyle.Italic)
            Dim msgBrush = New SolidBrush(Color.FromArgb(100, 100, 130))
            Dim msg = "Belum ada data kartu"
            Dim sz = g.MeasureString(msg, msgFont)
            g.DrawString(msg, msgFont, msgBrush, CSng((w - sz.Width) / 2), CSng((h - sz.Height) / 2))
            Return
        End If

        Dim maxJml = chartData.Max(Function(x) x.Jumlah)
        Dim totalKartu = chartData.Sum(Function(x) x.Jumlah)

        Dim padLeft = 160
        Dim padRight = 90
        Dim padTop = 20
        Dim padBottom = 20
        Dim barAreaW = w - padLeft - padRight
        Dim barCount = chartData.Count
        Dim slotH = CSng((h - padTop - padBottom)) / barCount
        Dim barH = CInt(Math.Min(slotH * 0.55, 32))

        Dim labelFont = New Font("Segoe UI", 9, FontStyle.Bold)
        Dim numFont = New Font("Segoe UI", 8.5F)
        Dim pctFont = New Font("Segoe UI", 8, FontStyle.Bold)

        For i = 0 To chartData.Count - 1
            Dim item = chartData(i)
            Dim barW = CInt(item.Jumlah / maxJml * barAreaW)
            Dim y = CSng(padTop + i * slotH + (slotH - barH) / 2)

            Dim labelBrush = New SolidBrush(Color.FromArgb(210, 210, 230))
            Dim labelSz = g.MeasureString(item.Tipe, labelFont)
            g.DrawString(item.Tipe, labelFont, labelBrush,
                         CSng(padLeft - labelSz.Width - 10),
                         CSng(y + (barH - labelSz.Height) / 2))

            Dim trackRect = New Rectangle(padLeft, CInt(y), barAreaW, barH)
            Dim trackBrush = New SolidBrush(Color.FromArgb(45, 45, 80))
            g.FillRectangle(trackBrush, trackRect)

            If barW > 0 Then
                Dim barRect = New Rectangle(padLeft, CInt(y), barW, barH)
                Dim c1 = item.Warna
                Dim c2 = Color.FromArgb(
                    Math.Max(0, c1.R - 50),
                    Math.Max(0, c1.G - 50),
                    Math.Max(0, c1.B - 50))
                Using grad = New Drawing2D.LinearGradientBrush(
                    barRect, c1, c2, Drawing2D.LinearGradientMode.Horizontal)
                    g.FillRectangle(grad, barRect)
                End Using

                Dim highlightRect = New Rectangle(padLeft, CInt(y), barW, CInt(barH * 0.3))
                Using hBrush = New SolidBrush(Color.FromArgb(40, 255, 255, 255))
                    g.FillRectangle(hBrush, highlightRect)
                End Using
            End If

            Dim jumlahTeks = $"{item.Jumlah} kartu"
            Dim jumlahSz = g.MeasureString(jumlahTeks, numFont)
            Dim txtX As Single
            Dim txtBrush As SolidBrush
            If barW > jumlahSz.Width + 10 Then
                txtX = CSng(padLeft + barW - jumlahSz.Width - 6)
                txtBrush = New SolidBrush(Color.FromArgb(230, 230, 230))
            Else
                txtX = CSng(padLeft + barW + 6)
                txtBrush = New SolidBrush(Color.FromArgb(180, 180, 200))
            End If
            g.DrawString(jumlahTeks, numFont, txtBrush, txtX, CSng(y + (barH - jumlahSz.Height) / 2))

            Dim pct = If(totalKartu > 0, item.Jumlah / totalKartu * 100, 0)
            Dim pctTeks = $"{pct:0.0}%"
            Dim pctSz = g.MeasureString(pctTeks, pctFont)
            Dim pctBrush = New SolidBrush(item.Warna)
            g.DrawString(pctTeks, pctFont, pctBrush,
                         CSng(w - padRight + 6),
                         CSng(y + (barH - pctSz.Height) / 2))
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

End Class