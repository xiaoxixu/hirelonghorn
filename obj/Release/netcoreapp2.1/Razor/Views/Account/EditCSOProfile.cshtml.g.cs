#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf8615007a84bdaaffda9e293106b44e53810afa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditCSOProfile), @"mvc.1.0.view", @"/Views/Account/EditCSOProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/EditCSOProfile.cshtml", typeof(AspNetCore.Views_Account_EditCSOProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf8615007a84bdaaffda9e293106b44e53810afa", @"/Views/Account/EditCSOProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditCSOProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditCSOProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
  
    ViewBag.Title = "Edit CSO";

#line default
#line hidden
            BeginContext(72, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(79, 13, false);
#line 6 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(92, 10, true);
            WriteLiteral(".</h2>\r\n\r\n");
            EndContext();
#line 8 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
 using (Html.BeginForm("EditCSOProfile", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(232, 23, false);
#line 10 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(257, 49, true);
            WriteLiteral("    <h4>Edit your CSO profile.</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(311, 58, false);
#line 13 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(371, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(380, 13, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(393, 45, true);
            WriteLiteral("</h4>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(439, 70, false);
#line 16 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(509, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(557, 62, false);
#line 18 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(619, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(712, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(751, 74, false);
#line 23 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(825, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(873, 66, false);
#line 25 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(939, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1008, 73, false);
#line 29 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1129, 65, false);
#line 31 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 210, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-danger\" value=\"Save\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 39 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/Account/EditCSOProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditCSOProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
