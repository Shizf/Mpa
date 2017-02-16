using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Mpa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}