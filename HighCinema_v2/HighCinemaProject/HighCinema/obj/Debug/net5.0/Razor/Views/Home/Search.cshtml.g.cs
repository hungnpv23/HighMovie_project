#pragma checksum "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8454690ab6cd4a1fd2690e113f17c2f1a5b0421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\_ViewImports.cshtml"
using HighCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\_ViewImports.cshtml"
using HighCinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8454690ab6cd4a1fd2690e113f17c2f1a5b0421", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9b2f25d7cd69bc422a0121b0cae0c8ab76d6ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaObject.Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hvr-shutter-out-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center"" style=""margin: 16px 0"">HighShop Movie Search List</h2>
<hr />

<div class=""general"">
    <h4 class=""latest-text w3_latest_text"">Movies</h4>
    <div class=""container"">
        <div id=""myTabContent"" class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane fade active in"" id=""home"" aria-labelledby=""home-tab"">
                <div class=""w3_agile_featured_movies"">
");
#nullable restore
#line 17 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-2 w3l-movie-gride-agile\" style=\"min-height: 425px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8454690ab6cd4a1fd2690e113f17c2f1a5b04216268", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 888, "\"", 918, 1);
#nullable restore
#line 21 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
WriteAttributeValue("", 894, Url.Content(item.Image), 894, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"album-name\" class=\"img-responsive\" alt=\" \" />\r\n                                <div class=\"w3l-action-icon\"><i class=\"fa fa-play-circle\" aria-hidden=\"true\"></i></div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"mid-1 agileits_w3layouts_mid_1_home\">\r\n                                <div class=\"w3l-movie-text\">\r\n                                    <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8454690ab6cd4a1fd2690e113f17c2f1a5b04219608", async() => {
#nullable restore
#line 26 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <div class=\"mid-2 agile_mid_2_home\">\r\n                                    <p>Duration: ");
#nullable restore
#line 29 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                            Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <div class=""block-stars"">
                                        <ul class=""w3l-ratings"">
                                            <li><a href=""#""><i class=""fa fa-star"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star-half-o"" aria-hidden=""true""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""clearfix""></div>
                                </div>
                            </div>
                            <div class=""ribben"">
                   ");
            WriteLiteral("             <p>NEW</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 46 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""clearfix""> </div>
                </div>
            </div>
        </div>
    </div>
</div>

<hr />
<h2 class=""text-center"">Detail & Booking</h2>
<hr />

<div class=""faq"">
    <div class=""container"">
        <div id=""myTabContent"" class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane fade in active"" id=""home"" aria-labelledby=""home-tab"">
                <div class=""agile-news-table"">
                    <table class=""table-hover table-responsive"">
                        <thead>
                            <tr>
                                <th>No.</th>
                                <th>Movie Name</th>
                                <th>Description</th>
                                <th>Main Actor</th>
                                <th>Duration</th>

                                <th>Booking</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 76 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 79 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <img width=\"350px\"");
            BeginWriteAttribute("src", " src=\"", 3956, "\"", 3986, 1);
#nullable restore
#line 81 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
WriteAttributeValue("", 3962, Url.Content(item.Image), 3962, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 4010, "\"", 4016, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <p>");
#nullable restore
#line 82 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 84 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 85 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                   Write(item.MainCharacters);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 86 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                   Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8454690ab6cd4a1fd2690e113f17c2f1a5b042116824", async() => {
                WriteLiteral("Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 91 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Home\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaObject.Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
