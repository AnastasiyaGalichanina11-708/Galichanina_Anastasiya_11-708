#pragma checksum "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ResetPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a36b9c228a4c95282244379e8830bffb0b2065f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Identity_Views_Auth_ResetPasswordConfirmation), @"mvc.1.0.view", @"/Features/Identity/Views/Auth/ResetPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/Identity/Views/Auth/ResetPasswordConfirmation.cshtml", typeof(AspNetCore.Features_Identity_Views_Auth_ResetPasswordConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a36b9c228a4c95282244379e8830bffb0b2065f", @"/Features/Identity/Views/Auth/ResetPasswordConfirmation.cshtml")]
    public class Features_Identity_Views_Auth_ResetPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ResetPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Reset password confirmation";

#line default
#line hidden
            BeginContext(63, 7, true);
            WriteLiteral(" \r\n<h2>");
            EndContext();
            BeginContext(71, 17, false);
#line 5 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ResetPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 106, true);
            WriteLiteral("</h2>\r\n<p>\r\n    Your password has been reset. Please <a asp-action=\"Login\">click here to log in</a>.\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
