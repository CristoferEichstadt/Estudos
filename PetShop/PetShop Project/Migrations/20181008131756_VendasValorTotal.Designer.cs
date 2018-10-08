﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop_Project.DAO;

namespace PetShop_Project.Migrations
{
    [DbContext(typeof(PetShopContext))]
    [Migration("20181008131756_VendasValorTotal")]
    partial class VendasValorTotal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetShop_Project.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("PetShop_Project.Models.Contato", b =>
                {
                    b.Property<int>("PessoaId");

                    b.Property<string>("Celular");

                    b.Property<string>("Email");

                    b.Property<string>("Telefone");

                    b.HasKey("PessoaId");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("PetShop_Project.Models.Endereco", b =>
                {
                    b.Property<int>("PessoaId");

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<string>("Referencia");

                    b.HasKey("PessoaId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("PetShop_Project.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<int>("TipoMovimentacao");

                    b.Property<int?>("UsuarioAlteracaoId");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsuarioAlteracaoId");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("PetShop_Project.Models.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("FormasDePagamento");
                });

            modelBuilder.Entity("PetShop_Project.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfCnpj");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("InscricaoEstadual");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("PetShop_Project.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CategoriaId");

                    b.Property<DateTime>("DataInsercao");

                    b.Property<string>("Descricao");

                    b.Property<byte[]>("Imagem");

                    b.Property<double>("MargemLucro");

                    b.Property<string>("Nome");

                    b.Property<int>("Quantidade");

                    b.Property<int>("SubcategoriaId");

                    b.Property<double>("ValorCusto");

                    b.Property<double>("ValorUnitario");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("SubcategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("PetShop_Project.Models.Subcategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Subcategorias");
                });

            modelBuilder.Entity("PetShop_Project.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Email");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int?>("PessoaId");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PetShop_Project.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataVenda");

                    b.Property<int?>("FormaPagamentoId");

                    b.Property<int?>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("PetShop_Project.Models.VendaItem", b =>
                {
                    b.Property<int>("VendaId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("VendaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("VendaItem");
                });

            modelBuilder.Entity("PetShop_Project.Models.Contato", b =>
                {
                    b.HasOne("PetShop_Project.Models.Pessoa", "Pessoa")
                        .WithOne("Contato")
                        .HasForeignKey("PetShop_Project.Models.Contato", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetShop_Project.Models.Endereco", b =>
                {
                    b.HasOne("PetShop_Project.Models.Pessoa", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("PetShop_Project.Models.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetShop_Project.Models.Estoque", b =>
                {
                    b.HasOne("PetShop_Project.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("PetShop_Project.Models.Usuario", "UsuarioAlteracao")
                        .WithMany()
                        .HasForeignKey("UsuarioAlteracaoId");
                });

            modelBuilder.Entity("PetShop_Project.Models.Produto", b =>
                {
                    b.HasOne("PetShop_Project.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PetShop_Project.Models.Subcategoria", "Subcategoria")
                        .WithMany()
                        .HasForeignKey("SubcategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetShop_Project.Models.Subcategoria", b =>
                {
                    b.HasOne("PetShop_Project.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetShop_Project.Models.Usuario", b =>
                {
                    b.HasOne("PetShop_Project.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("PetShop_Project.Models.Venda", b =>
                {
                    b.HasOne("PetShop_Project.Models.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId");

                    b.HasOne("PetShop_Project.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PetShop_Project.Models.VendaItem", b =>
                {
                    b.HasOne("PetShop_Project.Models.Produto", "Produto")
                        .WithMany("VendaItens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PetShop_Project.Models.Venda", "Venda")
                        .WithMany("VendaItens")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
