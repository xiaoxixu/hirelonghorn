#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d417fe31580bb48163f934aea5c85aaac8a60fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d417fe31580bb48163f934aea5c85aaac8a60fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sp19team18finalproject.Models.Application>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 28, true);
            WriteLiteral("<h2>LongHorn Hiring</h2>\r\n\r\n");
            EndContext();
#line 8 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
            BeginContext(179, 92, false);
#line 10 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
Write(Html.ActionLink("Set Time", "GoToSetTime", "Home", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(273, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(279, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
#line 12 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"

    if (User.IsInRole("Recruiter") || User.IsInRole("CSO"))
    {
        

#line default
#line hidden
            BeginContext(366, 105, false);
#line 15 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
   Write(Html.ActionLink("Create Interview", "SelectDate", "Interviews", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(473, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(483, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
#line 17 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"

    }

    if (User.IsInRole("CSO"))
    {
        

#line default
#line hidden
            BeginContext(549, 119, false);
#line 22 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
   Write(Html.ActionLink("Search For Interview", "InterviewSearch", "InterviewSearch", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(670, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(680, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(697, 102, false);
#line 24 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
   Write(Html.ActionLink("Register A Student", "Register", "Account", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(801, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(811, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(828, 113, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
   Write(Html.ActionLink("Register A Recruiter", "RegisterRecruiter", "Account", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(943, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(953, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(970, 101, false);
#line 28 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
   Write(Html.ActionLink("Register A CSO", "RegisterCSO", "Account", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1083, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(1100, 96, false);
#line 30 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
   Write(Html.ActionLink("Manager Users", "Index", "RoleAdmin", null, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
#line 30 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
                                                                                                         
    }
}
else
{
    

#line default
#line hidden
            BeginContext(1222, 85, false);
#line 35 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
Write(Html.ActionLink("Login", "Login", "Account", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
#line 35 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Home/Index.cshtml"
                                                                                          
}

#line default
#line hidden
            BeginContext(1312, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sp19team18finalproject.Models.Application>> Html { get; private set; }
    }
}
#pragma warning restore 1591