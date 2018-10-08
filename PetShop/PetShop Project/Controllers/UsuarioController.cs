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

            if (usuario != null && usuario.Ativo != false)
            {
                System.Web.HttpContext.Current.Session["usuarioLogado"] = usuario;

                if (usuario.Perfil == 'C')
                {
                    if (System.Web.HttpContext.Current.Session["carrinho"] as Venda != null)
                    {
                        return RedirectToAction("Checkout", "Carrinho");
                    }

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

        [HttpGet]
        public ActionResult pegaUsuarios()
        {
            UsuarioDAO dao = new UsuarioDAO();
            var lista = dao.Lista();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Status(int id)
        {
            UsuarioDAO dao = new UsuarioDAO();
            dao.AlternaAtivo(id);
            return Json(new { mudou = true }, JsonRequestBehavior.AllowGet);
        }

    }
}