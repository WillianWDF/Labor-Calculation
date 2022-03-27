using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ETAPA_5.Models;
using static ETAPA_5.Models.ItensUsuario;
namespace ETAPA_5.Controllers
{
    public class ItensUsuarioController: Controller
    {
        
        public IActionResult FaleConosco()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaleConosco(ItensUsuario u)
        {
            ItensUsuarioRepository ur = new ItensUsuarioRepository();
            ur.Cadastrar(u);
            return RedirectToAction("Listagem", "ItensUsuario");
        }
    
    public IActionResult Listagem()
        {
            


            ItensUsuarioRepository Teste = new ItensUsuarioRepository();
            List<ItensUsuario> Lista = Teste.Listar();
            return View(Lista);

        }
    
    
    public IActionResult Editar(int Id)
        {
            
            
            ItensUsuarioRepository ur = new ItensUsuarioRepository();
            ItensUsuario UserEncontrado = ur.BuscarPorId(Id);
            return View(UserEncontrado);
        }
        
        [HttpPost]
        public IActionResult Editar(ItensUsuario u)
        {
            ItensUsuarioRepository ur = new ItensUsuarioRepository();
            ur.Editar(u);
            return RedirectToAction("Listagem", "ItensUsuario");
        }


        public IActionResult Excluir(int Id)
        {
            
            
            ItensUsuarioRepository ur = new ItensUsuarioRepository();
            ItensUsuario userEncontrado = ur.BuscarPorId(Id);
            ur.Excluir(userEncontrado);
            return RedirectToAction("Listagem", "ItensUsuario");
        }
    
    
    }
}