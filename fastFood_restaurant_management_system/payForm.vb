Public Class payForm
    Public billForm As billing
    Public receiptForm As New receipt

    Public Function setParent(_Parent As billing)
        billForm = _Parent
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub payForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = Format(0.00, "0.00")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Format(0.00, "0.00")
        'receipt.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text < billForm.TextBox4.Text Then
            MessageBox.Show("Insufficient Ammount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = Format(0.00, "0.00")
        Else
            Try
                Dim result As DialogResult = MessageBox.Show("Confirm Transaction?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    receiptForm.setParent(Me)
                    For i = 0 To billForm.DataGridView1.Rows.Count - 1
                        create("INSERT INTO `transaction_record`(`Date`, `ItemID`, `Name`, `Description`, `Category`, `Qty`, `Price`) VALUES ('" & billForm.currentDate(i) & "','" & billForm.itemID(i) & "','" & billForm.TextBox6.Text & "','" & billForm.description(i) & "','" & billForm.category(i) & "','" & billForm.qty(i) & "','" & billForm.amount(i) & "')")
                    Next

                    Dim cash As Double = TextBox1.Text
                    Dim change As Double = cash - billForm.TextBox4.Text
                    Dim sumQty As Integer
                    For i = 0 To billForm.DataGridView1.Rows.Count - 1
                        sumQty += billForm.qty(i)
                    Next
                    create("INSERT INTO `transaction`(`Name`, `Date`, `TotalQTY`, `AmmountDue`, `Cash`, `CashChange`) VALUES ('" & billForm.TextBox6.Text & "','" & billForm.indexForm.Label6.Text & "','" & sumQty & "','" & billForm.TextBox4.Text & "','" & Format(cash, "0.00") & "','" & Format(change, "0.00") & "')")

                    receiptForm.Panel2.Height = 254
                    receiptForm.Height = 331
                    receiptForm.DataGridView1.Rows.Clear()
                    For i = 0 To billForm.DataGridView1.Rows.Count - 1
                        receiptForm.DataGridView1.Rows.Add(billForm.qty(i), billForm.description(i), billForm.amount(i))
                    Next

                    receiptForm.Label9.Text = sumQty
                    receiptForm.Label11.Text = billForm.TextBox4.Text
                    receiptForm.Label13.Text = cash
                    receiptForm.Label15.Text = change

                    receiptForm.Show()
                    Me.Hide()
                    TextBox1.Text = Format(0.00, "0.00")
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class