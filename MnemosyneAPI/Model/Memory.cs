namespace MnemosyneAPI.Model
{
    public class Memory
    {
        public Memory()
        {

        }

        public int Id { get; set; }
        // a ? significa que o nome pode ser anulavel
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public List<string>? Images { get; set; }
    }
}
