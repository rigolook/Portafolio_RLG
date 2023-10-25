using Microsoft.AspNetCore.Mvc;
using Portafolio_RLG.Conexion;
using Portafolio_RLG.Models;

namespace Portafolio_RLG.Controllers
{
    public class Persona1Controller : Controller
    {
        Persona1Datos _persona1Datos = new Persona1Datos();
        public IActionResult Index()
        {
            var lista = _persona1Datos.Listar();
            return View(lista);
        }
        
    }
}
