<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListResep
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
        Me.lpasien = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKeluhan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tDiagnosa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama :"
        '
        'lpasien
        '
        Me.lpasien.AutoSize = True
        Me.lpasien.Location = New System.Drawing.Point(43, 73)
        Me.lpasien.Name = "lpasien"
        Me.lpasien.Size = New System.Drawing.Size(40, 13)
        Me.lpasien.TabIndex = 1
        Me.lpasien.Text = "lpasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Keluhan :"
        '
        'tKeluhan
        '
        Me.tKeluhan.Location = New System.Drawing.Point(46, 137)
        Me.tKeluhan.Multiline = True
        Me.tKeluhan.Name = "tKeluhan"
        Me.tKeluhan.Size = New System.Drawing.Size(273, 99)
        Me.tKeluhan.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Diagnosa :"
        '
        'tDiagnosa
        '
        Me.tDiagnosa.Location = New System.Drawing.Point(46, 271)
        Me.tDiagnosa.Multiline = True
        Me.tDiagnosa.Name = "tDiagnosa"
        Me.tDiagnosa.Size = New System.Drawing.Size(273, 99)
        Me.tDiagnosa.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ResepObat :"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(385, 145)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(370, 225)
        Me.ListBox2.TabIndex = 7
        '
        'ListResep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tDiagnosa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tKeluhan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lpasien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListResep"
        Me.Text = "ListResep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lpasien As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tKeluhan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tDiagnosa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox2 As ListBox
End Class
