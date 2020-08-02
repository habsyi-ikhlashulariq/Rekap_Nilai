<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataAmsterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMatakuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataNilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAmsterToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(388, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataAmsterToolStripMenuItem
        '
        Me.DataAmsterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MahasiswaToolStripMenuItem, Me.MataKuliahToolStripMenuItem, Me.ToolStripMenuItem1, Me.NilaiToolStripMenuItem})
        Me.DataAmsterToolStripMenuItem.Name = "DataAmsterToolStripMenuItem"
        Me.DataAmsterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataAmsterToolStripMenuItem.Text = "Data Master"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'MataKuliahToolStripMenuItem
        '
        Me.MataKuliahToolStripMenuItem.Name = "MataKuliahToolStripMenuItem"
        Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MataKuliahToolStripMenuItem.Text = "Mata Kuliah"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NilaiToolStripMenuItem.Text = "Nilai"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMahasiswaToolStripMenuItem, Me.DataMatakuliahToolStripMenuItem, Me.DataNilaiToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataMahasiswaToolStripMenuItem
        '
        Me.DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        Me.DataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        '
        'DataMatakuliahToolStripMenuItem
        '
        Me.DataMatakuliahToolStripMenuItem.Name = "DataMatakuliahToolStripMenuItem"
        Me.DataMatakuliahToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DataMatakuliahToolStripMenuItem.Text = "Data Mata Kuliah"
        '
        'DataNilaiToolStripMenuItem
        '
        Me.DataNilaiToolStripMenuItem.Name = "DataNilaiToolStripMenuItem"
        Me.DataNilaiToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DataNilaiToolStripMenuItem.Text = "Data Nilai"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataAmsterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MataKuliahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents NilaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMatakuliahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataNilaiToolStripMenuItem As ToolStripMenuItem
End Class
