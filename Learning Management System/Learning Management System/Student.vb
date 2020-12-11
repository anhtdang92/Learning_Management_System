Public Class Student


    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()
        Login.Show()
        Login.txtUsername.Clear()
        Login.txtPassword.Clear()
    End Sub


End Class