using Microsoft.AspNetCore.Mvc;

namespace PrimerParcial.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
