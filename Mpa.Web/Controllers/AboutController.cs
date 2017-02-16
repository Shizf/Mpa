using System.Web.Mvc;

namespace Mpa.Web.Controllers
{
    public class AboutController : MpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}