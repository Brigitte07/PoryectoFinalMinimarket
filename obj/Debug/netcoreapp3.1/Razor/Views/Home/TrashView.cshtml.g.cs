#pragma checksum "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c31ef64e3dabb98baf71371b955a93ab24b4369b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrashView), @"mvc.1.0.view", @"/Views/Home/TrashView.cshtml")]
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
#line 1 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\_ViewImports.cshtml"
using Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\_ViewImports.cshtml"
using Market.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c31ef64e3dabb98baf71371b955a93ab24b4369b", @"/Views/Home/TrashView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6acc4b6803c069117c5c3b69757ef810f5c5bd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrashView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Market.Models.Trash>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
  
    ViewData["Title"] = "Trash";
    Layout = "_ClientLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped table-inverse"">
    <tr class=""text-center"">
        <th colspan=""6"">Lista de Productos</th>
    </tr>
    <tr>
        <td>Id</td>
        <td>Nombre</td>
        <td>Costo</td>
        <td>Direccion</td>
        <td>Tiempo</td>
        <td>Numero de telefono</td>
    </tr>
");
#nullable restore
#line 20 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
     if(Model.Count > 0){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
               Write(item.ProductsName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
               Write(item.ProductsCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
               Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
               Write(item.DeliveryTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \n                <td>");
#nullable restore
#line 29 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>     \n            </tr>\n");
#nullable restore
#line 31 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
         
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr class=\"text-center\">\n        <th colspan=\"5\">Vacio</th>\n    </tr>        \n");
#nullable restore
#line 36 "C:\Users\BRIGITTE\Desktop\MinimarcketCeleste\PoryectoFinalMinimarket\Views\Home\TrashView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Market.Models.Trash>> Html { get; private set; }
    }
}
#pragma warning restore 1591
