﻿namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public int Id { get; set; }
        public int Quantidade { get; internal set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }
    }
}