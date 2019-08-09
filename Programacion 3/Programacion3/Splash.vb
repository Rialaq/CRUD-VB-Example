Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = Convert.ToInt32(ProgressBar1.Value) + 10
        If ProgressBar1.Value = 80 Then
            Timer1.Stop()
            Dim login As New login
            login.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.Hide()
    End Sub
End Class
