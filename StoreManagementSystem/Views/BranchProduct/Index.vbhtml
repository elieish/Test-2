@ModelType IEnumerable(Of StoreManagementSystem.BranchProductModel)

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
            @Html.DisplayNameFor(Function(model) model.Branchuid)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Productuid)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Branchuid)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Productuid)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.BranchProductId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.BranchProductId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.BranchProductId})
        </td>
    </tr>
Next

</table>
