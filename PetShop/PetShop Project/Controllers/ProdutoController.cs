using PetShop_Project.DAO;
using PetShop_Project.Filtros;
using PetShop_Project.Models;
using System;
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

            ProdutoDAO daoP = new ProdutoDAO();
            ViewBag.Estoque = new Estoque();
            ViewBag.Estoque.Produto = new Produto();

            return View();
        }

        public ActionResult PopulaSubcategorias(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();

            return Json(new { lista = dao.ListaSubcategorias(id) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adiciona(Estoque estoque, int cat, int sub)
        {
            EstoqueDAO dao = new EstoqueDAO();
            //Produto produto = new Produto
            //{
            //    CategoriaId = cat,
            //    SubcategoriaId = sub,
            //    Nome = nome,
            //    MargemLucro = margemlucro,
            //    Quantidade = quantidade,
            //    DataInsercao = DateTime.Now,
            //    ValorCusto = valorcusto,
            //    ValorUnitario = valoruni
            //};
            

            if (estoque != null)
            {
                estoque.Produto.CategoriaId = cat;
                estoque.Produto.SubcategoriaId = sub;
                estoque.Produto.DataInsercao = DateTime.Now;
                estoque.TipoMovimentacao = 1;
                dao.Adiciona(estoque);
                return RedirectToAction("Form");

            }
            else
            {
                return RedirectToAction("Form");
            }
        }


    }
}
