#pragma checksum "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee63de4e32b507311b00cb4ccf65388a66e0788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee63de4e32b507311b00cb4ccf65388a66e0788", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5769cfbe4dda628aabf19144c89567913a2623fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 267, true);
            WriteLiteral(@"    <main>
        <h2>Dashboard</h2>
        <section id=""status-eventos"">
            <h3>Status dos Eventos</h3>
            <div id=""painel"">
                <div class=""box-status-eventos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(316, 22, false);
#line 9 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(338, 149, true);
            WriteLiteral("</p>\n                </div>\n                <div class=\"box-status-eventos pendentes\">\n                    <h4>Pendentes</h4>\n                    <p>");
            EndContext();
            BeginContext(488, 22, false);
#line 13 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(510, 151, true);
            WriteLiteral("</p>\n                </div>\n                <div class=\"box-status-eventos reprovados\">\n                    <h4>Reprovados</h4>\n                    <p>");
            EndContext();
            BeginContext(662, 23, false);
#line 17 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(685, 820, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-eventos"">
            <h3>Lista de eventos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Data Evento</th>
                        <th rowspan=""2"">Horario</th>
                        <th colspan=""2"">Tipo de Evento</th>
                        <th colspan=""2"">Serviço Adicional</th>
                        <th colspan=""2"" rowspan=""3"">Aprovar</th>
                        <th colspan=""2"" rowspan=""4"">Reprovar</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Eventos atualizados em ");
            EndContext();
            BeginContext(1506, 12, false);
#line 39 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1518, 110, true);
            WriteLiteral("</p>\n                        </td>\n                    </tr>\n                </tfoot>\n                <tbody>\n");
            EndContext();
#line 44 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var evento in Model.Eventos )
                    {

#line default
#line hidden
            BeginContext(1709, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1771, 19, false);
#line 47 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1829, 17, false);
#line 48 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1846, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1885, 14, false);
#line 49 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(1899, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1938, 23, false);
#line 50 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.TiposEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1961, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2000, 30, false);
#line 51 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2030, 40, true);
            WriteLiteral("</td>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2070, "\'", 2133, 1);
#line 52 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2077, Url.Action("Aprovar", "Usuario", new {id = @evento.Id}), 2077, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2134, 73, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2207, "\'", 2271, 1);
#line 53 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2214, Url.Action("Reprovar", "Usuario", new {id = @evento.Id}), 2214, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2272, 69, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\n                        </tr>\n");
            EndContext();
#line 55 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2363, 77, true);
            WriteLiteral("                </tbody>\n            </table>\n        </section>\n\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
