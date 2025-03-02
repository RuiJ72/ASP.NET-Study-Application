using Microsoft.AspNetCore.Mvc;

namespace NovoNar.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
