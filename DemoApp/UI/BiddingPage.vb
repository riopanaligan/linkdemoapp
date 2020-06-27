Public Class BiddingPage
    Private Sub BiddingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Panel2.BringToFront()
    End Sub

    Private Sub LoadData()
        Try
            Dim DbUtility As New DatabaseUtility
            Dim OpenBidTable As New DataTable
            Dim ClosedBidTable As New DataTable
            Dim BidInvitationTable As New DataTable
            Dim BidEvaluationTable As New DataTable

            Dim Query As String = String.Empty

            Query = "select CONCAT(""IB_"",  lpad(idBidInvitations,5,'0')) as ReferenceNo,
                        BidTitle,
                        User, 
                        DATE_FORMAT(DateCreated,'%Y-%m-%d') as DateCreated,
                        DATE_FORMAT(BidDueDate,'%Y-%m-%d') as ClosingDate, 
                        BidType as InvitationType 
                    from bidinvitations
                    where BidStatus = 'Open'
                        and User = '" & lblUserHeader.Text & "' "
            OpenBidTable = DbUtility.ExecuteDataReader(Query)

            dgvOpenBids.Rows.Clear()
            For Each OpenBidData As DataRow In OpenBidTable.Rows
                dgvOpenBids.Rows.Add(OpenBidData("ReferenceNo").ToString,
                                     OpenBidData("BidTitle").ToString,
                                     OpenBidData("User").ToString,
                                     OpenBidData("DateCreated").ToString,
                                     OpenBidData("ClosingDate").ToString,
                                     OpenBidData("InvitationType").ToString,
                                     0,
                                     "Cancel")
            Next

            Query = "select CONCAT(""IB_"",  lpad(idBidInvitations,5,'0')) as ReferenceNo,
                        BidTitle,
                        User, 
                        DATE_FORMAT(DateCreated,'%Y-%m-%d') as DateCreated,
                        DATE_FORMAT(BidDueDate,'%Y-%m-%d') as ClosingDate, 
                        BidStatus as Status,
                        '' as BidWinner
                    from bidinvitations 
                    where BidStatus <> 'Open'
                        and User = '" & lblUserHeader.Text & "' "
            ClosedBidTable = DbUtility.ExecuteDataReader(Query)
            dgvClosedBids.Rows.Clear()
            For Each ClosedBidData As DataRow In ClosedBidTable.Rows
                dgvClosedBids.Rows.Add(ClosedBidData("ReferenceNo").ToString,
                                       ClosedBidData("BidTitle").ToString,
                                       ClosedBidData("User").ToString,
                                       ClosedBidData("DateCreated").ToString,
                                       ClosedBidData("ClosingDate").ToString,
                                       ClosedBidData("Status").ToString,
                                       ClosedBidData("BidWinner").ToString)
            Next

            Query = "select CONCAT(""IB_"",  lpad(idBidInvitations,5,'0')) as ReferenceNo,
                        BidTitle,
                        User, 
                        UserCompany, 
                        DATE_FORMAT(DateCreated,'%Y-%m-%d') as DateCreated,
                        DATE_FORMAT(BidDueDate,'%Y-%m-%d') as ClosingDate, 
                        BidType
                    from bidinvitations 
                    where BidStatus = 'Open'
                        and User <> '" & lblUserHeader.Text & "'"
            BidInvitationTable = DbUtility.ExecuteDataReader(Query)
            dgvBidInvitations.Rows.Clear()
            For Each BidInvitationData As DataRow In BidInvitationTable.Rows
                dgvBidInvitations.Rows.Add(BidInvitationData("ReferenceNo").ToString,
                                       BidInvitationData("BidTitle").ToString,
                                       BidInvitationData("User").ToString,
                                       BidInvitationData("UserCompany").ToString,
                                       BidInvitationData("DateCreated").ToString,
                                       BidInvitationData("ClosingDate").ToString,
                                       BidInvitationData("BidType").ToString)
            Next

            Query = "SELECT CONCAT(""IB_"",  lpad(A.idBidInvitations,5,'0')) as InvitationNo,
	                    BidTitle, 
                        DATE_FORMAT(a.DateCreated,'%Y-%m-%d') as DateCreated,
	                    DATE_FORMAT(a.BidDueDate,'%Y-%m-%d') as ClosingDate, 
                        CONCAT(""QT_"",  lpad(b.idquotations ,5,'0')) as QuotationNo,
                        b.Company, 
                        b.User,
                        Rating
                    FROM bidinvitations A inner JOIN QUOTATIONS B ON (A.idbidinvitations = b.idbidinvitations)
                    where BidStatus = 'Open'
                        and a.User = '" & lblUserHeader.Text & "'"
            BidEvaluationTable = DbUtility.ExecuteDataReader(Query)
            dgvBidEvaluation.Rows.Clear()
            For Each BidEvaluationData As DataRow In BidEvaluationTable.Rows
                dgvBidEvaluation.Rows.Add(False,
                                          BidEvaluationData("InvitationNo").ToString,
                                          BidEvaluationData("BidTitle").ToString,
                                          BidEvaluationData("DateCreated").ToString,
                                          BidEvaluationData("ClosingDate").ToString,
                                          BidEvaluationData("QuotationNo").ToString,
                                          BidEvaluationData("Company").ToString,
                                          BidEvaluationData("User").ToString)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TabControl1.SelectedIndex = 3
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        LoadData()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TabControl1.SelectedIndex = 2
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        LoadData()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TabControl1.SelectedIndex = 1
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        LoadData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TabControl1.SelectedIndex = 0
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        LoadData()
    End Sub

    Private Sub lblHomeHeader_Click(sender As Object, e As EventArgs) Handles lblHomeHeader.Click
        Dim Homepage As New HomePage
        Homepage.Show()
        Homepage.lblUserHeader.Text = lblUserHeader.Text
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim createBidInvitationForm As New CreateBidInvitation
        createBidInvitationForm.Show()
        createBidInvitationForm.lblUser.Text = lblUserHeader.Text
        Me.Close()
    End Sub

    Private Sub dgvBidEvaluation_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvBidEvaluation.DataError
        e.Cancel = True
    End Sub

    Private Sub dgvBidEvaluation_DoubleClick(sender As Object, e As EventArgs) Handles dgvBidEvaluation.DoubleClick
        If dgvBidEvaluation.Rows.Count > 0 Then
            QuotationDetails.ShowDialog()
        End If
    End Sub
End Class