Public Class restaurantInfo
    Public masterForm As masterEntry

    Public Function setParent(_Parent As masterEntry)
        masterForm = _Parent
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        masterForm.indexForm.childForm(masterForm)
    End Sub
End Class