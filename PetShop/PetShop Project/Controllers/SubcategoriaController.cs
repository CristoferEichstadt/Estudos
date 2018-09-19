using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class SubcategoriaController : Controller
    {
        // GET: Subcategoria
        public ActionResult Form()
        {
            var dao = new CategoriaDAO();

            ViewBag.Subcategoria = new Subcategoria();
            ViewBag.Categorias = dao.Lista();
            return View();
        }

        public ActionResult AdicionaSubcategoria(string nome, int categoria)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            Subcategoria sub = new Subcategoria()
            {
                Nome = nome,
                Ativo = true,
                CategoriaId = categoria
            };

            dao.Adiciona(sub);

            return RedirectToAction("Form");

        }

    }
}