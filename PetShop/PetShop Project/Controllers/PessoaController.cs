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
        public bool ValidarCadastroPessoaFisica(Pessoa pessoa)
        {
            return pessoa.ValidaCadastroPessoaFisica();
        }

        public bool ValidarCadastroPessoaJuridica(Pessoa pessoa)
        {
            return pessoa.ValidaCadastroPessoaJuridica();
        }
    }
}