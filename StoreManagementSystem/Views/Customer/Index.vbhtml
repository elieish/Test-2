
@Code
    ViewData("Title") = "Customer View"
End Code
<h2>Index</h2>
  @Using (Html.BeginForm("ViewBranchProducts", "Customer", FormMethod.Get))
    @<p>
        Branch: @Html.DropDownList("branchprods", "All")    
        <input type="submit" value="Filter" />
    </p>
End Using

