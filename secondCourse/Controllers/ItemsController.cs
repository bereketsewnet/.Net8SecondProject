using Microsoft.AspNetCore.Mvc;
using secondCourse.Models;

namespace secondCourse.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard" };
            return View(item);
        }
    }
}
