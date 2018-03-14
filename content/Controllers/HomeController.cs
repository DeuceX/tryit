using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    public class HomeController : Controller
    {
        private HttpContext _context;

        public HomeController(IHttpContextAccessor context)
        {
            _context = context.HttpContext;
        }

        public IActionResult Index()
        {
            /*if (_context.User?.Identity?.Name != null)
            {
                return Redirect("/account");
            }*/

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
