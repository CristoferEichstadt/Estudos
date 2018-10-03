using PetShop_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class VerTodasCategoriasController : Controller
    {
        // GET: VerTodasCategorias
        public ActionResult TodasCategorias()
        {
            CategoriaDAO dao = new CategoriaDAO();
            ViewBag.Categorias = dao.Lista();
            return View();
        }
    }
}