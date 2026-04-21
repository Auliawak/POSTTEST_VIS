Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngkaDesimal(e As KeyPressEventArgs, teksSekarang As String)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "."c AndAlso Not teksSekarang.Contains(".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function FormatRupiah(nilai As Decimal) As String
        Return "Rp " & nilai.ToString("N0").Replace(",", ".")
    End Function

End Module