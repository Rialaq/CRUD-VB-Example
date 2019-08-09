<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.BEmpleados = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 35.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 56)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "BackupDB"
        '
        'BEmpleados
        '
        Me.BEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BEmpleados.FlatAppearance.BorderSize = 0
        Me.BEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEmpleados.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.75!)
        Me.BEmpleados.ForeColor = System.Drawing.Color.White
        Me.BEmpleados.Location = New System.Drawing.Point(-5, 274)
        Me.BEmpleados.Name = "BEmpleados"
        Me.BEmpleados.Size = New System.Drawing.Size(414, 64)
        Me.BEmpleados.TabIndex = 41
        Me.BEmpleados.Text = "BackupDB"
        Me.BEmpleados.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre de la Base de Datos: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(223, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "warehouse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Para restaurar el backup ingrese al SMS "
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(403, 337)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BEmpleados)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Backup"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BEmpleados As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
