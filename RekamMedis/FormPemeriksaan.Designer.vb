<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemeriksaan
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
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ldokter = New System.Windows.Forms.Label()
        Me.lpasien = New System.Windows.Forms.Label()
        Me.btnperiksa = New System.Windows.Forms.Button()
        Me.btnperbarui = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.tCari = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "> Data Dokter"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"pendaftaran", "pemeriksaan", "tebus_obat", "selesai"})
        Me.cbStatus.Location = New System.Drawing.Point(213, 21)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(236, 21)
        Me.cbStatus.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Dokter :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Status :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Pasien :"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Crimson
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Location = New System.Drawing.Point(898, 28)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(88, 47)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 89)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 17)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Home"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 251)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(972, 200)
        Me.DataGridView1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ldokter)
        Me.Panel2.Controls.Add(Me.lpasien)
        Me.Panel2.Controls.Add(Me.cbStatus)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnperiksa)
        Me.Panel2.Controls.Add(Me.btnperbarui)
        Me.Panel2.Location = New System.Drawing.Point(18, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1003, 98)
        Me.Panel2.TabIndex = 37
        '
        'ldokter
        '
        Me.ldokter.AutoSize = True
        Me.ldokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldokter.Location = New System.Drawing.Point(12, 62)
        Me.ldokter.Name = "ldokter"
        Me.ldokter.Size = New System.Drawing.Size(77, 13)
        Me.ldokter.TabIndex = 24
        Me.ldokter.Text = "nama dokter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lpasien
        '
        Me.lpasien.AutoSize = True
        Me.lpasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpasien.Location = New System.Drawing.Point(11, 18)
        Me.lpasien.Name = "lpasien"
        Me.lpasien.Size = New System.Drawing.Size(78, 13)
        Me.lpasien.TabIndex = 23
        Me.lpasien.Text = "nama pasien"
        '
        'btnperiksa
        '
        Me.btnperiksa.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnperiksa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnperiksa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperiksa.ForeColor = System.Drawing.Color.Transparent
        Me.btnperiksa.Location = New System.Drawing.Point(800, 27)
        Me.btnperiksa.Name = "btnperiksa"
        Me.btnperiksa.Size = New System.Drawing.Size(81, 48)
        Me.btnperiksa.TabIndex = 5
        Me.btnperiksa.Text = "PERIKSA"
        Me.btnperiksa.UseVisualStyleBackColor = False
        '
        'btnperbarui
        '
        Me.btnperbarui.BackColor = System.Drawing.Color.YellowGreen
        Me.btnperbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnperbarui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperbarui.ForeColor = System.Drawing.Color.Transparent
        Me.btnperbarui.Location = New System.Drawing.Point(690, 27)
        Me.btnperbarui.Name = "btnperbarui"
        Me.btnperbarui.Size = New System.Drawing.Size(91, 48)
        Me.btnperbarui.TabIndex = 4
        Me.btnperbarui.Text = "PERBARUI"
        Me.btnperbarui.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-11, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 90)
        Me.Panel1.TabIndex = 36
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
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Location = New System.Drawing.Point(0, 451)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1027, 22)
        Me.ToolStripStatusLabel1.TabIndex = 34
        Me.ToolStripStatusLabel1.Text = "StatusStrip1"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 36)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(971, 217)
        Me.DataGridView2.TabIndex = 8
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
        'tCari
        '
        Me.tCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCari.Location = New System.Drawing.Point(738, 4)
        Me.tCari.Name = "tCari"
        Me.tCari.Size = New System.Drawing.Size(166, 26)
        Me.tCari.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Controls.Add(Me.btnCari)
        Me.Panel3.Controls.Add(Me.tCari)
        Me.Panel3.Location = New System.Drawing.Point(18, 217)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1002, 260)
        Me.Panel3.TabIndex = 38
        '
        'FormPemeriksaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 473)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripStatusLabel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormPemeriksaan"
        Me.Text = "FormPemeriksaan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnperiksa As Button
    Friend WithEvents btnperbarui As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripStatusLabel1 As StatusStrip
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents tCari As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ldokter As Label
    Friend WithEvents lpasien As Label
End Class
