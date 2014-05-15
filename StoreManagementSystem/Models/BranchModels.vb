Imports System.ComponentModel.DataAnnotations
Public Class BranchModels
    Private Id As Integer
    Private Name As String
    Private Addr As String


    Public Sub New()
        Id = 0
        Name = ""
        Addr = ""
    End Sub
    <Key()> _
    Public Property BranchId() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value

        End Set
    End Property

    Public Property BranchName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value

        End Set
    End Property


    Public Property BranchAddress() As String
        Get
            Return Addr
        End Get
        Set(ByVal value As String)
            Addr = value

        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal addr As String)
        BranchId = id
        BranchName = name
        BranchAddress = addr

    End Sub

    Public Property BranchList() As List(Of BranchModels)
        Get
            Return b_List
        End Get
        Set(value As List(Of BranchModels))
            b_List = value
        End Set
    End Property
    Private b_List As List(Of BranchModels)
End Class
