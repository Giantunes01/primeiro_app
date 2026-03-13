using Microsoft.AspNetCore.Mvc;

namespace primeiro_app.Controllers
{
    public class alunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
