#pragma checksum "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b180bf80fd91abb1ebad86f6e5a507ec36e5bc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\devbuild4\CoffeeShopLab13-2\Views\_ViewImports.cshtml"
using CoffeeShopLab13_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\CoffeeShopLab13-2\Views\_ViewImports.cshtml"
using CoffeeShopLab13_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b180bf80fd91abb1ebad86f6e5a507ec36e5bc6", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a67f7170691f624b3da35b00901d1a26bb342ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    table#drinkTable {\r\n        width: 30%;\r\n        margin-left: 10%;\r\n        margin-right: 60%;\r\n        text-align: left;\r\n    }\r\n</style>\r\n\r\n<h1>Drinks</h1>\r\n\r\n");
#nullable restore
#line 17 "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml"
 foreach (Products prod in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"drinkTable\">\r\n    <tr><td width=60%><a");
            BeginWriteAttribute("href", " href=\"", 330, "\"", 366, 2);
            WriteAttributeValue("", 337, "/Product/Products?ID=", 337, 21, true);
#nullable restore
#line 20 "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml"
WriteAttributeValue("", 358, prod.ID, 358, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml"
                                                         Write(prod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td><td>");
#nullable restore
#line 20 "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml"
                                                                                 Write(prod.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n</table>\r\n    <br />\r\n");
#nullable restore
#line 23 "C:\devbuild4\CoffeeShopLab13-2\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
