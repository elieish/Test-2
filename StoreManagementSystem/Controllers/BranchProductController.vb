Imports System.Data.Entity
Imports StoreManagementSystem.Models

Namespace StoreManagementSystem
    Public Class BranchProductController
        Inherits System.Web.Mvc.Controller

        Private db As New StoreManagementContext

        '
        ' GET: /BranchProduct/

        Function Index() As ActionResult

            Return View(db.BranchProductModels.ToList())
        End Function
   

        '
        ' GET: /BranchProduct/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim branchproductmodel As BranchProductModel = db.BranchProductModels.Find(id)
            If IsNothing(branchproductmodel) Then
                Return HttpNotFound()
            End If
            Return View(branchproductmodel)
        End Function

        '
        ' GET: /BranchProduct/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /BranchProduct/Create

        <HttpPost()> _
        Function Create(ByVal branchproductmodel As BranchProductModel) As ActionResult
            If ModelState.IsValid Then
                db.BranchProductModels.Add(branchproductmodel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(branchproductmodel)
        End Function

        '
        ' GET: /BranchProduct/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim branchproductmodel As BranchProductModel = db.BranchProductModels.Find(id)
            If IsNothing(branchproductmodel) Then
                Return HttpNotFound()
            End If
            Return View(branchproductmodel)
        End Function

        '
        ' POST: /BranchProduct/Edit/5

        <HttpPost()> _
        Function Edit(ByVal branchproductmodel As BranchProductModel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(branchproductmodel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(branchproductmodel)
        End Function

        '
        ' GET: /BranchProduct/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim branchproductmodel As BranchProductModel = db.BranchProductModels.Find(id)
            If IsNothing(branchproductmodel) Then
                Return HttpNotFound()
            End If
            Return View(branchproductmodel)
        End Function

        '
        ' POST: /BranchProduct/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim branchproductmodel As BranchProductModel = db.BranchProductModels.Find(id)
            db.BranchProductModels.Remove(branchproductmodel)
            db.SaveChanges()
            Return RedirectToAction("ProductAllocation", New With {.id = branchproductmodel.Branchuid})
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

        Function ProductAllocation() As ActionResult
            ViewBag.products = db.ProductModels.ToList()
            ViewBag.branchproducts = db.BranchProductModels.ToList().Where(Function(x) x.Branchuid = RouteData.Values("id"))
            ViewData("prodID") = RouteData.Values("id")
            Return (View())
        End Function


        Function add_product(ByVal branchproductmodel As BranchProductModel) As ActionResult
            If ModelState.IsValid Then
                db.BranchProductModels.Add(branchproductmodel)
                db.SaveChanges()
                Return RedirectToAction("ProductAllocation", New With {.id = branchproductmodel.Branchuid})
            End If

            Return View(branchproductmodel)
        End Function


    End Class
End Namespace