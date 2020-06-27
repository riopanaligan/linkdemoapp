Public Class PurchaseOrderPage

    Private Sub dgvPurchaseOrder_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPurchaseOrder.CellEndEdit
        If dgvPurchaseOrder.CurrentCell.ColumnIndex = 0 Then
            Dim myComboBoxCell As DataGridViewComboBoxCell = DirectCast(dgvPurchaseOrder.Item(dgvPurchaseOrder.CurrentCell.ColumnIndex, dgvPurchaseOrder.CurrentCell.RowIndex), DataGridViewComboBoxCell)
            Dim mText As Double = myComboBoxCell.Value
            dgvPurchaseOrder.CurrentRow.Cells(3).Value = mText
        End If

        If dgvPurchaseOrder.CurrentCell.ColumnIndex = 2 Then
            dgvPurchaseOrder.CurrentRow.Cells(4).Value = dgvPurchaseOrder.CurrentRow.Cells(2).Value * dgvPurchaseOrder.CurrentRow.Cells(3).Value
        End If

        Dim Total As Double = 0
        For Each OrderItem As DataGridViewRow In dgvPurchaseOrder.Rows
            Total += OrderItem.Cells(4).Value
        Next




    End Sub

    Private Sub PurchaseOrderPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try

            Dim Query As String = String.Empty
            Dim DBUtility As New DatabaseUtility
            Dim SupplierList As New DataTable

            Query = "select distinct company from quotations where isbidwinner = 1;"

            SupplierList = DBUtility.ExecuteDataReader(Query)
            cmbBidType.DataSource = SupplierList
            cmbBidType.DisplayMember = "company"
            cmbBidType.ValueMember = "company"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadItemData()
        Try
            Dim Query As String = String.Empty
            Dim DBUtility As New DatabaseUtility
            Dim ItemTable As New DataTable

            Query = "SELECT Item, UnitPrice FROM quotations
                    where IsBidWinner = 1 and Company = '" & cmbBidType.Text & "'"
            ItemTable = DBUtility.ExecuteDataReader(Query)
            Column1.DataSource = ItemTable
            Column1.DisplayMember = "Item"
            Column1.ValueMember = "UnitPrice"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbBidType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBidType.SelectedIndexChanged
        If cmbBidType.SelectedIndex <> -1 Then
            LoadItemData()
        End If
    End Sub

End Class