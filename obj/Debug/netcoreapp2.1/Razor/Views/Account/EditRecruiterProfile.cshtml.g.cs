#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a42f820afa4f726d0e6d13a2de996850d891e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditRecruiterProfile), @"mvc.1.0.view", @"/Views/Account/EditRecruiterProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/EditRecruiterProfile.cshtml", typeof(AspNetCore.Views_Account_EditRecruiterProfile))]
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
#line 1 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
using hirelonghorn.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a42f820afa4f726d0e6d13a2de996850d891e6", @"/Views/Account/EditRecruiterProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditRecruiterProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditRecruiterProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
  
    ViewBag.Title = "Edit Recruiter";

#line default
#line hidden
            BeginContext(127, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(134, 13, false);
#line 7 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(147, 12, true);
            WriteLiteral(".</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
 using (Html.BeginForm("EditRecruiterProfile", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

    

#line default
#line hidden
            BeginContext(297, 23, false);
#line 13 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(322, 55, true);
            WriteLiteral("    <h4>Edit your recruiter profile.</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(382, 58, false);
#line 16 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(442, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(451, 13, false);
#line 17 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(464, 45, true);
            WriteLiteral("</h4>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(510, 70, false);
#line 19 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(580, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(628, 62, false);
#line 21 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(690, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(785, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(824, 74, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(898, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(946, 66, false);
#line 28 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1081, 73, false);
#line 32 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1202, 65, false);
#line 34 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1629, 180, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-danger\" value=\"Save\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 50 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/EditRecruiterProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditRecruiterProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
