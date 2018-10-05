using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{

    public class ProdutoController : Controller
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

        public ActionResult Form()
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'A' || user.Perfil == 'F')
                {
                    CategoriaDAO dao = new CategoriaDAO();
                    ViewBag.Categorias = dao.Lista();

                    ViewBag.Estoque = new Estoque();
                    ViewBag.Estoque.Produto = new Produto();

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

        public ActionResult PopulaSubcategorias(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();

            return Json(new { lista = dao.ListaSubcategorias(id) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adiciona(Estoque estoque, int cat, int sub, HttpPostedFileBase upload, int quantidade)
        {
            EstoqueDAO dao = new EstoqueDAO();

            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'A' || user.Perfil == 'F')
                {
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
        public ActionResult PegaProdutos()
        {
            ProdutoDAO dao = new ProdutoDAO();
            var lista = dao.Lista();

            JsonResult js = Json(new { data = lista }, JsonRequestBehavior.AllowGet);
            js.MaxJsonLength = int.MaxValue;
            return js;
        }

        public ActionResult Editar(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            ViewBag.Produto = dao.BuscaPorId(id);

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

        public ActionResult EditaProduto(Produto produto/*, HttpPostedFileBase upload*/)
        {
            ProdutoDAO dao = new ProdutoDAO();
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'A' || user.Perfil == 'F')
                {

                    //if (upload != null && upload.ContentLength > 0)
                    //{
                    //    using (System.IO.Stream inputStream = upload.InputStream)
                    //    {
                    //        System.IO.MemoryStream memoryStream = inputStream as System.IO.MemoryStream;
                    //        if (memoryStream == null)
                    //        {
                    //            memoryStream = new System.IO.MemoryStream();
                    //            inputStream.CopyTo(memoryStream);

                    //        }
                    //        produto.Imagem = memoryStream.ToArray();
                    //    }
                    //}
                    dao.Atualiza(produto);

                    return RedirectToAction("Index", "Produto");
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

        public JsonResult Status(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.AlternaAtivo(id);
            return Json(new { mudou = true }, JsonRequestBehavior.AllowGet);
        }


    }

}

