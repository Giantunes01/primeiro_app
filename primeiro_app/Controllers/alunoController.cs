using Microsoft.AspNetCore.Mvc;

namespace primeiro_app.Controllers
{
    public class alunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno Nota 10";
            ViewData["Escola"] = "E.E. Anhanguera";
            return View();

        }
        public IActionResult Teste()
        {

            TempData["MSG_EX"] = "Mensagem do TemData";
            return RedirectToAction("Resultado");
        }
        public IActionResult Resultado()
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Aluno ETEC MB";
            return View();
             


        }
    }
}
