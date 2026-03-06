Public Module ModulBuku

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    Public Sub HapusBuku(ByVal judul As String, ByRef berhasil As Boolean)
        berhasil = False
        Dim indexDitemukan As Integer = -1

        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                indexDitemukan = i
                Exit For
            End If
        Next

        If indexDitemukan >= 0 Then
            For i As Integer = indexDitemukan To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            daftarBuku(jumlahBuku - 1, 0) = ""
            daftarBuku(jumlahBuku - 1, 1) = ""
            jumlahBuku -= 1
            berhasil = True
        End If
    End Sub

    Public Function FormatBuku(ByVal judul As String, ByVal genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    Public Function BukuSudahAda(ByVal judul As String) As Boolean
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return True
            End If
        Next
        Return False
    End Function

End Module