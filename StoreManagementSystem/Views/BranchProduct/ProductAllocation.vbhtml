@ModelType IEnumerable(Of StoreManagementSystem.BranchProductModel)
                              

@Code
    ViewData("Title") = "ProductAllocation"
    
    
End Code

<h2>ProductAllocation</h2>


<table>
<tr><td><h2>List of Products</h2></td></tr>
    <tr>
        <th>
          Product ID
        </th>
        <th>
          Description
        </th>
        <th>
          Price
        </th>
       
    </tr>
    
    @For Each item As StoreManagementSystem.ProductModel In ViewBag.products
         @<tr>
            <td>@item.ProductId</td> 
            <td>@item.ProductDescription</td> 
            <td>@item.ProductPrice</td> 
            <td> @Html.ActionLink("Add", "add_product", New With {.Productuid = item.ProductId, .Branchuid = CInt(ViewData("prodID"))})</td> 
        </tr>
    Next     
</table>


<table>
<tr><td><h2>Selected List of Products </h2></td></tr>
    <tr>
       
        <th>
          Product ID
        </th>
        
        
    </tr>

    @For Each item As StoreManagementSystem.BranchProductModel In ViewBag.branchproducts
         @<tr>
            
            <td>@item.Productuid</td> 
            
            <td> @Html.ActionLink("Delete", "Delete", New With {.Id = item.BranchProductId})</td> 
        </tr>
    Next
   
</table>

 @Html.ActionLink("Back to List", "Index","Branch")


