Public Class administration
    Public indexForm As index

    Public Function setParent(_Parent As index)
        _Parent = indexForm
    End Function

    Sub clearText()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT `Name`, `Username`, `Password` FROM `login`", DataGridView1)
    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("Please fill all the input", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                create("INSERT INTO `login`(`Name`, `Username`, `Password`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')")
                MessageBox.Show("Added Succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reload("SELECT `Name`, `Username`, `Password` FROM `login`", DataGridView1)
                clearText()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        clearText()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            If IsNothing(DataGridView1.CurrentRow) Then
                MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Confirm?", "Warning", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    updateTable("UPDATE `login` SET `Name`='" & TextBox1.Text & "',`Username`='" & TextBox2.Text & "',`Password`='" & TextBox3.Text & "' WHERE `Username` = '" & DataGridView1.CurrentRow.Cells(1).Value & "'")
                    reload("SELECT `Name`, `Username`, `Password` FROM `login`", DataGridView1)
                    clearText()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            If IsNothing(DataGridView1.CurrentRow) Then
                MessageBox.Show("No row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Confirm Delete?", "Warning", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    delete("DELETE FROM `login` WHERE `Username` = '" & DataGridView1.CurrentRow.Cells(1).Value & "'")
                    reload("SELECT `Name`, `Username`, `Password` FROM `login`", DataGridView1)
                    clearText()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class