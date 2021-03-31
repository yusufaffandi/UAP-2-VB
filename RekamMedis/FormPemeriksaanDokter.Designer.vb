<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemeriksaanDokter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tKeluhan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tDiagnosa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnTambahObat = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.lpasien = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KELUHAN :"
        '
        'tKeluhan
        '
        Me.tKeluhan.Location = New System.Drawing.Point(25, 97)
        Me.tKeluhan.Multiline = True
        Me.tKeluhan.Name = "tKeluhan"
        Me.tKeluhan.Size = New System.Drawing.Size(332, 84)
        Me.tKeluhan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DIAGNOSA :"
        '
        'tDiagnosa
        '
        Me.tDiagnosa.Location = New System.Drawing.Point(25, 216)
        Me.tDiagnosa.Multiline = True
        Me.tDiagnosa.Name = "tDiagnosa"
        Me.tDiagnosa.Size = New System.Drawing.Size(332, 84)
        Me.tDiagnosa.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RESEP OBAT :"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(429, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(252, 303)
        Me.ListBox1.TabIndex = 7
        '
        'btnTambahObat
        '
        Me.btnTambahObat.Location = New System.Drawing.Point(429, 345)
        Me.btnTambahObat.Name = "btnTambahObat"
        Me.btnTambahObat.Size = New System.Drawing.Size(252, 38)
        Me.btnTambahObat.TabIndex = 8
        Me.btnTambahObat.Text = "TAMBAH RESEP OBAT"
        Me.btnTambahObat.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(25, 435)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(656, 38)
        Me.btnSelesai.TabIndex = 9
        Me.btnSelesai.Text = "PERIKSA SELESAI"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'lpasien
        '
        Me.lpasien.AutoSize = True
        Me.lpasien.Location = New System.Drawing.Point(22, 41)
        Me.lpasien.Name = "lpasien"
        Me.lpasien.Size = New System.Drawing.Size(33, 13)
        Me.lpasien.TabIndex = 10
        Me.lpasien.Text = "nama"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(25, 337)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(332, 95)
        Me.ListBox2.TabIndex = 11
        '
        'FormPemeriksaanDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 485)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.lpasien)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnTambahObat)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tDiagnosa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tKeluhan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPemeriksaanDokter"
        Me.Text = "FormPemeriksaanDokter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tKeluhan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tDiagnosa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnTambahObat As Button
    Friend WithEvents btnSelesai As Button
    Friend WithEvents lpasien As Label
    Friend WithEvents ListBox2 As ListBox
End Class
