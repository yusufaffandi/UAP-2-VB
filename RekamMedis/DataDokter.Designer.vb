<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataDokter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tSpesialis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnPerbarui = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tCari = New System.Windows.Forms.TextBox()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.StatusStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "> Data Dokter"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tSpesialis)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbGender)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.btnPerbarui)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.tPassword)
        Me.Panel2.Controls.Add(Me.tUsername)
        Me.Panel2.Controls.Add(Me.tNama)
        Me.Panel2.Location = New System.Drawing.Point(18, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1003, 98)
        Me.Panel2.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(250, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Spesialis :"
        '
        'tSpesialis
        '
        Me.tSpesialis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSpesialis.Location = New System.Drawing.Point(253, 27)
        Me.tSpesialis.Multiline = True
        Me.tSpesialis.Name = "tSpesialis"
        Me.tSpesialis.Size = New System.Drawing.Size(156, 58)
        Me.tSpesialis.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Jenis Kelamin :"
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbGender.Location = New System.Drawing.Point(14, 64)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(192, 21)
        Me.cbGender.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(439, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama :"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Crimson
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.Transparent
        Me.btnHapus.Location = New System.Drawing.Point(898, 28)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(88, 47)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnPerbarui
        '
        Me.btnPerbarui.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerbarui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerbarui.ForeColor = System.Drawing.Color.Transparent
        Me.btnPerbarui.Location = New System.Drawing.Point(800, 27)
        Me.btnPerbarui.Name = "btnPerbarui"
        Me.btnPerbarui.Size = New System.Drawing.Size(81, 48)
        Me.btnPerbarui.TabIndex = 5
        Me.btnPerbarui.Text = "PERBARUI"
        Me.btnPerbarui.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Transparent
        Me.btnTambah.Location = New System.Drawing.Point(693, 27)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(91, 48)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'tPassword
        '
        Me.tPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.Location = New System.Drawing.Point(440, 64)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(193, 23)
        Me.tPassword.TabIndex = 2
        '
        'tUsername
        '
        Me.tUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.Location = New System.Drawing.Point(439, 20)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(193, 23)
        Me.tUsername.TabIndex = 1
        '
        'tNama
        '
        Me.tNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNama.Location = New System.Drawing.Point(14, 20)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(193, 23)
        Me.tNama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(232, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 53)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "APLIKASI REKAM MEDIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(341, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 38)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "by affandyy33@gmail.com"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 93)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 17)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Home"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(972, 200)
        Me.DataGridView1.TabIndex = 21
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Orange
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.Transparent
        Me.btnCari.Location = New System.Drawing.Point(910, 3)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 27)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-11, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 90)
        Me.Panel1.TabIndex = 22
        '
        'tCari
        '
        Me.tCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCari.Location = New System.Drawing.Point(738, 4)
        Me.tCari.Name = "tCari"
        Me.tCari.Size = New System.Drawing.Size(166, 26)
        Me.tCari.TabIndex = 3
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Location = New System.Drawing.Point(0, 460)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1027, 22)
        Me.ToolStripStatusLabel1.TabIndex = 20
        Me.ToolStripStatusLabel1.Text = "StatusStrip1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnCari)
        Me.Panel3.Controls.Add(Me.tCari)
        Me.Panel3.Location = New System.Drawing.Point(18, 221)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1002, 260)
        Me.Panel3.TabIndex = 24
        '
        'DataDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 482)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripStatusLabel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "DataDokter"
        Me.Text = "DataDokter"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnPerbarui As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents tPassword As TextBox
    Friend WithEvents tUsername As TextBox
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tCari As TextBox
    Friend WithEvents ToolStripStatusLabel1 As StatusStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tSpesialis As TextBox
End Class
