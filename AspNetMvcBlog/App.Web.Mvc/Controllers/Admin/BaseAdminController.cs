using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class BaseAdminController : Controller
    {
        [Route("/BaseAdminController")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
