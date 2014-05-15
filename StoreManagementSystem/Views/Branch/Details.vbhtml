@ModelType StoreManagementSystem.BranchModels

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>BranchModels</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.BranchName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.BranchName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.BranchAddress)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.BranchAddress)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.BranchId}) |
    @Html.ActionLink("Back to List", "Index")
</p>
