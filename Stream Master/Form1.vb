Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Stream_Master_Player.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
