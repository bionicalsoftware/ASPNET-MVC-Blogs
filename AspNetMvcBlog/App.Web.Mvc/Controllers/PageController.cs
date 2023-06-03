using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PageController : Controller
    {
        [HttpGet]
        [HttpPut]
        [Route("/page/title-slug")]
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
