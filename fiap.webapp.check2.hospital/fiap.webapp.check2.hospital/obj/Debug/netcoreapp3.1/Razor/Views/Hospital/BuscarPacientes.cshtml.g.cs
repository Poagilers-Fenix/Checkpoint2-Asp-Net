#pragma checksum "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457e5509e311bfad280c7a8fd6fb7215979636f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospital_BuscarPacientes), @"mvc.1.0.view", @"/Views/Hospital/BuscarPacientes.cshtml")]
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
#line 1 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\_ViewImports.cshtml"
using fiap.webapp.check2.hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\_ViewImports.cshtml"
using fiap.webapp.check2.hospital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457e5509e311bfad280c7a8fd6fb7215979636f7", @"/Views/Hospital/BuscarPacientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b5415cabf3dfc5c0762fc6d5b536bb7c786b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Hospital_BuscarPacientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Paciente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/x.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastrarDoenca", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Paciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("idPaciente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mb-3 ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::fiap.webapp.check2.hospital.TagHelpers.MensagemTagHelper __fiap_webapp_check2_hospital_TagHelpers_MensagemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
       ViewData["title"] = "Listagem de Pacientes"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>Listagem de Pacientes</h2>\r\n    <br />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457e5509e311bfad280c7a8fd6fb7215979636f77622", async() => {
            }
            );
            __fiap_webapp_check2_hospital_TagHelpers_MensagemTagHelper = CreateTagHelper<global::fiap.webapp.check2.hospital.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(__fiap_webapp_check2_hospital_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
         WriteLiteral(TempData[" msg"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __fiap_webapp_check2_hospital_TagHelpers_MensagemTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", __fiap_webapp_check2_hospital_TagHelpers_MensagemTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"ml-3 mb-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457e5509e311bfad280c7a8fd6fb7215979636f79359", async() => {
                WriteLiteral("Buscar Pacientes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457e5509e311bfad280c7a8fd6fb7215979636f710825", async() => {
                WriteLiteral("Cadastrar novo Paciente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
         if (ViewBag.sabor != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"ml-md-auto mr-3\">\r\n            <p style=\"border: 2px #ccc solid; padding: 5px; border-radius: 5px\">");
#nullable restore
#line 18 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
                                                                           Write(ViewBag.sabor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457e5509e311bfad280c7a8fd6fb7215979636f712893", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "457e5509e311bfad280c7a8fd6fb7215979636f713110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        </div>");
#nullable restore
#line 19 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <table class=""table text-center"">
        <cabecalho></cabecalho>
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th>Cpf</th>
            <th>Endereço</th>
            <th>Data Nascimento</th>
            <th>Ações</th>
        </tr>
");
#nullable restore
#line 32 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
           Write(item.PacienteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
           Write(item.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
           Write(item.Endereco.Rua);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
                               Write(item.Endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 38 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
                                                      Write(item.Endereco.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
           Write(item.DataNascimento.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457e5509e311bfad280c7a8fd6fb7215979636f718289", async() => {
                WriteLiteral("Doenças");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
                                                                            WriteLiteral(item.PacienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Henrique\Documents\GitHub\Checkpoint2-Asp-Net\fiap.webapp.check2.hospital\fiap.webapp.check2.hospital\Views\Hospital\BuscarPacientes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Paciente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
