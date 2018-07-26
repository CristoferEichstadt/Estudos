using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; } //DbSet monitora a classe Produto e cria uma tabela automaticamente
                                                     //a partir dos atributos da classe Produto, a tabela recebe o nome de Produtos;
        public LojaContext() 
        { }
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }
        }
    }
}