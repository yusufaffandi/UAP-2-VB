<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResep
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
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.StatusStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lDokter = New System.Windows.Forms.Label()
        Me.lPasien = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPerbarui = New System.Windows.Forms.Button()
        Me.btnPeriksa = New System.Windows.Forms.Button()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Location = New System.Drawing.Point(0, 458)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1027, 22)
        Me.ToolStripStatusLabel1.TabIndex = 41
        Me.ToolStripStatusLabel1.Text = "StatusStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(374, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 38)
        Me.Label2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-11, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 90)
        Me.Panel1.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Coral
        Me.Label4.Location = New System.Drawing.Point(243, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 53)
        Me.Label4.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(215, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 53)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "APLIKASI REKAM MEDIS"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 89)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 17)
        Me.LinkLabel1.TabIndex = 46
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Home"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "> Data Dokter"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lDokter)
        Me.Panel2.Controls.Add(Me.lPasien)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnPerbarui)
        Me.Panel2.Controls.Add(Me.btnPeriksa)
        Me.Panel2.Controls.Add(Me.cbStatus)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(18, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 98)
        Me.Panel2.TabIndex = 48
        '
        'lDokter
        '
        Me.lDokter.AutoSize = True
        Me.lDokter.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDokter.Location = New System.Drawing.Point(12, 74)
        Me.lDokter.Name = "lDokter"
        Me.lDokter.Size = New System.Drawing.Size(41, 16)
        Me.lDokter.TabIndex = 9
        Me.lDokter.Text = "Pasien"
        '
        'lPasien
        '
        Me.lPasien.AutoSize = True
        Me.lPasien.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPasien.Location = New System.Drawing.Point(12, 30)
        Me.lPasien.Name = "lPasien"
        Me.lPasien.Size = New System.Drawing.Size(41, 16)
        Me.lPasien.TabIndex = 8
        Me.lPasien.Text = "Pasien"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Red
        Me.btnRefresh.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(812, 31)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(108, 52)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnPerbarui
        '
        Me.btnPerbarui.BackColor = System.Drawing.Color.Yellow
        Me.btnPerbarui.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerbarui.Location = New System.Drawing.Point(686, 31)
        Me.btnPerbarui.Name = "btnPerbarui"
        Me.btnPerbarui.Size = New System.Drawing.Size(108, 52)
        Me.btnPerbarui.TabIndex = 5
        Me.btnPerbarui.Text = "Perbarui"
        Me.btnPerbarui.UseVisualStyleBackColor = False
        '
        'btnPeriksa
        '
        Me.btnPeriksa.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPeriksa.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriksa.Location = New System.Drawing.Point(552, 31)
        Me.btnPeriksa.Name = "btnPeriksa"
        Me.btnPeriksa.Size = New System.Drawing.Size(108, 52)
        Me.btnPeriksa.TabIndex = 4
        Me.btnPeriksa.Text = "Lihat Resep"
        Me.btnPeriksa.UseVisualStyleBackColor = False
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Pendaftaran", "Pemeriksaan", "Tebus_Obat", "Selesai"})
        Me.cbStatus.Location = New System.Drawing.Point(327, 33)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(153, 21)
        Me.cbStatus.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Dokter :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pasien :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(18, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(991, 219)
        Me.Panel3.TabIndex = 49
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(960, 189)
        Me.DataGridView1.TabIndex = 0
        '
        'tCari
        '
        Me.tCari.Location = New System.Drawing.Point(704, 213)
        Me.tCari.Multiline = True
        Me.tCari.Name = "tCari"
        Me.tCari.Size = New System.Drawing.Size(191, 29)
        Me.tCari.TabIndex = 50
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Tomato
        Me.btnCari.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(901, 210)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(108, 33)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'FormResep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 480)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.tCari)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStripStatusLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormResep"
        Me.Text = "FormResep"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel1 As StatusStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPerbarui As Button
    Friend WithEvents btnPeriksa As Button
    Friend WithEvents tCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents lDokter As Label
    Friend WithEvents lPasien As Label
End Class
