#pragma checksum "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96dd798026053e5e6a7bb2d9dd3cd2970ce8736c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserView_WeeklyMenu), @"mvc.1.0.view", @"/Views/UserView/WeeklyMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserView/WeeklyMenu.cshtml", typeof(AspNetCore.Views_UserView_WeeklyMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96dd798026053e5e6a7bb2d9dd3cd2970ce8736c", @"/Views/UserView/WeeklyMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserView_WeeklyMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Receita>>
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
#line 2 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
  
    ViewData["Title"] = "Weekly Menu";

#line default
#line hidden
            BeginContext(99, 122, true);
            WriteLiteral("\r\n<h1>Weekly Menu</h1>\r\n<hr />\r\n\r\n<div style=\"margin-top: 60px\" align=\"center\">\r\n    <h2><p>Recipes Available</p></h2>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(262, 39, true);
            WriteLiteral("        <p style=\"margin-top:40px\"><h4>");
            EndContext();
            BeginContext(302, 9, false);
#line 14 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                                  Write(user.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(311, 37, true);
            WriteLiteral("</h4></p>\r\n        <b>Dificulty: </b>");
            EndContext();
            BeginContext(349, 16, false);
#line 15 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                     Write(user.Dificuldade);

#line default
#line hidden
            EndContext();
            BeginContext(367, 100, true);
            WriteLiteral("        <i class=\"fa fa-dot-circle-o title-icon\" aria-hidden=\"true\"></i>\r\n        <b>Nutrition: </b>");
            EndContext();
            BeginContext(468, 13, false);
#line 17 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                     Write(user.Nutricao);

#line default
#line hidden
            EndContext();
            BeginContext(483, 102, true);
            WriteLiteral("        <i class=\"fa fa-dot-circle-o title-icon\" aria-hidden=\"true\"></i>\r\n        <b>Description: </b>");
            EndContext();
            BeginContext(586, 24, false);
#line 19 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                       Write(user.Categoria.Descricao);

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                                                     
    }

#line default
#line hidden
            BeginContext(619, 149, true);
            WriteLiteral("</div>\r\n\r\n<section class=\"section\" style=\"margin-top: 60px\">\r\n    <h2><p class=\"text-center\">Define your menu</p></h2>\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 26 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(822, 43, true);
            WriteLiteral("            <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(866, 19, false);
#line 28 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                                      Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(885, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 29 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
        }

#line default
#line hidden
            BeginContext(902, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 30 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
         if (TempData["Fail"] != null)
        {

#line default
#line hidden
            BeginContext(953, 42, true);
            WriteLiteral("            <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(996, 16, false);
#line 32 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
                                     Write(TempData["Fail"]);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 33 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
        }

#line default
#line hidden
            BeginContext(1029, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 34 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
         using (Html.BeginForm("WeeMenu", "UserView", new
        {
            initialDate = ViewBag.initialDate,
            finalDate = ViewBag.finalDate,
            segunda = ViewBag.segunda,
            terca = ViewBag.terca,
            quarta = ViewBag.quarta,
            quinta = ViewBag.quinta,
            sexta = ViewBag.sexta,
            sabado = ViewBag.sabado,
            domingo = ViewBag.domingo
        }, FormMethod.Post))
        {
            

#line default
#line hidden
            BeginContext(1510, 28, false);
#line 47 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 242, true);
            WriteLiteral("            <div class=\"row philosophy\">\r\n\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 25px\">\r\n                    <p><b>Initial date</b></p>\r\n                    <input type=\"date\" name=\"initialDate\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1782, "", 1809, 1);
#line 52 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 1789, ViewBag.initialDate, 1789, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1809, 232, true);
            WriteLiteral(" required />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 25px\">\r\n                    <p><b>Final date</b></p>\r\n                    <input type=\"date\" name=\"finalDate\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2041, "", 2066, 1);
#line 56 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 2048, ViewBag.finalDate, 2048, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2066, 231, true);
            WriteLiteral(" required />\r\n                </div>\r\n\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 25px\">\r\n                    <p><b>First Day</b></p>\r\n                    <input type=\"text\" name=\"segunda\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2297, "", 2320, 1);
#line 61 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 2304, ViewBag.segunda, 2304, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2320, 219, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 25px\">\r\n                    <p><b>Second Day</b></p>\r\n                    <input type=\"text\" name=\"terca\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2539, "", 2560, 1);
#line 65 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 2546, ViewBag.terca, 2546, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2560, 219, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 50px\">\r\n                    <p><b>Third Day</b></p>\r\n                    <input type=\"text\" name=\"quarta\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2779, "", 2801, 1);
#line 69 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 2786, ViewBag.quarta, 2786, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2801, 220, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 50px\">\r\n                    <p><b>Fourth Day</b></p>\r\n                    <input type=\"text\" name=\"quinta\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3021, "", 3043, 1);
#line 73 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 3028, ViewBag.quinta, 3028, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3043, 218, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 50px\">\r\n                    <p><b>Fifth Day</b></p>\r\n                    <input type=\"text\" name=\"sexta\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3261, "", 3282, 1);
#line 77 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 3268, ViewBag.sexta, 3268, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3282, 219, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 50px\">\r\n                    <p><b>Sixth Say</b></p>\r\n                    <input type=\"text\" name=\"sabado\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3501, "", 3523, 1);
#line 81 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 3508, ViewBag.sabado, 3508, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3523, 222, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-6 philosophy-item text-center\" style=\"margin-top: 50px\">\r\n                    <p><b>Seventh Day</b></p>\r\n                    <input type=\"text\" name=\"domingo\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3745, "", 3768, 1);
#line 85 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
WriteAttributeValue("", 3752, ViewBag.domingo, 3752, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3768, 218, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div>\r\n                    <input style=\"margin-left:-45px\" type=\"submit\" value=\"Submit\" class=\"btn btn-default btn-primary\" />\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 91 "C:\Users\ASUS\source\repos\WebApplication3\WebApplication3\Views\UserView\WeeklyMenu.cshtml"
        }

#line default
#line hidden
            BeginContext(3997, 68, true);
            WriteLiteral("    </div>\r\n</section>\r\n\r\n<p align=\"right\" style=\"margin-top: 30px\">");
            EndContext();
            BeginContext(4065, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96dd798026053e5e6a7bb2d9dd3cd2970ce8736c15585", async() => {
                BeginContext(4117, 4, true);
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
            BeginContext(4125, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
