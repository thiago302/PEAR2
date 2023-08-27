using Microsoft.AspNetCore.Mvc;

namespace MyTodoApp.Controllers
{
    public class ServiçosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
