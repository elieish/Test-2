@ModelType StoreManagementSystem.ProductModel

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>ProductModel</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ProductDescription)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.ProductDescription)
            @Html.ValidationMessageFor(Function(model) model.ProductDescription)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ProductPrice)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.ProductPrice)
            @Html.ValidationMessageFor(Function(model) model.ProductPrice)
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
