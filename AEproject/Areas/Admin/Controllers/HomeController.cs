namespace AEproject.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        [Area("admin")]
        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}