Imports MySql.Data.MySqlClient
Public Class reports
    Public indexForm As index

    Public Function setParent(_Parent As index)
        indexForm = _Parent
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            DataGridView2.Hide()
            DataGridView1.Show()
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Date`, `ItemType`, `Description`, `Unit`, `Count`, `UnitPrice`, `Total` FROM `inventory`"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView1.Rows.Clear()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView1.Rows.Add(dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("ItemType").ToString, dt.Rows(i).Item("Description").ToString, dt.Rows(i).Item("Unit").ToString, dt.Rows(i).Item("Count").ToString, dt.Rows(i).Item("UnitPrice").ToString, dt.Rows(i).Item("Total").ToString)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ComboBox1.SelectedIndex = 1 Then
            DataGridView2.Show()
            DataGridView1.Hide()
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Date`, `ItemID`, `Name`, `Description`, `Category`, `Qty`, `Price` FROM `transaction_record`"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView2.Rows.Clear()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView2.Rows.Add(dt.Rows(i).Item("Name").ToString, dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("ItemID").ToString, dt.Rows(i).Item("Description").ToString, dt.Rows(i).Item("Category").ToString, dt.Rows(i).Item("Qty").ToString, dt.Rows(i).Item("Price").ToString)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class