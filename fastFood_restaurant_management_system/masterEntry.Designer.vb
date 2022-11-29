<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class masterEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masterEntry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menuItems_Button = New fastFood_restaurant_management_system.RoundButton()
        Me.itemsCategory_Button = New fastFood_restaurant_management_system.RoundButton()
        Me.inventoryType_Button = New fastFood_restaurant_management_system.RoundButton()
        Me.restaurantInfo_Button = New fastFood_restaurant_management_system.RoundButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Master Entry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Restaurant Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Inventory Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Items Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(431, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Menu Items"
        '
        'menuItems_Button
        '
        Me.menuItems_Button.BackColor = System.Drawing.Color.Red
        Me.menuItems_Button.FlatAppearance.BorderSize = 0
        Me.menuItems_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItems_Button.Image = CType(resources.GetObject("menuItems_Button.Image"), System.Drawing.Image)
        Me.menuItems_Button.Location = New System.Drawing.Point(404, 144)
        Me.menuItems_Button.Name = "menuItems_Button"
        Me.menuItems_Button.Size = New System.Drawing.Size(152, 123)
        Me.menuItems_Button.TabIndex = 14
        Me.menuItems_Button.UseVisualStyleBackColor = False
        '
        'itemsCategory_Button
        '
        Me.itemsCategory_Button.BackColor = System.Drawing.Color.Red
        Me.itemsCategory_Button.FlatAppearance.BorderSize = 0
        Me.itemsCategory_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemsCategory_Button.Image = CType(resources.GetObject("itemsCategory_Button.Image"), System.Drawing.Image)
        Me.itemsCategory_Button.Location = New System.Drawing.Point(411, 319)
        Me.itemsCategory_Button.Name = "itemsCategory_Button"
        Me.itemsCategory_Button.Size = New System.Drawing.Size(145, 122)
        Me.itemsCategory_Button.TabIndex = 13
        Me.itemsCategory_Button.UseVisualStyleBackColor = False
        '
        'inventoryType_Button
        '
        Me.inventoryType_Button.BackColor = System.Drawing.Color.Red
        Me.inventoryType_Button.FlatAppearance.BorderSize = 0
        Me.inventoryType_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventoryType_Button.Image = CType(resources.GetObject("inventoryType_Button.Image"), System.Drawing.Image)
        Me.inventoryType_Button.Location = New System.Drawing.Point(151, 319)
        Me.inventoryType_Button.Name = "inventoryType_Button"
        Me.inventoryType_Button.Size = New System.Drawing.Size(144, 122)
        Me.inventoryType_Button.TabIndex = 12
        Me.inventoryType_Button.UseVisualStyleBackColor = False
        '
        'restaurantInfo_Button
        '
        Me.restaurantInfo_Button.BackColor = System.Drawing.Color.Red
        Me.restaurantInfo_Button.FlatAppearance.BorderSize = 0
        Me.restaurantInfo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.restaurantInfo_Button.Image = CType(resources.GetObject("restaurantInfo_Button.Image"), System.Drawing.Image)
        Me.restaurantInfo_Button.Location = New System.Drawing.Point(151, 146)
        Me.restaurantInfo_Button.Name = "restaurantInfo_Button"
        Me.restaurantInfo_Button.Size = New System.Drawing.Size(144, 121)
        Me.restaurantInfo_Button.TabIndex = 10
        Me.restaurantInfo_Button.UseVisualStyleBackColor = False
        '
        'masterEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 513)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.menuItems_Button)
        Me.Controls.Add(Me.itemsCategory_Button)
        Me.Controls.Add(Me.inventoryType_Button)
        Me.Controls.Add(Me.restaurantInfo_Button)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "masterEntry"
        Me.Text = "masterEntry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents restaurantInfo_Button As RoundButton
    Friend WithEvents inventoryType_Button As RoundButton
    Friend WithEvents itemsCategory_Button As RoundButton
    Friend WithEvents menuItems_Button As RoundButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
