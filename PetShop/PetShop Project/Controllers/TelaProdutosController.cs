using PetShop_Project.DAO;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class TelaProdutosController : Controller
    {
        // GET: TelaProdutos
        public ActionResult Tela(int id)
        {
            SubcategoriaDAO dao = new SubcategoriaDAO();
            ViewBag.Subcategoria = dao.BuscaPorId(id);
            var s = dao.BuscaPorId(id);
            var c = s.CategoriaId;
            
            ViewBag.Subcategorias = dao.ListaSubcategorias(c);
            ProdutoDAO daoP = new ProdutoDAO();

            ViewBag.Produto = daoP.BuscaPorSub(id);

            return View();
        }
    }
}