using AgendamentoVeterinaria.Domain.Entities;

namespace AgendamentoVeterinaria.Domain.Interfaces
{
    public interface IAgendamentoService
    {
        Task<List<AgendamentoConsulta>> ListarTodos();
        Task CadastrarAgendamento(AgendamentoConsulta agendamento);
    }
}
