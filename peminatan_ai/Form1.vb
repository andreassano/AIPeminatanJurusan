Public Class Form1

    Private Sub Guna2Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Guna2Panel2.Controls.Clear()
        minat.TopLevel = False
        Guna2Panel2.Controls.Add(minat)
        minat.StartPosition = FormStartPosition.CenterScreen
        minat.Show()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Guna2Panel2.Controls.Clear()
        Nilai.TopLevel = False
        Guna2Panel2.Controls.Add(Nilai)
        Nilai.StartPosition = FormStartPosition.CenterScreen
        Nilai.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna2Button2.Enabled = False
        Guna2Panel2.Controls.Clear()
        dashboard.TopLevel = False
        Guna2Panel2.Controls.Add(dashboard)
        dashboard.Show()
    End Sub
End Class
