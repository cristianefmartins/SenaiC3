using Microsoft.EntityFrameworkCore;
using MnemosyneAPI.Model;

namespace MnemosyneAPI.Context
{
    public class MemoryDbContext : DbContext
    {
        public MemoryDbContext(DbContextOptions<MemoryDbContext> options) : base(options)
        { 
        }

        // Define a tabela 'Memories' no banco de dados
        public DbSet<Memory> Memories => Set<Memory>();
    }
}
