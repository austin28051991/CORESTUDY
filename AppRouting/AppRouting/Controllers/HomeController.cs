using Microsoft.AspNetCore.Mvc;

namespace AppRouting.Controllers
{
    //Attribute based routing
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")]
        public int Details(int id)
        {
            return id;
        }




    }
}
