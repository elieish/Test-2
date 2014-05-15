@ModelType IEnumerable(Of StoreManagementSystem.BranchModels)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.BranchName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BranchAddress)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.BranchName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.BranchAddress)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.BranchId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.BranchId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.BranchId})|
            @Html.ActionLink("Allocate Products", "ProductAllocation", "BranchProduct", New With {.id = currentItem.BranchId}, vbNull)
  
        </td>
    </tr>
Next

</table>
