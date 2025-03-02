using Microsoft.AspNetCore.Mvc;

namespace test_project_1.Controllers
{
    public class userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult add()
        {
            return View();
        }
    }
}
