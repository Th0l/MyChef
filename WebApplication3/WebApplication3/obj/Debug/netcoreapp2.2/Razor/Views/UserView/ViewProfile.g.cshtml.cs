#pragma checksum "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3349f255de128992cd98b3a1de4ab473921400cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserView_ViewProfile), @"mvc.1.0.view", @"/Views/UserView/ViewProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserView/ViewProfile.cshtml", typeof(AspNetCore.Views_UserView_ViewProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3349f255de128992cd98b3a1de4ab473921400cd", @"/Views/UserView/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserView_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Utilizador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getOpcoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml"
  
    ViewData["Title"] = "ViewProfile";

#line default
#line hidden
            BeginContext(102, 102, true);
            WriteLiteral("\r\n<div class=\"text-center\" style=\"margin-top: 100px\" align=\"center\">\r\n    <h1><p>Profile:</p></h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(245, 25, true);
            WriteLiteral("        <p><b>Name:</b>  ");
            EndContext();
            BeginContext(271, 9, false);
#line 11 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml"
                    Write(user.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(280, 32, true);
            WriteLiteral("</p>\r\n        <p><b>Email:</b>  ");
            EndContext();
            BeginContext(313, 10, false);
#line 12 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml"
                     Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(323, 31, true);
            WriteLiteral("</p>\r\n        <p><b>Diet:</b>  ");
            EndContext();
            BeginContext(355, 25, false);
#line 13 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml"
                    Write(user.RegimeAlimentar.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(380, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\ViewProfile.cshtml"
    }

#line default
#line hidden
            BeginContext(393, 53, true);
            WriteLiteral("\r\n</div>\r\n<p align=\"right\" style=\"margin-top: 150px\">");
            EndContext();
            BeginContext(446, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3349f255de128992cd98b3a1de4ab473921400cd5628", async() => {
                BeginContext(498, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(506, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Utilizador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
