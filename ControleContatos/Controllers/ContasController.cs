using Microsoft.AspNetCore.Mvc;

namespace ControleContatos.Controllers
{
    public class ContasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConta()
        {
            return View();
        }
    }
}
