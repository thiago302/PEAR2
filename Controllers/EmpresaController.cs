using Microsoft.AspNetCore.Mvc;

namespace MyTodoApp.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
