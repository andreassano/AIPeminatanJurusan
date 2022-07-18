Imports System.Data.Odbc
Public Class SignUp

    Sub kosongkan()
        Guna2TextBox1.Text = ""
        Guna2TextBox1.Text = ""
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM nilai WHERE Nama='" & Guna2TextBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Anda sudah mempunyai akun", MsgBoxStyle.Information)
        ElseIf Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into nilai values ('""','" & Guna2TextBox1.Text & "','" & Guna2TextBox2.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Akun anda berhasil dibuat", MsgBoxStyle.Information)
            Form1.Show()
            Me.Hide()
            Call kosongkan()
        End If
    End Sub
End Class