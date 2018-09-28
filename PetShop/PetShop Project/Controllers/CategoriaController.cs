using PetShop_Project.DAO;
using PetShop_Project.Filtros;
using PetShop_Project.Models;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    [AdminFilter]
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Form()
        {
            var dao = new CategoriaDAO();

            ViewBag.Subcategoria = new Subcategoria();
            ViewBag.Categorias = dao.Lista();

            ViewBag.Categoria = new Categoria();

            return View();
        }

        [HttpPost]
        public ActionResult AdicionaCategoria(string nome)
        {
            CategoriaDAO dao = new CategoriaDAO();
            var categoria = new Categoria
            {
                Nome = nome,
                Ativo = true,
            };

            if (categoria.Valida())
            {
                dao.Adiciona(categoria);
                return RedirectToAction("Form");
            }

            return Json(new { dadosInvalidos = true }, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult AdicionaSubcategoria(string nome, int cat)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            Subcategoria sub = new Subcategoria()
            {
                Nome = nome,
                Ativo = true,
                CategoriaId = cat,
            };
            if (sub.Valida())
            {
                dao.Adiciona(sub);
                return RedirectToAction("Form");
            }

            return Json(new { dadosInvalidos = true }, JsonRequestBehavior.AllowGet);
        }

    }
}