#pragma checksum "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afba3f934331c07467e29b2a3162dfa623ab7962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Identity_Views_Auth_ForgotPassword), @"mvc.1.0.view", @"/Features/Identity/Views/Auth/ForgotPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/Identity/Views/Auth/ForgotPassword.cshtml", typeof(AspNetCore.Features_Identity_Views_Auth_ForgotPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afba3f934331c07467e29b2a3162dfa623ab7962", @"/Features/Identity/Views/Auth/ForgotPassword.cshtml")]
    public class Features_Identity_Views_Auth_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam.Features.Identity.Models.ForgotPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ForgotPassword.cshtml"
  
    ViewData["Title"] = "Forgot your password?";

#line default
#line hidden
            BeginContext(119, 7, true);
            WriteLiteral(" \r\n<h2>");
            EndContext();
            BeginContext(127, 17, false);
#line 6 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ForgotPassword.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(144, 713, true);
            WriteLiteral(@"</h2>
<form asp-controller=""Auth"" asp-action=""ForgotPassword"" method=""post"" class=""form-horizontal"">
    <h4>Enter your email.</h4>
    <hr />
    <div asp-validation-summary=""All"" class=""text-danger""></div>
    <div class=""form-group"">
        <label asp-for=""Email"" class=""col-md-2 control-label""></label>
        <div class=""col-md-10"">
            <input asp-for=""Email"" class=""form-control"" />
            <span asp-validation-for=""Email"" class=""text-danger""></span>
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <button type=""submit"" class=""btn btn-default"">Submit</button>
        </div>
    </div>
</form>

<script>
");
            EndContext();
#line 26 "C:\Users\asyag\source\repos\Exam\Exam\Features\Identity\Views\Auth\ForgotPassword.cshtml"
       await Html.RenderPartialAsync("~/Common/Shared/_ValidationScriptsPartial.cshtml"); 

#line default
#line hidden
            BeginContext(950, 9, true);
            WriteLiteral("</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam.Features.Identity.Models.ForgotPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
