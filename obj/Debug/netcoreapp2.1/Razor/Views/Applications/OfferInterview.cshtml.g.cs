#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c86b0db0d3b2b0f942cb1c19d4dbe8c753bed35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_OfferInterview), @"mvc.1.0.view", @"/Views/Applications/OfferInterview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Applications/OfferInterview.cshtml", typeof(AspNetCore.Views_Applications_OfferInterview))]
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
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/_ViewImports.cshtml"
using sp19team18finalproject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c86b0db0d3b2b0f942cb1c19d4dbe8c753bed35", @"/Views/Applications/OfferInterview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Applications_OfferInterview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sp19team18finalproject.Models.AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfferInterview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
  
    ViewData["Title"] = "Choose Position";

#line default
#line hidden
            BeginContext(97, 87, true);
            WriteLiteral("\r\n<h2>Choose Position</h2>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(184, 1192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf515967fe24b8c9c9dd27581db06b8", async() => {
                BeginContext(232, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(246, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "484053ecbcfd4a3290110960b4c69235", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 12 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(312, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(327, 33, false);
#line 13 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(360, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(375, 40, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
       Write(Html.HiddenFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(415, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(430, 39, false);
#line 15 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
       Write(Html.HiddenFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(469, 84, true);
                WriteLiteral("\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(554, 45, false);
#line 18 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(599, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(667, 41, false);
#line 21 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(708, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(776, 44, false);
#line 24 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(820, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(888, 40, false);
#line 27 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(928, 167, true);
                WriteLiteral("\r\n                </dd>\r\n                \r\n            </dl>\r\n            <div class=\"form-group\">\r\n                <label>Select a Position:</label>\r\n                ");
                EndContext();
                BeginContext(1096, 104, false);
#line 33 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/OfferInterview.cshtml"
           Write(Html.DropDownList("SelectedPosition", (SelectList)ViewBag.AllPositions, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1200, 169, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-danger\" />\r\n\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1376, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1411, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51a5b2bfee94724bccd6ed7c98b922d", async() => {
                BeginContext(1433, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1449, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sp19team18finalproject.Models.AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591