#pragma checksum "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa82c805e9b1bd85d72f4c3e179042da4a3a15c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscription_Candidate), @"mvc.1.0.view", @"/Views/Inscription/Candidate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inscription/Candidate.cshtml", typeof(AspNetCore.Views_Inscription_Candidate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa82c805e9b1bd85d72f4c3e179042da4a3a15c4", @"/Views/Inscription/Candidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928166129b11b939891901ba6c4b6f1f2c82cf50", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscription_Candidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml"
  
    ViewData["Title"] = "Candidate";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 315, true);
            WriteLiteral(@"
<section>
      <div class=""container-fluid"">
        <div class=""page-header"">
            <h1 class=""text-titles""><i class=""zmdi zmdi-account zmdi-hc-fw""></i> <small>Datos Personales</small></h1>
        </div>
      </div>
    <div class=""row"">

        <div class=""col-xs-12 col-sm-3"">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 409, "\"", 455, 1);
#line 16 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml"
WriteAttributeValue("", 416, Url.Action("Candidate", "Inscription"), 416, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(456, 172, true);
            WriteLiteral(" class=\"btn btn-info\" style=\"color:#004D97\"><i class=\"zmdi zmdi-plus\"></i> &nbsp; PERSONALES</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 628, "\"", 672, 1);
#line 20 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml"
WriteAttributeValue("", 635, Url.Action("Studies", "Inscription"), 635, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(673, 191, true);
            WriteLiteral(" class=\"btn btn-success\" style=\"color:#004D97\"><i class=\"zmdi zmdi-format-list-bulleted\"></i> &nbsp; ACADÉMICOS</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 864, "\"", 911, 1);
#line 24 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml"
WriteAttributeValue("", 871, Url.Action("Experience", "Inscription"), 871, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(912, 178, true);
            WriteLiteral(" class=\"btn btn-primary\" style=\"color:#004D97\"><i class=\"zmdi zmdi-search\"></i> &nbsp; EXPERIENCIA</a>\r\n        </div>\r\n\r\n        <div class=\"col-xs-12 col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1135, 1);
#line 28 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml"
WriteAttributeValue("", 1097, Url.Action("Document", "Inscription"), 1097, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 235, true);
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:#004D97\"><i class=\"zmdi zmdi-comment-list\"></i> &nbsp; OTROS DOCUMENTOS</a>\r\n        </div>\r\n\r\n        <div class=\"container-fluid\">\r\n            <div class=\"panel panel-info\">\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(1372, 23, false);
#line 35 "D:\Proyect\EmploymentExchange\PastoralEmpleo\PastoralEmpleo\Views\Inscription\Candidate.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1395, 6068, true);
            WriteLiteral(@"

                <fieldset>

                    <legend><i class=""zmdi zmdi-account-box""></i> &nbsp; Informacion Personal </legend>

                    <div class=""container-fluid"">
                        <div class=""row"">

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <Label for=""DocumentType"">*Tipo Documento</Label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <Label for=""IdentityDocument"">*Numero Documento</Label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change""");
            WriteLiteral(@" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Document"">Adjunte Documento</label>                                 
                                    <input type=""file"" class=""form-control"">                                    
                                </div>    
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""userName"">*Apellido</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
");
            WriteLiteral(@"                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Name"">*Nombre</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Gender"">*Sexo</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                    ");
            WriteLiteral(@"            <div class=""form-group label-floating"">
                                    <label for=""CivilStatus"">*Estado Civil</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Brihtday"">Fecha Nacimiento</label>
                                    <input class=""form-control"" type=""date"" name=""date"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Telephone"">*Telefono</label>
                                    <inpu");
            WriteLiteral(@"t type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Addres"">*Dirección</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""Municipality"">*Municipio</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           ");
            WriteLiteral(@"class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-6"">
                                <div class=""form-group label-floating"">
                                    <label for=""District"">*Barrio</label>
                                    <input type=""text"" name=""nick"" parsley-trigger=""change"" required
                                           class=""form-control"">
                                </div>
                            </div>                            
                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
   </div>

        <div class=""text-center"">
            <div class=""margin-top: 20px"">
                <input type=""submit"" value=""Guardar"" class=""btn btn-light btn-raised btn-sm"" />
            </div>
        </div>   

</section>");
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
