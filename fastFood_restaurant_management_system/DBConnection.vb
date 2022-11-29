Imports MySql.Data.MySqlClient
Module DBConnection
    Public Function strConnection() As MySqlConnection
        Return New MySqlConnection("server = localhost; user id = root; password = ; database = fast_food_restaurant;")
    End Function
    Public strConn As MySqlConnection = strConnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    'This is for create or insert function
    Public Sub create(ByVal sql As String)
        Try
            strConn.Open()
            With cmd
                .Connection = strConn
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save the data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("Data has been saved in the database", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
        End Try
    End Sub

    'This is for retrieving data in the database
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strConn.Open()
            With cmd
                .Connection = strConn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
            da.Dispose()
        End Try
    End Sub

    'This is for updating data in database
    Public Sub updateTable(ByVal sql As String)
        Try
            strConn.Open()
            With cmd
                .Connection = strConn
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to update the data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been updated succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
        End Try
    End Sub

    'This is for deleting data in database
    Public Sub delete(ByVal sql As String)
        Try
            strConn.Open()
            With cmd
                .Connection = strConn
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to delete the data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("Data has been deleted succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
        End Try
    End Sub

    'Dim con As New MySqlConnection
    'Dim cmd As New MySqlCommand
    'Dim id As Integer

    'Public Sub sqlConnection()
    'con.ConnectionString = "server = localhost; database = fast_food_restaurant; user id = root; password = ;"
    'If con.State = ConnectionState.Open Then
    'con.Close()
    'MessageBox.Show("Failed to Connect Database")
    'End If
    'con.Open()
    'MessageBox.Show("Connected")
    'End Sub

    'Public Sub display_data()
    'cmd = con.CreateCommand()
    'cmd.CommandType = CommandType.Text
    'cmd.CommandText = "SELECT * FROM menu_items"
    'cmd.ExecuteNonQuery()

    'Dim dt As New DataTable
    'Dim da As New MySqlDataAdapter(cmd)
    'da.Fill(dt)
    'End Sub
End Module
