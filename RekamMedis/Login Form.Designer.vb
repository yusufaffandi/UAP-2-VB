<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OliveDrab
        Me.Label1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Ivory
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'tUsername
        '
        Me.tUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.Location = New System.Drawing.Point(161, 183)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(136, 26)
        Me.tUsername.TabIndex = 1
        '
        'tPassword
        '
        Me.tPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.Location = New System.Drawing.Point(161, 252)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(136, 26)
        Me.tPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(194, 298)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(79, 36)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.OliveDrab
        Me.Label4.Font = New System.Drawing.Font("Garamond", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Ivory
        Me.Label4.Location = New System.Drawing.Point(97, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Aplikasi Rekam Medis"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 94)
        Me.Panel1.TabIndex = 7
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(474, 438)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.tUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tUsername As TextBox
    Friend WithEvents tPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
