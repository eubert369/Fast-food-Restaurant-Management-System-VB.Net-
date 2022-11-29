Imports MySql.Data.MySqlClient
Public Class records
    Public indexForm As index

    Public Function setParent(_Parent As index)
        indexForm = _Parent
    End Function
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Search Transactions Here..." Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Search Transactions Here..."
            TextBox1.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Search Transactions Here..." Then
            MessageBox.Show("No Searches Entered", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DataGridView1.Show()
            Try
                'reload("SELECT `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange` FROM `transaction` WHERE `Name` LIKE '" & TextBox1.Text & "' OR `Date` LIKE '" & TextBox1.Text & "' OR `TotalQTY` LIKE '" & TextBox1.Text & "' OR `AmmountDue` LIKE '" & TextBox1.Text & "' OR `Cash` LIKE '" & TextBox1.Text & "' OR `CashChange` LIKE '" & TextBox1.Text & "'", DataGridView1)
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange` FROM `transaction` WHERE `Name` LIKE '%" & TextBox1.Text & "%' OR `Date` LIKE '%" & TextBox1.Text & "%' OR `TotalQTY` LIKE '%" & TextBox1.Text & "%' OR `AmmountDue` LIKE '%" & TextBox1.Text & "%' OR `Cash` LIKE '%" & TextBox1.Text & "%' OR `CashChange` LIKE '%" & TextBox1.Text & "%'"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView1.Rows.Clear()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView1.Rows.Add(dt.Rows(i).Item("Name").ToString, dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("TotalQTY").ToString, dt.Rows(i).Item("AmmountDue").ToString, dt.Rows(i).Item("Cash").ToString, dt.Rows(i).Item("CashChange").ToString)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            DataGridView2.Hide()
        End If
    End Sub

    Private Sub records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.Hide()
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange` FROM `transaction`"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i).Item("Name").ToString, dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("TotalQTY").ToString, dt.Rows(i).Item("AmmountDue").ToString, dt.Rows(i).Item("Cash").ToString, dt.Rows(i).Item("CashChange").ToString)
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView2.Hide()
        DataGridView1.Show()
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange` FROM `transaction`"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i).Item("Name").ToString, dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("TotalQTY").ToString, dt.Rows(i).Item("AmmountDue").ToString, dt.Rows(i).Item("Cash").ToString, dt.Rows(i).Item("CashChange").ToString)
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        DataGridView1.Hide()
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT `Date`, `ItemID`, `Name`, `Description`, `Category`, `Qty`, `Price` FROM `transaction_record` WHERE `Name` = '" & DataGridView1.CurrentRow.Cells(0).Value & "' AND `Date` = '" & DataGridView1.CurrentRow.Cells(1).Value & "'"
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
        DataGridView2.Show()
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            updateTable("UPDATE `transaction` SET `Status`='Delivered' WHERE `Name` = '" & DataGridView1.CurrentRow.Cells(0).Value & "' AND `Date` = '" & DataGridView1.CurrentRow.Cells(1).Value & "'")
            DataGridView2.Hide()
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange` FROM `transaction`"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView1.Rows.Clear()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView1.Rows.Add(dt.Rows(i).Item("Name").ToString, dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("TotalQTY").ToString, dt.Rows(i).Item("AmmountDue").ToString, dt.Rows(i).Item("Cash").ToString, dt.Rows(i).Item("CashChange").ToString)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            DataGridView1.Show()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            updateTable("UPDATE `transaction` SET `Status`='Rejected' WHERE `Name` = '" & DataGridView1.CurrentRow.Cells(0).Value & "' AND `Date` = '" & DataGridView1.CurrentRow.Cells(1).Value & "'")
            DataGridView2.Hide()
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange` FROM `transaction`"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView1.Rows.Clear()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView1.Rows.Add(dt.Rows(i).Item("Name").ToString, dt.Rows(i).Item("Date").ToString, dt.Rows(i).Item("TotalQTY").ToString, dt.Rows(i).Item("AmmountDue").ToString, dt.Rows(i).Item("Cash").ToString, dt.Rows(i).Item("CashChange").ToString)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            DataGridView1.Show()
        End If

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT * FROM `transaction` WHERE `Name` = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("Status").ToString = "Delivered" Then
                        Button3.Enabled = True
                        Button4.Enabled = False
                    ElseIf dt.Rows(i).Item("Status").ToString = "Rejected" Then
                        Button3.Enabled = False
                        Button4.Enabled = True
                    Else
                        Button3.Enabled = True
                        Button4.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
'SELECT `Date`, `ItemID`, `Name`, `Description`, `Category`, `Qty`, `Price` FROM `transaction_record` WHERE `Date` = '' OR `Name` = ''