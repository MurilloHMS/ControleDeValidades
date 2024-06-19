using Microsoft.EntityFrameworkCore;
using ControleDeValidades.Models;

namespace ControleDeValidades.Databases
{
    internal class ControleContext : DbContext
    {

        private string _connectionString;

        public DbSet<Produto> Produtos {  get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Opcoes> Opcoes { get; set; }
        public DbSet<MenuAcessos> menuAcessos { get; set; }

        public ControleContext()
        {
            string dbDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "db");
            if (!Directory.Exists(dbDiretorio))
            {
                Directory.CreateDirectory(dbDiretorio);
            }

            string PathArquivo = Path.Combine(dbDiretorio, "ControleDeValidades.db");

            //_connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={PathArquivo};Initial Catalog=ControleDeValidades;Integrated Security=True;Connect Timeout=30";
            _connectionString = $"Data Source = {PathArquivo};Cache=Shared";        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(_connectionString).UseLazyLoadingProxies();


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
                        Ativo = 'T'
                    },
                    new Usuarios
                    {
                        Nome = "Suporte",
                        Email = "Suporte@Outlook.com",
                        Senha = "Xj7hpmtmma@",
                        Ativo = 'T'
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

            if (!menuAcessos.Any()) 
            {
                menuAcessos.AddRange(
                    new MenuAcessos 
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 1,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 2,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 3,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 4,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 5,
                        ID = 1,
                        Liberado = 'T'

                    },
                    new MenuAcessos
                    {
                        Id_Usuario = 1,
                        Id_Opcao = 6,
                        ID = 1,
                        Liberado = 'T'

                    }

                );
                SaveChanges();
            }


        }
    }
}
