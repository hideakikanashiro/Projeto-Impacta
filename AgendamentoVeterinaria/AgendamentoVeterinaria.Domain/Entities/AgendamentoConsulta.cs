namespace AgendamentoVeterinaria.Domain.Entities
{
    public class AgendamentoConsulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string? NomeDono { get; set; }
        public string? NomePet { get; set; }
        public string? TipoServico { get; set; }
        public string? Observacoes { get; set; } 
    }
}
