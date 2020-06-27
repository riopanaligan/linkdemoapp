Public Class HomePage

    Private Sub lblBiddingHeader_MouseEnter(sender As Object, e As EventArgs) Handles lblBiddingHeader.MouseEnter, lblCreateBidInvitation.MouseEnter, lblBidInvitations.MouseEnter, lblClosedBids.MouseEnter, lblOpenBids.MouseEnter
        panelBidding.Visible = True
        panelProcure.Visible = False
    End Sub

    Private Sub lblProcureHeader_MouseEnter(sender As Object, e As EventArgs) Handles lblProcureHeader.MouseEnter
        panelProcure.Visible = True
        panelBidding.Visible = False
    End Sub

    Private Sub lblCreateBidInvitation_Click(sender As Object, e As EventArgs) Handles lblCreateBidInvitation.Click
        Dim createBidInvitationForm As New CreateBidInvitation
        createBidInvitationForm.Show()
        createBidInvitationForm.lblUser.Text = lblUserHeader.Text
        Me.Hide()
    End Sub

    Private Sub lblOpenBids_Click(sender As Object, e As EventArgs) Handles lblOpenBids.Click
        Dim biddingpage As New BiddingPage
        biddingpage.lblUserHeader.Text = lblUserHeader.Text
        biddingpage.Show()
        biddingpage.TabControl1.SelectedIndex = 0
        biddingpage.PictureBox1.Visible = True
        Me.Close()
    End Sub

    Private Sub lblClosedBids_Click(sender As Object, e As EventArgs) Handles lblClosedBids.Click
        Dim biddingpage As New BiddingPage
        biddingpage.lblUserHeader.Text = lblUserHeader.Text
        biddingpage.Show()
        biddingpage.TabControl1.SelectedIndex = 1
        biddingpage.PictureBox2.Visible = True
        Me.Close()
    End Sub

    Private Sub lblBidInvitations_Click(sender As Object, e As EventArgs) Handles lblBidInvitations.Click
        Dim biddingpage As New BiddingPage
        biddingpage.lblUserHeader.Text = lblUserHeader.Text
        biddingpage.Show()
        biddingpage.TabControl1.SelectedIndex = 2
        biddingpage.PictureBox3.Visible = True
        Me.Close()
    End Sub

    Private Sub lblBidEvaluation_Click(sender As Object, e As EventArgs) Handles lblBidEvaluation.Click
        Dim biddingpage As New BiddingPage
        biddingpage.lblUserHeader.Text = lblUserHeader.Text
        biddingpage.Show()
        biddingpage.TabControl1.SelectedIndex = 3
        biddingpage.PictureBox4.Visible = True
        Me.Close()
    End Sub

    Private Sub lblPurchaseOrder_Click(sender As Object, e As EventArgs) Handles lblPurchaseOrder.Click
        PurchaseOrderPage.lblUserHeader.Text = lblUserHeader.Text
        PurchaseOrderPage.Show()
    End Sub

End Class