#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcfc8cfd66a4b133a7b3be7cabe5e27786a2322b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ChangePassword.cshtml", typeof(AspNetCore.Views_Account_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcfc8cfd66a4b133a7b3be7cabe5e27786a2322b", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChangePasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 27, true);
            WriteLiteral("\n<h2>Change Password</h2>\n\n");
            EndContext();
#line 5 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
 using (Html.BeginForm("ChangePassword", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(186, 23, false);
#line 7 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(210, 45, true);
            WriteLiteral("    <h4>Change Password Form</h4>\n    <hr />\n");
            EndContext();
            BeginContext(260, 58, false);
#line 10 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(319, 37, true);
            WriteLiteral("    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(357, 76, false);
#line 12 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
   Write(Html.LabelFor(m => m.OldPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(433, 45, true);
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
            EndContext();
            BeginContext(479, 69, false);
#line 14 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.OldPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(548, 64, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(613, 76, false);
#line 18 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
   Write(Html.LabelFor(m => m.NewPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(689, 45, true);
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
            EndContext();
            BeginContext(735, 69, false);
#line 20 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(804, 64, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(869, 80, false);
#line 24 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(949, 45, true);
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
            EndContext();
            BeginContext(995, 73, false);
#line 26 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 213, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Change password\" class=\"btn btn-danger\" />\n        </div>\n    </div>\n");
            EndContext();
#line 34 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/ChangePassword.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
