#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1562373515dfd6a12b8ec03d0478d161ede6733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Interviews_Index), @"mvc.1.0.view", @"/Views/Interviews/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Interviews/Index.cshtml", typeof(AspNetCore.Views_Interviews_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1562373515dfd6a12b8ec03d0478d161ede6733", @"/Views/Interviews/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Interviews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sp19team18finalproject.Models.Interview>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelInterview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectDateEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InterviewEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 121, true);
            WriteLiteral("\r\n<h2>Scheduled Interviews</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(226, 46, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(272, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(328, 49, false);
#line 17 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InterviewTime));

#line default
#line hidden
            EndContext();
            BeginContext(377, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(433, 58, false);
#line 20 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position.PositionTitle));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 57, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(660, 67, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Interviewer.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(727, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(862, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(911, 45, false);
#line 36 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(956, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 48, false);
#line 39 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InterviewTime));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1116, 57, false);
#line 42 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position.PositionTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1229, 56, false);
#line 45 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1341, 66, false);
#line 48 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Interviewer.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 51 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                 if (User.IsInRole("Student"))
                {

#line default
#line hidden
            BeginContext(1513, 41, true);
            WriteLiteral("                <p>\r\n                    ");
            EndContext();
            BeginContext(1554, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661c269b3aca44549ff41a9d95bf432b", async() => {
                BeginContext(1619, 16, true);
                WriteLiteral("Cancel Interview");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                                                      WriteLiteral(item.InterviewId);

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
            BeginContext(1639, 25, true);
            WriteLiteral("|\r\n                </p>\r\n");
            EndContext();
#line 56 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1683, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 57 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                 if (User.IsInRole("Recruiter")|| User.IsInRole("CSO"))
                {

#line default
#line hidden
            BeginContext(1775, 49, true);
            WriteLiteral("                    <p>\r\n                        ");
            EndContext();
            BeginContext(1824, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b20ccc1cb0b4877a7162e5fb0d26d70", async() => {
                BeginContext(1919, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                                                                                        WriteLiteral(item.InterviewId);

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
            BeginContext(1927, 29, true);
            WriteLiteral("|\r\n                    </p>\r\n");
            EndContext();
#line 62 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1975, 35, true);
            WriteLiteral("                 \r\n                ");
            EndContext();
            BeginContext(2010, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e245f670a376498fa85ae9990cb7cb2a", async() => {
                BeginContext(2067, 7, true);
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
#line 64 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
                                          WriteLiteral(item.InterviewId);

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
            BeginContext(2078, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(2170, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Interviews/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2215, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sp19team18finalproject.Models.Interview>> Html { get; private set; }
    }
}
#pragma warning restore 1591
