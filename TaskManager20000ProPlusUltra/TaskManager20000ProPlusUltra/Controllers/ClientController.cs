using System.Web.Mvc;

namespace MathProCorporation.Controllers
{
    //TODO uncomment it
    //[Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        //
        // GET: /Client/
        public ActionResult Index()
        {
            return View();
        }
    }
}