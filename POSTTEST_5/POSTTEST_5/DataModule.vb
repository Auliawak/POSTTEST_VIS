Imports MySqlConnector

Module DataModule

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

    Public Function HapusKoleksi(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

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
        Try
            Dim query As String =
                "SELECT " &
                "(SELECT COUNT(*) FROM tb_kartu)                              AS total_kartu, " &
                "(SELECT COUNT(*) FROM tb_koleksi)                            AS total_koleksi, " &
                "(SELECT COUNT(*) FROM tb_kartu WHERE rarity = 'Rare Holo')  AS kartu_rare, " &
                "(SELECT COUNT(*) FROM tb_kartu WHERE rarity = 'Ultra Rare') AS kartu_ultra, " &
                "(SELECT COALESCE(SUM(harga_estimasi), 0) FROM tb_kartu)     AS total_nilai"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function GetKartuPerTipe() As DataTable
        Dim dt As New DataTable()
        Try
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
        Catch ex As Exception
        End Try
        Return dt
    End Function

End Module