#pragma checksum "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\List\EmploymentListing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8510973a3dc100316acf07a61090f1e397b03700"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_EmploymentListing), @"mvc.1.0.view", @"/Views/List/EmploymentListing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/EmploymentListing.cshtml", typeof(AspNetCore.Views_List_EmploymentListing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8510973a3dc100316acf07a61090f1e397b03700", @"/Views/List/EmploymentListing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_List_EmploymentListing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
  
    ViewData["Title"] = "EmploymentListing";

#line default
#line hidden
            BeginContext(55, 1177, true);
            WriteLiteral(@"
<section>
    <div class=""container-fluid"">
        <div class=""page-header"">
            <h1 class=""text-titles""><i class=""zmdi zmdi-account zmdi-hc-fw""></i> <small>Listado Empleo</small></h1>
        </div>
    </div>

    <div>

        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""color:#004D97"">Empresa</a>
        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""color:#004D97"">Cargo</a>
        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""color:#004D97"">Estado</a>
        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""color:#004D97"">Ingreso</a>
        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""color:#004D97"">Salida</a>
        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""color:#004D97"">Jefe</a>
        <a class=""btn btn-light btn-rounded w-md waves-effect waves-light m-b-5"" style=""colo");
            WriteLiteral("r:#004D97\">Teléfono</a>\r\n        <a class=\"btn btn-light btn-rounded w-md waves-effect waves-light m-b-5\" style=\"color:#004D97\">Consulte </a>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1279, 1);
#line 23 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
WriteAttributeValue("", 1239, Url.Action("Experience", "Inscription"), 1239, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1280, 112, true);
            WriteLiteral(" class=\"btn btn-success btn-rounded waves-effect waves-light m-b-5\" style=\"color:#004D97\">Editar</a>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1392, "\"", 1428, 1);
#line 24 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\List\EmploymentListing.cshtml"
WriteAttributeValue("", 1399, Url.Action("Login", "Login"), 1399, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 318, true);
            WriteLiteral(@" class=""btn btn-danger btn-rounded waves-light m-b-5"" style=""color:#004D97"">Eliminar</a>

    </div>


    <div class=""text-center"">
        <div class=""margin-top: 20px"">
            <input type=""submit"" value=""Guardar"" class=""btn btn-primary btn-raised btn-sm"" />
        </div>
    </div>

</section>

");
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
