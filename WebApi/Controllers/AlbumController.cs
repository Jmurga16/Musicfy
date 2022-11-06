using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
