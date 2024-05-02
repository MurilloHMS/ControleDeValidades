using Microsoft.EntityFrameworkCore;
using ControleDeValidades.Models;

namespace ControleDeValidades.Databases
{
    internal class ControleContext : DbContext
    {
       
        private string _connectionString = $@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ControleDeValidades;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public DbSet<Produto> produtos {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }
    }
}
