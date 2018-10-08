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

            PopulaItens(carrinho);

            Session["carrinho"] = carrinho;

            return View(carrinho);
        }

        public ActionResult AdicionaItem(int id)
        {
            var carrinho = Session["carrinho"] as Venda;

            if (carrinho == null)
            {
                carrinho = new Venda();
            }

            var temproduto = false;
            foreach (var item in carrinho.VendaItens)
            {
                if (item.ProdutoId == id)
                {
                    temproduto = true;
                    break;
                }
            }

            if (!temproduto)
            {
                carrinho.VendaItens.Add(new VendaItem()
                {
                    ProdutoId = id,
                    Quantidade = 1
                });
            }
            else
            {
                carrinho.VendaItens.Where(vi => vi.ProdutoId == id).FirstOrDefault().Quantidade++;
            }


            AtualizaTotal(carrinho);

            Session["carrinho"] = carrinho;

            return Json(new { adicionou = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RemoveItem(int id)
        {
            var carrinho = Session["carrinho"] as Venda;

            var itemParaRemover = carrinho.VendaItens.FirstOrDefault(i => i.ProdutoId == id);
            carrinho.VendaItens.Remove(itemParaRemover);

            double novoTotal = AtualizaTotal(carrinho);

            carrinho = Session["carrinho"] as Venda;

            return Json(new { removeu = true, novoTotal }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AtualizaQuantidade(int id, int quantidade)
        {
            try
            {
                var carrinho = Session["carrinho"] as Venda;
                var produto = carrinho.VendaItens.Where(vi => vi.ProdutoId == id).FirstOrDefault();
                produto.Quantidade = quantidade;
                double novoTotal = AtualizaTotal(carrinho);
                Session["carrinho"] = carrinho;
                return Json(new { atualizou = true, subtotal = Math.Round(produto.Quantidade * produto.Produto.ValorUnitario, 2), novoTotal }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { atualizou = false, msg = e.Message }, JsonRequestBehavior.AllowGet);
            }

        }

        private double AtualizaTotal(Venda venda)
        {
            venda.ValorTotal = 0;
            PopulaItens(venda);
            foreach (var item in venda.VendaItens)
            {
                venda.ValorTotal += item.Quantidade * item.Produto.ValorUnitario;
            }
            venda.ValorTotal = Math.Round(venda.ValorTotal, 2);
            return venda.ValorTotal;
        }

        private void PopulaItens(Venda venda)
        {
            var dao = new ProdutoDAO();
            foreach (var item in venda.VendaItens)
            {
                item.Produto = dao.BuscaPorId(item.ProdutoId);
            }
        }

        public ActionResult Checkout()
        {
            var user = HttpContext.Session["usuarioLogado"] as Usuario;
            var carrinho = Session["carrinho"] as Venda;

            ViewBag.Usuario = user;

            PopulaItens(carrinho);
            ViewBag.Carrinho = carrinho;
            if (user != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult ProcessaVenda()
        {
            VendaDAO vendaDao = new VendaDAO();
            EstoqueDAO estoqueDao = new EstoqueDAO();

            var user = HttpContext.Session["usuarioLogado"] as Usuario;
            var venda = Session["carrinho"] as Venda;


            venda.UsuarioId = user.Id;
            venda.FormaPagamentoId = 1;
            venda.DataVenda = DateTime.Today;

            ProdutoDAO pdao = new ProdutoDAO();

            foreach (var item in venda.VendaItens)
            {
                var produto = pdao.BuscaPorId(item.ProdutoId);
                produto.Quantidade -= item.Quantidade;
                pdao.Atualiza(produto);

                var estoque = new Estoque()
                {
                    ProdutoId = item.ProdutoId,
                    Quantidade = item.Quantidade,
                    UsuarioAlteracaoId = user.Id,
                    DataAlteracao = DateTime.Today,
                    TipoMovimentacao = 2
                };
                estoqueDao.Adiciona(estoque);
                //vendaDao.Adiciona(venda);

                ViewBag.Venda = true;
            }

            Session["carrinho"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}