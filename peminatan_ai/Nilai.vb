Imports System.Data.Odbc
Public Class Nilai

    Sub TampilGrid()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT Nama, Asal_Sekolah, Matematika, Bahasa_Indonesia, Bahasa_Inggris FROM nilai WHERE Nama='" & Guna2TextBox5.Text & "'", Conn)
        ds = New DataSet
        cmd = New OdbcCommand("SELECT * FROM nilai WHERE Nama='" & Guna2TextBox5.Text & "'", Conn)
        da.Fill(ds)
        Guna2DataGridView1.DataSource = ds.Tables(0)
        Guna2DataGridView1.ReadOnly = True
    End Sub

    Sub kosongkan()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2TextBox5.Text = ""
        Guna2TextBox6.Text = ""
    End Sub

    Private Sub Nilai_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TampilGrid()
        Call kosongkan()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        cmd = New OdbcCommand("SELECT * FROM nilai WHERE Nama='" & Guna2TextBox5.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Nama tersebut sudah terinput sistem, silahkan ubah nama anda...", MsgBoxStyle.Information)
            Call kosongkan()
        ElseIf Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Then
            MsgBox("Silahkan Isi Semua Data..")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into nilai values ('""','" & Guna2TextBox5.Text & "','" & Guna2TextBox6.Text & "','" & Guna2TextBox2.Text & "','" & Guna2TextBox1.Text & "','" & Guna2TextBox3.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Form1.Guna2Button1.Enabled = True
            cmd = New OdbcCommand("SELECT * FROM nilai WHERE Nama='" & Guna2TextBox5.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Hasil.Label5.Text = rd.Item("Nama")
                dump.Label1.Text = rd.Item("Nama")
                dump.Label2.Text = rd.Item("Asal_Sekolah")
                dump.Label3.Text = rd.Item("Matematika")
                dump.Label4.Text = rd.Item("Bahasa_Indonesia")
                dump.Label5.Text = rd.Item("Bahasa_Inggris")
            End If
            Guna2TextBox1.Enabled = False
            Guna2TextBox2.Enabled = False
            Guna2TextBox3.Enabled = False
            Guna2TextBox5.Enabled = False
            Guna2TextBox6.Enabled = False
            Call TampilGrid()
            Call kosongkan()
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Form1.Guna2Panel2.Controls.Clear()
        minat.TopLevel = False
        Form1.Guna2Panel2.Controls.Add(minat)
        minat.StartPosition = FormStartPosition.CenterScreen
        minat.Show()
    End Sub
End Class