#pragma checksum "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21724c5abaff996289a62c1fc5d537478a6b9f15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 2 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21724c5abaff996289a62c1fc5d537478a6b9f15", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be2b51821e9ae1f5026504230aac748e42d9a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
  //buranın layoultla alakası yok
    var popularClass=Model.Products.Count>2?"popular":""; 
    var products=Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n   ");
#nullable restore
#line 13 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("        \r\n");
#nullable restore
#line 16 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
                 if(products.Count ==0 )
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                                      
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">                  \r\n");
#nullable restore
#line 23 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
                         foreach (var product in products)
                        {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
                       Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>       \r\n");
#nullable restore
#line 29 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
                        
                        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\Ahmet Karadağ\shopapp\shopapp.webui\Views\Product\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
