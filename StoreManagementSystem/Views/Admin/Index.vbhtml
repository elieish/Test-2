@Code
    ViewData("Title") = "Administration"
End Code

<h2>Administration</h2>

<ul>
    <li>@Html.ActionLink("Branch Maintenance", "Index", "Branch")</li>
    <li>@Html.ActionLink("Product Maintenance", "Index", "Product")</li>
</ul>
