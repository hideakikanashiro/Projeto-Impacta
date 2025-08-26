namespace AgendamentoVet.BusinessLayer.Models
{
    internal class AgendamentoModel
    {
        public int Id { get; set; }
        public string? NomeDono { get; set; }
        public string? NomePet { get; set; }
        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public string? Descricao { get; set; }
    }
}
