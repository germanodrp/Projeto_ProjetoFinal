using Microsoft.AspNetCore.Mvc;

namespace PROJETO01.Controllers
{
    public class eventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
