#pragma checksum "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Tipo\CadastroTipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072d8b11612756a8c455b77772d8988b594e5d96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tipo_CadastroTipo), @"mvc.1.0.view", @"/Views/Tipo/CadastroTipo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tipo/CadastroTipo.cshtml", typeof(AspNetCore.Views_Tipo_CadastroTipo))]
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
#line 1 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\_ViewImports.cshtml"
using WebSystemUsers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072d8b11612756a8c455b77772d8988b594e5d96", @"/Views/Tipo/CadastroTipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393f6f55c67a61abdd2148a1ac419ed2d3f6caa", @"/Views/_ViewImports.cshtml")]
    public class Views_Tipo_CadastroTipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSystemUsers.Models.TipoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Tipo\CadastroTipo.cshtml"
  
    ViewBag.Title = "Cadastro Tipo de usuario";

#line default
#line hidden
            BeginContext(96, 409, true);
            WriteLiteral(@"



<h2>Cadastro de Usuários</h2>

<h2>Novo Cadastro de Usuários</h2>

<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Lista de Tipos Usuários</h5>
                </div>
                <div class=""ibox-content"">

");
            EndContext();
#line 22 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Tipo\CadastroTipo.cshtml"
                     using (Html.BeginForm("CadastroTipo", "Tipo"))
                    {

#line default
#line hidden
            BeginContext(597, 127, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-lg-6\">\r\n                                ");
            EndContext();
            BeginContext(725, 34, false);
#line 26 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Tipo\CadastroTipo.cshtml"
                           Write(Html.LabelFor(obj => obj.nomeTipo));

#line default
#line hidden
            EndContext();
            BeginContext(759, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(794, 69, false);
#line 27 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Tipo\CadastroTipo.cshtml"
                           Write(Html.TextBoxFor(obj => obj.nomeTipo, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(863, 102, true);
            WriteLiteral("\r\n                            </div>\r\n                          \r\n\r\n\r\n                        </div>\r\n");
            EndContext();
            BeginContext(990, 157, true);
            WriteLiteral("                        <div>\r\n                            <input type=\"submit\" value=\"Salvar\" class=\"btn btn-warning\" />\r\n\r\n                        </div>\r\n");
            EndContext();
#line 38 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Tipo\CadastroTipo.cshtml"
                    }

#line default
#line hidden
            BeginContext(1170, 78, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSystemUsers.Models.TipoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
