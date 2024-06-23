using BlazorDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDatabase.Data
{
    public class AplicationDbContext:DbContext
    {
        public DbSet<Medico> medicos;
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
            
        }
    }
}
