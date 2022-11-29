Imports MySql.Data.MySqlClient
Public Class dashboard
    Public indexForm As index

    Public Function setParent(_Parent As index)
        indexForm = _Parent
    End Function

    Public Sub loadDashboard()
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT * FROM `transaction`"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            Dim total As Integer = dt.Rows.Count
            Label7.Text = dt.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT * FROM `transaction` WHERE `Status` = 'Pending'"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            Dim pending As Integer = dt.Rows.Count
            Label9.Text = pending

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT * FROM `transaction` WHERE `Status` = 'Delivered'"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            Dim Delivered As Integer = dt.Rows.Count
            Label10.Text = Delivered

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT * FROM `transaction` WHERE `Status` = 'Rejected'"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            Dim Rejected As Integer = dt.Rows.Count
            Label11.Text = Rejected

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            sql = "SELECT `AmmountDue` FROM `transaction`"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            Dim sum As Double
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sum += dt.Rows(i).Item("AmmountDue").ToString
                Next

            End If
            Label8.Text = "₱ " & sum
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDashboard()
    End Sub
End Class