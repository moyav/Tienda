#pragma checksum "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b19d16484d5f68689ad868ce15c34814dee696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\_ViewImports.cshtml"
using TiendaIdeasElArca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\_ViewImports.cshtml"
using TiendaIdeasElArca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b19d16484d5f68689ad868ce15c34814dee696", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190c4db83be9ae353b254a746c75adc3f29fb6c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
  
    /*ViewData["Title"] = "Home Page";*/
    ViewBag.Title = "Index";
    var ListaProductos = ViewBag.ListaProductos;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Lista de Productos</h2>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 164, "\"", 193, 1);
#nullable restore
#line 9 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
WriteAttributeValue("", 171, Url.Action("Agregar"), 171, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Agregar</a>\r\n\r\n<hr />\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 17 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
         foreach(var p in ListaProductos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n\r\n               <div class=\"panel panel-default\">\r\n                   <div class=\"panel-heading\">");
#nullable restore
#line 22 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
                                         Write(p.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                   <div class=\"panel-body\">\r\n                       <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 587, 1);
#nullable restore
#line 24 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
WriteAttributeValue("", 578, p.Imagen, 578, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n\r\n                       <p>");
#nullable restore
#line 26 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
                     Write(p.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                       <p>$ ");
#nullable restore
#line 27 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
                       Write(p.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                   </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\X555QG\Documents\Desarrollos\IdeasElArca-CarritoDeCompras\TiendaIdeasElArca\TiendaIdeasElArca\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
