using Microsoft.AspNetCore.Mvc;

namespace SallesWebMvc.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
