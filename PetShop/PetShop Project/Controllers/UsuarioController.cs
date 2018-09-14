using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form()
        {
            ViewBag.Usuario = new Usuario();
            ViewBag.Usuario.Pessoa = new Pessoa();
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(Usuario usuario)
        {
            UsuarioDAO dao = new UsuarioDAO();
            var pessoa = usuario.Pessoa;
            var pessoaController = new PessoaController();

            if (usuario.Valida())
            {
                if (pessoa.TipoPessoa == 'F')
                {
                    if (pessoaController.ValidarCadastroPessoaFisica(pessoa) == true)
                    {
                        dao.Adiciona(usuario);
                        System.Web.HttpContext.Current.Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "Home");
                    }
                }
                else if (pessoa.TipoPessoa == 'J')
                {
                    if (pessoaController.ValidarCadastroPessoaJuridica(pessoa) == true)
                    {
                        dao.Adiciona(usuario);
                        System.Web.HttpContext.Current.Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return Json(new { dadosinvalidos = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult UsuarioLogOut()
        {
            System.Web.HttpContext.Current.Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult VerificaUsuario(string login, string senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Busca(login, senha);

            if (usuario != null)
            {
                System.Web.HttpContext.Current.Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }
        }
        public JsonResult VerificaCpfNoBanco(string cpf)
        {
            PessoaDAO dao = new PessoaDAO();
            return Json(new { existeCpf = dao.BuscaPorCpfCnpj(cpf) }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult VerificaCnpjNoBanco(string cnpj)
        {
            PessoaDAO dao = new PessoaDAO();
            return Json(new { existeCnpj = dao.BuscaPorCpfCnpj(cnpj) }, JsonRequestBehavior.AllowGet);
        }

    }
}