#pragma checksum "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66bf728831680639a0da18a78264474895d1567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66bf728831680639a0da18a78264474895d1567", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9b2f25d7cd69bc422a0121b0cae0c8ab76d6ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaObject.staff>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 168px; border-radius:30px; padding: 14px 0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\" style=\"margin-top:24px;\">Staff Management</h1>\r\n\r\n<p style=\"margin: 24px 0;text-align: center;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c66bf728831680639a0da18a78264474895d15674681", async() => {
                WriteLiteral("Add New Staff");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-hover table-responsive\" id=\"staffTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img width=\"200px\"");
            BeginWriteAttribute("src", " src=\"", 1620, "\"", 1650, 1);
#nullable restore
#line 54 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
WriteAttributeValue("", 1626, Url.Content(item.Image), 1626, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"/>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
#nullable restore
#line 60 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }, new {@class= "btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <br />\r\n\r\n                    ");
#nullable restore
#line 64 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id=item.Id }, new {@class= "btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <br />\r\n                    <br />\r\n                    ");
#nullable restore
#line 68 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }, new {@class= "btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n            <tr>\r\n                <th>\r\n                        ");
#nullable restore
#line 76 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 79 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 82 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 85 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 88 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 91 "D:\HocLieu\PRN211\HighMovie_cv\HighCinema_v2\HighCinemaProject\HighCinema\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n    </tfoot>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaObject.staff>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
