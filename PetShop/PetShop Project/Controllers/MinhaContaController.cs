using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Web.Mvc;
using System.Web.Security;
using UsuarioDAO = PetShop_Project.DAO.UsuarioDAO;

namespace PetShop_Project.Controllers
{
    public class MinhaContaController : Controller
    {
        public ActionResult Index()
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];

            PessoaDAO dao = new PessoaDAO();
            var usuarioLogado = dao.BuscaPorUsuario(user.Id);
            ViewBag.PessoaFisica = usuarioLogado.TipoPessoa == 'F';
            ViewBag.PessoaJuridica = usuarioLogado.TipoPessoa == 'J';

            ViewBag.Usuario = user;
            ViewBag.Pessoa = usuarioLogado;


            return View();
        }

        [HttpPost]
        public ActionResult AlteraDados(string nome, string cpf, DateTime dataNascimento, string email, string senha)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];

            PessoaDAO dao = new PessoaDAO();
            UsuarioDAO daoUser = new UsuarioDAO();

            var usuarioLogado = dao.BuscaPorUsuario(user.Id);

            user.Email = email;
            user.Senha = senha;
            daoUser.Atualiza(user);

            usuarioLogado.Nome = nome;
            usuarioLogado.CpfCnpj = cpf;
            usuarioLogado.DataNascimento = dataNascimento;

            dao.Atualiza(usuarioLogado);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AlteraEndereco(string logradouro, string cep, string numero, string estado, string referencia, string bairro, string complemento, string cidade)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];

            user.Pessoa.Endereco.Logradouro = logradouro;
            user.Pessoa.Endereco.Cep = cep;
            user.Pessoa.Endereco.Numero = numero;
            user.Pessoa.Endereco.Estado = estado;
            user.Pessoa.Endereco.Referencia = referencia;
            user.Pessoa.Endereco.Bairro = bairro;
            user.Pessoa.Endereco.Complemento = complemento;
            user.Pessoa.Endereco.Cidade = cidade;


            var dao = new UsuarioDAO();
            dao.Atualiza(user);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AlteraContatos(string email2, string celular, string telefone)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];

            user.Pessoa.Contato.Email = email2;
            user.Pessoa.Contato.Celular = celular;
            user.Pessoa.Contato.Telefone = telefone;

            var dao = new UsuarioDAO();
            dao.Atualiza(user);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult AlteraDadosJuridicos()
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];




            return RedirectToAction("Index");
        }

    }
}