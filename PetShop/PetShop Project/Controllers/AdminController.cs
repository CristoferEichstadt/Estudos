using PetShop_Project.Models;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
    }
}