using Microsoft.EntityFrameworkCore;
using ControleDeValidades.Models;
using System;
using System.IO;
using System.Linq;

namespace ControleDeValidades.Databases
{
    internal class ControleContext : DbContext
    {

        private string _connectionString;

        public DbSet<Produto> Produtos {  get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        public ControleContext()
        {
            string dbDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "db");
            if (!Directory.Exists(dbDiretorio))
            {
                Directory.CreateDirectory(dbDiretorio);
            }

            string PathArquivo = Path.Combine(dbDiretorio, "ControleDeValidadesPrimulla.mdf");
  
            _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={PathArquivo};Database=ControleDeValidades;Integrated Security=True;Connect Timeout=30";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void VerificarBanco()
        {
            try
            {
                Database.EnsureCreated();
                PreencherDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar ou popular o banco de dados:");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }


        }

        private void PreencherDados()
        {
            if (!Usuarios.Any())
            {
                Usuarios.AddRange(
                    new Usuarios
                    {
                        Nome = "Admin",
                        Email = "admin@outlook.com",
                        Senha = "Admin"
                    },
                    new Usuarios
                    {
                        Nome = "Suporte",
                        Email = "Suporte@Outlook.com",
                        Senha = "Xj7hpmtmma@"
                    }
                );
                SaveChanges();
            }
        }
    }
}
