Imports MySql.Data.MySqlClient
Public Class inventoryType
    Public masterForm As masterEntry

    Private datePurchased As New ArrayList
    Private itemType As New ArrayList
    Private description As New ArrayList
    Private measure As New ArrayList
    Private count As New ArrayList
    Private unitPrice As New ArrayList
    Private total As New ArrayList

    Public Function setParent(_Parent As masterEntry)
        masterForm = _Parent
    End Function

    Sub addToArray()
        For i = 0 To DataGridView1.Rows.Count - 1
            datePurchased.Add(DataGridView1.Rows(i).Cells(0).Value)
            itemType.Add(DataGridView1.Rows(i).Cells(1).Value)
            description.Add(DataGridView1.Rows(i).Cells(2).Value)
            measure.Add(DataGridView1.Rows(i).Cells(3).Value)
            count.Add(DataGridView1.Rows(i).Cells(4).Value)
            unitPrice.Add(DataGridView1.Rows(i).Cells(5).Value)
            total.Add(DataGridView1.Rows(i).Cells(6).Value)
        Next
    End Sub

    Sub clearArray()
        datePurchased.Clear()
        itemType.Clear()
        description.Clear()
        measure.Clear()
        count.Clear()
        unitPrice.Clear()
        total.Clear()
    End Sub

    Sub clear()
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        NumericUpDown1.Value = 0
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        masterForm.indexForm.childForm(masterForm)
    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Dim count As Double = NumericUpDown1.Value
        Dim unit As Double = TextBox3.Text
        Dim total As Double = count * unit

        DataGridView1.Rows.Add(masterForm.indexForm.Label6.Text, ComboBox1.SelectedItem, TextBox1.Text, TextBox2.Text, NumericUpDown1.Value, TextBox3.Text, Format(total, "0.00"))
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
        NumericUpDown1.Value = DataGridView1.CurrentRow.Cells(4).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Confirm?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DataGridView1.CurrentRow.Cells(1).Value = ComboBox1.SelectedItem
                DataGridView1.CurrentRow.Cells(2).Value = TextBox1.Text
                DataGridView1.CurrentRow.Cells(3).Value = TextBox2.Text
                DataGridView1.CurrentRow.Cells(4).Value = NumericUpDown1.Value
                DataGridView1.CurrentRow.Cells(5).Value = TextBox3.Text
            End If
        End If
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Confirm Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next
            End If
        End If
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Dim result As DialogResult = MessageBox.Show("Save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            clearArray()
            addToArray()

            Try
                delete("DELETE FROM `inventory`")
                For i = 0 To DataGridView1.Rows.Count - 1
                    create("INSERT INTO `inventory`(`Date`, `ItemType`, `Description`, `Unit`, `Count`, `UnitPrice`, `Total`) VALUES ('" & datePurchased(i).ToString & "','" & itemType(i).ToString & "','" & description(i).ToString & "','" & measure(i).ToString & "','" & count(i).ToString & "','" & unitPrice(i).ToString & "','" & total(i).ToString & "')")
                Next
                MessageBox.Show("Succesfully Saved.", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

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

        End If
    End Sub

    Private Sub inventoryType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub
End Class