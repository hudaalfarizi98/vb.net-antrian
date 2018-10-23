Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Call koneksi()
            Dim str As String = "Select * from user where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' "
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                halaman_utama.Show()
                Me.Hide()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class