using Microsoft.EntityFrameworkCore;
using PetShop_Project.Models;

namespace PetShop_Project.DAO
{
    public class PetShopContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<FormaPagamento> FormasDePagamento { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }
        public DbSet<Models.Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendaItem>().HasKey(vi => new { vi.VendaId, vi.ProdutoId });
            base.OnModelCreating(modelBuilder); //indica que a class vendaItens tem primary key composta, 2 foreign keys

            modelBuilder.Entity<Endereco>().Property<int>("PessoaId");

            modelBuilder.Entity<Endereco>().HasKey("PessoaId");

            modelBuilder.Entity<Contato>().Property<int>("PessoaId");

            modelBuilder.Entity<Contato>().HasKey("PessoaId");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;AttachDbFilename=|DataDirectory|PetShopDB.mdf;Trusted_Connection=true;");
            }
        }
    }
}