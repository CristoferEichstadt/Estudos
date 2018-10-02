using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Web.Mvc;
using UsuarioDAO = PetShop_Project.DAO.UsuarioDAO;

namespace PetShop_Project.Controllers
{
    public class MinhaContaController : Controller
    {
        public ActionResult Index()
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'C')
                {
                    PessoaDAO dao = new PessoaDAO();
                    var usuarioLogado = dao.BuscaPorUsuario(user.Id);
                    ViewBag.PessoaFisica = usuarioLogado.TipoPessoa == 'F';
                    ViewBag.PessoaJuridica = usuarioLogado.TipoPessoa == 'J';

                    var data = usuarioLogado.DataNascimento;


                    ViewBag.DataNascimento = data.ToString("yyyy'-'MM'-'dd");

                    ViewBag.Usuario = user;
                    ViewBag.Pessoa = usuarioLogado;

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
        public ActionResult AlteraDados(string nome, string cpf, DateTime dataNascimento, string email, string senha)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'C')
                {
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
        public ActionResult AlteraEndereco(string logradouro, string cep, string numero, string estado, string referencia, string bairro, string complemento, string cidade)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'C')
                {
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
        public ActionResult AlteraContatos(string email2, string celular, string telefone)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'C')
                {
                    user.Pessoa.Contato.Email = email2;
                    user.Pessoa.Contato.Celular = celular;
                    user.Pessoa.Contato.Telefone = telefone;

                    var dao = new UsuarioDAO();
                    dao.Atualiza(user);

                    return RedirectToAction("Index");
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
        public ActionResult AlteraDadosJuridicos(string email, string senhaJuridica, string razaoSocial, string inscricaoEstadual, string nomeFantasia)
        {
            var user = (Usuario)HttpContext.Session["usuarioLogado"];
            if (user != null)
            {
                if (user.Perfil == 'C')
                {
                    PessoaDAO dao = new PessoaDAO();
                    UsuarioDAO daoUser = new UsuarioDAO();

                    var usuarioLogado = dao.BuscaPorUsuario(user.Id);

                    user.Email = email;
                    user.Senha = senhaJuridica;
                    daoUser.Atualiza(user);

                    usuarioLogado.RazaoSocial = razaoSocial;
                    usuarioLogado.NomeFantasia = nomeFantasia;
                    usuarioLogado.InscricaoEstadual = inscricaoEstadual;

                    dao.Atualiza(usuarioLogado);

                    return RedirectToAction("Index");
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

    }
}