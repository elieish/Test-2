@ModelType StoreManagementSystem.ProductModel

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>ProductModel</legend>

        @Html.HiddenFor(Function(model) model.ProductId)

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
