using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Model;

namespace ProjetoAPI.Context
{
    public class ProdutoDbContext : DbContext
    {
        //Metodo construtor tem o mesmo nome da classe
        //base ta referenciando
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options) 
        {
            
        }

        //defino quais as tabelas meu banco vai ter
        public DbSet<Produto> Produtos => Set<Produto>();
    }
}

