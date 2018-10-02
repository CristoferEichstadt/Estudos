using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class EstoqueController : Controller
    {
        public ActionResult Index()
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'A' || user.Perfil == 'F')
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Error", "Error");

                }
            }
            else
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpGet]
        public ActionResult PegaEstoque()
        {
            EstoqueDAO dao = new EstoqueDAO();
            var lista = dao.Lista();

            return Json(new { data = lista}, JsonRequestBehavior.AllowGet);
        }
    }
}