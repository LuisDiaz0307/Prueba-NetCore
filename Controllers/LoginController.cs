using Microsoft.AspNetCore.Mvc;

namespace Practica_asp.net.Controllers
{
    public class LoginController : Controller
    {
        // Esta es la "Acción" que el navegador busca al entrar a /Login
        public IActionResult Index()
        {
            // Este comando busca el archivo Views/Login/Index.cshtml
            return View();
        }
    }
}