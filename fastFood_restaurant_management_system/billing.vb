Imports MySql.Data.MySqlClient
Public Class billing
    Public indexForm As index
    Public pay As New payForm

    Public currentDate As New ArrayList
    Public itemID As New ArrayList
    'Public name As New List(Of String)
    Public description As New ArrayList
    Public category As New ArrayList
    Public qty As New ArrayList
    Public amount As New ArrayList
    Public Function setParent(_Parent As index)
        indexForm = _Parent
    End Function

    Sub clearText()
        TextBox6.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        TextBox1.Text = "0.00"
        NumericUpDown1.Value = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.SelectedIndex = 0 Then
                'ComboBox2.Items.Add(reload("SELECT `ItemID` FROM menu_items"))
                'ComboBox2.Items.Clear()

                reload("SELECT * FROM menu_items WHERE `Category` = '" & ComboBox1.SelectedItem & "'", ComboBox3)

                ComboBox3.DataSource = dt
                ComboBox3.DisplayMember = "Description"
                ComboBox3.ValueMember = "ItemID"

            ElseIf ComboBox1.SelectedIndex = 1 Then

                reload("SELECT * FROM menu_items WHERE `Category` = '" & ComboBox1.SelectedItem & "'", ComboBox3)

                ComboBox3.DataSource = dt
                ComboBox3.DisplayMember = "Description"
                ComboBox3.ValueMember = "ItemID"

            ElseIf ComboBox1.SelectedIndex = 2 Then

                reload("SELECT * FROM menu_items WHERE `Category` = '" & ComboBox1.SelectedItem & "'", ComboBox3)

                ComboBox3.DataSource = dt
                ComboBox3.DisplayMember = "Description"
                ComboBox3.ValueMember = "ItemID"

            ElseIf ComboBox1.SelectedIndex = 3 Then

                reload("SELECT * FROM menu_items WHERE `Category` = '" & ComboBox1.SelectedItem & "'", ComboBox3)

                ComboBox3.DataSource = dt
                ComboBox3.DisplayMember = "Description"
                ComboBox3.ValueMember = "ItemID"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
        End Try

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            'strConn.Open()

            sql = "SELECT * FROM menu_items WHERE `Description` = '" & ComboBox3.Text & "'"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).Item("Price").ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strConn.Close()
        End Try
    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        If ComboBox3.SelectedIndex = -1 Or NumericUpDown1.Value = 0 Then
            MessageBox.Show("Please fill all the input", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim sql As String
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter
                'strConn.Open()

                sql = "SELECT * FROM menu_items WHERE `Description` = '" & ComboBox3.Text & "'"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    DataGridView1.Rows.Add(indexForm.Label6.Text, dt.Rows(0).Item("ItemID").ToString, dt.Rows(0).Item("Description").ToString, dt.Rows(0).Item("Category"), NumericUpDown1.Value, Format(NumericUpDown1.Value * dt.Rows(0).Item("Price"), "0.00"))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                strConn.Close()
            End Try

            Dim sum As Double
            For i = 0 To DataGridView1.Rows.Count - 1
                sum = sum + DataGridView1.Rows(i).Cells(4).Value * DataGridView1.Rows(i).Cells(5).Value
            Next

            TextBox2.Text = Format(sum, "0.00").ToString()
            TextBox3.Text = Format(sum * 0.05, "0.00").ToString()
            TextBox5.Text = Format(sum * 0.03, "0.00").ToString()
            Dim total As Double = total + TextBox2.Text + TextBox3.Text
            TextBox4.Text = Format(total - TextBox5.Text, "0.00")
        End If

    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        clearText()
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click

        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Confirm delete?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next
            End If
            ComboBox1.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
            TextBox1.Text = "0.00"
            NumericUpDown1.Value = 0
        End If

        Dim sum As Double
        For i = 0 To DataGridView1.Rows.Count - 1
            sum = sum + DataGridView1.Rows(i).Cells(4).Value * DataGridView1.Rows(i).Cells(5).Value
        Next

        TextBox2.Text = Format(sum, "0.00").ToString()
        TextBox3.Text = Format(sum * 0.05, "0.00").ToString()
        TextBox5.Text = Format(sum * 0.03, "0.00").ToString()
        Dim total As Double = total + TextBox2.Text + TextBox3.Text
        TextBox4.Text = Format(total - TextBox5.Text, "0.00")
    End Sub

    Private Sub CashIn_Button_Click(sender As Object, e As EventArgs) Handles CashIn_Button.Click
        'For i = 0 To DataGridView1.Rows.Count - 1
        'create("INSERT INTO `transaction_record`(`Date`, `ItemID`, `Name`, `Description`, `Category`, `Qty`, `Price`) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value.ToString & "','" & DataGridView1.Rows(i).Cells(1).Value.ToString & "','" & TextBox6.Text & "','" & DataGridView1.Rows(i).Cells(2).Value.ToString & "','" & DataGridView1.Rows(i).Cells(3).Value.ToString & "','" & DataGridView1.Rows(i).Cells(4).Value.ToString & "','" & DataGridView1.Rows(i).Cells(5).Value.ToString & "')")
        'Next

        currentDate.Clear()
        itemID.Clear()
        'name.Clear()
        description.Clear()
        category.Clear()
        qty.Clear()
        amount.Clear()

        For i = 0 To DataGridView1.Rows.Count - 1
            currentDate.Add(DataGridView1.Rows(i).Cells(0).Value)
            itemID.Add(DataGridView1.Rows(i).Cells(1).Value)
            'name.Add(TextBox6.Text)
            description.Add(DataGridView1.Rows(i).Cells(2).Value)
            category.Add(DataGridView1.Rows(i).Cells(3).Value)
            qty.Add(DataGridView1.Rows(i).Cells(4).Value)
            amount.Add(DataGridView1.Rows(i).Cells(5).Value)
        Next
        pay.setParent(Me)
        pay.Show()
    End Sub

End Class