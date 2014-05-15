@ModelType StoreManagementSystem.BranchModels

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>BranchModels</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.BranchName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.BranchName)
            @Html.ValidationMessageFor(Function(model) model.BranchName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.BranchAddress)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.BranchAddress)
            @Html.ValidationMessageFor(Function(model) model.BranchAddress)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
