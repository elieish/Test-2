Imports System.ComponentModel.DataAnnotations
Public Class BranchProductModel

    Private Id As Integer
    Private BranchId As Integer
    Private ProductId As Integer


    Public Sub New()
        Id = 0
        BranchId = 0
        ProductId = 0
    End Sub
    <Key()> _
    Public Property BranchProductId() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value

        End Set
    End Property

    Public Property Branchuid() As Integer
        Get
            Return BranchId
        End Get
        Set(ByVal value As Integer)
            BranchId = value

        End Set
    End Property

    Public Property Productuid() As Integer
        Get
            Return ProductId
        End Get
        Set(ByVal value As Integer)
            ProductId = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal bid As Integer, ByVal pid As Integer)
        BranchProductId = id
        Branchuid = bid
        Productuid = pid

    End Sub


End Class
