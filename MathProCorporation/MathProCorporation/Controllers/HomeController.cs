using System.Web.Mvc;

namespace MathProCorporation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are happy that you are interested in our awesome service. Stay tuned! :)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We encourage you to contact our technical support operator if you have any questions";

            return View();
        }
    }
}