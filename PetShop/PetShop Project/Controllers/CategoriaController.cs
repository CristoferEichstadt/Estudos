using PetShop_Project.DAO;
using PetShop_Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PetShop_Project.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Form()
        {
            ViewBag.Categoria = new Categoria();
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaCategoria(string nome)
        {
            CategoriaDAO dao = new CategoriaDAO();
            var categoria = new Categoria
            {
                Nome = nome,
                Ativo = true
            };

            dao.Adiciona(categoria);

            return RedirectToAction("Index", "Home");
        }

    }
}