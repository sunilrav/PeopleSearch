using PeopleSearch.Models.ViewModels;
using System.Web.Mvc;

namespace PeopleSearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpPost]
        public ActionResult Index(SearchViewModel searchViewModel)
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
