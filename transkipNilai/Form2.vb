Imports System.Data.SqlClient

Public Class Form2

    Sub kosongkanData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tb_mhs", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tb_mhs")
        DataGridView1.DataSource = (Ds.Tables("tb_mhs"))

        Button1.Text = "INPUT"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        DataGridView1.Enabled = False
    End Sub
    Sub siapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim insertData As String = "INSERT INTO tb_mhs VALUES ('" & TextBox1.Text & "',
                '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
                Cmd = New SqlCommand(insertData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Insert Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim updateData As String = "UPDATE tb_mhs SET nm_mhs='" & TextBox2.Text & "',
                kelas='" & TextBox3.Text & "', alamat= '" & TextBox4.Text & "' WHERE
                npm='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(updateData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Update Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "DELETE" Then
            Button3.Text = "SIMPAN"
            Button2.Enabled = False
            Button1.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            Call koneksi()
            Dim deleteData As String = "DELETE FROM tb_mhs WHERE
            npm='" & TextBox1.Text & "'"
            Cmd = New SqlCommand(deleteData, conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Berhasil Delete Data")
            Call kondisiAwal()
            Call kosongkanData()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New SqlCommand("SELECT * FROM tb_mhs WHERE npm = '" & TextBox1.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("nm_mhs")
                TextBox3.Text = Rd.Item("kelas")
                TextBox4.Text = Rd.Item("alamat")
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            Me.Close()
        Else
            Call kondisiAwal()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        On Error Resume Next
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class