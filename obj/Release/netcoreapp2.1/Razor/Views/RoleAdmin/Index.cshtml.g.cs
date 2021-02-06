#pragma checksum "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b59f9e5bae098d6b8bd0851042330b243915969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleAdmin_Index), @"mvc.1.0.view", @"/Views/RoleAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleAdmin/Index.cshtml", typeof(AspNetCore.Views_RoleAdmin_Index))]
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
#line 1 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
using sp19team18finalproject.Models;

#line default
#line hidden
#line 2 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b59f9e5bae098d6b8bd0851042330b243915969", @"/Views/RoleAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be70581899bb91e26de9071675405d3f5320e39", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleEditModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(108, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
  
    ViewBag.Title = "Roles";

#line default
#line hidden
            BeginContext(143, 267, true);
            WriteLiteral(@"
<h2>Manage Users</h2>

<div class=""panel panel-primary"">
    <div class=""panel-heading"">Roles</div>
    <table class=""table table-striped"">
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Users</th>
            <th></th>
        </tr>
");
            EndContext();
#line 20 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
         if (Model.Count() == 0)
        { 

#line default
#line hidden
            BeginContext(454, 101, true);
            WriteLiteral("            <tr>\n                <td colspan=\"4\" class=\"text-center\">No roles</td>\n            </tr>\n");
            EndContext();
#line 25 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
        }
        else
        {
            foreach (RoleEditModel role in Model)
            {  

#line default
#line hidden
            BeginContext(654, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(700, 12, false);
#line 31 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                   Write(role.Role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(712, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(743, 14, false);
#line 32 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                   Write(role.Role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(757, 31, true);
            WriteLiteral("</td>\n                    <td>\n");
            EndContext();
#line 34 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                         if (role.Members == null || role.Members.Count() == 0)
                        { 

#line default
#line hidden
            BeginContext(895, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(925, 18, true);
            WriteLiteral(" No Users in role\n");
            EndContext();
#line 37 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                        }
                        else
                        { 

#line default
#line hidden
            BeginContext(1025, 31, true);
            WriteLiteral("                            <p>");
            EndContext();
            BeginContext(1057, 52, false);
#line 40 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                          Write(string.Join(", ", role.Members.Select(x => x.Email)));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 41 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1140, 75, true);
            WriteLiteral("                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1216, 94, false);
#line 44 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = role.Role.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 47 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1383, 20, true);
            WriteLiteral("    </table>\n</div>\n");
            EndContext();
            BeginContext(1404, 77, false);
#line 51 "/Users/xiaoxixu/Desktop/Past Semesters/Sp19/MIS333K/sp19team18finalprojectFinal!/sp19team18finalproject/Views/RoleAdmin/Index.cshtml"
Write(Html.ActionLink("Create", "Create", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleEditModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591