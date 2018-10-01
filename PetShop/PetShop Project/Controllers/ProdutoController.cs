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
        public ActionResult Index()
        {
            return View();
        }

        public object ProdutosDAO { get; private set; }

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

        public ActionResult Adiciona(Estoque estoque, int cat, int sub, HttpPostedFileBase upload, int quantidade)
        {
            EstoqueDAO dao = new EstoqueDAO();

            if (upload != null && upload.ContentLength > 0)
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
                    estoque.Produto.Quantidade = quantidade;
                    estoque.Quantidade = quantidade;
                    dao.Adiciona(estoque);
                    return RedirectToAction("Form");
                }
            }
            else
            {
                return RedirectToAction("Form");
            }

        }

        [HttpGet]
        public ActionResult PegaProdutos()
        {
            ProdutoDAO dao = new ProdutoDAO();
            var lista = dao.Lista();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Editar(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            ViewBag.Produto = dao.BuscaPorId(id);

            return View();
        }

        public ActionResult EditaProduto(Produto produto, HttpPostedFileBase upload, int quantidade)
        {
            ProdutoDAO dao = new ProdutoDAO();

            var user = (Usuario)HttpContext.Session["usuarioLogado"];

            if (upload != null && upload.ContentLength > 0)
            {
                using (System.IO.Stream inputStream = upload.InputStream)
                {
                    System.IO.MemoryStream memoryStream = inputStream as System.IO.MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new System.IO.MemoryStream();
                        inputStream.CopyTo(memoryStream);

                    }
                    produto.Imagem = memoryStream.ToArray();
                }
            }

            Estoque estoque = new Estoque();
            EstoqueDAO daoEst = new EstoqueDAO();


            estoque.UsuarioAlteracaoId = user.Id;
            estoque.DataAlteracao = DateTime.Now;
            estoque.ProdutoId = produto.Id;
            produto.Quantidade = quantidade;
            estoque.Quantidade = quantidade;


            dao.Atualiza(produto);
            daoEst.Adiciona(estoque);

            return RedirectToAction("Index", "Produto");
        }


        public JsonResult Status(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.AlternaAtivo(id);
            return Json(new { mudou = true }, JsonRequestBehavior.AllowGet);
        }


    }

}

