using EnterpriseAdditionWeb.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseAdditionWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdditionService additionService;

        public HomeController(IAdditionService additionService)
        {
            this.additionService = additionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int a, int b)
        {
            var result = additionService.Add(a)(b);
            
            return Json(result);
        }
    }
}
