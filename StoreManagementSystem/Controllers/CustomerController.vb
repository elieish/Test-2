
Imports System.Data.Entity
Imports StoreManagementSystem.Models
Namespace StoreManagementSystem
    Public Class CustomerController
        Inherits System.Web.Mvc.Controller
         Private db As New StoreManagementContext
        '
        ' GET: /Customer

        Function Index() As ActionResult

            Dim list As New List(Of String)
            Dim Query = From d In db.BranchModels Order By d.BranchId Select d.BranchName
            list.AddRange(Query.Distinct)
            ViewData("branchprods") = New SelectList(list)
            Return View()
        End Function

        Function ViewBranchProducts(ByVal branchprods As String) As ActionResult
            Dim branch As BranchModels = (From profile In db.BranchModels Where profile.BranchName = branchprods).FirstOrDefault()
            Dim branchproducts = From m In db.BranchProductModels Select m
            If String.IsNullOrEmpty(branchprods) Then
                Dim Query = (From p In db.BranchProductModels Join J In db.BranchModels On p.Branchuid Equals J.BranchId Join k In db.ProductModels On p.Productuid Equals k.ProductId
                 Select New ViewModel() With {
                .BranchId = p.Branchuid, .BranchName = J.BranchName, .ProductName = k.ProductDescription, .ProductPrice = k.ProductPrice})
                Return View(Query.ToList())
            Else
                Dim Query = (From p In db.BranchProductModels Join J In db.BranchModels On p.Branchuid Equals J.BranchId Join k In db.ProductModels On p.Productuid Equals k.ProductId
                Where p.Branchuid = branch.BranchId Select New ViewModel() With {
                .BranchId = p.Branchuid, .BranchName = J.BranchName, .ProductName = k.ProductDescription, .ProductPrice = k.ProductPrice})
                Return View(Query.ToList())
            End If

        End Function

        
    End Class
End Namespace