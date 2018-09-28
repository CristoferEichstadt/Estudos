using PetShop_Project.DAO;
using PetShop_Project.Models;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Form()
        {
            ViewBag.Usuario = new Usuario();
            ViewBag.Usuario.Pessoa = new Pessoa();
            return View();
        }


        [HttpPost]
        public ActionResult AdicionaUsuario(Usuario usuario, Endereco endereco, Contato contato)
        {
            UsuarioDAO dao = new UsuarioDAO();
            var pessoa = usuario.Pessoa;
            pessoa.Endereco = endereco;
            pessoa.Contato = contato;

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

        public ActionResult VerificaUsuario(string email, string senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Busca(email, senha);

            if (usuario != null)
            {
                System.Web.HttpContext.Current.Session["usuarioLogado"] = usuario;

                if (usuario.Perfil == 'C')
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (usuario.Perfil == 'A')
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (usuario.Perfil == 'F')
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    System.Web.HttpContext.Current.Session.Abandon();
                    return RedirectToAction("Index", "Login");
                }
            }
            else
            {
                return RedirectToAction("Index");
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