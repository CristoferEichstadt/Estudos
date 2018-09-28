using PetShop_Project.DAO;
using PetShop_Project.Filtros;
using PetShop_Project.Models;
using System;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    [AdminFilter]
    public class ProdutoController : Controller
    {
        public ActionResult Form()
        {
            CategoriaDAO dao = new CategoriaDAO();
            ViewBag.Categorias = dao.Lista();

            ViewBag.Estoque = new Estoque();
            ViewBag.Estoque.Produto = new Produto();

            return View();
        }

        public ActionResult PopulaSubcategorias(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();

            return Json(new { lista = dao.ListaSubcategorias(id) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adiciona(Estoque estoque, int cat, int sub, HttpPostedFileBase upload)
        {
            EstoqueDAO dao = new EstoqueDAO();

            if (upload != null && upload.ContentLength > 0 && estoque != null)
            {
                using (System.IO.Stream inputStream = upload.InputStream)
                {
                    System.IO.MemoryStream memoryStream = inputStream as System.IO.MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new System.IO.MemoryStream();
                        inputStream.CopyTo(memoryStream);
                    }
                    estoque.Produto.Imagem = memoryStream.ToArray();
                    estoque.Produto.CategoriaId = cat;
                    estoque.Produto.SubcategoriaId = sub;
                    estoque.Produto.DataInsercao = DateTime.Now;
                    estoque.TipoMovimentacao = 1;
                    dao.Adiciona(estoque);
                    return RedirectToAction("Form");
                }
            }
            else
            {
                return RedirectToAction("Form");
            }

        }


    }
}
