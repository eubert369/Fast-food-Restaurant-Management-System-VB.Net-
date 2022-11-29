Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form1
    Public formIndex As New index

    Sub clearText()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim user As String = TextBox1.Text
        'Dim pass As String = TextBox2.Text

        'If user = "admin" And pass = "admin" Then
        'formIndex.setParent(Me)
        'formIndex.Show()
        'Me.Hide()
        'clearText()
        'Else
        'MessageBox.Show("Incorrect Username or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'clearText()
        'End If

        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            strConn.Open()

            sql = "SELECT * FROM login WHERE `Username` = '" & TextBox1.Text & "' AND `Password` = '" & TextBox2.Text & "'"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If TextBox1.Text = dt.Rows(0).Item("Username") And TextBox2.Text = dt.Rows(0).Item("Password") Then
                    formIndex.setParent(Me)
                    formIndex.Show()
                    formIndex.slidePanel.Height = formIndex.Button_Dashboard.Height
                    formIndex.slidePanel.Top = formIndex.Button_Dashboard.Top
                    formIndex.Label4.Text = dt.Rows(0).Item("Name")
                    formIndex.childForm(formIndex.dash)
                    Me.Hide()
                    clearText()
                Else
                    MessageBox.Show("Incorrect Username or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    clearText()
                End If
                'TextBox1.Text = dt.Rows(0).Item("Price").ToString
            Else
                MessageBox.Show("Incorrect Username or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sqlConnection()
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "PASSWORD" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "PASSWORD"
            TextBox2.ForeColor = Color.Silver
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "USERNAME" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "USERNAME"
            TextBox1.ForeColor = Color.Silver
        End If
    End Sub
End Class
