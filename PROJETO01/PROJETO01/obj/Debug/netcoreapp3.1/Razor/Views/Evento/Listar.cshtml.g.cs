#pragma checksum "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d961f89de3c729f37105cde9a3d3908a13bbf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_Listar), @"mvc.1.0.view", @"/Views/Evento/Listar.cshtml")]
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
#line 1 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d961f89de3c729f37105cde9a3d3908a13bbf2", @"/Views/Evento/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.evento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid "" style= ""border:groove; color:thick;background-color:white"">
    <br />
<h3>
    CADASTRO DE EVENTOS
    <a class=""btn btn-sm btn-dark float-right"" href=""/evento/Adicionar"">
        + ADICIONAR
    </a>
</h3>

<table class=""table table-hover "">
    <thead>
        <tr>
            <th>EventoID</th>
            <th>nome</th>
            <th>taxa</th>
            <th>horario</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
               Write(item.EventoID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
               Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
               Write(item.taxa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 27 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
                 Write(item.horario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 775, "\"", 814, 2);
            WriteAttributeValue("", 782, "/evento/Editar?uf=", 782, 18, true);
#nullable restore
#line 29 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
WriteAttributeValue("", 800, item.EventoID, 800, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 969, 2);
            WriteAttributeValue("", 936, "/evento/Excluir?uf=", 936, 19, true);
#nullable restore
#line 32 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
WriteAttributeValue("", 955, item.EventoID, 955, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\040160\Downloads\PROJETO01 (3)\PROJETO01\PROJETO01\Views\Evento\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n  </div>\r\n     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
