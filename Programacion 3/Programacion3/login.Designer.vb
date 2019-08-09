<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FPass = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TestDB = New System.Windows.Forms.Button()
        Me.FUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 35.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 56)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inicio de Sesion"
        '
        'FPass
        '
        Me.FPass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPass.Location = New System.Drawing.Point(44, 225)
        Me.FPass.Mask = "9999999"
        Me.FPass.Name = "FPass"
        Me.FPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.FPass.Size = New System.Drawing.Size(192, 25)
        Me.FPass.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-6, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(298, 64)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TestDB
        '
        Me.TestDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TestDB.FlatAppearance.BorderSize = 0
        Me.TestDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestDB.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.TestDB.ForeColor = System.Drawing.Color.White
        Me.TestDB.Location = New System.Drawing.Point(359, 133)
        Me.TestDB.Name = "TestDB"
        Me.TestDB.Size = New System.Drawing.Size(132, 36)
        Me.TestDB.TabIndex = 47
        Me.TestDB.Text = "TestDB"
        Me.TestDB.UseVisualStyleBackColor = False
        '
        'FUser
        '
        Me.FUser.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUser.Location = New System.Drawing.Point(44, 162)
        Me.FUser.Name = "FUser"
        Me.FUser.Size = New System.Drawing.Size(192, 25)
        Me.FUser.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario"
        '
        'login
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 387)
        Me.Controls.Add(Me.TestDB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FPass)
        Me.Controls.Add(Me.FUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents FPass As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TestDB As Button
    Friend WithEvents FUser As TextBox
    Friend WithEvents Label3 As Label
End Class
