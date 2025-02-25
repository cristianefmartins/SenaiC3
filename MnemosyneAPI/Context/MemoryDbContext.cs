using Microsoft.EntityFrameworkCore;
using MnemosyneAPI.Model;

namespace MnemosyneAPI.Context
{
    public class MemoryDbContext
    {
        public MemoryDbContext(DbContextOptions<MemoryDbContext> options) : base(options)
        { 
        }

        // Define a tabela 'Produtos' no banco de dados
      public DbSet<Memory> Produtos => Set<Memory>();
    }
}
