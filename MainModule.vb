' MainModule.vb

Module MainModule
    Sub Main()
        ' Create products
        Dim product1 As New Product(1, "Laptop", 999.99)
        Dim product2 As New Product(2, "Smartphone", 599.99)

        ' Create inventory
        Dim inventory As New Inventory()

        ' Add products to inventory
        inventory.AddProduct(product1)
        inventory.AddProduct(product2)

        ' Display inventory
        inventory.DisplayInventory()
    End Sub
End Module
