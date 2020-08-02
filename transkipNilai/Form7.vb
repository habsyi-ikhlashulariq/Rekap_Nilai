Imports System.Data.SqlClient
Public Class Form7
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tb_nilai", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tb_nilai")
        DataGridView1.DataSource = (Ds.Tables("tb_nilai"))

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

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub
End Class