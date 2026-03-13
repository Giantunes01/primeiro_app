using Microsoft.AspNetCore.Mvc;

namespace primeiro_app.Controllers
{
    public class alunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno Nota 10";
            ViewData ["Escola"] = "E.E. Anhanguera";
            return View();
        }
    }
}
