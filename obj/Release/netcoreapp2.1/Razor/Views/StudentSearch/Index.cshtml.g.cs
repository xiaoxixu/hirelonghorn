#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc73b438a137c32d1ca82b5ce924191f9aee370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentSearch_Index), @"mvc.1.0.view", @"/Views/StudentSearch/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentSearch/Index.cshtml", typeof(AspNetCore.Views_StudentSearch_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc73b438a137c32d1ca82b5ce924191f9aee370", @"/Views/StudentSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sp19team18finalproject.Models.AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StudentSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfferInterview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deactivate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reactivate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CSOEditStudentProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 25, true);
            WriteLiteral("<h2>Student List</h2>\r\n\r\n");
            EndContext();
            BeginContext(125, 303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e52c59ec474f60b90e7cbbee383a2c", async() => {
                BeginContext(194, 38, true);
                WriteLiteral("\r\n    <p class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(232, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34b4417cc124206b80f4a55a5aeed88", async() => {
                    BeginContext(285, 14, true);
                    WriteLiteral("Search Student");
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
                BeginContext(303, 40, true);
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Displaying ");
                EndContext();
                BeginContext(344, 28, false);
#line 12 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
              Write(ViewBag.SelectedStudentCount);

#line default
#line hidden
                EndContext();
                BeginContext(372, 4, true);
                WriteLiteral(" of ");
                EndContext();
                BeginContext(377, 23, false);
#line 12 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                                               Write(ViewBag.AllStudentCount);

#line default
#line hidden
                EndContext();
                BeginContext(400, 21, true);
                WriteLiteral(" Students\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(428, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(521, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(606, 45, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(651, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(707, 44, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(751, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(807, 41, false);
#line 29 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(848, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(904, 50, false);
#line 32 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GraduationDate));

#line default
#line hidden
            EndContext();
            BeginContext(954, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1010, 51, false);
#line 35 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Major.MajorName));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1117, 39, false);
#line 38 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GPA));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1212, 48, false);
#line 41 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1395, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1444, 44, false);
#line 51 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1544, 43, false);
#line 54 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1643, 40, false);
#line 57 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1739, 49, false);
#line 60 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GraduationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1844, 50, false);
#line 63 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Major.MajorName));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1950, 38, false);
#line 66 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GPA));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2044, 47, false);
#line 69 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 71 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
             if (User.IsInRole("Recruiter"))
            {


#line default
#line hidden
            BeginContext(2175, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2217, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "764ea44a73454e9db513090b309cbe9e", async() => {
                BeginContext(2302, 15, true);
                WriteLiteral("Offer Interview");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                                                                                   WriteLiteral(item.Id);

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
            BeginContext(2321, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 77 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                
                }

#line default
#line hidden
            BeginContext(2383, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 79 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
             if (User.IsInRole("CSO"))
            {
                

#line default
#line hidden
#line 81 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                 if (item.Active == true)
                {

#line default
#line hidden
            BeginContext(2500, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2550, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85f264dab9d54aa897d43a680459094f", async() => {
                BeginContext(2626, 10, true);
                WriteLiteral("Deactivate");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                                                                              WriteLiteral(item.Id);

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
            BeginContext(2640, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 86 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                }

#line default
#line hidden
#line 87 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                 if (item.Active == false)
                {

#line default
#line hidden
            BeginContext(2751, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2801, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d840ee08caa34676bfc95992f9a09ca0", async() => {
                BeginContext(2877, 10, true);
                WriteLiteral("Reactivate");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                                                                              WriteLiteral(item.Id);

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
            BeginContext(2891, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 92 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                }

#line default
#line hidden
#line 93 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                 if (User.IsInRole("CSO"))
                {

#line default
#line hidden
            BeginContext(3002, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(3052, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "295d583f2c07491392460611d20dee7b", async() => {
                BeginContext(3139, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                                                                                         WriteLiteral(item.Id);

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
            BeginContext(3147, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 98 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                }

#line default
#line hidden
#line 98 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
                 

            }


            

#line default
#line hidden
            BeginContext(3343, 17, true);
            WriteLiteral("\r\n        </tr>\r\n");
            EndContext();
#line 109 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/StudentSearch/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3371, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sp19team18finalproject.Models.AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591