#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bbcfb7b73447e416f25c3d1f9f13b8b961b5486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Index), @"mvc.1.0.view", @"/Views/Companies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Index.cshtml", typeof(AspNetCore.Views_Companies_Index))]
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
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/_ViewImports.cshtml"
using hirelonghorn.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbcfb7b73447e416f25c3d1f9f13b8b961b5486", @"/Views/Companies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<hirelonghorn.Models.Company>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompanySearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 32, true);
            WriteLiteral("\r\n<h2>Available Companies</h2>\r\n");
            EndContext();
#line 8 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
 if (User.IsInRole("CSO") || User.IsInRole("Student"))
{

#line default
#line hidden
            BeginContext(193, 36, true);
            WriteLiteral("    <p class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(229, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95e88deae25478eba7dce8f33975db6", async() => {
                BeginContext(282, 14, true);
                WriteLiteral("Search Company");
                EndContext();
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
            EndContext();
            BeginContext(300, 40, true);
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Displaying ");
            EndContext();
            BeginContext(341, 28, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
              Write(ViewBag.SelectedCompanyCount);

#line default
#line hidden
            EndContext();
            BeginContext(369, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(374, 23, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
                                               Write(ViewBag.AllCompanyCount);

#line default
#line hidden
            EndContext();
            BeginContext(397, 22, true);
            WriteLiteral(" Companies\r\n    </p>\r\n");
            EndContext();
#line 16 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
}

#line default
#line hidden
            BeginContext(422, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
 if (User.IsInRole("CSO"))
{

#line default
#line hidden
            BeginContext(455, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(472, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b332d66d4e44b1a6c5590bc6a16c92", async() => {
                BeginContext(495, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(509, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
}

#line default
#line hidden
            BeginContext(524, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(613, 47, false);
#line 30 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(716, 48, false);
#line 33 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyEmail));

#line default
#line hidden
            EndContext();
            BeginContext(764, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(820, 47, false);
#line 36 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(867, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(923, 44, false);
#line 39 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Industry));

#line default
#line hidden
            EndContext();
            BeginContext(967, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1102, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1163, 46, false);
#line 49 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1277, 47, false);
#line 52 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompanyEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1392, 46, false);
#line 55 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1506, 43, false);
#line 58 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Industry));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1616, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cad411d37d048f48396020954b1de19", async() => {
                BeginContext(1671, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
                                              WriteLiteral(item.CompanyID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1682, 46, true);
            WriteLiteral(" |\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Companies/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1739, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<hirelonghorn.Models.Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
