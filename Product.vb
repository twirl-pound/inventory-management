' Product.vb

Public Class Product
    Public Property ProductId As Integer
    Public Property Name As String
    Public Property Price As Decimal

    Public Sub New(productId As Integer, name As String, price As Decimal)
        Me.ProductId = productId
        Me.Name = name
        Me.Price = price
    End Sub

    Public Overrides Function ToString() As String
        Return $"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}"
    End Function
End Class
