using Microsoft.AspNetCore.Mvc;

namespace TiendaMuebles.repositories.cliente
{
    public class IClienteRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
