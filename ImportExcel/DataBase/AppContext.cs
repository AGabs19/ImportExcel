using ImportExcel.Models;
using Microsoft.EntityFrameworkCore;

namespace ImportExcel.DataBase
{

    public class AppContext : DbContext //Ele vai encapsular
    {
        public AppContext(DbContextOptions<AppContext>options) : base(options)
        {
            //Conexão com meu Banco de Dados, ligada ao meu Program.cs e appsettings.json
        }
        public AppContext()
        {

        }

        public DbSet<Autorizacao> Autorizacao{ get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<PeriodoAquisitivo> PeriodoAquisitivo { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
       


    }
}
/* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", false, true)
                .Build();
           optionsBuilder.UseSqlServer(configuration.GetConnectionString("FeriasApp"));
       }*/
