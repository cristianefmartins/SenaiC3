using ProjetoAPI.Model;

namespace ProjetoAPI.Repository
{
    public class ProdutoRepository
    {
        // Vetor = tem limite
        // Lista = nao tem limite, voce pode filtrar, etc
        List<Produto> listaProdutos = new()
        {
            new Produto()
            {
                Nome = "Produto 1",
                Categoria = "Categoria 1"
            },
            new Produto()
            {
                Nome = "Produto 2",
                Categoria = "Categoria 2"
            }

        };

        public List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }

    }
}
