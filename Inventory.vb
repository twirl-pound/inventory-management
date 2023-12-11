' Inventory.vb

Imports System.Collections.Generic

Public Class Inventory
    Private ReadOnly products As List(Of Product)

    Public Sub New()
        Me.products = New List(Of Product)()
    End Sub

    Public Sub AddProduct(product As Product)
        products.Add(product)
    End Sub

    Public Sub DisplayInventory()
        Console.WriteLine("Inventory:")
        For Each product In products
            Console.WriteLine(product.ToString())
        Next
    End Sub
End Class
