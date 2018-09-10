using PetShop_Project.DAO;
using PetShop_Project.Models;
using System.Web.Mvc;

namespace PetShop_Project.Controllers.Usuarios
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autentica(string login, string senha)
        {
            return new UsuarioController().VerificaUsuario(login, senha);
        }
    }
}