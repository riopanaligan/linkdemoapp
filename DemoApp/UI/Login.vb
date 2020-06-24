Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Top = (Me.Height - Panel1.Height - 100) / 2
        Panel1.Left = (Me.Width - Panel1.Width - 50) / 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> String.Empty Then
            Dim Homepage As New HomePage
            Homepage.Show()
            Homepage.lblUserHeader.Text = TextBox1.Text
            Me.Hide()
        End If
    End Sub
End Class