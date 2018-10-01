using PetShop_Project.DAO;
using PetShop_Project.Filtros;
using PetShop_Project.Models;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    [AdminFilter]
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Form()
        {
            ViewBag.Usuario = new Models.Usuario();
            ViewBag.Usuario.Pessoa = new Pessoa();
            return View();
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