<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.BUser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BEmpleados = New System.Windows.Forms.Button()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BUser
        '
        Me.BUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BUser.FlatAppearance.BorderSize = 0
        Me.BUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUser.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.BUser.ForeColor = System.Drawing.Color.White
        Me.BUser.Location = New System.Drawing.Point(12, 497)
        Me.BUser.Name = "BUser"
        Me.BUser.Size = New System.Drawing.Size(196, 36)
        Me.BUser.TabIndex = 19
        Me.BUser.Text = "Nombre Usuario"
        Me.BUser.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(214, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Click al nombre para salir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 35.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(103, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 56)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Menu Principal"
        '
        'BEmpleados
        '
        Me.BEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BEmpleados.FlatAppearance.BorderSize = 0
        Me.BEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEmpleados.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.75!)
        Me.BEmpleados.ForeColor = System.Drawing.Color.White
        Me.BEmpleados.Location = New System.Drawing.Point(84, 248)
        Me.BEmpleados.Name = "BEmpleados"
        Me.BEmpleados.Size = New System.Drawing.Size(289, 64)
        Me.BEmpleados.TabIndex = 40
        Me.BEmpleados.Text = "BackupDB"
        Me.BEmpleados.UseVisualStyleBackColor = False
        '
        'BProductos
        '
        Me.BProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BProductos.FlatAppearance.BorderSize = 0
        Me.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BProductos.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.75!)
        Me.BProductos.ForeColor = System.Drawing.Color.White
        Me.BProductos.Location = New System.Drawing.Point(84, 178)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(289, 64)
        Me.BProductos.TabIndex = 39
        Me.BProductos.Text = "Captura Datos"
        Me.BProductos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(84, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(289, 64)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Acerca de."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BEmpleados)
        Me.Controls.Add(Me.BProductos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BUser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BEmpleados As Button
    Friend WithEvents BProductos As Button
    Public WithEvents BUser As Button
    Friend WithEvents Button1 As Button
End Class
