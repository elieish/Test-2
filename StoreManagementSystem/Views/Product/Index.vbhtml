@ModelType IEnumerable(Of StoreManagementSystem.ProductModel)

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
            @Html.DisplayNameFor(Function(model) model.ProductDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProductPrice)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.ProductDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.ProductPrice)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.ProductId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.ProductId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.ProductId})
        </td>
    </tr>
Next

</table>
