using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class CarrinhoController : Controller
    {
        public ActionResult Index()
        {
            var carrinho = Session["carrinho"] as Venda;

            if (carrinho == null)
            {
                carrinho = new Venda();
            }

            var dao = new ProdutoDAO();

            foreach (var item in carrinho.VendaItens)
            {
                item.Produto = dao.BuscaPorId(item.ProdutoId);
            }


            Session["carrinho"] = carrinho;

            return View(carrinho);
        }

        public ActionResult AdicionaItem(int id, int qtd)
        {
            var carrinho = Session["carrinho"] as Venda;

            if (carrinho == null)
            {
                carrinho = new Venda();
            }

            carrinho.VendaItens.Add(new VendaItem()
            {
                ProdutoId = id,
                Quantidade = qtd
            });

            Session["carrinho"] = carrinho;

            return Json(new { adicionou = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RemoveItem(int id)
        {
            var carrinho = Session["carrinho"] as Venda;


            var itemParaRemover = carrinho.VendaItens.FirstOrDefault(i => i.ProdutoId == id);
            carrinho.VendaItens.Remove(itemParaRemover);

            carrinho = Session["carrinho"] as Venda;

            return Json(new { removeu = true }, JsonRequestBehavior.AllowGet);
        }

    }
}