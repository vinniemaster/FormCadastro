using FormCadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace FormCadastro.DAL
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<TB_CADASTRO> TB_CADASTRO { get; set; }
    }
}
