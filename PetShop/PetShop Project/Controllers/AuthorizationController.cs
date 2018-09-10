using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PetShop_Project.Controllers
{
    public class AuthorizationController : Controller
    {
        [HttpPost]
        public virtual JsonResult SignOut()
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            return Json(new { deslogar = true });
        }
    }
}