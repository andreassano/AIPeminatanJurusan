Imports System.Data.Odbc
Public Class Soal2

    Sub clearcheck()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Sub jumlahdata()
        Label3.Text = "2" & Space(2) & "/"
        Call Koneksi()
        cmd = New OdbcCommand("select count(*) from soal", Conn)
        Dim count1 As Integer
        count1 = Convert.ToString(cmd.ExecuteScalar)
        pagerows = Math.Ceiling(count1)
        Label6.Text = pagerows
    End Sub

    Private Sub Soal2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Koneksi()
        Call clearcheck()
        Call jumlahdata()
        'cmd = New OdbcCommand("select * from soal1 where no='" & Val(Label3.Text) & "'", Conn)
        'rd = cmd.ExecuteReader
        'rd.Read()
        'If rd.HasRows Then
        '    RadioButton1.Text = rd.Item("pertanyaan1")
        '    RadioButton2.Text = rd.Item("pertanyaan2")
        'End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.Hide()
        Form1.Guna2Button2.Enabled = False
        Form1.Guna2Panel2.Controls.Clear()
        Soal3.TopLevel = False
        Form1.Guna2Panel2.Controls.Add(Soal3)
        Soal3.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.Hide()
        Form1.Guna2Button2.Enabled = False
        Form1.Guna2Panel2.Controls.Clear()
        Soal3.TopLevel = False
        Form1.Guna2Panel2.Controls.Add(Soal3)
        Soal3.Show()
    End Sub
End Class