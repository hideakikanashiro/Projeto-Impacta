using AgendamentoVeterinaria.Domain.Entities;

namespace AgendamentoVeterinaria.Domain.Interfaces
{
    public interface IAgendamentoService
    {
        Task<List<AgendamentoConsulta>> ListarTodos();
        Task<AgendamentoConsulta?> BuscarPorId(int id);
        Task CadastrarAgendamento(AgendamentoConsulta agendamento);
        Task Atualizar(AgendamentoConsulta agendamento);
        Task Excluir(int id);
    }
}
