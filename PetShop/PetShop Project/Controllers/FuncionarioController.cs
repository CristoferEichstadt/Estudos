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
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaFuncionario(Usuario usuario)
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
                    }
                }
            }
            return Json(new { dadosinvalidos = true }, JsonRequestBehavior.AllowGet);
        }
    }
}