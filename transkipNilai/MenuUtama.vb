Public Class MenuUtama
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub DataAmsterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAmsterToolStripMenuItem.Click

    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub NilaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NilaiToolStripMenuItem.Click
        Form1.ShowDialog()

    End Sub

    Private Sub MataKuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataKuliahToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub

    Private Sub DataMatakuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMatakuliahToolStripMenuItem.Click
        Form6.ShowDialog()
    End Sub

    Private Sub DataNilaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataNilaiToolStripMenuItem.Click
        Form7.ShowDialog()
    End Sub
End Class