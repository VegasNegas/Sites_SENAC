#pragma checksum "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6b014cc37f2f74092720054db4629237343895f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
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
#line 1 "D:\Documentos\Senac\UC4\Atividade 2\Views\_ViewImports.cshtml"
using Atividade_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\Senac\UC4\Atividade 2\Views\_ViewImports.cshtml"
using Atividade_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6b014cc37f2f74092720054db4629237343895f", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d462a169bb18cfd2e5b15a2cccdd2b5e800796f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
  
    ViewData["Title"] = "Cadastro de Viagens";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Lista</h2>
<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>NOME</th>
            <th>ORIGEM</th>
            <th>DESTINO</th>
            <th>ATRATIVOS</th>
            <th>SAIDA</th>
            <th>RETORNO</th>
            <th>USUARIO</th>
            <th>AÇÕES</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
         foreach (PacotesTuristicos item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
               Write(item.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 907, 2);
            WriteAttributeValue("", 883, "/Home/Editar?Id=", 883, 16, true);
#nullable restore
#line 33 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
WriteAttributeValue("", 899, item.Id, 899, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 943, "\"", 975, 2);
            WriteAttributeValue("", 950, "/Home/Remover?Id=", 950, 17, true);
#nullable restore
#line 34 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
WriteAttributeValue("", 967, item.Id, 967, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deletar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "D:\Documentos\Senac\UC4\Atividade 2\Views\Home\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591