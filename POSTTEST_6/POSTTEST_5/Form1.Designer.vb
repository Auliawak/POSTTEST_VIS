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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblVersi = New System.Windows.Forms.Label()
        Me.btnNavTransaksi = New System.Windows.Forms.Button()
        Me.btnNavKoleksi = New System.Windows.Forms.Button()
        Me.btnNavKartu = New System.Windows.Forms.Button()
        Me.lblNavMenu = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlChartBox = New System.Windows.Forms.Panel()
        Me.lstChart = New System.Windows.Forms.ListBox()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.pnlStatTransaksi = New System.Windows.Forms.Panel()
        Me.lblStatTransaksiVal = New System.Windows.Forms.Label()
        Me.lblStatTransaksiLabel = New System.Windows.Forms.Label()
        Me.pnlStatNilai = New System.Windows.Forms.Panel()
        Me.lblStatNilaiVal = New System.Windows.Forms.Label()
        Me.lblStatNilaiLabel = New System.Windows.Forms.Label()
        Me.pnlStatRare = New System.Windows.Forms.Panel()
        Me.lblStatRareVal = New System.Windows.Forms.Label()
        Me.lblStatRareLabel = New System.Windows.Forms.Label()
        Me.pnlStatKoleksi = New System.Windows.Forms.Panel()
        Me.lblStatKoleksiVal = New System.Windows.Forms.Label()
        Me.lblStatKoleksiLabel = New System.Windows.Forms.Label()
        Me.pnlStatKartu = New System.Windows.Forms.Panel()
        Me.lblStatKartuVal = New System.Windows.Forms.Label()
        Me.lblStatKartuLabel = New System.Windows.Forms.Label()
        Me.lblWelcomeSub = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlChartBox.SuspendLayout()
        Me.pnlStatTransaksi.SuspendLayout()
        Me.pnlStatNilai.SuspendLayout()
        Me.pnlStatRare.SuspendLayout()
        Me.pnlStatKoleksi.SuspendLayout()
        Me.pnlStatKartu.SuspendLayout()
        Me.SuspendLayout()
        ' pnlHeader
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1084, 80)
        Me.pnlHeader.TabIndex = 0
        ' lblSubtitle
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.Location = New System.Drawing.Point(23, 50)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Kelola koleksi kartu Pokemon favoritmu"
        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "POKEMON CARD MANAGER"
        ' pnlSidebar
        Me.pnlSidebar.Controls.Add(Me.lblVersi)
        Me.pnlSidebar.Controls.Add(Me.btnNavTransaksi)
        Me.pnlSidebar.Controls.Add(Me.btnNavKoleksi)
        Me.pnlSidebar.Controls.Add(Me.btnNavKartu)
        Me.pnlSidebar.Controls.Add(Me.lblNavMenu)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 80)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 582)
        Me.pnlSidebar.TabIndex = 1
        ' lblVersi
        Me.lblVersi.AutoSize = True
        Me.lblVersi.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblVersi.Location = New System.Drawing.Point(10, 555)
        Me.lblVersi.Name = "lblVersi"
        Me.lblVersi.TabIndex = 4
        Me.lblVersi.Text = "v2.0.0  |  .NET 10.0"
        ' btnNavTransaksi
        Me.btnNavTransaksi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavTransaksi.Location = New System.Drawing.Point(5, 170)
        Me.btnNavTransaksi.Name = "btnNavTransaksi"
        Me.btnNavTransaksi.Size = New System.Drawing.Size(190, 50)
        Me.btnNavTransaksi.TabIndex = 3
        Me.btnNavTransaksi.Text = "Transaksi"
        Me.btnNavTransaksi.UseVisualStyleBackColor = False
        ' btnNavKoleksi
        Me.btnNavKoleksi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavKoleksi.Location = New System.Drawing.Point(5, 110)
        Me.btnNavKoleksi.Name = "btnNavKoleksi"
        Me.btnNavKoleksi.Size = New System.Drawing.Size(190, 50)
        Me.btnNavKoleksi.TabIndex = 2
        Me.btnNavKoleksi.Text = "Manajemen Koleksi"
        Me.btnNavKoleksi.UseVisualStyleBackColor = False
        ' btnNavKartu
        Me.btnNavKartu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavKartu.Location = New System.Drawing.Point(5, 50)
        Me.btnNavKartu.Name = "btnNavKartu"
        Me.btnNavKartu.Size = New System.Drawing.Size(190, 50)
        Me.btnNavKartu.TabIndex = 1
        Me.btnNavKartu.Text = "Data Kartu"
        Me.btnNavKartu.UseVisualStyleBackColor = False
        ' lblNavMenu
        Me.lblNavMenu.AutoSize = True
        Me.lblNavMenu.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNavMenu.Location = New System.Drawing.Point(15, 20)
        Me.lblNavMenu.Name = "lblNavMenu"
        Me.lblNavMenu.TabIndex = 0
        Me.lblNavMenu.Text = "NAVIGASI"
        ' pnlContent
        Me.pnlContent.Controls.Add(Me.pnlChartBox)
        Me.pnlContent.Controls.Add(Me.lblChartTitle)
        Me.pnlContent.Controls.Add(Me.pnlStatTransaksi)
        Me.pnlContent.Controls.Add(Me.pnlStatNilai)
        Me.pnlContent.Controls.Add(Me.pnlStatRare)
        Me.pnlContent.Controls.Add(Me.pnlStatKoleksi)
        Me.pnlContent.Controls.Add(Me.pnlStatKartu)
        Me.pnlContent.Controls.Add(Me.lblWelcomeSub)
        Me.pnlContent.Controls.Add(Me.lblWelcome)
        Me.pnlContent.Location = New System.Drawing.Point(200, 80)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(884, 582)
        Me.pnlContent.TabIndex = 2
        ' pnlChartBox
        Me.pnlChartBox.Controls.Add(Me.lstChart)
        Me.pnlChartBox.Location = New System.Drawing.Point(20, 240)
        Me.pnlChartBox.Name = "pnlChartBox"
        Me.pnlChartBox.Size = New System.Drawing.Size(840, 320)
        Me.pnlChartBox.TabIndex = 8
        ' lstChart
        Me.lstChart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstChart.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.lstChart.FormattingEnabled = True
        Me.lstChart.ItemHeight = 16
        Me.lstChart.Location = New System.Drawing.Point(0, 0)
        Me.lstChart.Name = "lstChart"
        Me.lstChart.Size = New System.Drawing.Size(840, 320)
        Me.lstChart.TabIndex = 0
        ' lblChartTitle
        Me.lblChartTitle.AutoSize = True
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChartTitle.Location = New System.Drawing.Point(20, 210)
        Me.lblChartTitle.Name = "lblChartTitle"
        Me.lblChartTitle.TabIndex = 7
        Me.lblChartTitle.Text = "Distribusi Kartu per Tipe"
        ' pnlStatTransaksi  (kanan, 270px)
        Me.pnlStatTransaksi.Controls.Add(Me.lblStatTransaksiVal)
        Me.pnlStatTransaksi.Controls.Add(Me.lblStatTransaksiLabel)
        Me.pnlStatTransaksi.Location = New System.Drawing.Point(590, 90)
        Me.pnlStatTransaksi.Name = "pnlStatTransaksi"
        Me.pnlStatTransaksi.Size = New System.Drawing.Size(270, 110)
        Me.pnlStatTransaksi.TabIndex = 6
        ' lblStatTransaksiVal
        Me.lblStatTransaksiVal.AutoSize = True
        Me.lblStatTransaksiVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatTransaksiVal.Location = New System.Drawing.Point(12, 42)
        Me.lblStatTransaksiVal.Name = "lblStatTransaksiVal"
        Me.lblStatTransaksiVal.TabIndex = 1
        Me.lblStatTransaksiVal.Text = "0"
        ' lblStatTransaksiLabel
        Me.lblStatTransaksiLabel.AutoSize = True
        Me.lblStatTransaksiLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatTransaksiLabel.Location = New System.Drawing.Point(15, 15)
        Me.lblStatTransaksiLabel.Name = "lblStatTransaksiLabel"
        Me.lblStatTransaksiLabel.TabIndex = 0
        Me.lblStatTransaksiLabel.Text = "Total Transaksi"
        ' pnlStatNilai
        Me.pnlStatNilai.Controls.Add(Me.lblStatNilaiVal)
        Me.pnlStatNilai.Controls.Add(Me.lblStatNilaiLabel)
        Me.pnlStatNilai.Location = New System.Drawing.Point(400, 90)
        Me.pnlStatNilai.Name = "pnlStatNilai"
        Me.pnlStatNilai.Size = New System.Drawing.Size(175, 110)
        Me.pnlStatNilai.TabIndex = 5
        ' lblStatNilaiVal
        Me.lblStatNilaiVal.AutoSize = True
        Me.lblStatNilaiVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatNilaiVal.Location = New System.Drawing.Point(12, 42)
        Me.lblStatNilaiVal.Name = "lblStatNilaiVal"
        Me.lblStatNilaiVal.TabIndex = 1
        Me.lblStatNilaiVal.Text = "Rp 0"
        ' lblStatNilaiLabel
        Me.lblStatNilaiLabel.AutoSize = True
        Me.lblStatNilaiLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatNilaiLabel.Location = New System.Drawing.Point(15, 15)
        Me.lblStatNilaiLabel.Name = "lblStatNilaiLabel"
        Me.lblStatNilaiLabel.TabIndex = 0
        Me.lblStatNilaiLabel.Text = "Est. Nilai Koleksi"
        ' pnlStatRare
        Me.pnlStatRare.Controls.Add(Me.lblStatRareVal)
        Me.pnlStatRare.Controls.Add(Me.lblStatRareLabel)
        Me.pnlStatRare.Location = New System.Drawing.Point(210, 90)
        Me.pnlStatRare.Name = "pnlStatRare"
        Me.pnlStatRare.Size = New System.Drawing.Size(175, 110)
        Me.pnlStatRare.TabIndex = 4
        ' lblStatRareVal
        Me.lblStatRareVal.AutoSize = True
        Me.lblStatRareVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatRareVal.Location = New System.Drawing.Point(12, 42)
        Me.lblStatRareVal.Name = "lblStatRareVal"
        Me.lblStatRareVal.TabIndex = 1
        Me.lblStatRareVal.Text = "0"
        ' lblStatRareLabel
        Me.lblStatRareLabel.AutoSize = True
        Me.lblStatRareLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatRareLabel.Location = New System.Drawing.Point(15, 15)
        Me.lblStatRareLabel.Name = "lblStatRareLabel"
        Me.lblStatRareLabel.TabIndex = 0
        Me.lblStatRareLabel.Text = "Kartu Rare+"
        ' pnlStatKoleksi
        Me.pnlStatKoleksi.Controls.Add(Me.lblStatKoleksiVal)
        Me.pnlStatKoleksi.Controls.Add(Me.lblStatKoleksiLabel)
        Me.pnlStatKoleksi.Location = New System.Drawing.Point(210, 90)
        Me.pnlStatKoleksi.Name = "pnlStatKoleksi"
        Me.pnlStatKoleksi.Size = New System.Drawing.Size(175, 110)
        Me.pnlStatKoleksi.TabIndex = 3
        ' lblStatKoleksiVal
        Me.lblStatKoleksiVal.AutoSize = True
        Me.lblStatKoleksiVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatKoleksiVal.Location = New System.Drawing.Point(12, 42)
        Me.lblStatKoleksiVal.Name = "lblStatKoleksiVal"
        Me.lblStatKoleksiVal.TabIndex = 1
        Me.lblStatKoleksiVal.Text = "0"
        ' lblStatKoleksiLabel
        Me.lblStatKoleksiLabel.AutoSize = True
        Me.lblStatKoleksiLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatKoleksiLabel.Location = New System.Drawing.Point(15, 15)
        Me.lblStatKoleksiLabel.Name = "lblStatKoleksiLabel"
        Me.lblStatKoleksiLabel.TabIndex = 0
        Me.lblStatKoleksiLabel.Text = "Total Koleksi"
        ' pnlStatKartu
        Me.pnlStatKartu.Controls.Add(Me.lblStatKartuVal)
        Me.pnlStatKartu.Controls.Add(Me.lblStatKartuLabel)
        Me.pnlStatKartu.Location = New System.Drawing.Point(20, 90)
        Me.pnlStatKartu.Name = "pnlStatKartu"
        Me.pnlStatKartu.Size = New System.Drawing.Size(175, 110)
        Me.pnlStatKartu.TabIndex = 2
        ' lblStatKartuVal
        Me.lblStatKartuVal.AutoSize = True
        Me.lblStatKartuVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatKartuVal.Location = New System.Drawing.Point(12, 42)
        Me.lblStatKartuVal.Name = "lblStatKartuVal"
        Me.lblStatKartuVal.TabIndex = 1
        Me.lblStatKartuVal.Text = "0"
        ' lblStatKartuLabel
        Me.lblStatKartuLabel.AutoSize = True
        Me.lblStatKartuLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatKartuLabel.Location = New System.Drawing.Point(15, 15)
        Me.lblStatKartuLabel.Name = "lblStatKartuLabel"
        Me.lblStatKartuLabel.TabIndex = 0
        Me.lblStatKartuLabel.Text = "Total Kartu"
        ' lblWelcomeSub
        Me.lblWelcomeSub.AutoSize = True
        Me.lblWelcomeSub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWelcomeSub.Location = New System.Drawing.Point(22, 50)
        Me.lblWelcomeSub.Name = "lblWelcomeSub"
        Me.lblWelcomeSub.TabIndex = 1
        Me.lblWelcomeSub.Text = "Ringkasan koleksi kartu Pokemon kamu"
        ' lblWelcome
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.Location = New System.Drawing.Point(20, 20)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Dashboard"
        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokemon Card Manager"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlChartBox.ResumeLayout(False)
        Me.pnlStatTransaksi.ResumeLayout(False)
        Me.pnlStatTransaksi.PerformLayout()
        Me.pnlStatNilai.ResumeLayout(False)
        Me.pnlStatNilai.PerformLayout()
        Me.pnlStatRare.ResumeLayout(False)
        Me.pnlStatRare.PerformLayout()
        Me.pnlStatKoleksi.ResumeLayout(False)
        Me.pnlStatKoleksi.PerformLayout()
        Me.pnlStatKartu.ResumeLayout(False)
        Me.pnlStatKartu.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblVersi As System.Windows.Forms.Label
    Friend WithEvents btnNavTransaksi As System.Windows.Forms.Button
    Friend WithEvents btnNavKoleksi As System.Windows.Forms.Button
    Friend WithEvents btnNavKartu As System.Windows.Forms.Button
    Friend WithEvents lblNavMenu As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlChartBox As System.Windows.Forms.Panel
    Friend WithEvents lstChart As System.Windows.Forms.ListBox
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatTransaksi As System.Windows.Forms.Panel
    Friend WithEvents lblStatTransaksiVal As System.Windows.Forms.Label
    Friend WithEvents lblStatTransaksiLabel As System.Windows.Forms.Label
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