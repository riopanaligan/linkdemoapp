Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class DatabaseUtility

    Public connStr As String = "server=localhost;user id=root;database=test_schema;port=3306;password=4IT@DMIN()nly"
    Public conn As MySqlConnection

    Public Function ConnectMysql() As Boolean
        Try
            conn = New MySqlConnection(connStr)

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.Open()

            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ExecuteNonQuery(ByVal query As String) As Boolean
        Try
            ConnectMysql()

            Dim command As New MySqlCommand(query, conn)
            command.ExecuteNonQuery()
            Return True

            ConnectMysql()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
