#pragma checksum "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\AppViews\Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b7cf83e9beeb3a814d261f89efeee13806407c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppViews_Article), @"mvc.1.0.view", @"/Views/AppViews/Article.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppViews/Article.cshtml", typeof(AspNetCore.Views_AppViews_Article))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b7cf83e9beeb3a814d261f89efeee13806407c", @"/Views/AppViews/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393f6f55c67a61abdd2148a1ac419ed2d3f6caa", @"/Views/_ViewImports.cshtml")]
    public class Views_AppViews_Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\AppViews\Article.cshtml"
  
    ViewData["Title"] = "Article";

#line default
#line hidden
            BeginContext(45, 213, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Article</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 258, "\"", 305, 1);
#line 11 "C:\Users\Cold\Desktop\DOTNET\WebSystemUsers\WebSystemUsers\WebSystemUsers\WebSystemUsers\Views\AppViews\Article.cshtml"
WriteAttributeValue("", 265, Url.Action("Dashboard_1", "Dashboards"), 265, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(306, 5871, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Article</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""wrapper wrapper-content  animated fadeInRight article"">
    <div class=""row justify-content-md-center"">
        <div class=""col-lg-10"">
            <div class=""ibox"">

                <div class=""ibox-content"">
                    <div class=""float-right"">
                        <button class=""btn btn-white btn-xs"" type=""button"">Model</button>
                        <button class=""btn btn-white btn-xs"" type=""button"">Publishing</button>
                        <button class=""btn btn-white btn-xs"" type=""button"">Modern</button>
                    </div>
                    <div class=""text-center article-title"">
                        <span class=""text-muted""><i class=""fa ");
            WriteLiteral(@"fa-clock-o""></i> 28th Oct 2015</span>
                        <h1>
                            Behind the word mountains
                        </h1>
                    </div>
                    <p>
                        Many desktop publishing packages and web page editors now use <strong>Lorem Ipsum as their default model text</strong>, and a search for 'lorem ipsum' will uncover many web
                    </p>
                    <p>
                        One morning, when Gregor Samsa woke from troubled dreams, he found himself transformed in his bed into a horrible vermin. He lay on his armour-like back, and if he lifted his head a little he could see his brown belly, slightly domed and divided by arches into stiff sections. The bedding was hardly able to cover it and seemed ready to slide off any moment. His many legs, pitifully thin compared with the size of the rest of him, waved about helplessly as he looked. ""What's happened to me?"" he thought. It wasn't a dream. His room, a proper");
            WriteLiteral(@" human room although a little too small, lay peacefully between its four familiar walls. A collection of textile samples lay spread out on the table - Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather. Drops
                    </p>
                    <p>
                        <i>
                            Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences f");
            WriteLiteral(@"ly into your mouth.
                        </i>
                    </p>
                    <p>
                        The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn???t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove, the headline of Alphabet Village and the subline of her own road, the Line Lane. Pityful a rethoric question ran over her cheek,
                    </p>
                    <p>
                        Two driven jocks help fax my big quiz. Quick, Baz, get my woven flax jodhpurs! ""Now fax quiz Jack!"" my brave ghost pled. Five quacking zephyrs jolt my wax bed. Flummoxed by job, kvetching W. zaps Iraq. Cozy sphinx waves quart jug of bad milk. A very bad quack might jinx zippy fowls. Few quips galvanized t");
            WriteLiteral(@"he mock jury box. Quick brown dogs jump over the lazy fox. The jay, pig, fox, zebra, and my wolves quack! Blowzy red vixens fight for a quick jump. Joaquin Phoenix was gazed by MTV for luck. A wizard???s job is to vex chumps quickly in fog. Watch ""Jeopardy!"", Alex Trebek's fun TV quiz game. Woven silk pyjamas exchanged for blue quartz. Brawny gods just
                    </p>
                    <p>
                        Brick quiz whangs jumpy veldt fox. Bright vixens jump; dozy fowl quack. Quick wafting zephyrs vex bold Jim. Quick zephyrs blow, vexing daft Jim. Sex-charged fop blew my junk TV quiz. How quickly daft jumping zebras vex.
                    </p>
                    <hr>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5>Tags:</h5>
                            <button class=""btn btn-primary btn-xs"" type=""button"">Model</button>
                            <button class=""btn btn-white btn-xs"" type=""button"">Publishing</but");
            WriteLiteral(@"ton>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""small text-right"">
                                <h5>Stats:</h5>
                                <div> <i class=""fa fa-comments-o""> </i> 56 comments </div>
                                <i class=""fa fa-eye""> </i> 144 views
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-lg-12"">

                            <h2>Comments:</h2>
                            <div class=""social-feed-box"">
                                <div class=""social-avatar"">
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6177, "\"", 6184, 0);
            EndWriteAttribute();
            BeginContext(6185, 62, true);
            WriteLiteral(" class=\"float-left\">\r\n                                        ");
            EndContext();
            BeginContext(6247, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60b7cf83e9beeb3a814d261f89efeee13806407c12363", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6286, 1140, true);
            WriteLiteral(@"
                                    </a>
                                    <div class=""media-body"">
                                        <a href=""#"">
                                            Andrew Williams
                                        </a>
                                        <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                                    </div>
                                </div>
                                <div class=""social-body"">
                                    <p>
                                        Many desktop publishing packages and web page editors now use Lorem Ipsum as their
                                        default model text, and a search for 'lorem ipsum' will uncover many web sites still
                                        default model text.
                                    </p>
                                </div>
                            </div>
                            <div class=""so");
            WriteLiteral("cial-feed-box\">\r\n                                <div class=\"social-avatar\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7426, "\"", 7433, 0);
            EndWriteAttribute();
            BeginContext(7434, 62, true);
            WriteLiteral(" class=\"float-left\">\r\n                                        ");
            EndContext();
            BeginContext(7496, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60b7cf83e9beeb3a814d261f89efeee13806407c15081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7535, 1382, true);
            WriteLiteral(@"
                                    </a>
                                    <div class=""media-body"">
                                        <a href=""#"">
                                            Michael Novek
                                        </a>
                                        <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                                    </div>
                                </div>
                                <div class=""social-body"">
                                    <p>
                                        Many desktop publishing packages and web page editors now use Lorem Ipsum as their
                                        default model text, and a search for 'lorem ipsum' will uncover many web sites still
                                        default model text, and a search for 'lorem ipsum' will uncover many web sites still
                                        in their infancy. Packages and web page editors now use L");
            WriteLiteral(@"orem Ipsum as their
                                        default model text.
                                    </p>
                                </div>
                            </div>
                            <div class=""social-feed-box"">
                                <div class=""social-avatar"">
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8917, "\"", 8924, 0);
            EndWriteAttribute();
            BeginContext(8925, 62, true);
            WriteLiteral(" class=\"float-left\">\r\n                                        ");
            EndContext();
            BeginContext(8987, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60b7cf83e9beeb3a814d261f89efeee13806407c18038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9026, 1257, true);
            WriteLiteral(@"
                                    </a>
                                    <div class=""media-body"">
                                        <a href=""#"">
                                            Alice Mediater
                                        </a>
                                        <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                                    </div>
                                </div>
                                <div class=""social-body"">
                                    <p>
                                        Many desktop publishing packages and web page editors now use Lorem Ipsum as their
                                        default model text, and a search for 'lorem ipsum' will uncover many web sites still
                                        in their infancy. Packages and web page editors now use Lorem Ipsum as their
                                        default model text.
                                    </p>
 ");
            WriteLiteral("                               </div>\r\n                            </div>\r\n                            <div class=\"social-feed-box\">\r\n                                <div class=\"social-avatar\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 10283, "\"", 10290, 0);
            EndWriteAttribute();
            BeginContext(10291, 62, true);
            WriteLiteral(" class=\"float-left\">\r\n                                        ");
            EndContext();
            BeginContext(10353, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60b7cf83e9beeb3a814d261f89efeee13806407c20881", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10392, 1252, true);
            WriteLiteral(@"
                                    </a>
                                    <div class=""media-body"">
                                        <a href=""#"">
                                            Monica Flex
                                        </a>
                                        <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                                    </div>
                                </div>
                                <div class=""social-body"">
                                    <p>
                                        Many desktop publishing packages and web page editors now use Lorem Ipsum as their
                                        default model text, and a search for 'lorem ipsum' will uncover many web sites still
                                        in their infancy. Packages and web page editors now use Lorem Ipsum as their
                                        default model text.
                                    </p>
    ");
            WriteLiteral("                            </div>\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
