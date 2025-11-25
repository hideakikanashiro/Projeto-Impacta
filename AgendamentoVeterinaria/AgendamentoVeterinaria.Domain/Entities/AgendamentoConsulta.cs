namespace AgendamentoVeterinaria.Domain.Entities
{
    public class AgendamentoConsulta
    {
        public int Id { get; set; }
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string? NomeDono { get; set; }
        public string? NomePet { get; set; }
        public string? TipoServico { get; set; }
        public string? Observacoes { get; set; }
        public string? Status { get; set; } = "Aguardando";

        public void AvancarStatus()
        {
            Status = Status switch
            {
                "Aguardando" => "Em andamento",
                "Em andamento" => "Finalizado",
                "Finalizado" => "Finalizado",
                _ => "Aguardando"
            };
        }

        public void Finalizar()
        {
            Status = "Finalizado";
        }
    }
}
