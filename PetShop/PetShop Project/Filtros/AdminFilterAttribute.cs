using PetShop_Project.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace PetShop_Project.Filtros
{
    public class AdminFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object user = filterContext.HttpContext.Session["usuarioLogado"];
            if (user == null)
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            else
            {
                var usuario = (Usuario)user;
                bool login = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName == "Login";
                if (usuario.Perfil != 'A' && usuario.Perfil != 'F' && !login)
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
                }
            }
        }

    }
}