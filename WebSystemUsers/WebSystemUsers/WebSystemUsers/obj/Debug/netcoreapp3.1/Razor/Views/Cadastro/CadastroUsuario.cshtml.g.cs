#pragma checksum "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d36696ab534ca51ff2ebfe3e08fdd93b5d12231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_CadastroUsuario), @"mvc.1.0.view", @"/Views/Cadastro/CadastroUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/CadastroUsuario.cshtml", typeof(AspNetCore.Views_Cadastro_CadastroUsuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d36696ab534ca51ff2ebfe3e08fdd93b5d12231", @"/Views/Cadastro/CadastroUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393f6f55c67a61abdd2148a1ac419ed2d3f6caa", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_CadastroUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSystemUsers.Models.UsuarioModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
  
    ViewBag.Title = "Cadastro Usuarios";

#line default
#line hidden
            BeginContext(92, 403, true);
            WriteLiteral(@"



<h2>Cadastro de Usuários</h2>

<h2>Novo Cadastro de Usuários</h2>

<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Lista de Usuários</h5>
                </div>
                <div class=""ibox-content"">

");
            EndContext();
#line 22 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                     using (Html.BeginForm("CadastroUsuario", "Cadastro"))
                    {

#line default
#line hidden
            BeginContext(594, 115, true);
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-lg-6\">\r\n                            ");
            EndContext();
            BeginContext(710, 30, false);
#line 26 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                       Write(Html.LabelFor(obj => obj.nome));

#line default
#line hidden
            EndContext();
            BeginContext(740, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(771, 65, false);
#line 27 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                       Write(Html.TextBoxFor(obj => obj.nome, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(836, 110, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-lg-6\">\r\n                            ");
            EndContext();
            BeginContext(947, 31, false);
#line 30 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                       Write(Html.LabelFor(obj => obj.email));

#line default
#line hidden
            EndContext();
            BeginContext(978, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1009, 66, false);
#line 31 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                       Write(Html.TextBoxFor(obj => obj.email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 112, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"col-lg-3\">\r\n                            ");
            EndContext();
            BeginContext(1188, 31, false);
#line 35 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                       Write(Html.LabelFor(obj => obj.senha));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1250, 65, false);
#line 36 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                       Write(Html.TextBoxFor(obj => obj.senha, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 207, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                <div class=\"col-lg-3\">\r\n                <label for=\'tiposid\' class=\"control-label\">Tipo de usuario</label>\r\n                 ");
            EndContext();
            BeginContext(1523, 80, false);
#line 43 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
            Write(Html.DropDownList("tiposid", null, "Selecione", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 183, true);
            WriteLiteral("\r\n                </div>\r\n                        <div>\r\n                            <input type=\"submit\" value=\"Salvar\" class=\"btn btn-warning\" />\r\n\r\n                        </div>\r\n");
            EndContext();
#line 49 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Cadastro\CadastroUsuario.cshtml"
                    }

#line default
#line hidden
            BeginContext(1809, 78, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSystemUsers.Models.UsuarioModel> Html { get; private set; }
    }
}
#pragma warning restore 1591