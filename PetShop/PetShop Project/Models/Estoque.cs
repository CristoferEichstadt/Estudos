﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int TipoMovimentacao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}