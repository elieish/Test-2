Public Class ViewModel


    Public Property BranchId() As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Private Id As Integer

    Public Property BranchName() As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property
    Private Name As String

    Public Property ProductName() As String
        Get
            Return prodName
        End Get
        Set(value As String)
            prodName = value
        End Set
    End Property
    Private prodName As String


    Public Property ProductPrice() As Decimal
        Get
            Return price
        End Get
        Set(value As Decimal)
            price = value
        End Set
    End Property
    Private price As Decimal
End Class



