#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478eb17fe4f453a0e6088bc05863e90053f72e71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CSOEditStudentProfile), @"mvc.1.0.view", @"/Views/Account/CSOEditStudentProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/CSOEditStudentProfile.cshtml", typeof(AspNetCore.Views_Account_CSOEditStudentProfile))]
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
#line 1 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
using hirelonghorn.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478eb17fe4f453a0e6088bc05863e90053f72e71", @"/Views/Account/CSOEditStudentProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CSOEditStudentProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditStudentProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
  
    ViewBag.Title = "Edit Student Profile";

#line default
#line hidden
            BeginContext(131, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(138, 13, false);
#line 7 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(151, 10, true);
            WriteLiteral(".</h2>\r\n\r\n");
            EndContext();
#line 9 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
 using (Html.BeginForm("CSOEditStudentProfile", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

    

#line default
#line hidden
            BeginContext(300, 23, false);
#line 12 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(325, 50, true);
            WriteLiteral("    <h4>Edit a student profile.</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(380, 58, false);
#line 15 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(440, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(449, 13, false);
#line 16 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(462, 45, true);
            WriteLiteral("</h4>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(508, 70, false);
#line 18 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(578, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(626, 62, false);
#line 20 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(688, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(783, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(822, 74, false);
#line 25 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(896, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(944, 66, false);
#line 27 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1079, 73, false);
#line 31 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1200, 65, false);
#line 33 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1297, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1336, 79, false);
#line 38 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.GraduationDate, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1463, 77, false);
#line 40 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
       Write(Html.TextBoxFor(m => m.GraduationDate, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 39, true);
            WriteLiteral("\r\n            <div class=\"text-danger\">");
            EndContext();
            BeginContext(1580, 16, false);
#line 41 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
                                Write(ViewBag.Message6);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 36, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1634, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1673, 70, false);
#line 46 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.Major, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1791, 98, false);
#line 48 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
       Write(Html.DropDownList("SelectedMajor", (SelectList)ViewBag.AllMajors, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1968, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2007, 77, false);
#line 54 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.PositionType, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 56 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
         if (Model.PositionType == Classification.FT)
        {

#line default
#line hidden
            BeginContext(2154, 33, true);
            WriteLiteral("            <label class=\"radio\">");
            EndContext();
            BeginContext(2188, 65, false);
#line 58 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
                            Write(Html.RadioButton("SelectedPositionType", Classification.FT, true));

#line default
#line hidden
            EndContext();
            BeginContext(2253, 56, true);
            WriteLiteral("FT(Full Time)</label>\r\n            <label class=\"radio\">");
            EndContext();
            BeginContext(2310, 58, false);
#line 59 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
                            Write(Html.RadioButton("SelectedPositionType", Classification.I));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 23, true);
            WriteLiteral("I(Internship)</label>\r\n");
            EndContext();
#line 60 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2427, 33, true);
            WriteLiteral("            <label class=\"radio\">");
            EndContext();
            BeginContext(2461, 59, false);
#line 63 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
                            Write(Html.RadioButton("SelectedPositionType", Classification.FT));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 56, true);
            WriteLiteral("FT(Full Time)</label>\r\n            <label class=\"radio\">");
            EndContext();
            BeginContext(2577, 64, false);
#line 64 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
                            Write(Html.RadioButton("SelectedPositionType", Classification.I, true));

#line default
#line hidden
            EndContext();
            BeginContext(2641, 23, true);
            WriteLiteral("I(Internship)</label>\r\n");
            EndContext();
#line 65 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
        }

#line default
#line hidden
            BeginContext(2675, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(2695, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2734, 68, false);
#line 72 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
   Write(Html.LabelFor(m => m.GPA, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2802, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(2850, 66, false);
#line 74 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
       Write(Html.TextBoxFor(m => m.GPA, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 39, true);
            WriteLiteral("\r\n            <div class=\"text-danger\">");
            EndContext();
            BeginContext(2956, 16, false);
#line 75 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
                                Write(ViewBag.Message5);

#line default
#line hidden
            EndContext();
            BeginContext(2972, 216, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-danger\" value=\"Save\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 83 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/hirelonghornFinal!/hirelonghorn/Views/Account/CSOEditStudentProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditStudentProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
