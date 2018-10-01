using PetShop_Project.DAO;
using PetShop_Project.Filtros;
using PetShop_Project.Models;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    [AdminFilter]
    public class SubcategoriaController : Controller
    {
        public ActionResult Form(int id)
        {
            var dao = new CategoriaDAO();
            ViewBag.Categorias = dao.BuscaPorId(id);
            ViewBag.Subcategoria = new Subcategoria();
            return View();
        }
        public ActionResult MostraSubs(int id)
        {
            CategoriaDAO dao = new CategoriaDAO();
            ViewBag.IdCategoria = id;
            ViewBag.Categoria = dao.BuscaPorId(id);
            return View();
        }

        public ActionResult pegaSubs(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            var lista = dao.ListaSubcategorias(id);

            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult AdicionaSubcategoria(int catId, string nome)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            Subcategoria sub = new Subcategoria()
            {
                Nome = nome,
                Ativo = true,
                CategoriaId = catId,
            };

            dao.Adiciona(sub);
            return RedirectToAction("Index", "Categoria");

        }

        public JsonResult Status(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            dao.AlternaAtivo(id);
            return Json(new { mudou = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Editar(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            ViewBag.Subcategoria = dao.BuscaPorId(id);
            var s = dao.BuscaPorId(id);

            CategoriaDAO daoC = new CategoriaDAO();
            ViewBag.Categoria = daoC.BuscaPorId(s.CategoriaId);

            return View();
        }

        public ActionResult EditaSubcategoria(int catId, string nome, int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            Subcategoria sub = new Subcategoria()
            {
                Id = id,
                Nome = nome,
                Ativo = true,
                CategoriaId = catId,
            };
            dao.Atualiza(sub);
            return RedirectToAction("Index", "Categoria");
        }
    }

}