Imports System.Data.Odbc
Public Class minat

    Private Sub Guna2Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Call Koneksi()
        Call Soal1.clearcheck()
        Me.Hide()
        Form1.Guna2Button2.Enabled = False
        Form1.Guna2Panel2.Controls.Clear()
        Soal1.TopLevel = False
        Form1.Guna2Panel2.Controls.Add(Soal1)
        Soal1.Show()
    End Sub

    Private Sub Guna2Shapes1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Shapes1.Click

    End Sub
End Class