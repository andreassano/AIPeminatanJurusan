'Imports System.Data.Odbc
'Public Class Login

'    Sub Login()
'        Koneksi()
'        cmd = New OdbcCommand("SELECT * FROM nilai where Nama='" & Guna2TextBox1.Text & "' and Sekolah='" & Guna2TextBox2.Text & "'", Conn)
'        rd = cmd.ExecuteReader
'        rd.Read()
'        If rd.HasRows Then
'            MsgBox("Selamat Datang")
'            Form1.Show()
'            Me.Hide()
'            Nilai.Label8.Text = rd.Item("nama")
'            'Form7.ComboBox1.Text = rd.Item("id_outlet")
'            'Form7.TextBox1.Text = rd.Item("nama")
'            'Form7.TextBox8.Text = rd.Item("nama_outlet")
'            'TextBox1.Text = ""
'            'TextBox2.Text = ""
'        Else
'            MsgBox("Nama dan Kelas anda salah")
'        'TextBox1.Text = ""
'        'TextBox2.Text = ""
'        'TextBox1.Focus()
'        End If
'    End Sub

'    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
'        Call Koneksi()
'        Call Login()
'    End Sub
'End Class