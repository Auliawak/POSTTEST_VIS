Public Class Form1

    Dim IP As Double = 0
    Dim Semester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim IPS As Double

        If Not Double.TryParse(txtIPS.Text, IPS) Then
            MessageBox.Show("Input harus berupa angka!", "GIMANA KAMU NI!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If IPS < 0 Or IPS > 4 Then
            MessageBox.Show("IP Semester harus antara 0.00 hingga 4.00!", "WE SALAH WE!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        IP += IPS
        Semester += 1

        Dim IPK As Double = IP / Semester

        txtIPK.Text = IPK.ToString("F2")

        If IPK >= 3.01 Then
            lblPredikat.Text = "Hebat Banget Kamu tuh"
        ElseIf IPK >= 2.76 Then
            lblPredikat.Text = "Hebat Kamu tuh"
        ElseIf IPK >= 2.0 Then
            lblPredikat.Text = "Lebih ditingkatkan lagi"
        Else
            lblPredikat.Text = "Gimana Kamu Ni IPK nya"
        End If

        txtIPS.Text = ""
        txtIPS.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        IP = 0
        Semester = 0

        txtIPS.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = ""

        txtIPS.Focus()
    End Sub

End Class