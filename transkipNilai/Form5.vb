Imports System.Data.SqlClient
Public Class Form5
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tb_mhs", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tb_mhs")
        DataGridView1.DataSource = (Ds.Tables("tb_mhs"))

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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub
End Class