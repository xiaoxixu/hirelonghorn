#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fb962e772e5927c7e07fbd4909f4f4306270a18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_Index), @"mvc.1.0.view", @"/Views/Applications/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Applications/Index.cshtml", typeof(AspNetCore.Views_Applications_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb962e772e5927c7e07fbd4909f4f4306270a18", @"/Views/Applications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Applications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sp19team18finalproject.Models.Application>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Withdraw", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfferInterviewForApp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Decline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 35, true);
            WriteLiteral("\r\n<h2>Submitted Applications</h2>\r\n");
            EndContext();
#line 9 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
 if (User.IsInRole("Student") || User.IsInRole("CSO"))

{


#line default
#line hidden
            BeginContext(206, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(311, 46, false);
#line 17 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.StatusType));

#line default
#line hidden
            EndContext();
            BeginContext(357, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(425, 51, false);
#line 20 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ApplicationDate));

#line default
#line hidden
            EndContext();
            BeginContext(476, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(544, 64, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Position.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(608, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(676, 58, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Position.PositionTitle));

#line default
#line hidden
            EndContext();
            BeginContext(734, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 32 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(897, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(970, 45, false);
#line 36 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StatusType));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1095, 50, false);
#line 39 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ApplicationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1225, 63, false);
#line 42 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Position.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1368, 57, false);
#line 45 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Position.PositionTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1504, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1f03640dff4ba88850be0ac656602d", async() => {
                BeginContext(1563, 7, true);
                WriteLiteral("Details");
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
#line 48 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                                                  WriteLiteral(item.ApplicationID);

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
            BeginContext(1574, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
#line 49 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                         if (User.IsInRole("Student"))
    {

#line default
#line hidden
            BeginContext(1641, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1661, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d8cf779077441d8cc61899cc22183e", async() => {
                BeginContext(1721, 8, true);
                WriteLiteral("Withdraw");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                                               WriteLiteral(item.ApplicationID);

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
            BeginContext(1733, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1738, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1805, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 59 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1849, 136, true);
            WriteLiteral("    <table class=\"table\">\r\n        \r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    \r\n                    ");
            EndContext();
            BeginContext(1986, 53, false);
#line 68 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2107, 52, false);
#line 71 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2227, 49, false);
#line 74 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2344, 58, false);
#line 77 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.GraduationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2470, 59, false);
#line 80 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.Major.MajorName));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2597, 47, false);
#line 83 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.GPA));

#line default
#line hidden
            EndContext();
            BeginContext(2644, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2712, 56, false);
#line 86 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppUser.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(2768, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 92 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
             foreach (var item in Model)
    {
        

#line default
#line hidden
            BeginContext(2932, 44, false);
#line 94 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
   Write(Html.HiddenFor(modelItem => item.AppUser.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2987, 47, false);
#line 95 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
   Write(Html.HiddenFor(modelItem => item.ApplicationID));

#line default
#line hidden
            EndContext();
            BeginContext(3036, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3085, 52, false);
#line 98 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3137, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3193, 51, false);
#line 101 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(3244, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3300, 48, false);
#line 104 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3348, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3404, 57, false);
#line 107 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.GraduationDate));

#line default
#line hidden
            EndContext();
            BeginContext(3461, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3517, 58, false);
#line 110 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.Major.MajorName));

#line default
#line hidden
            EndContext();
            BeginContext(3575, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3631, 46, false);
#line 113 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.GPA));

#line default
#line hidden
            EndContext();
            BeginContext(3677, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3733, 55, false);
#line 116 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppUser.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(3788, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3843, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f39301d3dd49eca82c4c3a170658ef", async() => {
                BeginContext(3945, 15, true);
                WriteLiteral("Offer Interview");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                                                                                     WriteLiteral(item.ApplicationID);

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
            BeginContext(3964, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3982, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d36882e220f4651b7ccccca2bd65033", async() => {
                BeginContext(4071, 19, true);
                WriteLiteral("Decline Application");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
                                                                        WriteLiteral(item.ApplicationID);

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
            BeginContext(4094, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(4242, 17, true);
            WriteLiteral("\r\n        </tr>\r\n");
            EndContext();
#line 128 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"
}

#line default
#line hidden
            BeginContext(4262, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 131 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Applications/Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sp19team18finalproject.Models.Application>> Html { get; private set; }
    }
}
#pragma warning restore 1591
