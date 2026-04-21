Imports MySqlConnector

Module ConnectionModule

    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=db_pokemon_cards;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module