using System.Web.Mvc;

namespace WithVueJs2.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Title = "The VueJs App!";
      return View();
    }
  }
}