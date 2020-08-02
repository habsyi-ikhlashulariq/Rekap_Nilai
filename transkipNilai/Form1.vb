Imports System.Data.SqlClient
Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label9.Click

    End Sub
    Sub kosongkanData()
        tx_id.Text = ""
        tx_kd_matkul.Text = ""
        tx_npm.Text = ""
        tx_tugas.Text = ""
        tx_keaktifan.Text = ""
        tx_presensi.Text = ""
        tx_uts.Text = ""
        tx_uas.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

    End Sub
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tb_nilai", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tb_nilai")
        DataGridView1.DataSource = (Ds.Tables("tb_nilai"))

        Button1.Text = "INPUT"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        btn_hitung.Enabled = False
        btn_reset.Enabled = False
        tx_id.Enabled = False
        tx_kd_matkul.Enabled = False
        tx_npm.Enabled = False
        tx_tugas.Enabled = False
        tx_keaktifan.Enabled = False
        tx_presensi.Enabled = False
        tx_uts.Enabled = False
        tx_uas.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False

        Call kosongkanData()
    End Sub
    Sub siapIsi()
        DataGridView1.Enabled = True
        btn_hitung.Enabled = True
        btn_reset.Enabled = True
        tx_id.Enabled = True
        tx_kd_matkul.Enabled = True
        tx_npm.Enabled = True
        tx_tugas.Enabled = True
        tx_keaktifan.Enabled = True
        tx_presensi.Enabled = True
        tx_uts.Enabled = True
        tx_uas.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim rata As Integer
        Dim tugas, aktif, uts, uas, presensi, hitungPresensi As Double
        Dim ket, grade As String

        hitungPresensi = Val(tx_presensi.Text * 6.25)


        If tx_tugas.Text = "" Then
            aktif = Val(tx_keaktifan.Text * 15 / 100)
            presensi = hitungPresensi * 20 / 100
            uts = Val(tx_uts.Text * 20 / 100)
            uas = Val(tx_uas.Text * 25 / 100)

            rata = aktif + presensi + uts + uas
            TextBox5.Text = rata
        ElseIf tx_keaktifan.Text = "" Then
            tugas = Val(tx_tugas.Text * 20 / 100)
            presensi = hitungPresensi * 20 / 100
            uts = Val(tx_uts.Text * 20 / 100)
            uas = Val(tx_uas.Text * 25 / 100)

            rata = tugas + uts + uas + presensi
            TextBox5.Text = rata
        ElseIf tx_presensi.Text = "" Then
            tugas = Val(tx_tugas.Text * 20 / 100)
            aktif = Val(tx_keaktifan.Text * 15 / 100)
            uts = Val(tx_uts.Text * 20 / 100)
            uas = Val(tx_uas.Text * 25 / 100)

            rata = tugas + aktif + uts + uas
            TextBox5.Text = rata
        ElseIf tx_uts.Text = "" Then
            tugas = Val(tx_tugas.Text * 20 / 100)
            aktif = Val(tx_keaktifan.Text * 15 / 100)
            presensi = hitungPresensi * 20 / 100
            uas = Val(tx_uas.Text * 25 / 100)

            rata = tugas + aktif + uas + presensi
            TextBox5.Text = rata
        ElseIf tx_uas.Text = "" Then
            tugas = Val(tx_tugas.Text * 20 / 100)
            aktif = Val(tx_keaktifan.Text * 15 / 100)
            presensi = hitungPresensi * 20 / 100
            uts = Val(tx_uts.Text * 20 / 100)

            rata = tugas + aktif + uts + presensi
            TextBox5.Text = rata
        End If


        If tx_tugas.Text = "" Or tx_keaktifan.Text = "" Or
            tx_uts.Text = "" Or tx_uas.Text = "" Then

            grade = "T"
            ket = "Ada Yang Belum Diinput"

        Else
            tugas = Val(tx_tugas.Text * 20 / 100)
            aktif = Val(tx_keaktifan.Text * 15 / 100)
            presensi = hitungPresensi * 20 / 100
            uts = Val(tx_uts.Text * 20 / 100)
            uas = Val(tx_uas.Text * 25 / 100)
            rata = tugas + aktif + uts + uas + presensi
            TextBox5.Text = rata

            If rata >= 80 Then
                grade = "A"
                ket = "Sangat Baik"
            ElseIf rata >= 65 And rata < 80 Then
                grade = "B"
                ket = "Baik"
            ElseIf rata >= 55 And rata < 65 Then
                grade = "C"
                ket = "Cukup"
            ElseIf rata >= 40 And rata < 55 Then
                grade = "D"
                ket = "Tidak Baik"
            Else
                grade = "E"
                ket = "Sangat Tidak Baik"

            End If
        End If

        TextBox6.Text = grade
        TextBox7.Text = ket

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub tx_npm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_npm.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New SqlCommand("SELECT * FROM tb_mhs WHERE npm = '" & tx_npm.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                lb_nm_mhs.Text = Rd.Item("nm_mhs")
            Else
                lb_nm_mhs.Text = "Tidak Diketahui"
            End If
        End If
    End Sub

    Private Sub tx_kd_matkul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_kd_matkul.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()

            Cmd = New SqlCommand("SELECT * FROM tb_matkul WHERE kd_matkul = '" & tx_kd_matkul.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                lb_nm_matkul.Text = Rd.Item("nm_matkul")
                lb_sks.Text = Rd.Item("sks")
            Else
                lb_nm_matkul.Text = "Tidak Diketahui"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If tx_id.Text = "" Or tx_npm.Text = "" Or tx_kd_matkul.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or
            TextBox7.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim insertData As String = "INSERT INTO tb_nilai VALUES ('" & tx_id.Text & "',
                '" & tx_npm.Text & "', '" & tx_kd_matkul.Text & "',
                '" & lb_sks.Text & "', '" & TextBox5.Text & "',
                '" & TextBox6.Text & "', '" & TextBox7.Text & "')"
                Cmd = New SqlCommand(insertData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Insert Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Call kosongkanData()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If tx_npm.Text = "" Or tx_kd_matkul.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or
            TextBox7.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim updateData As String = "UPDATE tb_nilai SET npm='" & tx_npm.Text & "',
                kd_matkul='" & tx_kd_matkul.Text & "',
                nilai_akhir='" & TextBox5.Text & "', grade= '" & TextBox6.Text & "',
                ket= '" & TextBox7.Text & "' WHERE id='" & tx_id.Text & "'"
                Cmd = New SqlCommand(updateData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Update Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "DELETE" Then
            Button3.Text = "SIMPAN"
            Button2.Enabled = False
            Button1.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            Call koneksi()
            Dim deleteData As String = "DELETE FROM tb_nilai WHERE
            id='" & tx_id.Text & "'"
            Cmd = New SqlCommand(deleteData, conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Berhasil Delete Data")
            Call kondisiAwal()
            Call kosongkanData()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            Me.Close()
        Else
            Call kondisiAwal()
        End If
    End Sub
    Private Sub tx_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_id.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New SqlCommand("SELECT * FROM tb_nilai WHERE id = '" & tx_id.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                tx_npm.Text = Rd.Item("npm")
                tx_kd_matkul.Text = Rd.Item("kd_matkul")
                tx_npm.Text = Rd.Item("npm")
                TextBox5.Text = Rd.Item("nilai_akhir")
                TextBox6.Text = Rd.Item("grade")
                TextBox7.Text = Rd.Item("ket")
            Else
                MsgBox("Data Tidak Ditemukan")
                Call kosongkanData()
            End If
        End If
    End Sub
End Class
