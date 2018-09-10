using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class PessoaController : Controller
    {
        public JsonResult ValidarCadastroPessoa(Pessoa pessoa)
        {
            PessoaDAO dao = new PessoaDAO();

            if (pessoa.ValidaCadastroPessoa() == true)
            {
                return Json(new { valido = true }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { valido = false }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}