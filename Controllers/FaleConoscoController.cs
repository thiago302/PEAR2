using Microsoft.AspNetCore.Mvc;

namespace MyTodoApp.Controllers
{
    public class FaleConoscoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
