Imports System.ComponentModel

Public Class formPrinter
    Public caller As receipt

    Public Function setParent(_Parent As receipt)
        caller = _Parent
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        TextBox1.Text = PrintDialog1.PrinterSettings.PrinterName
        'My.Settings.Printer = TextBox1.Text
        'My.Settings.Save()
    End Sub

    Private Sub formPrinter_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Printer = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub formPrinter_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = My.Settings.Printer
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        caller.PrintDocument1.PrinterSettings.PrinterName = TextBox1.Text
        caller.PrintDocument1.Print()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class