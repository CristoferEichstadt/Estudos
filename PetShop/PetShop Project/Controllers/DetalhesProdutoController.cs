using PetShop_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class DetalhesProdutoController : Controller
    {
        // GET: DetalhesProduto
        public ActionResult Detalhes(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            ViewBag.Produto = dao.BuscaPorId(id);

            return View();
        }
    }
}