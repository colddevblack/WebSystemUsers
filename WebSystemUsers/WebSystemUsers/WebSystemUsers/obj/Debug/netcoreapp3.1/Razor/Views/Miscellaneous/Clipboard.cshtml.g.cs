#pragma checksum "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Miscellaneous\Clipboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e023bb63c6f17bf51d7c032d334aaa4e8b45e84f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_Clipboard), @"mvc.1.0.view", @"/Views/Miscellaneous/Clipboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/Clipboard.cshtml", typeof(AspNetCore.Views_Miscellaneous_Clipboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e023bb63c6f17bf51d7c032d334aaa4e8b45e84f", @"/Views/Miscellaneous/Clipboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393f6f55c67a61abdd2148a1ac419ed2d3f6caa", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_Clipboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/clipboard/clipboard.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Miscellaneous\Clipboard.cshtml"
  
    ViewData["Title"] = "Clipboard";

#line default
#line hidden
            BeginContext(47, 223, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Copy to clipboard</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 270, "\"", 317, 1);
#line 11 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Miscellaneous\Clipboard.cshtml"
WriteAttributeValue("", 277, Url.Action("Dashboard_1", "Dashboards"), 277, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(318, 3917, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Copy to clipboard</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Copy to clipboard</h5>
                </div>

                <div class=""ibox-content"">


                    <p>
                        Modern copy to clipboard features. Just 2kb without flash!
                    </p>

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h3>Copy text from another element</h3>

                            <p>
                                A pretty common use case");
            WriteLiteral(@" is to copy content from another element. You can do that by adding a <code>data-clipboard-target</code> attribute in your trigger element.
                            </p>
                            <p>
                                The value you include on this attribute needs to match another's element selector.
                            </p>

                            <p class=""text-navy font-bold"" id=""copytext"">Please press the button and copy me!</p>
                            <button class=""btn btn-white"" data-clipboard-target=""#copytext""><i class=""fa fa-copy""></i> Copy</button>

                            <div class=""m-t"">
                                <strong>HTML markup</strong>
                            </div>
                            <pre>
&lt;p id=""copytext""&gt;Please press the button and copy me!&lt;/p&gt;
&lt;button class=""btn btn-white"" data-clipboard-target=""#copytext""&gt;&lt;i class=""fa fa-copy""&gt;&lt;/i&gt; Copy&lt;/button&gt;
                                ");
            WriteLiteral(@"    </pre>
                        </div>
                        <div class=""col-md-6"">
                            <h3>Cut text from another element</h3>

                            <p>
                                Additionally, you can define a <code>data-clipboard-action</code> attribute to specify if you want to either <code>copy</code> or <code>cut</code> content.
                            </p>

                            <textarea class=""form-control"" id=""cuttext"">This is example text that will be cuted fromt this textarea control.</textarea>
                            <button class=""btn btn-white m-t"" data-clipboard-action=""cut"" data-clipboard-target=""#cuttext""><i class=""fa fa-cut""></i> Cut to clipboard</button>

                            <div class=""m-t"">
                                <strong>HTML markup</strong>
                            </div>

                            <pre>
&lt;textarea id=""cuttext""&gt;This is example text that will be cuted fromt this textarea co");
            WriteLiteral(@"ntrol.&lt;/textarea&gt;
&lt;button class=""btn btn-white"" data-clipboard-action=""cut"" data-clipboard-target=""#cuttext""&gt;&lt;i class=""fa fa-cut""&gt;&lt;/i&gt; Cut to clipboard&lt;/button&gt;
                                    </pre>

                        </div>
                    </div>

                </div>
            </div>
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Playground</h5>
                </div>

                <div class=""ibox-content"">


                    <strong>

                        Paste and test you copied text.
                    </strong>

                    <textarea class=""form-control border-left m-t"" style=""height: 200px""></textarea>

                </div>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4253, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4259, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e023bb63c6f17bf51d7c032d334aaa4e8b45e84f9409", async() => {
                    BeginContext(4311, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(4321, 56, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e023bb63c6f17bf51d7c032d334aaa4e8b45e84f9828", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4377, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4397, 150, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n\r\n            new Clipboard(\'.btn\');\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4550, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
