using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminCatagoryController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
