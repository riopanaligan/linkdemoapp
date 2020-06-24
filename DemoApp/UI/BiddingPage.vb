Public Class BiddingPage
    Private Sub BiddingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BringToFront()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TabControl1.SelectedIndex = 3
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TabControl1.SelectedIndex = 2
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TabControl1.SelectedIndex = 1
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TabControl1.SelectedIndex = 0
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub lblHomeHeader_Click(sender As Object, e As EventArgs) Handles lblHomeHeader.Click
        Dim Homepage As New HomePage
        Homepage.Show()
        Homepage.lblUserHeader.Text = lblUserHeader.Text
        Me.Close()
    End Sub
End Class