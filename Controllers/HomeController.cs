using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ETAPA_5.Models;

namespace ETAPA_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Servico()
        {
            return View();
        }
        // Calculo do INSS e FGTS com base nos parametros.
        public IActionResult Calcula(double INSS, double FGTS)
        {
            double faixa1 = 0.075;
            double faixa2 = 0.09;
            double faixa3 = 0.12;
            double faixa4 = 0.14;
            double aliquota_fgts = 0.08;
            double resultadoinss;
            double resultadofgts;
            double aliquota_efetiva_inss;

            if (INSS <= 1100)
            {
                resultadoinss = INSS * faixa1;
            }
            else
            {
                if (INSS >= 1101.01 && INSS <= 2203.48)
                {
                    resultadoinss = (1100 * faixa1) + ((INSS - 1100) * faixa2);

                }
                else
                {
                    if (INSS >= 2203.49 && INSS <= 3305.22)
                    {
                        resultadoinss = (1100 * faixa1 + ((2203.48 - 1100) * faixa2) + ((INSS - 2203.48) * faixa3));
                    }
                    else
                    {
                        if (INSS >= 3305.23 && INSS <= 6433.57)
                        {
                            resultadoinss = (1100 * faixa1) + ((2203.48 - 1100) * faixa2) + ((3305.22 - 2203.48) * faixa3) + ((INSS - 3305.22) * faixa4);
                        }
                        else
                        {
                            if (INSS >= 6433.58)
                            {
                                resultadoinss = 751.99;
                            }
                            else
                            {
                                resultadoinss = 0;
                            }
                        }
                    }
                }
            }
            
            aliquota_efetiva_inss = resultadoinss / INSS;
            resultadofgts = FGTS * aliquota_fgts;
            aliquota_fgts = resultadofgts / FGTS;    
            ViewData["ResultadoINSS"] = "Resultado do INSS: " + resultadoinss.ToString("C")+".";
            ViewData["ResultadoFGTS"] = "Resultado do FGTS: " + resultadofgts.ToString("C")+".";
            ViewData["Alíquota Efetiva INSS"] = "Alíquota Efetiva INSS: " + aliquota_efetiva_inss.ToString("P")+".";
            ViewData["Alíquota Efetiva FGTS"] = "Alíquota Efetiva FGTS: "+ aliquota_fgts.ToString("P")+".";

            return View("Servico");

        }
        //Cadastrando usuário e mostrando para o usuário os dados cadastrados com sucesso.
        public IActionResult Noticas(){
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
