#pragma checksum "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\Home\Servico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1d2010551e3be41fd40b8769a7152430556f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Servico), @"mvc.1.0.view", @"/Views/Home/Servico.cshtml")]
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
#line 1 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\_ViewImports.cshtml"
using ETAPA_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\_ViewImports.cshtml"
using ETAPA_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1d2010551e3be41fd40b8769a7152430556f6b", @"/Views/Home/Servico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b3b4b5f8f0869cfe877dc00a92133b4b5f61422", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Servico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Calcula", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\Home\Servico.cshtml"
  
    ViewData["Title"] = "Serviço";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1d2010551e3be41fd40b8769a7152430556f6b4357", async() => {
                WriteLiteral(@"
    <br>
    <main>
        <br>
        <h2>TABELA DO INSS</h2>
        <span>VIGENTE A PARTIR DE 01/2022</span>
        <table border=""2"" align=""center"" class=""table"" style=""background: image Views/wwwroot/Teto do INSS -2021png;""
            ;"">
            <tbody>
                <tr>
                    <th></th>
                    <th>DE</th>
                    <th>ATÉ</th>
                    <th>ALÍQUOTA</th>
                </tr>
                <tr>
                    <th>1 FAIXA</th>
                    <td>R$ - </td>
                    <td>R$1.100,00</td>
                    <td>7,5%</td>
                </tr>
                <tr>
                    <th>2 FAIXA</th>
                    <td>R$1.100,01</td>
                    <td>R$2.203,48</td>
                    <td>9%</td>
                </tr>
                <tr>
                    <th>3 FAIXA</th>
                    <td>R$2.203,49</td>
                    <td>R$3.305,22</td>
                    <td>12%</");
                WriteLiteral(@"td>
                </tr>
                <tr>
                    <th>4 FAIXA</th>
                    <td>R$3.305,23</td>
                    <td>R$6.433,57</td>
                    <td>14%</td>
                </tr>
            </tbody>
        </table>
        <br>
        <spam>Informe os dados solicitados para efetuar o cálculo do FGTS e/ou INSS(Insira apenas números)</span>
            <br>
            <span>O resultado estará disponível nesta mesma página.</span>
            <div class=""row input-group"">
                <div class=""col-md-8 input-group-prepend"">
                    <table>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1d2010551e3be41fd40b8769a7152430556f6b6331", async() => {
                    WriteLiteral(@"
                            <tr>
                                </label>
                                <p>
                                    <td><label for=""txtINSS"">Salário bruto:</td>
                                    <td><input type=""text"" class=""input-group-text"" placeholder=""R$"" id=""txtINSS"" name=""INSS"" /></td>
                                </p>
                            </tr>
                            <tr>
                                </label>
                                <p>
                                    <td><label for=""txtFGTS"">Salário com todas as convergências:</td>
                                    <td> <input type=""text"" class=""input-group-text"" placeholder=""R$"" id=""txtFGTS"" name=""FGTS"" /></td>
                                </p>
                            </tr>
                            <tr>
                                <p>
                                    <td><input type=""reset"" class=""btn btn-danger"" value=""Limpar""></td>
                  ");
                    WriteLiteral("                  <td><input type=\"submit\" class=\"btn btn-primary\" value=\"Calcular\"></td>\r\n                                </p>\r\n                            </tr>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </table>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <table class=\"tabela_calculo\">\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 82 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\Home\Servico.cshtml"
                           Write(ViewData["ResultadoINSS"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 85 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\Home\Servico.cshtml"
                           Write(ViewData["Alíquota Efetiva INSS"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 88 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\Home\Servico.cshtml"
                           Write(ViewData["ResultadoFGTS"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 91 "C:\Users\Willi\OneDrive\Área de Trabalho\Técnico em Informática para Internet\Modúlo 2\PI\ETAPA 5\Views\Home\Servico.cshtml"
                           Write(ViewData["Alíquota Efetiva FGTS"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                        </tr>
                    </table>
                </div>
            </div>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <h2>DESCONTO INSS: O QUE É, COMO FUNCIONA E COMO CALCULAR?</h2>
            <p>Todo trabalhador brasileiro deve, por necessidade, entender como é feito o cálculo e respectivo desconto
                em
                seu salário por parte do Instituto Nacional de Seguridade Social (INSS). Afinal, este é um desconto que
                impacta diretamente no salário líquido.

                Tanto a empresa, quanto o trabalhador contribuem para o INSS. A empresa paga parte do salário do
                funcionário
                em contribuições; e o trabalhador, por sua vez, complementa por meio de descontos em seus vencimentos.

                Estar alinhado com o pagamento do INSS é uma obrigação tanto do empregado como do empregador. Caso o
                contrár");
                WriteLiteral(@"io podem acontecer inúmeras complicações, como processos trabalhistas ou perdas de dinheiro.

                Neste artigo iremos ensinar como calcular o desconto do INSS. Mas antes disso, é preciso que você
                entenda
                como e por qual motivo esse desconto acontece. Confira!</p>
            <br>
            <h2>INSS</h2>
            <p>O INSS é uma autarquia do Governo Federal do Brasil responsável por receber as contribuições
                previdenciárias
                – e obrigatórias – dos trabalhadores. Esse sistema é operado para que seja viável o pagamento de
                seguridades
                e assistenciais sociais, como:

            <table align=""center"">
                <tr>
                    <p>
                        <td>
                            <li><label>Aposentadorias </label></li>
                        </td>
                    </p>
                </tr>

                <tr>
                    <p>
                    ");
                WriteLiteral(@"    <td>
                            <li><label>Pensões por morte </label></li>
                        </td>
                    </p>
                </tr>

                <tr>
                    <p>
                        <td>
                            <li><label>Auxílios-doença </label></li>
                        </td>
                    </p>
                </tr>

                <tr>
                    <p>
                        <td>
                            <li><label>Auxílios-acidente e outros </label></li>
                        </td>
                    </p>
                </tr>
            </table>

            Além disso, o órgão detém a responsabilidade pela coleta dos abatimentos realizados na folha de pagamento
            dos trabalhadores em regime CLT.

            Portanto, quem participa da contribuição para o INSS tem direito ao afastamento remunerado, aposentadorias e
            pensões diversas. Contudo, a contribuição é compulsória. O órgão não");
                WriteLiteral(@" oferece a possibilidade de o
            trabalhador registrado negar-se a participar.
            </p>
            <h2>DESCONTO INSS</h2>
            <p>O desconto recolhido pelo INSS é feito diretamente na folha de pagamento do trabalhador, antes de ele
                receber
                o valor líquido da empresa.

                Esse desconto é feito de maneira progressiva, mensalmente. Já o cálculo e as porcentagens de desconto
                variam
                de acordo com o salário de cada trabalhador.

                Existe um teto máximo para o desconto do INSS. Mesmo quando o funcionário tem um salário superior ao
                limite
                de contribuição, o desconto acontece de acordo com esse limite.</p>
            <p>Em cada faixa salarial é aplicado um desconto desconto é proporcional, que aumenta conforme o salário. A
                partir da reforma da previdência, sancionada em novembro de 2019, foram aplicadas alterações nas
                alíqu");
                WriteLiteral(@"otas.
                Assim como na forma de cálculo.

                Anteriormente à reforma, eram consideradas três alíquotas que se multiplicavam diretamente ao salário,
                conforme a faixa que se encontrava.

                Além disso, salários que estão acima do teto da previdência, de R$ 6.101,06, contribuem os mesmos R$
                713,10.
                Assim, a alíquota efetiva é de aproximadamente 11,69%.</p>
            <h2>COMO CALCULAR O DESCONTO DO INSS</h2>
            <p>
                Com as novas alíquotas e a nova forma de cálculo progressivo, o desconto do INSS deve ser calculado para
                cada faixa. Isso é feito até que se atinja o valor do salário bruto.

                Entre cada parcela, o cálculo considera o máximo e o mínimo dessas alíquotas. Enquanto o valor do
                salário
                não é atingido, é considerado o teto da faixa salarial. Assim, o desconto é feito de acordo com cada
                faixa,
        ");
                WriteLiteral(@"        e aplicado assim:
            </p>
            <p>1ª faixa salarial: 1.100,00 x 0,075 = 82,50</p>
            <p>2ª faixa salarial: (R$ 2.203,48 – R$ 1.100,01) x 9% = R$ 1.044,60 x 9% = R$ 99,31</p>
            <p>3ª faixa salarial: (R$ 3.305,22 – R$ 2.203,49) x 12% = R$ 1.101,73 x 12% = R$ 132,21</p>
            <p>4ª faixa salarial: (R$ 6.433,57 – R$ 3.305,23) x 14% = R$ 3.128,34 x 14% = R$ 437,97</p>
            <p>Total máximo a recolher: R$ 82,50 + R$ 99,31 + R$ 132,21 + R$ 437,97 = R$ 751,99</p>
            <h2>ENTENDA O CÁLCULO DO FGTS</h2>
            <p>Todos os meses, o empregador realiza o cálculo do FGTS no valor de 8% do salário bruto do colaborador. No
                caso de menor aprendiz, a alíquota é de 2%. Para determinar o valor total de contribuição, basta
                multiplicar
                pelos meses contribuídos: R$ 160,00 x 12 meses = R$ 1.920,00.</p>
    </main>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
