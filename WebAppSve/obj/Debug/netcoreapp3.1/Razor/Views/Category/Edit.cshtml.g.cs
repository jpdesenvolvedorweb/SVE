#pragma checksum "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7ab04c4e6b9cb7ea47d05bb9cc5346aab71e7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Edit), @"mvc.1.0.view", @"/Views/Category/Edit.cshtml")]
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
#nullable restore
#line 1 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\_ViewImports.cshtml"
using WebAppSve;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\_ViewImports.cshtml"
using WebAppSve.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ab04c4e6b9cb7ea47d05bb9cc5346aab71e7af", @"/Views/Category/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f19d5f14dda67f43415e8df60a65474f0e9d423", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
  
    ViewData["Title"] = "Editar Categorias";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
Write(ViewBag.MessageInitialUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 6 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" form-horizontal\">\r\n        <fieldset>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 14 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
           Write(Html.LabelFor(model => model.Id, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 16 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
               Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 21 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-6\">\r\n                    ");
#nullable restore
#line 23 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control", @placeholder = "Digite o Nome" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 28 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
           Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 30 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
               Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control", @placeholder = "Digite a Descrição" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-actions col-md-offset-2\">\r\n                <input class=\"btn btn-primary\" type=\"submit\" name=\"btnsalvar\" value=\"Salvar\" />\r\n                ");
#nullable restore
#line 36 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
           Write(Html.ActionLink("Voltar a Lista", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </fieldset>\r\n    </div>\r\n");
#nullable restore
#line 41 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-primary text-success text-center\">\r\n    ");
#nullable restore
#line 44 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
Write(ViewBag.MessageSucess);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n<div class=\"text-primary text-danger text-center\">\r\n    ");
#nullable restore
#line 47 "D:\Projeto.Net\SVE\AppSve\WebAppSve\Views\Category\Edit.cshtml"
Write(ViewBag.MessageError);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
