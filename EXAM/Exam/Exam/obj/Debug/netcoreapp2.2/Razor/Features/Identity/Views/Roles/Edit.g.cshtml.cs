#pragma checksum "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2ba1ec2749be85b6caf283d091760ae8ac901e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Identity_Views_Roles_Edit), @"mvc.1.0.view", @"/Features/Identity/Views/Roles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/Identity/Views/Roles/Edit.cshtml", typeof(AspNetCore.Features_Identity_Views_Roles_Edit))]
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
#line 1 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2ba1ec2749be85b6caf283d091760ae8ac901e", @"/Features/Identity/Views/Roles/Edit.cshtml")]
    public class Features_Identity_Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam.Features.Identity.Models.ChangeRoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 40, true);
            WriteLiteral(" \r\n<h2>Изменение ролей для пользователя ");
            EndContext();
            BeginContext(137, 15, false);
#line 4 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
                                Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(152, 88, true);
            WriteLiteral("</h2>\r\n \r\n<form asp-action=\"Edit\" method=\"post\">\r\n    <input type=\"hidden\" name=\"userId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 240, "\"", 261, 1);
#line 7 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 248, Model.UserId, 248, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(262, 35, true);
            WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n");
            EndContext();
#line 9 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
            BeginContext(364, 47, true);
            WriteLiteral("            <input type=\"checkbox\" name=\"roles\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 411, "\"", 429, 1);
#line 11 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 419, role.Name, 419, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(430, 21, true);
            WriteLiteral("\r\n                   ");
            EndContext();
            BeginContext(453, 64, false);
#line 12 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
               Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
            EndContext();
            BeginContext(518, 3, true);
            WriteLiteral(" />");
            EndContext();
            BeginContext(522, 9, false);
#line 12 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
                                                                                    Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(531, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 13 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Roles\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(551, 89, true);
            WriteLiteral("    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Сохранить</button>\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam.Features.Identity.Models.ChangeRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591