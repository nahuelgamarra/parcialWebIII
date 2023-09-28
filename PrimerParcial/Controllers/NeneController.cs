using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Logica;

namespace PrimerParcial.Controllers
{
    public class NeneController : Controller
    {
        public INeneService _service;

        public NeneController(INeneService service) { 
        this._service= service;
                }
        public IActionResult CalcularTamano()
        {
            return View( new Nene());
        }


        [HttpPost]
        public IActionResult CalcularTamano(Nene nene)
        {
            if (ModelState.IsValid)
            {
                
                _service.AgregarNene(nene);
                return RedirectToAction("MostrarResultado"); 
            }
            return View(nene);
        }


        public IActionResult MostrarResultado()
        {
            List<Nene> resultado= _service.MostrarResultado();
            return View(resultado);
        }
    }
}
