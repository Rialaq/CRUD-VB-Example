Imports System.Data.SqlClient

Public Class Backup
    Dim conexion = New SqlConnection("server=DESKTOP-6LOGA0K;database=warehouse;integrated security = true")

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BEmpleados_Click(sender As Object, e As EventArgs) Handles BEmpleados.Click
        conexion.Open()
        SaveFileDialog1.FileName = DateAndTime.DateString + "BackupDB"
        SaveFileDialog1.Filter = "Sql Server database backup files | *.bak"
        SaveFileDialog1.ShowDialog()
        Dim cmd As New SqlCommand("BACKUP DATABASE warehouse TO DISK = '" & SaveFileDialog1.FileName & "' ", conexion)
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class