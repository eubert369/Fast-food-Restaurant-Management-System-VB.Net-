Public Class masterEntry
    Public indexForm As index
    Public menu As New menuItems
    Public restaurant As New restaurantInfo
    'Public kitchen As New kitchenSection
    Public inventory As New inventoryType
    Public itemCategory As New itemsCategory

    Public Function setParent(_Parent As index)
        indexForm = _Parent
    End Function

    Private Sub menuItems_Button_Click(sender As Object, e As EventArgs) Handles menuItems_Button.Click
        menu.setParent(Me)
        indexForm.childForm(menu)
    End Sub

    Private Sub restaurantInfo_Button_Click(sender As Object, e As EventArgs) Handles restaurantInfo_Button.Click
        restaurant.setParent(Me)
        indexForm.childForm(restaurant)
    End Sub

    Private Sub kitchenSection_Button_Click(sender As Object, e As EventArgs)
        'kitchen.setParent(Me)
        'indexForm.childForm(kitchen)
    End Sub

    Private Sub inventoryType_Button_Click(sender As Object, e As EventArgs) Handles inventoryType_Button.Click
        inventory.setParent(Me)
        indexForm.childForm(inventory)
    End Sub

    Private Sub itemsCategory_Button_Click(sender As Object, e As EventArgs) Handles itemsCategory_Button.Click
        itemCategory.setParent(Me)
        indexForm.childForm(itemCategory)
    End Sub
End Class