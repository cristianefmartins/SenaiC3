namespace ProjetoAPI.Model
{
    public class Produto
    {
        // Metodo com mesmo nome que a classe = metodo construtor
        // O construtor define o que a classe tem que fazer quando ela for instanciada 
        //atalho ctor + tab
        public Produto()
        {
            //Vai gerar um codigo pra cada produto cadastrado
            Id = Guid.NewGuid();
        }

        //atalho prop + tab
        public Guid Id { get; set; }
        // a ? significa que o nome pode ser anulavel
        public string? Nome { get; set; }
        public string? Categoria { get; set; }

    }
}
