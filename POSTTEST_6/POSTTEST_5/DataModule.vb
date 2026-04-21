Imports MySqlConnector

Module DataModule

    ' ============================================================
    '  BAGIAN 1 — KARTU POKEMON
    '  Dipakai oleh: FormKartu
    ' ============================================================

    ' Mengambil semua kartu beserta nama koleksinya (LEFT JOIN)
    ' Dipakai: FormKartu.TampilData, FormKartu.btnBatal_Click
    Public Function GetAllKartu() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT k.id_kartu, k.nama_kartu, k.no_pokedex, k.tipe, k.rarity, " &
                "k.kondisi, k.tahun_rilis, k.harga_estimasi, k.catatan, " &
                "k.id_koleksi, ko.nama_koleksi " &
                "FROM tb_kartu k " &
                "LEFT JOIN tb_koleksi ko ON k.id_koleksi = ko.id_koleksi " &
                "ORDER BY k.nama_kartu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data kartu: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Mencari kartu berdasarkan keyword (nama, tipe, rarity, atau koleksi)
    ' Dipakai: FormKartu.txtSearch_TextChanged
    Public Function SearchKartu(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT k.id_kartu, k.nama_kartu, k.no_pokedex, k.tipe, k.rarity, " &
                "k.kondisi, k.tahun_rilis, k.harga_estimasi, k.catatan, " &
                "k.id_koleksi, ko.nama_koleksi " &
                "FROM tb_kartu k " &
                "LEFT JOIN tb_koleksi ko ON k.id_koleksi = ko.id_koleksi " &
                "WHERE k.nama_kartu LIKE @kw OR k.tipe LIKE @kw " &
                "OR k.rarity LIKE @kw OR k.no_pokedex LIKE @kw " &
                "OR ko.nama_koleksi LIKE @kw " &
                "ORDER BY k.nama_kartu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Mengambil satu kartu berdasarkan id_kartu
    ' Dipakai: FormKartu.dgvKartu_CellClick -> IsiForm
    Public Function GetKartuById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT k.*, ko.nama_koleksi " &
                "FROM tb_kartu k " &
                "LEFT JOIN tb_koleksi ko ON k.id_koleksi = ko.id_koleksi " &
                "WHERE k.id_kartu = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data kartu: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Menyimpan kartu baru ke tabel tb_kartu
    ' Dipakai: FormKartu.btnSimpan_Click
    Public Function SimpanKartu(namaKartu As String, noPokedex As String,
                                 tipe As String, rarity As String,
                                 kondisi As String, tahunRilis As Integer,
                                 harga As Decimal, catatan As String,
                                 idKoleksi As Integer) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_kartu " &
                "(nama_kartu, no_pokedex, tipe, rarity, kondisi, " &
                "tahun_rilis, harga_estimasi, catatan, id_koleksi) " &
                "VALUES (@nama, @no, @tipe, @rarity, @kondisi, " &
                "@tahun, @harga, @catatan, @idKoleksi)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", namaKartu)
                    cmd.Parameters.AddWithValue("@no", noPokedex)
                    cmd.Parameters.AddWithValue("@tipe", tipe)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@kondisi", kondisi)
                    cmd.Parameters.AddWithValue("@tahun", tahunRilis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@catatan", catatan)
                    cmd.Parameters.AddWithValue("@idKoleksi",
                        If(idKoleksi = 0, DBNull.Value, CObj(idKoleksi)))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Mengubah data kartu yang sudah ada berdasarkan id_kartu
    ' Dipakai: FormKartu.btnUbah_Click
    Public Function UbahKartu(id As Integer, namaKartu As String,
                               noPokedex As String, tipe As String,
                               rarity As String, kondisi As String,
                               tahunRilis As Integer, harga As Decimal,
                               catatan As String, idKoleksi As Integer) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_kartu SET " &
                "nama_kartu=@nama, no_pokedex=@no, tipe=@tipe, " &
                "rarity=@rarity, kondisi=@kondisi, tahun_rilis=@tahun, " &
                "harga_estimasi=@harga, catatan=@catatan, id_koleksi=@idKoleksi " &
                "WHERE id_kartu=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", namaKartu)
                    cmd.Parameters.AddWithValue("@no", noPokedex)
                    cmd.Parameters.AddWithValue("@tipe", tipe)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@kondisi", kondisi)
                    cmd.Parameters.AddWithValue("@tahun", tahunRilis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@catatan", catatan)
                    cmd.Parameters.AddWithValue("@idKoleksi",
                        If(idKoleksi = 0, DBNull.Value, CObj(idKoleksi)))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Menghapus kartu berdasarkan id_kartu
    ' Dipakai: FormKartu.btnHapus_Click
    Public Function HapusKartu(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_kartu WHERE id_kartu = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ============================================================
    '  BAGIAN 2 — KOLEKSI / SET
    '  Dipakai oleh: FormKoleksi, dan FormKartu (ComboBox koleksi)
    ' ============================================================

    ' Mengambil semua koleksi, diurutkan nama
    ' Dipakai: FormKoleksi.TampilData, FormKartu.LoadKoleksiCombo
    Public Function GetAllKoleksi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id_koleksi, nama_koleksi, deskripsi, created_at " &
                "FROM tb_koleksi ORDER BY nama_koleksi ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan koleksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Mencari koleksi berdasarkan keyword (nama atau deskripsi)
    ' Dipakai: FormKoleksi.txtSearch_TextChanged
    Public Function SearchKoleksi(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id_koleksi, nama_koleksi, deskripsi, created_at " &
                "FROM tb_koleksi " &
                "WHERE nama_koleksi LIKE @kw OR deskripsi LIKE @kw " &
                "ORDER BY nama_koleksi ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari koleksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Menyimpan koleksi baru ke tabel tb_koleksi
    ' Dipakai: FormKoleksi.btnSimpan_Click
    Public Function SimpanKoleksi(namaKoleksi As String, deskripsi As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_koleksi (nama_koleksi, deskripsi) VALUES (@nama, @desk)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", namaKoleksi)
                    cmd.Parameters.AddWithValue("@desk", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan koleksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Mengubah nama dan deskripsi koleksi berdasarkan id_koleksi
    ' Dipakai: FormKoleksi.btnUbah_Click
    Public Function UbahKoleksi(id As Integer, namaKoleksi As String,
                                 deskripsi As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_koleksi SET nama_koleksi=@nama, deskripsi=@desk " &
                "WHERE id_koleksi=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", namaKoleksi)
                    cmd.Parameters.AddWithValue("@desk", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah koleksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Menghapus koleksi; ditolak jika masih ada kartu yang merujuk koleksi ini
    ' Dipakai: FormKoleksi.btnHapus_Click
    Public Function HapusKoleksi(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Cek apakah masih ada kartu dalam koleksi ini
                Dim queryCek As String =
                    "SELECT COUNT(*) FROM tb_kartu WHERE id_koleksi = @id"
                Using cmdCek As New MySqlCommand(queryCek, conn)
                    cmdCek.Parameters.AddWithValue("@id", id)
                    Dim jumlah As Integer = Convert.ToInt32(cmdCek.ExecuteScalar())
                    If jumlah > 0 Then
                        MessageBox.Show(
                            "Tidak dapat menghapus!" & vbNewLine &
                            "Masih ada " & jumlah & " kartu dalam koleksi ini." & vbNewLine &
                            "Pindahkan atau hapus kartu tersebut terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End Using

                ' Aman untuk dihapus
                Dim queryHapus As String =
                    "DELETE FROM tb_koleksi WHERE id_koleksi = @id"
                Using cmd As New MySqlCommand(queryHapus, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus koleksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function GetStatistik() As DataTable
        Dim dt As New DataTable()
        Dim query As String =
                "SELECT " &
                "(SELECT COUNT(*) FROM tb_kartu)                              AS total_kartu, " &
                "(SELECT COUNT(*) FROM tb_koleksi)                            AS total_koleksi, " &
                "(SELECT COUNT(*) FROM tb_kartu WHERE rarity = 'Rare Holo')  AS kartu_rare, " &
                "(SELECT COUNT(*) FROM tb_kartu WHERE rarity = 'Ultra Rare') AS kartu_ultra, " &
                "(SELECT COALESCE(SUM(harga_estimasi), 0) FROM tb_kartu)     AS total_nilai, " &
                "(SELECT COUNT(*) FROM tb_transaksi)                           AS total_transaksi"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
            Return dt
    End Function
    Public Function GetKartuPerTipe() As DataTable
        Dim dt As New DataTable()
        Dim query As String =
                "SELECT tipe, COUNT(*) AS jumlah " &
                "FROM tb_kartu " &
                "GROUP BY tipe " &
                "ORDER BY jumlah DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
            Return dt
    End Function

    Public Function GetAllTransaksi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.id_transaksi, t.id_kartu, k.nama_kartu, " &
                "t.jenis, t.harga, t.tanggal, t.nama_pembeli, t.catatan " &
                "FROM tb_transaksi t " &
                "INNER JOIN tb_kartu k ON t.id_kartu = k.id_kartu " &
                "ORDER BY t.tanggal DESC, t.id_transaksi DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan transaksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function SearchTransaksi(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.id_transaksi, t.id_kartu, k.nama_kartu, " &
                "t.jenis, t.harga, t.tanggal, t.nama_pembeli, t.catatan " &
                "FROM tb_transaksi t " &
                "INNER JOIN tb_kartu k ON t.id_kartu = k.id_kartu " &
                "WHERE k.nama_kartu LIKE @kw OR t.jenis LIKE @kw " &
                "OR t.nama_pembeli LIKE @kw OR t.catatan LIKE @kw " &
                "ORDER BY t.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari transaksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function GetTransaksiById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.*, k.nama_kartu FROM tb_transaksi t " &
                "INNER JOIN tb_kartu k ON t.id_kartu = k.id_kartu " &
                "WHERE t.id_transaksi = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data transaksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function SimpanTransaksi(idKartu As Integer, jenis As String,
                                     harga As Decimal, tanggal As Date,
                                     namaPembeli As String, catatan As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_transaksi " &
                "(id_kartu, jenis, harga, tanggal, nama_pembeli, catatan) " &
                "VALUES (@idKartu, @jenis, @harga, @tgl, @pembeli, @catatan)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idKartu", idKartu)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@pembeli",
                        If(namaPembeli = "", DBNull.Value, CObj(namaPembeli)))
                    cmd.Parameters.AddWithValue("@catatan",
                        If(catatan = "", DBNull.Value, CObj(catatan)))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UbahTransaksi(id As Integer, idKartu As Integer,
                                   jenis As String, harga As Decimal,
                                   tanggal As Date, namaPembeli As String,
                                   catatan As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_transaksi SET " &
                "id_kartu=@idKartu, jenis=@jenis, harga=@harga, " &
                "tanggal=@tgl, nama_pembeli=@pembeli, catatan=@catatan " &
                "WHERE id_transaksi=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@idKartu", idKartu)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@pembeli",
                        If(namaPembeli = "", DBNull.Value, CObj(namaPembeli)))
                    cmd.Parameters.AddWithValue("@catatan",
                        If(catatan = "", DBNull.Value, CObj(catatan)))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah transaksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTransaksi(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_transaksi WHERE id_transaksi = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus transaksi: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function FilterKartuByTipe(tipe As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT k.id_kartu, k.nama_kartu, k.no_pokedex, k.tipe, k.rarity, " &
                "k.kondisi, k.tahun_rilis, k.harga_estimasi, k.catatan, " &
                "k.id_koleksi, ko.nama_koleksi " &
                "FROM tb_kartu k " &
                "LEFT JOIN tb_koleksi ko ON k.id_koleksi = ko.id_koleksi " &
                "WHERE k.tipe = @tipe " &
                "ORDER BY k.nama_kartu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@tipe", tipe)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memfilter data: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function FilterKartuByTipeAndKeyword(tipe As String, keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT k.id_kartu, k.nama_kartu, k.no_pokedex, k.tipe, k.rarity, " &
                "k.kondisi, k.tahun_rilis, k.harga_estimasi, k.catatan, " &
                "k.id_koleksi, ko.nama_koleksi " &
                "FROM tb_kartu k " &
                "LEFT JOIN tb_koleksi ko ON k.id_koleksi = ko.id_koleksi " &
                "WHERE k.tipe = @tipe " &
                "AND (k.nama_kartu LIKE @kw OR k.rarity LIKE @kw " &
                "OR k.no_pokedex LIKE @kw OR ko.nama_koleksi LIKE @kw) " &
                "ORDER BY k.nama_kartu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@tipe", tipe)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memfilter data: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module