using PetShop_Project.Filtros;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    //[AdminFilter]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}