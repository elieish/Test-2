
Imports System.ComponentModel.DataAnnotations
Public Class ProductModel
    Private Id As Integer
    Private Description As String
    Private Price As Decimal


    Public Sub New()
        Id = 0
        Description = ""
        Price = 0
    End Sub
    <Key()> _
    Public Property ProductId() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value

        End Set
    End Property

    Public Property ProductDescription() As String
        Get
            Return Description
        End Get
        Set(ByVal value As String)
            Description = value

        End Set
    End Property

    Public Property ProductPrice() As Decimal
        Get
            Return Price
        End Get
        Set(ByVal value As Decimal)
            Price = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal description As String, ByVal price As Decimal)
        ProductId = id
        ProductDescription = description
        ProductPrice = price

    End Sub


End Class
