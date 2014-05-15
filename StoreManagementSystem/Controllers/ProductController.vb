Imports System.Data.Entity
Imports StoreManagementSystem.Models

Namespace StoreManagementSystem
    Public Class ProductController
        Inherits System.Web.Mvc.Controller

        Private db As New StoreManagementContext

        '
        ' GET: /Product/

        Function Index() As ActionResult
            Return View(db.ProductModels.ToList())
        End Function

        '
        ' GET: /Product/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim productmodel As ProductModel = db.ProductModels.Find(id)
            If IsNothing(productmodel) Then
                Return HttpNotFound()
            End If
            Return View(productmodel)
        End Function

        '
        ' GET: /Product/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Product/Create

        <HttpPost()> _
        Function Create(ByVal productmodel As ProductModel) As ActionResult
            If ModelState.IsValid Then
                db.ProductModels.Add(productmodel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(productmodel)
        End Function

        '
        ' GET: /Product/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim productmodel As ProductModel = db.ProductModels.Find(id)
            If IsNothing(productmodel) Then
                Return HttpNotFound()
            End If
            Return View(productmodel)
        End Function

        '
        ' POST: /Product/Edit/5

        <HttpPost()> _
        Function Edit(ByVal productmodel As ProductModel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(productmodel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(productmodel)
        End Function

        '
        ' GET: /Product/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim productmodel As ProductModel = db.ProductModels.Find(id)
            If IsNothing(productmodel) Then
                Return HttpNotFound()
            End If
            Return View(productmodel)
        End Function

        '
        ' POST: /Product/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim productmodel As ProductModel = db.ProductModels.Find(id)
            db.ProductModels.Remove(productmodel)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace