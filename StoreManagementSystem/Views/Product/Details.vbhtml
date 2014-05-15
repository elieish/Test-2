@ModelType StoreManagementSystem.ProductModel

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>ProductModel</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ProductDescription)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.ProductDescription)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ProductPrice)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.ProductPrice)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.ProductId}) |
    @Html.ActionLink("Back to List", "Index")
</p>
