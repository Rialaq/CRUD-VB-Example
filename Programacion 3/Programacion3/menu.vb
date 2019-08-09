Public Class menu
    Private Sub BUser_Click(sender As Object, e As EventArgs) Handles BUser.Click
        Dim result As Integer = MessageBox.Show("Seguro que desea salir", "Aviso", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim Login As New login()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BProductos_Click(sender As Object, e As EventArgs) Handles BProductos.Click
        Dim productos As New productos
        productos.Show()
    End Sub

    Private Sub BEmpleados_Click(sender As Object, e As EventArgs) Handles BEmpleados.Click
        Dim backup As New Backup
        backup.Show()
    End Sub
End Class