using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleCondominal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Login";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult fazerLogin(string username, string password)
        {
            if (username == "adm" && password == "123")
            {
                // Login bem-sucedido, retornar um JSON indicando o redirecionamento
                return Json(new { success = true, redirectUrl = Url.Action("Index", "Home") });
            }
            else
            {
                // Login falhou, retornar um JSON com erro
                return Json(new { success = false, message = "Usuário ou senha inválidos." });
            }
        }

    }

}
