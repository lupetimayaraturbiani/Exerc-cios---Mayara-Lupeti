#pragma checksum "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5df802b35b82cf452a8d448751ff986be30d30f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Usuario), @"mvc.1.0.view", @"/Views/Cliente/Usuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Usuario.cshtml", typeof(AspNetCore.Views_Cliente_Usuario))]
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
#line 1 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5df802b35b82cf452a8d448751ff986be30d30f", @"/Views/Cliente/Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5769cfbe4dda628aabf19144c89567913a2623fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Usuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.UsuarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
  
    ViewData["Title"] = "Usuario - RoleTop";

#line default
#line hidden
            BeginContext(96, 19, true);
            WriteLiteral("<main>\n        <h2>");
            EndContext();
            BeginContext(116, 17, false);
#line 6 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
       Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(133, 302, true);
            WriteLiteral(@"</h2>

        <img src=""/img/icone usuário.png"" id=""icone-usuario"" />

        <section class=""topicos"">
            <p>Minha Conta</p>
            <br />
            <br />
            <br />
            <br />
                <h2>Cadastre seu evento</h2>
        <section id=""cadastro"">
            ");
            EndContext();
            BeginContext(435, 2928, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5df802b35b82cf452a8d448751ff986be30d30f4928", async() => {
                BeginContext(500, 181, true);
                WriteLiteral("\n                \n                <div>\n                    <label for=\"nome\">Nome do Contratante</label>\n                    <br />\n                    <input id=\"nome\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 681, "\"", 708, 1);
#line 23 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
WriteAttributeValue("", 689, Model.Cliente.Nome, 689, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(709, 203, true);
                WriteLiteral(" name=\"nome\"/>\n                </div>\n\n                <div>\n                    <label for=\"nome\">Email do Contratante</label>\n                    <br />\n                    <input id=\"nome\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 912, "\"", 940, 1);
#line 29 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
WriteAttributeValue("", 920, Model.Cliente.Email, 920, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(941, 1198, true);
                WriteLiteral(@" name=""email""/>
                </div>

                <div>
                    <label for=""nome"">Nome do Evento</label>
                    <br />
                    <input id=""nome"" type=""text"" maxlength=""20"" minlength=""3""  name=""nomeEvento""/>
                </div>

                <div>
                    <label for=""data do evento"">Data do Evento</label>
                    <br />
                    <input id=""data do evento"" type=""date"" maxlength=""10"" minlength=""10"" name=""data_evento""/>
                </div>

                <div>
                    <label for=""hora"">Horário do Evento</label>
                    <br />
                    <input id=""hora"" type=""time"" maxlength=""5"" minlength=""5"" name=""horario"" />
                </div>

                <div>
                    <label for=""pagamento"">Forma de Pagamento</label>
                    <br />
                    <input id=""pagamento"" type=""text"" maxlength=""5"" minlength=""5"" name=""pagamento""/>
                </div>

                <labe");
                WriteLiteral("l for=\"servicosAdicionais\">Serviços Adicionais</label>\n                <br />\n                <select id=\"servicosAdicionais\" name=\"servicosAdicionais\" >\n                    ");
                EndContext();
                BeginContext(2139, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5df802b35b82cf452a8d448751ff986be30d30f7856", async() => {
                    BeginContext(2175, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2193, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 60 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var servicosAdicionais in Model.ServicosAdicionais)
                    {

#line default
#line hidden
                BeginContext(2298, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2322, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5df802b35b82cf452a8d448751ff986be30d30f10334", async() => {
                    BeginContext(2362, 23, false);
#line 62 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                          Write(servicosAdicionais.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2385, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2391, 24, false);
#line 62 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                                       Write(servicosAdicionais.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2415, 26, true);
                    WriteLiteral("\n\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 62 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(servicosAdicionais.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2450, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 65 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(2473, 219, true);
                WriteLiteral("\n                </select>\n                <br />\n                <label for=\"tiposEvento\">Tipo de Evento</label>\n                <br />\n                <select id=\"tiposEvento\" name=\"tiposEvento\" >\n                    ");
                EndContext();
                BeginContext(2692, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5df802b35b82cf452a8d448751ff986be30d30f13517", async() => {
                    BeginContext(2728, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2746, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 73 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var tiposEvento in Model.TiposEvento)
                    {

#line default
#line hidden
                BeginContext(2837, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2861, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5df802b35b82cf452a8d448751ff986be30d30f15982", async() => {
                    BeginContext(2894, 16, false);
#line 75 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                   Write(tiposEvento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2910, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2916, 17, false);
#line 75 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                         Write(tiposEvento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2933, 26, true);
                    WriteLiteral("\n\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 75 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(tiposEvento.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2968, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 78 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(2991, 365, true);
                WriteLiteral(@"                </select>
                <br />
                <label for=""descricao""> Descrição do Evento</label>
                <br />
                <textarea placeholder=""Descrição do evento""name=""descricao"" id=""descricao"" ></textarea>
                    
                <br />
                <input type=""submit"" value=""Cadastrar evento"" />
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 18 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
AddHtmlAttributeValue("", 463, Url.Action("Registrar", "Usuario"), 463, 35, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3363, 436, true);
            WriteLiteral(@"
        </section>

        <br />
        <br />

        <p>Meus Eventos</p>
    <table>
        <thead>
            <tr>
                <th>Nome</th>
                <th>Data do Evento</th>
                <th>Horário</th>
                <th>Tipo de Evento</th>
                <th>Descrição</th>
                <th>Serviços Adicionais</th>
                <th>Preço Total</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 107 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
             foreach( var evento in Model.Eventos ) {

#line default
#line hidden
            BeginContext(3853, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(3899, 17, false);
#line 109 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3916, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(3947, 17, false);
#line 110 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3964, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(3995, 14, false);
#line 111 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(4009, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4040, 23, false);
#line 112 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.TiposEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4063, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4094, 16, false);
#line 113 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(4110, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4141, 30, false);
#line 114 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4171, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4202, 17, false);
#line 115 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(4219, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 117 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
            }

#line default
#line hidden
            BeginContext(4261, 107, true);
            WriteLiteral("        </tbody>\n    </table>\n\n            <p>Cancelamentos</p>\n            \n        </section>\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.UsuarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
