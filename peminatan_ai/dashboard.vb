Imports System.Data.Odbc
Public Class dashboard

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Form1.Guna2Button2.Enabled = True
        Form1.Guna2Panel2.Controls.Clear()
        Nilai.TopLevel = False
        Form1.Guna2Panel2.Controls.Add(Nilai)
        Nilai.StartPosition = FormStartPosition.CenterScreen
        Nilai.Show()
    End Sub
End Class