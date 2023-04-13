using Microsoft.AspNetCore.Mvc;

namespace KujoWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
