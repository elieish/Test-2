
@ModelType IEnumerable(Of StoreManagementSystem.ViewModel)
@Code
    ViewData("Title") = "List of Products by Branch"
End Code
<table>
<tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.BranchId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BranchName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProductName)
        </th>
          <th>
            @Html.DisplayNameFor(Function(model) model.ProductPrice)
        </th>     
        
    </tr>
<h2>ViewBranchProducts</h2>
@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.BranchId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.BranchName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.ProductName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.ProductPrice)
        </td>
       
    </tr>
Next
    
</table>
<div>
    @Html.ActionLink("Back to List", "Index")
</div>