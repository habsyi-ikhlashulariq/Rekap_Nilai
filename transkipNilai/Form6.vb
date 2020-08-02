Imports System.Data.SqlClient
Public Class Form6
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tb_matkul", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tb_matkul")
        DataGridView1.DataSource = (Ds.Tables("tb_matkul"))

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub
End Class