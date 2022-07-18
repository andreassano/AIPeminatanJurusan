Imports System.Data.Odbc
Public Class Soal3

    Sub clearcheck()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Sub jumlahdata()
        Label3.Text = "3" & Space(2) & "/"
        Call Koneksi()
        cmd = New OdbcCommand("select count(*) from soal", Conn)
        Dim count1 As Integer
        count1 = Convert.ToString(cmd.ExecuteScalar)
        pagerows = Math.Ceiling(count1)
        Label6.Text = pagerows
    End Sub

    Private Sub Soal3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Koneksi()
        Call jumlahdata()
        Call clearcheck()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Soal1.RadioButton2.Checked Or Soal2.RadioButton2.Checked Or dump.Label3.Text & dump.Label5.Text > dump.Label4.Text Then
            Hasil.Label6.Text = "Teknik Informatika"
        ElseIf Soal1.RadioButton1.Checked Or RadioButton1.Checked Or dump.Label4.Text & dump.Label5.Text > dump.Label3.Text Then
            Hasil.Label6.Text = "Desain Komunikasi Visual"
        End If

        Form1.Guna2Panel2.Controls.Clear()
        Hasil.TopLevel = False
        Form1.Guna2Panel2.Controls.Add(Hasil)
        Hasil.Show()
    End Sub
End Class