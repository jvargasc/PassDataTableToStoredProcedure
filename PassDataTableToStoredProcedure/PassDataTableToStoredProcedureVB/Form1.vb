Imports System.Data.SqlClient

Public Class FormMain
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        TxtCustomer.Text = ""
        DtgClients.DataSource = Nothing

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        GetData()

    End Sub

    Private Sub TxtCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCustomer.KeyDown

        If (e.KeyCode = Keys.Enter) And (TxtCustomer.Text.Trim <> "") Then
            GetData()
        End If

    End Sub

    Private Sub GetData()
        Dim TmpTable As New DataTable
        Dim TmpTableRead As New DataTable
        Dim TmpRow As DataRow

        TmpTable.Columns.Add("CustomerId", GetType(String))
        TmpTable.Columns.Add("CustomerName", GetType(String))

        TmpRow = TmpTable.NewRow()

        TmpRow.Item("CustomerId") = TxtCustomer.Text
        TmpRow.Item("CustomerName") = "Nombre de Prueba"

        TmpTable.Rows.Add(TmpRow)

        Using TmpConnection As New SqlConnection("Data Source=.\sqlexpress01;Initial Catalog=Northwind;Persist Security Info=True;User ID=dbuser;Password=P4$$w0rd")

            TmpConnection.Open()

            Dim TmpSqlCommand As SqlCommand = New SqlCommand("dbo.SP_CustomerList", TmpConnection)
            TmpSqlCommand.CommandType = CommandType.StoredProcedure

            Dim TmpSqlParameter As SqlParameter = TmpSqlCommand.Parameters.AddWithValue("@CustomerList", TmpTable)

            TmpSqlParameter.SqlDbType = SqlDbType.Structured
            'TmpSqlCommand.ExecuteNonQuery()
            Dim TmpSqlDataAdapter As New SqlDataAdapter()

            TmpSqlDataAdapter.SelectCommand = TmpSqlCommand
            TmpSqlDataAdapter.Fill(TmpTableRead)

            If (TmpTableRead.Rows.Count > 0) Then

                DtgClients.DataSource = TmpTableRead
            Else
                MessageBox.Show("Code not found")
                DtgClients.DataSource = Nothing
            End If

        End Using

    End Sub

End Class
