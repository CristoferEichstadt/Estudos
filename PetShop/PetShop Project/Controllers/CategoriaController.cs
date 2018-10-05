using PetShop_Project.DAO;
using PetShop_Project.Models;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{

    public class CategoriaController : Controller
    {
        public ActionResult Form()
        {
            ViewBag.Categoria = new Categoria();

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

        public ActionResult PegaCategorias()
        {
            CategoriaDAO dao = new CategoriaDAO();
            var lista = dao.Lista();

            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Status(int id)
        {
            CategoriaDAO dao = new CategoriaDAO();
            dao.AlternaAtivo(id);
            return Json(new { mudou = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Editar(int id)
        {
            CategoriaDAO dao = new CategoriaDAO();
            ViewBag.Categoria = dao.BuscaPorId(id);


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

        public ActionResult EditaCategoria(Categoria categoria)
        {
            CategoriaDAO dao = new CategoriaDAO();

            dao.Atualiza(categoria);

            return RedirectToAction("Index");
        }

        public JsonResult VerificaCategoriaNoBanco(string nome)
        {
            CategoriaDAO dao = new CategoriaDAO();
            return Json(new { existe = dao.BuscaPorNome(nome) }, JsonRequestBehavior.AllowGet);
        }
    }
}