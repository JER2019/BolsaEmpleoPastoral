#pragma checksum "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acbbae48c1493e49b53c0a4249d9678a783c4b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscription_Document), @"mvc.1.0.view", @"/Views/Inscription/Document.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inscription/Document.cshtml", typeof(AspNetCore.Views_Inscription_Document))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbbae48c1493e49b53c0a4249d9678a783c4b4a", @"/Views/Inscription/Document.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscription_Document : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml"
  
    ViewData["Title"] = "Document";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 315, true);
            WriteLiteral(@"
<section>

    <div class=""container-fluid"">
        <div class=""page-header"">
            <h1 class=""text-titles""><i class=""zmdi zmdi-account zmdi-hc-fw""></i> <small>Otros Documentos</small></h1>
        </div>
    </div>

    <div class=""row"">

        <div class=""col-xs-12 col-sm-3"">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 408, "\"", 454, 1);
#line 18 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml"
WriteAttributeValue("", 415, Url.Action("Candidate", "Inscription"), 415, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(455, 172, true);
            WriteLiteral(" class=\"btn btn-info\" style=\"color:#004D97\"><i class=\"zmdi zmdi-plus\"></i> &nbsp; PERSONALES</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 627, "\"", 671, 1);
#line 22 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml"
WriteAttributeValue("", 634, Url.Action("Studies", "Inscription"), 634, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(672, 190, true);
            WriteLiteral(" class=\"btn btn-success\" style=\"color:#004D97\"><i class=\"zmdi zmdi-format-list-bulleted\"></i> &nbsp; FORMACIÓN</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 862, "\"", 909, 1);
#line 26 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml"
WriteAttributeValue("", 869, Url.Action("Experience", "Inscription"), 869, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(910, 178, true);
            WriteLiteral(" class=\"btn btn-primary\" style=\"color:#004D97\"><i class=\"zmdi zmdi-search\"></i> &nbsp; EXPERIENCIA</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1088, "\"", 1133, 1);
#line 30 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml"
WriteAttributeValue("", 1095, Url.Action("Document", "Inscription"), 1095, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1134, 235, true);
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:#004D97\"><i class=\"zmdi zmdi-comment-list\"></i> &nbsp; OTROS DOCUMENTOS</a>\r\n        </div>\r\n\r\n        <div class=\"container-fluid\">\r\n            <div class=\"panel panel-info\">\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(1370, 23, false);
#line 37 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Document.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1393, 1612, true);
            WriteLiteral(@"

                <fieldset>

                    <legend><i class=""zmdi zmdi-account-box""></i> &nbsp; Otros Documentos</legend>

                    <div class=""container-fluid"">
                        <div class=""row"">

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <Label for=""School"">*Tipo Documento</Label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Document"">Adjunte Certificado</label>
                                    <input type=""file"" class=""form-control"">
                              ");
            WriteLiteral(@"  </div>
                            </div>

                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
    </div>

    <div class=""text-left"">
        <div class=""margin-top: 20px"">
            <input type=""submit"" value=""Guardar"" class=""btn btn-primary btn-bordred btn-sm"" />
        </div>
    </div>

    <div class=""text-right"">
        <div class=""margin-top: 20px"">
            <input type=""submit"" value=""Cancelar"" class=""btn btn-danger btn-bordred btn-sm"" />
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
