
Imports MySql.Data.MySqlClient

Public Class menuItems
    Public masterForm As masterEntry

    Private ItemID As New ArrayList
    Private Description As New ArrayList
    Private Category As New ArrayList
    Private Price As New ArrayList

    'Dim conn As New MySqlConnection("server = localhost; user id = root; password = ; database = fast_food_restaurant;")

    Sub clearArray()
        ItemID.Clear()
        Description.Clear()
        Category.Clear()
        Price.Clear()
    End Sub

    Sub addToArrays()
        For i = 0 To DataGridView1.Rows.Count - 1
            ItemID.Add(DataGridView1.Rows(i).Cells(0).Value)
            Description.Add(DataGridView1.Rows(i).Cells(1).Value)
            Category.Add(DataGridView1.Rows(i).Cells(2).Value)
            Price.Add(DataGridView1.Rows(i).Cells(3).Value)
        Next
    End Sub

    Sub clearText()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox3.Clear()
    End Sub

    Public Function setParent(_Parent As masterEntry)
        masterForm = _Parent
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        masterForm.indexForm.childForm(masterForm)
    End Sub

    Private Sub menuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reload("SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`", DataGridView1)
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            'strConn.Open()

            sql = "SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`"
            cmd.Connection = strConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i).Item("ItemID").ToString, dt.Rows(i).Item("Description").ToString, dt.Rows(i).Item("Category").ToString, dt.Rows(i).Item("Price").ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        'sqlConnection()
        'Dim str As String
        'Str = "SELECT * FROM menu_items"

        'Try
        'If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
        'MessageBox.Show("Please fill all the input", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        'create("INSERT INTO menu_items (ItemID, Description, Category, Price) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.SelectedItem & "', '" & TextBox3.Text & "')")
        'reload("SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`", DataGridView1)
        'End If

        'reload("SELECT * FROM menu_items", DataGridView1)

        'conn.Open()
        'If conn.State = ConnectionState.Open Then
        'MsgBox("Conncted")
        'Else
        'MsgBox("Failed to Connect")
        'End If
        'conn.Close()
        'conn.Open()
        'Dim search As New MySqlDataAdapter(str, conn)
        'Dim ds As New DataSet
        'search.Fill(ds, "menu_items")
        'DataGridView1.DataSource = ds.Tables("menu_items")
        'conn.Close()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, ComboBox1.SelectedItem, TextBox3.Text)
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        clearText()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        'Try
        'If IsNothing(DataGridView1.CurrentRow) Then
        'MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        'Dim result As DialogResult = MessageBox.Show("Confirm?", "Warning", MessageBoxButtons.YesNo)
        'If result = DialogResult.Yes Then
        'updateTable("UPDATE `menu_items` SET `ItemID`='" & TextBox1.Text & "',`Description`='" & TextBox2.Text & "',`Category`='" & ComboBox1.SelectedItem & "',`Price`='" & TextBox3.Text & "' WHERE `ItemID` = " & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "")
        'reload("SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`", DataGridView1)
        'clearText()
        'End If
        'End If

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Confirm?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DataGridView1.CurrentRow.Cells(0).Value = TextBox1.Text
                DataGridView1.CurrentRow.Cells(1).Value = TextBox2.Text
                DataGridView1.CurrentRow.Cells(2).Value = ComboBox1.SelectedItem
                DataGridView1.CurrentRow.Cells(3).Value = TextBox3.Text
            End If
        End If
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        'Try
        'If IsNothing(DataGridView1.CurrentRow) Then
        'MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        'Dim result As DialogResult = MessageBox.Show("Confirm Delete?", "Warning", MessageBoxButtons.YesNo)
        'If result = DialogResult.Yes Then
        'delete("DELETE FROM `menu_items` WHERE `ItemID` = " & DataGridView1.CurrentRow.Cells(0).Value.ToString())
        'reload("SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`", DataGridView1)
        'clearText()
        'End If
        'End If

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
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
        'create("")
        'reload("SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`", DataGridView1)
        Dim result As DialogResult = MessageBox.Show("Save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            clearArray()
            addToArrays()

            Try
                delete("DELETE FROM `menu_items`")

                For i = 0 To DataGridView1.Rows.Count - 1
                    create("INSERT INTO `menu_items`(`ItemID`, `Description`, `Category`, `Price`) VALUES ('" & ItemID(i).ToString & "','" & Description(i).ToString & "','" & Category(i).ToString & "','" & Price(i).ToString & "')")
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
                'strConn.Open()

                sql = "SELECT `ItemID`, `Description`, `Category`, `Price` FROM `menu_items`"
                cmd.Connection = strConn
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView1.Rows.Clear()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView1.Rows.Add(dt.Rows(i).Item("ItemID").ToString, dt.Rows(i).Item("Description").ToString, dt.Rows(i).Item("Category").ToString, dt.Rows(i).Item("Price").ToString)
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

End Class