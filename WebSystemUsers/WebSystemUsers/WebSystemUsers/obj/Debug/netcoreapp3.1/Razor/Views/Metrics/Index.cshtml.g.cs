#pragma checksum "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Metrics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1cd157eb2d1ca0d391f044ee2177b56692c86a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Metrics_Index), @"mvc.1.0.view", @"/Views/Metrics/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Metrics/Index.cshtml", typeof(AspNetCore.Views_Metrics_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1cd157eb2d1ca0d391f044ee2177b56692c86a", @"/Views/Metrics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393f6f55c67a61abdd2148a1ac419ed2d3f6caa", @"/Views/_ViewImports.cshtml")]
    public class Views_Metrics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sparkline/jquery.sparkline.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\Metrics\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 14371, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5 class=""m-b-md"">Server status Q12</h5>
                    <h2 class=""text-navy"">
                        <i class=""fa fa-play fa-rotate-270""></i> Up
                    </h2>
                    <small>Last down 42 days ago</small>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content "">
                    <h5 class=""m-b-md"">Server status Q13</h5>
                    <h2 class=""text-navy"">
                        <i class=""fa fa-play fa-rotate-270""></i> Up
                    </h2>
                    <small>Last down 42 days ago</small>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                ");
            WriteLiteral(@"<div class=""ibox-content"">
                    <h5 class=""m-b-md"">Server status Q42</h5>
                    <h2 class=""text-danger"">
                        <i class=""fa fa-play fa-rotate-90""></i> Down
                    </h2>
                    <small>Server down since 4 days</small>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5 class=""m-b-md"">Server status Q43</h5>
                    <h2 class=""text-danger"">
                        <i class=""fa fa-play fa-rotate-90""></i> Down
                    </h2>
                    <small>Server down since 4:32 pm.</small>
                </div>
            </div>
        </div>

    </div>
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Visits in last 24h</h5>
                    <h2>198 009</h2>
");
            WriteLiteral(@"                    <div id=""sparkline1""></div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Visits week</h5>
                    <h2>65 000</h2>
                    <div id=""sparkline2""></div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Last month</h5>
                    <h2>680 900</h2>
                    <div id=""sparkline3""></div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Avarage time</h5>
                    <h2>00:06:40</h2>
                    <div id=""sparkline4""></div>
                </div>
            </div>
        </div>
    </div>
    <div cla");
            WriteLiteral(@"ss=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Usage</h5>
                    <h2>65%</h2>
                    <div class=""progress progress-mini"">
                        <div style=""width: 68%;"" class=""progress-bar""></div>
                    </div>

                    <div class=""m-t-sm small"">Server down since 4:32 pm.</div>
                </div>
            </div>
        </div>

        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Usage</h5>
                    <h2>50%</h2>
                    <div class=""progress progress-mini"">
                        <div style=""width: 78%;"" class=""progress-bar""></div>
                    </div>

                    <div class=""m-t-sm small"">Server down since 4:32 pm.</div>
                </div>
            </div>
        </div>

        <div class=""col-lg-3"">
         ");
            WriteLiteral(@"   <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Usage</h5>
                    <h2>14%</h2>
                    <div class=""progress progress-mini"">
                        <div style=""width: 38%;"" class=""progress-bar progress-bar-danger""></div>
                    </div>

                    <div class=""m-t-sm small"">Server down since 4:32 pm.</div>
                </div>
            </div>
        </div>

        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Usage</h5>
                    <h2>20%</h2>
                    <div class=""progress progress-mini"">
                        <div style=""width: 28%;"" class=""progress-bar progress-bar-danger""></div>
                    </div>

                    <div class=""m-t-sm small"">Server down since 4:32 pm.</div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class");
            WriteLiteral(@"=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Percentage distribution</h5>
                    <h2>42/20</h2>
                    <div class=""text-center"">
                        <div id=""sparkline5""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Percentage division</h5>
                    <h2>100/54</h2>
                    <div class=""text-center"">
                        <div id=""sparkline6""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Percentage distribution</h5>
                    <h2>685/211</h2>
                    <div class=""text-center"">
                        <d");
            WriteLiteral(@"iv id=""sparkline7""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Percentage division</h5>
                    <h2>240/32</h2>
                    <div class=""text-center"">
                        <div id=""sparkline8""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Income</h5>
                    <h1 class=""no-margins"">886,200</h1>
                    <div class=""stat-percent font-bold text-navy"">98% <i class=""fa fa-bolt""></i></div>
                    <small>Total income</small>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
            ");
            WriteLiteral(@"    <div class=""ibox-content"">
                    <h5>Income last month</h5>
                    <h1 class=""no-margins"">1 738,200</h1>
                    <div class=""stat-percent font-bold text-navy"">98% <i class=""fa fa-bolt""></i></div>
                    <small>Total income</small>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Income last day</h5>
                    <h1 class=""no-margins"">-200,100</h1>
                    <div class=""stat-percent font-bold text-danger"">12% <i class=""fa fa-level-down""></i></div>
                    <small>Total income</small>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Income all</h5>
                    <h1 class=""no-margins"">54,200</h1>
                    <div class=""st");
            WriteLiteral(@"at-percent font-bold text-danger"">24% <i class=""fa fa-level-down""></i></div>
                    <small>Total income</small>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>All new alerts</h5>
                    <table class=""table table-stripped small m-t-md"">
                        <tbody>
                            <tr>
                                <td class=""no-borders"">
                                    <i class=""fa fa-circle text-navy""></i>
                                </td>
                                <td class=""no-borders"">
                                    Example element 1
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-navy""></i>
     ");
            WriteLiteral(@"                           </td>
                                <td>
                                    Example element 2
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-navy""></i>
                                </td>
                                <td>
                                    Example element 3
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Alerts</h5>
                    <table class=""table table-stripped small m-t-md"">
                        <tbody>
                            <tr>
                                <td class=""no-borders"">
     ");
            WriteLiteral(@"                               <i class=""fa fa-circle text-navy""></i>
                                </td>
                                <td class=""no-borders"">
                                    Example element 1
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-navy""></i>
                                </td>
                                <td>
                                    Example element 2
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-navy""></i>
                                </td>
                                <td>
                                    Example element 3
                                </td>
                            </tr>
                    ");
            WriteLiteral(@"    </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>All messages</h5>
                    <table class=""table table-stripped small m-t-md"">
                        <tbody>
                            <tr>
                                <td class=""no-borders"">
                                    <i class=""fa fa-circle text-danger""></i>
                                </td>
                                <td class=""no-borders"">
                                    Example element 1
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-danger""></i>
                                </td>
                                <td>
                                    Example ");
            WriteLiteral(@"element 2
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-danger""></i>
                                </td>
                                <td>
                                    Example element 3
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h5>Last notification</h5>
                    <table class=""table table-stripped small m-t-md"">
                        <tbody>
                            <tr>
                                <td class=""no-borders"">
                                    <i class=""fa fa-circle text-danger""></i>
                              ");
            WriteLiteral(@"  </td>
                                <td class=""no-borders"">
                                    Example element 1
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-danger""></i>
                                </td>
                                <td>
                                    Example element 2
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <i class=""fa fa-circle text-danger""></i>
                                </td>
                                <td>
                                    Example element 3
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        <");
            WriteLiteral("/div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(14432, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14438, 145, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1cd157eb2d1ca0d391f044ee2177b56692c86a19678", async() => {
                    BeginContext(14490, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(14500, 63, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1cd157eb2d1ca0d391f044ee2177b56692c86a20100", async() => {
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
                    BeginContext(14563, 6, true);
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
                BeginContext(14583, 1961, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $('body').addClass('light-navbar');

            $(""#sparkline1"").sparkline([34, 43, 43, 35, 44, 32, 44, 52], {
                type: 'line',
                width: '100%',
                height: '60',
                lineColor: '#1ab394',
                fillColor: ""#ffffff""
            });

            $(""#sparkline2"").sparkline([24, 43, 43, 55, 44, 62, 44, 72], {
                type: 'line',
                width: '100%',
                height: '60',
                lineColor: '#1ab394',
                fillColor: ""#ffffff""
            });

            $(""#sparkline3"").sparkline([74, 43, 23, 55, 54, 32, 24, 12], {
                type: 'line',
                width: '100%',
                height: '60',
                lineColor: '#ed5565',
                fillColor: ""#ffffff""
            });

            $(""#sparkline4"").sparkline([24, 43, 33, 55, 64, 72, 44, 22], {
               ");
                WriteLiteral(@" type: 'line',
                width: '100%',
                height: '60',
                lineColor: '#ed5565',
                fillColor: ""#ffffff""
            });

            $(""#sparkline5"").sparkline([1, 4], {
                type: 'pie',
                height: '140',
                sliceColors: ['#1ab394', '#F5F5F5']
            });

            $(""#sparkline6"").sparkline([5, 3], {
                type: 'pie',
                height: '140',
                sliceColors: ['#1ab394', '#F5F5F5']
            });

            $(""#sparkline7"").sparkline([2, 2], {
                type: 'pie',
                height: '140',
                sliceColors: ['#ed5565', '#F5F5F5']
            });

            $(""#sparkline8"").sparkline([2, 3], {
                type: 'pie',
                height: '140',
                sliceColors: ['#ed5565', '#F5F5F5']
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(16547, 2, true);
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
