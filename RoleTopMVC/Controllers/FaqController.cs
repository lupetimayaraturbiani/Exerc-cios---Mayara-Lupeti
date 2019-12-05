using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class FaqController : AbstractController
    {
        public IActionResult Faq()
        {
            return View(new BaseViewModel(){
                NomeView = "FAQ",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}