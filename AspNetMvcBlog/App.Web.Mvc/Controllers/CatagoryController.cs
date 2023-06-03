using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class Catagory : Controller
    {
        [HttpGet]
        [HttpPut]
        [Route("/category/category-slug")]
        
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
