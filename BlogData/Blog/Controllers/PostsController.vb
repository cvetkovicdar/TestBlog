Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Blog.Blog

Namespace Controllers
    Public Class PostsController
        Inherits System.Web.Mvc.Controller

        Private db As New BlogDataEntities

        ' GET: Posts
        Function Index() As ActionResult
            Return View(db.Posts.ToList())
        End Function

        ' GET: Posts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim post As Post = db.Posts.Find(id)
            If IsNothing(post) Then
                Return HttpNotFound()
            End If
            Return View(post)
        End Function

        ' GET: Posts/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Posts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Title,Date,Authors")> ByVal post As Post) As ActionResult
            If ModelState.IsValid Then
                db.Posts.Add(post)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(post)
        End Function

        ' GET: Posts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim post As Post = db.Posts.Find(id)
            If IsNothing(post) Then
                Return HttpNotFound()
            End If
            Return View(post)
        End Function

        ' POST: Posts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Title,Date,Authors")> ByVal post As Post) As ActionResult
            If ModelState.IsValid Then
                db.Entry(post).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(post)
        End Function

        ' GET: Posts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim post As Post = db.Posts.Find(id)
            If IsNothing(post) Then
                Return HttpNotFound()
            End If
            Return View(post)
        End Function

        ' POST: Posts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim post As Post = db.Posts.Find(id)
            db.Posts.Remove(post)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
