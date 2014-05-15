Imports System.Data.Entity
Namespace Models
    Public Class StoreManagementContext
        Inherits DbContext
        ' You can add custom code to this file. Changes will not be overwritten.
        ' 
        ' If you want Entity Framework to drop and regenerate your database
        ' automatically whenever you change your model schema, add the following
        ' code to the Application_Start method in your Global.asax file.
        ' Note: this will destroy and re-create your database with every model change.
        ' 
        ' System.Data.Entity.Database.SetInitializer(New System.Data.Entity.DropCreateDatabaseIfModelChanges(Of Models.StoreManagementContext)())

        Public Sub New()
            MyBase.New("name=StoreManagementContext")
        End Sub

        Public Property BranchModels As DbSet(Of BranchModels)
        Public Property ProductModels As DbSet(Of ProductModel)

        Public Property BranchProductModels As DbSet(Of BranchProductModel)
    End Class


End Namespace


