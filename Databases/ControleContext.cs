using Microsoft.EntityFrameworkCore;
using ControleDeValidades.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using System.Windows.Forms;

namespace ControleDeValidades.Databases
{
    internal class ControleContext : DbContext
    {

        private string _connectionString;

        public DbSet<Produto> Produtos {  get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Opcoes> Opcoes { get; set; }

        public ControleContext()
        {
            string dbDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "db");
            if (!Directory.Exists(dbDiretorio))
            {
                Directory.CreateDirectory(dbDiretorio);
            }

            string PathArquivo = Path.Combine(dbDiretorio, "ControleDeValidades.mdf");
  
            _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={PathArquivo};Initial Catalog=ControleDeValidades;Integrated Security=True;Connect Timeout=30";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuAcessos>()
                .HasKey(ma => new { ma.Id_Usuario, ma.Id_Opcao });

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
                        Senha = "Admin",
                        Ativo = Convert.ToChar("Y")
                    },
                    new Usuarios
                    {
                        Nome = "Suporte",
                        Email = "Suporte@Outlook.com",
                        Senha = "Xj7hpmtmma@",
                        Ativo = Convert.ToChar("Y")
                    }
                );
                SaveChanges();
            }

            if (!Opcoes.Any())
            {
                Opcoes.AddRange(
                    new Opcoes
                    {
                        Id = 1,
                        Nome = "loginSistemaToolStripMenuItem",
                        Descricao = "Opções / Login Sistema",
                        Nivel = 2
                    },
                    new Opcoes
                    {
                        Id = 2,
                        Nome = "desconectarToolStripMenuItem",
                        Descricao = "Opções / Desconectar",
                        Nivel = 2
                    },
                    new Opcoes
                    {
                        Id = 3,
                        Nome = "produtoToolStripMenuItem1",
                        Descricao = "Cadastros / Produto",
                        Nivel = 2
                    },
                    new Opcoes
                    {
                        Id = 4,
                        Nome = "importarXMLToolStripMenuItem1",
                        Descricao = "Cadastros / Importar XML",
                        Nivel = 2
                    },
                    new Opcoes
                    {
                        Id = 5,
                        Nome = "usuáriosToolStripMenuItem",
                        Descricao = "Cadastros / Usuários",
                        Nivel = 2
                    },
                    new Opcoes
                    {
                        Id = 6,
                        Nome = "filtroProdutosToolStripMenuItem",
                        Descricao = "Janelas / Filtro Produtos",
                        Nivel = 2
                    }
                );
                SaveChanges();
            }

        }
    }
}
