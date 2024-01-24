using Exames_Clinpop.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Exames_Clinpop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exame>().HasData(
                    new Exame
                    {
                        ExameId = 1,
                        NomeExame = "V.D.R.L",
                        DescricaoExame = "Exame de Sangue",
                        Preco = 6.00m
                    });

        }

        public DbSet<Exame> Exames { get; set; }
    }
}

