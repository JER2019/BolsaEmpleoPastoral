#pragma checksum "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e05863253ef6d4423da66b97ed6946b4828d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\_ViewImports.cshtml"
using PastoralEmpleo;

#line default
#line hidden
#line 2 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\_ViewImports.cshtml"
using PastoralEmpleo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e05863253ef6d4423da66b97ed6946b4828d76", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m-t-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

    Layout = "~/Views/Shared/LayoutSecondary.cshtml";

#line default
#line hidden
            BeginContext(98, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n  ");
            EndContext();
            BeginContext(129, 3392, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54f3b6162563492d85e1abf7b4e0f596", async() => {
                BeginContext(135, 548, true);
                WriteLiteral(@"

    <div class=""account-pages""></div>
    <div class=""clearfix""></div>
    <div class=""wrapper-page"">
        <div class=""text-center"">
            <a href=""index.html"" class=""logo""><span>Pastoral<span>Empleo</span></span></a>
            <h5 class=""text-muted m-t-0 font-600"">Trabaja con Nosotros</h5>
        </div>
        <div class=""m-t-40 card-box"">
            <div class=""text-center"">
                <h4 class=""text-uppercase font-bold m-b-0"">Ingresa</h4>
            </div>
            <div class=""p-20"">
                ");
                EndContext();
                BeginContext(683, 1745, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2c719f9add94686bcb0c27c328807ab", async() => {
                    BeginContext(740, 1478, true);
                    WriteLiteral(@"

                    <div class=""form-group"">
                        <div class=""col-xs-12"">
                            <input class=""form-control"" type=""text"" required="""" placeholder=""Correo"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-xs-12"">
                            <input class=""form-control"" type=""password"" required="""" placeholder=""Contraeña"">
                        </div>
                    </div>

                    <div class=""form-group "">
                        <div class=""col-xs-12"">
                            <div class=""checkbox checkbox-custom"">
                                <input id=""checkbox-signup"" type=""checkbox"">
                                <label for=""checkbox-signup"">
                                    Recuérdame
                                </label>
                            </div>

                        </div>
                    </div>
");
                    WriteLiteral(@"
                    <div class=""form-group text-center m-t-30"">
                        <div class=""col-xs-12"">
                            <button class=""btn btn-custom btn-bordred btn-block waves-effect waves-light"" type=""submit"">Iniciar</button>
                        </div>
                    </div>

                    <div class=""form-group m-t-30 m-b-0"">
                        <div class=""col-sm-12"">
                            <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2218, "\"", 2262, 1);
#line 58 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\Login.cshtml"
WriteAttributeValue("", 2225, Url.Action("ResetPassword", "Login"), 2225, 37, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2263, 158, true);
                    WriteLiteral(" class=\"text-muted\"><i class=\"fa fa-lock m-r-5\"></i> Olvidades tu cotraseña?</a>\r\n                        </div>\r\n                    </div>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2428, 206, true);
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <!-- end card-box-->\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 text-center\">\r\n                <p class=\"text-muted\">No tienes cuenta? <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2634, "\"", 2673, 1);
#line 69 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\Login.cshtml"
WriteAttributeValue("", 2641, Url.Action("Register", "Login"), 2641, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2674, 840, true);
                WriteLiteral(@" class=""text-primary m-l-5""><b>Registrate</b></a></p>
            </div>
        </div>

    </div>
    <!-- end wrapper page -->
    <!-- jQuery  -->
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/js/popper.min.js""></script>
    <script src=""assets/js/bootstrap.min.js""></script>
    <script src=""assets/js/detect.js""></script>
    <script src=""assets/js/fastclick.js""></script>
    <script src=""assets/js/jquery.blockUI.js""></script>
    <script src=""assets/js/waves.js""></script>
    <script src=""assets/js/jquery.nicescroll.js""></script>
    <script src=""assets/js/jquery.slimscroll.js""></script>
    <script src=""assets/js/jquery.scrollTo.min.js""></script>

    <!-- App js -->
    <script src=""assets/js/jquery.core.js""></script>
    <script src=""assets/js/jquery.app.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3521, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
