namespace LHPet.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(option)
        {

        }

        public DbSet<Ciente> Cliente{get; set;}
    }
}
