@ModelType StoreManagementSystem.BranchModels

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>BranchModels</legend>

        @Html.HiddenFor(Function(model) model.BranchId)

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
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
