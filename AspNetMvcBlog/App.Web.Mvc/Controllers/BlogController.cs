using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }
        [HttpGet]
        [HttpPut]
        [Route("/blog/title-slug")]
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
