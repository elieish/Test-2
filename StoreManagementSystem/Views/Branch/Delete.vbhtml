@ModelType StoreManagementSystem.BranchModels

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
