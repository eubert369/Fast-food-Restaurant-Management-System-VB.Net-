Imports MySql.Data.MySqlClient
Public Class itemsCategory
    Public masterForm As masterEntry

    Public Function setParent(_Parent As masterEntry)
        masterForm = _Parent
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        masterForm.indexForm.childForm(masterForm)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Date`, `ItemType`, `Description`, `Unit`, `Count`, `UnitPrice`, `Total` FROM `inventory` WHERE `ItemType` = '" & ComboBox1.SelectedItem & "'"
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
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Date`, `ItemType`, `Description`, `Unit`, `Count`, `UnitPrice`, `Total` FROM `inventory` WHERE `ItemType` = '" & ComboBox1.SelectedItem & "'"
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
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                sql = "SELECT `Date`, `ItemType`, `Description`, `Unit`, `Count`, `UnitPrice`, `Total` FROM `inventory` WHERE `ItemType` = '" & ComboBox1.SelectedItem & "'"
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
        End If
    End Sub

    Private Sub itemsCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class