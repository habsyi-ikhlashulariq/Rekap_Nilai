<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_tugas = New System.Windows.Forms.TextBox()
        Me.tx_keaktifan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_uts = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_uas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tx_presensi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tx_npm = New System.Windows.Forms.TextBox()
        Me.tx_kd_matkul = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lb_nm_mhs = New System.Windows.Forms.Label()
        Me.lb_nm_matkul = New System.Windows.Forms.Label()
        Me.lb_sks = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tx_id = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tugas"
        '
        'tx_tugas
        '
        Me.tx_tugas.Location = New System.Drawing.Point(85, 195)
        Me.tx_tugas.Name = "tx_tugas"
        Me.tx_tugas.Size = New System.Drawing.Size(100, 20)
        Me.tx_tugas.TabIndex = 1
        '
        'tx_keaktifan
        '
        Me.tx_keaktifan.Location = New System.Drawing.Point(85, 230)
        Me.tx_keaktifan.Name = "tx_keaktifan"
        Me.tx_keaktifan.Size = New System.Drawing.Size(100, 20)
        Me.tx_keaktifan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Keaktifan"
        '
        'tx_uts
        '
        Me.tx_uts.Location = New System.Drawing.Point(244, 189)
        Me.tx_uts.Name = "tx_uts"
        Me.tx_uts.Size = New System.Drawing.Size(100, 20)
        Me.tx_uts.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UTS"
        '
        'tx_uas
        '
        Me.tx_uas.Location = New System.Drawing.Point(244, 234)
        Me.tx_uas.Name = "tx_uas"
        Me.tx_uas.Size = New System.Drawing.Size(100, 20)
        Me.tx_uas.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "UAS"
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(32, 316)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(132, 23)
        Me.btn_hitung.TabIndex = 8
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(464, 203)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(170, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nilai Akhir"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(464, 229)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(170, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(394, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Grade"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(464, 260)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(170, 20)
        Me.TextBox7.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Keterangan"
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(180, 316)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(132, 23)
        Me.btn_reset.TabIndex = 15
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(313, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "NILAI MAHASISWA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "INPUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(559, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(464, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(559, 322)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "TUTUP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 158)
        Me.DataGridView1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Presensi"
        '
        'tx_presensi
        '
        Me.tx_presensi.Location = New System.Drawing.Point(85, 263)
        Me.tx_presensi.Name = "tx_presensi"
        Me.tx_presensi.Size = New System.Drawing.Size(100, 20)
        Me.tx_presensi.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "* max 16x pertemuan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Input Nilai Mahasiswa :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(378, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Hasil Input Nilai"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Input Mahasiswa Dan Matakuliah"
        '
        'tx_npm
        '
        Me.tx_npm.Location = New System.Drawing.Point(230, 99)
        Me.tx_npm.Name = "tx_npm"
        Me.tx_npm.Size = New System.Drawing.Size(115, 20)
        Me.tx_npm.TabIndex = 23
        '
        'tx_kd_matkul
        '
        Me.tx_kd_matkul.Location = New System.Drawing.Point(411, 102)
        Me.tx_kd_matkul.Name = "tx_kd_matkul"
        Me.tx_kd_matkul.Size = New System.Drawing.Size(128, 20)
        Me.tx_kd_matkul.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(227, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "NPM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(408, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Kode Matkul"
        '
        'lb_nm_mhs
        '
        Me.lb_nm_mhs.AutoSize = True
        Me.lb_nm_mhs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nm_mhs.Location = New System.Drawing.Point(230, 126)
        Me.lb_nm_mhs.Name = "lb_nm_mhs"
        Me.lb_nm_mhs.Size = New System.Drawing.Size(91, 13)
        Me.lb_nm_mhs.TabIndex = 26
        Me.lb_nm_mhs.Text = "Nama Mahasiswa"
        '
        'lb_nm_matkul
        '
        Me.lb_nm_matkul.AutoSize = True
        Me.lb_nm_matkul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nm_matkul.Location = New System.Drawing.Point(412, 126)
        Me.lb_nm_matkul.Name = "lb_nm_matkul"
        Me.lb_nm_matkul.Size = New System.Drawing.Size(70, 13)
        Me.lb_nm_matkul.TabIndex = 26
        Me.lb_nm_matkul.Text = "Nama Matkul"
        '
        'lb_sks
        '
        Me.lb_sks.AutoSize = True
        Me.lb_sks.Location = New System.Drawing.Point(412, 143)
        Me.lb_sks.Name = "lb_sks"
        Me.lb_sks.Size = New System.Drawing.Size(45, 13)
        Me.lb_sks.TabIndex = 27
        Me.lb_sks.Text = "Label16"
        Me.lb_sks.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(48, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "ID Nilai"
        '
        'tx_id
        '
        Me.tx_id.Location = New System.Drawing.Point(51, 98)
        Me.tx_id.Name = "tx_id"
        Me.tx_id.Size = New System.Drawing.Size(100, 20)
        Me.tx_id.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 543)
        Me.Controls.Add(Me.tx_id)
        Me.Controls.Add(Me.lb_sks)
        Me.Controls.Add(Me.lb_nm_matkul)
        Me.Controls.Add(Me.lb_nm_mhs)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tx_kd_matkul)
        Me.Controls.Add(Me.tx_npm)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.tx_uas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tx_uts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx_presensi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tx_keaktifan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tx_tugas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form Nilai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tx_tugas As TextBox
    Friend WithEvents tx_keaktifan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tx_uts As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tx_uas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_hitung As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents tx_presensi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tx_npm As TextBox
    Friend WithEvents tx_kd_matkul As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lb_nm_mhs As Label
    Friend WithEvents lb_nm_matkul As Label
    Friend WithEvents lb_sks As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tx_id As TextBox
End Class
