Public Class receipt
    Public caller As payForm
    Public print As New formPrinter

    Public Function setParent(_Parent As payForm)
        caller = _Parent
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        caller.billForm.clearText()
        caller.billForm.DataGridView1.Rows.Clear()
    End Sub

    Private Sub resizeDGV()
        'DataGridView1.Height += 22
        DataGridView1.Height = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows.Cast(Of DataGridViewRow).Sum(Function(r) r.Height)
        Label7.Top = DataGridView1.Bottom
        Panel2.Height += 22
        Label8.Top = Label7.Bottom
        Label9.Top = Label7.Bottom
        Label10.Top = Label8.Bottom
        Label11.Top = Label9.Bottom
        Label12.Top = Label10.Bottom
        Label13.Top = Label11.Bottom
        Label14.Top = Label12.Bottom
        Label15.Top = Label13.Bottom
        Label16.Top = Label14.Bottom
        Label17.Top = Label16.Bottom
        Me.Height += 22

        'DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        resizeDGV()
    End Sub
    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        resizeDGV()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel2.Width, Me.Panel2.Height)

        Panel2.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aps As New PageSetupDialog
        aps.Document = PrintDocument1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'DataGridView1.Rows.Add("row", "row", "row")
        print.setParent(Me)
        print.Show()
    End Sub

End Class