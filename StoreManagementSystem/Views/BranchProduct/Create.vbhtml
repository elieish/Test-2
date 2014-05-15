﻿@ModelType StoreManagementSystem.BranchProductModel

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>BranchProductModel</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Branchuid)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Branchuid)
            @Html.ValidationMessageFor(Function(model) model.Branchuid)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Productuid)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Productuid)
            @Html.ValidationMessageFor(Function(model) model.Productuid)
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
