Imports System.Data.SqlClient

Public Class productos
    Dim conexion = New SqlConnection("server=DESKTOP-6LOGA0K;database=warehouse;integrated security = true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BProductos.Click
        conexion.Open()
        Dim cmd As New SqlCommand("insert into items(descripcion, precio, familia, fecha_vencimiento) values (@desc, @precio, @familia, @fecha)", conexion)
        'insert into items(descripcion, precio, familia, fecha_vencimiento) values (@desc, precio, @familia, @fecha)

        cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = FDesc.Text
        cmd.Parameters.Add("@precio", SqlDbType.Int).Value = FPRecio.Text
        cmd.Parameters.Add("@familia", SqlDbType.VarChar).Value = FFamila.Text
        cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = FFecha.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim var As Integer = cmd.ExecuteNonQuery
        If var > 0 Then
            MessageBox.Show("Se ha Guardado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.Close()
            LoadData()

        Else
            'MessageBox.Show("Error al Guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
        End If
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadData()
        GProductos.Hide()
        GUsuarios.Hide()
        GClientes.Hide()
        GSuplidores.Hide()
        GEmpleado.Hide()
        LTema.Text = "Escoja un Grupo"
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        conexion.Open()
        Dim cmd As New SqlCommand("insert into clientes(nombre_completo, cedula, fecha_nacimiento, puntos) values (@nombre, @cedula, @fecha, @puntos)", conexion)
        'insert into items(descripcion, precio, familia, fecha_vencimiento) values (@desc, precio, @familia, @fecha)

        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = FClientesNom.Text
        cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = FCedula.Text
        cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = FNacimientoCli.Text
        cmd.Parameters.Add("@puntos", SqlDbType.Int).Value = FPuntos.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim var As Integer = cmd.ExecuteNonQuery
        If var > 0 Then
            MessageBox.Show("Se ha Guardado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.Close()
            LoadData()
        Else
            'MessageBox.Show("Error al Guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
        End If
    End Sub

    Private Sub LoadData()
        Dim grupo As String
        DataGridView1.RowHeadersVisible = False
        Dim ElDataTable As DataTable = New DataTable
        Dim ElReader As SqlDataReader
        Dim ElComando As SqlCommand
        grupo = LTema.Text

        Try
            conexion.Open()

            ElComando = New SqlCommand("select * from " + grupo, conexion)
            ElReader = ElComando.ExecuteReader()

            ElDataTable.Load(ElReader)

            DataGridView1.DataSource = ElDataTable

            conexion.Close()

        Catch ex As Exception
            conexion.Close()
            MsgBox("Error al cargar el DataGridView.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        conexion.Open()
        Dim cmd As New SqlCommand("insert into usuarios(usuario, pass, nivel) values (@user, @pass, @level)", conexion)
        'insert into items(descripcion, precio, familia, fecha_vencimiento) values (@desc, precio, @familia, @fecha)

        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = FUSuario.Text
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = FPass.Text
        cmd.Parameters.Add("@level", SqlDbType.VarChar).Value = FNivel.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim var As Integer = cmd.ExecuteNonQuery
        If var > 0 Then
            MessageBox.Show("Se ha Guardado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.Close()
            LoadData()
        Else
            'MessageBox.Show("Error al Guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion.Open()
        Dim cmd As New SqlCommand("insert into suplidores(nombre) values (@user)", conexion)
        'insert into items(descripcion, precio, familia, fecha_vencimiento) values (@desc, precio, @familia, @fecha)

        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = FSuplidores.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim var As Integer = cmd.ExecuteNonQuery
        If var > 0 Then
            MessageBox.Show("Se ha Guardado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.Close()
            LoadData()
        Else
            'MessageBox.Show("Error al Guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BEmpleado.Click
        conexion.Open()
        Dim cmd As New SqlCommand("insert into empleados(nombre_completo, cedula, fecha_nacimiento, cargo, sueldo) values (@nombre, @cedula, @fecha, @cargo, @sueldo)", conexion)
        'insert into items(descripcion, precio, familia, fecha_vencimiento) values (@desc, precio, @familia, @fecha)

        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = FNombreEmp.Text
        cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = FCedulaEMp.Text
        cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = FNacEMp.Text
        cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = FCargo.Text
        cmd.Parameters.Add("@sueldo", SqlDbType.Int).Value = FSueldo.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim var As Integer = cmd.ExecuteNonQuery
        If var > 0 Then
            MessageBox.Show("Se ha Guardado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.Close()
            LoadData()
        Else
            'MessageBox.Show("Error al Guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RProductos.CheckedChanged
        If RProductos.Checked = True Then
            GProductos.Show()
            GUsuarios.Hide()
            GClientes.Hide()
            GSuplidores.Hide()
            GEmpleado.Hide()
            LTema.Text = "Items"
            LoadData()
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RSuplidores.CheckedChanged
        If RSuplidores.Checked = True Then
            GProductos.Hide()
            GUsuarios.Hide()
            GClientes.Hide()
            GSuplidores.Show()
            GEmpleado.Hide()
            LTema.Text = "Suplidores"
            LoadData()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles REmpleados.CheckedChanged
        If REmpleados.Checked = True Then
            GEmpleado.Show()
            GProductos.Hide()
            GUsuarios.Hide()
            GClientes.Hide()
            GSuplidores.Hide()
            LTema.Text = "Empleados"
            LoadData()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RUsuarios.CheckedChanged
        If RUsuarios.Checked = True Then
            GProductos.Hide()
            GUsuarios.Show()
            GClientes.Hide()
            GSuplidores.Hide()
            GEmpleado.Hide()
            LTema.Text = "Usuarios"
            LoadData()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RClientes.CheckedChanged
        If RClientes.Checked = True Then
            GProductos.Hide()
            GUsuarios.Hide()
            GClientes.Show()
            GSuplidores.Hide()
            GEmpleado.Hide()
            LTema.Text = "Clientes"
            LoadData()
        End If
    End Sub
End Class