#pragma checksum "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Pages\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d544ed055ab7a44c8089cc0c4277aa617589ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_SearchResults), @"mvc.1.0.view", @"/Views/Pages/SearchResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/SearchResults.cshtml", typeof(AspNetCore.Views_Pages_SearchResults))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d544ed055ab7a44c8089cc0c4277aa617589ab6", @"/Views/Pages/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393f6f55c67a61abdd2148a1ac419ed2d3f6caa", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Pages\SearchResults.cshtml"
  
    ViewData["Title"] = "SearchResults";

#line default
#line hidden
            BeginContext(51, 217, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-9\">\r\n        <h2>\tSearch Page</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 268, "\"", 315, 1);
#line 11 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Pages\SearchResults.cshtml"
WriteAttributeValue("", 275, Url.Action("Dashboard_1", "Dashboards"), 275, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 749, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                Extra Pages
            </li>
            <li class=""active breadcrumb-item"">
                <strong>	Search Page</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-content"">
                    <h2>
                        2,160 results found for: <span class=""text-navy"">???Admin Theme???</span>
                    </h2>
                    <small>Request time  (0.23 seconds)</small>

                    <div class=""search-form"">
                        ");
            EndContext();
            BeginContext(1065, 614, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d544ed055ab7a44c8089cc0c4277aa617589ab65454", async() => {
                BeginContext(1134, 538, true);
                WriteLiteral(@"
                            <div class=""input-group"">
                                <input type=""text"" placeholder=""Admin Theme"" name=""search"" class=""form-control form-control-lg"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-lg btn-primary"" type=""submit"">
                                        Search
                                    </button>
                                </div>
                            </div>

                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Pages\SearchResults.cshtml"
AddHtmlAttributeValue("", 1079, Url.Action("Dashboard_1", "Dashboards"), 1079, 40, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1679, 4587, true);
            WriteLiteral(@"
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">INSPINIA IN+ Admin Theme</a></h3>
                        <a href=""#"" class=""search-link"">www.inspinia.com/inspinia</a>
                        <p>
                            Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites
                            still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">WrapBootstrap - Bootstrap Themes & Templates</a></h3>
                        <a href=""#"" class=""search-link"">https://wrapbootst");
            WriteLiteral(@"rap.com/???</a>
                        <p>
                            WrapBootstrap is a marketplace for premium Bootstrap themes and templates. Impress your clients and visitors while using a single, rock-solid foundation.
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">WrapBootstrap | Facebook</a></h3>
                        <a href=""#"" class=""search-link"">https://www.facebook.com/wrapbootstrap???</a>
                        <p>
                            WrapBootstrap. 13672 likes ?? 508 talking about this. Marketplace for premium Bootstrap themes and templates. https://wrapbootstrap.com/
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">Wrapbootstrap - Quora</a></h3>
                        <a hr");
            WriteLiteral(@"ef=""#"" class=""search-link"">www.quora.com/Wrapbootstrap??????</a>
                        <p>
                            If you are familiar with using any other HTML/CSS themes or WordPress themes then you shouldn't have any problems. If you have some experience using the ...
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">Newspaper Template - Wrapbootstrap Free download ...</a></h3>
                        <a href=""#"" class=""search-link"">https://wrapbootstrap.com/??????</a>
                        <p>
                            What's black, white and red all over? The answer is Newspaper. A stylish magazine/news style theme inspired by black and white newsprint. The theme is.
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                  ");
            WriteLiteral(@"      <h3><a href=""#"">Admin Themes Wrapbootstrap</a></h3>
                        <a href=""#"" class=""search-link"">https://wrapbootstrap.com/themes/admin??????</a>
                        <p>
                            It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""text-center"">
                        <div class=""btn-group"">
                            <button class=""btn btn-white"" type=""button""><i class=""fa fa-chevron-left""></i></button>
                            <button class=""btn btn-white"">1</button>
                            <button class=""btn btn-white  active"">2</button>
                            <button class=""btn btn-white"">3</button>
                            <button class=""btn btn-w");
            WriteLiteral(@"hite"">4</button>
                            <button class=""btn btn-white"">5</button>
                            <button class=""btn btn-white"">6</button>
                            <button class=""btn btn-white"">7</button>
                            <button class=""btn btn-white"" type=""button""><i class=""fa fa-chevron-right""></i> </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
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
