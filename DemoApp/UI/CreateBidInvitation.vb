Public Class CreateBidInvitation
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim Homepage As New HomePage
        Homepage.Show()
        Homepage.lblUserHeader.Text = lblUser.Text
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim company1 As String = String.Empty
            Dim company2 As String = String.Empty
            Dim company3 As String = String.Empty
            Dim company4 As String = String.Empty
            Dim company5 As String = String.Empty

            For Each company As DataGridViewRow In dgvSelectedCompany.Rows
                Select Case company.Index
                    Case 0
                        company1 = company.Cells(0).Value.ToString
                    Case 1
                        company2 = company.Cells(0).Value.ToString
                    Case 2
                        company3 = company.Cells(0).Value.ToString
                    Case 3
                        company4 = company.Cells(0).Value.ToString
                    Case 4
                        company5 = company.Cells(0).Value.ToString
                End Select
            Next


            Dim dbutility As New DatabaseUtility
            Dim query As String = "INSERT INTO BIDINVITATIONS ( BidTitle, 
                                                                BidDueDate, 
                                                                BidDueTime, 
                                                                BidType, 
                                                                BidStatus, 
                                                                BidTransactionFee, 
                                                                ProjectDescription,  
                                                                ItemName, 
                                                                ItemDescription, 
                                                                ItemQuantity, 
                                                                ItemUOM, 
                                                                Company1, 
                                                                Company2, 
                                                                Company3, 
                                                                Company4, 
                                                                Company5,
                                                                User,
                                                                Company ) 
                                                      VALUES (  '" & txtBidTitle.Text & "', 
                                                                '" & dtpDueDate.Value.Date.ToString("yyyy-MM-dd") & "',
                                                                '" & dtpDueTime.Value.ToString("HH:mm:ss") & "',
                                                                '" & cmbBidType.Text & "',
                                                                '" & cmbBidStatus.Text & "',
                                                                " & cmbTransactionFee.Text & ",
                                                                '" & txtDescription.Text & "',
                                                                '" & txtItemName.Text & "',
                                                                '" & txtItemDescription.Text & "',
                                                                " & txtItemQuantity.Text & ",
                                                                '" & txtItemUOM.Text & "',
                                                                '" & company1 & "',
                                                                '" & company2 & "',
                                                                '" & company3 & "',
                                                                '" & company4 & "',
                                                                '" & company5 & "', 
                                                                '" & lblUser.Text & "',
                                                                'Company ABC')"

            dbutility.ExecuteNonQuery(query)
            MessageBox.Show("New Bid Invitation successfully saved and published!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim Homepage As New HomePage
            Homepage.lblUserHeader.Text = lblUser.Text
            Homepage.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Homepage As New HomePage
        Homepage.lblUserHeader.Text = lblUser.Text
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub cmbBidType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBidType.SelectedIndexChanged
        If cmbBidType.Text.Trim = "Public" Then
            Panel9.Visible = False
            Panel10.Visible = False
            Panel11.Location = New Point(2, 1019)
        Else
            Panel9.Visible = True
            Panel10.Visible = True
            Panel11.Location = New Point(2, 1258)
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class