Imports System.Data.SqlClient

Public Class login

    Dim conexion = New SqlConnection("server=DESKTOP-6LOGA0K;database=warehouse;integrated security = true")

    Private Sub TestDB_Click(sender As Object, e As EventArgs) Handles TestDB.Click
        conexion.Open()
        MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos")
        conexion.Close()
        MessageBox.Show("Se cerró la conexión.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Open()
        Dim cmd As New SqlCommand("select * from usuarios where usuario = @user and pass = @pass", conexion)
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = FUser.Text
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = FPass.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Porfavor Revise sus Credenciales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexion.Close()
        Else
            conexion.Close()
            Dim menu As New menu()
            menu.BUser.Text = FUser.Text
            menu.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class