Public Class HomeAdmin
    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lHello.Text = "Hello, " & My.Settings.nama

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lTanggal.Text = Format(Now, "dd/MM/yyyy")
        lWaktu.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        DataAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterToolStripMenuItem.Click
        DataDokter.Show()
        Me.Hide()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        DataPasien.Show()
        Me.Hide()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        DataObat.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub PendaftaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendaftaranToolStripMenuItem.Click
        FormPendaftaran.Show()
    End Sub

    Private Sub PemeriksaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemeriksaanToolStripMenuItem.Click
        FormPemeriksaan.Show()
    End Sub

    Private Sub PengambilanObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengambilanObatToolStripMenuItem.Click
        FormResep.Show()
    End Sub
End Class
