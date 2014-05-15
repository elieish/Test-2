Imports System.Data.Entity
Imports StoreManagementSystem.Models

Namespace StoreManagementSystem
    Public Class BranchController
        Inherits System.Web.Mvc.Controller

        Private db As New StoreManagementContext

        '
        ' GET: /Branch/

        Function Index() As ActionResult
            Return View(db.BranchModels.ToList())
        End Function

        '
        ' GET: /Branch/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim branchmodels As BranchModels = db.BranchModels.Find(id)
            If IsNothing(branchmodels) Then
                Return HttpNotFound()
            End If
            Return View(branchmodels)
        End Function

        '
        ' GET: /Branch/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Branch/Create

        <HttpPost()> _
        Function Create(ByVal branchmodels As BranchModels) As ActionResult
            If ModelState.IsValid Then
                db.BranchModels.Add(branchmodels)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(branchmodels)
        End Function

        '
        ' GET: /Branch/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim branchmodels As BranchModels = db.BranchModels.Find(id)
            If IsNothing(branchmodels) Then
                Return HttpNotFound()
            End If
            Return View(branchmodels)
        End Function

        '
        ' POST: /Branch/Edit/5

        <HttpPost()> _
        Function Edit(ByVal branchmodels As BranchModels) As ActionResult
            If ModelState.IsValid Then
                db.Entry(branchmodels).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(branchmodels)
        End Function

        '
        ' GET: /Branch/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim branchmodels As BranchModels = db.BranchModels.Find(id)
            If IsNothing(branchmodels) Then
                Return HttpNotFound()
            End If
            Return View(branchmodels)
        End Function

        '
        ' POST: /Branch/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim branchmodels As BranchModels = db.BranchModels.Find(id)
            db.BranchModels.Remove(branchmodels)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace