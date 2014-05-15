@ModelType StoreManagementSystem.BranchProductModel

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>BranchProductModel</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Branchuid)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Branchuid)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Productuid)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Productuid)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.BranchProductId}) |
    @Html.ActionLink("Back to List", "Index")
</p>
