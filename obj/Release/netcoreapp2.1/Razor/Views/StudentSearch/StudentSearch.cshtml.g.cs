#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf878419178a3000906e245b5fb8f03c9a3402df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentSearch_StudentSearch), @"mvc.1.0.view", @"/Views/StudentSearch/StudentSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentSearch/StudentSearch.cshtml", typeof(AspNetCore.Views_StudentSearch_StudentSearch))]
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
#line 1 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
using hirelonghorn.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf878419178a3000906e245b5fb8f03c9a3402df", @"/Views/StudentSearch/StudentSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentSearch_StudentSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayStudentSearchResults", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StudentSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
  
    ViewData["Title"] = "StudentSearch";

#line default
#line hidden
            BeginContext(92, 30, true);
            WriteLiteral("<h2>Search for Students</h2>\r\n");
            EndContext();
            BeginContext(122, 1842, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5835fd46fad34852912cd0c959d04393", async() => {
                BeginContext(213, 394, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label>Search Student First Name:</label>
        <input name=""SearchFirstName"" class=""form-control"" />
    </div>

    <div class=""form-group"">
        <label>Search Student Last Name:</label>
        <input name=""SearchLastName"" class=""form-control"" />
    </div>

    <div class=""form-group"">
        <label>Select a Major:</label>
        ");
                EndContext();
                BeginContext(608, 98, false);
#line 19 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
   Write(Html.DropDownList("SelectedMajor", (SelectList)ViewBag.AllMajors, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(706, 71, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        Graduation Year: ");
                EndContext();
                BeginContext(778, 75, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                    Write(Html.TextBox("SearchGraduationYear", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(853, 26, true);
                WriteLiteral(" <div class=\"text-danger\">");
                EndContext();
                BeginContext(880, 15, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                                                                                                                          Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(895, 37, true);
                WriteLiteral("</div>\r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(933, 61, false);
#line 24 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedYearRange", YearRange.Before, true));

#line default
#line hidden
                EndContext();
                BeginContext(994, 45, true);
                WriteLiteral("Before</label>\r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(1040, 54, false);
#line 25 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedYearRange", YearRange.After));

#line default
#line hidden
                EndContext();
                BeginContext(1094, 72, true);
                WriteLiteral("After</label>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        GPA: ");
                EndContext();
                BeginContext(1167, 64, false);
#line 29 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
        Write(Html.TextBox("SearchGPA", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1231, 26, true);
                WriteLiteral(" <div class=\"text-danger\">");
                EndContext();
                BeginContext(1258, 15, false);
#line 29 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                                                                                                   Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1273, 40, true);
                WriteLiteral("</div>   \r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(1314, 64, false);
#line 30 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedGPARange", GPARange.GreaterThan, true));

#line default
#line hidden
                EndContext();
                BeginContext(1378, 51, true);
                WriteLiteral("Greater Than</label>\r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(1430, 55, false);
#line 31 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedGPARange", GPARange.LessThan));

#line default
#line hidden
                EndContext();
                BeginContext(1485, 92, true);
                WriteLiteral("Less Than</label>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(1578, 66, false);
#line 35 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedPositionType", Classification.ALL, true));

#line default
#line hidden
                EndContext();
                BeginContext(1644, 42, true);
                WriteLiteral("All</label>\r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(1687, 59, false);
#line 36 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedPositionType", Classification.FT));

#line default
#line hidden
                EndContext();
                BeginContext(1746, 48, true);
                WriteLiteral("Full Time</label>\r\n        <label class=\"radio\">");
                EndContext();
                BeginContext(1795, 58, false);
#line 37 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/StudentSearch/StudentSearch.cshtml"
                        Write(Html.RadioButton("SelectedPositionType", Classification.I));

#line default
#line hidden
                EndContext();
                BeginContext(1853, 104, true);
                WriteLiteral("Internship</label>\r\n\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-danger\">Search</button>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(1964, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
