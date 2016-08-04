using Microsoft.AspNetCore.Mvc;

namespace BPE.Web.Controllers
{
    public class HomeController : BPEControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}