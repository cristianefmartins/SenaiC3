using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Model;

namespace ProjetoAPI.Context
{
    public class ProdutosDbContext : DbContext
    {
        public ProdutosDbContext(DbContextOptions<ProdutosDbContext> options) : base(options) 
        {
            
        }
        //aqui estou criando as tabelas do banco
        public DbSet<Produto> Produtos => Set<Produto>();
        public DbSet<Categoria> Categorias => Set<Categoria>();

        //apagar os arquivos .db depois dessa mudanca
    }
}
