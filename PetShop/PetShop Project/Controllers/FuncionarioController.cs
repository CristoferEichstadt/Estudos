using PetShop_Project.DAO;
using PetShop_Project.Models;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Form()
        {
            ViewBag.Usuario = new Usuario();
            ViewBag.Usuario.Pessoa = new Pessoa();

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
        public ActionResult AdicionaFuncionario(Models.Usuario usuario)
        {
            DAO.UsuarioDAO dao = new DAO.UsuarioDAO();
            var pessoa = usuario.Pessoa;
            var pessoaController = new PessoaController();

            if (usuario.Valida())
            {
                if (pessoaController.ValidarCadastroPessoaFisica(pessoa) == true)
                {
                    dao.Adiciona(usuario);
                }
            }
            return Json(new { dadosinvalidos = true }, JsonRequestBehavior.AllowGet);

        }
        public JsonResult VerificaCpfFuncionarioNoBanco(string cpf)
        {
            PessoaDAO dao = new PessoaDAO();
            return Json(new { existeCpf = dao.BuscaPorCpfCnpj(cpf) }, JsonRequestBehavior.AllowGet);
        }

    }
}