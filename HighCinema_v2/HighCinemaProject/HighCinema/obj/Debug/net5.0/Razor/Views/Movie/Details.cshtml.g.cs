#pragma checksum "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2bc68de0a746600b34fcfbd5a1d4721479faf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2bc68de0a746600b34fcfbd5a1d4721479faf7", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9b2f25d7cd69bc422a0121b0cae0c8ab76d6ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaObject.Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\" style=\"margin-top:24px;\">Details Movie Information</h1>\r\n\r\n<hr />\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <img width=\"100px\" height=\"100px\" class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 851, "\"", 882, 1);
#nullable restore
#line 30 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
WriteAttributeValue("", 857, Url.Content(Model.Image), 857, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MainCharacters));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.MainCharacters));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div class=\"form-group text-center\">\r\n    ");
#nullable restore
#line 72 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Movie\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }, new {@class= "btn btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <span> | </span>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2bc68de0a746600b34fcfbd5a1d4721479faf711039", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaObject.Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
