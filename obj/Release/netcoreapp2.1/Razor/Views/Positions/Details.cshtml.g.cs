#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96d9dc536ca9df1aa360db16f5606dfc32f2247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Positions_Details), @"mvc.1.0.view", @"/Views/Positions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Positions/Details.cshtml", typeof(AspNetCore.Views_Positions_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96d9dc536ca9df1aa360db16f5606dfc32f2247", @"/Views/Positions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Positions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hirelonghorn.Models.Position>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Apply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(92, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Position</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(215, 49, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PositionTitle));

#line default
#line hidden
            EndContext();
            BeginContext(264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(308, 45, false);
#line 17 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.PositionTitle));

#line default
#line hidden
            EndContext();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(397, 47, false);
#line 20 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(488, 43, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(531, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(575, 48, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(667, 44, false);
#line 29 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.PositionType));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 44, false);
#line 32 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(799, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(843, 40, false);
#line 35 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(927, 55, false);
#line 38 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(982, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1026, 51, false);
#line 41 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1121, 52, false);
#line 44 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.Industry));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1217, 48, false);
#line 47 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.Industry));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1309, 44, false);
#line 50 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1397, 40, false);
#line 53 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
       Write(Html.DisplayFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 170, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<h5>Applicable Majors for this Position</h5>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Major Name</th>\r\n    </tr>\r\n");
            EndContext();
#line 62 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
     foreach (MajorPosition cd in Model.MajorPositions)
    {

#line default
#line hidden
            BeginContext(1671, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1702, 18, false);
#line 65 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
           Write(cd.Major.MajorName);

#line default
#line hidden
            EndContext();
            BeginContext(1720, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 67 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"

    }

#line default
#line hidden
            BeginContext(1751, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
#line 70 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
 if (User.IsInRole("CSO") || User.IsInRole("Recruiter"))
{

#line default
#line hidden
            BeginContext(1822, 166, true);
            WriteLiteral("    <h5>Applicable Interview Date for Each Position</h5>\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>Interview Date</th>\r\n        </tr>\r\n");
            EndContext();
#line 77 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
         foreach (Interview cd in Model.Interviews)
        {

#line default
#line hidden
            BeginContext(2052, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(2091, 16, false);
#line 80 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
               Write(cd.InterviewTime);

#line default
#line hidden
            EndContext();
            BeginContext(2107, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 82 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"

        }

#line default
#line hidden
            BeginContext(2146, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 85 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
}

#line default
#line hidden
            BeginContext(2163, 13, true);
            WriteLiteral("\r\n\r\n<div>\r\n\r\n");
            EndContext();
#line 90 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
     if (User.IsInRole("CSO") || User.IsInRole("Recruiter"))
    {

#line default
#line hidden
            BeginContext(2245, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(2270, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d65d9418c559469985be1dfec1ee962e", async() => {
                BeginContext(2324, 4, true);
                WriteLiteral("Edit");
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
#line 93 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
                                   WriteLiteral(Model.PositionID);

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
            BeginContext(2332, 18, true);
            WriteLiteral(" |\r\n        </p>\r\n");
            EndContext();
#line 95 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2357, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 97 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
     if (User.IsInRole("Student"))
    {

#line default
#line hidden
            BeginContext(2402, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(2427, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34762bbca86a468ab3234cac5bb452f7", async() => {
                BeginContext(2482, 5, true);
                WriteLiteral("Apply");
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
#line 100 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
                                    WriteLiteral(Model.PositionID);

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
            BeginContext(2491, 18, true);
            WriteLiteral(" |\r\n        </p>\r\n");
            EndContext();
#line 102 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Positions/Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2516, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2522, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95542e3090164ba5ab5efdb1d3ebc95b", async() => {
                BeginContext(2544, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2560, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hirelonghorn.Models.Position> Html { get; private set; }
    }
}
#pragma warning restore 1591
