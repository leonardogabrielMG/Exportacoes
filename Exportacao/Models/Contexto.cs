using Microsoft.EntityFrameworkCore;

namespace Exportacao.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Container> Container { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
    }
}
