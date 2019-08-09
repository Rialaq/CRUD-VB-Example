<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
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
        Me.LTema = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FFecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FFamila = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FPRecio = New System.Windows.Forms.MaskedTextBox()
        Me.FDesc = New System.Windows.Forms.TextBox()
        Me.GProductos = New System.Windows.Forms.GroupBox()
        Me.GClientes = New System.Windows.Forms.GroupBox()
        Me.FCedula = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FClientesNom = New System.Windows.Forms.TextBox()
        Me.FNacimientoCli = New System.Windows.Forms.MaskedTextBox()
        Me.FPuntos = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GUsuarios = New System.Windows.Forms.GroupBox()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.FUSuario = New System.Windows.Forms.TextBox()
        Me.FPass = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FNivel = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GSuplidores = New System.Windows.Forms.GroupBox()
        Me.GEmpleado = New System.Windows.Forms.GroupBox()
        Me.FCedulaEMp = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BEmpleado = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FNombreEmp = New System.Windows.Forms.TextBox()
        Me.FNacEMp = New System.Windows.Forms.MaskedTextBox()
        Me.FSueldo = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.FSuplidores = New System.Windows.Forms.TextBox()
        Me.FCargo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RProductos = New System.Windows.Forms.RadioButton()
        Me.REmpleados = New System.Windows.Forms.RadioButton()
        Me.RUsuarios = New System.Windows.Forms.RadioButton()
        Me.RSuplidores = New System.Windows.Forms.RadioButton()
        Me.RClientes = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GProductos.SuspendLayout()
        Me.GClientes.SuspendLayout()
        Me.GUsuarios.SuspendLayout()
        Me.GSuplidores.SuspendLayout()
        Me.GEmpleado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTema
        '
        Me.LTema.AutoSize = True
        Me.LTema.Font = New System.Drawing.Font("Tw Cen MT Condensed", 35.75!)
        Me.LTema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LTema.Location = New System.Drawing.Point(12, 9)
        Me.LTema.Name = "LTema"
        Me.LTema.Size = New System.Drawing.Size(166, 56)
        Me.LTema.TabIndex = 32
        Me.LTema.Text = "Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(381, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(712, 494)
        Me.DataGridView1.TabIndex = 34
        '
        'BProductos
        '
        Me.BProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BProductos.FlatAppearance.BorderSize = 0
        Me.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BProductos.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.BProductos.ForeColor = System.Drawing.Color.White
        Me.BProductos.Location = New System.Drawing.Point(19, 430)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(298, 64)
        Me.BProductos.TabIndex = 44
        Me.BProductos.Text = "Guardar"
        Me.BProductos.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'FFecha
        '
        Me.FFecha.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FFecha.Location = New System.Drawing.Point(171, 386)
        Me.FFecha.Mask = "99/99/9999"
        Me.FFecha.Name = "FFecha"
        Me.FFecha.Size = New System.Drawing.Size(146, 25)
        Me.FFecha.TabIndex = 47
        Me.FFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Familia:"
        '
        'FFamila
        '
        Me.FFamila.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FFamila.FormattingEnabled = True
        Me.FFamila.Location = New System.Drawing.Point(82, 349)
        Me.FFamila.Name = "FFamila"
        Me.FFamila.Size = New System.Drawing.Size(235, 26)
        Me.FFamila.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Descripcion:"
        '
        'FPRecio
        '
        Me.FPRecio.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPRecio.Location = New System.Drawing.Point(75, 313)
        Me.FPRecio.Mask = "9999999"
        Me.FPRecio.Name = "FPRecio"
        Me.FPRecio.Size = New System.Drawing.Size(242, 25)
        Me.FPRecio.TabIndex = 41
        Me.FPRecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDesc
        '
        Me.FDesc.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDesc.Location = New System.Drawing.Point(106, 277)
        Me.FDesc.Name = "FDesc"
        Me.FDesc.Size = New System.Drawing.Size(211, 25)
        Me.FDesc.TabIndex = 40
        Me.FDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GProductos
        '
        Me.GProductos.Controls.Add(Me.BProductos)
        Me.GProductos.Controls.Add(Me.Label5)
        Me.GProductos.Controls.Add(Me.FDesc)
        Me.GProductos.Controls.Add(Me.FFecha)
        Me.GProductos.Controls.Add(Me.FPRecio)
        Me.GProductos.Controls.Add(Me.Label4)
        Me.GProductos.Controls.Add(Me.Label3)
        Me.GProductos.Controls.Add(Me.FFamila)
        Me.GProductos.Controls.Add(Me.Label1)
        Me.GProductos.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.GProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GProductos.Location = New System.Drawing.Point(22, 76)
        Me.GProductos.Name = "GProductos"
        Me.GProductos.Size = New System.Drawing.Size(335, 506)
        Me.GProductos.TabIndex = 36
        Me.GProductos.TabStop = False
        Me.GProductos.Text = "Productos"
        '
        'GClientes
        '
        Me.GClientes.Controls.Add(Me.FCedula)
        Me.GClientes.Controls.Add(Me.Label10)
        Me.GClientes.Controls.Add(Me.BClientes)
        Me.GClientes.Controls.Add(Me.Label6)
        Me.GClientes.Controls.Add(Me.FClientesNom)
        Me.GClientes.Controls.Add(Me.FNacimientoCli)
        Me.GClientes.Controls.Add(Me.FPuntos)
        Me.GClientes.Controls.Add(Me.Label8)
        Me.GClientes.Controls.Add(Me.Label9)
        Me.GClientes.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.GClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GClientes.Location = New System.Drawing.Point(22, 76)
        Me.GClientes.Name = "GClientes"
        Me.GClientes.Size = New System.Drawing.Size(335, 506)
        Me.GClientes.TabIndex = 49
        Me.GClientes.TabStop = False
        Me.GClientes.Text = "Clientes"
        '
        'FCedula
        '
        Me.FCedula.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FCedula.Location = New System.Drawing.Point(75, 349)
        Me.FCedula.Mask = "999-9999999-9"
        Me.FCedula.Name = "FCedula"
        Me.FCedula.Size = New System.Drawing.Size(242, 25)
        Me.FCedula.TabIndex = 51
        Me.FCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(15, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 24)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Cedula"
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.BClientes.ForeColor = System.Drawing.Color.White
        Me.BClientes.Location = New System.Drawing.Point(19, 430)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(298, 64)
        Me.BClientes.TabIndex = 44
        Me.BClientes.Text = "Guardar"
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 24)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'FClientesNom
        '
        Me.FClientesNom.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FClientesNom.Location = New System.Drawing.Point(147, 275)
        Me.FClientesNom.Name = "FClientesNom"
        Me.FClientesNom.Size = New System.Drawing.Size(170, 25)
        Me.FClientesNom.TabIndex = 40
        Me.FClientesNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FNacimientoCli
        '
        Me.FNacimientoCli.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNacimientoCli.Location = New System.Drawing.Point(171, 386)
        Me.FNacimientoCli.Mask = "99/99/9999"
        Me.FNacimientoCli.Name = "FNacimientoCli"
        Me.FNacimientoCli.Size = New System.Drawing.Size(146, 25)
        Me.FNacimientoCli.TabIndex = 47
        Me.FNacimientoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FPuntos
        '
        Me.FPuntos.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPuntos.Location = New System.Drawing.Point(75, 311)
        Me.FPuntos.Mask = "9999999"
        Me.FPuntos.Name = "FPuntos"
        Me.FPuntos.Size = New System.Drawing.Size(242, 25)
        Me.FPuntos.TabIndex = 41
        Me.FPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Nombre Completo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Puntos"
        '
        'GUsuarios
        '
        Me.GUsuarios.Controls.Add(Me.BUsuarios)
        Me.GUsuarios.Controls.Add(Me.FUSuario)
        Me.GUsuarios.Controls.Add(Me.FPass)
        Me.GUsuarios.Controls.Add(Me.Label12)
        Me.GUsuarios.Controls.Add(Me.Label13)
        Me.GUsuarios.Controls.Add(Me.FNivel)
        Me.GUsuarios.Controls.Add(Me.Label14)
        Me.GUsuarios.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.GUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GUsuarios.Location = New System.Drawing.Point(22, 68)
        Me.GUsuarios.Name = "GUsuarios"
        Me.GUsuarios.Size = New System.Drawing.Size(335, 253)
        Me.GUsuarios.TabIndex = 49
        Me.GUsuarios.TabStop = False
        Me.GUsuarios.Text = "Usuarios"
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.BUsuarios.ForeColor = System.Drawing.Color.White
        Me.BUsuarios.Location = New System.Drawing.Point(21, 168)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Size = New System.Drawing.Size(298, 64)
        Me.BUsuarios.TabIndex = 44
        Me.BUsuarios.Text = "Guardar"
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'FUSuario
        '
        Me.FUSuario.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUSuario.Location = New System.Drawing.Point(84, 50)
        Me.FUSuario.Name = "FUSuario"
        Me.FUSuario.Size = New System.Drawing.Size(235, 25)
        Me.FUSuario.TabIndex = 40
        Me.FUSuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FPass
        '
        Me.FPass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPass.Location = New System.Drawing.Point(67, 86)
        Me.FPass.Mask = "9999999"
        Me.FPass.Name = "FPass"
        Me.FPass.Size = New System.Drawing.Size(252, 25)
        Me.FPass.TabIndex = 41
        Me.FPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(17, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 24)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Nivel:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(17, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 24)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Usuario:"
        '
        'FNivel
        '
        Me.FNivel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FNivel.FormattingEnabled = True
        Me.FNivel.Items.AddRange(New Object() {"Desarrollador ", "Secretaria", "Director"})
        Me.FNivel.Location = New System.Drawing.Point(75, 122)
        Me.FNivel.Name = "FNivel"
        Me.FNivel.Size = New System.Drawing.Size(244, 26)
        Me.FNivel.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(17, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 24)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Pass:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(15, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 24)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Nombre:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(19, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(298, 64)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GSuplidores
        '
        Me.GSuplidores.Controls.Add(Me.Button2)
        Me.GSuplidores.Controls.Add(Me.FSuplidores)
        Me.GSuplidores.Controls.Add(Me.Label15)
        Me.GSuplidores.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.GSuplidores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GSuplidores.Location = New System.Drawing.Point(22, 378)
        Me.GSuplidores.Name = "GSuplidores"
        Me.GSuplidores.Size = New System.Drawing.Size(335, 204)
        Me.GSuplidores.TabIndex = 50
        Me.GSuplidores.TabStop = False
        Me.GSuplidores.Text = "Suplidores"
        '
        'GEmpleado
        '
        Me.GEmpleado.Controls.Add(Me.Label21)
        Me.GEmpleado.Controls.Add(Me.FCargo)
        Me.GEmpleado.Controls.Add(Me.FCedulaEMp)
        Me.GEmpleado.Controls.Add(Me.Label17)
        Me.GEmpleado.Controls.Add(Me.BEmpleado)
        Me.GEmpleado.Controls.Add(Me.Label18)
        Me.GEmpleado.Controls.Add(Me.FNombreEmp)
        Me.GEmpleado.Controls.Add(Me.FNacEMp)
        Me.GEmpleado.Controls.Add(Me.FSueldo)
        Me.GEmpleado.Controls.Add(Me.Label19)
        Me.GEmpleado.Controls.Add(Me.Label20)
        Me.GEmpleado.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.GEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GEmpleado.Location = New System.Drawing.Point(22, 76)
        Me.GEmpleado.Name = "GEmpleado"
        Me.GEmpleado.Size = New System.Drawing.Size(335, 506)
        Me.GEmpleado.TabIndex = 52
        Me.GEmpleado.TabStop = False
        Me.GEmpleado.Text = "Empleados"
        '
        'FCedulaEMp
        '
        Me.FCedulaEMp.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FCedulaEMp.Location = New System.Drawing.Point(75, 349)
        Me.FCedulaEMp.Mask = "999-9999999-9"
        Me.FCedulaEMp.Name = "FCedulaEMp"
        Me.FCedulaEMp.Size = New System.Drawing.Size(242, 25)
        Me.FCedulaEMp.TabIndex = 51
        Me.FCedulaEMp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(15, 348)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 24)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Cedula"
        '
        'BEmpleado
        '
        Me.BEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BEmpleado.FlatAppearance.BorderSize = 0
        Me.BEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEmpleado.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!)
        Me.BEmpleado.ForeColor = System.Drawing.Color.White
        Me.BEmpleado.Location = New System.Drawing.Point(19, 430)
        Me.BEmpleado.Name = "BEmpleado"
        Me.BEmpleado.Size = New System.Drawing.Size(298, 64)
        Me.BEmpleado.TabIndex = 44
        Me.BEmpleado.Text = "Guardar"
        Me.BEmpleado.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(15, 386)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 24)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Fecha de Nacimiento"
        '
        'FNombreEmp
        '
        Me.FNombreEmp.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNombreEmp.Location = New System.Drawing.Point(147, 275)
        Me.FNombreEmp.Name = "FNombreEmp"
        Me.FNombreEmp.Size = New System.Drawing.Size(170, 25)
        Me.FNombreEmp.TabIndex = 40
        Me.FNombreEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FNacEMp
        '
        Me.FNacEMp.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNacEMp.Location = New System.Drawing.Point(171, 386)
        Me.FNacEMp.Mask = "99/99/9999"
        Me.FNacEMp.Name = "FNacEMp"
        Me.FNacEMp.Size = New System.Drawing.Size(146, 25)
        Me.FNacEMp.TabIndex = 47
        Me.FNacEMp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FSueldo
        '
        Me.FSueldo.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSueldo.Location = New System.Drawing.Point(75, 311)
        Me.FSueldo.Mask = "9999999"
        Me.FSueldo.Name = "FSueldo"
        Me.FSueldo.Size = New System.Drawing.Size(242, 25)
        Me.FSueldo.TabIndex = 41
        Me.FSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(15, 273)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 24)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Nombre Completo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(15, 309)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 24)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Sueldo"
        '
        'FSuplidores
        '
        Me.FSuplidores.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSuplidores.Location = New System.Drawing.Point(82, 67)
        Me.FSuplidores.Name = "FSuplidores"
        Me.FSuplidores.Size = New System.Drawing.Size(235, 25)
        Me.FSuplidores.TabIndex = 40
        Me.FSuplidores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FCargo
        '
        Me.FCargo.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.FCargo.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FCargo.FormattingEnabled = True
        Me.FCargo.Location = New System.Drawing.Point(73, 238)
        Me.FCargo.Name = "FCargo"
        Me.FCargo.Size = New System.Drawing.Size(244, 26)
        Me.FCargo.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(16, 238)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 24)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Cargo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RSuplidores)
        Me.GroupBox1.Controls.Add(Me.RClientes)
        Me.GroupBox1.Controls.Add(Me.RUsuarios)
        Me.GroupBox1.Controls.Add(Me.REmpleados)
        Me.GroupBox1.Controls.Add(Me.RProductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 588)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 100)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Grupo"
        '
        'RProductos
        '
        Me.RProductos.AutoSize = True
        Me.RProductos.Location = New System.Drawing.Point(42, 43)
        Me.RProductos.Name = "RProductos"
        Me.RProductos.Size = New System.Drawing.Size(92, 28)
        Me.RProductos.TabIndex = 51
        Me.RProductos.TabStop = True
        Me.RProductos.Text = "Productos"
        Me.RProductos.UseVisualStyleBackColor = True
        '
        'REmpleados
        '
        Me.REmpleados.AutoSize = True
        Me.REmpleados.Location = New System.Drawing.Point(162, 43)
        Me.REmpleados.Name = "REmpleados"
        Me.REmpleados.Size = New System.Drawing.Size(98, 28)
        Me.REmpleados.TabIndex = 52
        Me.REmpleados.TabStop = True
        Me.REmpleados.Text = "Empleados"
        Me.REmpleados.UseVisualStyleBackColor = True
        '
        'RUsuarios
        '
        Me.RUsuarios.AutoSize = True
        Me.RUsuarios.Location = New System.Drawing.Point(282, 43)
        Me.RUsuarios.Name = "RUsuarios"
        Me.RUsuarios.Size = New System.Drawing.Size(85, 28)
        Me.RUsuarios.TabIndex = 53
        Me.RUsuarios.TabStop = True
        Me.RUsuarios.Text = "Usuarios"
        Me.RUsuarios.UseVisualStyleBackColor = True
        '
        'RSuplidores
        '
        Me.RSuplidores.AutoSize = True
        Me.RSuplidores.Location = New System.Drawing.Point(522, 43)
        Me.RSuplidores.Name = "RSuplidores"
        Me.RSuplidores.Size = New System.Drawing.Size(96, 28)
        Me.RSuplidores.TabIndex = 55
        Me.RSuplidores.TabStop = True
        Me.RSuplidores.Text = "Suplidores"
        Me.RSuplidores.UseVisualStyleBackColor = True
        '
        'RClientes
        '
        Me.RClientes.AutoSize = True
        Me.RClientes.Location = New System.Drawing.Point(402, 43)
        Me.RClientes.Name = "RClientes"
        Me.RClientes.Size = New System.Drawing.Size(80, 28)
        Me.RClientes.TabIndex = 54
        Me.RClientes.TabStop = True
        Me.RClientes.Text = "Clientes"
        Me.RClientes.UseVisualStyleBackColor = True
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 700)
        Me.Controls.Add(Me.GUsuarios)
        Me.Controls.Add(Me.GSuplidores)
        Me.Controls.Add(Me.GClientes)
        Me.Controls.Add(Me.GEmpleado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GProductos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LTema)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "productos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GProductos.ResumeLayout(False)
        Me.GProductos.PerformLayout()
        Me.GClientes.ResumeLayout(False)
        Me.GClientes.PerformLayout()
        Me.GUsuarios.ResumeLayout(False)
        Me.GUsuarios.PerformLayout()
        Me.GSuplidores.ResumeLayout(False)
        Me.GSuplidores.PerformLayout()
        Me.GEmpleado.ResumeLayout(False)
        Me.GEmpleado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTema As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BProductos As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents FFecha As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FFamila As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FPRecio As MaskedTextBox
    Friend WithEvents FDesc As TextBox
    Friend WithEvents GProductos As GroupBox
    Friend WithEvents GClientes As GroupBox
    Friend WithEvents FCedula As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BClientes As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents FClientesNom As TextBox
    Friend WithEvents FNacimientoCli As MaskedTextBox
    Friend WithEvents FPuntos As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GUsuarios As GroupBox
    Friend WithEvents BUsuarios As Button
    Friend WithEvents FUSuario As TextBox
    Friend WithEvents FPass As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents FNivel As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GSuplidores As GroupBox
    Friend WithEvents GEmpleado As GroupBox
    Friend WithEvents FCedulaEMp As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents BEmpleado As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents FNombreEmp As TextBox
    Friend WithEvents FNacEMp As MaskedTextBox
    Friend WithEvents FSueldo As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents FSuplidores As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents FCargo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RSuplidores As RadioButton
    Friend WithEvents RClientes As RadioButton
    Friend WithEvents RUsuarios As RadioButton
    Friend WithEvents REmpleados As RadioButton
    Friend WithEvents RProductos As RadioButton
End Class
