
using Microsoft.EntityFrameworkCore;

namespace Tabela.Data
{
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    // DbSets personalizados, se quiser adicionar depois
    // public DbSet<Algo> Algos { get; set; }
}
}
