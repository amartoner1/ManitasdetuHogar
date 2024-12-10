using Microsoft.AspNetCore.Mvc;

namespace ManitasDelHogar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult PoliticasCookies()
        {
            return View();
        }
    }
}
