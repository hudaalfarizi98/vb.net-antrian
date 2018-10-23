Imports MySql.Data.MySqlClient
Public Class antrian_masuk

    Private Sub antrian_masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Call koneksi()
            Dim tanggal As String
            tanggal = Format(Now, "yyyy:MM:dd:HH:mm:ss")
            Dim str As String = "insert into pelanggan_masuk (jam_masuk) values ('" & tanggal & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Erro saat mencoba menulis data ke database")
        End Try
        Try
            Call koneksi()
            Dim str As String = "select * from pelanggan_masuk ORDER BY id DESC Limit 1"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                txtkategori.Text = "A"
                txthasil.Text = rd.Item("id") + rd.Item("jam_masuk")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class