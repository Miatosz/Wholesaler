#pragma checksum "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f7b72209c7ea3dbff0f6ab5da65766c6103058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListOrders), @"mvc.1.0.view", @"/Views/Admin/ListOrders.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/_ViewImports.cshtml"
using Wholesaler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/_ViewImports.cshtml"
using Wholesaler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/_ViewImports.cshtml"
using Wholesaler.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/_ViewImports.cshtml"
using Wholesaler.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f7b72209c7ea3dbff0f6ab5da65766c6103058", @"/Views/Admin/ListOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897949581738ead327005ebe72420022f3e08577", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
  
    ViewBag.Title = "Zamówienia";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table table-bordered table-striped\">\n    <tr>\n        <th>ID produktu</th>\n        <th>Produkt</th>\n        <th>wartosc</th>\n        <th>Ilość</th>\n        <th>Sklep</th>\n        <th>Zamowienie</th>\n    </tr>\n\n\n");
#nullable restore
#line 19 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
 if (Model.Count() > 0)
{
    
        
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
         foreach (var o in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 26 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
                           Write(o.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 27 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
               Write(o.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>         \n                <th>");
#nullable restore
#line 28 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
               Write(o.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>       \n                <th>");
#nullable restore
#line 29 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
               Write(o.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 30 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
               Write(o.Shop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 31 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
               Write(o.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n               \n                \n            </tr>\n");
#nullable restore
#line 35 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
            
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
         
    
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">Brak niezrealizowanych zamówień</div>\n");
#nullable restore
#line 42 "/home/marcin/Pulpit/Github/Wholesaler/webApp/Views/Admin/ListOrders.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
