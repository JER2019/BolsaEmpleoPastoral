#pragma checksum "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab0d18bee61870bf51c08e1679e4f32ed53eb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_ResetPassword), @"mvc.1.0.view", @"/Views/Login/ResetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/ResetPassword.cshtml", typeof(AspNetCore.Views_Login_ResetPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab0d18bee61870bf51c08e1679e4f32ed53eb19", @"/Views/Login/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\ResetPassword.cshtml"
  
    ViewData["Title"] = "ResetPassword";
    Layout = "~/Views/Shared/LayoutSecondary.cshtml";

#line default
#line hidden
            BeginContext(106, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(116, 2277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c7f8cdc7e694b51ac48acfc626081ea", async() => {
                BeginContext(122, 511, true);
                WriteLiteral(@"

    <div class=""account-pages""></div>
    <div class=""clearfix""></div>
    <div class=""wrapper-page"">
        <div class=""text-center"">
            <a href=""index.html"" class=""logo""><span>Pastoral<span>Empleo</span></span></a>           
        </div>

        <div class=""m-t-40 card-box"">
            <div class=""text-center"">
                <h4 class=""text-uppercase font-bold m-b-0"">Recuperar Contraseña</h4>             
           </div>

            <div class=""p-20"">
                ");
                EndContext();
                BeginContext(633, 671, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52ec89004ac94c9fb885dfacf688a1ad", async() => {
                    BeginContext(690, 607, true);
                    WriteLiteral(@"

                    <div class=""form-group"">
                        <div class=""col-xs-12"">
                            <input class=""form-control"" type=""email"" required="""" placeholder=""Correo"">
                        </div>
                    </div>

                    <div class=""form-group text-center m-t-20 m-b-0"">
                        <div class=""col-xs-12"">
                            <button class=""btn btn-custom btn-bordred btn-block waves-effect waves-light"" type=""submit"">Enviar Correo</button>
                        </div>
                    </div>

                ");
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
                BeginContext(1304, 207, true);
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <!-- end card-box -->\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 text-center\">\r\n                <p class=\"text-muted\">¿Ya tienes cuenta?<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1511, "\"", 1547, 1);
#line 45 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Login\ResetPassword.cshtml"
WriteAttributeValue("", 1518, Url.Action("Login", "Login"), 1518, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1548, 838, true);
                WriteLiteral(@""" class=""text-primary m-l-5""><b>Ingresa</b></a></p>
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
            BeginContext(2393, 19, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
