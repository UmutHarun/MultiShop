using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Order.WebApi.Controllers
{
    public class AddressesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
